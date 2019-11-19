using System;
using System.Linq;
using System.Threading.Tasks;
using MvcWeb.Services;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;

namespace MvcWeb.TheraLang.Services
{
    public class ProjectTypeService : IProjectTypeService
    {
        private readonly IUnitOfWork _uow;
        public ProjectTypeService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task AddProjectType(ProjectType projectType)
        {
            ProjectType Projecttype = new ProjectType { TypeName = projectType.TypeName };
            if (projectType == null)
            {
                throw new NullReferenceException($"{nameof(ProjectType)} can`t be null");
            }
            try
            {
                await _uow.Repository<ProjectType>().Add(projectType);
                await _uow.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"Error when trying to add new {nameof(ProjectType)}");
            }
        }

        public async Task RemoveProjectType(int id)
        {
            try
            {
                ProjectType projectType = _uow.Repository<ProjectType>().Get().SingleOrDefault(i => i.Id == id);
                _uow.Repository<ProjectType>().Remove(projectType);

                await _uow.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when remove ProjectType by {nameof(ProjectType.Id)}: {id}: ", ex);
            }
        }

        public async Task UpdateProjectType(ProjectType projectType, int id)
        {
            try
            {
                projectType.UpdatedDateUtc = DateTime.UtcNow;
                projectType.UpdatedById = id;

                _uow.Repository<ProjectType>().Update(projectType);
                await _uow.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when updating the {nameof(ProjectType)}: {projectType.Id}: ", ex);
            }
        }
    }
}
