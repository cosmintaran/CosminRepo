using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace SistemeInformaticeContabile
{
   public class ReadFromDataBase
    {
        public ReadFromDataBase() { }

        //Create a list of objects with database components
        public List<object> ReadDatabase(string query)
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

        public Dictionary<string,List<object>>ReadDatabase()
        {
            var temp = new Dictionary<string, List<object>>();
            return temp;
        }

    }
}
