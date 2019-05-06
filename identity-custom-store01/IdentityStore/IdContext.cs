using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace IdentityStore
{
    public class IdContext : IDisposable
    {
        CloudTableClient _client;

        public IdContext(string connectionString)
        {
            var account = CloudStorageAccount.Parse(connectionString);
            _client = account.CreateCloudTableClient();
        }

        public void Dispose()
        {
            _client = null;
        }
    }
}
