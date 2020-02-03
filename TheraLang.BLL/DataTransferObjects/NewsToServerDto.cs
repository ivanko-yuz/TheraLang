using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.BLL.DataTransferObjects
{
    public class NewsToServerDto
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public ICollection<IFormFile> NewImages { get; set; }
        public ICollection<string> UploadedImageUrls { get; set; }
    }
}
