using System;

namespace TheraLang.BLL.DataTransferObjects.CommentDtos
{
    public class CommentRequestDto
    {
        public string Text { get; set; }
        public Guid AuthorId { get; set; }
        public int PostId { get; set; }
    }
}
