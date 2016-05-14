namespace ContabilitatePrimaraPFA.View.UserControls
{
    using System.Windows.Forms;
    using System;
    using Queries.Core.Domain;
    using Queries.Persitence;
    using System.Collections.Generic;
    using System.ComponentModel;
    using ContabilitatePrimaraPFA.View.Classes;
    using System.Collections;
    using ContabilitatePrimaraPFA.View.Forms;



    public partial class ucLucrari : UserControl
    {

        public delegate void FormChangedEventHandler(object sender, EventArgs args);
        public event FormChangedEventHandler UserControlChanging;


        #region Declared Members
        private static ucLucrari m_instance = null;
        private static readonly object padlock = new object();
        Lucrare m_lucrare = null;
        #endregion

        #region Init Area
        public static ucLucrari GetUILucrari
        {
            get
            {
                lock (padlock)
                {
                    if (m_instance == null)
                    {
                        m_instance = new ucLucrari();
                    }

                    return m_instance;
                }
            }
        }

        private ucLucrari()
        {
            InitializeComponent();
            FillCombobox();
            FillGridView(DateTime.Today.Year);
        }
        #endregion

        #region Command region

        private void bttSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Lucrare lucrare = null;
                PrepareObject(out lucrare);
                ContaContext con = new ContaContext();
                UnitOfWork unitOfWork = new UnitOfWork(con);
                unitOfWork.Lucrari.Add(lucrare);
                int a = unitOfWork.Complete();
                unitOfWork.Dispose();
                FillGridView(2015);
            }

        }

        private void bttNewLucrare_Click(object sender, EventArgs e)
        {
            if (grBoxLucrare.Enabled == false)
                grBoxLucrare.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bttDeleteLucrari.Enabled == false || bttEditLucrare.Enabled == false)
            {
                bttDeleteLucrari.Enabled = true;
                bttEditLucrare.Enabled = true;
            }
        }

        private void bttClearlucrare_Click(object sender, EventArgs e)
        {
            cbAcceptResp.SelectedIndex = -1;
            cbContract.SelectedIndex = -1;
            cbReceptionatRespins.SelectedIndex = -1;
            cbTipLucrare.SelectedIndex = -1;
            txtAvizator.Text = "";
            txtCad.Text = "";
            txtDoc.Text = "";
            txtInreg.Text = "";
            txtObservatii.Text = "";
            txtUAT.Text = "";
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            var form = CautaLucrari.GetCautaLucrariForm;
            form.Show();
        }

        private void LucrariView_CellContentDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = null;
            foreach (DataGridViewRow iterator in LucrariView.SelectedRows)
            {
                row = iterator;
            }

            if (row != null) //daca randul este gol sau nu exista nu face nimic
            {
                ContaContext conta = new ContaContext();
                var unitOfWork = new UnitOfWork(conta);

                int id =(int)row.Cells["LucrareId"].Value;

                if(id > 0) 
                {
                    m_lucrare = unitOfWork.Lucrari.Get(id);

                    cbAcceptResp.SelectedItem = unitOfWork.AcceptateRespinse.Get(m_lucrare.AcceptataRefuzataId).StatusAccept;
                    cbReceptionatRespins.SelectedItem = unitOfWork.ReceptionateRespinse.Get(m_lucrare.ReceptionatRespinsId).StatusRec;
                    cbTipLucrare.SelectedIndex = (int)m_lucrare.TipLucrareId - 1;
                    int ctr = cbContract.SelectedIndex;
                    cbContract.SelectedText = unitOfWork.Contracte.Get((int)m_lucrare.ContractId).NrContract;
                    txtInreg.Text = m_lucrare.Nr_OCPI.ToString();
                    dateTimePickerInreg.Value = (DateTime)m_lucrare.DataInregistrare;
                    dateTimePickerTermen.Value = (DateTime)m_lucrare.TermenSolutionare;
                    txtDoc.Text = m_lucrare.Nr_Proiect.ToString();
                    txtAvizator.Text = m_lucrare.AvizatorRegistrator;
                    txtUAT.Text = m_lucrare.UAT;

                    if (bttNewLucrare.Enabled == true)
                        bttNewLucrare.Enabled = false;

                    if (bttEditLucrare.Enabled == false)
                        bttEditLucrare.Enabled = true;

                    if (bttDeleteLucrari.Enabled == false)
                        bttDeleteLucrari.Enabled = true;

                    if (grBoxLucrare.Enabled == false)
                        grBoxLucrare.Enabled = true;

                    if (bttSave.Enabled == true)
                        bttSave.Enabled = false;

                    unitOfWork.Dispose();
                    conta.Dispose();

                }
            }

        }

        #endregion

        # region Logical Area

        private bool FillCombobox()
        {
            bool isSucceded = true;
            try
            {
                BindingSource bindAcceptrefuz = new BindingSource();
                BindingSource bindTipLucrare = new BindingSource();
                BindingSource bindRecResp = new BindingSource();
                BindingSource bindContract = new BindingSource();

                var contaContext = new ContaContext();
                var unitOfWork = new UnitOfWork(contaContext);

                bindAcceptrefuz.DataSource = unitOfWork.AcceptateRespinse.GetAll();
                cbAcceptResp.DataSource = bindAcceptrefuz;
                cbAcceptResp.DisplayMember = "StatusAccept";

                bindTipLucrare.DataSource = unitOfWork.TipLucrare.GetAll();
                cbTipLucrare.DataSource = bindTipLucrare;
                cbTipLucrare.DisplayMember = "TipLucrare1";

                bindRecResp.DataSource = unitOfWork.ReceptionateRespinse.GetAll();
                cbReceptionatRespins.DataSource = bindRecResp;
                cbReceptionatRespins.DisplayMember = "StatusRec";

                bindContract.DataSource = unitOfWork.Contracte.GetContractsByYear(DateTime.Today.Year);
                bindContract.Add(new Contract { NrContract = "<new...>" });
                cbContract.DataSource = bindContract;
                cbContract.DisplayMember = "NrContract";

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error initializing fields", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            return isSucceded;
        }

        private bool FillGridView(int year)
        {
            bool isSucceded = true;
            try
            {
                ContaContext conta = new ContaContext();
                UnitOfWork unityOfWork = new UnitOfWork(conta);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = unityOfWork.Lucrari.GetLucrariForGridView(DateTime.Today.Year);
                LucrariView.DataSource = bindingSource;
                LucrariView.Columns["LucrareId"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return isSucceded;
        }

        private void cbContract_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((cbContract.SelectedItem as Contract).NrContract == "<new...>")
            {
                ChangeForm("Contracte");
            }
        }

        protected virtual void ChangeForm(string formName)
        {
            if (UserControlChanging != null)
                UserControlChanging(formName, EventArgs.Empty);
        }

        private void PrepareObject(out Lucrare lucrare)
        {
            lucrare = new Lucrare();
            try
            {

                lucrare.AcceptataRefuzataId = (cbAcceptResp.SelectedItem as AcceptataRefuzata).AcceptataRefuzataId;
                lucrare.ContractId = (cbContract.SelectedItem as Contract).ContractId;
                lucrare.ReceptionatRespinsId = (cbReceptionatRespins.SelectedItem as ReceptionatRespins).ReceptionatRespinsId;
                lucrare.TipLucrareId = (cbTipLucrare.SelectedItem as TipLucrare).TipLucrareId;
                lucrare.AvizatorRegistrator = txtAvizator.Text;
                lucrare.DataInregistrare = dateTimePickerInreg.Value;
                lucrare.Nr_Proiect = txtDoc.Text;
                lucrare.Nr_OCPI = txtInreg.Text;
                lucrare.TermenSolutionare = dateTimePickerTermen.Value;
                lucrare.UAT = txtUAT.Text;
                lucrare.AnProiect = DateTime.Now.Year.ToString();

            }
            catch (Exception ex) {/*TODO trateaza exceptia*/}
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
                /*e.Cancel = true*/
                ; txtInreg.Focus(); errorProviderLucrari.SetError(txtInreg, "Campul contine caractere invalide");
            }
            else { e.Cancel = false; errorProviderLucrari.SetError(txtInreg, ""); }
        }

        private void txtUAT_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUAT.Text))
            {
                /*e.Cancel = true*/
                ; txtUAT.Focus(); errorProviderLucrari.SetError(txtUAT, "Campul UAT trebuie completat");
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

        private void cbTipLucrare_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cbTipLucrare.Text))
            {
                /*e.Cancel = true;*/
                cbTipLucrare.Focus(); errorProviderLucrari.SetError(cbTipLucrare, "Selectati o valoare");
            }

            else
            { e.Cancel = false; errorProviderLucrari.SetError(cbTipLucrare, ""); }
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
            if (String.IsNullOrEmpty(cbContract.Text) || cbContract.Text == "<new..>")
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
