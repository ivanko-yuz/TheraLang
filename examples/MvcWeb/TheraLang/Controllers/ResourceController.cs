using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Constants;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/resource")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class ResourceController : ControllerBase
    {
        public ResourceController(IResourceService service)
        {
            _service = service;
        }

        private readonly IResourceService _service;

        [HttpPost]
        [Route("create/{resource}")]
        public async Task<IActionResult> PostResource([FromBody]Resource resource)
        {
            if (resource == null)
            {
                throw new ArgumentException($"{nameof(resource)} can not be null");
            }
            await _service.AddResource(resource);
            return Ok();
        }

        [HttpPut]
        [Route("update/{resource}/{updatedById}")]
        public async Task<IActionResult> PutResource([FromBody] Resource resource, int updatedById)
        {
            if (updatedById == default)
            {
                throw new ArgumentException($"{nameof(updatedById)} can not be 0");
            }
            if (resource == null)
            {
                throw new ArgumentException($"{nameof(resource)} can not be null");
            }
            await _service.UpdateResource(resource, updatedById);
            return Ok();
        }

        [HttpGet]
        [Route("get/{Id}")]
        public IActionResult GetResource([FromBody]int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }
            Resource resource = _service.GetResourceById(id);
            return Ok(resource);
        }

        [HttpDelete]
        [Route("delete/{Id}")]
        public async Task<IActionResult> DeleteResource([FromBody]int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }
            await _service.RemoveResource(id);
            return Ok();
        }

        [HttpGet]
        [Route("categories/{withAssignedResources}")]
        public IActionResult GetResourcesCategories(bool withAssignedResources)
        {
            var countResources = _service.GetResourcesCategories(withAssignedResources);
            return Ok(countResources);
        }

        [HttpGet]
        [Route("count/{categoryId}")]
        public IActionResult CountResourcesByCategoryId(int categoryId)
        {
            if (categoryId == default)
            {
                throw new ArgumentException($"{nameof(categoryId)} cannot be 0");
            }
            int count = _service.CountResourcesByCategoryId(categoryId);
            return Ok(count);
        }

        [HttpGet]
        [Route("all/{categoryId}/{pageNumber}/{recordsPerPage?}")]
        public IActionResult GetAllResourcesByCategoryId(int categoryId, int pageNumber,
            int recordsPerPage = PaginationConstants.RecordsPerPage)
        {
            if (pageNumber == default || categoryId == default)
            {
                throw new ArgumentException($"{nameof(pageNumber)} cannot be 0");
            }

            IEnumerable<Resource> resources = _service.GetResourcesByCategoryId(categoryId, pageNumber, recordsPerPage);
            return Ok(resources);
        }

        [HttpGet]
        [Route("all/{projectId}")]
        public IActionResult GetAllResourcesByProjectId(int projectId)
        {
            if (projectId == default)
            {
                throw new ArgumentException($"{nameof(projectId)} cannot be 0");
            }

            IEnumerable<Resource> resources = _service.GetAllResourcesByProjectId(projectId);
            return Ok(resources);
        }
    }
}
