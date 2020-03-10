using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.DataTransferObjects.UserDtos;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels.UsersViewModels;

namespace TheraLang.Web.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthenticateService _authService;
        private readonly IUserManagementService _userManagement;
        private readonly IConfirmationService _confirmation;

        public AccountController(IAuthenticateService authService, IUserManagementService userManagement, IConfirmationService confirmation)
        {
            _authService = authService;
            _userManagement = userManagement;
            _confirmation = confirmation;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> SignIn([FromBody] LoginModel login)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<LoginModel, LoginModelDto>()).CreateMapper();
            var loginDto = mapper.Map<LoginModel, LoginModelDto>(login);
            var user = await _userManagement.GetUser(loginDto.Email, loginDto.Password);
            var token = await _authService.Authenticate(user);
            if (token == "" || token == null)
            {
                return BadRequest("Invalid Request");
            }

            return Ok(new LoginResponse()
            {
                Token = token,
            });
        }

        [AllowAnonymous]
        [HttpPost("registration")]
        public async Task<IActionResult> Register([FromForm] UserAllViewModel newUser)
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserAllViewModel, UserAllDto>();
                cfg.CreateMap<UserAllViewModel, ConfirmUserDto>();
            }).CreateMapper();

            var user = mapper.Map<UserAllViewModel, UserAllDto>(newUser);
            var confirmUser = mapper.Map<UserAllViewModel, ConfirmUserDto>(newUser);
            await _userManagement.AddUser(user);
            return Ok();
        }

        [HttpPost("confirmation")]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail([FromBody]ConfirmUserViewModel confirmUser)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ConfirmUserViewModel, ConfirmUserDto>()).CreateMapper();
            var confirm = mapper.Map<ConfirmUserViewModel, ConfirmUserDto>(confirmUser);
            await _confirmation.ConfirmUser(confirm);
            return Ok();
        }

        [HttpPost("password/forgot")]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword([FromBody]ConfirmPasswordChangingViewModel req)
        {
            await _userManagement.PasswordConfirmationRequest(req.Email);
            return Ok();
        }

        [HttpPost("password/reset")]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmUser([FromBody]ConfirmPasswordChangingViewModel confirmPassword)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ConfirmPasswordChangingViewModel, ConfirmPasswordChangingDto>()).CreateMapper();
            var confirm = mapper.Map<ConfirmPasswordChangingViewModel, ConfirmPasswordChangingDto>(confirmPassword);
            await _confirmation.ConfirmPassword(confirm);
            return Ok();
        }
    }
}