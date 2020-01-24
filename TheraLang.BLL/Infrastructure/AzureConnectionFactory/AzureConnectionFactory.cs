using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;

namespace TheraLang.BLL.FileManager
{
    public class AzureConnectionFactory: IAzureConnectionFactory
    {
        private readonly string _connectionString;
        public AzureConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public CloudBlobClient GetClient()
        {
            var storageAccount = CloudStorageAccount.Parse(_connectionString);
            return storageAccount.CreateCloudBlobClient();
        }
    }
}