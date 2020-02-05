using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects;
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
        private readonly IValidator<NewsToServerViewModel> _validator;

        public NewsController(INewsService newsService, IValidator<NewsToServerViewModel> validator)
        {
            _newsService = newsService;
            _validator = validator;
        }

        // GET: api/news
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsDetailsDto, NewsPreviewViewModel>()).CreateMapper();

            var newsDtos = await _newsService.GetAllNews();

            if(!newsDtos.Any())
            {
                return NotFound();
            }

            var newsModels = mapper.Map<List<NewsPreviewViewModel>>(newsDtos);
            return Ok(newsModels);
        }

        // GET: api/news/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> GetById(int id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsDetailsDto, NewsDetailsViewModel>()).CreateMapper();

            var newsDto = await _newsService.GetNewsById(id);
            if(newsDto == null)
            {
                return NotFound();
            }

            var newsModel = mapper.Map<NewsDetailsViewModel>(newsDto);

            return Ok(newsModel);
        }

        // POST: api/news
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] NewsToServerViewModel newsModel)
        {
            var validationResult = _validator.Validate(newsModel);

            if (!validationResult.IsValid)
            {
                throw new ArgumentException($"{nameof(newsModel)} is not valid");
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsToServerViewModel, NewsToServerDto>()).CreateMapper();

            var newsDto = mapper.Map<NewsToServerDto>(newsModel);
            
            await _newsService.AddNews(newsDto);
            return Ok();
        }

        // PUT: api/news/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromForm] NewsToServerViewModel newsModel)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsToServerViewModel, NewsToServerDto>()).CreateMapper();

            var validationResult = _validator.Validate(newsModel);

            if (!validationResult.IsValid)
            {
                throw new ArgumentException($"{nameof(newsModel)} is not valid");
            }

            var newsDto = mapper.Map<NewsToServerDto>(newsModel);

            try
            {
                await _newsService.UpdateNews(id, newsDto);
            }
            catch(ArgumentException)
            {
                return NotFound();
            }

            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            try
            {
                await _newsService.RemoveNews(id);
            }
            catch (ArgumentException)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
