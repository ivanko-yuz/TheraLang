using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using TheraLang.Web.ViewModels;
using TheraLang.Web.Extensions;
using AutoMapper;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.CustomTypes;

namespace TheraLang.Web.Controllers
{
    [Route("api/pages")]
    [ApiController]
    public class PageController : ControllerBase
    {
        private readonly IPageService _pageService;

        public PageController(IPageService pageService)
        {
            _pageService = pageService;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreatePage([FromBody] PageViewModel pageModel)
        {
            var userId = User.Claims.GetUserId();
            if (userId == null) return BadRequest();

            if (pageModel == null) return BadRequest();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageViewModel, PageDto>()
            .ForMember(c => c.Content, opt => opt.MapFrom(n => new HtmlContent(n.Content))))
                .CreateMapper();
            var pageDto = mapper.Map<PageViewModel, PageDto>(pageModel);

            await _pageService.Add(pageDto);
            return Ok(pageDto);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> EditPage(int id, [FromBody] PageViewModel pageModel)
        {
            var userId = User.Claims.GetUserId();
            if (userId == null) return BadRequest();

            var page = await _pageService.GetPageById(id);
            if (page == null) return NotFound();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageViewModel, PageDto>()
            .ForMember(c => c.Content, opt => opt.MapFrom(n => new HtmlContent(n.Content))))
                .CreateMapper();
            var pageDto = mapper.Map<PageViewModel, PageDto>(pageModel);

            await _pageService.Update(pageDto, id);
            return Ok(pageDto);
        }

        [HttpGet("id{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPageById(int id)
        {
            var page = await _pageService.GetPageById(id);
            if (page == null) return NotFound();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageDto, PageViewModel>())
                .CreateMapper();
            var pageModel = mapper.Map<PageDto, PageViewModel>(page);

            return Ok(pageModel);
        }

        [HttpGet("{lang}/{route}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPageByRoute(LanguageViewModel lang, string route)
        {
            var langMapper = new MapperConfiguration(cfg => cfg.CreateMap<LanguageViewModel, LanguageDto>()).CreateMapper();
            var langDto = langMapper.Map<LanguageViewModel, LanguageDto>(lang);

            var page = await _pageService.GetPageByRoute(route, langDto);
            if (page == null) return NotFound();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageDto, PageViewModel>())
                .CreateMapper();
            var pageModel = mapper.Map<PageDto, PageViewModel>(page);

            return Ok(pageModel);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPages()
        {
            var pages = await _pageService.GetAllPages();
            if (!pages.Any()) return NotFound();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageDto, PageViewModel>()
            .ForMember(c => c.Content, opt => opt.MapFrom(n => n.Content.ToString())))
               .CreateMapper();
            var pageModel = mapper.Map<IEnumerable<PageDto>, IEnumerable<PageViewModel>>(pages);

            return Ok(pageModel);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeletePage(int id)
        {
            var userId = User.Claims.GetUserId();
            if (userId == null) return BadRequest();

            var page = await _pageService.GetPageById(id);
            if (page == null) return NotFound();

            await _pageService.Remove(id);

            return Ok();
        }
    }
}