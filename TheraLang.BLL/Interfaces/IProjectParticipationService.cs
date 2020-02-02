using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IProjectParticipationService
    {
        Task<IEnumerable<ProjectParticipationDto>> GetAllAsync();

        Task CreateRequestAsync(Guid userId, int projectId);

        Task ChangeStatusAsync(int participantId, ProjectParticipationStatusDto status);

    }
}
