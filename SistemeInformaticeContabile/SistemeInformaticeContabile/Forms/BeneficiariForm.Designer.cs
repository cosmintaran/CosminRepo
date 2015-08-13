namespace SistemeInformaticeContabile
{
    partial class BeneficiariForm
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
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtSerieCI = new System.Windows.Forms.TextBox();
            this.txtNrCI = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblNrCI = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(13, 24);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(138, 20);
            this.txtNume.TabIndex = 0;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(183, 24);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(138, 20);
            this.txtPrenume.TabIndex = 1;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(12, 67);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(135, 20);
            this.txtCNP.TabIndex = 2;
            // 
            // txtSerieCI
            // 
            this.txtSerieCI.Location = new System.Drawing.Point(183, 67);
            this.txtSerieCI.Name = "txtSerieCI";
            this.txtSerieCI.Size = new System.Drawing.Size(44, 20);
            this.txtSerieCI.TabIndex = 3;
            // 
            // txtNrCI
            // 
            this.txtNrCI.Location = new System.Drawing.Point(244, 67);
            this.txtNrCI.Name = "txtNrCI";
            this.txtNrCI.Size = new System.Drawing.Size(77, 20);
            this.txtNrCI.TabIndex = 4;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(12, 111);
            this.txtAdresa.Multiline = true;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(309, 40);
            this.txtAdresa.TabIndex = 5;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(13, 5);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 6;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(183, 5);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 7;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Location = new System.Drawing.Point(13, 51);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(29, 13);
            this.lblCNP.TabIndex = 8;
            this.lblCNP.Text = "CNP";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(180, 51);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(44, 13);
            this.lblSerie.TabIndex = 9;
            this.lblSerie.Text = "Serie CI";
            // 
            // lblNrCI
            // 
            this.lblNrCI.AutoSize = true;
            this.lblNrCI.Location = new System.Drawing.Point(244, 51);
            this.lblNrCI.Name = "lblNrCI";
            this.lblNrCI.Size = new System.Drawing.Size(57, 13);
            this.lblNrCI.TabIndex = 10;
            this.lblNrCI.Text = "Numar C.I.";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(13, 95);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(90, 13);
            this.lblAdresa.TabIndex = 11;
            this.lblAdresa.Text = "Adresa Beneficiar";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(19, 169);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(234, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BeneficiariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 204);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblNrCI);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.lblCNP);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNrCI);
            this.Controls.Add(this.txtSerieCI);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Name = "BeneficiariForm";
            this.Text = "Beneficiari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtSerieCI;
        private System.Windows.Forms.TextBox txtNrCI;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblNrCI;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
    }
}