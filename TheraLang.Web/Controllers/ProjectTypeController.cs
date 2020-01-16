using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.Services;
using TheraLang.DLL.Entities;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Piranha.AspNetCore.Identity.Data;

namespace TheraLang.Web.Controllers
{
    [Route("api/projectTypes")]
    [ApiController]
 
    public class ProjectTypeController : ControllerBase
    {
        public ProjectTypeController(IProjectTypeService service, UserManager<User> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        private readonly IProjectTypeService _service;
        private readonly UserManager<User> _userManager;

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
        public async Task<IActionResult> PutProjectType([FromBody] ProjectType projectType)
        {
            if (projectType == null)
            {
                throw new ArgumentException($"{nameof(projectType)} can not be null");
            }

            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            Guid userId = user.Id;
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
