using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Piranha;
using TheraLang.Web.Models;

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

        [HttpPost("login")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(LoginModel model)
        {
            // string.IsNullOrWhiteSpace()
            if (model.UserName == null)
            {
                throw new ArgumentException($"{nameof(model.UserName)} cannot be null");
            }
            if (model.Password == null)
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
    }
}