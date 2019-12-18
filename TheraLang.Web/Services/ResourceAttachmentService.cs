using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.DLL.Entities;
using TheraLang.DLL.UnitOfWork;

namespace TheraLang.Web.Services
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
        public Stream InputStream { get; set; }

        public async Task Add(ResourceAttachment file)
        {
            var newFile = new ResourceAttachment { FileName = file.FileName, Path = file.Path, ResourceId = file.ResourceId };
            try
            {
                await _uow.Repository<ResourceAttachment>().Add(newFile);
                await _uow.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["file"] = file;
                throw;
            }
        }
        public void SaveAs(ResourceAttachment resource, bool overwrite = true, bool autoCreateDirectory = true)
        {
            try
            {
                if (autoCreateDirectory)
                {
                    var directory = new FileInfo(Path.Combine(resource.Path, resource.FileName)).Directory;
                    if (directory == null) directory.Create();
                }
                var newPath = Path.Combine(_appEnvironment.WebRootPath, "uploads", resource.FileName);
                File.Copy(Path.Combine(resource.Path, resource.FileName), newPath, overwrite);
            }
            catch (Exception e)
            {
                throw new Exception($"Error when adding the {nameof(resource)}: ", e);
            }
        }
        public IEnumerable<ResourceAttachment> Get()
        {
            return _uow.Repository<ResourceAttachment>().Get().AsNoTracking().ToList();
        }
    }
}