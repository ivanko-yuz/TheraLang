using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;


namespace MvcWeb.Controllers
{
    [Route("api/projects/approve")]
    [ApiController]
    public class ProjectApproveController : ControllerBase
    {
        public IUnitOfWork uow;

        public ProjectApproveController(IUnitOfWork unitOfWork)
        {
            uow = unitOfWork;
        }


        public IEnumerable<Project> GetAllProjects()
        {
            return uow.Repository<Project>().Get().ToList();
        }
        [HttpPut("{id}")]
        public IActionResult ApproveStatusId(int id)
        {
            var project = GetAllProjects().FirstOrDefault((p) => p.Id == id);
            project.StatusId = 1;
            return Ok(project);
        }
        [HttpPut("{id}")]
        public IActionResult RejectStatusId(int id)
        {
            var project = GetAllProjects().FirstOrDefault((p) => p.Id == id);
            project.StatusId = 2;
            return Ok(project);
        }

        
    };
 
}
