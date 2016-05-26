using System.IO;
using Microsoft.Owin;
using Owin;
using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Blob; // Namespace for Blob storage types

[assembly: OwinStartupAttribute(typeof(TemperatureLogger.Startup))]
namespace TemperatureLogger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            /*
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference("temperature");

            CloudBlockBlob blockBlob = container.GetBlockBlobReference("0_d1e8a2b709b14461b5ac12265f33020b_1.json");

            string path = (@"C:\Users\Benny\Source\Repos\JSON\StorageBlob\StorageBlob\data.json");
            blockBlob.DownloadToFile(path, FileMode.OpenOrCreate);
            */
        }
    }
}
