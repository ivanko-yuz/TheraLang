using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TheraLang.DAL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> DbSet { get; }
        public Repository(DbSet<TEntity> dbSet)
        {
            DbSet = dbSet;
        }
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> where)
        {
            var entity = await DbSet.FirstOrDefaultAsync(where);
            return entity;
        }
        public async Task<TEntity> GetAsync()
        {
            var entity = await DbSet.FirstOrDefaultAsync();
            return entity;
        }

        public async Task<IQueryable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> where)
        {
            return DbSet.Where(where);
        }

        public async Task<IQueryable<TEntity>> GetListAsync()
        {
            return DbSet.AsQueryable();
        }

        public async Task RemoveAsync(TEntity entity)
        {
              DbSet.Remove(entity);
        }

        public async Task RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            DbSet.RemoveRange(entities);
        }

        public async Task AddAsync(TEntity entity)
        {
            await DbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await DbSet.AddRangeAsync(entities);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public async Task AttachAsync(TEntity entity)
        {
            DbSet.Attach(entity);
        }

        public async Task<TEntity> GetWithIncludeAsync(Expression<Func<TEntity, bool>> where, params string[] include)
        {
            var query = DbSet.AsQueryable();

            query = include.Aggregate(query, (current, property) => current.Include(property));

            return await query.FirstOrDefaultAsync(where);
        }

        public async Task<IQueryable<TEntity>> GetListWithIncludeAsync(params string[] include)
        {
            var query = DbSet.AsQueryable();
            query = include.Aggregate(query, (current, property) => current.Include(property));
            return  query;
        }

    }
}