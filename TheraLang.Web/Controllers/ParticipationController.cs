using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.DLL.Enums;
using TheraLang.DLL.Services;
using Microsoft.AspNetCore.Identity;
using Piranha.AspNetCore.Identity.Data;
using TheraLang.DLL.Models;
using System.Linq;

namespace TheraLang.Web.Controllers
{
    [Route("api/participants")]
    [ApiController]
    public class ParticipationController : ControllerBase
    {
        public ParticipationController(IProjectParticipationService service, UserManager<User> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        private readonly IProjectParticipationService _service;
        private readonly UserManager<User> _userManager;

        /// <summary>
        /// Change status of participant
        /// </summary>
        /// <param name="participantId"></param>
        /// <param name="status"></param>
        /// <returns>status code</returns>
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

        /// <summary>
        /// get all ProjectParticipants
        /// </summary>
        /// <returns>array of ProjectParticipants</returns>
        [HttpGet]
        public ActionResult<IEnumerable<ParticipantModel>> Get()
        {
            _service.GetAll();
            var part = _service.GetAll().Select(p => new ParticipantModel
            {
                Id = p.Id,
                ProjectId = p.ProjectId,
                Role = p.Role,
                Status = p.Status,
                UserName = "Олексій Гордієнко",
                UserEmail = "gordienko@gmail.com"
            }).ToList();

            return Ok(part);
        }

        /// <summary>
        /// create a project participation request
        /// </summary>
        /// <param name="projectId">Id of project that you want participate</param>
        /// <returns>status code</returns>
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Post([FromBody]int projectId)
        {
            if (projectId == default)
            {
                throw new ArgumentException($"The {nameof(projectId)} can not be 0");
            }

            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            await _service.CreateRequest(user.Id, projectId);
            return Ok();
        }
    }
}