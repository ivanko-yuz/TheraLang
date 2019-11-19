using MvcWeb.TheraLang.Entities;
using System.Threading.Tasks;

namespace MvcWeb.Services
{
    public interface IProjectTypeService
    {
        Task AddProjectType(ProjectType projectType);

        Task RemoveProjectType(int id);

        Task UpdateProjectType(ProjectType projectType, int id);


    }
}