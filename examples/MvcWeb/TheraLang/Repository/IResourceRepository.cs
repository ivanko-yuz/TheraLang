using MvcWeb.TheraLang.Entities;

namespace MvcWeb.TheraLang.Repository
{
    public interface IResourceRepository
    {
        void RemoveResource(int Id);

        Resource GetResource(int Id);
    }
}
