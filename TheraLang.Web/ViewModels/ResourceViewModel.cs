using Microsoft.AspNetCore.Http;
using System;

namespace TheraLang.Web.ViewModels
{
    public class ResourceViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public string FileName { get; set; }

        public IFormFile File { get; set; }

        public int CategoryId { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public ResourceCategoryViewModel ResourceCategory { get; set; }
    }
}
