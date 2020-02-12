using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;
using System.IO;
using System.Linq.Expressions;
using AutoMapper;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;

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
            try
            {
                var resource = await _unitOfWork.Repository<Resource>().Get(i => i.Id == id);

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Resource, ResourceDto>()).CreateMapper();
                var resourceDto = mapper.Map<Resource, ResourceDto>(resource);

                return resourceDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when getting resource by {nameof(id)}={id}: ", ex);
            }
        }

        public async Task AddResource(ResourceDto resourceDto, Guid userId)
        {
            try
            {
                if (resourceDto.File != null)
                {
                    var fileUri = await _fileService.SaveFile(resourceDto.File);
                    resourceDto.Url = fileUri.ToString();
                }

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ResourceDto, Resource>()
                    .ForMember(r => r.File, opt => opt.Ignore())
                    .ForMember(r => r.CreatedById, opt => opt.MapFrom(r => userId))
                ).CreateMapper();

                var resource = mapper.Map<ResourceDto, Resource>(resourceDto);

                _unitOfWork.Repository<Resource>().Add(resource);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when adding the {nameof(resourceDto)}: ", ex);
            }
        }

        public async Task UpdateResource(int id, ResourceDto resourceDto, Guid updatedById)
        {
            try
            {
                if (resourceDto.File != null)
                {
                    using (var binaryReader = new BinaryReader(resourceDto.File.OpenReadStream()))
                    {
                        var byteFile = binaryReader.ReadBytes((int) resourceDto.File.Length);
                        BitConverter.ToString(byteFile);
                    }
                }

                var resource = await _unitOfWork.Repository<Resource>().Get(i => i.Id == id);

                if (resource != null)
                {
                    resource.Name = resourceDto.Name;
                    resource.Description = resourceDto.Description;
                    resource.Url = resourceDto.Url;
                    resource.FileName = resourceDto.FileName;

                    _unitOfWork.Repository<Resource>().Update(resource);
                    await _unitOfWork.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when updating the {nameof(resourceDto)}: {id} ", ex);
            }
        }

        public async Task RemoveResource(int id)
        {
            try
            {
                var resource = await _unitOfWork.Repository<Resource>().Get(i => i.Id == id);
                _unitOfWork.Repository<Resource>().Remove(resource);

                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when remove resource by {nameof(id)}: {id} ", ex);
            }
        }

        public async Task<IEnumerable<ResourceDto>> GetResourcesByCategoryId(int categoryId, int pageNumber,
            int recordsPerPage)
        {
            try
            {
                var resources = (await _unitOfWork.Repository<Resource>().GetAllAsync(x => x.CategoryId == categoryId))
                    .Skip((pageNumber - 1) * recordsPerPage)
                    .Take(recordsPerPage).ToList();


                var mapper = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Resource, ResourceDto>()
                        .ForMember(res => res.File, opt => opt.Ignore());
                }).CreateMapper();
                var resourcesPerPagesDto = mapper.Map<IEnumerable<Resource>, IEnumerable<ResourceDto>>(resources);

                return resourcesPerPagesDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when get resources by {nameof(categoryId)} = {categoryId}", ex);
            }
        }

        public async Task<int> GetResourcesCount(int categoryId)
        {
            try
            {
                var resourcesCount =
                    (await _unitOfWork.Repository<Resource>().GetAllAsync()).Count(x => x.CategoryId == categoryId);
                return resourcesCount;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when get resources count by category id", ex);
            }
        }

        public async Task<IEnumerable<ResourceCategoryDto>> GetResourcesCategories(bool withAssignedResources)
        {
            try
            {
                var resourceEntities = await _unitOfWork.Repository<ResourceCategory>()
                    .GetAllAsync(
                        withAssignedResources
                            ? cat => cat.Resources.Any()
                            : (Expression<Func<ResourceCategory, bool>>) null
                    );
                var mapper = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<ResourceCategory, ResourceCategoryDto>(MemberList.None);
                        cfg.CreateMap<Resource, ResourceDto>(MemberList.None)
                            .ForMember(r => r.File, opt => opt.Ignore());
                    })
                    .CreateMapper();
                var resourceCategoriesDto =
                    mapper.Map<IEnumerable<ResourceCategory>, IEnumerable<ResourceCategoryDto>>(resourceEntities);

                return resourceCategoriesDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when get all Resource Categories", ex);
            }
        }

        public async Task<IEnumerable<ResourceDto>> GetAllResourcesByProjectId(int projectId)
        {
            try
            {
                var resources = await _unitOfWork.Repository<Resource>()
                    .GetAllAsync(x => x.ResourceProjects.Any(c => c.ProjectId == projectId));
                var joinedResources = resources.Select(res =>
                    new Resource
                    {
                        Id = res.Id,
                        User = res.User,
                        Name = res.Name,
                        Description = res.Description,
                        Url = res.Url,
                        File = res.File,
                        CategoryId = res.CategoryId,
                        ResourceCategory = res.ResourceCategory,
                        ResourceProjects = res.ResourceProjects,
                        UpdatedById = res.UpdatedById,
                        CreatedDateUtc = res.CreatedDateUtc,
                        UpdatedDateUtc = res.UpdatedDateUtc,
                    }).ToList();

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Resource, ResourceDto>()).CreateMapper();
                var joinedResourcesDto = mapper.Map<IEnumerable<Resource>, IEnumerable<ResourceDto>>(joinedResources);

                return joinedResourcesDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when get all resources by {nameof(projectId)} = {projectId} ", ex);
            }
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