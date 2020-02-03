using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.Interfaces;

namespace TheraLang.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SiteMapController : ControllerBase
    {
        private readonly ISiteMapService _siteMapService;

        public SiteMapController(ISiteMapService siteMapService)
        {
            _siteMapService = siteMapService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           return Ok(await _siteMapService.GetAll());
        }
    }
}