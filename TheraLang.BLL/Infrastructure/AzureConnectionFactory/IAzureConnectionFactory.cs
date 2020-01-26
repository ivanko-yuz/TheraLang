using Microsoft.Azure.Storage.Blob;

namespace TheraLang.BLL.Infrastructure.AzureConnectionFactory
{
    public interface IAzureConnectionFactory
    {
        CloudBlobClient GetClient();
    }
}