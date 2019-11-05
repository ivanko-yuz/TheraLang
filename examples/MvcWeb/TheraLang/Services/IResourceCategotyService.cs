using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Services
{
    public interface IResourceCategotyService
    {
        Task ChangeType(int Id, string newType);
    }
}
