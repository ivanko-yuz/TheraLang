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

        public IEnumerable<ProjectDto> GetAllProjects()
        {
            var projects = _unitOfWork.Repository<Project>().Get().Include(x => x.Donations);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                    .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(p => p.DonationTarget)))
                .CreateMapper();
            var projectsDto = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDto>>(projects);

            return projectsDto;
        }

        public IEnumerable<ProjectDto> GetAllNewProjects()
        {
            var projects = _unitOfWork.Repository<Project>().Get().Where(i => i.StatusId == 0);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                    .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(p => p.DonationTarget)))
                .CreateMapper();
            var projectsDto = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDto>>(projects);

            return projectsDto;
        }

        public IEnumerable<ProjectDto> GetProjectsByStatus(int status)
        {
            var projects = _unitOfWork.Repository<Project>().Get().Where(i => i.StatusId == (ProjectStatus)status).ToArray();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                    .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(p => p.DonationTarget)))
                .CreateMapper();
            var projectsDto = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDto>>(projects);

            return projectsDto;
        }

        public async Task Add(ProjectDto projectDto, Guid userId)
        {
            var user = _unitOfWork.Repository<User>().Get().Where(u => u.Id == userId).FirstOrDefault();

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
                await _unitOfWork.Repository<Project>().Add(project);
                await _unitOfWork.Repository<ProjectParticipation>().Add(newParticipant);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["project"] = projectDto;
                throw;
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                var project = _unitOfWork.Repository<Project>().Get().SingleOrDefault(p => p.Id == id);
                if (project == null)
                {
                    throw new ArgumentNullException($"Error while deleting project. Project with id {nameof(id)}={id} not found");
                }
                _unitOfWork.Repository<Project>().Remove(project);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["projectId"] = id;
                throw;
            }
        }

        public IEnumerable<ProjectDto> GetProjects(int pageNumber, int pageSize = PaginationConstants.RecordsPerPage)
        {
            try
            {
                var projects = _unitOfWork.Repository<Project>().Get().AsNoTracking();
                var projectsPerPage = projects.Skip((pageNumber - 1) * pageSize).Take(pageSize);

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                    .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(p => p.DonationTarget)))
                    .CreateMapper();
                var projectDtosPerPage = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDto>>(projectsPerPage);

                return projectDtosPerPage;
            }
            catch
            {
                throw new Exception($"Error while fetching the projects for {nameof(pageNumber)}={pageNumber} and {nameof(pageSize)}={pageSize}");
            }
        }

        public async Task ChangeStatus(int projectId, ProjectStatusDto status)
        {
            var project = _unitOfWork.Repository<Project>().Get().SingleOrDefault(p => p.Id == projectId);
            if (project == null)
            {
                throw new ArgumentNullException($"Error while changing status. Project with id {nameof(projectId)}={projectId} not found");
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectStatusDto, ProjectStatus>()).CreateMapper();
            var projectStatus = mapper.Map<ProjectStatusDto, ProjectStatus>(status);

            project.StatusId = projectStatus;
            _unitOfWork.Repository<Project>().Update(project);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, ProjectDto projectDto)
        {
            try
            {
                var proj = _unitOfWork.Repository<Project>().Get().SingleOrDefault(p => p.Id == id);
                if (proj == null)
                {
                    throw new ArgumentNullException($"Error while updating project. Project with id {nameof(id)}={id} not found");
                }

                proj.Name = projectDto.Name;
                proj.Description = projectDto.Description;
                proj.Details = projectDto.Details;
                proj.ProjectStart = projectDto.ProjectStart;
                proj.ProjectEnd = projectDto.ProjectEnd;
                proj.DonationTarget = projectDto.DonationTargetSum;

                _unitOfWork.Repository<Project>().Update(proj);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["project"] = projectDto;
                throw;
            }
        }

        public ProjectDto GetById(int id)
        {
            try
            {
                var project = _unitOfWork.Repository<Project>().Get().SingleOrDefault(i => i.Id == id);

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