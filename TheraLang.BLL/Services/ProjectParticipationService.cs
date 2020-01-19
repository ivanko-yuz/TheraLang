using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TheraLang.BLL.DataTransferObjects;
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

        public async Task ChangeStatusAsync(int participantId, ProjectParticipationStatusDto statusDto)
        {
            try
            {
                ProjectParticipation participant = _unitOfWork.Repository<ProjectParticipation>()
                                                              .Get().SingleOrDefault(x => x.Id == participantId);

                if (participant == null)
                {
                    throw new NullReferenceException($"Error while changing status. Participant with id {nameof(participantId)}={participantId} not found");
                }

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectParticipationStatusDto, ProjectParticipationStatus>()).CreateMapper();
                var status = mapper.Map<ProjectParticipationStatusDto, ProjectParticipationStatus>(statusDto);

                participant.Status = status;

                _unitOfWork.Repository<ProjectParticipation>().Update(participant);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while updating the status for {nameof(participantId)}:{participantId}", ex);
            }

        }

        public IEnumerable<ProjectParticipationDto> GetAll()
        {
            var projectParticipations = _unitOfWork.Repository<ProjectParticipation>().Get().ToList();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectParticipation, ProjectParticipationDto>()).CreateMapper();
            var projectParticipationsDto = mapper.Map<IEnumerable<ProjectParticipation>, IEnumerable<ProjectParticipationDto>>(projectParticipations);

            return projectParticipationsDto;
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
