using MvcWeb.TheraLang.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcWeb.Services
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
