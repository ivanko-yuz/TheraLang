using Microsoft.AspNetCore.Hosting;
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
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class ResourceAttachmentService : IResourceAttachmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHostingEnvironment _appEnvironment;
        public ResourceAttachmentService(IUnitOfWork unitOfWork, IHostingEnvironment appEnvironment)
        {
            _unitOfWork = unitOfWork;
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

                    await _unitOfWork.Repository<ResourceAttachment>().Add(resource);
                    await _unitOfWork.SaveChangesAsync();
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
            var resources = _unitOfWork.Repository<ResourceAttachment>().Get().AsNoTracking().ToList();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ResourceAttachment, ResourceAttachDto>()).CreateMapper();
            var resourceDto = mapper.Map<IEnumerable<ResourceAttachment>, IEnumerable<ResourceAttachDto>>(resources);

            return resourceDto;
        }
    }
}