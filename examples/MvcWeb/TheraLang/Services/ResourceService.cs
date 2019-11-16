using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;

namespace MvcWeb.TheraLang.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResourceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Resource GetResourceById(int Id)
        {
            try
            {
                Resource resource = _unitOfWork.Repository<Resource>().Get().SingleOrDefault(i => i.Id == Id);
                return resource;
            }
            catch(Exception ex)
            {
                throw new Exception($"Error when geting resource by {nameof(Id)}={Id}: ", ex);  
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
            catch(Exception ex)
            {
                throw new Exception($"Error when updating the {nameof(resource)}: {resource.Id}: ", ex);
            }
        }   

        public async Task RemoveResource(int Id)
        {
            try
            {
                Resource resource = _unitOfWork.Repository<Resource>().Get().SingleOrDefault(i => i.Id == Id);
                _unitOfWork.Repository<Resource>().Remove(resource);

                await _unitOfWork.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"Error when remove resource by {nameof(Id)}: {Id}: ", ex);
            }
        }

        public IEnumerable<Resource> GetAllResources(int pageNumber, int recordsPerPage)
        {
            try
            {
                IEnumerable<Resource> resources = _unitOfWork.Repository<Resource>().Get().Where(i => !i.ResourceProjects.Any());
                IEnumerable<Resource> resourcesPerPages = resources.Skip((pageNumber - 1) * recordsPerPage).Take(recordsPerPage);
                return resourcesPerPages;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when get all resources: ", ex);
            }
        }

        public int GetCountAllResources()
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
