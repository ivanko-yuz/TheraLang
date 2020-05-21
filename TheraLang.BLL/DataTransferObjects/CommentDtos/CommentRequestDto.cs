using System;

namespace TheraLang.BLL.DataTransferObjects.CommentDtos
{
    public class CommentRequestDto
    {
        public string Text { get; set; }
        public int NewsId { get; set; }
        public int? AnsweredCommentId { get; set; }
    }
}
