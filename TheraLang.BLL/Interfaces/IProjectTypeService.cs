using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IProjectTypeService
    {
        Task Add(ProjectTypeDto projectType);

        Task Remove(int id);

        Task Update(ProjectTypeDto projectType);

        Task<IEnumerable<ProjectTypeDto>> GetAllProjectsType();

        Task<ProjectTypeDto> GetProjectTypeById(int id);
    }
}