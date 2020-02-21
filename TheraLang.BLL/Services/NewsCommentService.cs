using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.DataTransferObjects.CommentDtos;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class NewsCommentService : INewsCommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthenticateService _authenticateService;

        public NewsCommentService(IUnitOfWork unitOfWork, IAuthenticateService authenticateService)
        {
            _unitOfWork = unitOfWork;
            _authenticateService = authenticateService;
        }

        public async Task<int> GetCommentsForNewsCount(int newsId)
        {
            return await _unitOfWork.Repository<NewsComment>().GetAll().CountAsync();
        }

        public async Task<IEnumerable<CommentResponseDto>> GetCommentsForNews(int newsId)
        {
            var comments = await _unitOfWork.Repository<NewsComment>().GetAll()
                .Where(c => c.NewsId == newsId)
                .Include(e => e.Author)
                .ThenInclude(e => e.Details)
                .ToListAsync();

            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<NewsComment, CommentResponseDto>()
                    .ForMember(m => m.AuthorName,
                        opt => opt.MapFrom(sm => $"{sm.Author.Details.FirstName} {sm.Author.Details.LastName}"))
                    .ForMember(m => m.AuthorImageUrl, opt => opt.MapFrom(sm => sm.Author.Details.ImageURl))
                    .ForMember(m => m.isEdited, opt => opt.MapFrom(sm => sm.UpdatedDateUtc != null));
            }).CreateMapper();

            var commentDtos = mapper.Map<IEnumerable<NewsComment>, IEnumerable<CommentResponseDto>>(comments);

            return commentDtos;
        }

        public async Task<IEnumerable<CommentResponseDto>> GetCommentsForNewsPage(int newsId, PagingParametersDto pageParameters)
        {
            var comments = await _unitOfWork.Repository<NewsComment>().GetAll()
                .Where(c => c.NewsId == newsId)
                .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                .Take(pageParameters.PageSize)
                .Include(e => e.Author)
                .ThenInclude(e => e.Details)
                .ToListAsync();

            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<NewsComment, CommentResponseDto>()
                    .ForMember(m => m.AuthorName,
                        opt => opt.MapFrom(sm => $"{sm.Author.Details.FirstName} {sm.Author.Details.LastName}"))
                    .ForMember(m => m.AuthorImageUrl, opt => opt.MapFrom(sm => sm.Author.Details.ImageURl))
                    .ForMember(m => m.isEdited, opt => opt.MapFrom(sm => sm.UpdatedDateUtc != null));
            }).CreateMapper();

            var commentDtos = mapper.Map<IEnumerable<NewsComment>, IEnumerable<CommentResponseDto>>(comments);

            return commentDtos;
        }

        public async Task AddComment(CommentRequestDto commentDto)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CommentRequestDto, NewsComment>()
                    .ForMember(m => m.CreatedById, opt => opt.MapFrom(sm => sm.AuthorId))
                    .ForMember(m => m.NewsId, opt => opt.MapFrom(sm => sm.PostId)))
                .CreateMapper();

            var comment = mapper.Map<CommentRequestDto, NewsComment>(commentDto);

            _unitOfWork.Repository<NewsComment>().Add(comment);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveComment(int id)
        {
            var comment = await _unitOfWork.Repository<NewsComment>().Get(i => i.Id == id);
            if (comment == null)
            {
                throw new ArgumentNullException($"Comment with id {id} not found!");
            }

            var authUser = await _authenticateService.GetAuthUserAsync();
            if(authUser.Id != comment.CreatedById || !authUser.Role.ToLower().Equals("admin"))
            {
                //TODO: Throw exception
            }

            _unitOfWork.Repository<NewsComment>().Remove(comment);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateComment(int id, CommentRequestDto commentDto)
        {
            var commentToUpdate = await _unitOfWork.Repository<NewsComment>().Get(i => i.Id == id);
            if (commentToUpdate == null)
            {
                throw new ArgumentNullException($"Comment with id {id} not found!");
            }

            var authUser = await _authenticateService.GetAuthUserAsync();
            if (authUser.Id != commentToUpdate.CreatedById || !authUser.Role.ToLower().Equals("admin"))
            {
                //TODO: Throw exception
            }

            commentToUpdate.Text = commentDto.Text;

            _unitOfWork.Repository<NewsComment>().Update(commentToUpdate);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
