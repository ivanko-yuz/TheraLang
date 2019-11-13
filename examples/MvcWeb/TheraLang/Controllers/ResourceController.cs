using MvcWeb.TheraLang.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using MvcWeb.TheraLang.Constants;

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
        [Route("all/project/{id}")]
        public IActionResult GetAllResourcesByProjectId(int id)
        {
             IEnumerable<Resource> resourse = service.GetAllResourcesByProjectId(id);
             return Ok(resourse);
        }

        [HttpGet]
        [Route("all/{pageNumber}/{recordsPerPage?}")]
        public IActionResult GetAllResources(int pageNumber = 0, int recordsPerPage = PaginationConstants.RecordsPerPage)
        {
             IEnumerable<Resource> resourse = service.GetAllResources(pageNumber, recordsPerPage); 
            return Ok(resourse);
        }
        [HttpGet]
        [Route("all/count")]
        public IActionResult GetCountAllResources()
        {
            int countResources = service.GetCountAllResources();
            return Ok(countResources);
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
