using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace TheraLang.Web.ViewModels.NewsViewModels
{
    public class NewsCreateViewModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public IFormFile MainImage { get; set; }
        public ICollection<IFormFile> ContentImages { get; set; }
    }
}
