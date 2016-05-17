
namespace ContabilitatePrimaraPFA.View.Forms
{
    using System.Windows.Forms;
    using Queries.Persitence;
    using System;

    public partial class SelectTipLucrari : Form
    {
        public int SelectedCodLucrare { get; private set; }
        public SelectTipLucrari()
        {
            InitializeComponent();
            FillListBox();
        }

        private void FillListBox()
        {
            ContaContext contaContext = new ContaContext();
            UnitOfWork unitOfWork = new UnitOfWork(contaContext);
            var data = unitOfWork.TipLucrare.GetAll();
            foreach (var item in data)
            {
                ListViewItem lvItem = new ListViewItem(item.TipLucrareId.ToString());
                lvItem.SubItems.Add(item.CodLucrare.ToString());
                lvItem.SubItems.Add(item.Tip_Lucrare);
                listViewTipLucrare.Items.Add(lvItem);
            }

        }

        private void listViewTipLucrare_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCodLucrare =int.Parse(listViewTipLucrare.SelectedItems[0].Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bttCloseTiplucrare_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
