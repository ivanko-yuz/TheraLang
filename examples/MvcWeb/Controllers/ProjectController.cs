using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.Services;
using MvcWeb.TheraLang.Entities;


namespace MvcWeb.Controllers
{
    [Route("api/project")]
    [ApiController]

    public class ProjectController : ControllerBase
    {
        public ProjectController(IProjectService projectService)
        {
                _projectService = projectService;
        }
            private readonly IProjectService _projectService;

            public IEnumerable<Project> GetAllProjects()
            {
                return _projectService.GetAll();
            }

            [HttpPut("{id}")]
            public async Task<IActionResult> ApproveStatusId(int id)
            {
                if (id == default)
                {
                    throw new ArgumentException($"{nameof(id)} cannot be 0");
                }
                await _projectService.ChangeStatus(id, ProjectStatus.Approved);
                return Ok();
            }

            [HttpPut("{id}")]
            public async Task<IActionResult> RejectStatusId(int id)
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

