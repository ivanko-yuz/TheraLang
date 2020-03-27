using AutoMapper;
using AutoMapper.QueryableExtensions;
using Common;
using Common.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return await _unitOfWork.Repository<NewsComment>().GetAll().Where(c => c.NewsId == newsId).CountAsync();
        }

        public async Task<IEnumerable<CommentResponseDto>> GetCommentsForNews(int newsId)
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<NewsComment, CommentResponseDto>()
                    .ForMember(m => m.AuthorName,
                        opt => opt.MapFrom(sm => $"{sm.Author.Details.FirstName} {sm.Author.Details.LastName}"))
                    .ForMember(m => m.AuthorImageUrl, opt => opt.MapFrom(sm => sm.Author.Details.ImageURl))
                    .ForMember(m => m.isEdited, opt => opt.MapFrom(sm => sm.UpdatedDateUtc != null));
            });

            var commentDtos = await _unitOfWork.Repository<NewsComment>().GetAll()
                .Where(c => c.NewsId == newsId)
                .OrderByDescending(c => c.CreatedDateUtc)
                .ProjectTo<CommentResponseDto>(mapper)
                .ToListAsync();

            if (!commentDtos.Any())
            {
                throw new NotFoundException($"Comments for news with id {newsId}");
            }

            return commentDtos;
        }

        public async Task<IEnumerable<CommentResponseDto>> GetCommentsForNewsPage(int newsId,
                PaginationParams paginationParams)
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<NewsComment, CommentResponseDto>()
                    .ForMember(m => m.AuthorName,
                        opt => opt.MapFrom(sm => $"{sm.Author.Details.FirstName} {sm.Author.Details.LastName}"))
                    .ForMember(m => m.AuthorImageUrl, opt => opt.MapFrom(sm => sm.Author.Details.ImageURl))
                    .ForMember(m => m.isEdited, opt => opt.MapFrom(sm => sm.UpdatedDateUtc != null));
            });

            var commentDtos = await _unitOfWork.Repository<NewsComment>().GetAll()
                .Where(c => c.NewsId == newsId)
                .OrderByDescending(c => c.CreatedDateUtc)
                .Skip(paginationParams.Skip)
                .Take(paginationParams.Take)
                .ProjectTo<CommentResponseDto>(mapper)
                .ToListAsync();

            if (!commentDtos.Any())
            {
                throw new NotFoundException($"Comments for news with id {newsId} page {paginationParams.PageNumber}");
            }

            return commentDtos;
        }

        public async Task AddComment(CommentRequestDto commentDto)
        {
            var authUser = await _authenticateService.GetAuthUser();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CommentRequestDto, NewsComment>()
                    .ForMember(m => m.CreatedById, opt => opt.MapFrom(sm => authUser.Id)))
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
                throw new NotFoundException($"Comment with id {id}");
            }

            //Check permissions (only owner and admin)
            var authUser = await _authenticateService.GetAuthUser();
            if (authUser.Id != comment.CreatedById || !authUser.Role.Equals("Admin"))
            {
                throw new NoPermissionsException("Only comment owner and admin can remove comment");
            }

            _unitOfWork.Repository<NewsComment>().Remove(comment);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateComment(int id, CommentRequestDto commentDto)
        {
            var commentToUpdate = await _unitOfWork.Repository<NewsComment>().Get(i => i.Id == id);
            if (commentToUpdate == null)
            {
                throw new NotFoundException($"Comment with id {id}");
            }

            //Check permissions (only owner)
            var authUser = await _authenticateService.GetAuthUser();
            if(authUser.Id != commentToUpdate.CreatedById)
            {
                throw new NoPermissionsException("Only comment owner can edit comment");
            }

            commentToUpdate.Text = commentDto.Text;

            _unitOfWork.Repository<NewsComment>().Update(commentToUpdate);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
