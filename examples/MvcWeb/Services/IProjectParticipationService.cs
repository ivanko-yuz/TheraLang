using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLangWeb.TheraLang.DLL.Entities;

namespace TheraLangWeb.Services
{
    public interface IProjectParticipationService
    {
        IEnumerable<ProjectParticipation> GetAll();

        Task CreateRequest(int userId, int projectId);
    }
}
