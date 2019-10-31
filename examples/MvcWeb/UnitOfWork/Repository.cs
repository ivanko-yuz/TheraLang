﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcWeb.UnitOfWork
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> DbSet { get; }

        public Repository(DbSet<TEntity> dbSet)
        {
            DbSet = dbSet;
        }

        public IQueryable<TEntity> Get()
        {
            return DbSet;
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void Remove(IEnumerable<TEntity> entities)
        {
            DbSet.RemoveRange(entities);
        }

        public Task Add(TEntity entity)
        {
            return DbSet.AddAsync(entity);
        }

        public Task Add(IEnumerable<TEntity> entities)
        {
            return DbSet.AddRangeAsync(entities);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }
        
        public void Attach(TEntity entity)
        {
            DbSet.Attach(entity);
        }
    }
}