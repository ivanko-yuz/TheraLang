using Microsoft.AspNetCore.Mvc;
using MvcWeb.Db.Entities;
using MvcWeb.UnitOfWork;
using System.Threading.Tasks;

namespace MvcWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private IUnitOfWork UnitOfWork;

        public ResourceController(IUnitOfWork unit)
        {
            this.UnitOfWork = unit;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Resource resource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await UnitOfWork.Repository<Resource>().Add(resource);
            await UnitOfWork.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Resource resource)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            UnitOfWork.Repository<Resource>().Update(resource);
            await UnitOfWork.SaveChangesAsync();

            return Ok();
        }
    }
}