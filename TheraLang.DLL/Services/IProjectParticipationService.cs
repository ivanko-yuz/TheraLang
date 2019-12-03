using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DLL.Entities;

namespace TheraLang.DLL.Services
{
    public interface IProjectParticipationService
    {
        IEnumerable<ProjectParticipation> GetAll();

        Task CreateRequest(int userId, int projectId);
    }
}
