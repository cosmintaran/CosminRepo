﻿using System.Collections.Generic;
using System.Windows.Forms;
using ContaPFA.View.UserControls;

namespace ContaPFA.View.Classes
{
    public class UiFactory
    {
        private static Dictionary<string, UserControl> _mDUserControl = new Dictionary<string, UserControl>();

        public static UserControl GetUserControl(string uiName)
        {
            if (_mDUserControl.Count != 0) return _mDUserControl[uiName];
            _mDUserControl.Add("Lucrari", UcLucrari.GetUiLucrari);
            _mDUserControl.Add("Contracte", UcContracte.GetUiContracte);
            _mDUserControl.Add("Operatiuni", ucOperatiuni.GetUiOperatiuni);
            return _mDUserControl[uiName];
        }

    }
}
