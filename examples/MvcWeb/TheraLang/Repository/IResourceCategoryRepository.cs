using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Repository
{
    interface IResourceCategoryRepository
    {
        Task ChangeType(int categoryId, string newType);
    }
}
