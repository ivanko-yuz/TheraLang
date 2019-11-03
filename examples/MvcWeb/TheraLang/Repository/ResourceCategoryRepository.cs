using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MvcWeb.TheraLang.Repository
{
    public class ResourceCategoryRepository : IResourceCategoryRepository
    {
        private DbSet<ResourceCategory> DbSet { get; }

        public ResourceCategoryRepository(DbSet<ResourceCategory> dbSet)
        {
            DbSet = dbSet;
        }

        public async Task ChangeType(int categoryId, string newType)
        {
            var categotyType = await DbSet.Where(i => i.Id == categoryId).FirstOrDefaultAsync();
            categotyType.Type = newType;
        }
    }
}
