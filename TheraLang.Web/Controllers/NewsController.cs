using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
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
        private readonly IValidator<NewsToServerViewModel> _validator;

        public NewsController(INewsService newsService, IValidator<NewsToServerViewModel> validator)
        {
            _newsService = newsService;
            _validator = validator;
        }

        // GET: api/news
        [HttpGet]
        public IActionResult GetAll()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsFromServerDto, NewsFromServerViewModel>()).CreateMapper();

            var newsDtos = _newsService.GetAllNews();
            var newsModels = mapper.Map<List<NewsFromServerViewModel>>(newsDtos);

            return Ok(newsModels);
        }

        // GET: api/news/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetById(int id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsFromServerDto, NewsFromServerViewModel>()).CreateMapper();

            var newsDto = _newsService.GetNewsById(id);
            var newsModel = mapper.Map<NewsFromServerViewModel>(newsDto);

            return Ok(newsModel);
        }

        // POST: api/news
        [HttpPost]
        public IActionResult Post([FromBody] NewsToServerViewModel newsModel)
        {
            var validationResult = _validator.Validate(newsModel);

            if (!validationResult.IsValid)
            {
                throw new ArgumentException($"{nameof(newsModel)} is not valid");
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsToServerViewModel, NewsToServerDto>()).CreateMapper();

            var newsDto = mapper.Map<NewsToServerDto>(newsModel);
            
            _newsService.AddNews(newsDto);
            return Ok();
        }

        // PUT: api/news/5
        [HttpPut("{id}")]
        public IActionResult Edit(int id, [FromBody] NewsToServerViewModel newsModel)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsToServerViewModel, NewsToServerDto>()).CreateMapper();

            var newsDto = mapper.Map<NewsToServerDto>(newsModel);

            _newsService.UpdateNews(id, newsDto);
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
