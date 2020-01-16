using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheraLang.DLL.Entities;
using TheraLang.DLL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class ProjectTypeService : IProjectTypeService
    {
        private readonly IUnitOfWork _uow;
        public ProjectTypeService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task Add(ProjectType projectType)
        {
            try
            {
                await _uow.Repository<ProjectType>().Add(projectType);
                await _uow.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ex.Data[nameof(ProjectType)] = projectType;
                throw new Exception($"Error when trying to add new {nameof(ProjectType)}", ex);
            }
        }

        public async Task Remove(int projectTypeId)
        {
            try
            {
                ProjectType projectType = _uow.Repository<ProjectType>().Get().SingleOrDefault(i => i.Id == projectTypeId);
                _uow.Repository<ProjectType>().Remove(projectType);

                await _uow.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when remove ProjectType by {nameof(ProjectType.Id)}: {projectTypeId}: ", ex);
            }
        }

        public async Task Update(ProjectType projectType, Guid userId)
        {
            try
            {
                _uow.Repository<ProjectType>().Update(projectType);
                await _uow.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when updating the {nameof(ProjectType)}: {projectType.Id}: ", ex);
            }
        }

        public IEnumerable<ProjectType> GetAllProjectsType()
        {
            return _uow.Repository<ProjectType>().Get().AsNoTracking().ToList();
        }

        public ProjectType GetProjectTypeById(int id)
        {
            try
            {
                ProjectType projectType = _uow.Repository<ProjectType>().Get().FirstOrDefault(p => p.Id == id);
                return projectType;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when getting project by {nameof(id)} = {id}: ", ex);
            }
        }
    }
}
