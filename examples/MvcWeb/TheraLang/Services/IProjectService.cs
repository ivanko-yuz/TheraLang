using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Services
{
    public interface IProjectService
    {
        Task TryAddProject(Project projectViewModel);

        Task UpdateAsync(int id, Project project);

        IEnumerable<Project> GetAllProjects();

        Project GetById(int id);
    }
}
