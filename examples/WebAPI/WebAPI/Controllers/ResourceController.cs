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
            Resource resource1 = new Resource { Id = 1, Name = "Good boy", Date = DateTime.UtcNow, Description = "https://www.brovarnya-rivne.com/img/images/poroda-hatiko-akita-inu-opisanie-i-harakter-uhod-za-yaponskoj-porodoj-iz-filma-hatiko.jpg", ProjectId = 1 };
            Resource resource4 = new Resource { Id = 4, Name = "Hatiko so sweety", Date = new DateTime(2015, 7, 20, 3, 17, 00), Description = "https://piensosloboazul.com/wp-content/uploads/2019/01/Hachiko-richard-gere.jpg", ProjectId = 1 };
            Resource resource2 = new Resource { Id = 2, Name = "Resource2", Date = new DateTime(2015, 7, 20), Description = "https://i.kym-cdn.com/photos/images/original/000/581/296/c09.jpg", ProjectId = 2 };
            Resource resource3 = new Resource { Id = 3, Name = "Resource3", Date = new DateTime(2015, 7, 20), Description = "https://i.kym-cdn.com/entries/icons/mobile/000/030/157/womanyellingcat.jpg", ProjectId = 3 };
            Resource[] resources = new Resource[] { resource1, resource2, resource3, resource4 };
            return resources.Where(x => x.ProjectId == Convert.ToInt32(id));
        }
        [HttpGet("")]
        public IEnumerable<Resource> GetByProjId(int id)
        {
            Resource resource1 = new Resource { Id = 1, Name = "Good boy", Date = DateTime.UtcNow, Description = "https://www.brovarnya-rivne.com/img/images/poroda-hatiko-akita-inu-opisanie-i-harakter-uhod-za-yaponskoj-porodoj-iz-filma-hatiko.jpg", ProjectId = 1 };
            Resource resource4 = new Resource { Id = 4, Name = "Hatiko so sweety", Date = new DateTime(2015, 7, 20, 3, 17, 00), Description = "https://piensosloboazul.com/wp-content/uploads/2019/01/Hachiko-richard-gere.jpg", ProjectId = 1 };
            Resource resource2 = new Resource { Id = 2, Name = "Resource2", Date = new DateTime(2015, 7, 20), Description = "https://i.kym-cdn.com/photos/images/original/000/581/296/c09.jpg", ProjectId = 2 };
            Resource resource3 = new Resource { Id = 3, Name = "Resource3", Date = new DateTime(2015, 7, 20), Description = "https://i.kym-cdn.com/entries/icons/mobile/000/030/157/womanyellingcat.jpg", ProjectId = 3 };
            Resource[] resources = new Resource[] { resource1, resource2, resource3, resource4 };
            return resources.Where(x => x.ProjectId == id);
        }

    }
    //[Route("api/resources")]
    //public class NullableResController : Controller
    //{
    //    [HttpGet("")]
    //    public IEnumerable
    //}
}