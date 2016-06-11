
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using ContabilitatePrimaraPFA.View.Classes;
using ContabilitatePrimaraPFA.View.Forms;
using Queries.Core.Domain;
using Queries.Persitence;
using View.View.Forms;
using View.View.Classes;

namespace View.View.UserControls
{
    public partial class UcLucrari : UserControl
    {

        //public delegate void FormChangedEventHandler(object sender, EventArgs args);
        //public event FormChangedEventHandler UserControlChanging;
         public EventHandler<UserControlEventArgs> UserControlChanging;

        #region Declared Members
        private static UcLucrari _mInstance;
        private UcContracte _mContracte;
        private static readonly object Padlock = new object();
        private Lucrare _lucrare;
        private FilterCriteria _filter = FilterCriteria.None;
        private string _filterKeyWordS;
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
            FillGridView(_filter, DateTime.Today.Year.ToString());
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

            IList<Lucrare> checkIfIsExist = (IList<Lucrare>)unitOfWork.Lucrari.GetLucrariByNumberAndYear(_lucrare.NrProiect, DateTime.Today);
            if (checkIfIsExist == null || checkIfIsExist.Count > 0)
            {
                MessageBox.Show(@"Documentatia cu numarul " + _lucrare.NrProiect +@"/" +_lucrare.AnProiect+ @" exista deja.",
                    @"Eroare la salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDoc.Text = "";
                return;
            }

            unitOfWork.Lucrari.Add(_lucrare);
            unitOfWork.Complete();
            unitOfWork.Dispose();
            FillGridView(_filter, _filterKeyWordS);

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
            Dictionary<string,FilterCriteria> mDictionary = new Dictionary<string, FilterCriteria>
            {
                {"None",FilterCriteria.None} ,{"An Documentatie",FilterCriteria.An},{ "Nr. Documentatie", FilterCriteria.NrDoc}, 
                { "Nume Beneficiar",FilterCriteria.NumeBeneficiar},{ "C.N.P. Beneficiar",FilterCriteria.CnpBeneficiar},
                { "Cod Documentatie",FilterCriteria.TipDoc},{ "Nr. Contract",FilterCriteria.NrContract},{"U.A.T.",FilterCriteria.Uat},
                { "Receptionate",FilterCriteria.Receptionata},{ "Respinse",FilterCriteria.Respinsa}, {"In Lucru",FilterCriteria.InLucru}};

            FilterForm sel = FilterForm.GetCautaForm(mDictionary);
            var result = sel.ShowDialog();
            if (result != DialogResult.OK) return;
             _filterKeyWordS = sel.SearchKey;
           // if (string.IsNullOrEmpty(_filterKeyWordS)) return;
            _filter = sel.FilterCriteria;
            FillGridView(_filter, _filterKeyWordS);
            if (IsFilterd())
            {
                lblFilter.Text = @"Filter On";
                lblFilter.Font = new System.Drawing.Font(lblFilter.Font, System.Drawing.FontStyle.Bold);
            }
            else
            {
                lblFilter.Text = "";
            }
                
                           
            
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

            unitOfWork.Dispose();
            conta.Dispose();

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
                try
                {
                    unityOfWork.Lucrari.Remove(lucrare);
                    unityOfWork.Complete();
                    unityOfWork.Dispose();
                    contaContext.Dispose();
                    bttDeleteLucrari.Enabled = false;
                    FillGridView(_filter, DateTime.Now.Year.ToString());
                }
                catch (DbUpdateException)
                {
                    // ReSharper disable once LocalizableElement
                    MessageBox.Show("Documentatie este folosit de o alta intrare din baza de date.\nStergere refuzata", @"Eroare stergere contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, @"Eroare stergere contract", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
            FillGridView(_filter, DateTime.Today.Year.ToString());

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

        protected virtual void ChangeForm(string formName)
        {
            if (_mContracte == null)
            {
                _mContracte = UiFactory.GetUserControl("Contracte") as UcContracte;
                if (_mContracte != null) _mContracte.ReturnFromContracteEventHandler += CallBackFromContracte;
            }

            UserControlChanging?.Invoke(formName,new UserControlEventArgs() {UsControl = this });
        }
        #endregion

        # region Logical Area

        private void FillCombobox()
        {
            try
            {
                var bindAcceptrefuz = new BindingSource();
                var bindRecResp = new BindingSource();
                //var bindContract = new BindingSource();

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
               /* bindContract.DataSource = unitOfWork.Contracte.GetContractByYear(DateTime.Today.Year);
                bindContract.Add(new Contract { NrContract = "<new...>" });
                cbContract.DataSource = bindContract;
                cbContract.DisplayMember = "NrContract";*/
                var listOfContracts = unitOfWork.Contracte.GetContractByYear(DateTime.Today.Year);              
                foreach (var item in listOfContracts)
                {
                    cbContract.Items.Add(item);
                }
               // cbContract.Items.Add(new Contract { NrContract = "<new...>" });
                cbContract.DisplayMember = "NrContract"; 
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, @"Error initializing fields", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void FillGridView(FilterCriteria criteria, string key)
        {
            try
            {
                ContaContext conta = new ContaContext();
                UnitOfWork unityOfWork = new UnitOfWork(conta);

                BindingSource bindingSource;

                #region Switch 
                switch (criteria)
                {
                    case FilterCriteria.An:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByYear(key) };
                        break;
                    case FilterCriteria.CnpBeneficiar:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByBeneficiarName(key) };
                        break;
                    case FilterCriteria.NrContract:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrareByContract(key) }; 
                        break;
                    case FilterCriteria.NrDoc:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByNrDocumentatie(key) };
                        break;
                    case FilterCriteria.NumeBeneficiar:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByBeneficiarName(key) };
                        break;

                    case FilterCriteria.TipDoc:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByCodLucrare(key) };
                        break;
                    case FilterCriteria.Uat:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByUat(key) };
                        break;
                    case FilterCriteria.Receptionata:
                    case FilterCriteria.Respinsa:
                    case FilterCriteria.InLucru:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByStatusOcpi(key) };
                        break;
                                          
