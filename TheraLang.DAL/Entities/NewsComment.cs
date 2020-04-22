using System.Collections.Generic;

namespace TheraLang.DAL.Entities
{
    public class NewsComment : BaseEntity
    {
        public string Text { get; set; }
        public virtual User Author { get; set; }
        public int NewsId { get; set; }
        public virtual News News { get; set; }
        public int? AnsweredCommentId { get; set; }
        public virtual NewsComment AnsweredComment { get; set; }
        public virtual ICollection<NewsComment> Replies { get; set; }
    }
}
