using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.DLL.Entities;
using TheraLang.DLL.Models;
using TheraLang.DLL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class ResourceAttachmentService : IResourceAttachmentService
    {
        private readonly IUnitOfWork _uow;
        private readonly IHostingEnvironment _appEnvironment;
        public ResourceAttachmentService(IUnitOfWork uow, IHostingEnvironment appEnvironment)
        {
            _uow = uow;
            _appEnvironment = appEnvironment;
        }        

        public async Task Add(ResourceAttachModel file)
        {
            try
            {
                if (file.File != null)
                {
                    string path = "/Files/" + file.FileName;
                    using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        await file.File.CopyToAsync(fileStream);
                    }
                    ResourceAttachment model = new ResourceAttachment { FileName = file.FileName, Path = file.Path, ResourceId = file.ResourceId };
                    await _uow.Repository<ResourceAttachment>().Add(model);
                    await _uow.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {                
                ex.Data[nameof(ResourceAttachModel)] = file;
                throw new Exception("Error when adding file {nameof(ProjectType)}", ex);
            }
        } 
        
        public IEnumerable<ResourceAttachment> Get()
        {
            return _uow.Repository<ResourceAttachment>().Get().AsNoTracking().ToList();
        }
    }
}