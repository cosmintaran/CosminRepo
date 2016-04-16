namespace ContabilitatePrimaraPFA
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        UserControl luc = null;
        public Form1()
        {
            InitializeComponent();
            Object init = "Lucrari";
            PaintUserControl(init,null);
        }

        private void PaintUserControl(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            switch(sender.ToString())
            {
                case "Lucrari":
                    luc = UIFactory.CreateUI(sender.ToString());
                    break;
                default:
                    {
                        string currentUserControl = luc.Name;
                       currentUserControl = currentUserControl.Remove(0, 2);
                        if ((sender as Button).Text != currentUserControl)
                            luc = UIFactory.CreateUI((sender as Button).Text);
                    }
                    break;
            }
            
            if (!mainPanel.Controls.Contains(luc))
            {
                if (luc != null)
                {
                    mainPanel.Controls.Add(luc);
                    luc.Dock = DockStyle.Fill;
                    luc.BringToFront();
                }
            }
            else
            {
                luc.BringToFront();
            }
        }
    }
}
