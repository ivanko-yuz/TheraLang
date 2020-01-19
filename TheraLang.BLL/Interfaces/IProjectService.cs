using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
    public interface IProjectService
    {
        Task ChangeStatus(int id, ProjectStatusDto status);

        Task Add(ProjectDto projectModel, Guid userId);

        Task Delete(int id);

        Task UpdateAsync(int id, ProjectDto project);

        IEnumerable<ProjectDto> GetAllProjects();

        ProjectDto GetById(int id);

        IEnumerable<ProjectDto> GetProjects(int pageNumber, int pageSize);
        IEnumerable<ProjectDto> GetAllNewProjects();
        IEnumerable<ProjectDto> GetProjectsByStatus(int status);
    }
}
