using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly IUserManagementService _userManager;
        private readonly IAuthenticateService _authenticateService;

        public ProjectController(IProjectService projectService, IUserManagementService userManager, IAuthenticateService authenticateService)
        {
            _projectService = projectService;
            _userManager = userManager;
            _authenticateService = authenticateService;
        }

        /// <summary>
        /// Create new project
        /// </summary>
        /// <param name="projectModel"></param>
        /// <returns>status code</returns>
        [HttpPost("create")]
        [Authorize]
        public async Task<IActionResult> CreateProject([FromBody]ProjectViewModel projectModel)
        {
            if (projectModel == null)
            {
                return BadRequest();
            }

            var AuthUser = await _authenticateService.GetAuthUserAsync();
            if (AuthUser == null) return BadRequest();
            var user = _userManager.GetUserById(AuthUser.Id);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectViewModel, ProjectDto>()).CreateMapper();
            var projectDto = mapper.Map<ProjectViewModel, ProjectDto>(projectModel);

            await _projectService.Add(projectDto, user.Id);
            return Ok(projectDto);
        }

        /// <summary>
        /// get all Projects
        /// </summary>
        /// <returns>array of Projects</returns>
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<ProjectDonationViewModel> GetAllProjects()
        {
            var projectModels = _projectService.GetAllProjects().Where(x => x.StatusId == ProjectStatusDto.Approved)
                .Select(p => new ProjectDonationViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    DonationsSum = p.Donations.Sum(y => y.Amount),
                    DonationTargetSum = p.DonationTargetSum,
                    SumLeftToCollect = p.DonationTargetSum - p.Donations.Sum(y => y.Amount),
                    Description = p.Description,
                    Details = p.Details,
                    ProjectStart = p.ProjectStart,
                    ProjectEnd = p.ProjectEnd
                }).ToList();

            return projectModels;
        }

        [HttpGet("new")]
        [Authorize]
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
        [AllowAnonymous]
        public IActionResult GetProject(int id)
        {
            var project = _projectService.GetById(id);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        /// <summary>
        /// Edit project by Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectModel">new version</param>
        /// <returns>edited project</returns>
        [HttpPut("update/{id}")]
        [Authorize]
        public async Task<IActionResult> EditProject(int id, [FromBody]ProjectViewModel projectModel)
        {
            var project = _projectService.GetById(id);

            if (project == null)
            {
                return NotFound();
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectViewModel, ProjectDto>()).CreateMapper();
            var projectDto = mapper.Map<ProjectViewModel, ProjectDto>(projectModel);

            await _projectService.UpdateAsync(id, projectDto);
            return Ok(projectDto);
        }

        /// <summary>
        /// Approve selected project
        /// </summary>
        /// <param name="id"></param>
        /// <returns>status code</returns>
        [HttpGet("approve/{id}")]
        [Authorize]
        public async Task<IActionResult> Approve(int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} cannot be 0");
            }

            var statusApproved = ProjectStatusDto.Approved;

            await _projectService.ChangeStatus(id, statusApproved);
            return Ok(ProjectStatusDto.Approved);
        }

        /// <summary>
        /// Get projects on the page
        /// </summary>
        /// <param name="page">page number</param>
        /// <param name="pageSize">number of projects on one page</param>
        /// <returns>array of selected project</returns>
        [HttpGet("page/{page}/{pageSize}")]
        [AllowAnonymous]
        public IActionResult ProjectsPagination(int page, int pageSize)
        {
            if (page == default)
            {
                throw new ArgumentException($"{nameof(page)} can not be 0");
            }
            if (pageSize == default)
            {
                throw new ArgumentException($"{nameof(pageSize)} can not be 0");
            }
            var projects = _projectService.GetProjects(page, pageSize);
            return Ok(projects);
        }

        /// <summary>
        /// Reject selected project
        /// </summary>
        /// <param name="id"></param>
        /// <returns>status code</returns>
        [HttpGet("reject/{id}")]
        [Authorize]
        public async Task<IActionResult> Reject(int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} cannot be 0");
            }

            var statusRejected = ProjectStatusDto.Rejected;

            await _projectService.ChangeStatus(id, statusRejected);
            return Ok(ProjectStatusDto.Rejected);
        }

        /// <summary>
        /// Delete project by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>status code</returns>
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteProject(int id)
        {
            var project = _projectService.GetById(id);

            if (project == null)
            {
                return NotFound();
            }

            await _projectService.Delete(id);
            return Ok();
        }

        [HttpGet("newstatus/{status}")]
        [AllowAnonymous]
        public IActionResult GetProjectsByStatus(int status)
        {
            var projects = _projectService.GetProjectsByStatus(status);
            return Ok(projects);
        }
    }
}
