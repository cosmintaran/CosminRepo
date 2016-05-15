namespace ContabilitatePrimaraPFA.View.Forms
{
    using System;
    using System.Windows.Forms;
    using Classes;
    using System.Collections.Generic;

    public partial class CautaLucrari : Form
    {
        #region Class members declaration
        public string SearchKey { get; private set; }
        public SearchDocCriteria SearchCriteria { get; private set; }
        private Dictionary<string, SearchDocCriteria> _mDictionary;
        private string _selectedCriteria;
        private static CautaLucrari _mInstance = null;
        public static readonly object Padlock = new object();
        #endregion

        private CautaLucrari()
        {
            InitializeComponent();
             _mDictionary= new Dictionary<string, SearchDocCriteria>
            {
                { "Nr. Documentatie", SearchDocCriteria.NrDoc}, {"An Documentatie",SearchDocCriteria.AnDoc}, { "Nume Beneficiar",SearchDocCriteria.NumeBeneficiar},
                { "C.N.P. Beneficiar",SearchDocCriteria.CnpBeneficiar}, {"Cod Documentatie",SearchDocCriteria.TipDoc}, {"Nr. Contract",SearchDocCriteria.NrContract},
                {"U.A.T.",SearchDocCriteria.Uat}, {"Receptionate",SearchDocCriteria.Receptionata}, {"Respinse",SearchDocCriteria.Respinsa}, {"In Lucru",SearchDocCriteria.InLucru}};

            FillList();
        }

        public static CautaLucrari GetCautaLucrariForm
        {
            get
            {
                lock(Padlock)
                {
                    if(_mInstance == null)
                    {
                        _mInstance = new CautaLucrari();
                    }
                }

                return _mInstance;
            }
        }

        private void bttCautaLucrare_Click(object sender, EventArgs e)
        {
                 
            SearchKey = txtCautaLucrare.Text;
            SearchCriteria = string.IsNullOrEmpty(_selectedCriteria) ? SearchDocCriteria.None : _mDictionary[_selectedCriteria];
               this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FillList()
        {
            
            
            int contor = 1;
            foreach (var iter in _mDictionary)
            {
                ListViewItem item = new ListViewItem(contor.ToString());

                item.SubItems.Add(iter.Key);
                listView1.Items.Add(item);
                contor++;
            }

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            _selectedCriteria = "";
            _selectedCriteria = listView1.SelectedItems[0].SubItems[1].Text;
            switch (_selectedCriteria)
            {
                case "Receptionate":
                    txtCautaLucrare.Text = @"Receptionata";
                    txtCautaLucrare.Enabled = false;
                    break;
                case "Respinse":
                    txtCautaLucrare.Text = @"Respinsa";
                    txtCautaLucrare.Enabled = false;
                    break;
                case "In Lucru":
                    txtCautaLucrare.Text = @"InLucru";
                    txtCautaLucrare.Enabled = false;
                    break;
                default:
                    txtCautaLucrare.Text = "";
                    txtCautaLucrare.Enabled = true;
                    break;
            }
        }
    }
}
