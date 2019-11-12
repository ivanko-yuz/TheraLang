using MvcWeb.TheraLang.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/resource")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        public ResourceController(IResourceService _service)
        {
            this.service = _service;
        }

        private readonly IResourceService service;

        [HttpPost]
        [Route("create/{resource}")]
        public async Task<IActionResult> PostResource([FromBody]Resource resource)
        {
            await service.AddResource(resource);
            
            return Ok();
        }

        [HttpPut]
        [Route("update/{resource}/{updatedById}")]
        public async Task<IActionResult> PutResource([FromBody] Resource resource, Guid updatedById)
        {
            await service.UpdateResource(resource, updatedById);

            return Ok();
        }

        [HttpGet]
        [Route("get/{Id}")]
        public IActionResult GetResource([FromBody]int Id)
        {

            {
                Resource resource = service.GetResourceById(Id);
                return Ok(resource);
            }
        }
        [HttpGet]
        [Route("project/{Id}")]
        public IActionResult GetAllResourcesByProjectId(int Id) //only on projects page
        {
             IEnumerable<Resource> resourse = service.GetAllResourcesByProjectId(Id);
             return Ok(resourse);
        }

        [HttpGet]
        [Route("project")]
        public IActionResult GetAllResources(int pageNumber = 0, int recordsPerPage = 10)    //todo move to constant PaginationConsts -> RecordsPerPage
        {
             IEnumerable<Resource> resourse = service.GetAllResources(pageNumber, recordsPerPage);  //todo: implement and change naming in entity ResourceProject to ResourceProjects
            return Ok(resourse);
        }

        [HttpDelete]
        [Route("delete/{Id}")]
        public async Task<IActionResult> DeleteResource([FromBody]int Id)
        {
            await service.RemoveResource(Id);

            return Ok();
        }
    }
}
