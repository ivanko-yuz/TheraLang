using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DLL.Entities;
using TheraLang.DLL.Enums;

namespace TheraLang.DLL.Services
{
    public interface IProjectParticipationService
    {
        IEnumerable<ProjectParticipation> GetAll();

        Task CreateRequest(int userId, int projectId);

        Task ChangeStatusAsync(int participantId, ProjectParticipationStatus status);

    }
}
