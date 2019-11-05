using MvcWeb.TheraLang.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Services;
using System.Collections.Generic;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipationController : ControllerBase
    {
        public ParticipationController(IProjectParticipationSerice _service)
        {
            this.service = _service;
        }

        private readonly IProjectParticipationSerice service;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<ProjectParticipation> members = service.GetAll();

            return Ok(members);
        }

        [HttpPost]
        public async Task<IActionResult> Post(int userId, int projectId)
        {
            await service.CreateRequest(userId, projectId);

            return Ok();
        }
    }
}