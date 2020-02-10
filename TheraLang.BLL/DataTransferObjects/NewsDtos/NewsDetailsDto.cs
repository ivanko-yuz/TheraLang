using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.DataTransferObjects.NewsDtos
{
    public class NewsDetailsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string MainImageUrl { get; set; }
        public ICollection<string> ContentImageUrls { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreatedDateUtc { get; set; }
    }
}
