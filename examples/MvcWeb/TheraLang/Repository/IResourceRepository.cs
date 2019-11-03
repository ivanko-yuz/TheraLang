using MvcWeb.TheraLang.Entities;
using System.Linq;

namespace MvcWeb.TheraLang.Repository
{
    public interface IResourceRepository
    {
        void RemoveResource(int Id);

        IQueryable<Resource> GetResource(int Id);
    }
}
