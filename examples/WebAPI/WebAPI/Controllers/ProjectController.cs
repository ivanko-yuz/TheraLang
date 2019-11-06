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
        static List<Project> projects = new List<Project> {
             new Project { Id = 1, Name = "Хатіко: Вірний друг", Type = "type 1" },
         new Project { Id = 2, Name = "project2", Type = "type 2" },
        new Project { Id = 3, Name = "project3", Type = "type 3" }
       };

       // GET api/values
       [HttpGet]
        public ActionResult<IEnumerable<Project>> Get()
        {
            
            return projects;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Project> Get(int id)
        {
            Project project1 = new Project { Id = 1, Name = "Хатіко: Вірний друг", Type = "type 1" };
            Project project2 = new Project { Id = 2, Name = "project2", Type = "type 2" };
            Project project3 = new Project { Id = 3, Name = "project3", Type = "type 3" };
            Project[] projects = new Project[] { project1, project2, project3 };

            return projects.FirstOrDefault(x=>x.Id == id);
        }

    

        [HttpPost]
        public ActionResult CreateProject([FromBody] Project project)
        {
            projects.Add(project);
            return Ok();
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

}
