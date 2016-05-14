namespace ContabilitatePrimaraPFA.View.UserControls
{
    using System.Windows.Forms;

    public partial class ucContracte : UserControl
    {
        #region Declared Members
        private static ucContracte m_Contracte = null;
        private static readonly object padlock = new object();
        #endregion

        #region Init Area
        public static ucContracte GetUIContracte
        {
            get
            {
                lock(padlock)
                {
                    if (m_Contracte == null)
                    {
                        m_Contracte = new ucContracte();
                    }
                    return m_Contracte;
                }
            }
            
        }
        private ucContracte()
        {
            InitializeComponent();
        }
        #endregion



    }
}
