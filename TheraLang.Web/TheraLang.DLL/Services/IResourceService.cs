using MvcWeb.TheraLang.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Services
{
    public interface IResourceService
    {
        Task AddResource(Resource resource);

        Task UpdateResource(Resource resource, int updatedById);

        Task RemoveResource(int id);

        Resource GetResourceById(int id);

        IEnumerable<ResourceCategory> GetResourcesCategories(bool withAssignedResources);

        int GetResourcesCount(int categoryId);

        IEnumerable<Resource> GetResourcesByCategoryId(int categoryId, int pageNumber, int recordsPerPage);

        IEnumerable<Resource> GetAllResourcesByProjectId(int projectId);
    }
}
