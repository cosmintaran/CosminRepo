
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ContabilitatePrimaraPFA.View.Classes;

namespace View.View.Forms
{
    public partial class FilterForm : Form
    {
        #region Class members declaration
        public string SearchKey { get; private set; }
        public FilterCriteria FilterCriteria { get; private set; }
        private Dictionary<string, FilterCriteria> _mDictionary;
        private string _selectedCriteria;
        private static FilterForm _mInstance = null;
        public static readonly object Padlock = new object();
        #endregion

        private FilterForm(Dictionary<string,FilterCriteria> dictionary)
        {
            InitializeComponent();
            _mDictionary = dictionary;
            FillList();
 
        }

        public static FilterForm GetCautaForm(Dictionary<string,FilterCriteria> dictionary)
        {
                lock(Padlock)
                {
                    if(_mInstance == null)
                    {
                        _mInstance = new FilterForm(dictionary);
                    }
                }

                return _mInstance;
            
        }

        private void bttCautaLucrare_Click(object sender, EventArgs e)
        {
                 
            SearchKey =  txtCautaLucrare.Text.Trim();
            FilterCriteria = string.IsNullOrEmpty(_selectedCriteria) ? FilterCriteria.None : _mDictionary[_selectedCriteria];
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

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
