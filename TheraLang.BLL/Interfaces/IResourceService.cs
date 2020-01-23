using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IResourceService
    {
        Task AddResource(ResourceDto resource, Guid userId);

        Task UpdateResource(ResourceDto resource, Guid updatedById);

        Task RemoveResource(int id);

        ResourceDto GetResourceById(int id);

        IEnumerable<ResourceCategoryDto> GetResourcesCategories(bool withAssignedResources);

        int GetResourcesCount(int categoryId);

        IEnumerable<ResourceDto> GetResourcesByCategoryId(int categoryId, int pageNumber, int recordsPerPage);

        IEnumerable<ResourceDto> GetAllResourcesByProjectId(int projectId);
    }
}
