using System;
using System.Collections.Generic;

namespace TheraLang.BLL.DataTransferObjects.CommentDtos
{
    public class CommentResponseDto
    {
        public int Id { get; set; }
        public Guid CreatedById { get; set; }
        public string Text { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public bool isEdited { get; set; }
        public int? AnsweredCommentId { get; set; }
        public ICollection<CommentResponseDto> Replies { get; set; }
    }
}
