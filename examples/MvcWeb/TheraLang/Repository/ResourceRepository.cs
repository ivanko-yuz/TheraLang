using MvcWeb.TheraLang.Entities;
using System.Linq;
using MvcWeb.TheraLang.UnitOfWork;

namespace MvcWeb.TheraLang.Repository
{
    public class ResourceRepository : IResourceRepository
    {
        private readonly IUnitOfWork unitOfWork;

        public ResourceRepository(IUnitOfWork _unit)
        {
            unitOfWork = _unit;
        }

        public void RemoveResource(int Id)
        {
            Resource resource = unitOfWork.Repository<Resource>().Get().Where(i => i.Id == Id).FirstOrDefault();
            unitOfWork.Repository<Resource>().Remove(resource);

            unitOfWork.SaveChangesAsync();
        }

        public Resource GetResource(int Id)
        {
            Resource resource = unitOfWork.Repository<Resource>().Get().Where(i => i.Id == Id).FirstOrDefault();
            return resource;
        }
    }
}
