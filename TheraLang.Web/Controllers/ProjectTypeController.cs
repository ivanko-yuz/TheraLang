using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;
using TheraLang.Web.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace TheraLang.Web.Controllers
{
    [Route("api/projectTypes")]
    [ApiController]
 
    public class ProjectTypeController : ControllerBase
    {
        public ProjectTypeController(IProjectTypeService service, IUserManagementService userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        private readonly IProjectTypeService _service;
        private readonly IUserManagementService _userManager;

        /// <summary>
        /// create project type
        /// </summary>
        /// <param name="projectTypeModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PostProjectType([FromBody]ProjectTypeViewModel projectTypeModel)
        {
            if (projectTypeModel == null)
            {
                throw new ArgumentException($"{nameof(projectTypeModel)} can not be null");
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectTypeViewModel, ProjectTypeDto>()).CreateMapper();
            var projectDto = mapper.Map<ProjectTypeViewModel, ProjectTypeDto>(projectTypeModel);

            await _service.Add(projectDto);
            return Ok();
        }


        [HttpPut]       
        [Authorize]
        public async Task<IActionResult> PutProjectType([FromBody] ProjectTypeViewModel projectTypeModel)
        {
            if (projectTypeModel == null)
            {
                throw new ArgumentException($"{nameof(projectTypeModel)} can not be null");
            }
            var UserId = User.Claims.GetUserId();
            if (UserId == null) return BadRequest();
            var user = _userManager.GetUserById(UserId.Value);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectTypeViewModel, ProjectTypeDto>()).CreateMapper();
            var projectTypeDto = mapper.Map<ProjectTypeViewModel, ProjectTypeDto>(projectTypeModel);

            await _service.Update(projectTypeDto);
            return Ok();
        }

        
        [HttpDelete("{id}")]
        [Authorize]
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
        [AllowAnonymous]
        public IEnumerable<ProjectTypeDto> GetAllTypes()
        {
            return _service.GetAllProjectsType();
        }

        /// <summary>
        /// Get ProjectType by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>selected ProjectType</returns>
        [HttpGet("{id}")]
        [AllowAnonymous]
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
