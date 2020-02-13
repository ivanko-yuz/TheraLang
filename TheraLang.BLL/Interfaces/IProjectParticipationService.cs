using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IProjectParticipationService
    {
        Task<IEnumerable<ProjectParticipationDto>> GetAll();

        Task CreateRequest(Guid userId, int projectId);

        Task ChangeStatus(int participantId, ProjectParticipationStatusDto status);

        Task<IEnumerable<ProjectParticipationDto>> GetProjectParticipations(int projectId);
    }
}