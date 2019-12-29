using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DLL.Constants;
using TheraLang.DLL.Entities;
using TheraLang.DLL.Services;
using TheraLang.DLL.Models;
using Microsoft.AspNetCore.Identity;
using Piranha.AspNetCore.Identity.Data;
using FluentValidation;

namespace TheraLang.Web.Controllers
{
    [Route("api/resources")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        public ResourceController(IResourceService service, UserManager<User> userManager, IValidator<ResourceViewModel> validator)
        {
            _service = service;
            _userManager = userManager;
            _validator = validator;
        }

        private readonly IResourceService _service;
        private readonly UserManager<User> _userManager;
        private readonly IValidator<ResourceViewModel> _validator;

        /// <summary>
        /// create resource
        /// </summary>
        /// <param name="resourceModel">Resource param which was given through POST body</param>
        /// <returns>status code</returns>
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> PostResource([FromBody] ResourceViewModel resourceModel)
        {
            var validationResult = _validator.Validate(resourceModel);
            
            if (!validationResult.IsValid)
            {
                throw new ArgumentException($"{nameof(resourceModel)} is not valid");
            }

            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            Guid userId = user.Id;
            await _service.AddResource(resourceModel, userId);
            return Ok();
        }

        /// <summary>
        /// Create new Resource
        /// </summary>
        /// <param name="resourceModel"></param>
        /// <returns>status code</returns>
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> PutResource([FromBody] ResourceViewModel resourceModel)
        {
            var validationResult = _validator.Validate(resourceModel);

            if (!validationResult.IsValid)
            {
                throw new ArgumentException($"{nameof(resourceModel)} is not valid");
            }

            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            Guid userId = user.Id;
            await _service.AddResource(resourceModel, userId);
            return Ok();
        }

        /// <summary>
        /// Get Resource by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>selected resource</returns>
        [HttpGet]
        [Route("get/{Id}")]
        public IActionResult GetResource(int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }
            Resource resource = _service.GetResourceById(id);
            return Ok(resource);
        }

        /// <summary>
        /// Delete Resource by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>status code</returns>
        [HttpDelete]
        [Route("delete/{Id}")]
        public async Task<IActionResult> DeleteResource(int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }
            await _service.RemoveResource(id);
            return Ok();
        }

        /// <summary>
        /// Get all ResourcesCategories
        /// </summary>
        /// <param name="withAssignedResources">only those RC that are used</param>
        /// <returns>array of categories</returns>
        [HttpGet]
        [Route("categories/{withAssignedResources}")]
        public IActionResult GetResourcesCategories(bool withAssignedResources)
        {
            var categories = _service.GetResourcesCategories(withAssignedResources);
            return Ok(categories);
        }

        /// <summary>
        /// Get count of Resources that belong to Category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>count</returns>
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

        /// <summary>
        /// Get all Resources by Category with pagination
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="pageNumber"></param>
        /// <param name="recordsPerPage"></param>
        /// <returns>array of resources</returns>
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

        /// <summary>
        /// Get all Resources by Project
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns>selected Project</returns>
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
