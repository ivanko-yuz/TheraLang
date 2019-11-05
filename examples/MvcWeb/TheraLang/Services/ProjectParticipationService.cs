using System;
using System.Linq;
using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;
using System.Collections.Generic;

namespace MvcWeb.TheraLang.Services
{
    public class ProjectParticipationService : IProjectParticipationSerice
    {
        public ProjectParticipationService(IUnitOfWork _unit)
        {
            this.unitOfWork = _unit;
        }

        private readonly IUnitOfWork unitOfWork;

        public IEnumerable<ProjectParticipation> GetAll()
        {
            return unitOfWork.Repository<ProjectParticipation>().Get().ToList();
        }

        public async Task CreateRequest(int userId, int projectId)
        {
            try
            {
                ProjectParticipation member = new ProjectParticipation 
                { CreatedById = userId, ProjectId = projectId, Role = 0, Status = 0, UpdatedDateUtc = DateTime.UtcNow };

                await unitOfWork.Repository<ProjectParticipation>().Add(member);
                await unitOfWork.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                unitOfWork.Dispose();
                throw new Exception($"");
            }
        }
    }
}
