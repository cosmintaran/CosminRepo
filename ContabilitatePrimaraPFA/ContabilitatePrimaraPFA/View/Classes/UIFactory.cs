
namespace ContabilitatePrimaraPFA.View.Classes
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using UserControls;

    public class UiFactory
    {
        private static Dictionary<string, UserControl> _mDUserControl = new Dictionary<string, UserControl>();

        public static UserControl CreateUi(string uiName)
        {
            if (_mDUserControl.Count != 0) return _mDUserControl[uiName];
            _mDUserControl.Add("Lucrari", UcLucrari.GetUiLucrari);
            _mDUserControl.Add("Contracte", UcContracte.GetUiContracte);
            _mDUserControl.Add("Facturi", ucFacturi.GetUIFacturi);
            return _mDUserControl[uiName];
        }

    }
}
