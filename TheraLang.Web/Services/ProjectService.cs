using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcWeb.TheraLang.Constants;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;

namespace MvcWeb.Services
{
    public class ProjectService : IProjectService
    {
        public ProjectService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        private readonly IUnitOfWork _uow;

        public IEnumerable<Project> GetAllProjects()
        {
            return _uow.Repository<Project>().Get().AsNoTracking().ToList();
        }

        public async Task Add(Project projectViewModel)
        {
            var newProject = new Project { Name = projectViewModel.Name, Details = projectViewModel.Details,
                Description = projectViewModel.Description, IsActive = projectViewModel.IsActive,
                ProjectStart = projectViewModel.ProjectStart, ProjectEnd = projectViewModel.ProjectEnd  };
            try
            {
                await _uow.Repository<Project>().Add(newProject);
                await _uow.SaveChangesAsync();
            }
            catch(Exception e)
            {
                e.Data["project"] = projectViewModel;
                throw;
            }
        }

        public IEnumerable<Project> GetProjects(int pageNumber, int pageSize = PaginationConstants.RecordsPerPage)
        {
            try
            {
                
                var projects = _uow.Repository<Project>().Get().AsNoTracking();
                IEnumerable<Project> projectsPerPages = projects.Skip((pageNumber - 1) * pageSize).Take(pageSize);
                return projectsPerPages;
            }
            catch
            {
                throw new Exception($"Error while fetching the projects for {nameof(pageNumber)}={pageNumber} and {nameof(pageSize)}={pageSize}");
            }
        }

        public async Task ChangeStatus(int projectId, ProjectStatus status)
        {
 
                var project = _uow.Repository<Project>().Get().SingleOrDefault(p => p.Id == projectId);
                if (project is null)
                {
                    throw new NullReferenceException($"{ nameof(project) } cannot be null");
                }
                project.StatusId = status;
                await _uow.SaveChangesAsync();          
        }

        public async Task UpdateAsync(int id, Project project)
        {
            try
            {
                project = _uow.Repository<Project>().Get().SingleOrDefault(p => p.Id == id);
                if (project == null)
                {
                    throw new NullReferenceException($"Error while updating project. Project with id {nameof(id)}={id} not found");
                }
                _uow.Repository<Project>().Update(project);
                await _uow.SaveChangesAsync();               
            }
            catch(Exception e)
            {
                e.Data["project"] = project;
                throw;
            }
        }

        public Project GetById(int id)
        {
            try
            {
                var project = _uow.Repository<Project>().Get().SingleOrDefault(i => i.Id == id);
                return project;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when getting project by {nameof(id)} = {id} ", ex);  
            }
        }
    }
}
