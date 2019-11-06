﻿    using MvcWeb.TheraLang.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Services;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/resource")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        public ResourceController(IResourceService _service)
        {
            this.service = _service;
        }

        private readonly IResourceService service;

        [HttpPost]
        [Route("create/{resource}")]
        public async Task<IActionResult> PostResource([FromBody]Resource resource)
        {
            await service.AddResource(resource);
            
            return Ok();
        }

        [HttpPut]
        [Route("update/{resource}/{updatedById}")]
        public async Task<IActionResult> PutResource([FromBody] Resource resource, int updatedById)
        {
            await service.UpdateResource(resource, updatedById);

            return Ok();
        }

        [HttpGet]
        [Route("get/{Id}")]
        public IActionResult GetResource([FromBody]int Id)
        {
            Resource resource = service.GetResourceById(Id);

            return Ok(resource);
        }

        [HttpDelete]
        [Route("delete/{Id}")]
        public async Task<IActionResult> DeleteResource([FromBody]int Id)
        {
            await service.RemoveResource(Id);

            return Ok();
        }
    }
}