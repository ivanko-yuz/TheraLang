﻿using MvcWeb.TheraLang.Repository;
using MvcWeb.TheraLang.Repository.ProjectTypeRepository;
using System;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
    }
}