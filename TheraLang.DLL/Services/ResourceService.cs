using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.DLL.Entities;
using TheraLang.DLL.UnitOfWork;
using TheraLang.DLL.Models;
using System.IO;

namespace TheraLang.DLL.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResourceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Resource GetResourceById(int id)
        {
            try
            {
                Resource resource = _unitOfWork.Repository<Resource>().Get().SingleOrDefault(i => i.Id == id);
                return resource;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when getting resource by {nameof(id)}={id}: ", ex);
            }
        }

        public async Task AddResource(ResourceViewModel resourceModel, Guid userId)
        {
            try
            {
                string resourceFileString = "";

                if (resourceModel.file != null)
                {
                    using (BinaryReader binaryReader = new BinaryReader(resourceModel.file.OpenReadStream()))
                    {
                        byte[] byteFile = binaryReader.ReadBytes((int)resourceModel.file.Length);
                        resourceFileString = BitConverter.ToString(byteFile);
                    }
                }

                Resource resource = new Resource
                {
                    Name = resourceModel.name,
                    Description = resourceModel.description,
                    Url = resourceModel.url,
                    FileName = resourceModel.fileName,
                    File = resourceFileString,
                    CategoryId = resourceModel.categoryId,
                    CreatedById = userId
                };

                await _unitOfWork.Repository<Resource>().Add(resource);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when adding the {nameof(resourceModel)}: ", ex);
            }
        }

        public async Task UpdateResource(ResourceViewModel resourceModel, Guid updatetById)
        {
            try
            {
                string resourceFileString = "";

                if (resourceModel.file != null)
                {
                    using (BinaryReader binaryReader = new BinaryReader(resourceModel.file.OpenReadStream()))
                    {
                        byte[] byteFile = binaryReader.ReadBytes((int)resourceModel.file.Length);
                        resourceFileString = BitConverter.ToString(byteFile);
                    }
                }

                Resource resource = _unitOfWork.Repository<Resource>().Get().FirstOrDefault(i => i.Id == resourceModel.id);

                resource.Name = resourceModel.name;
                resource.Description = resourceModel.description;
                resource.Url = resourceModel.url;
                resource.FileName = resourceModel.fileName;
                resource.File = resourceFileString;
                resource.CategoryId = resourceModel.categoryId;
                resource.UpdatedById = updatetById;

                _unitOfWork.Repository<Resource>().Update(resource);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when updating the {nameof(resourceModel)}: {resourceModel.id} ", ex);
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

        public IEnumerable<Resource> GetResourcesByCategoryId(int categoryId, int pageNumber, int recordsPerPage)
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
                return resourcesPerPages;
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

        public IEnumerable<ResourceCategory> GetResourcesCategories(bool withAssignedResources)
        {
            try
            {
                var query = _unitOfWork.Repository<ResourceCategory>().Get();

                if (withAssignedResources)
                {
                    query = query.Where(x => x.Resources.Any());
                }

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when get all Resource Categories", ex);
            }
        }

        public IEnumerable<Resource> GetAllResourcesByProjectId(int projectId)
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
                                       });
                return joinedResources.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when get all resources by {nameof(projectId)} = {projectId} ", ex);
            }
        }
    }
}
