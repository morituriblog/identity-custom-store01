using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using IdentityStore.Tables;

namespace IdentityStore
{
    public class IdContext : IDisposable
    {
        CloudTableClient _client;

        public UserTable User { get; private set; }

        public IdContext(string connectionString)
        {
            var account = CloudStorageAccount.Parse(connectionString);
            _client = account.CreateCloudTableClient();

            User = new UserTable(_client);
        }

        public void Dispose()
        {
            User.Dispose();
            _client = null;
        }
    }
}
