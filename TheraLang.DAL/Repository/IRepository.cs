using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TheraLang.DAL.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> where);
        Task<TEntity> GetAsync();
        Task<IQueryable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> where);
        Task<IQueryable<TEntity>> GetListAsync();
        Task RemoveAsync(TEntity entity);
        Task RemoveRangeAsync(IEnumerable<TEntity> entities);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entity);
        Task UpdateAsync(TEntity entity);
        Task AttachAsync(TEntity entity);
        Task<TEntity> GetWithIncludeAsync(Expression<Func<TEntity, bool>> where, params string[] include);
        Task<IQueryable<TEntity>> GetListWithIncludeAsync(params string[] include);
    }
}