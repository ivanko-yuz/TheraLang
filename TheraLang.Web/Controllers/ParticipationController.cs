using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.DLL.Entities;
using TheraLang.DLL.Services;

namespace TheraLang.DLL.Controllers
{
    [Route("api/participation")]
    [ApiController]
    public class ParticipationController : ControllerBase
    {
        public ParticipationController(IProjectParticipationService service)
        {
            _service = service;
        }

        private readonly IProjectParticipationService _service;

        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            IEnumerable<ProjectParticipation> members = _service.GetAll();
            return Ok(members);
        }

        [HttpPost]
        [Route("create/{projectId}")]
        public async Task<IActionResult> Post([FromBody] int projectId, int userId)
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