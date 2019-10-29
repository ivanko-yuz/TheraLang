using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Repository
{
    public interface IProjectRepository 
    {
        Task<bool> ChangeType(int id, string type);
        Task<bool> ChangeName(int id, string type);
    }
}