                    default:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrari() };
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
                    var dataGridViewColumn = LucrariView.Columns["Current"];
                    if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
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
            if (contract == null || contract.NrContract == "<new...>")
            {
                ChangeForm("Contracte");
            }
        }

        private void PrepareObject()
        {
            var acceptataRefuzata = cbAcceptResp.SelectedItem as AcceptataRefuzata;
            if (acceptataRefuzata != null)
                _lucrare.AcceptataRefuzataId = acceptataRefuzata.AcceptataRefuzataId;

            _lucrare.Nr_OCPI = txtInreg.Text.Trim();
            _lucrare.DataInregistrare = dateTimePickerInreg.Value;
            _lucrare.TermenSolutionare = dateTimePickerTermen.Value;
            _lucrare.AvizatorRegistrator = txtAvizator.Text.Trim();
            //TipLucrare din form SelectTipLucrare initializam doar cu val default
            if (_lucrare.TipLucrareId == null || _lucrare.TipLucrareId <= 0)
                _lucrare.TipLucrareId = 1; // Id 1 None     
            _lucrare.NrProiect = txtDoc.Text.Trim();
            _lucrare.AnProiect = DateTime.Now.Year.ToString().Trim();
            _lucrare.CadTop = txtCad.Text.Trim();
            _lucrare.UAT = txtUAT.Text.Trim();

            var contract = cbContract.SelectedItem as Contract;
            if (contract != null)
                _lucrare.ContractId = contract.ContractId;

            var receptionatRespins = cbReceptionatRespins.SelectedItem as ReceptionatRespins;
            if (receptionatRespins != null)
                _lucrare.ReceptionatRespinsId = receptionatRespins.ReceptionatRespinsId;

            _lucrare.Observatii = txtObservatii.Text.Trim();
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

        private bool IsFilterd()
        {
            bool isFiltred = _filter != FilterCriteria.None;
            return isFiltred;
        }

        private void CallBackFromContracte(object sender, UserControlEventArgs arg)
        {
            FillCombobox();
            ChangeForm(sender.ToString());
            if (_mContracte == null) return;
            _mContracte.ReturnFromContracteEventHandler -= CallBackFromContracte;
            _mContracte = null;
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
            if (String.IsNullOrEmpty(cbContract.Text) || cbContract.Text == @"<new...>")
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
