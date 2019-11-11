using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Repository.ProjectTypeRepository
{
    public class TypeRepository :  ITypeRepository
    {
        IUnitOfWork uow;
        public Task SortingById()
        {
            uow.Repository<ProjectType>().Get().OrderBy(e => e.Id);
            return uow.SaveChangesAsync();
        }

        public Task SortingByName()
        {
            uow.Repository<ProjectType>().Get().OrderBy(e => e.TypeName);
            return uow.SaveChangesAsync();
        }
    }
}
