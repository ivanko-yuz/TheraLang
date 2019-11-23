using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Get();
        
        void Remove(TEntity entity);
       
        void RemoveRange(IEnumerable<TEntity> entities);
       
        Task Add(TEntity entity);
        
        Task AddRange(IEnumerable<TEntity> entity);
       
        void Update(TEntity entity);
       
        void Attach(TEntity entity);
    }
}