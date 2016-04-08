namespace ContabilitatePrimaraPFA.UserControls
{
    using System.Windows.Forms;
    public partial class ucLucrari : UserControl
    {

        private static  ucLucrari m_instance = null;
        private static readonly object padlock = new object();
       
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
    }
}
