using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MovieReview.API.Services;
using MovieReview.Application.Dtos;
using MovieReview.Application.Interfaces;
using System;
using System.Threading.Tasks;

namespace Movie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountAppService _AccountAppService;
        private readonly IConfiguration _configuration;

        public AccountController(IAccountAppService AccountAppService, IConfiguration configuration)
        {
            _AccountAppService = AccountAppService;
            _configuration = configuration;
        }

        /// <summary>
        /// Log into account 
        /// </summary>
        /// <response code="200">The account has been successfully authenticated.</response>
        /// <response code="400">The Login model is invalid.</response>
        /// <response code="500">There was an error logging into the account.</response>
        [HttpPost("auth")]
        public async Task<dynamic> AuthPostAsync(LoginAccountRequest loginRequest)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var account = await _AccountAppService.AuthenticateAsync(loginRequest.Email, loginRequest.Password);

                if (account == null)
                    return NotFound();

                var service = new JwtService(_configuration);

                var token = service.GenerateToken(account);

                return new
                {
                    account,
                    token
                };
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        /// <summary>
        /// Register account 
        /// </summary>
        /// <response code="204">The account was successfully registered.</response>
        /// <response code="400">The account model is invalid.</response>
        /// <response code="500">There was an error logging into the account.</response>
        [HttpPost("register")]
        public async Task<IActionResult> RegisterPostAsync(RegisterAccountRequest registerDto)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var emailExists = await _AccountAppService.EmailExistsAsync(registerDto.Email);

                if (emailExists)
                    return BadRequest("Email is already in use");

                var account = await _AccountAppService.Register(registerDto);

                return NoContent();
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

    }
}
