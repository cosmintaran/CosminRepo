using System;
using System.Windows.Forms;

namespace SistemeInformaticeContabile
{
    public partial class BeneficiariForm : Form
    {
        public BeneficiariForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string CreateQuery()
        {
            string temp = null;
            temp = String.Format("Insert Into Beneficiari (Nume,Prenume,CNP,Serie_CI,NR_CI,Adresa) values ('{0}','{1}','{2}','{3}','{4}','{5}')",txtNume.Text,txtPrenume.Text,txtCNP.Text,txtSerieCI.Text,txtNrCI.Text,txtAdresa.Text);
            return temp;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                WriteInDataBase.Write(CreateQuery());
                Refres();
                MessageBox.Show("S-a creat o inregistrare noua");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Refres()
        {
            txtAdresa.Text = null;
            txtCNP.Text = null;
            txtNrCI.Text = null;
            txtNume.Text = null;
            txtPrenume.Text = null;
            txtSerieCI.Text = null;
        }
    }
}
