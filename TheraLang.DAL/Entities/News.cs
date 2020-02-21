using System.Collections.Generic;
using TheraLang.DAL.Entities.ManyToMany;

namespace TheraLang.DAL.Entities
{
    public class News : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string MainImageUrl { get; set; }
        public virtual User Author { get; set; }
        public virtual ICollection<UploadedNewsContentImage> UploadedContentImages { get; set; }
        public virtual ICollection<NewsLike> Likes { get; set; }
        public virtual ICollection<NewsComment> Comments { get; set; }
    }
}