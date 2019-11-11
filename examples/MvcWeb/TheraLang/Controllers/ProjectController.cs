using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.Services;
using System.Collections.Generic;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        public IProjectService ProjectService; 
        public ProjectController(IProjectService projectService)
        {
            ProjectService = projectService;
        }
        [HttpPost("create")]
        public IActionResult CreateProject(Project project)
        {
            if(project == null)
            {
                throw new System.NullReferenceException($"project can`t be null");
            }
            ProjectService.TryAddProject(project);
            return  Ok(project);
        }
        [HttpGet]
        public IEnumerable<Project> GetAllProjects()
        {
            return ProjectService.GetAllProjects();
        }
        [HttpGet("{id}")]
        public IActionResult GetProject(int id)
        {
           var project = ProjectService.GetById(id);
            if(project == null)
            {
                throw new System.NullReferenceException($"project with id {id} not found");
            }
            return Ok(project);            
        }
        [HttpPut("update{id}")]
        public IActionResult EditProject(int id,Project project)
        {
            ProjectService.UpdateAsync(id,project);
            if (project == null)
            {
                throw new System.NullReferenceException($"project with id {id} not found");
            }
           
            return Ok(project);
        }
    }
}
