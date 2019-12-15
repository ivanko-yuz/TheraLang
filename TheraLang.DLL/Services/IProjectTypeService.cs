﻿using TheraLang.DLL.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace TheraLang.DLL.Services
{
    public interface IProjectTypeService
    {
        Task Add(ProjectType projectType);

        Task Remove(int id);

        Task Update(ProjectType projectType, Guid userId);

        IEnumerable<ProjectType> GetAllProjectsType();

        ProjectType GetProjectTypeById(int id);
    }
}