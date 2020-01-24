using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace TheraLang.Web.ViewModels
{
    public class ResourceViewModel
    {
        [JsonProperty("id")]
        public int? Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public IFormFile File { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }
    }
}
