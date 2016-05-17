namespace ContabilitatePrimaraPFA.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    public class SQLHelper
    {
        private const String m_connectionString = @"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDBFilename=F:\ProiectDiplomaWPF\ProiectDiplomaWPF\Database\ContaPFADb.mdf";
        private SqlConnection m_con = null;
        private SqlCommand m_command = null;
        public SQLHelper() { }

       
        public void ExecuteQuery(out DataTable dt, String sqlQuery)
        { 
            dt = new DataTable();
            StartConnection();
            try
            {
                using(SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery,m_con))
                {
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw ex;
            }
            CloseConnection();
        }


         public void ExecuteQuery(out IList<object> objList, String sqlQuery)
        {
            objList = new List<object>();
            try
            {
                StartConnection();
                using(m_command = new SqlCommand(sqlQuery,m_con))
                {                    
                    var reader = m_command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            objList.Add((object)reader.GetValue(0));
                        }
                    }
                }
                CloseConnection();
            }
             catch (Exception ex)
            {
                CloseConnection();
                 throw ex;
            }
        }


        private void StartConnection()
        {
            if (m_con == null)
            {
                m_con = new SqlConnection(m_connectionString);
                m_con.Open();
            }
        }

        private void CloseConnection()
        {
            if (m_con != null)
                m_con.Close();
        }

    }
 
}
