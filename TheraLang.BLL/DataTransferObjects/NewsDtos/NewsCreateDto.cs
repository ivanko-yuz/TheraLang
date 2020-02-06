using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.BLL.DataTransferObjects.NewsDtos
{
    public class NewsCreateDto
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public virtual ICollection<IFormFile> NewImages { get; set; }
    }
}
