using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Windows.Forms;

namespace SistemeInformaticeContabile
{
    public partial class ContracteForm : Form
    {
        public ContracteForm()
        {
            InitializeComponent();
            FillComboBeneficiari();
        }

        private void FillComboBeneficiari()
        {
            var comboContent = new List<object>();
            var fillCombo = new ReadFromDataBase();
            comboBeneficiar.Items.Add("<Beneficiar Nou..>");
            comboContent = fillCombo.ReadColumnDatabase(ConfigurationManager.AppSettings["ComboBoxBeneficiari"]);
            for (int i = 0; i < comboContent.Count; i++)
            {
                comboBeneficiar.Items.Add((string)comboContent[i]);
            }
        }

        private void comboBeneficiar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(String.Compare((string)comboBeneficiar.SelectedItem, "<Beneficiar Nou..>") ==0)
            {
                BeneficiariForm beneficiari = new BeneficiariForm();
                beneficiari.Show();
                comboBeneficiar.Items.Clear();
                FillComboBeneficiari();
            }
        }

        private void bttOK_Click(object sender, EventArgs e)
        {
            var temp = new StringBuilder();
            if (ValidareForm(ref temp) == true)
                MessageBox.Show(temp.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                try
                {
                    WriteInDataBase.Write(ContracteQuery());
                    Reset();
                }
                catch(Exception ex)
                { MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
        }

        private string ContracteQuery()
        {
            string query = string.Format("Insert into Contracte (Nr_Contract,Data_Contract,Beneficiar,Obiectul_Contractului,UAT,Observatii) Values('{0}','{1}','{2}','{3}','{4}','{5}')",
                           txtNumarContract.Text,dateTimePicker_Contracte.Text,comboBeneficiar.SelectedIndex,txtObiectulContractului.Text,txtUAT.Text,txtObservatii.Text);
            return query;
        }

        private bool ValidareForm(ref StringBuilder temp)
        {
            bool test = false;
            temp.Append("Va rugam completati: ");
            if (String.IsNullOrEmpty(txtNumarContract.Text))
            { temp.Append("numarul contractului "); test = true; }
            else if (comboBeneficiar.SelectedItem == null)
            { temp.Append("beneficiarul contractului "); test = true; }
            else if (String.IsNullOrEmpty(txtObiectulContractului.Text))
            { temp.Append("obiectul contractului "); test = true; }
            else if (String.IsNullOrEmpty(txtUAT.Text))
            { temp.Append("U.A.T. imobilului "); test = true; }
            else if (String.IsNullOrEmpty(txtObservatii.Text))
            { temp.Append("observatii la contract"); test = true; }
                return test;
        }

        private void Reset()
        {
            txtNumarContract.Text = null;
            txtObiectulContractului.Text = null;
            txtObservatii.Text = null;
            txtUAT.Text = null;
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
