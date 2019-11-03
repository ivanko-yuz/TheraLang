using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MvcWeb.TheraLang.UnitOfWork;

namespace MvcWeb.TheraLang.Repository
{
    public class ResourceCategoryRepository : IResourceCategoryRepository
    {
        private readonly IUnitOfWork unitOfWork;

        public ResourceCategoryRepository(IUnitOfWork _unit)
        {
            unitOfWork = _unit;
        }

        public async Task ChangeType(int categoryId, string newType)
        {
            ResourceCategory resource = await unitOfWork.Repository<ResourceCategory>().
                                              Get().Where(i => i.Id == categoryId).FirstOrDefaultAsync();

            resource.Type = newType;
            unitOfWork.Repository<ResourceCategory>().Update(resource);
            await unitOfWork.SaveChangesAsync();
        }
    }
}
