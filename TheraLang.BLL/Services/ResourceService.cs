using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Common;
using Common.Exceptions;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileService _fileService;

        public ResourceService(IUnitOfWork unitOfWork, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _fileService = fileService;
        }

        public async Task<ResourceDto> GetResourceById(int id)
        {
            var resource = await _unitOfWork.Repository<Resource>().Get(i => i.Id == id);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Resource, ResourceDto>()).CreateMapper();
            var resourceDto = mapper.Map<Resource, ResourceDto>(resource);

            return resourceDto;
        }

        public async Task<int> AddResource(ResourceDto resourceDto, Guid userId)
        {
            if (resourceDto.File != null)
            {
                using var fileStream = resourceDto.File.OpenReadStream();
                var fileExtension = Path.GetExtension(resourceDto.File.FileName);
                var fileUri = await _fileService.SaveFile(fileStream, fileExtension);
                resourceDto.Url = fileUri.ToString();
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ResourceDto, Resource>()
                    .ForMember(r => r.CreatedById, opt => opt.MapFrom(r => userId)))
                .CreateMapper();

            var resource = mapper.Map<ResourceDto, Resource>(resourceDto);

            _unitOfWork.Repository<Resource>().Add(resource);
            await _unitOfWork.SaveChangesAsync();
            return resource.Id;
        }

        public async Task UpdateResource(int id, ResourceDto resourceDto, Guid updatedById)
        {
            var resource = await _unitOfWork.Repository<Resource>().Get(i => i.Id == id) ??
                           throw new NotFoundException("Resource");
            
            resource.Name = resourceDto.Name;
            resource.Description = resourceDto.Description;
            resource.Url = resourceDto.Url;
            resource.UpdatedById = updatedById;
            resource.UpdatedDateUtc = DateTime.Now;

            _unitOfWork.Repository<Resource>().Update(resource);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveResource(int id)
        {
            var resource = await _unitOfWork.Repository<Resource>().Get(i => i.Id == id) ??
                           throw new NotFoundException("Resource");
            
            _unitOfWork.Repository<Resource>().Remove(resource);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<ResourceDto>> GetResources(int? categoryId, int? projectId,
            PaginationParams paginationParams)
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Resource, ResourceDto>()
                    .ForMember(dto => dto.AuthorName,
                        opts => opts.MapFrom(resource =>
                            $"{resource.User.Details.FirstName} {resource.User.Details.LastName}"));
            });

            var resources = await _unitOfWork.Repository<Resource>()
                .GetAll()
                .Where(r => categoryId == null || r.CategoryId == categoryId)
                .Where(r => projectId == null || r.ResourceProjects.Any(rp => rp.ProjectId == projectId))
                .OrderByDescending(r => r.CreatedDateUtc)
                .Skip(paginationParams.Skip)
                .Take(paginationParams.Take)
                .ProjectTo<ResourceDto>(mapper)
                .ToListAsync();
            
            return resources;
        }

        public async Task<int> GetResourcesCount(int? categoryId, int? projectId)
        {
            var resourcesCount = await _unitOfWork.Repository<Resource>()
                .GetAll()
                .Where(r => categoryId == null || r.CategoryId == categoryId)
                .Where(r => projectId == null || r.ResourceProjects.Any(rp => rp.ProjectId == projectId))
                .CountAsync();

            return resourcesCount;
        }

        public async Task<IEnumerable<ResourceCategoryDto>> GetResourcesCategories(int? projectId, bool includeEmpty)
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ResourceCategory, ResourceCategoryDto>();
                cfg.CreateMap<Resource, ResourceDto>();
            });

            var resourceCategories = await _unitOfWork.Repository<ResourceCategory>().GetAll()
                .Where(cat =>
                    includeEmpty || cat.Resources.Any(r =>
                        projectId == null || r.ResourceProjects.Any(rp => rp.ProjectId == projectId)))
                .ProjectTo<ResourceCategoryDto>(mapper)
                .ToListAsync();

            return resourceCategories;
        }

        public async Task<IEnumerable<ResourceDto>> GetAllResources()
        {
            var resources = await _unitOfWork.Repository<Resource>().GetAllAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Resource, ResourceDto>()).CreateMapper();
            var resourceDtos = mapper.Map<IEnumerable<Resource>, IEnumerable<ResourceDto>>(resources);

            return resourceDtos;
        }
    }
}