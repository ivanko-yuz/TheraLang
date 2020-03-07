using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Common.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.CustomTypes;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Controllers
{
    [Route("api/pages")]
    [ApiController]
    public class PageController : ControllerBase
    {
        private readonly IPageService _pageService;
        private readonly IAuthenticateService _authenticateService;

        public PageController(IPageService pageService, IAuthenticateService authenticateService)
        {
            _pageService = pageService;
            _authenticateService = authenticateService;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreatePages([FromBody] IEnumerable<PageViewModel> pageModels)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageViewModel, PageDto>()
                    .ForMember(c => c.Content, opt => opt.MapFrom(n => new HtmlContent(n.Content))))
                .CreateMapper();
            var pagesDto = mapper.Map<IEnumerable<PageViewModel>, IEnumerable<PageDto>>(pageModels);

            await _pageService.Add(pagesDto);
            return Ok();
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> EditPage(int id, [FromBody] PageViewModel pageModel)
        {
            var page = await _pageService.GetPageById(id);
            if (page == null) return NotFound();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageViewModel, PageDto>()
                    .ForMember(c => c.Content, opt => opt.MapFrom(n => new HtmlContent(n.Content))))
                .CreateMapper();
            var pageDto = mapper.Map<PageViewModel, PageDto>(pageModel);

            await _pageService.Update(pageDto, id);
            return Ok();
        }

        [HttpPut("route/{route}")]
        [Authorize]
        public async Task<IActionResult> EditPages(string route, [FromBody] IEnumerable<PageViewModel> pageModels)
        {
            var page = await _pageService.GetPagesByRoute(route);
            if (!page.Any()) return NotFound();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageViewModel, PageDto>()
                    .ForMember(c => c.Content, opt => opt.MapFrom(n => new HtmlContent(n.Content))))
                .CreateMapper();
            var pageDto = mapper.Map<IEnumerable<PageViewModel>, IEnumerable<PageDto>>(pageModels);

            await _pageService.UpdatePages(pageDto, route);
            return Ok();
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
        public async Task<IActionResult> GetPageByRoute(Language lang, string route)
        {
            var page = await _pageService.GetPageByRoute(route, lang);
            if (page == null) return NotFound();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageDto, PageViewModel>())
                .CreateMapper();
            var pageModel = mapper.Map<PageDto, PageViewModel>(page);

            return Ok(pageModel);
        }

        [HttpGet("{route}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPagesByRoute(string route)
        {
            var pagesDto = await _pageService.GetPagesByRoute(route);
            if (!pagesDto.Any()) return NotFound();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageDto, PageViewModel>())
                .CreateMapper();
            var pagesModel = mapper.Map<IEnumerable<PageDto>, IEnumerable<PageViewModel>>(pagesDto);

            return Ok(pagesModel);
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
            var page = await _pageService.GetPageById(id);
            if (page == null) return NotFound();

            await _pageService.Remove(id);

            return Ok();
        }
    }
}