using System.Linq;
using System.Threading.Tasks;
using TheraLang.Web.TheraLang.DLL.Entities;
using TheraLang.Web.TheraLang.DLL.UnitOfWork;

namespace TheraLang.Web.TheraLang.DLL.Services
{
    public class ResourceCategoryService : IResourceCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResourceCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task ChangeType(int categoryId, string newTypeName)
        {
            try
            {
                ResourceCategory category = _unitOfWork.Repository<ResourceCategory>().
                                            Get().SingleOrDefault(i => i.Id == categoryId);
                category.Type = newTypeName;

                _unitOfWork.Repository<ResourceCategory>().Update(category);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception($"Error when changing resource category for {nameof(categoryId)}:{categoryId} " +
                    $"and {nameof(newTypeName)}:{newTypeName}: ", ex);
            }
        }
    }
}
