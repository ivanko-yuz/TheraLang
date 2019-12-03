using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.DLL.Entities;
using TheraLang.Web.Models;
using TheraLang.Web.Services;

namespace TheraLang.Web.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService; 
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        
        [HttpPost("create")]
        public IActionResult CreateProject(Project project)
        {
            if(project == null)
            {
                throw new ArgumentException($"{nameof(project)} cannot be null");
            }
            _projectService.Add(project);
            return  Ok(project);
        }
        
        [HttpGet]
        public IEnumerable<ProjectModel> GetAllProjects()
        {
            List<ProjectModel> projectModels = new List<ProjectModel>();
            projectModels = _projectService.GetAllProjects().Select(p => new ProjectModel
            {
                Id = p.Id,
                Name = p.Name,
                DonationAmount = p.Donations.Sum(y => y.Amount),
                Description = p.Description,
                Details = p.Details,
                ProjectStart = p.ProjectStart,
                ProjectEnd = p.ProjectEnd
                
            }).ToList();

            return projectModels;
        }

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
          

        [HttpPut("update/{id}")]
        public IActionResult EditProject(int id,Project project)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }
            _projectService.UpdateAsync(id,project);
            return Ok(project);
        }
        

            /*[HttpPut("{id}")]
            public async Task<IActionResult> Approve(int id)
            {
                if (id == default)
                {
                    throw new ArgumentException($"{nameof(id)} cannot be 0");
                }
                await _projectService.ChangeStatus(id, ProjectStatus.Approved);
                return Ok();
            }//*/

        [HttpGet("page/{page}/{pagesize}")]
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

            [HttpPut("{id}")]
            public async Task<IActionResult> Reject(int id)
            {
                if (id == default)
                {
                    throw new ArgumentException($"{nameof(id)} cannot be 0");
                }
                await _projectService.ChangeStatus(id, ProjectStatus.Rejected);
                return Ok();
            }
        }
    }