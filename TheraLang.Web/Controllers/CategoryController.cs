using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace TheraLang.Web.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public CategoryController(IResourceCategoryService service)
        {
            _service = service;
        }

        private readonly IResourceCategoryService _service;

        /// <summary>
        /// change resource category
        /// </summary>
        /// <param name="categoryId">id of category you want to change</param>
        /// <param name="newTypeName">new name of selected category</param>
        /// <returns>wil return just status code</returns>
        [HttpPut]
        [Authorize]
        [Route("update/{categoryId}/{newTypeName}")]
        public async Task<IActionResult> PutType(int categoryId, string newTypeName)
        {
            if (categoryId == default)
            {
                throw new ArgumentException($"{nameof(categoryId)} can not be 0");
            }

            if (newTypeName == null)
            {
                throw new ArgumentException($"{nameof(newTypeName)} can not be null");
            }

            await _service.ChangeTypeName(categoryId, newTypeName);
            return Ok();
        }

        /// <summary>
        /// get all ResourceCategories
        /// </summary>
        /// <returns>array of ResourceCategories</returns>
        [HttpGet]
        [Authorize]
        [Route("get")]
        public async Task<IEnumerable<ResourceCategoryDto>> GetAll()
        {
            var categories = await _service.GetAllCategories();
            return categories;
        }
    }
}