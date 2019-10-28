using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProjectController : ControllerBase
    {
        //[HttpGet("{idResources}")]
        //public ActionResult<IEnumerable<Resource>> GetByProjId(int inProjectId)
        //{
        //    Resource resource1 = new Resource { Id = 1, Name = "Resource1", Date = new DateTime(2015, 7, 20), Description = "Blah blah blah", ProjectId = 1 };
        //    Resource resource2 = new Resource { Id = 2, Name = "Resource2", Date = new DateTime(2015, 7, 20), Description = "Blah blah blah", ProjectId = 2 };
        //    Resource resource3 = new Resource { Id = 3, Name = "Resource3", Date = new DateTime(2015, 7, 20), Description = "Blah blah blah", ProjectId = 3 };
        //    Resource[] resources = new Resource[] { resource1, resource2, resource3 };
        //    return resources.Where(x => x.ProjectId == inProjectId).ToList();
        //}
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Project>> Get()
        {
            Project project1 = new Project { Id = 1, Name = "project1", Type = "type 1" };
            Project project2 = new Project { Id = 2, Name = "project2", Type = "type 2" };
            Project project3 = new Project { Id = 3, Name = "project3", Type = "type 3" };
            Project[] projects = new Project[] { project1, project2, project3 };
            return projects;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Project> Get(int id)
        {
            Project project1 = new Project { Id = 1, Name = "project1", Type = "type 1" };
            Project project2 = new Project { Id = 2, Name = "project2", Type = "type 2" };
            Project project3 = new Project { Id = 3, Name = "project3", Type = "type 3" };
            Project[] projects = new Project[] { project1, project2, project3 };

            return projects.FirstOrDefault(x=>x.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class ResourceController : ControllerBase
    {

    }
}
