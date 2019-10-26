using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcWeb.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext Context { get; }

        public UnitOfWork(DbContext context)
        {
            Context = context;
        }

        public IQueryable<TEntity> Queryable<TEntity>() where TEntity : class => Context.Set<TEntity>();

        public Task<int> SaveChangesAsync() => Context.SaveChangesAsync();
    }
}