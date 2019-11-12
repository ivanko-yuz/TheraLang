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

        Resource GetResourceById(int? Id);

        IEnumerable<Resource> GetAllResourcesWhereProjectIdNull(int? Id);
    }
}
