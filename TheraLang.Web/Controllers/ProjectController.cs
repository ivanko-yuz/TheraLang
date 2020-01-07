using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TheraLang.DLL.Entities;
using TheraLang.DLL.Models;
using TheraLang.DLL.Services;
using Piranha.AspNetCore.Identity.Data;

namespace TheraLang.Web.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly UserManager<User> _userManager;

        public ProjectController(IProjectService projectService, UserManager<User> userManager)
        {
            _projectService = projectService;
            _userManager = userManager;
        }

        /// <summary>
        /// Create new project
        /// </summary>
        /// <param name="project"></param>
        /// <returns>status code</returns>
        [HttpPost("create")]
        public async Task <IActionResult> CreateProject([FromBody]ProjectModel project)
        {
            if(project == null)
            {
                throw new ArgumentException($"{nameof(project)} cannot be null");
            }
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            await _projectService.Add(project, user.Id);
            return  Ok(project);
        }

        /// <summary>
        /// get all Projects
        /// </summary>
        /// <returns>array of Projects</returns>
        [HttpGet]
        public IEnumerable<ProjectDonationModel> GetAllProjects()
        {
            List<ProjectDonationModel> projectModels = new List<ProjectDonationModel>();
            projectModels = _projectService.GetAllProjects().Where(x => x.StatusId == ProjectStatus.Approved)
                .Select(p => new ProjectDonationModel
            {
                Id = p.Id,
                Name = p.Name,
                DonationsSum = p.Donations.Sum(y => y.Amount),
                DonationTargetSum = p.DonationTarget,
                SumLeftToCollect = p.DonationTarget - p.Donations.Sum(y => y.Amount),
                Description = p.Description,
                Details = p.Details,
                ProjectStart = p.ProjectStart,
                ProjectEnd = p.ProjectEnd
            }).ToList();

            return projectModels;
        }
        [HttpGet("new")]
        public IActionResult GetAllNewProjects()
        {

            var projects = _projectService.GetAllNewProjects();
            return Ok(projects);
        }



        /// <summary>
        /// Get project by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>serialized project</returns>
        [HttpGet("{id}")]
        public IActionResult GetProject(int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }
            var project = _projectService.GetById(id);            
            return Ok(project);            
        }

        /// <summary>
        /// Edit project by Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="project">new version</param>
        /// <returns>edited project</returns>
        [HttpPut("update/{id}")]
        public IActionResult EditProject(int id, [FromBody]Project project)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }
            _projectService.UpdateAsync(id,project);
            return Ok(project);
        }

        /// <summary>
        /// Approve selected project
        /// </summary>
        /// <param name="id"></param>
        /// <returns>status code</returns>
        [HttpGet("approve/{id}")]
        public async Task<IActionResult> Approve(int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} cannot be 0");
            }
            await _projectService.ChangeStatus(id, ProjectStatus.Approved);
            return Ok(ProjectStatus.Approved);
        }

        /// <summary>
        /// Get projects on the page
        /// </summary>
        /// <param name="page">page number</param>
        /// <param name="pageSize">number of projects on one page</param>
        /// <returns>array of selected project</returns>
        [HttpGet("page/{page}/{pageSize}")]
        public IActionResult ProjectsPagination(int page,  int pageSize)
        {
            if (page == default)
            {
                throw new ArgumentException($"{nameof(page)} can not be 0");
            }
            if (pageSize == default)
            {
                throw new ArgumentException($"{nameof(pageSize)} can not be 0");
            }
            var projects =_projectService.GetProjects(page, pageSize);
            return Ok(projects);
        }

        /// <summary>
        /// Reject selected project
        /// </summary>
        /// <param name="id"></param>
        /// <returns>status code</returns>
        [HttpGet("reject/{id}")]
        public async Task<IActionResult> Reject(int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} cannot be 0");
            }
            await _projectService.ChangeStatus(id, ProjectStatus.Rejected);
            return Ok(ProjectStatus.Rejected);
        }

        /// <summary>
        /// Delete project by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>status code</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} cannot be 0");
            }
            await _projectService.Delete(id);
            return Ok();
        }

        [HttpGet("newstatus/{status}")]
        public IActionResult GetProjectsByStatus(int status)
        {
            var projects = _projectService.GetProjectsByStatus(status);
            return Ok(projects);
        }
    }
}
