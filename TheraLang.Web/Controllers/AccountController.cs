using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Piranha;
//using Piranha.AspNetCore.Identity;

namespace TheraLang.Web.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ISecurity _service;

        public AccountController(ISecurity service)
        {
            _service = service;
        }

        [HttpPost("login/{username}/{password}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(string username, string password)
        {
            if (username == null)
            {
                throw new ArgumentException($"{nameof(username)} cannot be null");
            }
            if (password == null)
            {
                throw new ArgumentException($"{nameof(password)} cannot be null");
            }
            if (await _service.SignIn(HttpContext, username, password))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost("logout")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignOut()
        {
            await _service.SignOut(HttpContext);
            return Ok();
        }
    }
}