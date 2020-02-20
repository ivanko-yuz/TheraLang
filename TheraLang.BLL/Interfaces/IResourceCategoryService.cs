using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IResourceCategoryService
    {
        Task ChangeTypeName(int categoryId, string newTypeName);

        Task<IEnumerable<ResourceCategoryDto>> GetAllCategories();
    }
}