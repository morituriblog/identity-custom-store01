using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.Storage.Table;

namespace IdentityStore.Tables
{
    public class UserTable
    {
        const string TABLE_NAME = "User";

        CloudTable _table;

        public UserTable(CloudTableClient client)
        {
            _table = client.GetTableReference(TABLE_NAME);
        }
    }
}
