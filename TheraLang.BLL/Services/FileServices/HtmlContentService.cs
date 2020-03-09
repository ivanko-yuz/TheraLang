using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TheraLang.BLL.CustomTypes;
using TheraLang.BLL.Interfaces;

namespace TheraLang.BLL.Services.FileServices
{
    public class HtmlContentService : IHtmlContentService
    {
        private readonly IFileService _fileService;

        public HtmlContentService(IFileService fileService)
        {
            _fileService = fileService;
        }

        public async Task<HtmlContent> SavePictures(HtmlContent htmlContent)
        {
            var regex = new Regex("data:image/(?<exteniton>\\w*);base64.(?<data>\\S*)\"/>",
                RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline);
            var matches = regex.Matches(htmlContent.ToString());
            var html = htmlContent.ToString();

            foreach (var item in matches)
            {
                var match = regex.Match(item.ToString());
                var extension = $".{match.Groups["extension"].Value}";
                var base64Data = match.Groups["data"].Value;
                var rawData = Convert.FromBase64String(base64Data);

                var ms = new MemoryStream(rawData);
                var uri = await _fileService.SaveFile(ms, extension);

                html = html.Replace(match.Value, $"{uri}\"/>");
            }

            return new HtmlContent(html);
        }
    }
}