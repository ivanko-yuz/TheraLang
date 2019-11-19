using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TheraLang.DataSeeding
{
    public static class SeedData
    {
        public static void Seed<TEntity>(this DbContext dbContext, IEnumerable<TEntity> entities) where TEntity : class
        {
            foreach (var project in entities)
            {
                dbContext.Set<TEntity>().Add(project);
            }
            dbContext.SaveChanges();
        }

        public static void Clear<TEntity>(this DbContext dbContext) where TEntity : class
        {
            var entities = dbContext.Set<TEntity>().AsEnumerable();
            dbContext.Set<TEntity>().RemoveRange(entities);
            dbContext.SaveChanges();
        }

        public static void ClearAndSeed<TEntity>(this DbContext dbContext, IEnumerable<TEntity> entities)
            where TEntity : class
        {
            dbContext.Clear<TEntity>();
            dbContext.Seed(entities);
        }

        public static TEntity[] GetArrayOf<TEntity>(this DbContext dbContext) where TEntity: class
        {
            var array = dbContext.Set<TEntity>().ToArray();
            if (array.Length == 0)
            {
                throw new System.Exception("array is empty! fill it first");
            }
            return array;
        }
    }
}