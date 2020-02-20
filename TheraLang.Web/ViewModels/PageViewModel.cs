namespace TheraLang.Web.ViewModels
{
    public class PageViewModel
    {
        public int? Id { get; set; }
        public string Content { get; set; }
        public string Header { get; set; }
        public string MenuTitle { get; set; }
        public string Route { get; set; }
        public LanguageViewModel Language { get; set; }
    }
}