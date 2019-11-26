using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.Models;
using MvcWeb.TheraLang.UnitOfWork;

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
        
        [HttpGet]
        public IEnumerable<ProjectModel> GetAllProjects()
        {
            List<ProjectModel> projectModels = new List<ProjectModel>();
            projectModels = uow.Repository<Project>().Get()/*.Where(p=>p.IsActive == true)*/.Select(p => new ProjectModel
            {
                Id = p.Id,
                Name = p.Name,
                DonationAmount = p.Donations.Sum(y => y.Amount)
                //Description = p.Description,
                //Details = p.Details,
                //ProjectBegin = p.ProjectStart,
                //ProjectEnd = p.ProjectEnd
            }).ToList();

            return projectModels;

        }
        [HttpGet("{id}")]
        public IActionResult GetProject(int id)
        {
            var project = GetAllProjects().FirstOrDefault((p) => p.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }
    }
}
