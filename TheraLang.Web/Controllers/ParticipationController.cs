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
using Microsoft.AspNetCore.Authorization;
using TheraLang.Web.Extensions;

namespace TheraLang.Web.Controllers
{
    [Route("api/participants")]
    [ApiController]
    public class ParticipationController : ControllerBase
    {
        public ParticipationController(IProjectParticipationService service, IUserManagementService userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        private readonly IProjectParticipationService _service;
        private readonly IUserManagementService _userManager;

        /// <summary>
        /// Change status of participant
        /// </summary>
        /// <param name="participantId"></param>
        /// <param name="status"></param>
        /// <returns>status code</returns>
        [HttpPut]
        [Route("{participantId}")]
        [Authorize]
        public async Task<IActionResult> ChangeStatus(int participantId, [FromBody]ProjectParticipationStatusViewModel status)
        {
            if (participantId == default)
            {
                throw new ArgumentException($"{nameof(participantId)} can not be 0");
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectParticipationStatusViewModel, ProjectParticipationStatusDto>()).CreateMapper();
            var statusDto = mapper.Map<ProjectParticipationStatusViewModel, ProjectParticipationStatusDto>(status);

            await _service.ChangeStatusAsync(participantId, statusDto);
            return Ok();
        }

        /// <summary>
        /// get all ProjectParticipants
        /// </summary>
        /// <returns>array of ProjectParticipants</returns>
        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<ParticipantViewModel>> Get()
        {
            var members = _service.GetAll().ToList();

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
        public async Task<IActionResult> Post([FromBody]int projectId)
        {
            if (projectId == default)
            {
                throw new ArgumentException($"The {nameof(projectId)} can not be 0");
            }

            var UserId = User.Claims.GetUserId();
            if (UserId == null) return BadRequest();
            var user = _userManager.GetUserById(UserId.Value);

            await _service.CreateRequest(user.Id, projectId);
            return Ok();
        }
    }
}