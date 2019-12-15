using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.DLL.Services;
using TheraLang.DLL.Entities;
using System.Collections.Generic;

namespace TheraLang.Web.Controllers
{
    [Route("api/projectTypes")]
    [ApiController]
 
    public class ProjectTypeController : ControllerBase
    {
        public ProjectTypeController(IProjectTypeService service)
        {
            _service = service;
        }

        private readonly IProjectTypeService _service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectType"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PostProjectType([FromBody]ProjectType projectType)
        {
            if (projectType == null)
            {
                throw new ArgumentException($"{nameof(projectType)} can not be null");
            }
            await _service.Add(projectType);
            return Ok();
        }


        [HttpPut]       
        public async Task<IActionResult> PutProjectType([FromBody] ProjectType projectType, int userId)
        {
            if (projectType == null)
            {
                throw new ArgumentException($"{nameof(projectType)} can not be null");
            }
            await _service.Update(projectType, userId);
            return Ok();
        }

        
        [HttpDelete("{id}")]        
        public async Task<IActionResult> DeleteProjectType(int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }
            await _service.Remove(id);
            return Ok();
        }

        /// <summary>
        /// get all ProjectsTypes
        /// </summary>
        /// <returns>array of ProjectsTypes</returns>
        [HttpGet]
        public IEnumerable<ProjectType> GetAllTypes()
        {
            return _service.GetAllProjectsType();
        }

        /// <summary>
        /// Get ProjectType by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>selected ProjectType</returns>
        [HttpGet("{id}")]
        public IActionResult GetType(int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }
            var type = _service.GetProjectTypeById(id);
            return Ok(type);
        }
    }
}
