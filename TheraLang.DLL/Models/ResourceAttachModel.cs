using Microsoft.AspNetCore.Http;

namespace TheraLang.DLL.Models
{
    public class ResourceAttachModel
    {
        public int ResourceId { get; set; }

        public string FileName { get; set; }

        public string Path { get; set; }

        public IFormFile File { get; set;}

       
    }
}
