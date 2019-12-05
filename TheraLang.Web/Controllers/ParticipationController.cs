using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.DLL.Entities;
using TheraLang.DLL.Enums;
using TheraLang.DLL.Services;
using Microsoft.AspNetCore.Identity;

namespace TheraLang.Web.Controllers
{
    [Route("api/participants")]
    [ApiController]
    public class ParticipationController : ControllerBase
    {
        public ParticipationController(IProjectParticipationService service, UserManager<IdentityUser> manager)
        {
            _service = service;
            _userManager = manager;
        }

        private readonly IProjectParticipationService _service;
        private readonly UserManager<IdentityUser> _userManager;


        [HttpPut]
        [Route("{participantId}")]
        public async Task<IActionResult> ChangeStatus(int participantId, [FromBody]ProjectParticipationStatus status)
        {
            if (participantId == default)
            {
                throw new ArgumentException($"{nameof(participantId)} can not be 0");
            }

            await _service.ChangeStatusAsync(participantId, status);
            return Ok();
        }


        [HttpGet]
        public ActionResult<IEnumerable<ProjectParticipation>> Get()
        {
            IEnumerable<ProjectParticipation> members = _service.GetAll();
            return Ok(members);
        }


        [HttpPost]
        [Route("create/{projectId}")]
        public async Task<IActionResult> Post(int projectId)
        {
            if (projectId == default)
            {
                throw new ArgumentException($"The {nameof(projectId)} can not be 0");
            }

            int userId = _userManager.GetUserAsync(HttpContext.User).Id;
            await _service.CreateRequest(userId, projectId);
            return Ok();
        }
    }
}