using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Piranha;
using Piranha.AspNetCore.Identity.Data;
using TheraLang.Web.Models;

namespace TheraLang.Web.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ISecurity _service;
        private readonly UserManager<User> _userManager;

        public AccountController(ISecurity service, UserManager<User> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        [HttpPost("login")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(LoginModel model)
        {
            // string.IsNullOrWhiteSpace()
            if (string.IsNullOrWhiteSpace(model.UserName))
            {
                throw new ArgumentException($"{nameof(model.UserName)} cannot be null");
            }
            if (string.IsNullOrWhiteSpace(model.Password))
            {
                throw new ArgumentException($"{nameof(model.Password)} cannot be null");
            }
            if (await _service.SignIn(HttpContext, model.UserName, model.Password))
            {
                return Ok();
            }
            else
            {
                return BadRequest(); //TODO an authorize
            }
        }

        [HttpGet("logout")]
        //[ValidateAntiForgeryToken] // to do add user stories
        public async Task<IActionResult> SignOut()
        {
            await _service.SignOut(HttpContext);
            return Ok();
        }

        [HttpGet("isAuthenticated")]
        public bool UserIsAuthenticated()
        {
            var isAuthenticated = User.Identity.IsAuthenticated;
            return isAuthenticated;
        }

        [HttpGet("getUserId")]
        public async Task<Guid> GetActiveUserId()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userId = user.Id;
            return userId;
        }
    }
}