using System.Windows.Forms;

namespace ContaPFA.View.Forms
{
    public partial class AppHelp : Form
    {

        private static readonly object padlock = new object();
        private static AppHelp _instance;
        private AppHelp()
        {
            InitializeComponent();
        }

        public static AppHelp ShowAppHelp
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                        _instance = new AppHelp();
                }
                return _instance;
            }
        }
    }
}
