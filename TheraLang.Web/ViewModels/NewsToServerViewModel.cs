using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheraLang.Web.ViewModels
{
    public class NewsToServerViewModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public ICollection<IFormFile> NewImages { get; set; }
        public ICollection<string> UploadedImageUrls { get; set; }
    }
}
