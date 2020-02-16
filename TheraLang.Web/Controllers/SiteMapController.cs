using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels.SiteMap;

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
            var siteMapDtos = await _siteMapService.GetAll();
            var mapper = new MapperConfiguration(mapOpts =>
            {
                mapOpts.CreateMap<SiteMapDto, SiteMapViewModel>()
                    .ForMember(vm => vm.MenuTitle,
                        opts => opts.MapFrom(dto => dto.MenuName));
            }).CreateMapper();
            var siteMapVMs = mapper.Map<IEnumerable<SiteMapDto>,IEnumerable<SiteMapViewModel>>(siteMapDtos);
            return Ok(new {pages = siteMapVMs});
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ChangedSiteMapStructureViewModel siteMapStructure)
        {
            if (!siteMapStructure.SiteMaps.Any())
            {
                return NoContent();
            }
            var mapper = new MapperConfiguration(mapOpts => 
                mapOpts.CreateMap<ChangedSiteMapViewModel,SiteMapDto>()
                    .ForMember(dto => dto.SortOrder,opts => 
                        opts.MapFrom(vm => vm.NewIndex))
                    .ForMember(dto=>dto.ParentPageId,opts => 
                        opts.MapFrom(vm => vm.NewParentId))
            ).CreateMapper();
            var structure = 
                mapper.Map<IEnumerable<ChangedSiteMapViewModel>,IEnumerable<SiteMapDto>>(siteMapStructure.SiteMaps);
            await _siteMapService.UpdateStructure(structure);
            return NoContent();
        }
    }
}