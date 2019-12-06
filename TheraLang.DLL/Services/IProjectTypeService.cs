using TheraLang.DLL.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TheraLang.DLL.Services
{
    public interface IProjectTypeService
    {
        Task Add(ProjectType projectType);

        Task Remove(int id);

        Task Update(ProjectType projectType, int id);

        IEnumerable<ProjectType> GetAllProjectsType();

        ProjectType GetProjectTypeById(int id);
    }
}