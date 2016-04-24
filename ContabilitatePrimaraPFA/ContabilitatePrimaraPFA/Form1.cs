namespace ContabilitatePrimaraPFA
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        UserControl userControl = null;

        //Constructor
        public Form1()
        {
            InitializeComponent();
            object init = "Lucrari";
            PaintUserControl(init,null);
            ((UserControls.ucLucrari)userControl).UserControlChanging += this.PaintUserControl;
        }

        //UserControl changer
        private void PaintUserControl(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            switch(sender.ToString())
            {
                case "Lucrari":
                    userControl = UIFactory.CreateUI(sender.ToString());
                    break;

                case "Contracte":
                    userControl = UIFactory.CreateUI(sender.ToString());
                    break;
                default:
                    {
                        string currentUserControl = userControl.Name;
                       currentUserControl = currentUserControl.Remove(0, 2);
                        if ((sender as Button).Text != currentUserControl)
                        {
                            userControl = UIFactory.CreateUI((sender as Button).Text);
                                                           
                        }
                    }
                    break;
            }
            
            if (!mainPanel.Controls.Contains(userControl))
            {
                if (userControl != null)
                {
                    mainPanel.Controls.Add(userControl);
                    userControl.Dock = DockStyle.Fill;
                    userControl.BringToFront();
                }
            }
            else
            {
                userControl.BringToFront();
            }
        }
    }
}
