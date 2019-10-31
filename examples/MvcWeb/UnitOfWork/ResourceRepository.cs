using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcWeb.Db.Entities;

namespace MvcWeb.UnitOfWork
{
    public class ResourceRepository : IResourceRepository
    {
        private DbSet<Resource> DbSet { get; set; }
        
        public ResourceRepository(DbSet<Resource> db)
        {
            this.DbSet = db;
        }

        public async Task ChangeName(int Id, string newName)
        {
            var resource = await DbSet.Where(i => i.Id == Id).FirstOrDefaultAsync();
            resource.Name = newName;
        }

        public async Task EditDescription(int Id, string description)
        {
            var resource = await DbSet.Where(i => i.Id == Id).FirstOrDefaultAsync();
            resource.Description = description;
        }
    }
}
