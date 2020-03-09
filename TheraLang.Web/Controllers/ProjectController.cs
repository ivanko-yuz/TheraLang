using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.CustomTypes;
using TheraLang.BLL.DataTransferObjects.Projects;
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

        public ProjectController(IProjectService projectService, IUserManagementService userManager,
            IAuthenticateService authenticateService)
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
        public async Task<IActionResult> CreateProject([FromForm] ProjectViewModel projectModel)
        {
            var authUser = await _authenticateService.GetAuthUser();
            if (authUser == null) return BadRequest();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectViewModel, ProjectDto>()).CreateMapper();
            var projectDto = mapper.Map<ProjectViewModel, ProjectDto>(projectModel);

            await _projectService.AddAsync(projectDto, authUser.Id);
            return Ok(projectDto);
        }

        /// <summary>
        /// get all Projects
        /// </summary>
        /// <returns>array of Projects</returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IEnumerable<ProjectDonationViewModel>> GetAllProjects([FromQuery] FilterQuery query)
        {
            if (User.Identity.IsAuthenticated)
            {
                query.User = await _authenticateService.GetAuthUserAsync();
            }
            var mapper = new MapperConfiguration(mapOpts =>
                    mapOpts.CreateMap<ProjectPreviewDto, ProjectDonationViewModel>())
                .CreateMapper();

            var projectDtos = await _projectService.GetAllProjectsAsync(query);

            var projectModels =
                mapper.Map<IEnumerable<ProjectPreviewDto>, IEnumerable<ProjectDonationViewModel>>(projectDtos);
            
            return projectModels;
        }

        [HttpGet("new")]
        [Authorize]
        public async Task<IActionResult> GetAllNewProjects()
        {
            var projects = await _projectService.GetAllNewProjectsAsync();
            return Ok(projects);
        }

        /// <summary>
        /// Get project by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>serialized project</returns>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetProject(int id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectDto, ProjectDonationViewModel>())
                .CreateMapper();

            var projectDto = await _projectService.GetByIdAsync(id);
            if (projectDto == null)
            {
                return NotFound();
            }

            var projectModel = mapper.Map<ProjectDonationViewModel>(projectDto);

            return Ok(projectModel);
        }

        /// <summary>
        /// Edit project by Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectModel">new version</param>
        /// <returns>edited project</returns>
        [HttpPut("update/{id}")]
        [Authorize]
        public async Task<IActionResult> EditProject(int id, [FromBody] ProjectViewModel projectModel)
        {
            var project = _projectService.GetByIdAsync(id);

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

            await _projectService.ChangeStatusAsync(id, statusApproved);
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
        public async Task<IActionResult> ProjectsPagination(int page, int pageSize)
        {
            if (page == default)
            {
                throw new ArgumentException($"{nameof(page)} can not be 0");
            }

            if (pageSize == default)
            {
                throw new ArgumentException($"{nameof(pageSize)} can not be 0");
            }

            var projects = await _projectService.GetProjectsAsync(page, pageSize);
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

            await _projectService.ChangeStatusAsync(id, statusRejected);
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
            var project = _projectService.GetByIdAsync(id);

            if (project == null)
            {
                return NotFound();
            }

            await _projectService.DeleteAsync(id);
            return Ok();
        }

        [HttpGet("newstatus/{status}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetProjectsByStatus(int status)
        {
            var projects = await _projectService.GetProjectsByStatusAsync(status);
            return Ok(projects);
        }
    }
}