using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Services.File
{
    public class LocalFileService : IFileService
    {
        private readonly IHostingEnvironment _env;

        public LocalFileService(IHostingEnvironment env)
        {
            _env = env;
        }

        public async Task<Uri> SaveFile(IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);
            var uniqueName = Guid.NewGuid().ToString();
            var filename = $"{uniqueName}{extension}";
            var folder = Path.Combine(_env.WebRootPath, "fileuploads");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            using (var fileStream = new FileStream(Path.Combine(folder, filename), FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return new Uri($"/fileuploads/{filename}", UriKind.Relative);
        }
    }
}