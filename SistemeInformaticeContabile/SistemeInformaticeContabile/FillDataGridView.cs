using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemeInformaticeContabile
{
    public static class FillDataGridView
    {
        public static void Lucrari()
        {
            var jobs= new ReadFromDataBase();
            jobs.ReadTables("");
        }

    }
}
