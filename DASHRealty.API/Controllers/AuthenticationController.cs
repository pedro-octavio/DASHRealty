using System;
using DASHRealty.Application.DTOs;
using DASHRealty.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DASHRealty.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ITokenApplicationService _tokenApplicationService;
        private readonly IUserApplicationService _userApplicationService;

        public AuthenticationController(ITokenApplicationService tokenApplicationService, IUserApplicationService userApplicationService)
        {
            _tokenApplicationService = tokenApplicationService;
            _userApplicationService = userApplicationService;
        }

        [HttpGet]
        public IActionResult Authenticate([FromBody] UserDTO userDTO)
        {
            try
            {
                var user = _userApplicationService.GetByEmail(userDTO.Email);

                if (user == null) return BadRequest(error: "Incorrect email.");
                if (user.Password != userDTO.Password) return BadRequest(error: "Incorrect password.");

                return Ok(_tokenApplicationService.GenerateToken(userDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(error: ex);
            }
        }
    }
}
