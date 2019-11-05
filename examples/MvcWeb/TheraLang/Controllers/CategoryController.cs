using MvcWeb.TheraLang.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Services;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public CategoryController(IResourceCategoryService _service)
        {
            this.service = _service;
        }

        private readonly IResourceCategoryService service;

        [HttpPut]
        [Route("create/{categoryId}/{newType}")]
        public async Task<IActionResult> PutType(int categoryId, string newType)
        {
            await service.ChangeType(categoryId, newType);

            return Ok();
        }
    }
}