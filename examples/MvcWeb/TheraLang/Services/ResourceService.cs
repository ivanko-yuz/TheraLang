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

        public async Task<bool> AddResource(Resource resource)
        {
            try
            {
                resource.CreatedDateUTC = DateTime.UtcNow;
                await unitOfWork.Repository<Resource>().Add(resource);
                await unitOfWork.SaveChangesAsync();
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateResource(Resource resource, int updatetById)
        {
            try
            {
                resource.UpdatedDateUTC = DateTime.UtcNow;
                resource.UpdatedbyId = updatetById;

                unitOfWork.Repository<Resource>().Update(resource);
                await unitOfWork.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
