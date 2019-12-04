﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DLL.Entities;
using TheraLang.Web.Models;

namespace TheraLang.Web.Services
{
    public interface IProjectService
    {
        Task ChangeStatus(int id, ProjectStatus rejected);

        Task Add(Project projectViewModel);

        Task UpdateAsync(int id, Project project);

        IEnumerable<Project> GetAllProjects();

        Project GetById(int id);

        IEnumerable<Project> GetProjects(int pageNumber, int pageSize);
    }
}
