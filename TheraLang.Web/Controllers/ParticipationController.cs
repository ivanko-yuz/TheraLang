using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Common.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Controllers
{
    [Route("api/participants")]
    [ApiController]
    public class ParticipationController : ControllerBase
    {
        public ParticipationController(IProjectParticipationService projectParticipationServiceservice,
            IUserManagementService userManager, IProjectService projectService,
            IAuthenticateService authenticateService)
        {
            _projectParticipationServiceservice = projectParticipationServiceservice;
            _userManager = userManager;
            _authenticateService = authenticateService;
            _projectService = projectService;
        }

        private readonly IProjectParticipationService _projectParticipationServiceservice;
        private readonly IUserManagementService _userManager;
        private readonly IProjectService _projectService;
        private readonly IAuthenticateService _authenticateService;

        /// <summary>
        /// Change status of participant
        /// </summary>
        /// <param name="participantId"></param>
        /// <param name="status"></param>
        /// <returns>status code</returns>
        [HttpPut]
        [Route("{participantId}")]
        [Authorize]
        public async Task<IActionResult> ChangeStatus(int participantId,
            [FromBody] ProjectParticipationStatus status)
        {
            if (participantId == default)
            {
                throw new ArgumentException($"{nameof(participantId)} can not be 0");
            }
            
            await _projectParticipationServiceservice.ChangeStatus(participantId, status);
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
            var members = await _projectParticipationServiceservice.GetAll();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectParticipationDto, ParticipantViewModel>()).CreateMapper();
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
            var project = await _projectService.GetByIdAsync(projectId);
            if (project == null)
            {
                return NotFound();
            }

            var authUser = await _authenticateService.GetAuthUserAsync();
            if (authUser == null) return BadRequest();

            await _projectParticipationServiceservice.CreateRequest(authUser.Id, projectId);
            return Ok();
        }

        [HttpGet("{projectId}")]
        public async Task<ActionResult<IEnumerable<ParticipantViewModel>>> GetProjectParticipants(int projectId)
        {
            var members = await _projectParticipationServiceservice.GetProjectParticipations(projectId);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectParticipationDto, ParticipantViewModel>()
                .ForMember(m => m.UserName,
                    opt => opt.MapFrom(m => $"{m.User.Details.FirstName} {m.User.Details.LastName}"))
                .ForMember(m => m.UserEmail, opt => opt.MapFrom(m => m.User.Email))
            ).CreateMapper();

            var membersModel =
                mapper.Map<IEnumerable<ProjectParticipationDto>, IEnumerable<ParticipantViewModel>>(members);

            return Ok(membersModel);
        }
    }
}