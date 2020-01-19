using System.Threading.Tasks;
using System.Collections.Generic;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IResourceCategoryService
    {
        Task ChangeType(int categoryId, string newType);

        IEnumerable<ResourceCategoryDto> GetAllCategories();
    }
}
