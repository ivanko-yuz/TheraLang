using System;
using System.Linq;
using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;
using System.Collections.Generic;
using MvcWeb.TheraLang.ProjectStatus;

namespace MvcWeb.TheraLang.Services
{
    public class ProjectParticipationService : IProjectParticipationService
    {
        public ProjectParticipationService(IUnitOfWork unit)
        {
            _unitOfWork = unit;
        }

        private readonly IUnitOfWork _unitOfWork;

        //
        public async Task ChangeStatusAsync(int participantId, ProjectParticipationStatus status)
        {
            var participant = _unitOfWork.Repository<ProjectParticipation>().Get().SingleOrDefault(x => x.Id == participantId);
            participant.Status = status;
            _unitOfWork.Repository<ProjectParticipation>().Update(participant);
            await _unitOfWork.SaveChangesAsync();
        }
        //


        public IEnumerable<ProjectParticipation> GetAll()
        {
            return _unitOfWork.Repository<ProjectParticipation>().Get().ToList();
        }

        public async Task CreateRequest(int userId, int projectId)
        {
            try
            {
                ProjectParticipation member = new ProjectParticipation 
                { CreatedById = userId, ProjectId = projectId, UpdatedDateUtc = DateTime.UtcNow };

                await _unitOfWork.Repository<ProjectParticipation>().Add(member);
                await _unitOfWork.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"Error when creating request for {nameof(userId)}:{userId}" +
                    $"and {nameof(projectId)}:{projectId}: ", ex);
            }
        }
    }
}
