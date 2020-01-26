using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AutoMapper;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;

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
       public IActionResult UploadFile([FromBody]ResourceAttachViewModel resourceModel)
       {
           if (resourceModel == null)
           {
               throw new ArgumentException($"{nameof(resourceModel)} cannot be null");
           }

           var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ResourceAttachViewModel, ResourceAttachDto>()).CreateMapper();
           var resourceDto = mapper.Map<ResourceAttachViewModel, ResourceAttachDto>(resourceModel);

            _attachment.Add(resourceDto);
           return Ok(resourceDto);
       }
       [HttpGet]
       public IEnumerable<ResourceAttachDto> GetAllTypes()
       {
           return _attachment.Get();
       }
   }
}