using System.Linq;
using Microsoft.EntityFrameworkCore;
using MvcWeb.Db.Entities;

namespace MvcWeb.UnitOfWork
{
    public class ResourceCategoryRepository : IResourceCategoryRepository
    {
        private DbSet<ResourceCategory> DbSet { get; }

        public ResourceCategoryRepository(DbSet<ResourceCategory> dbSet)
        {
            DbSet = dbSet;
        }

        public void ChangeType(int categoryId, string newType)
        {
            var category = DbSet.Where(i => i.Id == categoryId).FirstOrDefault();
            category.Type = newType;
        }
    }
}
