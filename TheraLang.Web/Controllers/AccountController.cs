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
        private readonly IUserManagementService _userManagementService;
        public AccountController(IAuthenticateService authService, IUserManagementService userManagementService)
        {
            _authService = authService;
            _userManagementService = userManagementService;
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
            var user = _userManagementService.GetUser(loginDto);
            if (user == null) return BadRequest();
            if (_authService.IsAuthenticated(out var token, user))
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
