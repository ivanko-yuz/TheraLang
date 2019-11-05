using MvcWeb.TheraLang.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Services;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        public ResourceController(IResourceService _service)
        {
            this.service = _service;
        }

        private readonly IResourceService service;

        [HttpPost]
        public async Task<IActionResult> PostResource(Resource resource)
        {
            await service.AddResource(resource);
            
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> PutResource(Resource resource, int updatedById)
        {
            await service.UpdateResource(resource, updatedById);

            return Ok();
        }

        [HttpGet]
        public IActionResult GetResource(int Id)
        {
            Resource resource = service.GetResourceById(Id);

            return Ok(resource);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteResource(int Id)
        {
            await service.RemoveResource(Id);

            return Ok();
        }
    }
}
