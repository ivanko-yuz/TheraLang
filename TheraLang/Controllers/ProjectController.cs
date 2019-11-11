using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.Models;
using TheraLang.Services;

namespace TheraLang.Controllers
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
        public async Task<ActionResult<bool>> CreateProject(ProjectViewModel projectViewModel)
        {
            var ms = ModelState;
            if (!ModelState.IsValid) return false;
            return await ProjectService.TryAddProject(projectViewModel);
        }
    }
}