using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;
using System;
using System.Collections.Generic;

namespace MvcWeb.TheraLang.Services
{
    public interface IResourceService
    {
        Task AddResource(Resource resource);

        Task UpdateResource(Resource resource, Guid updatedById);

        Task RemoveResource(int Id);

        Resource GetResourceById(int id);

        IEnumerable<Resource> GetAllResourcesByProjectId(int Id);
        IEnumerable<Resource> GetAllResources(int pageNumber, int recordsPerPage);
        int GetCountAllResources();
    }
}
