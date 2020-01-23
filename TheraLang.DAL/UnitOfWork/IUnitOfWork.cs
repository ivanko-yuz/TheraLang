using System;
using System.Threading.Tasks;
using TheraLang.DAL.Repository;

namespace TheraLang.DAL.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
    }
}