using TheraLangWeb.TheraLang.DLL.Repository;
using System;
using System.Threading.Tasks;

namespace TheraLangWeb.TheraLang.DLL.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
    }
}