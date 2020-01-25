using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace TheraLang.Web.ViewModels
{
    public class ResourceViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public string FileName { get; set; }
        
        public IFormFile File { get; set; }

        public int CategoryId { get; set; }
    }
}
