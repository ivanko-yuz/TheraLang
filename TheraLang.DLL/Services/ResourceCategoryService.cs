using System.Linq;
using System.Threading.Tasks;
using TheraLang.DLL.Entities;
using TheraLang.DLL.UnitOfWork;
using System.Collections.Generic;
using System;

namespace TheraLang.DLL.Services
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
            catch (Exception ex)
            {
                throw new Exception($"Error when changing resource category for {nameof(categoryId)}:{categoryId} " +
                    $"and {nameof(newTypeName)}:{newTypeName}: ", ex);
            }
        }

        public IEnumerable<ResourceCategory> GetAllCategories()
        {
            IEnumerable<ResourceCategory> categories = _unitOfWork.Repository<ResourceCategory>().Get();
            return categories;
        }
    }
}
