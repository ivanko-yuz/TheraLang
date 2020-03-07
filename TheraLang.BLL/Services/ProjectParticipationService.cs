using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Common.Enums;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class ProjectParticipationService : IProjectParticipationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthenticateService _authenticateService;

        public ProjectParticipationService(IUnitOfWork unitOfWork, IAuthenticateService authenticateService)
        {
            _unitOfWork = unitOfWork;
            _authenticateService = authenticateService;
        }

        public async Task ChangeStatus(int participantId, ProjectParticipationStatus status)
        {
            try
            {
                var participant = await _unitOfWork.Repository<ProjectParticipation>()
                    .Get(x => x.Id == participantId);

                if (participant == null)
                {
                    throw new NullReferenceException(
                        $"Error while changing status. Participant with id {nameof(participantId)}={participantId} not found");
                }

                participant.Status = status;

                _unitOfWork.Repository<ProjectParticipation>().Update(participant);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while updating the status for {nameof(participantId)}:{participantId}", ex);
            }
        }

        public async Task<IEnumerable<ProjectParticipationDto>> GetAll()
        {
            var currentUserId = (await _authenticateService.GetAuthUserAsync()).Id;

            var projectParticipations = await _unitOfWork.Repository<ProjectParticipation>().GetAll()
                .Where(p => p.Role != MemberRole.ProjectOwner)
                .Where(p => p.Project.OwnerId == currentUserId)
                .Include(p => p.User)
                .ThenInclude(p => p.Details)
                .Include(p => p.Project)
                .ToListAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectParticipation, ProjectParticipationDto>()
                .ForMember(m => m.RequstedGuidUserId, opt => opt.MapFrom(m => m.User.Id))
                .ForMember(m => m.RequestedUserName,
                    opt => opt.MapFrom(m => $"{m.User.Details.FirstName} {m.User.Details.LastName}"))
            ).CreateMapper();

            var projectParticipationDtos = mapper.Map<IEnumerable<ProjectParticipation>, IEnumerable<ProjectParticipationDto>>(projectParticipations);

            return projectParticipationDtos;
        }

        public async Task<IEnumerable<ProjectParticipationDto>> GetProjectParticipations(int projectId)
        {
            var projectParticipations = await _unitOfWork.Repository<ProjectParticipation>()
                .GetAll()
                .Where(p => p.ProjectId == projectId && p.Status == ProjectParticipationStatus.Approved)
                .Include(p => p.User)
                .Include(p => p.Project)
                .ToListAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectParticipation, ProjectParticipationDto>()
                .ForMember(m => m.RequstedGuidUserId, opt => opt.MapFrom(m => m.User.Id))
                .ForMember(m => m.RequestedUserName,
                    opt => opt.MapFrom(m => $"{m.User.Details.FirstName} {m.User.Details.LastName}"))
                .ForMember(m => m.RequestedUserEmail, opt => opt.MapFrom(m => m.User.Email))
            ).CreateMapper();
            var projectParticipationDtos =
                mapper.Map<IEnumerable<ProjectParticipation>, IEnumerable<ProjectParticipationDto>>(
                    projectParticipations);

            return projectParticipationDtos;
        }

        public async Task CreateRequest(Guid userId, int projectId)
        {
            try
            {
                var user = await _unitOfWork.Repository<User>().Get(u => u.Id == userId);
                var isRequested = await _unitOfWork.Repository<ProjectParticipation>()
                    .Get(p => p.ProjectId == projectId && p.User.Id == userId);


                if (isRequested == null)
                {
                    var member = new ProjectParticipation
                    {
                        User = user,
                        ProjectId = projectId,
                        Status = ProjectParticipationStatus.New,
                    };

                    _unitOfWork.Repository<ProjectParticipation>().Add(member);
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