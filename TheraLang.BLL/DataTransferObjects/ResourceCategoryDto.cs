using System.Collections.Generic;

namespace TheraLang.BLL.DataTransferObjects
{
    public class ResourceCategoryDto
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public IEnumerable<ResourceDto> Resources { get; set; }
    }
}
