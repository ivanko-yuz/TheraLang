using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.Web.TheraLang.DLL.Entities;

namespace TheraLang.Web.TheraLang.DLL.Services
{
    public interface IProjectParticipationService
    {
        IEnumerable<ProjectParticipation> GetAll();

        Task CreateRequest(int userId, int projectId);
    }
}
