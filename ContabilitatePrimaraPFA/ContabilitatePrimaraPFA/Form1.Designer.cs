namespace ContabilitatePrimaraPFA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grBoxOperatiuni = new System.Windows.Forms.GroupBox();
            this.btttFacturi = new System.Windows.Forms.Button();
            this.bttContracte = new System.Windows.Forms.Button();
            this.bttLucrari = new System.Windows.Forms.Button();
            this.grBoxCursValutar = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.grBoxOperatiuni.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxOperatiuni
            // 
            this.grBoxOperatiuni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grBoxOperatiuni.Controls.Add(this.btttFacturi);
            this.grBoxOperatiuni.Controls.Add(this.bttContracte);
            this.grBoxOperatiuni.Controls.Add(this.bttLucrari);
            this.grBoxOperatiuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxOperatiuni.Location = new System.Drawing.Point(12, 165);
            this.grBoxOperatiuni.Name = "grBoxOperatiuni";
            this.grBoxOperatiuni.Size = new System.Drawing.Size(100, 428);
            this.grBoxOperatiuni.TabIndex = 0;
            this.grBoxOperatiuni.TabStop = false;
            this.grBoxOperatiuni.Text = "Operatiuni";
            // 
            // btttFacturi
            // 
            this.btttFacturi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btttFacturi.Location = new System.Drawing.Point(6, 124);
            this.btttFacturi.Name = "btttFacturi";
            this.btttFacturi.Size = new System.Drawing.Size(88, 28);
            this.btttFacturi.TabIndex = 0;
            this.btttFacturi.Text = "Facturi";
            this.btttFacturi.UseVisualStyleBackColor = true;
            this.btttFacturi.Click += new System.EventHandler(this.PaintUserControl);
            // 
            // bttContracte
            // 
            this.bttContracte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttContracte.Location = new System.Drawing.Point(6, 78);
            this.bttContracte.Name = "bttContracte";
            this.bttContracte.Size = new System.Drawing.Size(88, 28);
            this.bttContracte.TabIndex = 0;
            this.bttContracte.Text = "Contracte";
            this.bttContracte.UseVisualStyleBackColor = true;
            this.bttContracte.Click += new System.EventHandler(this.PaintUserControl);
            // 
            // bttLucrari
            // 
            this.bttLucrari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLucrari.Location = new System.Drawing.Point(6, 32);
            this.bttLucrari.Name = "bttLucrari";
            this.bttLucrari.Size = new System.Drawing.Size(88, 28);
            this.bttLucrari.TabIndex = 0;
            this.bttLucrari.Text = "Lucrari";
            this.bttLucrari.UseVisualStyleBackColor = true;
            this.bttLucrari.Click += new System.EventHandler(this.PaintUserControl);
            // 
            // grBoxCursValutar
            // 
            this.grBoxCursValutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxCursValutar.Location = new System.Drawing.Point(12, 27);
            this.grBoxCursValutar.Name = "grBoxCursValutar";
            this.grBoxCursValutar.Size = new System.Drawing.Size(100, 110);
            this.grBoxCursValutar.TabIndex = 1;
            this.grBoxCursValutar.TabStop = false;
            this.grBoxCursValutar.Text = "Curs B.N.R.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Location = new System.Drawing.Point(119, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1062, 565);
            this.mainPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 605);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.grBoxCursValutar);
            this.Controls.Add(this.grBoxOperatiuni);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grBoxOperatiuni.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxOperatiuni;
        private System.Windows.Forms.GroupBox grBoxCursValutar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btttFacturi;
        private System.Windows.Forms.Button bttContracte;
        private System.Windows.Forms.Button bttLucrari;
        private System.Windows.Forms.Panel mainPanel;
    }
}

