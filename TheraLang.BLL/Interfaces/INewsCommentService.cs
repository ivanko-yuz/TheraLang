using Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.DataTransferObjects.CommentDtos;

namespace TheraLang.BLL.Interfaces
{
    public interface INewsCommentService
    {
        Task<IEnumerable<CommentResponseDto>> GetCommentsForNews(int newsId);
        Task<IEnumerable<CommentResponseDto>> GetCommentsForNewsPage(int newsId, PaginationParams pagingParameters);
        Task<int> GetCommentsForNewsCount(int newsId);
        Task AddComment(CommentCreateDto commentDto);
        Task UpdateComment(int id, CommentEditDto commentDto);
        Task RemoveComment(int id);
    }
}
