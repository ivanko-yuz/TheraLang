using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects.CommentDtos;

namespace TheraLang.BLL.Interfaces
{
    public interface INewsCommentService
    {
        Task<IEnumerable<CommentResponseDto>> GetCommentsForNews(int newsId);
        Task AddComment(CommentRequestDto commentDto);
        Task UpdateComment(int id, CommentRequestDto commentDto);
        Task RemoveComment(int id);
    }
}
