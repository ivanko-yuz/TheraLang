using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.Storage.Blob;
using TheraLang.BLL.Infrastructure.AzureConnectionFactory;
using TheraLang.BLL.Interfaces;

namespace TheraLang.BLL.Services.File
{
    public class AzureFileService : IFileService
    {
        private readonly IAzureConnectionFactory _azureConnection;

        public AzureFileService(IAzureConnectionFactory azureConnection)
        {
            _azureConnection = azureConnection;
        }

        /// <summary>
        /// Uploads a file to Azure Blob Storage
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="fileExtension"></param>
        /// <returns></returns>
        public async Task<Uri> SaveFile(Stream stream, string fileExtension)
        {
            var container = _azureConnection.GetClient().GetContainerReference("files");
            var uniqueName = Guid.NewGuid().ToString();
            var filename = $"{uniqueName}{fileExtension}";
            if (!await container.ExistsAsync())
            {
                await container.CreateAsync();
                await container.SetPermissionsAsync(new BlobContainerPermissions()
                {
                    PublicAccess = BlobContainerPublicAccessType.Blob
                });
            }

            var blockBlob = container.GetBlockBlobReference(filename);

            await blockBlob.UploadFromStreamAsync(stream);
            return blockBlob.Uri;
        }
    }
}