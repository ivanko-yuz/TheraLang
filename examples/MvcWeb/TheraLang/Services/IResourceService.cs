using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;
using System;

namespace MvcWeb.TheraLang.Services
{
    public interface IResourceService
    {
        Task AddResource(Resource resource);

        Task UpdateResource(Resource resource, Guid updatedById);

        Task RemoveResource(int Id);

        Resource GetResourceById(int Id);
    }
}
