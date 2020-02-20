using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace TheraLang.BLL.DataTransferObjects.NewsDtos
{
    public class NewsCreateDto
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public IFormFile MainImage { get; set; }
        public ICollection<IFormFile> ContentImages { get; set; }
        public Guid AuthorId { get; set; }
    }
}