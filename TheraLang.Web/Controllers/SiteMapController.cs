using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;

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
            var res = await _siteMapService.GetAll(); 
            return Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] SiteMapStructureViewModel siteMapStructure)
        {
            var mapper = new MapperConfiguration(opts => 
                opts.CreateMap<SiteMapViewModel,SiteMapDto>()
                    .ForMember(sm => sm.Changed,
                        opt => 
                            opt.MapFrom(val=> false ))
                ).CreateMapper();
            var structure = 
                mapper.Map<IEnumerable<SiteMapViewModel>,IEnumerable<SiteMapDto>>(siteMapStructure.SiteMap);
            await _siteMapService.UpdateStructure(structure);
            return Ok(await _siteMapService.GetAll());
        }
    }
}