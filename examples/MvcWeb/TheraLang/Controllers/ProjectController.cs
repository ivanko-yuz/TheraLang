using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;
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
        [HttpPost("create")]
        public IActionResult CreateProject(Project project)
        {
            if(project == null)
            {
                throw new System.NullReferenceException($"project can`t be null");
            }
             uow.Repository<Project>().Add(project);
             uow.SaveChangesAsync();
            return  Ok(project);
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
            if(project == null)
            {
                throw new System.NullReferenceException($"project with id {id} not found");
            }
            return Ok(project);            
        }
        [HttpPut("update{id}")]
        public IActionResult EditProject(int id,Project project)
        {
            project = GetAllProjects().FirstOrDefault((p) => p.Id == id);
            if (project == null)
            {
                throw new System.NullReferenceException($"project with id {id} not found");
            }
            uow.Repository<Project>().Update(project);
            uow.SaveChangesAsync();
            return Ok(project);
        }
    }
}
