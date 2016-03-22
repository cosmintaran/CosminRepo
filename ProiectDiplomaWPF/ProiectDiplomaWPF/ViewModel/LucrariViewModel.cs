using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectDiplomaWPF.ViewModel
{
    class LucrariViewModel
    {

        private IList<Lucrare> m_Lucrari;
        private DataTable m_dataTable;
        private string sqlQuery;

        public LucrariViewModel()
        {
            SQLHelper m_sqlConnection = new SQLHelper();
            m_sqlConnection.ExecuteQuery(out m_dataTable, sqlQuery);
            
        }
    }
}
