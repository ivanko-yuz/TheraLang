using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects.NewsDtos;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels.NewsViewModels;

namespace TheraLang.Web.Controllers
{
    [Route("api/news")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        // GET: api/news
        [AllowAnonymous]
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsPreviewDto, NewsPreviewViewModel>())
                .CreateMapper();

            var newsDtos = await _newsService.GetAllNews();

            var newsModels = mapper.Map<List<NewsPreviewViewModel>>(newsDtos);
            return Ok(newsModels);
        }

        // GET: api/news?pageNumber=2&pageSize=10
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] PaginationParams paginationParams)
        {
            var mapper = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<NewsDetailsDto, NewsPreviewViewModel>();
                }
            ).CreateMapper();

            var newsDtos = await _newsService.GetNewsPage(paginationParams);

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

            await _newsService.UpdateNews(id, newsDto);

            return Ok();
        }

        [Authorize]
        [HttpPut("like/{id}")]
        public async Task<IActionResult> Like(int id)
        {
            await _newsService.Like(id);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await _newsService.RemoveNews(id);

            return Ok();
        }
    }
}