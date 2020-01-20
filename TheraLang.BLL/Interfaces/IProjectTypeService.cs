using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IProjectTypeService
    {
        Task Add(ProjectTypeDto projectType);

        Task Remove(int id);

        Task Update(ProjectTypeDto projectType, Guid userId);

        IEnumerable<ProjectTypeDto> GetAllProjectsType();

        ProjectTypeDto GetProjectTypeById(int id);
    }
}