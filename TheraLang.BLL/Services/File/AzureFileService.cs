using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Storage.Blob;
using TheraLang.BLL.Infrastructure.AzureConnectionFactory;
using TheraLang.BLL.Interfaces;

namespace TheraLang.BLL.Services.File
{
    public class AzureFileService: IFileService
    {
        private readonly IAzureConnectionFactory _azureConnection;
        
        public AzureFileService(IAzureConnectionFactory azureConnection)
        {
            _azureConnection = azureConnection;
        }

        public async Task<Uri> SaveFile(IFormFile file)
        {
            var container = _azureConnection.GetClient().GetContainerReference("files");
            var extension = Path.GetExtension(file.FileName);
            var uniqueName = Guid.NewGuid().ToString();
            var filename = $"{uniqueName}{extension}";
            if (!await container.ExistsAsync())
            {
                await container.CreateAsync();
                await container.SetPermissionsAsync(new BlobContainerPermissions()
                {
                    PublicAccess = BlobContainerPublicAccessType.Blob
                });
            }
            var blockBlob = container.GetBlockBlobReference(filename);

            await blockBlob.UploadFromStreamAsync(file.OpenReadStream());
            return blockBlob.Uri;
        }
    }
}