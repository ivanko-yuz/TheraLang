﻿using Microsoft.EntityFrameworkCore;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResourceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Resource GetResourceById(int id)
        {
            try
            {
                Resource resource = _unitOfWork.Repository<Resource>().Get().SingleOrDefault(i => i.Id == id);
                return resource;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when geting resource by {nameof(id)}={id}: ", ex);
            }
        }

        public async Task AddResource(Resource resource)
        {
            try
            {
                resource.CreatedDateUtc = DateTime.UtcNow;
                await _unitOfWork.Repository<Resource>().Add(resource);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when adding the {nameof(resource)}: {resource.Id} ", ex);
            }
        }

        public async Task UpdateResource(Resource resource, int updatetById)
        {
            try
            {
                resource.UpdatedDateUtc = DateTime.UtcNow;
                resource.UpdatedById = updatetById;

                _unitOfWork.Repository<Resource>().Update(resource);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when updating the {nameof(resource)}: {resource.Id}: ", ex);
            }
        }

        public async Task RemoveResource(int id)
        {
            try
            {
                Resource resource = _unitOfWork.Repository<Resource>().Get().SingleOrDefault(i => i.Id == id);
                _unitOfWork.Repository<Resource>().Remove(resource);

                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when remove resource by {nameof(id)}: {id}: ", ex);
            }
        }

        public IEnumerable<Resource> GetAllResources(int pageNumber, int recordsPerPage)
        {
            try
            {
                var resources = _unitOfWork.Repository<Resource>().Get();
                IEnumerable<Resource> resourcesPerPages = resources.Skip((pageNumber - 1) * recordsPerPage)
                    .Take(recordsPerPage).AsNoTracking().ToList();
                return resourcesPerPages;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when get all resources: ", ex);
            }
        }

        public int GetResourcesCount()
        {
            try
            {
                int countAllResources = _unitOfWork.Repository<Resource>().Get().Count();
                return countAllResources;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when get count all resources", ex);
            }
        }
    }
}