using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;
using TheraLang.BLL.DataTransferObjects;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace TheraLang.Web.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuthenticateService _authenticateService;
        public UserController (IUserService userService, IAuthenticateService authenticateService)
        {
            _userService = userService;
            _authenticateService = authenticateService;
        }

        [HttpGet]
        [Route("my/profile")]
        [Authorize]
        public async Task<IActionResult> GetMyProfile()
        {
            var authUser = await _authenticateService.GetAuthUserAsync();
            if (authUser == null) return BadRequest();
            var user = await _userService.GetMyProfile(authUser.Id);
            return Ok(user);
        }

        [HttpGet]
        [Route("profile/{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetUser(Guid id)
        {

            var user = await _userService.GetUserById(id);
            return Ok(user);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> UpdateUserDetails([FromForm]UserDetailsViewModel userUpdate)
        {
            var authUser = await _authenticateService.GetAuthUserAsync();
            if (authUser == null) return BadRequest();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDetailsViewModel, UserDetailsDto>()).CreateMapper();
            var user = mapper.Map<UserDetailsViewModel, UserDetailsDto>(userUpdate);
            await _userService.Update(user, authUser.Id);
            return Ok();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _userService.GetAllUsers());
        }

        [HttpPost("{id}/role")]
        [Authorize (Roles = "Admin")]
        public async Task<IActionResult> ChangeRole(Guid id, [FromBody]ChangeRoleViewModel newRole)
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
    }
}