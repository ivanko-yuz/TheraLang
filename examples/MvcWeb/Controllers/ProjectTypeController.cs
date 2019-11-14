using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.Services;
using MvcWeb.TheraLang.Entities;

namespace MvcWeb.Controllers
{
    [ApiController]
    [Route("api/types")]
    public class ProjectTypeController : ControllerBase
    {
        private readonly IProjectTypeService _service;
        public ProjectTypeController(IProjectTypeService Service)
        {
            _service = Service;
        }

        [HttpGet]
        public IEnumerable<ProjectType> GetAllTypes()
        {
            return _service.GetAllProjectsType();
        }

        [HttpGet("{id}")]
        public IActionResult GetType(int id)
        {
            var type = _service.GetProjectTypeById(id);           
            return Ok(type);
        }            
    }
}
