using MvcWeb.TheraLang.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcWeb.Services
{
    public interface IProjectTypeService
    {
        IEnumerable<ProjectType> GetAllProjectsType();

        ProjectType GetProjectTypeById(int id);

        Task Add(string name);
    }
}
