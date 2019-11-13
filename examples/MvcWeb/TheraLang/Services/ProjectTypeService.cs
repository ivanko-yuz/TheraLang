using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;

namespace MvcWeb.TheraLang.Services
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
            return uow.Repository<ProjectType>().Get().ToList();
        }

        public ProjectType GetProjectTypeById(int id)
        {
            try
            {
                ProjectType projectType = uow.Repository<ProjectType>().Get().ToList().FirstOrDefault(p => p.Id == id);
                if (projectType == null)
                {
                    throw new NullReferenceException("project with id {id} not found");
                }
                return projectType;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when geting project by Id: ", ex);
            }
        }

        async Task IProjectTypeService.TryAddProjectType(ProjectType projecttype)
        {
                ProjectType Projecttype = new ProjectType { TypeName = projecttype.TypeName };
                if(Projecttype == null)
                {
                    throw new NullReferenceException("projectType can`t be null");
                }
                try
                {
                    await uow.Repository<ProjectType>().Add(Projecttype);
                    await uow.SaveChangesAsync();
                }
                catch(Exception e)
                {
                    e.Data["project"] = projecttype;
                    throw;
                }
        }
    }
}
