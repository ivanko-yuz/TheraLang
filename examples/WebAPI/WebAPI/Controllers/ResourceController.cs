using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    //[ApiController]
    [Route("api/project/{id}/[controller]s")]
    public class ResourceController : Controller
    {
        [HttpGet("")]
        public IEnumerable<Resource> GetByProjId(string id)
        {
            Resource resource1 = new Resource { Id = 1, Name = "Good boy", Date = new DateTime(2015, 7, 20), Description = "Blah blah blah", ProjectId = 1 };
            Resource resource4 = new Resource { Id = 4, Name = "Hatiko so sweety", Date = new DateTime(2015, 7, 20), Description = "Blah blah blah", ProjectId = 1 };
            Resource resource2 = new Resource { Id = 2, Name = "Resource2", Date = new DateTime(2015, 7, 20), Description = "Blah blah blah", ProjectId = 2 };
            Resource resource3 = new Resource { Id = 3, Name = "Resource3", Date = new DateTime(2015, 7, 20), Description = "Blah blah blah", ProjectId = 3 };
            Resource[] resources = new Resource[] { resource1, resource2, resource3, resource4 };
            return resources.Where(x => x.ProjectId == Convert.ToInt32(id));
        }

    }
}