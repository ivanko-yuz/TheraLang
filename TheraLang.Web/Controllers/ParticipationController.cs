using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Piranha.AspNetCore.Identity.Data;
using System.Linq;
using AutoMapper;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Controllers
{
    [Route("api/participants")]
    [ApiController]
    public class ParticipationController : ControllerBase
    {
        public ParticipationController(IProjectParticipationService projectParticipationServiceservice, UserManager<User> userManager, IProjectService projectService)
        {
            _projectParticipationServiceservice = projectParticipationServiceservice;
            _userManager = userManager;
            _projectService = projectService;
        }

        private readonly IProjectParticipationService _projectParticipationServiceservice;
        private readonly UserManager<User> _userManager;
        private readonly IProjectService _projectService;

        /// <summary>
        /// Change status of participant
        /// </summary>
        /// <param name="participantId"></param>
        /// <param name="status"></param>
        /// <returns>status code</returns>
        [HttpPut]
        [Route("{participantId}")]
        public async Task<IActionResult> ChangeStatus(int participantId, [FromBody]ProjectParticipationStatusViewModel status)
        {
            if (participantId == default)
            {
                throw new ArgumentException($"{nameof(participantId)} can not be 0");
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectParticipationStatusViewModel, ProjectParticipationStatusDto>()).CreateMapper();
            var statusDto = mapper.Map<ProjectParticipationStatusViewModel, ProjectParticipationStatusDto>(status);

            await _projectParticipationServiceservice.ChangeStatusAsync(participantId, statusDto);
            return Ok();
        }

        /// <summary>
        /// get all ProjectParticipants
        /// </summary>
        /// <returns>array of ProjectParticipants</returns>
        [HttpGet]
        public ActionResult<IEnumerable<ParticipantViewModel>> GetAllParticipants()
        {
            var members = _projectParticipationServiceservice.GetAll().ToList();

            return Ok(members);
        }

        /// <summary>
        /// create a project participation request
        /// </summary>
        /// <param name="projectId">Id of project that you want participate</param>
        /// <returns>status code</returns>
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateParticipant([FromBody]int projectId)
        {
            var project = _projectService.GetById(projectId);

            if (project == null)
            {
                NotFound();
            }

            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            await _projectParticipationServiceservice.CreateRequest(user.Id, projectId);

            return Ok();
        }
    }
}