﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects.CommentDtos;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels.CommentViewModels;

namespace TheraLang.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly INewsCommentService _newsCommentService;
        private readonly IAuthenticateService _authenticateService;

        public CommentController(INewsCommentService newsCommentService, IAuthenticateService authenticateService)
        {
            _newsCommentService = newsCommentService;
            _authenticateService = authenticateService;
        }

        // GET: api/Comment/newsId
        [HttpGet("{newsId}")]
        public async Task<IActionResult> GetCommentsForNews(int newsId)
        {
            var commentDtos = await _newsCommentService.GetCommentsForNews(newsId);
            if (!commentDtos.Any())
            {
                return NotFound();
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CommentResponseDto, CommentResponseViewModel>())
                .CreateMapper();

            var commentModels = mapper.Map<IEnumerable<CommentResponseViewModel>>(commentDtos);

            return Ok(commentModels);
        }

        // POST: api/Comment
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] CommentRequestViewModel commentModel)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CommentRequestViewModel, CommentRequestDto>())
                .CreateMapper();

            var commentDto = mapper.Map<CommentRequestDto>(commentModel);
            var authUser = await _authenticateService.GetAuthUserAsync();
            commentDto.AuthorId = authUser.Id;

            await _newsCommentService.AddComment(commentDto);
            return Ok();
        }

        // PUT: api/Comment/5
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromForm] CommentRequestViewModel commentModel)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CommentRequestViewModel, CommentRequestDto>())
                .CreateMapper();

            var commentDto = mapper.Map<CommentRequestDto>(commentModel);
            var authUser = await _authenticateService.GetAuthUserAsync();
            commentDto.AuthorId = authUser.Id;

            try
            {
                await _newsCommentService.UpdateComment(id, commentDto);
            }
            catch (ArgumentNullException)
            {
                return NotFound();
            }

            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            try
            {
                await _newsCommentService.RemoveComment(id);
            }
            catch (ArgumentNullException)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}