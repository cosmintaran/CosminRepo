namespace ContabilitatePrimaraPFA.UserControls
{
    using System.Windows.Forms;
    using System;
    using Queries.Core.Domain;
    using Queries.Persitence;
    using System.Collections.Generic;
    using System.ComponentModel;
    using ContabilitatePrimaraPFA.View.Classes;
using System.Collections;

    

    public partial class ucLucrari : UserControl
    {

        public delegate void FormChangedEventHandler(object sender, EventArgs args);
        public event FormChangedEventHandler UserControlChanging;


        #region Declared Members
        private static  ucLucrari m_instance = null;
        private static readonly object padlock = new object();
        IEnumerable<AcceptataRefuzata> m_AcceptRefuz;
        IEnumerable<TipLucrare> m_TipLucrare;
        IEnumerable<ReceptionatRespins> m_RecResp;
        IEnumerable<Contract> m_Contract;
        #endregion

        #region Init Area
        public  static ucLucrari GetUILucrari 
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

        private void bttSave_Click (object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                Lucrare lucrare = null;
                PrepareObject(out lucrare);
            }

        }        
        
        private void bttNewLucrare_Click (object sender, EventArgs e)
         {
             if (grBoxLucrare.Enabled == false)
                 grBoxLucrare.Enabled = true;
         }

        private void listView1_SelectedIndexChanged (object sender, EventArgs e)
         {
             if (bttDeleteLucrari.Enabled == false || bttEditLucrare.Enabled == false)
             {
                 bttDeleteLucrari.Enabled = true;
                 bttEditLucrare.Enabled = true;
             }                 
         }

        private void bttClearlucrare_Click (object sender, EventArgs e)
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

        #endregion

        # region Logical Area

        private bool FillCombobox()
        {
           bool isSucceded = true;
            try
            {
                var contaContext = new ContaContext();

                var unitOfWork = new UnitOfWork(contaContext);
                m_AcceptRefuz = unitOfWork.AcceptateRespinse.GetAll();
                m_TipLucrare = unitOfWork.TipLucrare.GetAll();
                m_RecResp = unitOfWork.ReceptionateRespinse.GetAll();
                m_Contract = unitOfWork.Contracte.GetContractsByYear(DateTime.Today.Year);
                foreach (var item in m_AcceptRefuz)
                    cbAcceptResp.Items.Add(item.Status);

                foreach (var item in m_TipLucrare)
                    cbTipLucrare.Items.Add(item.Tip_Lucrare);

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
                bindingSource.DataSource = unityOfWork.Lucrari.GetLucrariForView(DateTime.Today.Year);
                LucrariView.DataSource = bindingSource;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return isSucceded;
        }

        private void cbContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbContract.SelectedItem.ToString() == "<new...>")
            {
                ChangeForm("Contracte");
            }
        }

        protected virtual void ChangeForm(string formName)
        {
            if(UserControlChanging != null)         
                UserControlChanging(formName, EventArgs.Empty);
        }

        private void PrepareObject(out Lucrare lucrare)
        {
            lucrare = new Lucrare();
            foreach(var item in m_AcceptRefuz)
            {
                if (item.Status.ToString() == cbAcceptResp.Text)
                    lucrare.AcceptataRefuzataId = item.AcceptataRefuzataId;
            }

            foreach(var item in m_RecResp)
            {
                if (item.Status == cbReceptionatRespins.Text)
                    lucrare.Receptionat_Respins = item.ReceptionatRespinsId;
            }
            
            foreach(var item in m_TipLucrare)
            {
                if (item.Tip_Lucrare == cbTipLucrare.Text)
                    lucrare.TipLucrareId = item.TipLucrareId;
            }

            //foreach()
        }

        #endregion

        #region Fileds Validation Area

        private void txtDoc_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtDoc.Text))
            {
                e.Cancel = true; txtDoc.Focus(); errorProviderLucrari.SetError(txtDoc, "Campul Nr. Documentatie trebuie completat");
            }

            else if (!FormValidator.NamesValidator(txtDoc.Text, "[A-Za-z0-9]"))
            {
                e.Cancel = false; txtDoc.Focus(); errorProviderLucrari.SetError(txtDoc, "Campul contine caractere invalide");
            }
            else
            {
                e.Cancel = false; errorProviderLucrari.SetError(txtDoc, "");
            }
        }

        private void txtInreg_Validating(object sender, CancelEventArgs e)
        {
            if (FormValidator.NamesValidator(txtInreg.Text, "[0-9]"))
            {
                e.Cancel = true; txtInreg.Focus(); errorProviderLucrari.SetError(txtInreg, "Campul contine caractere invalide");
            }
            else { e.Cancel = false; errorProviderLucrari.SetError(txtInreg, ""); }
        }

        private void txtUAT_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(txtUAT.Text))
            {
                e.Cancel = true; txtUAT.Focus(); errorProviderLucrari.SetError(txtUAT, "Campul UAT trebuie completat");
            }

            else if(!FormValidator.NamesValidator(txtUAT.Text,"[A-Za-z]"))
            {
                e.Cancel = true; txtUAT.Focus(); errorProviderLucrari.SetError(txtUAT, "Campul UAT contine caractere invalide");
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
                e.Cancel = true; txtCad.Focus(); errorProviderLucrari.SetError(txtCad, "Campul trebuie completat");
            }

            else if (!FormValidator.NamesValidator(txtCad.Text, "[A-Za-z0-9/]"))
            {
                e.Cancel = true; txtCad.Focus(); errorProviderLucrari.SetError(txtCad, "Campul UAT contine caractere invalide");
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
                e.Cancel = true; cbTipLucrare.Focus(); errorProviderLucrari.SetError(cbTipLucrare, "Selectati o valoare");
            }

            else
            { e.Cancel = false; errorProviderLucrari.SetError(cbTipLucrare, ""); }
        }

        private void cbAcceptResp_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cbAcceptResp.Text))
            {
                e.Cancel = true; cbAcceptResp.Focus(); errorProviderLucrari.SetError(cbAcceptResp, "Selectati o valoare");
            }

            else
            { e.Cancel = false; errorProviderLucrari.SetError(cbAcceptResp, ""); }
        }

        private void cbContract_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cbContract.Text) || cbContract.Text == "<new..>")
            {
                e.Cancel = true; cbContract.Focus(); errorProviderLucrari.SetError(cbContract, "Selectati o valoare");
            }
            else
            { e.Cancel = true; errorProviderLucrari.SetError(cbContract, ""); }
        }

        #endregion Fileds Validation Area       
        
    }
}
