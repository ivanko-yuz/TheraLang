using System;
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
                Resource resource = _unitOfWork.Repository<Resource>().Get().Where(i => i.Id == Id).SingleOrDefault();
                return resource;
            }
            catch(Exception ex)
            {
                throw new Exception($"Error when geting resource by Id: ", ex);
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
                throw new Exception($"Error when adding the Id: {resource.Id} ", ex);
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
                throw new Exception($"Error when updating the Id: {resource.Id} ", ex);
            }
        }   

        public async Task RemoveResource(int Id)
        {
            try
            {
                Resource resource = _unitOfWork.Repository<Resource>().Get().Where(i => i.Id == Id).SingleOrDefault();
                _unitOfWork.Repository<Resource>().Remove(resource);

                await _unitOfWork.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"Error when removing the Resource: ", ex);
            }
        }
    }
}
