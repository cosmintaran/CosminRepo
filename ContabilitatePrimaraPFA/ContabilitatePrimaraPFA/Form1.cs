using ContabilitatePrimaraPFA.View.Classes;

namespace ContabilitatePrimaraPFA
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        #region declaration Area
        UserControl _userControl = null;
        //string 
        #endregion
        //Constructor
        public Form1()
        {
            InitializeComponent();
            object init = "Lucrari";
            PaintUserControl(init,null);
            ((View.UserControls.UcLucrari)_userControl).UserControlChanging += PaintUserControl;
        }

        //UserControl changer
        private void PaintUserControl(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            switch(sender.ToString())
            {
                case "Lucrari":
                    _userControl = UiFactory.CreateUi(sender.ToString());
                    break;

                case "Contracte":
                    _userControl = UiFactory.CreateUi(sender.ToString());
                    break;
                default:
                    {
                        var currentUserControl = _userControl.Name;
                       currentUserControl = currentUserControl.Remove(0, 2);
                        var button = sender as Button;
                        if (button != null && button.Text != currentUserControl)
                        {
                            _userControl = UiFactory.CreateUi(((Button) sender).Text);
                                                           
                        }
                    }
                    break;
            }
            
            if (!mainPanel.Controls.Contains(_userControl))
            {
                if (_userControl != null)
                {
                    mainPanel.Controls.Add(_userControl);
                    _userControl.Dock = DockStyle.Fill;
                    _userControl.BringToFront();
                }
            }
            else
            {
                _userControl.BringToFront();
            }
        }
    }
}
