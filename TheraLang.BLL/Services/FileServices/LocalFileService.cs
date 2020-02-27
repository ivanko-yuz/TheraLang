using System;
using System.IO;
using System.Threading.Tasks;
using Common.Exceptions;
using Microsoft.AspNetCore.Hosting;
using TheraLang.BLL.Interfaces;

namespace TheraLang.BLL.Services.FileServices
{
    public class LocalFileService : IFileService
    {
        private readonly string _folderPath;

        public LocalFileService(IHostingEnvironment env)
        {
            _folderPath = GetDirectory(env.WebRootPath);
        }

        /// <summary>
        /// Saves file to a local folder
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="fileExtension"></param>
        /// <returns></returns>
        public async Task<Uri> SaveFile(Stream stream, string fileExtension)
        {
            var uniqueName = Guid.NewGuid().ToString();
            var fileName = $"{uniqueName}{fileExtension}";
            var fullPath = FormatFullPath(fileName);

            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                await stream.CopyToAsync(fileStream);
            }

            return new Uri($"/fileuploads/{fileName}", UriKind.Relative);
        }

        /// <summary>
        /// Removes file from a local folder
        /// </summary>
        /// <param name="fileUrl"></param>
        /// <returns></returns>
        /// <exception cref="FileDoesNotExistException"></exception>
        public Task RemoveFile(string fileUrl)
        {
            var fileName = Path.GetFileName(fileUrl);

            var fullPath = FormatFullPath(fileName);

            if (File.Exists(fullPath))
            {
                throw new FileDoesNotExistException(fullPath);
            }

            File.Delete(fullPath);
            return Task.CompletedTask;
        }

        private string GetDirectory(string baseFolder)
        {
            var folder = Path.Combine(baseFolder, "fileuploads");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            return folder;
        }

        private string FormatFullPath(string fileName)
        {
            return Path.Combine(_folderPath, fileName);
        }
    }
}