using System.Linq;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;
using System.Collections.Generic;
using System;
using TheraLang.BLL.Interfaces;

namespace TheraLang.BLL.Services
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
