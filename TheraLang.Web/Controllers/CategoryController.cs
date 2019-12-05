using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.DLL.Services;
using System.Collections.Generic;
using TheraLang.DLL.Entities;

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

        [HttpPut]
        [Route("update/{categoryId}/{newType}")]
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
            await _service.ChangeType(categoryId, newTypeName);
            return Ok();
        }

        [HttpGet]
        [Route("get")]
        public IEnumerable<ResourceCategory> GetAll()
        {
            IEnumerable<ResourceCategory> categories = _service.GetAllCategories();
            return categories;
        }
    }
}