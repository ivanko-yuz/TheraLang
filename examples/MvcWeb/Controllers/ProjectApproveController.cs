using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.Services;
using MvcWeb.TheraLang;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;


namespace MvcWeb.Controllers
{
    [Route("api/project")]
    [ApiController]

    public class ProjectController : ControllerBase
    {
        public ProjectController(IProjectService projectService)
        {
            ProjectService = projectService;
        }

        private IProjectService ProjectService { get; } //todo change to readonly property _projectService
        public class ProjectStatusIdController : ControllerBase
        {
            public IUnitOfWork uow;

            public ProjectStatusIdController(IUnitOfWork unitOfWork)
            {
                uow = unitOfWork;
            }

            public IEnumerable<Project> GetAllProjects()
            {
                return uow.Repository<Project>().Get().ToList();
            }

            [HttpPut("{id}")]
            public async Task<IActionResult> ApproveStatusId(int id)
            {
                //TODO: use ChangeStatus service method
                var project = GetAllProjects().FirstOrDefault((p) => p.Id == id);
                project.StatusId = ProjectStatus.Approved;

                await uow.SaveChangesAsync();
                return Ok(project);
            }

            [HttpPut("{id}")]
            public async Task<IActionResult> RejectStatusId(int id)
            {
                //TODO: use ChangeStatus service method
                service.ChangeStatus(id, ProjectStatus.Rejected)
                var project = GetAllProjects().FirstOrDefault((p) => p.Id == id);
                project.StatusId = ProjectStatus.Rejected;
                await uow.SaveChangesAsync();
                return Ok(project);
            }
        };
    }
}
