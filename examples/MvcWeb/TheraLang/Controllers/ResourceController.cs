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
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            bool result = await service.AddResource(resource);
            if(!result)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> PutResource(Resource resource, int updatedById)
        {
           if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            bool result = await service.UpdateResource(resource, updatedById);
            if(!result)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
