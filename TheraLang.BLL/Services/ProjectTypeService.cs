using System;
using System.Collections.Generic;
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
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectTypeDto, ProjectType>())
                    .CreateMapper();
                var projectType = mapper.Map<ProjectTypeDto, ProjectType>(projectTypeDto);

                _unitOfWork.Repository<ProjectType>().Add(projectType);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ex.Data[nameof(ProjectType)] = projectTypeDto;
                throw new Exception($"Cannot add new {nameof(ProjectType)}.", ex);
            }
        }

        public async Task Remove(int projectTypeId)
        {
            try
            {
                var projectType =
                    await _unitOfWork.Repository<ProjectType>().Get(i => i.Id == projectTypeId);
                _unitOfWork.Repository<ProjectType>().Remove(projectType);

                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Cannot remove ProjectType with {nameof(ProjectType.Id)}: {projectTypeId}.", ex);
            }
        }

        public async Task Update(ProjectTypeDto projectTypeDto)
        {
            try
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectTypeDto, ProjectType>())
                    .CreateMapper();
                var projectType = mapper.Map<ProjectTypeDto, ProjectType>(projectTypeDto);

                _unitOfWork.Repository<ProjectType>().Update(projectType);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Cannot update the {nameof(ProjectType)} with {nameof(projectTypeDto.Id)}: {projectTypeDto.Id}.",
                    ex);
            }
        }

        public async Task<IEnumerable<ProjectTypeDto>> GetAllProjectsType()
        {
            var projectTypes = await _unitOfWork.Repository<ProjectType>().GetAll()
                .AsNoTracking()
                .ToListAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectType, ProjectTypeDto>()).CreateMapper();
            var projectTypesDto = mapper.Map<IEnumerable<ProjectType>, IEnumerable<ProjectTypeDto>>(projectTypes);

            return projectTypesDto;
        }

        public async Task<ProjectTypeDto> GetProjectTypeById(int id)
        {
            var projectType = await _unitOfWork.Repository<ProjectType>().Get(p => p.Id == id);
            try
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectType, ProjectTypeDto>())
                    .CreateMapper();
                var projectTypeDto = mapper.Map<ProjectType, ProjectTypeDto>(projectType);

                return projectTypeDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Cannot get project with {nameof(id)}: {id}.", ex);
            }
        }
    }
}