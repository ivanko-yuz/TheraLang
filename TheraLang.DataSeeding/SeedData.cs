using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace TheraLang.DataSeeding
{
    internal static class SeedData
    {
        public static async Task Seed<TEntity>(this DbContext dbContext, IEnumerable<TEntity> entities) where TEntity : class
        {
            await dbContext.AddRangeAsync(entities);
            await dbContext.SaveChangesAsync();
        }

        public static async Task Clear<TEntity>(this DbContext dbContext) where TEntity : class
        {
            var entities = await dbContext.Set<TEntity>().ToListAsync();
            dbContext.Set<TEntity>().RemoveRange(entities);
            await dbContext.SaveChangesAsync();
        }

        public static async Task ClearAndSeed<TEntity>(this DbContext dbContext, IEnumerable<TEntity> entities)
            where TEntity : class
        {
            await dbContext.Clear<TEntity>();
            await dbContext.Seed(entities);
        }
    }
}