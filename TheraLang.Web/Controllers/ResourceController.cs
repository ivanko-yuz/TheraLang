using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using AutoMapper;
using TheraLang.Web.ViewModels;
using Piranha.AspNetCore.Identity.Data;
using FluentValidation;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.DataTransferObjects.Constants;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace TheraLang.Web.Controllers
{
    [Route("api/resources")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        public ResourceController(IResourceService service, IUserManagementService userManager, IValidator<ResourceViewModel> validator)
        {
            _service = service;
            _userManager = userManager;
            _validator = validator;
        }

        private readonly IResourceService _service;
        private readonly IUserManagementService _userManager;
        private readonly IValidator<ResourceViewModel> _validator;

        /// <summary>
        /// create resource
        /// </summary>
        /// <param name="resourceModel">Resource param which was given through POST body</param>
        /// <returns>status code</returns>
        [HttpPost]
        [Authorize]
        [Route("create")]
        public async Task<IActionResult> PostResource([FromForm] ResourceViewModel resourceModel)
        {
            var validationResult = _validator.Validate(resourceModel);

            if (!validationResult.IsValid)
            {
                throw new ArgumentException($"{nameof(resourceModel)} is not valid");
            }
            var UserId = User.Claims.GetUserId();
            if (UserId == null) return BadRequest();
            var user = _userManager.GetUserById(UserId.Value);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ResourceViewModel, ResourceDto>()).CreateMapper();
            var resourceDto = mapper.Map<ResourceViewModel, ResourceDto>(resourceModel);

            await _service.AddResource(resourceDto, UserId.Value);
            return Ok();
        }

        /// <summary>
        /// Create new Resource
        /// </summary>
        ///  <param name="id"></param>
        /// <param name="resourceModel"></param>
        /// <returns>status code</returns>
        [HttpPut]
        [Authorize]
        [Route("update/{id}")]
        public async Task<IActionResult> PutResource(int id, [FromBody] ResourceViewModel resourceModel)
        {

            var resource = _service.GetResourceById(id);

            if (resource == null)
            {
                return NotFound();
            }

            var validationResult = _validator.Validate(resourceModel);

            if (!validationResult.IsValid)
            {
                throw new ArgumentException($"{nameof(resourceModel)} is not valid");
            }

            var UserId = User.Claims.GetUserId();
            if (UserId == null) return BadRequest();
            var user = _userManager.GetUserById(UserId.Value);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ResourceViewModel, ResourceDto>()).CreateMapper();
            var resourceDto = mapper.Map<ResourceViewModel, ResourceDto>(resourceModel);

            await _service.AddResource(resourceDto, UserId.Value);
            return Ok();
        }

        /// <summary>
        /// Get Resource by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>selected resource</returns>
        [HttpGet]
        [Route("get/{Id}")]
        [Authorize]
        public IActionResult GetResource(int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }
            var resource = _service.GetResourceById(id);
            return Ok(resource);
        }

        /// <summary>
        /// Delete Resource by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>status code</returns>
        [HttpDelete]
        [Route("delete/{Id}")]
        [Authorize]
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
        [Authorize]
        public IActionResult GetResourcesCategories(bool withAssignedResources)
        {
            var categories = _service.GetResourcesCategories(withAssignedResources);
            return Ok(categories);
        }

        /// <summary>
        /// Get all Resources
        /// </summary>
        /// <returns>array of resources</returns>
        [HttpGet]
        public IActionResult GetAllResources()
        {
            var resources = _service.GetAllResources();
            return Ok(resources);
        }

        /// <summary>
        /// Get count of Resources that belong to Category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>count</returns>
        [HttpGet]
        [Route("count/{categoryId}")]
        [Authorize]
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
        [Authorize]
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

            var resources = _service.GetResourcesByCategoryId(categoryId, pageNumber, recordsPerPage);
            return Ok(resources);
        }

        /// <summary>
        /// Get all Resources by Project
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns>selected Project</returns>
        [HttpGet]
        [Route("all/{projectId}")]
        [Authorize]
        public IActionResult GetAllResourcesByProjectId(int projectId)
        {
            if (projectId == default)
            {
                throw new ArgumentException($"{nameof(projectId)} cannot be 0");
            }

            var resources = _service.GetAllResourcesByProjectId(projectId);
            return Ok(resources);
        }
    }
}
