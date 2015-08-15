using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Resources;

namespace Import_Excel_into_Database
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            string filePath = null;
            ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            

        }
    }
}
