using System;
using System.IO;
using System.Threading.Tasks;
using Common.Exceptions;
using Microsoft.Azure.Storage.Blob;
using TheraLang.BLL.Infrastructure.AzureConnectionFactory;
using TheraLang.BLL.Interfaces;

namespace TheraLang.BLL.Services.FileServices
{
    public class AzureFileService : IFileService
    {
        private readonly CloudBlobContainer _container;

        public AzureFileService(IAzureConnectionFactory azureConnection)
        {
            _container = azureConnection.GetClient().GetContainerReference("files");
        }

        /// <summary>
        /// Uploads a file to Azure Blob Storage
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="fileExtension"></param>
        /// <returns></returns>
        public async Task<Uri> SaveFile(Stream stream, string fileExtension)
        {
            var uniqueName = Guid.NewGuid().ToString();
            var filename = $"{uniqueName}{fileExtension}";
            if (!await _container.ExistsAsync())
            {
                await _container.CreateAsync();
                await _container.SetPermissionsAsync(new BlobContainerPermissions()
                {
                    PublicAccess = BlobContainerPublicAccessType.Blob
                });
            }

            var blockBlob = _container.GetBlockBlobReference(filename);

            await blockBlob.UploadFromStreamAsync(stream);
            return blockBlob.Uri;
        }

        /// <summary>
        /// Remove file from a Azure Blob Storage
        /// </summary>
        /// <param name="fileUrl"></param>
        /// <returns></returns>
        /// <exception cref="FileDoesNotExistException"></exception>
        public async Task RemoveFile(string fileUrl)
        {
            if (!await _container.ExistsAsync())
            {
                return;
            }
            var fileName = Path.GetFileName(fileUrl);
            var blockBlob = _container.GetBlockBlobReference(fileName);
            if (!await blockBlob.DeleteIfExistsAsync())
            {
                throw new FileDoesNotExistException($"azureBlobStorage//{fileName}");
            }
        }
    }
}