﻿using Microsoft.AspNetCore.Mvc;
using System;
using TheraLang.BLL.Services;
using TheraLang.DLL.Entities;
using System.Collections.Generic;
using TheraLang.DLL.Models;

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
       public IActionResult UploadFile([FromBody]ResourceAttachModel resource)
       {
           if (resource == null)
           {
               throw new ArgumentException($"{nameof(resource)} cannot be null");
           }
          
           _attachment.Add(resource);
           return Ok(resource);
       }
       [HttpGet]
       public IEnumerable<ResourceAttachment> GetAllTypes()
       {
           return _attachment.Get();
       }
   }
}