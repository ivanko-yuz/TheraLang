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

        public NewsCommentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> GetCommentsForNewsCount(int newsId)
        {
            return await _unitOfWork.Repository<NewsComment>().GetAll().CountAsync();
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
                .Skip((paginationParams.PageNumber - 1) * paginationParams.PageSize)
                .Take(paginationParams.PageSize)
                .ProjectTo<CommentResponseDto>(mapper)
                .ToListAsync();
            if (!commentDtos.Any())
            {
                throw new NotFoundException($"Comments for news with id {newsId} page {paginationParams.PageNumber}");
            }

            return commentDtos;
        }

        public async Task AddComment(CommentCreateDto commentDto)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CommentCreateDto, NewsComment>()
                    .ForMember(m => m.CreatedById, opt => opt.MapFrom(sm => sm.AuthorId))
                    .ForMember(m => m.NewsId, opt => opt.MapFrom(sm => sm.PostId)))
                .CreateMapper();

            var comment = mapper.Map<CommentCreateDto, NewsComment>(commentDto);

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

            //TODO: Check permissions (only owner and admin)
            _unitOfWork.Repository<NewsComment>().Remove(comment);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateComment(int id, CommentEditDto commentDto)
        {
            var commentToUpdate = await _unitOfWork.Repository<NewsComment>().Get(i => i.Id == id);
            if (commentToUpdate == null)
            {
                throw new NotFoundException($"Comment with id {id}");
            }

            //TODO: Check permissions (only owner)
            commentToUpdate.Text = commentDto.Text;

            _unitOfWork.Repository<NewsComment>().Update(commentToUpdate);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
