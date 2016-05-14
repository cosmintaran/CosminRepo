using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContabilitatePrimaraPFA.View.Forms
{
    public partial class CautaLucrari : Form
    {
        
        private static CautaLucrari m_instance = null;
        public static readonly object padlock = new object(); 
        
        private CautaLucrari()
        {
            InitializeComponent();
        }

        public static CautaLucrari GetCautaLucrariForm
        {
            get
            {
                lock(padlock)
                {
                    if(m_instance == null)
                    {
                        m_instance = new CautaLucrari();
                    }
                }

                return m_instance;
            }
        }

        private void bttCautaLucrare_Click(object sender, EventArgs e)
        {

        }
    }
}
