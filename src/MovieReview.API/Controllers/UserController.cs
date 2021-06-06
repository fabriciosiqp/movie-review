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
using System.Threading.Tasks;

namespace Movie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [ApiController]
    [Authorize(Roles = "admin")]
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _userAppService;
        private readonly IUriService _uriService;

        public UserController(IUserAppService userAppService, IUriService uriService)
        {
            _userAppService = userAppService;
            _uriService = uriService;
        }

        /// <summary>
        ///  Get all common user
        /// </summary>
        /// <response code="200">The user list was successfully obtained.</response>
        /// <response code="403">Only administrators have access .</response>
        /// <response code="500">There was an error fetching the user list.</response>
        [HttpGet]
        public PagedResponse<List<UserResponse>> Get([FromQuery] PaginationFilter filter)
        {

            List<UserResponse> users = (List<UserResponse>)_userAppService.GetAllCommon(filter.PageIndex, filter.PageSize);

            var totalRecords = _userAppService.CountCommon();

            return PaginationHelper.CreatePagedResponse(users, filter, totalRecords, _uriService, Request.Path.Value);
        }

        /// <summary>
        /// Register user
        /// </summary>
        /// <response code="202">The user was successfully registered.</response>
        /// <response code="400">The user model is invalid.</response>
        /// <response code="401">Unauthorized.</response>
        /// <response code="403">Only administrators have access.</response>
        /// <response code="500">An error occurred while registering the user.</response>
        [HttpPost]
        public async Task<IActionResult> PostAsync(CreateUserRequest createUserDto)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                await _userAppService.RegisterAsync(createUserDto);

                return Accepted();
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        /// <summary>
        /// Update user
        /// </summary>
        /// <response code="204">The user has been updated successfully.</response>
        /// <response code="400">The user model is invalid.</response>
        /// <response code="401">Unauthorized.</response>
        /// <response code="403">Only administrators have access .</response>
        /// <response code="404">User not found with specified ID.</response>
        /// <response code="500">An error occurred while registering the user.</response>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync([FromRoute] Guid id, UpdateUserRequest updateUserRequest)
        {

            updateUserRequest.Id = id;

            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                await _userAppService.UpdateAsync(updateUserRequest);

                return NoContent();
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <response code="204">The user has been deleted successfully.</response>
        /// <response code="400">The user model is invalid.</response>
        /// <response code="401">Unauthorized.</response>
        /// <response code="403">Only administrators have access .</response>
        /// <response code="404">User not found with specified ID.</response>
        /// <response code="500">An error occurred while registering the user.</response>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {

            if (Guid.Empty == id)
                return BadRequest();

            try
            {

                await _userAppService.DeleteAsync(id);

                return NoContent();
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }


    }
}
