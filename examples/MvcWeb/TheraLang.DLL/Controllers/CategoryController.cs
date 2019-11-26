using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Services;
using System;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public CategoryController(IResourceCategoryService service)
        {
            _service = service;
        }

        private readonly IResourceCategoryService _service;

        [HttpPut]
        [Route("create/{categoryId}/{newType}")]
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
    }
}