using Resources.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Resources
{
   public class SQLHelper : IDatabase
    {
        private SqlConnection m_connection;
        private string connectionString;


        public SQLHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public bool Open(string connectionString)
        {
            bool isSucceded = false;
            try
            {
                Debug.WriteLine("Trying to connect...");
                m_connection = new SqlConnection(connectionString);
                m_connection.Open();
                isSucceded = true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            Debug.WriteLine("Connection started succsesfuly.");
            return isSucceded;
        }

        public bool ExecuteNonQuery(string sqlQuery)
        {
            bool isQuerySucceded = false;            

            return isQuerySucceded;
        }

        public bool ExecuteQuery(string sqlQuery, out DataTable dtInput)
        {
            throw new NotImplementedException();
        }

        public bool ExecuteQuery(string sqlQuery, out IList<string> lsInput)
        {
            throw new NotImplementedException();
        }

        public bool BulkCopy(string databaseTable, DataTable input)
        {
            return true;
        }


        public bool CloseConnection()
        {
            bool isClosed = false;
            Debug.WriteLine("Trying to close connection....");
            try
            {
                m_connection.Close();
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            Debug.WriteLine("Connection closed succsesfuly.");
            return isClosed;
        }
    }
}
