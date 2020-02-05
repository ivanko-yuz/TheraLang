using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TheraLang.BLL.Interfaces;

namespace TheraLang.BLL.Services.File
{
    public class PictureService : IPictureService
    {
        private readonly IHostingEnvironment _env;

        public PictureService(IHostingEnvironment env)
        {
            _env = env;
        }
        public void SavePictures(string htmlContent)
        {
            var regex = new Regex("data:image/(?<format>\\w*);base64.(?<data>\\S*)\"/>", RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline);
            var matches = regex.Matches(htmlContent);


            foreach (var item in matches)
            {
                var match = regex.Match(item.ToString());

                var format = match.Groups["format"].Value;
                string base64Data = match.Groups["data"].Value;
             
                byte[] rawData = Convert.FromBase64String(base64Data);
                string pictureName = DateTime.Now + "." + format;
                
                var folder = Path.Combine(_env.WebRootPath, "fileuploads");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                    using (var fileStream = new FileStream(Path.Combine(folder, pictureName), FileMode.Create))
                    {
                        fileStream.Write(rawData, 0, rawData.Length);
                        fileStream.Flush();
                    }
                
                htmlContent.Replace(item.ToString(), $"~/fileuploads/{pictureName}");
                
            }
            
        }
    }
}
