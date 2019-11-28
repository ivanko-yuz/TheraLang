using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheraLangWeb.TheraLang.DLL.Entities;
using TheraLangWeb.TheraLang.DLL.UnitOfWork;

namespace TheraLangWeb.Services
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
                return projectType;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when geting project by {nameof(id)} = {id}: ", ex);
            }
        }

        public async Task Add(string name)
        {
                var projectType = new ProjectType { TypeName = name };               
                try
                {
                    await _uow.Repository<ProjectType>().Add(projectType);
                    await _uow.SaveChangesAsync();
                }
                 catch (Exception e)
                {
                    e.Data["project type"] = projectType;
                    throw;
                }
        }
    }
}
