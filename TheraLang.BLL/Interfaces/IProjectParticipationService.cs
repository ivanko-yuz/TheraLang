using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Enums;
using System;

namespace TheraLang.BLL.Interfaces
{
    public interface IProjectParticipationService
    {
        IEnumerable<ProjectParticipation> GetAll();

        Task CreateRequest(Guid userId, int projectId);

        Task ChangeStatusAsync(int participantId, ProjectParticipationStatus status);

    }
}
