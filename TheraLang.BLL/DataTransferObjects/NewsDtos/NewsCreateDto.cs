using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.DataTransferObjects.NewsDtos
{
    public class NewsCreateDto
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public IFormFile MainImage { get; set; }
        public ICollection<IFormFile> ContentImages { get; set; }
        public User Author { get; set; } 
    }
}
