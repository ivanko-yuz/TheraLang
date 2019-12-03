﻿using TheraLang.DLL.Entities;
using System.Threading.Tasks;

namespace TheraLang.DLL.Services
{
    public interface IProjectTypeService
    {
        Task Add(ProjectType projectType);

        Task Remove(int id);

        Task Update(ProjectType projectType, int id);


    }
}