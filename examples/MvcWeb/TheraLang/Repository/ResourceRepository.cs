using MvcWeb.TheraLang.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace MvcWeb.TheraLang.Repository
{
    public class ResourceRepository : IResourceRepository
    {
        private readonly DbSet<Resource> DbSet;

        public ResourceRepository(DbSet<Resource> db)
        {
            this.DbSet = db;
        }

        public void RemoveResource(int Id)
        {
            IEnumerable<Resource> resources = DbSet.Where(i => i.Id == Id).ToList();
            DbSet.RemoveRange(resources);
        }

        public IQueryable<Resource> GetResource(int Id)
        {
            IQueryable<Resource> resource = DbSet.Where(i => i.Id == Id);
            return resource;
        }
    }
}
