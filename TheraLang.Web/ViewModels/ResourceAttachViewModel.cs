using Microsoft.AspNetCore.Http;

namespace TheraLang.Web.ViewModels
{
    public class ResourceAttachViewModel
    {
        public int ResourceId { get; set; }

        public string FileName { get; set; }

        public string Path { get; set; }

        public IFormFile File { get; set; }
    }
}