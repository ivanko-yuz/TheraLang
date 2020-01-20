using System.Collections.Generic;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.DataTransferObjects
{
    public class ResourceCategoryDto
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public ICollection<Resource> Resources { get; set; }
    }
}
