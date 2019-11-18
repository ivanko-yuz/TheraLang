using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;

namespace MvcWeb.Services
{
    public class ProjectTypeService : IProjectTypeService
    {
        private readonly IUnitOfWork _uow;
        public ProjectTypeService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
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
                if (id == default(int))
                {
                    throw new ArgumentException($"{nameof(id)} cannot be null");
                }
                return projectType;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when geting project by Id: ", ex);
            }
        }

        public async Task Add(ProjectType projecttype)
        {
                var projectType = new ProjectType { TypeName = projecttype.TypeName };               
                try
                {
                    await _uow.Repository<ProjectType>().Add(projectType);
                    await _uow.SaveChangesAsync();
                }
                catch(Exception e)
                {
                    throw new Exception("error when trying to add new data", e);
                }
        }
    }
}
