using MvcWeb.TheraLang.Entities;
using System.Threading.Tasks;

namespace MvcWeb.Services
{
    public interface IProjectTypeService
    {
        Task Add(ProjectType projectType);

        Task Remove(int id);

        Task Update(ProjectType projectType, int id);


    }
}