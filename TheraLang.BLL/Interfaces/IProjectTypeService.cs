using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IProjectTypeService
    {
        Task AddAsync(ProjectTypeDto projectType);

        Task RemoveAsync(int id);

        Task UpdateAsync(ProjectTypeDto projectType);

        Task<IEnumerable<ProjectTypeDto>> GetAllProjectsTypeAsync();

        Task<ProjectTypeDto> GetProjectTypeByIdAsync(int id);
    }
}