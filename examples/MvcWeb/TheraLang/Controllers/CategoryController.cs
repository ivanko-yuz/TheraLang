using MvcWeb.TheraLang.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Services;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public CategoryController(IResourceCategotyService _service)
        {
            this.service = _service;
        }

        private readonly IResourceCategotyService service;

        [HttpPut]
        public async Task<IActionResult> PutType(int categoryId, string newType)
        {
            await service.ChangeType(categoryId, newType);

            return Ok();
        }
    }
}