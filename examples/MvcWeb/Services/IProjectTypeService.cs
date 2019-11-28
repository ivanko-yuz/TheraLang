using TheraLangWeb.TheraLang.DLL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheraLangWeb.Services
{
    public interface IProjectTypeService
    {
        IEnumerable<ProjectType> GetAllProjectsType();

        ProjectType GetProjectTypeById(int id);

        Task Add(string name);
    }
}
