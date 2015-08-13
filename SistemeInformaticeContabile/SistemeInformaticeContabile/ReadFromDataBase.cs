using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SistemeInformaticeContabile
{
    public class ReadFromDataBase
    {
        public ReadFromDataBase() { }

        //Returneaza liste de obiecte cu componentele bazei de date
        public List<object> ReadColumnDatabase(string query)
        {
            var temp = new List<object>();
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ContaDatabase"].ConnectionString);
            var command = new SqlCommand(query, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    temp.Add((object)reader.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            return temp;
        }

        //Returneaza Dictionare cu componentele bazei de date
        public Dictionary<string,List<object>>ReadAllDatabase()
        {
            var temp = new Dictionary<string, List<object>>();
            return temp;
        }
        //Returneaza DataTable cu componentele bazei de date
        public DataTable  ReadTables(string query)
        {
           
            var table = new DataTable();
            var connection=new SqlConnection(ConfigurationManager.ConnectionStrings["ContaDatabase"].ConnectionString);
            connection.Open();
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally { connection.Close(); }        
                return table;
        }


    }
}
