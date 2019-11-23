using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/project")]
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
            var project = GetAllProjects().FirstOrDefault((p) => p.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }
    }
}
