using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        IUnitOfWork uow;
        public async Task<bool> ChangeName(int id, string name)
        {
            var p = await uow.Repository<Project>().Get().ToAsyncEnumerable().FirstOrDefault(i => i.Id == id);
            if (p != null)
            {
                p.Name = name;
                await uow.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> ChangeType(int id, string type)
        {

            var p = await uow.Repository<Project>().Get().ToAsyncEnumerable().FirstOrDefault(i => i.Id == id);
            if (p != null)
            {
                p.Type = type;
                await uow.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}