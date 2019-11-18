using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Services
{
    public interface IResourceCategoryService
    {
        Task ChangeType(int Id, string newType);
    }
}
