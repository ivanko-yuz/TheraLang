using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheraLang.DLL.Constants;
using TheraLang.DLL.Entities;
using TheraLang.DLL.UnitOfWork;
using TheraLang.Web.Models;

namespace TheraLang.Web.Services
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
            return _uow.Repository<Project>().Get().Include(x=>x.Donations);
        }

        public async Task Add(ProjectModel projectModel, Guid userId)
        {
            var newProject = new Project {
                //Name = projectModel.Name,
                //Details = projectModel.Details,
                //Description = projectModel.Description,
                //IsActive = true,
                //ProjectStart = projectModel.ProjectStart,
                //ProjectEnd = projectModel.ProjectEnd
            };
            var newParticipant = new ProjectParticipation
            {
                Role = DLL.Enums.MemberRole.ProjectOwner,
                CreatedById = userId,
                Status = DLL.Enums.ProjectParticipationStatus.Approved,
                Project = newProject,
            };
            try
            {
                await _uow.Repository<Project>().Add(newProject);
                await _uow.SaveChangesAsync();
                // newParticipant.ProjectId = newProject.Id;
                await _uow.Repository<ProjectParticipation>().Add(newParticipant);
                await _uow.SaveChangesAsync();
            }
            catch(Exception e)
            {
                e.Data["project"] = projectModel;
                throw;
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                var project = _uow.Repository<Project>().Get().SingleOrDefault(p => p.Id == id);
                if (project == null)
                {
                    throw new NullReferenceException($"Error while deleting project. Project with id {nameof(id)}={id} not found");
                }
                _uow.Repository<Project>().Remove(project);
                await _uow.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["projectId"] = id;
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
