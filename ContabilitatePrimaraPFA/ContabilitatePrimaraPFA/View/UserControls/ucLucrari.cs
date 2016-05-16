namespace ContabilitatePrimaraPFA.View.UserControls
{
    using System.Windows.Forms;
    using System;
    using Queries.Core.Domain;
    using Queries.Persitence;
    using System.ComponentModel;
    using Classes;
    using Forms;

    public partial class UcLucrari : UserControl
    {

        public delegate void FormChangedEventHandler(object sender, EventArgs args);
        public event FormChangedEventHandler UserControlChanging;


        #region Declared Members
        private static UcLucrari _mInstance;
        private static readonly object Padlock = new object();
        private Lucrare _lucrare;

        #endregion

        #region Init Area
        public static UcLucrari GetUiLucrari
        {
            get
            {
                lock (Padlock)
                {
                    return _mInstance ?? (_mInstance = new UcLucrari());
                }
            }
        }

        private UcLucrari()
        {
            InitializeComponent();
            _lucrare = new Lucrare();
            FillCombobox();
            FillGridView(SearchCriteria.An, DateTime.Today.Year.ToString());
            ClearFormLucrare();
        }
        #endregion

        #region Command region

        private void bttSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled)) return;
            
            PrepareObject();
            var con = new ContaContext();
            var unitOfWork = new UnitOfWork(con);
            unitOfWork.Lucrari.Add(_lucrare);
            unitOfWork.Complete();
            unitOfWork.Dispose();
            FillGridView(SearchCriteria.An, DateTime.Today.Year.ToString());

            ClearFormLucrare();
            if (!bttNewLucrare.Enabled)
                bttNewLucrare.Enabled = true;
            // Disable grupbox Lucrari
            if (grBoxLucrare.Enabled)
                grBoxLucrare.Enabled = false;
           
        }

        private void bttNewLucrare_Click(object sender, EventArgs e)
        {
            if (grBoxLucrare.Enabled == false)
                grBoxLucrare.Enabled = true;

            bttNewLucrare.Enabled = false;
            bttDeleteLucrari.Enabled = false;
        }

        private void LucrariView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bttDeleteLucrari.Enabled) return;
            bttDeleteLucrari.Enabled = true;
        }

        private void bttClearlucrare_Click(object sender, EventArgs e)
        {
            ClearFormLucrare();
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            CautaLucrari sel = CautaLucrari.GetCautaLucrariForm;
            var result = sel.ShowDialog();
            if (result != DialogResult.OK) return;
            var criteria = sel.SearchCriteria;
            var key = sel.SearchKey;
            if (string.IsNullOrEmpty(key)) return;
            FillGridView(criteria, key);
        }

        private void LucrariView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = null;
            foreach (DataGridViewRow iterator in LucrariView.SelectedRows)
            {
                row = iterator;
            }

            if (row == null) return;
            var conta = new ContaContext();
            var unitOfWork = new UnitOfWork(conta);

            // ReSharper disable once ConstantConditionalAccessQualifier
            var id = row?.Cells["LucrareId"].Value;
            if (id == null) return;
            _lucrare = unitOfWork.Lucrari.Get((int)id);

            unitOfWork.Dispose();
            conta.Dispose();

            if (_lucrare == null) return;

            int sStatusAccept = unitOfWork.AcceptateRespinse.Get(_lucrare.AcceptataRefuzataId).AcceptataRefuzataId;
            if (--sStatusAccept >= 0)
                cbAcceptResp.SelectedIndex = sStatusAccept;

            int sStatusRec = unitOfWork.ReceptionateRespinse.Get(_lucrare.ReceptionatRespinsId).ReceptionatRespinsId;
            if(--sStatusRec >= 0)
                cbReceptionatRespins.SelectedIndex = sStatusRec;

            if (_lucrare.ContractId != null)
                cbContract.SelectedText = unitOfWork.Contracte.Get((int)_lucrare.ContractId).NrContract;

            if (_lucrare.DataInregistrare != null)
                dateTimePickerInreg.Value = (DateTime)_lucrare.DataInregistrare;

            if (_lucrare.TermenSolutionare != null)
                dateTimePickerTermen.Value = (DateTime)_lucrare.TermenSolutionare;

            txtInreg.Text = _lucrare.Nr_OCPI;
            txtDoc.Text = _lucrare.NrProiect;
            txtAvizator.Text = _lucrare.AvizatorRegistrator;
            txtUAT.Text = _lucrare.UAT;
            txtObservatii.Text = _lucrare.Observatii;
            txtCad.Text = _lucrare.CadTop;

            //Set enable disabe or visibilty for controls
            bttNewLucrare.Enabled = false;
            bttDeleteLucrari.Enabled = false;
            grBoxLucrare.Enabled = true;
            bttEdit.Visible = true;
            bttCancel.Visible = true;
            bttSave.Visible = false;
            bttClearlucrare.Visible = false;
        }

        private void bttTipLucrare_Click(object sender, EventArgs e)
        {
            using (SelectTipLucrari sel = new SelectTipLucrari())
            {
                var result = sel.ShowDialog();
                if (result != DialogResult.OK) return;
                _lucrare.TipLucrareId = sel.SelectedCodLucrare;
            }

        }

        private void bttDeleteLucrari_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            foreach (DataGridViewRow iterator in LucrariView.SelectedRows)
            {
                selectedRow = iterator;
            }

            var dataGridViewCell = selectedRow?.Cells["LucrareId"].Value;
            if (dataGridViewCell == null) return;
            //var id = dataGridViewCell;
            ContaContext contaContext = new ContaContext();
            UnitOfWork unityOfWork = new UnitOfWork(contaContext);
            Lucrare lucrare = unityOfWork.Lucrari.Get((int)dataGridViewCell);
            var userConfirm = MessageBox.Show(@"Confirmati stergerea din baza de date a documentatiei cu nr. " + lucrare.NrProiect + @"/" +
                lucrare.AnProiect, @"Delete confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (userConfirm == DialogResult.Yes)
            {
                unityOfWork.Lucrari.Remove(lucrare);
                unityOfWork.Complete();
                unityOfWork.Dispose();
                contaContext.Dispose();
                bttDeleteLucrari.Enabled = false;
                FillGridView(SearchCriteria.An,DateTime.Now.Year.ToString());
            }
            else
            {
                bttDeleteLucrari.Enabled = false;
                unityOfWork.Dispose();
                contaContext.Dispose();
            }
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled)) return;

            PrepareObject();
            var con = new ContaContext();
            var unitOfWork = new UnitOfWork(con);
            unitOfWork.Lucrari.UpdateEntry(_lucrare);
            unitOfWork.Complete();
            unitOfWork.Dispose();
            FillGridView(SearchCriteria.An, DateTime.Today.Year.ToString());

            ClearFormLucrare();

            bttClearlucrare.Visible = true;
            bttClearlucrare.Enabled = true;
            bttSave.Visible = true;
            bttSave.Enabled = true;
            bttEdit.Visible = false;
            bttCancel.Visible = false;
            bttNewLucrare.Enabled = true;
            bttDeleteLucrari.Enabled = false;
            grBoxLucrare.Enabled = false;

        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            ClearFormLucrare();

            bttClearlucrare.Visible = true;
            bttNewLucrare.Visible = true;
            bttEdit.Visible = false;
            bttCancel.Visible = false;
            bttNewLucrare.Enabled = true;
            bttDeleteLucrari.Enabled = false;
            grBoxLucrare.Enabled = false;
        }

        #endregion

        # region Logical Area

        private void FillCombobox()
        {
            try
            {
                var bindAcceptrefuz = new BindingSource();
                var bindRecResp = new BindingSource();
                var bindContract = new BindingSource();

                var contaContext = new ContaContext();
                var unitOfWork = new UnitOfWork(contaContext);

                //Acceptata/Respinsa
                bindAcceptrefuz.DataSource = unitOfWork.AcceptateRespinse.GetAll();
                cbAcceptResp.DataSource = bindAcceptrefuz;
                cbAcceptResp.DisplayMember = "StatusAccept";

                //Receptionat/Respins
                bindRecResp.DataSource = unitOfWork.ReceptionateRespinse.GetAll();
                cbReceptionatRespins.DataSource = bindRecResp;
                cbReceptionatRespins.DisplayMember = "StatusRec";

                //Numar contract
                bindContract.DataSource = unitOfWork.Contracte.GetContractByYear(DateTime.Today.Year);
                bindContract.Add(new Contract { NrContract = "<new...>" });
                cbContract.DataSource = bindContract;
                cbContract.DisplayMember = "NrContract";

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, @"Error initializing fields", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void FillGridView(SearchCriteria criteria, string key)
        {
            try
            {
                ContaContext conta = new ContaContext();
                UnitOfWork unityOfWork = new UnitOfWork(conta);

                BindingSource bindingSource;

                #region Switch 
                switch (criteria)
                {
                    case SearchCriteria.An:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByYear(key) };
                        break;
                    case SearchCriteria.CnpBeneficiar:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByBeneficiarName(key) };
                        break;
                    case SearchCriteria.NrContract:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrareByContract(key) }; 
                        break;
                    case SearchCriteria.NrDoc:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByNrDocumentatie(key) };
                        break;
                    case SearchCriteria.NumeBeneficiar:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByBeneficiarName(key) };
                        break;

                    case SearchCriteria.TipDoc:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByCodLucrare(key) };
                        break;
                    case SearchCriteria.Uat:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByUat(key) };
                        break;
                    case SearchCriteria.Receptionata:
                    case SearchCriteria.Respinsa:
                    case SearchCriteria.InLucru:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByStatusOCPI(key) };
                        break;
                                          
                    default:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByYear(key) };
                        break;
                }
                #endregion Switch

                // ReSharper disable once ConstantConditionalAccessQualifier
                if (bindingSource?.DataSource == null) return;
                LucrariView.DataSource = bindingSource;
                if (LucrariView.Columns["LucrareId"] == null)
                {
                    LucrariView.Rows.Clear();
                    LucrariView.Refresh();
                }
                else
                {
                    var dataGridViewColumn = LucrariView.Columns["LucrareId"];
                    dataGridViewColumn.Visible = false;
                }

            }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cbContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contract = cbContract.SelectedItem as Contract;
            if (contract != null && contract.NrContract == "<new...>")
            {
                ChangeForm("Contracte");
            }
        }

        protected virtual void ChangeForm(string formName)
        {
            UserControlChanging?.Invoke(formName, EventArgs.Empty);
        }

        private void PrepareObject()
        {
            var acceptataRefuzata = cbAcceptResp.SelectedItem as AcceptataRefuzata;
            if (acceptataRefuzata != null)
                _lucrare.AcceptataRefuzataId = acceptataRefuzata.AcceptataRefuzataId;

            _lucrare.Nr_OCPI = txtInreg.Text;
            _lucrare.DataInregistrare = dateTimePickerInreg.Value;
            _lucrare.TermenSolutionare = dateTimePickerTermen.Value;
            _lucrare.AvizatorRegistrator = txtAvizator.Text;
            //TipLucrare din form SelectTipLucrare initializam doar cu val default 
            _lucrare.TipLucrareId = 1; // Id 1 None
            _lucrare.NrProiect = txtDoc.Text;
            _lucrare.AnProiect = DateTime.Now.Year.ToString();
            _lucrare.CadTop = txtCad.Text;
            _lucrare.UAT = txtUAT.Text;

            var contract = cbContract.SelectedItem as Contract;
            if (contract != null)
                _lucrare.ContractId = contract.ContractId;

            var receptionatRespins = cbReceptionatRespins.SelectedItem as ReceptionatRespins;
            if (receptionatRespins != null)
                _lucrare.ReceptionatRespinsId = receptionatRespins.ReceptionatRespinsId;

            _lucrare.Observatii = txtObservatii.Text;
        }

        private void ClearFormLucrare()
        {
            cbAcceptResp.SelectedIndex = -1;
            cbContract.SelectedIndex = -1;
            cbReceptionatRespins.SelectedIndex = -1;
            txtAvizator.Text = "";
            txtCad.Text = "";
            txtDoc.Text = "";
            txtInreg.Text = "";
            txtObservatii.Text = "";
            txtUAT.Text = "";
        }

        #endregion

        #region Fileds Validation Area

        private void txtDoc_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtDoc.Text))
            {
                e.Cancel = true;
                txtDoc.Focus(); errorProviderLucrari.SetError(txtDoc, "Campul Nr. Documentatie trebuie completat");
            }

            else if (!FormValidator.NamesValidator(txtDoc.Text, "[A-Za-z0-9]"))
            {
                e.Cancel = true;
                txtDoc.Focus(); errorProviderLucrari.SetError(txtDoc, "Campul contine caractere invalide");
            }
            else
            {
                e.Cancel = false; errorProviderLucrari.SetError(txtDoc, "");
            }
        }

        private void txtInreg_Validating(object sender, CancelEventArgs e)
        {
            if (!FormValidator.NamesValidator(txtInreg.Text, "[0-9]"))
            {
                e.Cancel = true;
                txtInreg.Focus(); errorProviderLucrari.SetError(txtInreg, "Campul contine caractere invalide");
            }
            else { e.Cancel = false; errorProviderLucrari.SetError(txtInreg, ""); }
        }

        private void txtUAT_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUAT.Text))
            {
                e.Cancel = true;
                txtUAT.Focus(); errorProviderLucrari.SetError(txtUAT, "Campul UAT trebuie completat");
            }

            else if (!FormValidator.NamesValidator(txtUAT.Text, "[A-Za-z]"))
            {
                e.Cancel = true;
                txtUAT.Focus(); errorProviderLucrari.SetError(txtUAT, "Campul UAT contine caractere invalide");
            }
            else
            {
                e.Cancel = false; errorProviderLucrari.SetError(txtUAT, "");
            }
        }

        private void txtCad_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtCad.Text))
            {
                e.Cancel = true;
                txtCad.Focus(); errorProviderLucrari.SetError(txtCad, "Campul trebuie completat");
            }

            else if (!FormValidator.NamesValidator(txtCad.Text, "[A-Za-z0-9/]"))
            {
                e.Cancel = true;
                txtCad.Focus(); errorProviderLucrari.SetError(txtCad, "Campul UAT contine caractere invalide");
            }
            else
            {
                e.Cancel = false; errorProviderLucrari.SetError(txtCad, "");
            }
        }

        private void cbAcceptResp_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cbAcceptResp.Text))
            {
                e.Cancel = true;
                cbAcceptResp.Focus(); errorProviderLucrari.SetError(cbAcceptResp, "Selectati o valoare");
            }

            else
            { e.Cancel = false; errorProviderLucrari.SetError(cbAcceptResp, ""); }
        }

        private void cbContract_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cbContract.Text) || cbContract.Text == @"<new..>")
            {
                e.Cancel = true;
                
                cbContract.Focus(); errorProviderLucrari.SetError(cbContract, "Selectati o valoare");
            }
            else
            { e.Cancel = false; errorProviderLucrari.SetError(cbContract, ""); }
        }


        #endregion Fileds Validation Area

    }
}
