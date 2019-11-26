using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcWeb.Models;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.Repository;
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

        public async Task TryAddProject(ProjectViewModel projectViewModel)
        {
            var newProject = new Project {Name = projectViewModel.Name, Type = projectViewModel.Type};
            try
            {
                await _uow.Repository<Project>().Add(newProject);
                await _uow.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                ex.Data[nameof(projectViewModel)] = projectViewModel;
                throw new Exception($"Error while adding the project", ex);
            }
        }

        public IEnumerable<Project> GetAll()
        {
            return _uow.Repository<Project>().Get().AsNoTracking().ToList();
        }

        public Project GetbyId(int id)
        {
            try
            {
                Project project = _uow.Repository<Project>().Get().ToList().FirstOrDefault(p => p.Id == id);
                if (project == null)
                {
                    throw new NullReferenceException("project with id {id} not found");
                }
                return project;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when geting project by Id: ", ex);
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
    }
}