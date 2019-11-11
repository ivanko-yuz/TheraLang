﻿using MvcWeb.TheraLang.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Services;
using System;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/resource")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        public ResourceController(IResourceService service)
        {
            _service = service;
        }

        private readonly IResourceService _service;

        [HttpPost]
        [Route("create/{resource}")]
        public async Task<IActionResult> PostResource([FromBody]Resource resource)
        {
            if(resource == null)
            {
                throw new ArgumentException($"{nameof(resource)} can not be null");
            }
            await _service.AddResource(resource);            
            return Ok();
        }

        [HttpPut]
        [Route("update/{resource}/{updatedById}")]
        public async Task<IActionResult> PutResource([FromBody] Resource resource, Guid updatedById)
        {
            if (updatedById == default)
            {
                throw new ArgumentException($"{nameof(updatedById)} can not be 0");
            }
            if(resource == null)
            {
                throw new ArgumentException($"{nameof(resource)} can not be null");
            }
            await _service.UpdateResource(resource, updatedById);
            return Ok();
        }

        [HttpGet]
        [Route("get/{Id}")]
        public IActionResult GetResource([FromBody]int Id)
        {
            if (Id == default)
            {
                throw new ArgumentException($"{nameof(Id)} can not be 0");
            }
            Resource resource = _service.GetResourceById(Id);
            return Ok(resource);
        }

        [HttpDelete]
        [Route("delete/{Id}")]
        public async Task<IActionResult> DeleteResource([FromBody]int Id)
        {
            if (Id == default)
            {
                throw new ArgumentException($"{nameof(Id)} can not be 0");
            }
            await _service.RemoveResource(Id);
            return Ok();
        }
    }
}