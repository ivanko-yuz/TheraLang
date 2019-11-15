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
        public ProjectService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        private readonly IUnitOfWork _uow;

        public IEnumerable<Project> GetAllProjects()
        {
            return _uow.Repository<Project>().Get().AsNoTracking().ToList();
        }

        public async Task TryAddProject(Project projectViewModel)
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
                e.Data["projectViewModel"] = projectViewModel;
                throw;
            }
        }

        public IEnumerable<Project> GetProjects(int pageNumber, int pageSize = PaginationConstants.RecordsPerPage)
        {
            try
            {
                IEnumerable<Project> projects = _uow.Repository<Project>().Get();
                IEnumerable<Project> projectsPerPages = projects.Skip((pageNumber - 1) * pageSize).Take(pageSize);
                return projectsPerPages;
            }
            catch
            {
                throw new NullReferenceException($"projects on this page can`t be found");
            }
        }

        public async Task UpdateAsync(int id, Project project)
        {
            try
            {
                project = _uow.Repository<Project>().Get().ToList().FirstOrDefault(p => p.Id == id);
                if (project == null)
                {
                    throw new NullReferenceException($"project with id {id} not found");
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
                if (project == null)
                {
                    throw new NullReferenceException($"project with id {id} not found");
                }
                return project;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when geting project by Id: ", ex);
            }
        }
    }
}