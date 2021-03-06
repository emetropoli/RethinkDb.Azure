﻿using System;

namespace RethinkDb.Azure.WebJobs.Extensions.Model
{
    internal struct TableOptions
    {
        #region Properties
        public string DatabaseName { get; private set; }

        public string TableName { get; private set; }
        #endregion

        #region Constructor
        public TableOptions(string databaseName, string tableName)
            : this()
        {
            DatabaseName = databaseName ?? throw new ArgumentNullException(nameof(databaseName));
            TableName = tableName ?? throw new ArgumentNullException(nameof(tableName));
        }
        #endregion
    }
}
