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
        public SearchCriteria SearchCriteria { get; private set; }
        private Dictionary<string, SearchCriteria> _mDictionary;
        private string _selectedCriteria;
        private static CautaLucrari _mInstance = null;
        public static readonly object Padlock = new object();
        #endregion

        private CautaLucrari()
        {
            InitializeComponent();
             _mDictionary= new Dictionary<string, SearchCriteria>
            {
                { "Nr. Documentatie", SearchCriteria.NrDoc}, {"An Documentatie",SearchCriteria.An}, { "Nume Beneficiar",Classes.SearchCriteria.NumeBeneficiar},
                { "C.N.P. Beneficiar",Classes.SearchCriteria.CnpBeneficiar}, {"Cod Documentatie",Classes.SearchCriteria.TipDoc}, {"Nr. Contract",Classes.SearchCriteria.NrContract},
                {"U.A.T.",Classes.SearchCriteria.Uat}, {"Receptionate",Classes.SearchCriteria.Receptionata}, {"Respinse",Classes.SearchCriteria.Respinsa}, {"In Lucru",SearchCriteria.InLucru}};

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
            SearchCriteria = string.IsNullOrEmpty(_selectedCriteria) ? SearchCriteria.None : _mDictionary[_selectedCriteria];
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
                    txtCautaLucrare.Text = @"Receptionat";
                    txtCautaLucrare.Enabled = false;
                    break;
                case "Respinse":
                    txtCautaLucrare.Text = @"Respins";
                    txtCautaLucrare.Enabled = false;
                    break;
                case "In Lucru":
                    txtCautaLucrare.Text = @"In Lucru";
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
