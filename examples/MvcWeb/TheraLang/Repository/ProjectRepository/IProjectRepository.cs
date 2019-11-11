using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Repository
{
    public interface IProjectRepository
    {
         Task SortingById();
         Task SortingByName();
         Task SortingByBeginDate();
         Task SortingByEndDate();
    }
}
