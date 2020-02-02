using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.DataTransferObjects.Constants;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Enums;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ProjectDto>> GetAllProjectsAsync()
        {
            var projects = await _unitOfWork.Repository<Project>().GetListWithIncludeAsync("Donations");

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                    .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(p => p.DonationTarget)))
                .CreateMapper();
            var projectsDto = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDto>>(projects);

            return projectsDto;
        }

        public async Task<IEnumerable<ProjectDto>> GetAllNewProjectsAsync()
        {
            var projects = await _unitOfWork.Repository<Project>().GetListAsync(i => i.StatusId == 0);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                    .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(p => p.DonationTarget)))
                .CreateMapper();
            var projectsDto = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDto>>(projects);

            return projectsDto;
        }

        public async Task<IEnumerable<ProjectDto>> GetProjectsByStatusAsync(int status)
        {
            var projects =
                (await _unitOfWork.Repository<Project>().GetListAsync(i => i.StatusId == (ProjectStatus) status))
                .ToArray();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                    .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(p => p.DonationTarget)))
                .CreateMapper();
            var projectsDto = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDto>>(projects);

            return projectsDto;
        }

        public async Task AddAsync(ProjectDto projectDto, Guid userId)
        {
            var user = await _unitOfWork.Repository<User>().GetAsync(u => u.Id == userId);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectDto, Project>()
                    .ForMember(p => p.DonationTarget, opt => opt.MapFrom(src => src.DonationTargetSum))
                    .ForMember(p => p.IsActive, opt => opt.MapFrom(src => true)))
                .CreateMapper();

            var project = mapper.Map<ProjectDto, Project>(projectDto);

            var newParticipant = new ProjectParticipation
            {
                Role = MemberRole.ProjectOwner,
                User = user,
                Status = ProjectParticipationStatus.Approved,
                Project = project,
            };
            try
            {
                await _unitOfWork.Repository<Project>().AddAsync(project);
                await _unitOfWork.Repository<ProjectParticipation>().AddAsync(newParticipant);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["project"] = projectDto;
                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var project = await _unitOfWork.Repository<Project>().GetAsync(p => p.Id == id);
                if (project == null)
                {
                    throw new ArgumentNullException(
                        $"Error while deleting project. Project with id {nameof(id)}={id} not found");
                }

                await _unitOfWork.Repository<Project>().RemoveAsync(project);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["projectId"] = id;
                throw;
            }
        }

        public async Task<IEnumerable<ProjectDto>> GetProjectsAsync(int pageNumber,
            int pageSize = PaginationConstants.RecordsPerPage)
        {
            try
            {
                var projects = (await _unitOfWork.Repository<Project>().GetListAsync()).AsNoTracking();
                var projectsPerPage = projects.Skip((pageNumber - 1) * pageSize).Take(pageSize);

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                        .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(p => p.DonationTarget)))
                    .CreateMapper();
                var projectDtosPerPage = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDto>>(projectsPerPage);

                return projectDtosPerPage;
            }
            catch
            {
                throw new Exception(
                    $"Error while fetching the projects for {nameof(pageNumber)}={pageNumber} and {nameof(pageSize)}={pageSize}");
            }
        }

        public async Task ChangeStatusAsync(int projectId, ProjectStatusDto status)
        {
            var project = await _unitOfWork.Repository<Project>().GetAsync(p => p.Id == projectId);
            if (project == null)
            {
                throw new ArgumentNullException(
                    $"Error while changing status. Project with id {nameof(projectId)}={projectId} not found");
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectStatusDto, ProjectStatus>())
                .CreateMapper();
            var projectStatus = mapper.Map<ProjectStatusDto, ProjectStatus>(status);

            project.StatusId = projectStatus;
            await _unitOfWork.Repository<Project>().UpdateAsync(project);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, ProjectDto projectDto)
        {
            try
            {
                var proj = await _unitOfWork.Repository<Project>().GetAsync(p => p.Id == id);
                if (proj == null)
                {
                    throw new ArgumentNullException(
                        $"Error while updating project. Project with id {nameof(id)}={id} not found");
                }

                proj.Name = projectDto.Name;
                proj.Description = projectDto.Description;
                proj.Details = projectDto.Details;
                proj.ProjectStart = projectDto.ProjectStart;
                proj.ProjectEnd = projectDto.ProjectEnd;
                proj.DonationTarget = projectDto.DonationTargetSum;

                await _unitOfWork.Repository<Project>().UpdateAsync(proj);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["project"] = projectDto;
                throw;
            }
        }

        public async Task<ProjectDto> GetByIdAsync(int id)
        {
            try
            {
                var project = await _unitOfWork.Repository<Project>().GetAsync(i => i.Id == id);

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                        .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(src => src.DonationTarget)))
                    .CreateMapper();

                var projectDto = mapper.Map<Project, ProjectDto>(project);

                return projectDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when getting project by {nameof(id)} = {id} ", ex);
            }
        }
    }
}