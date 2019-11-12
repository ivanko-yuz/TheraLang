using MvcWeb.TheraLang.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Services;
using System;
using System.Collections.Generic;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/participation")]
    [ApiController]
    public class ParticipationController : ControllerBase
    {
        public ParticipationController(IProjectParticipationService _service)
        {
            this.service = _service;
        }

        private readonly IProjectParticipationService service;

        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            IEnumerable<ProjectParticipation> members = service.GetAll();

            return Ok(members);
        }

        [HttpPost]
        [Route("create/{userId}/{projectId}")]
        public async Task<IActionResult> Post([FromBody] Guid userId, int projectId)
        {
            await service.CreateRequest(userId, projectId);

            return Ok();
        }
    }
}