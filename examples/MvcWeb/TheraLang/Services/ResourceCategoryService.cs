using System.Linq;
using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;

namespace MvcWeb.TheraLang.Services
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
                                            Get().Where(i => i.Id == categoryId).SingleOrDefault();
                category.Type = newTypeName;

                _unitOfWork.Repository<ResourceCategory>().Update(category);
                await _unitOfWork.SaveChangesAsync();
            }
            catch(System.Exception ex)
            {
                throw new System.Exception($"Error when changing resource type: ", ex);
            }
        }
    }
}
