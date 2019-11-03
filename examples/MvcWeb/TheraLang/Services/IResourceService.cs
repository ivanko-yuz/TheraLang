using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;

namespace MvcWeb.TheraLang.Services
{
    public interface IResourceService
    {
        Task<bool> AddResource(Resource resource);

        Task<bool> UpdateResource(Resource resource, int updatedById);
    }
}
