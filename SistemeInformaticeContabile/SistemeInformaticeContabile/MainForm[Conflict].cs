using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemeInformaticeContabile
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FillCombo();
            
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            
        }
         private void FillCombo()
        {
            var comboContent = new List<object>();
            var fillCombo = new ReadFromDataBase();
            comboContent=fillCombo.ReadDatabase(ConfigurationManager.AppSettings["ComboBox"]);
            for (int i = 0; i < comboContent.Count; i++)
            {
                comboBoxViewTable.Items.Add((string)comboContent[i]);
            }
        }

        private void bttnNewJob_Click(object sender, EventArgs e)
        {

        }
    }
}
