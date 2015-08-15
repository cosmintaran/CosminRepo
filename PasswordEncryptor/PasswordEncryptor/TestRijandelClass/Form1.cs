using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordEncryptor;

namespace TestRijandelClass
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }

        private void bttClose_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttGenerateXML_Click (object sender, EventArgs e)
        {
            XMLWriter x = new XMLWriter(txtDatabaseName.Text, txtUserName.Text, RijandaelClass.EncryptRijandel(txtPassword.Text));
            x.WriteXML();
        }

    }
}
