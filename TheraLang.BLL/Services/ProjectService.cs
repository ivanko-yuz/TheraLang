using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Constants;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Enums;
using TheraLang.DAL.UnitOfWork;
using TheraLang.DAL.Models;

namespace TheraLang.BLL.Services
{
    public class ProjectService : IProjectService
    {
        public ProjectService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        private readonly IUnitOfWork _uow;

        public IEnumerable<ProjectDto> GetAllProjects()
        {
            var projects = _uow.Repository<Project>().Get().Include(x => x.Donations);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                    .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(p => p.DonationTarget)))
                .CreateMapper();
            var projectsDto = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDto>>(projects);

            return projectsDto;
        }

        public IEnumerable<ProjectDto> GetAllNewProjects()
        {
            var projects = _uow.Repository<Project>().Get().Where(i => i.StatusId == 0);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                    .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(p => p.DonationTarget)))
                .CreateMapper();
            var projectsDto = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDto>>(projects);

            return projectsDto;
        }

        public IEnumerable<ProjectDto> GetProjectsByStatus(int status)
        {
            var projects = _uow.Repository<Project>().Get().Where(i => i.StatusId == (ProjectStatus)status).ToArray();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                    .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(p => p.DonationTarget)))
                .CreateMapper();
            var projectsDto = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDto>>(projects);

            return projectsDto;
        }

        public async Task Add(ProjectDto projectDto, Guid userId)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectDto, Project>()
                .ForMember(p => p.DonationTarget, opt => opt.MapFrom(src => src.DonationTargetSum))
                .ForMember(p => p.IsActive, opt => opt.MapFrom(src => true)))
                .CreateMapper();

            var project = mapper.Map<ProjectDto, Project>(projectDto);

            var newParticipant = new ProjectParticipation
            {
                Role = DAL.Enums.MemberRole.ProjectOwner,
                CreatedById = userId,
                Status = DAL.Enums.ProjectParticipationStatus.Approved,
                Project = project,
            };
            try
            {
                await _uow.Repository<Project>().Add(project);
                await _uow.SaveChangesAsync();
                await _uow.Repository<ProjectParticipation>().Add(newParticipant);
                await _uow.SaveChangesAsync();
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
                var project = _uow.Repository<Project>().Get().SingleOrDefault(p => p.Id == id);
                if (project == null)
                {
                    throw new NullReferenceException($"Error while deleting project. Project with id {nameof(id)}={id} not found");
                }
                _uow.Repository<Project>().Remove(project);
                await _uow.SaveChangesAsync();
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
                var projects = _uow.Repository<Project>().Get().AsNoTracking();
                var projectsPerPages = projects.Skip((pageNumber - 1) * pageSize).Take(pageSize);

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                    .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(p => p.DonationTarget)))
                    .CreateMapper();
                var projectsPerPagesDto = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDto>>(projectsPerPages);

                return projectsPerPagesDto;
            }
            catch
            {
                throw new Exception($"Error while fetching the projects for {nameof(pageNumber)}={pageNumber} and {nameof(pageSize)}={pageSize}");
            }
        }

        public async Task ChangeStatus(int projectId, ProjectStatus status)
        {
            var project = _uow.Repository<Project>().Get().SingleOrDefault(p => p.Id == projectId);
            if (project is null)
            {
                throw new NullReferenceException($"{ nameof(project) } cannot be null");
            }
            project.StatusId = status;
            _uow.Repository<Project>().Update(project);

            await _uow.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, ProjectDto projectDto)
        {
            try
            {
                var proj = _uow.Repository<Project>().Get().SingleOrDefault(p => p.Id == id);
                if (proj == null)
                {
                    throw new NullReferenceException($"Error while updating project. Project with id {nameof(id)}={id} not found");
                }

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectDto, Project>()
                        .ForMember(p => p.DonationTarget, opt => opt.MapFrom(src => src.DonationTargetSum)))
                    .CreateMapper();
                var project = mapper.Map<ProjectDto, Project>(projectDto);

                _uow.Repository<Project>().Update(project);
                await _uow.SaveChangesAsync();
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
                var project = _uow.Repository<Project>().Get().SingleOrDefault(i => i.Id == id);

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