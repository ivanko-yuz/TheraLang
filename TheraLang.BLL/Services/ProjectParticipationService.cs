﻿using System;
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
            var projectParticipations = _unitOfWork.Repository<ProjectParticipation>().Get()
                .Include(p => p.PiranhaUser)
                .Include(p => p.Project)
                .ToList();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectParticipation, ProjectParticipationDto>()
                .ForMember(m => m.ProjectId, opt => opt.MapFrom(m => m.ProjectId))
                .ForMember(m => m.ProjectName, opt => opt.MapFrom(m => m.Project.Name))
                .ForMember(m => m.RequstedGuidUserId, opt => opt.MapFrom(m => m.CreatedById))
                .ForMember(m => m.RequestedUserName, opt => opt.MapFrom(m => m.PiranhaUser.UserName))
                .ForMember(m => m.RequestedUserEmail, opt => opt.MapFrom(m => m.PiranhaUser.Email))
            ).CreateMapper();
            var projectParticipationDtos = mapper.Map<IEnumerable<ProjectParticipation>, IEnumerable<ProjectParticipationDto>>(projectParticipations);

            return projectParticipationDtos;
        }


        public async Task CreateRequest(Guid userId, int projectId)
        {
            try
            {
                var isRequested = _unitOfWork.Repository<ProjectParticipation>()
                    .Get()
                    .Any(p => p.ProjectId == projectId && p.CreatedById == userId);

                if (!isRequested)
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
