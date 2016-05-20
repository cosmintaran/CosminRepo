using System;
using System.Data.Entity;
using System.Windows.Forms;
using View.View.Classes;
using Queries.Persitence;
using View.View.UserControls;

namespace View
{
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
            Database.SetInitializer<ContaContext>(new ContaContextSeeder());
            object init = "Lucrari";
            PaintUserControl(init,null);
            ((UcLucrari)_userControl).UserControlChanging += PaintUserControl;

        }

        //UserControl changer
        private void PaintUserControl(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            switch(sender.ToString())
            {
                case "Lucrari":
                    _userControl = UiFactory.GetUserControl(sender.ToString());
                    break;

                case "Contracte":
                    _userControl = UiFactory.GetUserControl(sender.ToString());
                    break;
                default:
                    {
                        var currentUserControl = _userControl.Name;
                       currentUserControl = currentUserControl.Remove(0, 2);
                        var button = sender as Button;
                        if (button != null && button.Text != currentUserControl)
                        {
                            _userControl = UiFactory.GetUserControl(((Button) sender).Text);
                                                           
                        }
                    }
                    break;
            }
            
            if (!mainPanel.Controls.Contains(_userControl))
            {
                if (_userControl == null) return;
                mainPanel.Controls.Add(_userControl);
                _userControl.Dock = DockStyle.Fill;
                _userControl.BringToFront();
            }
            else
            {
                _userControl.BringToFront();
            }
        }
    }
}
