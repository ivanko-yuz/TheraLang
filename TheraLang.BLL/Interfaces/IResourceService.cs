using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IResourceService
    {
        Task<int> AddResource(ResourceDto resource, Guid userId);

        Task UpdateResource(int id, ResourceDto resource, Guid updatedById);

        Task RemoveResource(int id);

        Task<ResourceDto> GetResourceById(int id);

        Task<IEnumerable<ResourceCategoryDto>> GetResourcesCategories(int? projectId, bool includeEmpty);

        Task<int> GetResourcesCount(int? categoryId, int? projectId);

        Task<IEnumerable<ResourceDto>> GetResources(int? categoryId, int? projectId,
            PaginationParams paginationParams);

        Task<IEnumerable<ResourceDto>> GetAllResources();
    }
}