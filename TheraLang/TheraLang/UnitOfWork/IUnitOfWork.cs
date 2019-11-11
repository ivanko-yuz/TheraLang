using System;
using System.Threading.Tasks;
using TheraLang.TheraLang.Repository;

namespace TheraLang.TheraLang.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
    }
}