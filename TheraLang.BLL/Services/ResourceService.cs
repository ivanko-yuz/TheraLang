using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;
using System.IO;
using AutoMapper;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;

namespace TheraLang.BLL.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResourceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ResourceDto GetResourceById(int id)
        {
            try
            {
                Resource resource = _unitOfWork.Repository<Resource>().Get().SingleOrDefault(i => i.Id == id);

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
                string resourceFileString = "";

                if (resourceDto.File != null)
                {
                    using (BinaryReader binaryReader = new BinaryReader(resourceDto.File.OpenReadStream()))
                    {
                        byte[] byteFile = binaryReader.ReadBytes((int)resourceDto.File.Length);
                        resourceFileString = BitConverter.ToString(byteFile);
                    }
                }

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ResourceDto, Resource>()
                    .ForMember(r => r.File, opt => opt.MapFrom(r => resourceFileString))
                ).CreateMapper();

                var resource = mapper.Map<ResourceDto, Resource>(resourceDto);

                await _unitOfWork.Repository<Resource>().Add(resource);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when adding the {nameof(resourceDto)}: ", ex);
            }
        }

        public async Task UpdateResource(ResourceDto resourceDto, Guid updatedById)
        {
            try
            {
                string resourceFileString = "";

                if (resourceDto.File != null)
                {
                    using (BinaryReader binaryReader = new BinaryReader(resourceDto.File.OpenReadStream()))
                    {
                        byte[] byteFile = binaryReader.ReadBytes((int)resourceDto.File.Length);
                        resourceFileString = BitConverter.ToString(byteFile);
                    }
                }

                Resource resource = _unitOfWork.Repository<Resource>().Get().FirstOrDefault(i => i.Id == resourceDto.Id);

                if (resource != null)
                {
                    resource.Name = resourceDto.Name;
                    resource.Description = resourceDto.Description;
                    resource.Url = resourceDto.Url;
                    resource.FileName = resourceDto.FileName;
                    resource.File = resourceFileString;
                    resource.CategoryId = resourceDto.CategoryId;
                    resource.UpdatedById = updatedById;

                    _unitOfWork.Repository<Resource>().Update(resource);
                    await _unitOfWork.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when updating the {nameof(resourceDto)}: {resourceDto.Id} ", ex);
            }
        }

        public async Task RemoveResource(int id)
        {
            try
            {
                Resource resource = _unitOfWork.Repository<Resource>().Get().SingleOrDefault(i => i.Id == id);
                _unitOfWork.Repository<Resource>().Remove(resource);

                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when remove resource by {nameof(id)}: {id} ", ex);
            }
        }

        public IEnumerable<ResourceDto> GetResourcesByCategoryId(int categoryId, int pageNumber, int recordsPerPage)
        {
            try
            {
                var resources = _unitOfWork.Repository<Resource>().Get().Where(x => x.CategoryId == categoryId);
                var joinedResources = (from res in resources
                                       select new Resource
                                       {
                                           Id = res.Id,
                                           PiranhaUser = res.PiranhaUser,
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
                                       });

                var resourcesPerPages = joinedResources.Skip((pageNumber - 1) * recordsPerPage)
                    .Take(recordsPerPage).ToList();

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Resource, ResourceDto>()).CreateMapper();
                var resourcesPerPagesDto = mapper.Map<IEnumerable<Resource>, IEnumerable<ResourceDto>>(resourcesPerPages);

                return resourcesPerPagesDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when get resources by {nameof(categoryId)} = {categoryId}", ex);
            }
        }

        public int GetResourcesCount(int categoryId)
        {
            try
            {
                var resourcesCount = _unitOfWork.Repository<Resource>().Get().Count(x => x.CategoryId == categoryId);
                return resourcesCount;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when get resources count by category id", ex);
            }
        }

        public IEnumerable<ResourceCategoryDto> GetResourcesCategories(bool withAssignedResources)
        {
            try
            {
                IEnumerable<ResourceCategory> query = _unitOfWork.Repository<ResourceCategory>().Get().ToList();

                if (withAssignedResources)
                {
                    query = query.Where(x => x.Resources.Any());
                }

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ResourceCategory, ResourceCategoryDto>())
                    .CreateMapper();
                var resourceCategoriesDto = mapper.Map<IEnumerable<ResourceCategory>, IEnumerable<ResourceCategoryDto>>(query);

                return resourceCategoriesDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when get all Resource Categories", ex);
            }
        }

        public IEnumerable<ResourceDto> GetAllResourcesByProjectId(int projectId)
        {
            try
            {
                var resources = _unitOfWork.Repository<Resource>().Get().Where(x => x.ResourceProjects.Any(c => c.ProjectId == projectId));
                var joinedResources = (from res in resources
                                       select new Resource
                                       {
                                           Id = res.Id,
                                           PiranhaUser = res.PiranhaUser,
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
    }
}
