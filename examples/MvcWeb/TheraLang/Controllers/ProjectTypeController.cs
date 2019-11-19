using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.Services;
using MvcWeb.TheraLang.Entities;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/ProjectType")]
    [ApiController]
    public class ProjectTypeController : ControllerBase
    {
        public ProjectTypeController(IProjectTypeService service)
        {
            _service = service;
        }

        private readonly IProjectTypeService _service;

        [HttpPost]
        [Route("create/{ProjectType}")]
        public async Task<IActionResult> PostProjectType([FromBody]ProjectType projectType)
        {
            if (projectType == null)
            {
                throw new ArgumentException($"{nameof(projectType)} can not be null");
            }
            await _service.AddProjectType(projectType);
            return Ok();
        }

        [HttpPut]
        [Route("update/{ProjectType}/{Id}")]
        public async Task<IActionResult> PutProjectType([FromBody] ProjectType projectType, int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }
            if (projectType == null)
            {
                throw new ArgumentException($"{nameof(projectType)} can not be null");
            }
            await _service.UpdateProjectType(projectType, id);
            return Ok();
        }

        
        [HttpDelete]
        [Route("delete/{Id}")]
        public async Task<IActionResult> DeleteProjectType([FromBody]int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }
            await _service.RemoveProjectType(id);
            return Ok();
        }
    }
}
