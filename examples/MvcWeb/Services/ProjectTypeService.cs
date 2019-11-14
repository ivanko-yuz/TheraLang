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
        private IUnitOfWork uow { get; }
        public ProjectTypeService(IUnitOfWork unitOfWork)
        {
            uow = unitOfWork;
        }
        public IEnumerable<ProjectType> GetAllProjectsType()
        {
            return uow.Repository<ProjectType>().Get().AsNoTracking().ToList();
        }

        public ProjectType GetProjectTypeById(int id)
        {
            try
            {
                ProjectType projectType = uow.Repository<ProjectType>().Get().FirstOrDefault(p => p.Id == id);
                if (id == default(int))
                {
                    new ArgumentException($"{nameof(id)} cannot be 0");
                }
                return projectType;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when geting project by Id: ", ex);
            }
        }

        public async Task TryAddProjectType(ProjectType projecttype)
        {
                ProjectType Projecttype = new ProjectType { TypeName = projecttype.TypeName };
                if(Projecttype == null)
                {
                    throw new NullReferenceException($"{nameof(Projecttype)} can`t be null");
                }
                try
                {
                    await uow.Repository<ProjectType>().Add(Projecttype);
                    await uow.SaveChangesAsync();
                }
                catch(Exception e)
                {
                    throw new Exception("error when trying to add new data");
                }
        }
    }
}
