using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IResourceService
    {
        Task AddResource(ResourceDto resource, Guid userId);

        Task UpdateResource(int id, ResourceDto resource, Guid updatedById);

        Task RemoveResource(int id);

        Task<ResourceDto> GetResourceById(int id);

        Task<IEnumerable<ResourceCategoryDto>> GetResourcesCategories(bool withAssignedResources);

        Task<int> GetResourcesCount(int categoryId);

        Task<IEnumerable<ResourceDto>> GetResourcesByCategoryId(int categoryId, int pageNumber, int recordsPerPage);

        Task<IEnumerable<ResourceDto>> GetAllResourcesByProjectId(int projectId);

        Task<IEnumerable<ResourceDto>> GetAllResources();
    }
}