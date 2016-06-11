using System.Windows.Forms;

namespace View.View.UserControls
{
    public partial class ucOperatiuni : UserControl
    {
        #region Declared Members
        private static ucOperatiuni m_instance = null;
        public static readonly object padlock = new object();
        #endregion

        private ucOperatiuni()
        {
            InitializeComponent();
        }

        #region Init Area
        public static ucOperatiuni GetUiOperatiuni
        {
          get
            {
                lock(padlock)
                {
                    if(m_instance == null)
                        m_instance = new ucOperatiuni();
                }
                return m_instance;
            }
        }
        #endregion

        #region Command region
        #endregion
    }
}
