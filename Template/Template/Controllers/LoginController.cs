using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Template.Application.Interfaces;
using Template.Application.ViewModels;

namespace Template.Controllers
{
    [ApiController]
    [Route("login")]
    public class LoginController : ControllerBase
    {
        private IAuthenticationAppService _authService;

        public LoginController(IAuthenticationAppService authService)
        {
            _authService = authService;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> AuthenticateUser(AuthRequestViewModel authData)
        {
            var authResult = await _authService.Authenticate(authData);

            if (authResult == null)
                return NotFound(new { message = "User or password are incorrect." });

            return Ok(authResult);
        }
    }
}
