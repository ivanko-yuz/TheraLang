using MvcWeb.TheraLang.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Services;
using System;
using System.Collections.Generic;
using MvcWeb.TheraLang.Constants;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/resource")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        public ResourceController(IResourceService service)
        {
            this._service = service;
        }

        private readonly IResourceService _service;

        [HttpPost]
        [Route("create/{resource}")]
        public async Task<IActionResult> PostResource([FromBody]Resource resource)
        {
            await _service.AddResource(resource);
            
            return Ok();
        }

        [HttpPut]
        [Route("update/{resource}/{updatedById}")]
        public async Task<IActionResult> PutResource([FromBody] Resource resource, Guid updatedById)
        {
            await _service.UpdateResource(resource, updatedById);

            return Ok();
        }

        [HttpGet]
        [Route("get/{Id}")]
        public IActionResult GetResource([FromBody]int id)
        {

            {
                Resource resource = _service.GetResourceById(id);
                return Ok(resource);
            }
        }

        [HttpGet]
        [Route("all/project/{id}")]
        public IActionResult GetAllResourcesByProjectId(int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} cannot be 0");
            }
            IEnumerable<Resource> resources = _service.GetAllResourcesByProjectId(id);
             return Ok(resources);
        }

        [HttpGet]
        [Route("all/{pageNumber}/{recordsPerPage?}")]
        public IActionResult GetAllResources(int pageNumber, int recordsPerPage = PaginationConstants.RecordsPerPage)
        {
            if (pageNumber == default)
            {
                throw new ArgumentException($"{nameof(pageNumber)} cannot be 0");
            }
            IEnumerable<Resource> resources = _service.GetAllResources(pageNumber, recordsPerPage); 
            return Ok(resources);
        }

        [HttpGet]
        [Route("all/count")]
        public IActionResult GetCountAllResources()
        {
            int countResources = _service.GetCountAllResources();
            return Ok(countResources);
        }

        [HttpDelete]
        [Route("delete/{Id}")]
        public async Task<IActionResult> DeleteResource([FromBody]int id)
        {
            await _service.RemoveResource(id);

            return Ok();
        }
    }
}
