using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Enums;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IProjectParticipationService
    {
        Task<IEnumerable<ProjectParticipationDto>> GetAll();

        Task CreateRequest(Guid userId, int projectId);

        Task ChangeStatus(int participantId, ProjectParticipationStatus status);

        Task<IEnumerable<ProjectParticipationDto>> GetProjectParticipations(int projectId);
    }
}