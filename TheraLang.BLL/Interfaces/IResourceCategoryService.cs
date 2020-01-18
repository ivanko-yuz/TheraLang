using System.Threading.Tasks;
using System.Collections.Generic;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
    public interface IResourceCategoryService
    {
        Task ChangeType(int categoryId, string newType);

        IEnumerable<ResourceCategory> GetAllCategories();
    }
}
