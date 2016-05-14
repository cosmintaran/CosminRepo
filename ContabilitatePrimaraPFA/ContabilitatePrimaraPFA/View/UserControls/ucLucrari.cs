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
        private Lucrare _oldLucrare;
        private Lucrare _newLucrare;

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
            _newLucrare = new Lucrare();
            FillCombobox();
            FillGridView(DateTime.Today.Year.ToString());
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
            unitOfWork.Lucrari.Add(_newLucrare);
            unitOfWork.Complete();
            unitOfWork.Dispose();
            FillGridView(DateTime.Today.Year.ToString());
        }

        private void bttNewLucrare_Click(object sender, EventArgs e)
        {
            if (grBoxLucrare.Enabled == false)
                grBoxLucrare.Enabled = true;
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
            var form = CautaLucrari.GetCautaLucrariForm;
            form.Show();
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

            int id = 0;
            if(row.Index > 0)
                id = (int)row.Cells["LucrareId"].Value;

            if (id <= 0) return;
            _oldLucrare = unitOfWork.Lucrari.Get(id);

            int sStatusAccept = unitOfWork.AcceptateRespinse.Get(_oldLucrare.AcceptataRefuzataId).AcceptataRefuzataId;
            if (--sStatusAccept >= 0)
                cbAcceptResp.SelectedIndex = sStatusAccept;

            int sStatusRec = unitOfWork.ReceptionateRespinse.Get(_oldLucrare.ReceptionatRespinsId).ReceptionatRespinsId;
            if(--sStatusRec >= 0)
                cbReceptionatRespins.SelectedItem = sStatusRec;

            if (_oldLucrare.ContractId != null)
                cbContract.SelectedText = unitOfWork.Contracte.Get((int)_oldLucrare.ContractId).NrContract;

            if (_oldLucrare.DataInregistrare != null)
                dateTimePickerInreg.Value = (DateTime)_oldLucrare.DataInregistrare;

            if (_oldLucrare.TermenSolutionare != null)
                dateTimePickerTermen.Value = (DateTime)_oldLucrare.TermenSolutionare;

            txtInreg.Text = _oldLucrare.Nr_OCPI;
            txtDoc.Text = _oldLucrare.NrProiect;
            txtAvizator.Text = _oldLucrare.AvizatorRegistrator;
            txtUAT.Text = _oldLucrare.UAT;
            txtObservatii.Text = _oldLucrare.Observatii;
            txtCad.Text = _oldLucrare.CadTop;

            if (bttNewLucrare.Enabled)
                bttNewLucrare.Enabled = false;

            if (!grBoxLucrare.Enabled)
                grBoxLucrare.Enabled = true;

            unitOfWork.Dispose();
            conta.Dispose();
        }

        private void bttTipLucrare_Click(object sender, EventArgs e)
        {
            using (SelectTipLucrari sel = new SelectTipLucrari())
            {
                var result = sel.ShowDialog();
                if (result != DialogResult.OK) return;
                _newLucrare.TipLucrareId = sel.SelectedCodLucrare;
            }

        }

        private void bttDeleteLucrari_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            foreach (DataGridViewRow iterator in LucrariView.SelectedRows)
            {
                selectedRow = iterator;
            }
            if (selectedRow != null)
            {
                var id = (int?) selectedRow.Cells["LucrareId"].Value;
                if (id == null) return;
                ContaContext contaContext = new ContaContext();
                UnitOfWork unityOfWork = new UnitOfWork(contaContext);
                Lucrare lucrare = unityOfWork.Lucrari.Get((int)id);
                unityOfWork.Lucrari.Remove(lucrare);
                unityOfWork.Complete();
                unityOfWork.Dispose();
            }
            bttDeleteLucrari.Enabled = false;
            FillGridView(DateTime.Now.Year.ToString());
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
                bindContract.DataSource = unitOfWork.Contracte.GetContractsByYear(DateTime.Today.Year);
                bindContract.Add(new Contract { NrContract = "<new...>" });
                cbContract.DataSource = bindContract;
                cbContract.DisplayMember = "NrContract";

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, @"Error initializing fields", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void FillGridView(string year)
        {

            try
            {
                ContaContext conta = new ContaContext();
                UnitOfWork unityOfWork = new UnitOfWork(conta);
                BindingSource bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByYear(year) };
                LucrariView.DataSource = bindingSource;
                var dataGridViewColumn = LucrariView.Columns["LucrareId"];
                if (dataGridViewColumn != null)
                    dataGridViewColumn.Visible = false;
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
                _newLucrare.AcceptataRefuzataId = acceptataRefuzata.AcceptataRefuzataId;

            _newLucrare.Nr_OCPI = txtInreg.Text;
            _newLucrare.DataInregistrare = dateTimePickerInreg.Value;
            _newLucrare.TermenSolutionare = dateTimePickerTermen.Value;
            _newLucrare.AvizatorRegistrator = txtAvizator.Text;
            //TipLucrare din form SelectTipLucrare
            _newLucrare.NrProiect = txtDoc.Text;
            _newLucrare.AnProiect = DateTime.Now.Year.ToString();
            _newLucrare.CadTop = txtCad.Text;
            _newLucrare.UAT = txtUAT.Text;

            var contract = cbContract.SelectedItem as Contract;
            if (contract != null)
                _newLucrare.ContractId = contract.ContractId;

            var receptionatRespins = cbReceptionatRespins.SelectedItem as ReceptionatRespins;
            if (receptionatRespins != null)
                _newLucrare.ReceptionatRespinsId = receptionatRespins.ReceptionatRespinsId;

            _newLucrare.Observatii = txtObservatii.Text;
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
                /*e.Cancel = true;*/
                txtDoc.Focus(); errorProviderLucrari.SetError(txtDoc, "Campul Nr. Documentatie trebuie completat");
            }

            else if (!FormValidator.NamesValidator(txtDoc.Text, "[A-Za-z0-9]"))
            {
                /*e.Cancel = false;*/
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
                /*e.Cancel = true;*/
                txtInreg.Focus(); errorProviderLucrari.SetError(txtInreg, "Campul contine caractere invalide");
            }
            else { e.Cancel = false; errorProviderLucrari.SetError(txtInreg, ""); }
        }

        private void txtUAT_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUAT.Text))
            {
                /*e.Cancel = true;*/
                txtUAT.Focus(); errorProviderLucrari.SetError(txtUAT, "Campul UAT trebuie completat");
            }

            else if (!FormValidator.NamesValidator(txtUAT.Text, "[A-Za-z]"))
            {
                /*e.Cancel = true;*/
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
                /*e.Cancel = true;*/
                txtCad.Focus(); errorProviderLucrari.SetError(txtCad, "Campul trebuie completat");
            }

            else if (!FormValidator.NamesValidator(txtCad.Text, "[A-Za-z0-9/]"))
            {
                /*e.Cancel = true;*/
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
                /*e.Cancel = true;*/
                cbAcceptResp.Focus(); errorProviderLucrari.SetError(cbAcceptResp, "Selectati o valoare");
            }

            else
            { e.Cancel = false; errorProviderLucrari.SetError(cbAcceptResp, ""); }
        }

        private void cbContract_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cbContract.Text) || cbContract.Text == @"<new..>")
            {
                /*e.Cancel = true;*/
                cbContract.Focus(); errorProviderLucrari.SetError(cbContract, "Selectati o valoare");
            }
            else
            { e.Cancel = false; errorProviderLucrari.SetError(cbContract, ""); }
        }

        #endregion Fileds Validation Area


    }
}
