using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IAuthenticateService _authService;
        public AccountController(IAuthenticateService authService)
        {
            _authService = authService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> SignIn([FromBody]LoginModel login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<LoginModel, LoginModelDto>()).CreateMapper();
            var loginDto = mapper.Map<LoginModel, LoginModelDto>(login);

            if (_authService.IsAuthenticated(loginDto, out var token))
            {
                return Ok(new LoginResponse()
                {
                    Token = token,
                });
            }

            return BadRequest("Invalid Request");
        }

    }
}
