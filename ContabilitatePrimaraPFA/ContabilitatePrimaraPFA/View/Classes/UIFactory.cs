using ContabilitatePrimaraPFA.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContabilitatePrimaraPFA
{
    public class UIFactory
    {
        private static Dictionary<string, UserControl> m_dUserControl = new Dictionary<string, UserControl>();

        public static UserControl CreateUI(string uiName)
        {
            if (m_dUserControl.Count == 0)
            {
                m_dUserControl.Add("Lucrari", ucLucrari.GetUILucrari);
                m_dUserControl.Add("Contracte", ucContracte.GetUIContracte);
            }
            return m_dUserControl[uiName];
        }

    }
}
