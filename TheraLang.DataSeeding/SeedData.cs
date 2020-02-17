using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace TheraLang.DataSeeding
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder builder)
        {
            
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


    }
}