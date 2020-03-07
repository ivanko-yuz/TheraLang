using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Common.Constants;
using Common.Enums;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.DataTransferObjects.Projects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileService _fileService;
        private readonly IChatService _chatService;

        public ProjectService(IUnitOfWork unitOfWork, IFileService fileService, IChatService chatService)
        {
            _unitOfWork = unitOfWork;
            _fileService = fileService;
            _chatService = chatService;
        }

        public async Task<IEnumerable<ProjectPreviewDto>> GetAllProjectsAsync()
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Project, ProjectPreviewDto>()
                    .ForMember(dto => dto.DonationTargetSum,
                        opt => opt.MapFrom(p => p.DonationTarget))
                    .ForMember(dto => dto.DonationsSum,
                        opts => opts.MapFrom(entity => entity.Donations.Sum(donation => donation.Amount))
                    );
            });

            var projectsDtos = await _unitOfWork.Repository<Project>()
                .GetAll()
                .Where(x => x.StatusId == ProjectStatus.Approved)
                .ProjectTo<ProjectPreviewDto>(mapper)
                .ToListAsync();

            return projectsDtos;
        }

        public async Task<IEnumerable<ProjectDto>> GetAllNewProjectsAsync()
        {
            var projects = await _unitOfWork.Repository<Project>().GetAllAsync(i => i.StatusId == 0);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                    .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(p => p.DonationTarget)))
                .CreateMapper();
            var projectsDto = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDto>>(projects);
            return projectsDto;
        }

        public async Task<IEnumerable<ProjectDto>> GetProjectsByStatusAsync(int status)
        {
            var projects =
                (await _unitOfWork.Repository<Project>().GetAllAsync(i => i.StatusId == (ProjectStatus) status))
                .ToArray();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDto>()
                    .ForMember(p => p.DonationTargetSum, opt => opt.MapFrom(p => p.DonationTarget)))
                .CreateMapper();
            var projectsDto = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDto>>(projects);

            return projectsDto;
        }

        public async Task AddAsync(ProjectDto projectDto, Guid userId)
        {
            var user = await _unitOfWork.Repository<User>().Get(u => u.Id == userId);

            if (projectDto.ImgFile != null)
            {
                using (var fileStream = projectDto.ImgFile.OpenReadStream())
                {
                    var fileExtension = Path.GetExtension(projectDto.ImgFile.FileName);
                    var fileUri = await _fileService.SaveFile(fileStream, fileExtension);
                    projectDto.ImgUrl = fileUri.ToString();
                }
            }

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
                _unitOfWork.Repository<Project>().Add(project);
                _unitOfWork.Repository<ProjectParticipation>().Add(newParticipant);
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
                var project = await _unitOfWork.Repository<Project>().Get(p => p.Id == id);
                if (project == null)
                {
                    throw new ArgumentNullException(
                        $"Error while deleting project. Project with id {nameof(id)}={id} not found");
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

        public async Task<IEnumerable<ProjectDto>> GetProjectsAsync(int pageNumber,
            int pageSize = PaginationConstants.RecordsPerPage)
        {
            try
            {
                var projects = await _unitOfWork.Repository<Project>().GetAll().AsNoTracking().ToListAsync();
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
            var project = await _unitOfWork.Repository<Project>().Get(p => p.Id == projectId);
            if (project == null)
            {
                throw new ArgumentNullException(
                    $"Error while changing status. Project with id {nameof(projectId)}={projectId} not found");
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectStatusDto, ProjectStatus>())
                .CreateMapper();
            var projectStatus = mapper.Map<ProjectStatusDto, ProjectStatus>(status);

            project.StatusId = projectStatus;

            if (project.StatusId == ProjectStatus.Approved)
            {
                var chatId = await _chatService.CreateRoom(project.Name);
                project.ChatId = chatId;
            }

            _unitOfWork.Repository<Project>().Update(project);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, ProjectDto projectDto)
        {
            try
            {
                var proj = await _unitOfWork.Repository<Project>().Get(p => p.Id == id);
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

                _unitOfWork.Repository<Project>().Update(proj);
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
                var project = await _unitOfWork.Repository<Project>().Get(i => i.Id == id);

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