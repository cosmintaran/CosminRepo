
namespace ContabilitatePrimaraPFA.UserControls
{
    using System.Windows.Forms;

    public partial class ucContracte : UserControl
    {
        private static ucContracte m_Contracte = null;
        private static readonly object padlock = new object();

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
    }
}
