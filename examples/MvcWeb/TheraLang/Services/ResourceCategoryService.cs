using System;
using System.Linq;
using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;

namespace MvcWeb.TheraLang.Services
{
    public class ResourceCategoryService : IResourceCategotyService
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
                                            Get().Where(i => i.Id == categoryId).FirstOrDefault();
                category.Type = newType;

                unitOfWork.Repository<ResourceCategory>().Update(category);
                await unitOfWork.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                unitOfWork.Dispose();
                throw new Exception($"Error when changing resource type: ", ex);
            }
        }
    }
}
