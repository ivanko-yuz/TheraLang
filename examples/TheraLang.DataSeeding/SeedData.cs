using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
using MvcWeb.Db.Entities;
using MvcWeb.TheraLang.Entities;

namespace TheraLang.DataSeeding
{
    public static class SeedData 
    {
        public static void Seed<TEntity>(this DbContext dbContext, IEnumerable<TEntity> entities)where TEntity:class
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
        
        public static void ClearAndSeed<TEntity>(this DbContext dbContext, IEnumerable<TEntity> entities) where TEntity : class
        {
            dbContext.Clear<TEntity>();
            dbContext.Seed(entities);
        }
    }
    
    public class GenericCollection
    {
        public GenericCollection()
        {
            Data = new Dictionary<Type, IList<object>>();
        }

        private Dictionary<Type, IList<object>> Data { get; }
        
        public void Add<TType>(TType value)
        {
            Data.TryAdd(typeof(TType), new List<object>());
            var list = Data[typeof(TType)];
            list.Add(value);
        }
        
        public void Remove<TType>(TType value)
        {
            var hasList = Data.TryGetValue(typeof(TType), out var list);
            if (!hasList) return;
            list.Remove(value);
        }
        
        public int Count(Type type)
        {
            var hasList = Data.TryGetValue(type, out var list);
            return hasList ? list.Count : 0;
        }
        
        public int Count<TType>()
        {
            return Count(typeof(TType));
        }
        
        public object GetItem(Type type, int index)
        {
            var hasList = Data.TryGetValue(type, out var list);
            return hasList ? list[index] : default;
        }
        
        public TType GetItem<TType>(int index)
        {
            return (TType) GetItem(typeof(TType), index);
        }

        public IEnumerable<Type> GetTypes()
        {
            return Data.Keys.AsEnumerable();
        }

        public IEnumerable<object> GetValues(Type type)
        {
            return Data[type].AsEnumerable();
        }

        public IEnumerable<TType> GetValues<TType>()
        {
            return (IEnumerable<TType>) GetValues(typeof(TType));
        }
    }
    
}