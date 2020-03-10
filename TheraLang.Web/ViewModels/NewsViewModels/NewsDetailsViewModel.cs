using System;
using System.Collections.Generic;

namespace TheraLang.Web.ViewModels.NewsViewModels
{
    public class NewsDetailsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string MainImageUrl { get; set; }
        public ICollection<string> ContentImageUrls { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public int LikesCount { get; set; }
        public bool IsLikedByCurrentUser { get; set; }
    }
}