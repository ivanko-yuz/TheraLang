using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Repository
{
    public class ProjectRepository :  IProjectRepository
    {
        IUnitOfWork uow;
       
        public Task SortingById()
        {
            uow.Repository<Project>().Get().OrderBy(p => p.Id);
            return uow.SaveChangesAsync();
        }
        public Task SortingByName()
        {
           uow.Repository<Project>().Get().OrderBy(p => p.Name);
           return uow.SaveChangesAsync();
        }

        public Task SortingByBeginDate()
        {
            uow.Repository<Project>().Get().OrderBy(p => p.ProjectBegin);
            return uow.SaveChangesAsync();
        }

        public Task SortingByEndDate()
        {
            uow.Repository<Project>().Get().OrderBy(p => p.ProjectEnd);
            return uow.SaveChangesAsync();
        }
    }
}
