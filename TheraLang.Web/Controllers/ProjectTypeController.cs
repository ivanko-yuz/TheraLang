using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TheraLang.DLL.Entities;
using TheraLang.Web.Services;

namespace TheraLang.Web.Controllers
{
    [ApiController]
    [Route("api/types")]
    public class ProjectTypeController : ControllerBase
    {
        private readonly IProjectTypeService _service;
        public ProjectTypeController(IProjectTypeService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<ProjectType> GetAllTypes()
        {
            return _service.GetAllProjectsType();
        }

        [HttpGet("{id}")]
        public IActionResult GetType(int id)
        {
            if(id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }
            var type = _service.GetProjectTypeById(id);           
            return Ok(type);
        }            
    }
}
