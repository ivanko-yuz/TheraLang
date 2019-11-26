using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.Web.TheraLang.DLL.Entities;

namespace TheraLang.Web.Services
{
    public interface IProjectTypeService
    {
        IEnumerable<ProjectType> GetAllProjectsType();

        ProjectType GetProjectTypeById(int id);

        Task Add(string name);
    }
}
