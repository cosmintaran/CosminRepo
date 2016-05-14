namespace ContabilitatePrimaraPFA.View.UserControls
{
    using System.Windows.Forms;

    public partial class ucFacturi : UserControl
    {
        #region Declared Members
        private static ucFacturi m_instance = null;
        public static readonly object padlock = new object();
        #endregion

        private ucFacturi()
        {
            InitializeComponent();
        }

        #region Init Area
        public static ucFacturi GetUIFacturi
        {
          get
            {
                lock(padlock)
                {
                    if(m_instance == null)
                        m_instance = new ucFacturi();
                }
                return m_instance;
            }
        }
        #endregion

        #region Command region
        #endregion
    }
}
