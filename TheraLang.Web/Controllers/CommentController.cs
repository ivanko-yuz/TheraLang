using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Common;
using Microsoft.AspNetCore.Authorization;
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

        public CommentController(INewsCommentService newsCommentService)
        {
            _newsCommentService = newsCommentService;
        }

        [AllowAnonymous]
        [HttpGet("count/{newsId}")]
        public async Task<IActionResult> GetCommentsForNewsCount(int newsId)
        {
            var pageCount = await _newsCommentService.GetCommentsForNewsCount(newsId);
            return Ok(pageCount);
        }

        // GET: api/Comment/newsId
        [AllowAnonymous]
        [HttpGet("all/{newsId}")]
        public async Task<IActionResult> GetCommentsForNews(int newsId)
        {
            var commentDtos = await _newsCommentService.GetCommentsForNews(newsId);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CommentResponseDto, CommentResponseViewModel>())
                .CreateMapper();

            var commentModels = mapper.Map<IEnumerable<CommentResponseViewModel>>(commentDtos);

            return Ok(commentModels);
        }

        // GET: api/comment/newsId?pageNumber=2&pageSize=10
        [AllowAnonymous]
        [HttpGet("{newsId}")]
        public async Task<IActionResult> GetCommentsForNewsPage(int newsId, [FromQuery] PaginationParams paginationParams)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CommentRequestViewModel, CommentRequestDto>())
                .CreateMapper();

            var commentDtos = await _newsCommentService.GetCommentsForNewsPage(newsId, paginationParams);

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

            await _newsCommentService.UpdateComment(id, commentDto);

            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await _newsCommentService.RemoveComment(id);

            return Ok();
        }
    }
}
