using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AutoMapper;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace TheraLang.Web.Controllers
{

   [Route("api/files")]
   [ApiController]
   public class ResourceAttachmentController : ControllerBase
   {
       public ResourceAttachmentController(IResourceAttachmentService attachment)
       {
           _attachment = attachment;
       }
       private readonly IResourceAttachmentService _attachment;

       [HttpPost("attach")]
        [Authorize]
        public async Task<IActionResult> UploadFile([FromBody]ResourceAttachViewModel resourceModel)
       {
           if (resourceModel == null)
           {
               throw new ArgumentException($"{nameof(resourceModel)} cannot be null");
           }

           var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ResourceAttachViewModel, ResourceAttachDto>()).CreateMapper();
           var resourceDto = mapper.Map<ResourceAttachViewModel, ResourceAttachDto>(resourceModel);

            await _attachment.AddAsync(resourceDto);
           return Ok(resourceDto);
       }
       [HttpGet]
        [Authorize]
        public  async Task<IEnumerable<ResourceAttachDto>> GetAllTypes()
       {
           return await _attachment.GetAsync();
       }
   }
}