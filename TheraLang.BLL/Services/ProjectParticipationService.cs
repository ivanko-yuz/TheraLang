using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Enums;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class ProjectParticipationService : IProjectParticipationService
    {
        public ProjectParticipationService(IUnitOfWork unit)
        {
            _unitOfWork = unit;
        }

        private readonly IUnitOfWork _unitOfWork;

        public async Task ChangeStatusAsync(int participantId, ProjectParticipationStatus status)
        {
            try
            {
                ProjectParticipation participant = _unitOfWork.Repository<ProjectParticipation>()
                                                              .Get().SingleOrDefault(x => x.Id == participantId);
                participant.Status = status;
                _unitOfWork.Repository<ProjectParticipation>().Update(participant);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while updating the status for {nameof(participantId)}:{participantId}", ex);
            }
         
        }

        public IEnumerable<ProjectParticipation> GetAll()
        {
            return _unitOfWork.Repository<ProjectParticipation>().Get().ToList();
        }


        public async Task CreateRequest(Guid userId, int projectId)
        {
            try
            {
                ProjectParticipation member = new ProjectParticipation
                { 
                  CreatedById = userId, 
                  ProjectId = projectId,
                  Status = ProjectParticipationStatus.New,

                };

                await _unitOfWork.Repository<ProjectParticipation>().Add(member);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when creating request for {nameof(userId)}:{userId}" +
                    $"and {nameof(projectId)}:{projectId}: ", ex);
            }
        }
    }
}
