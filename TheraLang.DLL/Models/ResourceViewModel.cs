using Microsoft.AspNetCore.Http;

namespace TheraLang.DLL.Models
{
    public class ResourceViewModel
    {
        public int? id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public string url { get; set; }

        public string fileName { get; set; }

        public IFormFile file { get; set; }

        public int categoryId { get; set; }
    }
}
