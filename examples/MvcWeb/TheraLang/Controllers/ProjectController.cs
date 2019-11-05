using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {

        public IUnitOfWork uow;
        public ProjectController(IUnitOfWork unitOfWork)
        {
            uow = unitOfWork;
        }
        [HttpGet]
        public IEnumerable<Project> GetAllProjects()
        {
            return uow.Repository<Project>().Get().ToList();
        }
        [HttpGet("{id}")]
        public IActionResult GetProject(int id)
        {
            try
            {
                var project = GetAllProjects().FirstOrDefault((p) => p.Id == id);
                return Ok(project);
            }
            catch(NullReferenceException)
            {
                return NotFound();
            }
        }      
    }
}
