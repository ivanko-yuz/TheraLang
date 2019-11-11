using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcWeb.TheraLang.Controllers
{
    [ApiController]
    [Route("api/types")]
    public class ProjectTypeController : ControllerBase
    {
        // GET: /<controller>/
        private IProjectTypeService service;
        public ProjectTypeController(IProjectTypeService Service)
        {
            service = Service;
        }
        [HttpGet]
        public IEnumerable<ProjectType> GetAllTypes()
        {
            return service.GetAllProjectsType();
        }
        [HttpGet("{id}")]
        public IActionResult GetType(int id)
        {
            var type = GetAllTypes().FirstOrDefault(p => p.Id == id);
            if (type == null)
            {
                throw new NullReferenceException($"type with {id} not found");
            }
            return Ok(type);
        }
    }
}
