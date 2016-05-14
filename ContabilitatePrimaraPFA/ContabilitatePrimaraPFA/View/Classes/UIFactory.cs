namespace ContabilitatePrimaraPFA
{
    using ContabilitatePrimaraPFA.View.UserControls;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public class UIFactory
    {
        private static Dictionary<string, UserControl> m_dUserControl = new Dictionary<string, UserControl>();

        public static UserControl CreateUI(string uiName)
        {
            if (m_dUserControl.Count == 0)
            {
                m_dUserControl.Add("Lucrari", ucLucrari.GetUILucrari);
                m_dUserControl.Add("Contracte", ucContracte.GetUIContracte);
                m_dUserControl.Add("Facturi", ucFacturi.GetUIFacturi);
            }
            return m_dUserControl[uiName];
        }

    }
}
