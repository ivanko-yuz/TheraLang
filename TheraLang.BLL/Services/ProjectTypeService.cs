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

        public async Task AddAsync(ProjectTypeDto projectTypeDto)
        {
            try
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectTypeDto, ProjectType>())
                    .CreateMapper();
                var projectType = mapper.Map<ProjectTypeDto, ProjectType>(projectTypeDto);

                await _unitOfWork.Repository<ProjectType>().AddAsync(projectType);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ex.Data[nameof(ProjectType)] = projectTypeDto;
                throw new Exception($"Error when trying to add new {nameof(ProjectType)}", ex);
            }
        }

        public async Task RemoveAsync(int projectTypeId)
        {
            try
            {
                ProjectType projectType =
                    await _unitOfWork.Repository<ProjectType>().GetAsync(i => i.Id == projectTypeId);
                await _unitOfWork.Repository<ProjectType>().RemoveAsync(projectType);

                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when remove ProjectType by {nameof(ProjectType.Id)}: {projectTypeId}: ",
                    ex);
            }
        }

        public async Task UpdateAsync(ProjectTypeDto projectTypeDto)
        {
            try
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectTypeDto, ProjectType>())
                    .CreateMapper();
                var projectType = mapper.Map<ProjectTypeDto, ProjectType>(projectTypeDto);

                await _unitOfWork.Repository<ProjectType>().UpdateAsync(projectType);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when updating the {nameof(ProjectType)}: {projectTypeDto.Id}: ", ex);
            }
        }

        public async Task<IEnumerable<ProjectTypeDto>> GetAllProjectsTypeAsync()
        {
            var projectTypes = (await _unitOfWork.Repository<ProjectType>().GetListAsync()).AsNoTracking().ToList();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectType, ProjectTypeDto>()).CreateMapper();
            var projectTypesDto = mapper.Map<IEnumerable<ProjectType>, IEnumerable<ProjectTypeDto>>(projectTypes);

            return projectTypesDto;
        }

        public async Task<ProjectTypeDto> GetProjectTypeByIdAsync(int id)
        {
            try
            {
                ProjectType projectType = await _unitOfWork.Repository<ProjectType>().GetAsync(p => p.Id == id);

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectType, ProjectTypeDto>())
                    .CreateMapper();
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