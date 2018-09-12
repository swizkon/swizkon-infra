namespace Swizkon.Infrastructure.Azure.Storage.TableStorage
{
    using System.Diagnostics;
    using Microsoft.Extensions.Configuration;
    using Microsoft.WindowsAzure.Storage;
    using Microsoft.WindowsAzure.Storage.Table;

    public abstract class AzureTableStorageBase
    {
        private readonly CloudTableClient _tableClient;

        public AzureTableStorageBase(IConfiguration configuration)
        {
            var connectionString = configuration["Azure:StorageConnectionString"];
            var cloudStorageAccount = CloudStorageAccount.Parse(connectionString);
            _tableClient = cloudStorageAccount.CreateCloudTableClient();
        }

        protected CloudTable GetTableReference(string tableName)
        {
            var table = _tableClient.GetTableReference(tableName.ToLower());
            table.CreateIfNotExistsAsync().Wait();

            return table;
        }
    }
}
