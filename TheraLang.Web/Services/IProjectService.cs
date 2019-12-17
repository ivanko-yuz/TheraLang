using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DLL.Entities;
using TheraLang.Web.Models;
using System;

namespace TheraLang.Web.Services
{
    public interface IProjectService
    {
        Task ChangeStatus(int id, ProjectStatus status);

        Task Add(ProjectModel projectModel, Guid userId);

        Task Delete(int id);

        Task UpdateAsync(int id, Project project);

        IEnumerable<Project> GetAllProjects();

        Project GetById(int id);

        IEnumerable<Project> GetProjects(int pageNumber, int pageSize);
        IEnumerable<Project> GetAllNewProjects();
        IEnumerable<Project> GetProjectsByStatus(int status);
    }
}
