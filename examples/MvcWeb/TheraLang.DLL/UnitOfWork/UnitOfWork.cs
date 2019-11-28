using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheraLangWeb.TheraLang.DLL.Repository;
using TheraLangWeb.TheraLang.DLL.UnitOfWork;

namespace TheraLangWeb.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(DbContext context)
        {
            Context = context;
        }

        private DbContext Context { get; }

        public IRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            return new Repository<TEntity>(Context.Set<TEntity>());
        }

        public Task<int> SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}