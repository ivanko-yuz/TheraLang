using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IResourceService
    {
        Task AddResourceAsync(ResourceDto resource, Guid userId);

        Task UpdateResourceAsync(int id, ResourceDto resource, Guid updatedById);

        Task RemoveResourceAsync(int id);

        Task<ResourceDto> GetResourceByIdAsync(int id);

        Task<IEnumerable<ResourceCategoryDto>> GetResourcesCategoriesAsync(bool withAssignedResources);

        Task<int> GetResourcesCountAsync(int categoryId);

        Task<IEnumerable<ResourceDto>> GetResourcesByCategoryIdAsync(int categoryId, int pageNumber, int recordsPerPage);

        Task<IEnumerable<ResourceDto>> GetAllResourcesByProjectIdAsync(int projectId);

        Task<IEnumerable<ResourceDto>> GetAllResourcesAsync();
    }
}
