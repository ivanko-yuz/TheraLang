using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Models;
using TheraLang.DAL.UnitOfWork;

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

        public async Task Add(ResourceAttachDto file)
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

                    var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ResourceAttachDto, ResourceAttachment>()).CreateMapper();
                    var resource = mapper.Map<ResourceAttachDto, ResourceAttachment>(file);

                    await _uow.Repository<ResourceAttachment>().Add(resource);
                    await _uow.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                ex.Data[nameof(ResourceAttachDto)] = file;
                throw new Exception("Error when adding file {nameof(ProjectType)}", ex);
            }
        }

        public IEnumerable<ResourceAttachDto> Get()
        {
            var resources = _uow.Repository<ResourceAttachment>().Get().AsNoTracking().ToList();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ResourceAttachment, ResourceAttachDto>()).CreateMapper();
            var resourceDto = mapper.Map<IEnumerable<ResourceAttachment>, IEnumerable<ResourceAttachDto>>(resources);

            return resourceDto;
        }
    }
}