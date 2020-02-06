using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TheraLang.BLL.CustomTypes;
using TheraLang.BLL.Interfaces;

namespace TheraLang.BLL.Services.File
{
    public class HtmlContentService : IHtmlContentService
    {
        public HtmlContent SavePictures(HtmlContent htmlContent)
        {
            var regex = new Regex("data:image/(?<exteniton>\\w*);base64.(?<data>\\S*)\"/>", RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline);
            var matches = regex.Matches(htmlContent.ToString());
            string html = htmlContent.ToString();

            foreach (var item in matches)
            {
                var match = regex.Match(item.ToString());
                var exteniton = "." + match.Groups["exteniton"].Value;
                var base64Data = match.Groups["data"].Value;
                byte[] rawData = Convert.FromBase64String(base64Data);
                
                var ms = new MemoryStream(rawData);

               /// html.Replace(match, urI);    
            }

            return new HtmlContent(html);

        }
    }
}
