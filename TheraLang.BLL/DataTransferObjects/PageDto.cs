using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.BLL.DataTransferObjects
{
    public class PageDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public string MenuName { get; set; }
        public int? ParentPageId { get; set; }

        public virtual PageDto ParentPage { get; set; }
        public virtual ICollection<PageDto> SubPages { get; set; }
    }
}
