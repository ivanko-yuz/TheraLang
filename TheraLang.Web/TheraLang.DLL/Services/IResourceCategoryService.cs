using System.Threading.Tasks;

namespace TheraLang.Web.TheraLang.DLL.Services
{
    public interface IResourceCategoryService
    {
        Task ChangeType(int Id, string newType);
    }
}
