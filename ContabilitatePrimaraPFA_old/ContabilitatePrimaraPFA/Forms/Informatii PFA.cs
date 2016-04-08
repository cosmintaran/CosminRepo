using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resources;
namespace ContabilitatePrimaraPFA.Forms
{
    public partial class Date_PFA : Form
    {
        DataTable judete;
        public Date_PFA()
        {
            InitializeComponent();
            MSSQLHelper msSQL = new MSSQLHelper(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\cosmi\OneDrive\Documente\Repository\ContabilitatePrimaraPFA\ContabilitatePrimaraPFA\Database\ContaDb.mdf; Integrated Security = True");
            string sqlQuery = "Select [Denumire Judet] from Judete";
            msSQL.Open();
            msSQL.ExecuteQuery(sqlQuery, out judete);
            msSQL.CloseConnection();
            foreach (DataRow jud in judete.Rows)
            {
                comboBoxJudet.Items.Add(jud.ToString());
            }
        }

        private void bttOk_Click(object sender, EventArgs e)
        {


        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
