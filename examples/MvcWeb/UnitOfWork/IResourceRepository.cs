using System.Threading.Tasks;

namespace MvcWeb.UnitOfWork
{
    interface IResourceRepository
    {
        Task ChangeName(int Id, string newName);

        Task EditDescription(int Id, string description);
    }
}
