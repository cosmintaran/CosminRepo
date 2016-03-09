using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectDiplomaWPF.ViewModel
{
    public class DatabaseConnection
    {
        //private bool m_isClassIntantiate;
        private static DatabaseConnection m_currentConnection = null;
        private static readonly object padlock = new object();
        
        public static DatabaseConnection StartConection
        {
            get
            {
                lock (padlock)
                {
                    if(m_currentConnection == null)
                    {
                        m_currentConnection = new DatabaseConnection();
                    }
                    return m_currentConnection;
                }
            }

        }

        
        private DatabaseConnection()
        {

        }

    }
}
