using System.Collections.Generic;
using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.Enums;

namespace MvcWeb.TheraLang.Services
{
    public interface IProjectParticipationService
    {
        IEnumerable<ProjectParticipation> GetAll();

        Task CreateRequest(int userId, int projectId);

        Task ChangeStatusAsync(int participantId, ProjectParticipationStatus status);

    }
}
