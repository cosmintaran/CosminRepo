namespace ContabilitatePrimaraPFA.UserControls
{
    using System.Windows.Forms;
    using System;
    using System.Collections.Generic;
    using ContabilitatePrimaraPFA.Controller;

    public partial class ucLucrari : UserControl
    {

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
            
        }
        #endregion

        #region Command region
        private void bttSave_Click (object sender, System.EventArgs e)
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
    }
}
