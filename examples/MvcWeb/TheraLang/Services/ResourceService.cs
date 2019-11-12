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
        private readonly IUnitOfWork unitOfWork;

        public ResourceService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Resource GetResourceById(int? Id)
        {

            try
            {
                Resource resource = unitOfWork.Repository<Resource>().Get().Where(i => i.Id == Id).FirstOrDefault();
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
                await unitOfWork.Repository<Resource>().Add(resource);
                await unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when adding the Id: {resource.Id} ", ex);
            }
        }

        public async Task UpdateResource(Resource resource, Guid updatetById)
        {
            try
            {
                resource.UpdatedDateUtc = DateTime.UtcNow;
                resource.UpdatedById = updatetById;

                unitOfWork.Repository<Resource>().Update(resource);
                await unitOfWork.SaveChangesAsync();
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
                Resource resource = unitOfWork.Repository<Resource>().Get().Where(i => i.Id == Id).SingleOrDefault();
                unitOfWork.Repository<Resource>().Remove(resource);

                await unitOfWork.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"Error when removing the Resource: ", ex);
            }
        }

        public IEnumerable<Resource> GetAllResourcesWhereProjectIdNull(int? Id)
        {
            try
            {
                IEnumerable<Resource>resources = unitOfWork.Repository<Resource>().Get().Where(i => i.ResourceProjectId == Id); 
                return resources;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when get resources with Id equal null: ", ex);
            }
        }
    }
}
