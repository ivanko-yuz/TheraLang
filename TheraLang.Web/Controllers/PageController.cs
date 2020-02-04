using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using TheraLang.Web.ViewModels;
using TheraLang.Web.Extensions;
using AutoMapper;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : ControllerBase
    {
        private readonly IPageService _pageService;
        private readonly IUserManagementService _userManagementService;

        public PageController(IPageService pageService, IUserManagementService userManagementService)
        {
            _pageService = pageService;
            _userManagementService = userManagementService;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreatePage([FromBody] PageViewModel pageModel)
        {
            var UserId = User.Claims.GetUserId();
            if (UserId == null) return BadRequest();

            if (pageModel == null) return BadRequest();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageViewModel, PageDto>())
                .CreateMapper();
            var pageDto = mapper.Map<PageViewModel, PageDto>(pageModel);

            await _pageService.Add(pageDto);
            return Ok(pageDto);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> EditPage(int pageId, [FromBody] PageViewModel pageModel)
        {
            var UserId = User.Claims.GetUserId();
            if (UserId == null) return BadRequest();

            var page = await _pageService.GetPage(pageId);
            if (page == null) return NotFound();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageViewModel, PageDto>())
                .CreateMapper();
            var pageDto = mapper.Map<PageViewModel, PageDto>(pageModel);

            await _pageService.Update(pageDto, pageId);
            return Ok(pageDto);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPage(int pageId)
        {
            var page = await _pageService.GetPage(pageId);
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

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageDto, PageViewModel>())
               .CreateMapper();
            var pageModel = mapper.Map<IEnumerable<PageDto>, IEnumerable<PageViewModel>>(pages);

            return Ok(pageModel);
        }

        [HttpDelete("id")]
        [Authorize]
        public async Task<IActionResult> RemovePage(int pageId)
        {
            var UserId = User.Claims.GetUserId();
            if (UserId == null) return BadRequest();

            var page = await _pageService.GetPage(pageId);
            if (page == null) return NotFound();

            await _pageService.Remove(pageId);

            return Ok();
        }
    }
}