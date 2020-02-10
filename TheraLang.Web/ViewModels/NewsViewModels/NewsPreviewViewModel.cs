using System;

namespace TheraLang.Web.ViewModels.NewsViewModels
{
    public class NewsPreviewViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string MainImageUrl { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreatedDateUtc { get; set; }
    }
}
