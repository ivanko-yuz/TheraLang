using System.Threading.Tasks;
using MvcWeb.Models;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;

namespace MvcWeb.Services
{
    public interface IProjectService
    {
        Task<bool> TryAddProject(ProjectViewModel projectViewModel);
    }

    public class ProjectService : IProjectService
    {
        public ProjectService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        private IUnitOfWork UnitOfWork { get; }

        public async Task<bool> TryAddProject(ProjectViewModel projectViewModel)
        {
            var newProject = new Project {Name = projectViewModel.Name, Type = projectViewModel.Type};
            try
            {
                await UnitOfWork.Repository<Project>().Add(newProject);
                await UnitOfWork.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}