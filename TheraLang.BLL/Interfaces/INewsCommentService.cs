using Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects.CommentDtos;

namespace TheraLang.BLL.Interfaces
{
    public interface INewsCommentService
    {
        Task<IEnumerable<CommentResponseDto>> GetCommentsForNews(int newsId);
        Task<IEnumerable<CommentResponseDto>> GetCommentsForNewsPage(int newsId, PaginationParams pagingParameters);
        Task<int> GetCommentsForNewsCount(int newsId);
        Task AddComment(CommentRequestDto commentDto);
        Task UpdateComment(int id, CommentRequestDto commentDto);
        Task RemoveComment(int id);
    }
}
