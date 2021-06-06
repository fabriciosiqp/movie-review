using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieReview.API.Helpers;
using MovieReview.API.Interfaces;
using MovieReview.API.Models;
using MovieReview.Application.Dtos;
using MovieReview.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace MovieReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieAppService _movieAppService;
        private readonly IUriService _uriService;

        public MovieController(IMovieAppService movieAppService, IUriService uriService)
        {
            _movieAppService = movieAppService;
            _uriService = uriService;
        }

        /// <summary>
        ///  Get all movies
        /// </summary>
        /// <response code="200">The movie list was successfully obtained.</response>
        /// <response code="500">There was an error fetching the movie list.</response>
        [HttpGet]
        [AllowAnonymous]
        public PagedResponse<List<MovieResponse>> Get([FromQuery] MovieSearch searchTerms)
        {
            var filters = searchTerms.Filters();

            List<MovieResponse> movies = (List<MovieResponse>)_movieAppService.GetAll(searchTerms.PageIndex, searchTerms.PageSize, filters);

            var totalRecords = _movieAppService.Count(filters);

            return PaginationHelper.CreatePagedResponse(movies, searchTerms, totalRecords, _uriService, Request.Path.Value);
        }

        /// <summary>
        ///  Get movie by ID
        /// </summary>
        /// <param name="id">Movie Id</param>
        /// <response code="200">The movie was successfully obtained.</response>
        /// <response code="404">Movie not found with specified ID.</response>
        /// <response code="500">An error occurred while obtaining the movie.</response>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            try
            {
                var movie = await _movieAppService.GetByIdAsync(id);

                if (movie == null)
                    return NotFound();

                return Ok(new Response<MovieResponse>(movie));
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }

        }

        /// <summary>
        /// Register movie
        /// </summary>
        /// <response code="202">The movie was successfully registered.</response>
        /// <response code="400">The movie model is invalid.</response>
        /// <response code="401">Unauthorized.</response>
        /// <response code="403">Only administrators have access .</response>
        /// <response code="500">An error occurred while registering the movie.</response>
        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> PostAsync(MovieRequest createMovieRequest)
        {

            if (createMovieRequest == null)
                return BadRequest();

            try
            {
                var movie = await _movieAppService.RegisterAsync(createMovieRequest);

                return Created("", movie);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        /// <summary>
        /// Register vote
        /// </summary>
        /// <response code="202">  The vote was successfully registered.</response>
        /// <response code="400">The vote model is invalid.</response>
        /// <response code="401">Unauthorized.</response>
        /// <response code="403">Only common users can vote.</response>
        /// <response code="500">An error occurred while registering the vote.</response>
        [HttpPost("{id}/vote")]
        [Authorize(Roles = "common")]
        public async Task<IActionResult> VoteAsync([FromRoute] Guid id, VoteRequest movieDto)
        {

            var userId = User?.FindFirst("Id").Value.ToString();

            movieDto.MovieId = id;
            movieDto.UserId = Guid.Parse(userId);

            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                await _movieAppService.VoteAsync(movieDto);

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

    }
}
