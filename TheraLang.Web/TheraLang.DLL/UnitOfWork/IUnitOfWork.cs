using System;
using System.Threading.Tasks;
using TheraLang.Web.TheraLang.DLL.Repository;

namespace TheraLang.Web.TheraLang.DLL.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
    }
}