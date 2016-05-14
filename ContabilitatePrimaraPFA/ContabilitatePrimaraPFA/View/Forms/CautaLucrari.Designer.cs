namespace ContabilitatePrimaraPFA.View.Forms
{
    partial class CautaLucrari
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
            this.radioBttBeneficiar = new System.Windows.Forms.RadioButton();
            this.bttCautaLucrare = new System.Windows.Forms.Button();
            this.txtCautaLucrare = new System.Windows.Forms.TextBox();
            this.radioBttCNP = new System.Windows.Forms.RadioButton();
            this.radioBttAn = new System.Windows.Forms.RadioButton();
            this.radioBttTipLucrare = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioBttBeneficiar
            // 
            this.radioBttBeneficiar.AutoSize = true;
            this.radioBttBeneficiar.Location = new System.Drawing.Point(13, 41);
            this.radioBttBeneficiar.Name = "radioBttBeneficiar";
            this.radioBttBeneficiar.Size = new System.Drawing.Size(103, 17);
            this.radioBttBeneficiar.TabIndex = 0;
            this.radioBttBeneficiar.TabStop = true;
            this.radioBttBeneficiar.Text = "Nume Beneficiar";
            this.radioBttBeneficiar.UseVisualStyleBackColor = true;
            // 
            // bttCautaLucrare
            // 
            this.bttCautaLucrare.Location = new System.Drawing.Point(278, 12);
            this.bttCautaLucrare.Name = "bttCautaLucrare";
            this.bttCautaLucrare.Size = new System.Drawing.Size(75, 23);
            this.bttCautaLucrare.TabIndex = 1;
            this.bttCautaLucrare.Text = "Cauta";
            this.bttCautaLucrare.UseVisualStyleBackColor = true;
            this.bttCautaLucrare.Click += new System.EventHandler(this.bttCautaLucrare_Click);
            // 
            // txtCautaLucrare
            // 
            this.txtCautaLucrare.Location = new System.Drawing.Point(13, 12);
            this.txtCautaLucrare.Name = "txtCautaLucrare";
            this.txtCautaLucrare.Size = new System.Drawing.Size(259, 20);
            this.txtCautaLucrare.TabIndex = 2;
            // 
            // radioBttCNP
            // 
            this.radioBttCNP.AutoSize = true;
            this.radioBttCNP.Location = new System.Drawing.Point(13, 70);
            this.radioBttCNP.Name = "radioBttCNP";
            this.radioBttCNP.Size = new System.Drawing.Size(56, 17);
            this.radioBttCNP.TabIndex = 3;
            this.radioBttCNP.TabStop = true;
            this.radioBttCNP.Text = "C.N.P.";
            this.radioBttCNP.UseVisualStyleBackColor = true;
            // 
            // radioBttAn
            // 
            this.radioBttAn.AutoSize = true;
            this.radioBttAn.Location = new System.Drawing.Point(172, 41);
            this.radioBttAn.Name = "radioBttAn";
            this.radioBttAn.Size = new System.Drawing.Size(107, 17);
            this.radioBttAn.TabIndex = 4;
            this.radioBttAn.TabStop = true;
            this.radioBttAn.Text = "An Documentatie";
            this.radioBttAn.UseVisualStyleBackColor = true;
            // 
            // radioBttTipLucrare
            // 
            this.radioBttTipLucrare.AutoSize = true;
            this.radioBttTipLucrare.Location = new System.Drawing.Point(172, 70);
            this.radioBttTipLucrare.Name = "radioBttTipLucrare";
            this.radioBttTipLucrare.Size = new System.Drawing.Size(131, 17);
            this.radioBttTipLucrare.TabIndex = 5;
            this.radioBttTipLucrare.TabStop = true;
            this.radioBttTipLucrare.Text = "Cod Tip Documentatie";
            this.radioBttTipLucrare.UseVisualStyleBackColor = true;
            // 
            // CautaLucrari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 99);
            this.Controls.Add(this.radioBttTipLucrare);
            this.Controls.Add(this.radioBttAn);
            this.Controls.Add(this.radioBttCNP);
            this.Controls.Add(this.txtCautaLucrare);
            this.Controls.Add(this.bttCautaLucrare);
            this.Controls.Add(this.radioBttBeneficiar);
            this.Name = "CautaLucrari";
            this.Text = "Cautare Lucrari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBttBeneficiar;
        private System.Windows.Forms.Button bttCautaLucrare;
        private System.Windows.Forms.TextBox txtCautaLucrare;
        private System.Windows.Forms.RadioButton radioBttCNP;
        private System.Windows.Forms.RadioButton radioBttAn;
        private System.Windows.Forms.RadioButton radioBttTipLucrare;
    }
}