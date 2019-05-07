using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;
using IdentityStore.Models;

namespace IdentityStore.Tables
{
    public class UserTable : IDisposable
    {
        const string TABLE_NAME = "User";

        CloudTable _table;

        public UserTable(CloudTableClient client)
        {
            _table = client.GetTableReference(TABLE_NAME);
        }

        public void Dispose()
        {
            _table = null;
        }

        public async Task CreateAsync(IdUser user, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            user.GenerateKeys();
            var operation = TableOperation.Insert(user);

            await _table.CreateIfNotExistsAsync();
            await _table.ExecuteAsync(operation);
        }
    }
}
