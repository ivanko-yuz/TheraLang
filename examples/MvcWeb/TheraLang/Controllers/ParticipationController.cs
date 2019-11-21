using MvcWeb.TheraLang.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Services;
using System.Collections.Generic;
using System;
using MvcWeb.TheraLang.ProjectStatus;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/participants")]
    [ApiController]
    public class ParticipationController : ControllerBase
    {
        public ParticipationController(IProjectParticipationService service)
        {
            _service = service;
        }

        private readonly IProjectParticipationService _service;

        [HttpGet]
        //[Route("get")]
        public ActionResult<ProjectParticipation> Get()
        {
            IEnumerable<ProjectParticipation> members = _service.GetAll();
            return Ok(members);
        }

        //
        [HttpPut]
        [Route("{participantId}")]
        public async Task<IActionResult> ChangeStatus(int participantId, [FromBody]ProjectParticipationStatus status)
        {
            await _service.ChangeStatusAsync(participantId, status);
            return Ok();
        }

        //

        [HttpPost]
        [Route("create/{userId}/{projectId}")]
        public async Task<IActionResult> Post([FromBody] int userId, int projectId)
        {
            if( userId == default || projectId == default )
            {
                throw new ArgumentException($"{nameof(userId)} or {nameof(projectId)} can not be 0");
            }
            await _service.CreateRequest(userId, projectId);
            return Ok();
        }
    }
}