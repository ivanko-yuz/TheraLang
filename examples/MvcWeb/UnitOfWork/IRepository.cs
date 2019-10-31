using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.UnitOfWork
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Get();

        void Remove(TEntity entity);
        
        void Remove(IEnumerable<TEntity> entities);
        
        Task Add(TEntity entity);
        
        Task Add(IEnumerable<TEntity> entity);
        
        void Update(TEntity entity);
        
        void Attach(TEntity entity);
    }
}