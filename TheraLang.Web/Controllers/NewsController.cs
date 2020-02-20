using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.DataTransferObjects.NewsDtos;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;
using TheraLang.Web.ViewModels.NewsViewModels;

namespace TheraLang.Web.Controllers
{
    [Route("api/news")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;
        private readonly IAuthenticateService _authenticateService;

        public NewsController(INewsService newsService, IAuthenticateService authenticateService)
        {
            _newsService = newsService;
            _authenticateService = authenticateService;
        }

        // GET: api/news
        [AllowAnonymous]
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsPreviewDto, NewsPreviewViewModel>())
                .CreateMapper();

            var newsDtos = await _newsService.GetAllNews();

            if (!newsDtos.Any())
            {
                return NotFound();
            }

            var newsModels = mapper.Map<List<NewsPreviewViewModel>>(newsDtos);
            return Ok(newsModels);
        }

        // GET: api/news?pageNumber=2&pageSize=10
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] PagingParametersViewModel pageParametersModel)
        {
            var mapper = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<NewsDetailsDto, NewsPreviewViewModel>();
                    cfg.CreateMap<PagingParametersViewModel, PagingParametersDto>();
                }
            ).CreateMapper();

            var pageParametersDto = mapper.Map<PagingParametersDto>(pageParametersModel);
            var newsDtos = await _newsService.GetNewsPage(pageParametersDto);

            if (!newsDtos.Any())
            {
                return NotFound();
            }

            var newsModels = mapper.Map<List<NewsPreviewViewModel>>(newsDtos);
            return Ok(newsModels);
        }

        [AllowAnonymous]
        [HttpGet("count")]
        public async Task<IActionResult> GetNewsCount()
        {
            var pageCount = await _newsService.GetNewsCount();
            return Ok(pageCount);
        }

        // GET: api/news/5
        [AllowAnonymous]
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> GetById(int id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsDetailsDto, NewsDetailsViewModel>())
                .CreateMapper();

            var newsDto = await _newsService.GetNewsById(id);
            if (newsDto == null)
            {
                return NotFound();
            }

            var newsModel = mapper.Map<NewsDetailsViewModel>(newsDto);

            return Ok(newsModel);
        }

        // POST: api/news
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] NewsCreateViewModel newsModel)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsCreateViewModel, NewsCreateDto>())
                .CreateMapper();

            var newsDto = mapper.Map<NewsCreateDto>(newsModel);
            var authUser = await _authenticateService.GetAuthUserAsync();
            newsDto.AuthorId = authUser.Id;

            await _newsService.AddNews(newsDto);
            return Ok();
        }

        // PUT: api/news/5
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromForm] NewsEditViewModel newsModel)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsEditViewModel, NewsEditDto>()).CreateMapper();

            var newsDto = mapper.Map<NewsEditDto>(newsModel);
            var authUser = await _authenticateService.GetAuthUserAsync();
            newsDto.EditorId = authUser.Id;

            try
            {
                await _newsService.UpdateNews(id, newsDto);
            }
            catch (ArgumentNullException)
            {
                return NotFound();
            }

            return Ok();
        }

        [Authorize]
        [HttpPut("like/{id}")]
        public async Task<IActionResult> Like(int id)
        {
            var authUser = await _authenticateService.GetAuthUserAsync();

            await _newsService.Like(id, authUser.Id);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            try
            {
                await _newsService.RemoveNews(id);
            }
            catch (ArgumentNullException)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}