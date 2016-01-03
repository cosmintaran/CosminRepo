using System.Collections.Generic;
using System.Data;

namespace Resources.Interfaces
{
    interface IDatabase
    {
        bool Open();
        bool CloseConnection();
        bool ExecuteQuery(string sqlQuery, out IList<string> lsInput);
        bool ExecuteQuery(string sqlQuery, out DataTable dtInput);
        bool ExecuteNonQuery(string sqlQuery);
        bool BulkCopy(string databaseTable, DataTable input);
    }
}
