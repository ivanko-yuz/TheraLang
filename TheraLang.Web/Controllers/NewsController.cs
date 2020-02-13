﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects.NewsDtos;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.Extensions;
using TheraLang.Web.ViewModels.NewsViewModels;

namespace TheraLang.Web.Controllers
{
    [Route("api/news")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;
        private readonly IUserManagementService _userManagementService;

        public NewsController(INewsService newsService, IUserManagementService userManagementService)
        {
            _newsService = newsService;
            _userManagementService = userManagementService;
        }

        // GET: api/news
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsPreviewDto, NewsPreviewViewModel>()).CreateMapper();

            var newsDtos = await _newsService.GetAllNews();
            if (!newsDtos.Any())
            {
                return NotFound();
            }

            var newsModels = mapper.Map<List<NewsPreviewViewModel>>(newsDtos);
            return Ok(newsModels);
        }

        // GET: api/news/5
        [AllowAnonymous]
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> GetById(int id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsDetailsDto, NewsDetailsViewModel>()).CreateMapper();

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
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsCreateViewModel, NewsCreateDto>()).CreateMapper();

            var newsDto = mapper.Map<NewsCreateDto>(newsModel);
            var userId = User.Claims.GetUserId();
            newsDto.Author = await _userManagementService.GetUserById(userId.Value);

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
            var userId = User.Claims.GetUserId();
            var user = await _userManagementService.GetUserById(userId.Value);
           
            await _newsService.Like(id, user);
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