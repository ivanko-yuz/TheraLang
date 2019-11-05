using System;
using System.Linq;
using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;

namespace MvcWeb.TheraLang.Services
{
    public class ResourceCategoryService : IResourceCategoryService
    {
        private readonly IUnitOfWork unitOfWork;

        public ResourceCategoryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task ChangeType(int categoryId, string newType)
        {
            try
            {
                ResourceCategory category = unitOfWork.Repository<ResourceCategory>().
                                            Get().Where(i => i.Id == categoryId).SingleOrDefault();
                category.Type = newType;

                unitOfWork.Repository<ResourceCategory>().Update(category);
                await unitOfWork.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"Error when changing resource type: ", ex);
            }
        }
    }
}
