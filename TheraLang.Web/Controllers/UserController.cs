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
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuthenticateService _authenticateService;

        public UserController(IUserService userService, IAuthenticateService authenticateService)
        {
            _userService = userService;
            _authenticateService = authenticateService;
        }

        [HttpGet]
        [Route("me")]
        [Authorize]
        public async Task<IActionResult> GetMyProfile()
        {
            var authUser = await _authenticateService.GetAuthUserAsync();
            if (authUser == null) return BadRequest();
            var user = await _userService.GetMyProfile(authUser.Id);
            return Ok(user);
        }

        [HttpGet]
        [Route("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await _userService.GetUserDetailsById(id);
            return Ok(user);
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateUserDetails([FromForm] UserDetailsViewModel userUpdate)
        {
            var authUser = await _authenticateService.GetAuthUserAsync();
            if (authUser == null) return BadRequest();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDetailsViewModel, UserDetailsDto>())
                .CreateMapper();
            var user = mapper.Map<UserDetailsViewModel, UserDetailsDto>(userUpdate);
            await _userService.Update(user, authUser.Id);
            return Ok();
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _userService.GetAllUsers());
        }

        [HttpPost("{id}/role")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ChangeRole(Guid id, [FromBody] ChangeRoleViewModel newRole)
        {
            var authUser = await _authenticateService.GetAuthUserAsync();
            if (authUser == null) return BadRequest();
            if (await _userService.ChangeRole(id, newRole.NewRoleId)) return Ok();
            return BadRequest();
        }


        [HttpGet]
        [Route("admin/{Id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAdminUserView(Guid Id)
        {
            var authUser = await _authenticateService.GetAuthUserAsync();
            if (authUser == null) return BadRequest();
            var user = await _userService.AdminUserView(Id);
            if (user == null) return BadRequest();
            return Ok(user);
        }

        [HttpGet("roles")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _userService.GetAllRols();
            return Ok(roles);
        }

        [HttpGet("{id}/role")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetUserRole(Guid id)
        {
            var userRole = await _userService.GetUserRole(id);
            return Ok(new UserRoleViewModel()
            {
                Id = userRole,
            });
        }
    }
}