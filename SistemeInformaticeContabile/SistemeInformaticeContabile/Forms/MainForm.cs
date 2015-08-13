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

        private void bttnContracte_Click(object sender, EventArgs e)
        {
            ContracteForm contracte=new ContracteForm();
            contracte.Show();
        }
         private void FillCombo()
        {
            var comboContent = new List<object>();
            var fillCombo = new ReadFromDataBase();
            comboContent=fillCombo.ReadColumnDatabase(ConfigurationManager.AppSettings["ComboBox"]);
            for (int i = 0; i < comboContent.Count; i++)
            {
                comboBoxViewTable.Items.Add((string)comboContent[i]);
            }
        }

        private void bttnLucrareNoua_Click(object sender, EventArgs e)
        {

        }
        #region Fill DataGridView
        private void comboBoxViewTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            var option = comboBoxViewTable.SelectedItem.ToString();
            
            switch(option)
            {
                case "Lucrari":
                    dgViewDatabase.Refresh();
                    dgViewDatabase.AutoResizeColumns();
                    var jobs = new ReadFromDataBase();
                    dgViewDatabase.DataSource = jobs.ReadTables(ConfigurationManager.AppSettings["ReadJobs"]);
                    
                    break;
                case "Contracte":
                    dgViewDatabase.Refresh();
                    dgViewDatabase.AutoResizeColumns();
                    var contracte= new ReadFromDataBase();
                    dgViewDatabase.DataSource = contracte.ReadTables(ConfigurationManager.AppSettings["Contracte"]);
                    break;
                case "Procese Verbale":
                    Console.WriteLine("Procese Verbale");
                    break;
                case "Registru Jurnal":
                    Console.WriteLine("Registru Jurnal");
                    break;
                case "Raport 392B":
                    Console.WriteLine("Raport 392B");
                    break;
                default:
                    break;
            }
        }
        #endregion Fill DataGridView

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
