using System.Collections.Generic;
using Common.Enums;
using TheraLang.BLL.CustomTypes;

namespace TheraLang.BLL.DataTransferObjects
{
    public class PageDto
    {
        public int Id { get; set; }
        public HtmlContent Content { get; set; }
        public string Header { get; set; }
        public string MenuTitle { get; set; }
        public int? ParentPageId { get; set; }
        public string Route { get; set; }
        public Language Language { get; set; }
        public virtual PageDto ParentPage { get; set; }
        public virtual ICollection<PageDto> SubPages { get; set; }
    }
}