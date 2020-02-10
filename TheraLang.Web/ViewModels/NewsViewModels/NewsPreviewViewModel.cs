using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;

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
