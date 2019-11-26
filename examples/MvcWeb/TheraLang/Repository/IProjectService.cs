using System.Collections.Generic;
using System.Threading.Tasks;
using MvcWeb.Models;
using MvcWeb.TheraLang.Entities;

namespace MvcWeb.TheraLang.Repository
{
    public interface IProjectService
    {
        Task TryAddProject(ProjectViewModel projectViewModel);

        Task ChangeStatus(int id, Entities.ProjectStatus rejected);

        IEnumerable<Project> GetAll();

        Project GetbyId(int id);
    }
}
