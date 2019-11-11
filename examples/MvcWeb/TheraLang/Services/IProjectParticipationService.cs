using System.Collections.Generic;
using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;
using System;

namespace MvcWeb.TheraLang.Services
{
    public interface IProjectParticipationService
    {
        IEnumerable<ProjectParticipation> GetAll();

        Task CreateRequest(Guid userId, int projectId);
    }
}
