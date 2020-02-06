using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;

namespace TheraLang.Web.ViewModels.NewsViewModels
{
    public class NewsToServerViewModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public ICollection<IFormFile> NewImages { get; set; }
        public ICollection<UploadedNewsImage> UploadedImages { get; set; }
    }
}
