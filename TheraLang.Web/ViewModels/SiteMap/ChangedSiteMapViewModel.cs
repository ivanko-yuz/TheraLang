using Newtonsoft.Json;

namespace TheraLang.Web.ViewModels.SiteMap
{
    public class ChangedSiteMapViewModel
    {
        public int Id { get; set; }
        
        [JsonProperty("prevParentId")]
        public int? PreviousParentId { get; set; }

        [JsonProperty("newParentId")]
        public int? NewParentId { get; set; }
        
        public int? NewIndex { get; set; }
    }
}