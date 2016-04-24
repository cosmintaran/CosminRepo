namespace ContabilitatePrimaraPFA.UserControls
{
    using System.Windows.Forms;
    using System;
    using Queries.Core.Domain;
    using Queries.Persitence;
    using System.Collections.Generic;

    

    public partial class ucLucrari : UserControl
    {

        public delegate void FormChangedEventHandler(object sender, EventArgs args);
        public event FormChangedEventHandler UserControlChanging;


        #region Declared Members
        private static  ucLucrari m_instance = null;
        private static readonly object padlock = new object();
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
        }
        #endregion

        #region Command region
        private void bttSave_Click (object sender, EventArgs e)
        {


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

        private bool FillCombobox()
        {
           bool isSucceded = true;
            try
            {
                var contaContext = new ContaContext();

                var unitOfWork = new UnitOfWork(contaContext);
                IEnumerable<AcceptataRefuzata> acc = unitOfWork.AcceptateRespinse.GetAll();
                IEnumerable<TipLucrare> tiplucrare = unitOfWork.TipLucrare.GetAll();
                
                foreach (var item in acc)
                    cbAcceptResp.Items.Add(item.Status);

                foreach (var item in tiplucrare)
                    cbTipLucrare.Items.Add(item.Tip_Lucrare);

            }
            catch(Exception ex) { }


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
    }
}
