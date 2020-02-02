using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Enums;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class ProjectParticipationService : IProjectParticipationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectParticipationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task ChangeStatusAsync(int participantId, ProjectParticipationStatusDto statusDto)
        {
            try
            {
                ProjectParticipation participant = await _unitOfWork.Repository<ProjectParticipation>()
                    .GetAsync(x => x.Id == participantId);

                if (participant == null)
                {
                    throw new NullReferenceException(
                        $"Error while changing status. Participant with id {nameof(participantId)}={participantId} not found");
                }

                var mapper = new MapperConfiguration(cfg =>
                    cfg.CreateMap<ProjectParticipationStatusDto, ProjectParticipationStatus>()).CreateMapper();
                var status = mapper.Map<ProjectParticipationStatusDto, ProjectParticipationStatus>(statusDto);

                participant.Status = status;

                await _unitOfWork.Repository<ProjectParticipation>().UpdateAsync(participant);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while updating the status for {nameof(participantId)}:{participantId}", ex);
            }
        }

        public async Task<IEnumerable<ProjectParticipationDto>> GetAllAsync()
        {
            var projectParticipations = await _unitOfWork.Repository<ProjectParticipation>()
                .GetListWithIncludeAsync("User", "Project");


            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectParticipation, ProjectParticipationDto>()
                .ForMember(m => m.ProjectId, opt => opt.MapFrom(m => m.ProjectId))
                .ForMember(m => m.ProjectName, opt => opt.MapFrom(m => m.Project.Name))
                .ForMember(m => m.RequstedGuidUserId, opt => opt.MapFrom(m => m.CreatedById))
                .ForMember(m => m.RequestedUserName, opt => opt.MapFrom(m => m.User.UserName))
                .ForMember(m => m.RequestedUserEmail, opt => opt.MapFrom(m => m.User.Email))
            ).CreateMapper();
            var projectParticipationDtos =
                mapper.Map<IEnumerable<ProjectParticipation>, IEnumerable<ProjectParticipationDto>>(
                    projectParticipations);

            return projectParticipationDtos;
        }


        public async Task CreateRequestAsync(Guid userId, int projectId)
        {
            try
            {
                var user = await _unitOfWork.Repository<User>().GetAsync(u => u.Id == userId);
                var isRequested = await _unitOfWork.Repository<ProjectParticipation>()
                    .GetAsync(p => p.ProjectId == projectId && p.User.Id == userId);


                if (isRequested == null)
                {
                    ProjectParticipation member = new ProjectParticipation
                    {
                        User = user,
                        ProjectId = projectId,
                        Status = ProjectParticipationStatus.New,
                    };

                    await _unitOfWork.Repository<ProjectParticipation>().AddAsync(member);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    throw new Exception($"Request already sent for {nameof(userId)}:{userId}" +
                                        $"and {nameof(projectId)}:{projectId}: ");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when creating request for {nameof(userId)}:{userId}" +
                                    $"and {nameof(projectId)}:{projectId}: ", ex);
            }
        }
    }
}