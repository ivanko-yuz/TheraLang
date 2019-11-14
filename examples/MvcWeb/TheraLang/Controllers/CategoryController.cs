using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Services;

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
            if( categoryId == default )
            {
                throw new System.ArgumentException($"{nameof(categoryId)} can not be 0");
            }
            await _service.ChangeType(categoryId, newTypeName);
            return Ok();
        }
    }
}