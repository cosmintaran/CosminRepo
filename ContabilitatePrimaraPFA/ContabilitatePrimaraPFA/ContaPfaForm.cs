﻿using System;
using System.Data.Entity;
using System.Windows.Forms;
using ContaPFA.View.Classes;
using ContaPFA.View.UserControls;
using Queries.Persitence;
using ContaPFA.View.Forms;

namespace ContaPFA
{
    public partial class ContaPfaForm : Form
    {
        #region declaration Area
        UserControl _userControl;
        //string 
        #endregion
        //Constructor
        public ContaPfaForm()
        {
            InitializeComponent();
            Database.SetInitializer<ContaContext>(new ContaContextSeeder());
            GetBNR();
            object init = "Lucrari";
            PaintUserControl(init, null);
            ((UcLucrari)_userControl).UserControlChanging += PaintUserControl;

        }

        //UserControl changer
        private void PaintUserControl(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            switch (sender.ToString())
            {
                case "Lucrari":
                    _userControl = UiFactory.GetUserControl(sender.ToString());
                    break;

                case "Contracte":
                    _userControl = UiFactory.GetUserControl(sender.ToString());
                    break;

                case "Operatiuni":
                    _userControl = UiFactory.GetUserControl(sender.ToString());
                    break;
                default:
                    {
                        var currentUserControl = _userControl.Name;
                        currentUserControl = currentUserControl.Remove(0, 2);
                        var button = sender as Button;
                        if (button != null && button.Text != currentUserControl)
                        {
                            _userControl = UiFactory.GetUserControl(((Button)sender).Text);

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

        private void GetBNR()
        {
            try
            {
                Currency valute = Currency.None;
                valute |= Currency.EUR;
                valute |= Currency.USD;
                var curs = new CursBNR("http://www.bnr.ro/nbrfxrates.xml");
                var content = curs.GetCurrentExchangeRate(valute);
                lblEuro.Text = @"Euro " + content["EUR"] /*+ @"/Lei"*/;
                lblUsd.Text = @"Usd " + content["USD"] /*+ @"/Lei"*/;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Eroare curs valutar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void informatiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var hp = AppHelp.ShowAppHelp;
            hp.Show();
        }

    }
}
