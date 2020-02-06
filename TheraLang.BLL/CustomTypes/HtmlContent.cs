using System.Text.RegularExpressions;
namespace TheraLang.BLL.CustomTypes
{
    public class HtmlContent
    {
        private readonly string _content;
        
        public HtmlContent(string content)
        {
            _content = content;
        }

        public HtmlContent TrimScript()
        {
            var regex = new Regex(@"<[^>]*script[^>]*>(.*?)<[^>]*/[^>]*script[^>]*>");
            string clearContent = regex.Replace(_content, "");
            return new HtmlContent(clearContent);
        }

        public override string ToString()
        {
            return _content;
        }
    }
}
