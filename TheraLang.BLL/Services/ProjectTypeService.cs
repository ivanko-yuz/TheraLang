using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class ProjectTypeService : IProjectTypeService
    {
        private readonly IUnitOfWork _uow;
        public ProjectTypeService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task Add(ProjectTypeDto projectTypeDto)
        {
            try
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectTypeDto, ProjectType>()).CreateMapper();
                var projectType = mapper.Map<ProjectTypeDto, ProjectType>(projectTypeDto);

                await _uow.Repository<ProjectType>().Add(projectType);
                await _uow.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ex.Data[nameof(ProjectType)] = projectTypeDto;
                throw new Exception($"Error when trying to add new {nameof(ProjectType)}", ex);
            }
        }

        public async Task Remove(int projectTypeId)
        {
            try
            {
                ProjectType projectType = _uow.Repository<ProjectType>().Get().SingleOrDefault(i => i.Id == projectTypeId);
                _uow.Repository<ProjectType>().Remove(projectType);

                await _uow.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when remove ProjectType by {nameof(ProjectType.Id)}: {projectTypeId}: ", ex);
            }
        }

        public async Task Update(ProjectTypeDto projectTypeDto, Guid userId)
        {
            try
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectTypeDto, ProjectType>()).CreateMapper();
                var projectType = mapper.Map<ProjectTypeDto, ProjectType>(projectTypeDto);

                _uow.Repository<ProjectType>().Update(projectType);
                await _uow.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when updating the {nameof(ProjectType)}: {projectTypeDto.Id}: ", ex);
            }
        }

        public IEnumerable<ProjectTypeDto> GetAllProjectsType()
        {
            var projectTypes = _uow.Repository<ProjectType>().Get().AsNoTracking().ToList();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectType, ProjectTypeDto>()).CreateMapper();
            var projectTypesDto = mapper.Map<IEnumerable<ProjectType>, IEnumerable<ProjectTypeDto>>(projectTypes);

            return projectTypesDto;
        }

        public ProjectTypeDto GetProjectTypeById(int id)
        {
            try
            {
                ProjectType projectType = _uow.Repository<ProjectType>().Get().FirstOrDefault(p => p.Id == id);

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectType, ProjectTypeDto>()).CreateMapper();
                var projectTypeDto = mapper.Map<ProjectType, ProjectTypeDto>(projectType);

                return projectTypeDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when getting project by {nameof(id)} = {id}: ", ex);
            }
        }
    }
}
