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
        private readonly IUserManagementService _userManagement;

        public AccountController(IAuthenticateService authService, IUserManagementService userManagement)
        {
            _authService = authService;
            _userManagement = userManagement;
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
            var user = await _userManagement.GetUser(loginDto.Email, loginDto.Password);
            if (user == null) return BadRequest();
            var token = await _authService.Authenticate(user);
            if (token == "")
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
        public async Task<IActionResult> Register([FromForm]UserAllViewModel newUser)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserAllViewModel, UserAllDto>()).CreateMapper();
            var user = mapper.Map<UserAllViewModel, UserAllDto>(newUser);
            await _userManagement.AddUser(user);
            return Ok();
        }
    }
}
