using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;
using TheraLang.Web.ViewModels.Resources;

namespace TheraLang.Web.Controllers
{
    [Route("api/resources")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        public ResourceController(IResourceService service, IUserManagementService userManager,
            IAuthenticateService authenticateService)
        {
            _service = service;
            _userManager = userManager;
            _authenticateService = authenticateService;
        }

        private readonly IResourceService _service;
        private readonly IUserManagementService _userManager;
        private readonly IAuthenticateService _authenticateService;
        
        /// <summary>
        /// Get Resource by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>selected resource</returns>
        [HttpGet]
        [Route("{Id}")]
        [Authorize]
        public async Task<IActionResult> GetResource(int id)
        {
            if (id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }

            var resource = await _service.GetResourceById(id);
            return Ok(resource);
        }
        
        /// <summary>
        /// Get all Resources
        /// </summary>
        /// <returns>array of resources</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllResources()
        {
            var resources = await _service.GetAllResources();
            return Ok(resources);
        }
        
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
            var authUser = await _authenticateService.GetAuthUserAsync();
            if (authUser == null) return BadRequest();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ResourceViewModel, ResourceDto>()).CreateMapper();
            var resourceDto = mapper.Map<ResourceViewModel, ResourceDto>(resourceModel);

            await _service.AddResource(resourceDto, authUser.Id);
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
        public async Task<IActionResult> PutResource(int id, [FromBody] ResourceTextInfoViewModel resourceModel)
        {
            var authUser = await _authenticateService.GetAuthUserAsync();
            
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ResourceTextInfoViewModel, ResourceDto>()).CreateMapper();
            var resourceDto = mapper.Map<ResourceTextInfoViewModel, ResourceDto>(resourceModel);

            await _service.UpdateResource(id, resourceDto, authUser.Id);
            return NoContent();
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
        /// <returns>array of categories</returns>
        [HttpGet]
        [Route("categories/{projectId?}")]
        [Authorize]
        public async Task<IActionResult> GetResourceCategories(int? projectId,[FromQuery]bool includeEmpty = false)
        {
            var categories = await _service.GetResourcesCategories(projectId, includeEmpty);

            var mapper = new MapperConfiguration(mapOpts =>
            {
                mapOpts.CreateMap<ResourceCategoryDto, ResourceCategoryViewModel>();
            }).CreateMapper();

            var categoryViewModels =
                mapper.Map<IEnumerable<ResourceCategoryDto>, IEnumerable<ResourceCategoryViewModel>>(categories);
            return Ok(categoryViewModels);
        }

        /// <summary>
        /// Get count of Resources that belong to Category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="projectId"></param>
        /// <returns>count</returns>
        [HttpGet]
        [Route("count/")]
        [Authorize]
        public async Task<IActionResult> CountResources([FromQuery] int? categoryId, [FromQuery] int? projectId)
        {
            var count = await _service.GetResourcesCount(categoryId, projectId);
            return Ok(count);
        }

        /// <summary>
        /// Get all Resources by Category with pagination
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>array of resources</returns>
        [HttpGet]
        [Route("category/{categoryId}/{projectId?}")]
        [Authorize]
        public async Task<IActionResult> GetAllResources(int categoryId, int? projectId,
            [FromQuery] PagingParametersViewModel pagingParametersViewModel)
        {
            var mapper = new MapperConfiguration(mapOpts =>
            {
                mapOpts.CreateMap<PagingParametersViewModel, PagingParametersDto>();
            }).CreateMapper();

            var pagingParameters = mapper.Map<PagingParametersDto>(pagingParametersViewModel);
            var resources = await _service.GetResourcesByCategoryId(categoryId, projectId, pagingParameters);
            return Ok(resources);
        }
    }
}