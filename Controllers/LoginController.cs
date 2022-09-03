using Genesys_Core_API.AuthTest.Manager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Genesys_Core_API.Models;

namespace Genesys_Core_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LoginController : ControllerBase
    {
        private readonly JwtAuthenticationManager jwtAuthenticationManager;
       public LoginController (JwtAuthenticationManager _jwtAuthenticationManager)
        {
            this.jwtAuthenticationManager = _jwtAuthenticationManager;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Authorize([FromBody] Users user)
        {
            string? token = jwtAuthenticationManager.Authenticate(username: user.UserName, password: user.Password);
            if (string.IsNullOrEmpty(token))
            {
                return Unauthorized();
            }
            return Ok(token);
        }

        [HttpGet]
        public IActionResult Route()
        {
            return Ok("Authorized");
        }
    }
}
