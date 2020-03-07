using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.DataTransferObjects.Projects;

namespace TheraLang.BLL.Interfaces
{
    public interface IProjectService
    {
        Task ChangeStatusAsync(int id, ProjectStatusDto status);

        Task AddAsync(ProjectDto projectModel, Guid userId);

        Task DeleteAsync(int id);

        Task UpdateAsync(int id, ProjectDto project);

        Task<IEnumerable<ProjectPreviewDto>> GetAllProjectsAsync();

        Task<ProjectDto> GetByIdAsync(int id);

        Task<IEnumerable<ProjectDto>> GetProjectsAsync(int pageNumber, int pageSize);
        Task<IEnumerable<ProjectDto>> GetAllNewProjectsAsync();
        Task<IEnumerable<ProjectDto>> GetProjectsByStatusAsync(int status);
    }
}