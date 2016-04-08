using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContabilitatePrimaraPFA.Forms;

namespace ContabilitatePrimaraPFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adaugaPFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Date_PFA pfaForm = new Date_PFA();
            pfaForm.Show();
        }
    }
}
