using System;
using System.Data.SqlClient;
using System.Configuration;

namespace SistemeInformaticeContabile
{
    public class WriteInDataBase
    {
        public WriteInDataBase() { }

        public static void Write(string query)
        {
            var connecting = new SqlConnection(ConfigurationManager.ConnectionStrings["ContaDataBase"].ConnectionString);
            var command = new SqlCommand(query,connecting);
            try
            {
                connecting.Open();
                command.ExecuteNonQuery();
                connecting.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connecting.Close();
            }
        }

    }
}
