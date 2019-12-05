using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.DLL.Constants;
using TheraLang.DLL.Entities;
using TheraLang.DLL.Services;
using TheraLang.DLL.Models;
using Microsoft.AspNetCore.Identity;

namespace TheraLang.Web.Controllers
{
    [Route("api/resources")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        public ResourceController(IResourceService service, UserManager<IdentityUser> manager)
        {
            _service = service;
            _userManager = manager;
        }

        private readonly IResourceService _service;
        private readonly UserManager<IdentityUser> _userManager;

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> PostResource([FromBody] ResourceViewModel resourceModel)
        {
            if (resourceModel == null)
            {
                throw new ArgumentException($"{nameof(resourceModel)} can not be null");
            }

            int userId = _userManager.GetUserAsync(HttpContext.User).Id;
            await _service.AddResource(resourceModel, userId);
            return Ok();
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> PutResource([FromBody] ResourceViewModel resourceModel)
        {
            if (resourceModel == null)
            {
                throw new ArgumentException($"{nameof(resourceModel)} can not be null");
            }

            int userId = _userManager.GetUserAsync(HttpContext.User).Id;
            await _service.AddResource(resourceModel, userId);
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
            var categories = _service.GetResourcesCategories(withAssignedResources);
            return Ok(categories);
        }

        [HttpGet]
        [Route("count/{categoryId}")]
        public IActionResult CountResourcesByCategoryId(int categoryId)
        {
            if (categoryId == default)
            {
                throw new ArgumentException($"{nameof(categoryId)} cannot be 0");
            }
            int count = _service.GetResourcesCount(categoryId);
            return Ok(count);
        }

        [HttpGet]
        [Route("all/{categoryId}/{pageNumber}/{recordsPerPage?}")]
        public IActionResult GetAllResourcesByCategoryId(int categoryId, int pageNumber,
            int recordsPerPage = PaginationConstants.RecordsPerPage)
        {
            if (pageNumber == default)
            {
                throw new ArgumentException($"{nameof(pageNumber)} cannot be 0");
            }

            if (categoryId == default)
            {
                throw new ArgumentException($"{nameof(categoryId)} cannot be 0");
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
