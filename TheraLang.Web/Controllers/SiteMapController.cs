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
        
        
        
    }
}