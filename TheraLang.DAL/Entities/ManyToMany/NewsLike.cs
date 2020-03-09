using System;

namespace TheraLang.DAL.Entities.ManyToMany
{
    public class NewsLike
    {
        public int NewsId { get; set; }
        public News News { get; set; }
        public Guid UserThatLikedId { get; set; }
        public User UserThatLiked { get; set; }
    }
}
