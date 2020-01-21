using Microsoft.AspNetCore.Http;

namespace TheraLang.BLL.DataTransferObjects
{
    public class ResourceAttachDto
    {
        public int ResourceId { get; set; }

        public string FileName { get; set; }

        public string Path { get; set; }

        public IFormFile File { get; set; }
    }
}
