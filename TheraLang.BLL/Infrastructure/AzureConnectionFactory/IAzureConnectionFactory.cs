using Microsoft.Azure.Storage.Blob;

namespace TheraLang.BLL.FileManager
{
    public interface IAzureConnectionFactory
    {
        CloudBlobClient GetClient();
    }
}