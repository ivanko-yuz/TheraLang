using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    //[ApiController]
    [Route("api/project/{id}/[controller]s")]
    public class ResourceController : Controller
    {
        [HttpGet("")]
        public IEnumerable<Resource> GetByProjId(int? id)
        {
            Resource resource1 = new Resource { 
                Id = 1,
                Name = "Good boy",
                Description = "https://www.brovarnya-rivne.com/img/images/poroda-hatiko-akita-inu-opisanie-i-harakter-uhod-za-yaponskoj-porodoj-iz-filma-hatiko.jpg",
                Date = DateTime.UtcNow,                
                ProjectId = 1,
                ResourceCategory = "Зображення"};
            Resource resource4 = new Resource { 
                Id = 2,
                Name = "Hatiko so sweety1",
                Description = "https://piensosloboazul.com/wp-content/uploads/2019/01/Hachiko-richard-gere.jpg",
                Date = new DateTime(2015, 7, 20, 3, 17, 00),                
                ProjectId = 1,
                ResourceCategory = "Відео"
            };
            Resource resource11 = new Resource
            {
                Id = 11,
                Name = "Hatiko so sweety2",
                Description = "https://piensosloboazul.com/wp-content/uploads/2019/01/Hachiko-richard-gere.jpg",
                Date = new DateTime(2015, 7, 20, 3, 17, 00),
                ProjectId = 1,
                ResourceCategory = "Посилання"
            };
            Resource resource5 = new Resource
            {
                Id = 10,
                Name = "Hatiko so sweety3",
                Description = "https://piensosloboazul.com/wp-content/uploads/2019/01/Hachiko-richard-gere.jpg",
                Date = new DateTime(2015, 7, 20, 3, 17, 00),
                ProjectId = 1,
                ResourceCategory = "Зображення"
            };
            Resource resource6 = new Resource
            {
                Id = 9,
                Name = "Hatiko so sweety4",
                Description = "https://piensosloboazul.com/wp-content/uploads/2019/01/Hachiko-richard-gere.jpg",
                Date = new DateTime(2015, 7, 20, 3, 17, 00),
                ProjectId = 1,
                ResourceCategory = "Відео"
            };
            Resource resource7 = new Resource
            {
                Id = 8,
                Name = "Hatiko so sweety5",
                Description = "https://piensosloboazul.com/wp-content/uploads/2019/01/Hachiko-richard-gere.jpg",
                Date = new DateTime(2015, 7, 20, 3, 17, 00),
                ProjectId = 1,
                ResourceCategory = "Зображення"
            };
            Resource resource8 = new Resource
            {
                Id = 7,
                Name = "Hatiko so sweety6 null",
                Description = "https://piensosloboazul.com/wp-content/uploads/2019/01/Hachiko-richard-gere.jpg",
                Date = new DateTime(2015, 7, 20, 3, 17, 00),
                ProjectId = null,
                ResourceCategory = "Зображення"
            };
            Resource resource9 = new Resource
            {
                Id = 6,
                Name = "Hatiko so sweety7",
                Description = "https://piensosloboazul.com/wp-content/uploads/2019/01/Hachiko-richard-gere.jpg",
                Date = new DateTime(2015, 7, 20, 3, 17, 00),
                ProjectId = 2,
                ResourceCategory = "Посилання"
            };
            Resource resource10 = new Resource
            {
                Id = 5,
                Name = "Hatiko so sweety8 null",
                Description = "https://piensosloboazul.com/wp-content/uploads/2019/01/Hachiko-richard-gere.jpg",
                Date = new DateTime(2015, 7, 20, 3, 17, 00),
                ProjectId = null,
                ResourceCategory = "Відео"
            };
            Resource resource2 = new Resource { 
                Id = 3,
                Name = "Resource2",
                Description = "https://i.kym-cdn.com/photos/images/original/000/581/296/c09.jpg",
                Date = new DateTime(2015, 7, 20),                
                ProjectId = 2,
                ResourceCategory = "Файли"
            };
            Resource resource3 = new Resource { 
                Id = 4,
                Name = "Resource3",
                Description = "https://i.kym-cdn.com/entries/icons/mobile/000/030/157/womanyellingcat.jpg",
                Date = new DateTime(2015, 7, 20),                
                ProjectId = 3,
                ResourceCategory = "Зображення"
            };



            Resource resource12 = new Resource
            {
                Id = 5,
                Name = "Hatiko so sweety8 null",
                Description = "https://piensosloboazul.com/wp-content/uploads/2019/01/Hachiko-richard-gere.jpg",
                Date = new DateTime(2015, 7, 20, 3, 17, 00),
                ProjectId = null,
                ResourceCategory = "Відео"
            };
            Resource resource13 = new Resource
            {
                Id = 3,
                Name = "Resource2 null",
                Description = "https://i.kym-cdn.com/photos/images/original/000/581/296/c09.jpg",
                Date = new DateTime(2015, 7, 20),
                ProjectId = null,
                ResourceCategory = "Файли"
            };
            Resource resource14 = new Resource
            {
                Id = 4,
                Name = "Resource3 null",
                Description = "https://i.kym-cdn.com/entries/icons/mobile/000/030/157/womanyellingcat.jpg",
                Date = new DateTime(2015, 7, 20),
                ProjectId = null,
                ResourceCategory = "Зображення"
            };

            Resource[] resources = new Resource[] { resource11, resource10, resource9, resource8, resource7,
                resource6, resource5, resource4, resource3, resource2, resource12, resource13 , resource14 };
            foreach(var res in resources)
            {
                res.Description = res.ResourceCategory;
            }
            return resources.Where(x => x.ProjectId == id);
        }

    }
}