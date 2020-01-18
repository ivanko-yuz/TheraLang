using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Models;
using System;

namespace TheraLang.BLL.Interfaces
{
    public interface IResourceService
    {
        Task AddResource(ResourceViewModel resourceModel, Guid userId);

        Task UpdateResource(ResourceViewModel resourceModel, Guid updatedById);

        Task RemoveResource(int id);

        Resource GetResourceById(int id);

        IEnumerable<ResourceCategory> GetResourcesCategories(bool withAssignedResources);

        int GetResourcesCount(int categoryId);

        IEnumerable<Resource> GetResourcesByCategoryId(int categoryId, int pageNumber, int recordsPerPage);

        IEnumerable<Resource> GetAllResourcesByProjectId(int projectId);
    }
}
