using System.Threading.Tasks;
using System.Collections.Generic;
using TheraLang.DLL.Entities;

namespace TheraLang.BLL.Services
{
    public interface IResourceCategoryService
    {
        Task ChangeType(int categoryId, string newType);

        IEnumerable<ResourceCategory> GetAllCategories();
    }
}
