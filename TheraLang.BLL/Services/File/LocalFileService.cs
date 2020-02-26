using System;
using System.IO;
using System.Threading.Tasks;
using Common.Exceptions;
using Microsoft.AspNetCore.Hosting;
using TheraLang.BLL.Interfaces;

namespace TheraLang.BLL.Services.File
{
    public class LocalFileService : IFileService
    {
        private readonly IHostingEnvironment _env;

        public LocalFileService(IHostingEnvironment env)
        {
            _env = env;
        }

        /// <summary>
        /// Saves file to a WebRootPath/fileuploads folder
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="fileExtension"></param>
        /// <returns></returns>
        public async Task<Uri> SaveFile(Stream stream, string fileExtension)
        {
            var uniqueName = Guid.NewGuid().ToString();
            var filename = $"{uniqueName}{fileExtension}";
            var folder = GetDirectory();
            

            using (var fileStream = new FileStream(Path.Combine(folder, filename), FileMode.Create))
            {
                await stream.CopyToAsync(fileStream);
            }

            return new Uri($"/fileuploads/{filename}", UriKind.Relative);
        }

        public Task RemoveFile(string fileUrl)
        {
            var fileName = Path.GetFileName(fileUrl);
            var folder = GetDirectory();

            var fullPath = Path.Combine(folder, fileName);

            if (!System.IO.File.Exists(fullPath))
            {
                throw new FileDoesNotExistException(fullPath);
            }

            System.IO.File.Delete(fullPath);
            return Task.CompletedTask;
        }

        private string GetDirectory()
        {
            var folder = Path.Combine(_env.WebRootPath, "fileuploads");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            return folder;
        }
    }
}