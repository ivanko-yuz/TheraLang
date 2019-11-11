using System.Threading.Tasks;

namespace TheraLang.TheraLang.Repository
{
    public interface IProjectRepository 
    {
        Task<bool> ChangeType(int id, string type);
        Task<bool> ChangeName(int id, string type);
    }
}
