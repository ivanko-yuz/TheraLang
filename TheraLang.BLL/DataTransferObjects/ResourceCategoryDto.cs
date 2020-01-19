using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.DataTransferObjects
{
    public class ResourceCategoryDto
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }
        public ResourceCategoryDto()
        {
            this.Resources = new List<Resource>();
        }
    }
}
