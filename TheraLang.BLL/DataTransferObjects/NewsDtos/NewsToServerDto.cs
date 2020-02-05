using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.DataTransferObjects.NewsDtos
{
    public class NewsToServerDto
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public virtual ICollection<IFormFile> NewImages { get; set; }
        public virtual ICollection<string> UploadedImageUrls { get; set; }
    }
}
