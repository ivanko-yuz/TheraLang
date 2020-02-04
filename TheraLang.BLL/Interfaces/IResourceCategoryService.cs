using System.Threading.Tasks;
using System.Collections.Generic;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IResourceCategoryService
    {
        Task ChangeTypeName(int categoryId, string newTypeName);

        Task<IEnumerable<ResourceCategoryDto>> GetAllCategories();
    }
}
