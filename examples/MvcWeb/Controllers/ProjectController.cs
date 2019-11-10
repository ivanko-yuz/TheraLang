using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.Models;
using MvcWeb.Services;

namespace MvcWeb.Controllers
{
    [Route("/api/projects/")]
    public class ProjectController : ControllerBase
    {
        public ProjectController(IProjectService projectService)
        {   
            ProjectService = projectService;
        }

        private IProjectService ProjectService { get; }
        
        [HttpPost("create")]
        public async Task<ActionResult<bool>> CreateProject([CustomizeValidator(RuleSet = "create")]ProjectViewModel projectViewModel)
        {
            if (!ModelState.IsValid) return false;
            return await ProjectService.TryAddProject(projectViewModel);
        }
    }
}