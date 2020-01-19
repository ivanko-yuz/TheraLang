using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;
using System;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IProjectParticipationService
    {
        IEnumerable<ProjectParticipationDto> GetAll();

        Task CreateRequest(Guid userId, int projectId);

        Task ChangeStatusAsync(int participantId, ProjectParticipationStatusDto status);

    }
}
