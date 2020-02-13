using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AutoMapper;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using TheraLang.Web.Extensions;

namespace TheraLang.Web.Controllers
{
    [Route("api/participants")]
    [ApiController]
    public class ParticipationController : ControllerBase
    {
        public ParticipationController(IProjectParticipationService projectParticipationServiceservice, IUserManagementService userManager,
            IProjectService projectService)
        {
            _projectParticipationServiceservice = projectParticipationServiceservice;
            _userManager = userManager;
            _projectService = projectService;
        }

        private readonly IProjectParticipationService _projectParticipationServiceservice;
        private readonly IUserManagementService _userManager;
        private readonly IProjectService _projectService;

        /// <summary>
        /// Change status of participant
        /// </summary>
        /// <param name="participantId"></param>
        /// <param name="status"></param>
        /// <returns>status code</returns>
        [HttpPut]
        [Route("{participantId}")]
        [Authorize]
        public async Task<IActionResult> ChangeStatus(int participantId, [FromBody] ProjectParticipationStatusViewModel status)
        {
            if (participantId == default)
            {
                throw new ArgumentException($"{nameof(participantId)} can not be 0");
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectParticipationStatusViewModel, ProjectParticipationStatusDto>()).CreateMapper();
            var statusDto = mapper.Map<ProjectParticipationStatusViewModel, ProjectParticipationStatusDto>(status);

            await _projectParticipationServiceservice.ChangeStatus(participantId, statusDto);
            return Ok();
        }

        /// <summary>
        /// get all ProjectParticipants
        /// </summary>
        /// <returns>array of ProjectParticipants</returns>
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<ParticipantViewModel>>> Get()
        {
            var members = (await _projectParticipationServiceservice.GetAll()).ToList();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectParticipationDto, ParticipantViewModel>()
                .ForMember(m => m.Id, opt => opt.MapFrom(m => m.User.Id))
                .ForMember(m => m.UserName, opt => opt.MapFrom(m => m.User.UserName))
                .ForMember(m => m.UserEmail, opt => opt.MapFrom(m => m.User.Email))
            ).CreateMapper();

            var membersModel = mapper.Map<IEnumerable<ProjectParticipationDto>, IEnumerable<ParticipantViewModel>>(members);

            return Ok(membersModel);
        }

        /// <summary>
        /// create a project participation request
        /// </summary>
        /// <param name="projectId">Id of project that you want participate</param>
        /// <returns>status code</returns>
        [HttpPost]
        [Authorize]
        [Route("create")]
        public async Task<IActionResult> CreateParticipant([FromBody] int projectId)
        {
            var userId = User.Claims.GetUserId();
            if (userId == null)
            {
                return BadRequest();
            }

            var project = await _projectService.GetByIdAsync(projectId);
            if (project == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserById(userId.Value);

            await _projectParticipationServiceservice.CreateRequest(user.Id, projectId);
            return Ok();
        }
    }
}