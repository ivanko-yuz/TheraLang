using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;

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
        [HttpGet]
        public IActionResult GetAll()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsDto, NewsViewModel>()).CreateMapper();

            var newsDtos = _newsService.GetAllNews();
            var newsModels = mapper.Map<List<NewsViewModel>>(newsDtos);

            return Ok(newsModels);
        }

        // GET: api/news/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetById(int id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsDto, NewsViewModel>()).CreateMapper();

            var newsDto = _newsService.GetNewsById(id);
            var newsModel = mapper.Map<NewsViewModel>(newsDto);

            return Ok(newsModel);
        }

        // POST: api/news
        [HttpPost]
        public IActionResult Post([FromBody] NewsViewModel newsModel)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsViewModel, NewsDto>()).CreateMapper();

            var newsDto = mapper.Map<NewsDto>(newsModel);
            
            _newsService.AddNews(newsDto);
            return Ok();
        }

        // PUT: api/news/5
        [HttpPut("{id}")]
        public IActionResult Edit(int id, [FromBody] NewsViewModel newsModel)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsViewModel, NewsDto>()).CreateMapper();

            var newsDto = mapper.Map<NewsDto>(newsModel);

            _newsService.AddNews(newsDto);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            _newsService.RemoveNews(id);
            return Ok();
        }
    }
}
