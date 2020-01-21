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
        private readonly IUnitOfWork _unitOfWork;
        public ProjectTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Add(ProjectTypeDto projectTypeDto)
        {
            try
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectTypeDto, ProjectType>()).CreateMapper();
                var projectType = mapper.Map<ProjectTypeDto, ProjectType>(projectTypeDto);

                await _unitOfWork.Repository<ProjectType>().Add(projectType);
                await _unitOfWork.SaveChangesAsync();
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
                ProjectType projectType = _unitOfWork.Repository<ProjectType>().Get().SingleOrDefault(i => i.Id == projectTypeId);
                _unitOfWork.Repository<ProjectType>().Remove(projectType);

                await _unitOfWork.SaveChangesAsync();
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

                _unitOfWork.Repository<ProjectType>().Update(projectType);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when updating the {nameof(ProjectType)}: {projectTypeDto.Id}: ", ex);
            }
        }

        public IEnumerable<ProjectTypeDto> GetAllProjectsType()
        {
            var projectTypes = _unitOfWork.Repository<ProjectType>().Get().AsNoTracking().ToList();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectType, ProjectTypeDto>()).CreateMapper();
            var projectTypesDto = mapper.Map<IEnumerable<ProjectType>, IEnumerable<ProjectTypeDto>>(projectTypes);

            return projectTypesDto;
        }

        public ProjectTypeDto GetProjectTypeById(int id)
        {
            try
            {
                ProjectType projectType = _unitOfWork.Repository<ProjectType>().Get().FirstOrDefault(p => p.Id == id);

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
