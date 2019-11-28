using System.Threading.Tasks;

namespace TheraLangWeb.Services
{
    public interface IResourceCategoryService
    {
        Task ChangeType(int Id, string newType);
    }
}
