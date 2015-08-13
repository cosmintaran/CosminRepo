namespace SistemeInformaticeContabile
{
    partial class ContracteForm
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
            this.txtNumarContract = new System.Windows.Forms.TextBox();
            this.txtObservatii = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Contracte = new System.Windows.Forms.DateTimePicker();
            this.lblNrContract = new System.Windows.Forms.Label();
            this.lblBeneficiar = new System.Windows.Forms.Label();
            this.comboBeneficiar = new System.Windows.Forms.ComboBox();
            this.lblDataContract = new System.Windows.Forms.Label();
            this.txtUAT = new System.Windows.Forms.TextBox();
            this.lblUAT = new System.Windows.Forms.Label();
            this.lblObservatii = new System.Windows.Forms.Label();
            this.txtObiectulContractului = new System.Windows.Forms.TextBox();
            this.lblObiectulContractului = new System.Windows.Forms.Label();
            this.bttOK = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumarContract
            // 
            this.txtNumarContract.Location = new System.Drawing.Point(12, 25);
            this.txtNumarContract.Name = "txtNumarContract";
            this.txtNumarContract.Size = new System.Drawing.Size(100, 20);
            this.txtNumarContract.TabIndex = 0;
            // 
            // txtObservatii
            // 
            this.txtObservatii.Location = new System.Drawing.Point(12, 111);
            this.txtObservatii.Multiline = true;
            this.txtObservatii.Name = "txtObservatii";
            this.txtObservatii.Size = new System.Drawing.Size(397, 77);
            this.txtObservatii.TabIndex = 2;
            // 
            // dateTimePicker_Contracte
            // 
            this.dateTimePicker_Contracte.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker_Contracte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Contracte.Location = new System.Drawing.Point(127, 25);
            this.dateTimePicker_Contracte.Name = "dateTimePicker_Contracte";
            this.dateTimePicker_Contracte.ShowCheckBox = true;
            this.dateTimePicker_Contracte.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker_Contracte.TabIndex = 3;
            // 
            // lblNrContract
            // 
            this.lblNrContract.AutoSize = true;
            this.lblNrContract.Location = new System.Drawing.Point(13, 6);
            this.lblNrContract.Name = "lblNrContract";
            this.lblNrContract.Size = new System.Drawing.Size(81, 13);
            this.lblNrContract.TabIndex = 4;
            this.lblNrContract.Text = "Numar Contract";
            // 
            // lblBeneficiar
            // 
            this.lblBeneficiar.AutoSize = true;
            this.lblBeneficiar.Location = new System.Drawing.Point(249, 6);
            this.lblBeneficiar.Name = "lblBeneficiar";
            this.lblBeneficiar.Size = new System.Drawing.Size(54, 13);
            this.lblBeneficiar.TabIndex = 5;
            this.lblBeneficiar.Text = "Beneficiar";
            // 
            // comboBeneficiar
            // 
            this.comboBeneficiar.FormattingEnabled = true;
            this.comboBeneficiar.Location = new System.Drawing.Point(252, 25);
            this.comboBeneficiar.Name = "comboBeneficiar";
            this.comboBeneficiar.Size = new System.Drawing.Size(157, 21);
            this.comboBeneficiar.TabIndex = 6;
            this.comboBeneficiar.SelectedIndexChanged += new System.EventHandler(this.comboBeneficiar_SelectedIndexChanged);
            // 
            // lblDataContract
            // 
            this.lblDataContract.AutoSize = true;
            this.lblDataContract.Location = new System.Drawing.Point(127, 6);
            this.lblDataContract.Name = "lblDataContract";
            this.lblDataContract.Size = new System.Drawing.Size(73, 13);
            this.lblDataContract.TabIndex = 7;
            this.lblDataContract.Text = "Data Contract";
            // 
            // txtUAT
            // 
            this.txtUAT.Location = new System.Drawing.Point(12, 68);
            this.txtUAT.Name = "txtUAT";
            this.txtUAT.Size = new System.Drawing.Size(100, 20);
            this.txtUAT.TabIndex = 8;
            // 
            // lblUAT
            // 
            this.lblUAT.AutoSize = true;
            this.lblUAT.Location = new System.Drawing.Point(16, 52);
            this.lblUAT.Name = "lblUAT";
            this.lblUAT.Size = new System.Drawing.Size(38, 13);
            this.lblUAT.TabIndex = 9;
            this.lblUAT.Text = "U.A.T.";
            // 
            // lblObservatii
            // 
            this.lblObservatii.AutoSize = true;
            this.lblObservatii.Location = new System.Drawing.Point(12, 95);
            this.lblObservatii.Name = "lblObservatii";
            this.lblObservatii.Size = new System.Drawing.Size(112, 13);
            this.lblObservatii.TabIndex = 10;
            this.lblObservatii.Text = "Observatii La Contract";
            // 
            // txtObiectulContractului
            // 
            this.txtObiectulContractului.Location = new System.Drawing.Point(131, 67);
            this.txtObiectulContractului.Name = "txtObiectulContractului";
            this.txtObiectulContractului.Size = new System.Drawing.Size(278, 20);
            this.txtObiectulContractului.TabIndex = 11;
            // 
            // lblObiectulContractului
            // 
            this.lblObiectulContractului.AutoSize = true;
            this.lblObiectulContractului.Location = new System.Drawing.Point(131, 51);
            this.lblObiectulContractului.Name = "lblObiectulContractului";
            this.lblObiectulContractului.Size = new System.Drawing.Size(105, 13);
            this.lblObiectulContractului.TabIndex = 12;
            this.lblObiectulContractului.Text = "Obiectul Contractului";
            // 
            // bttOK
            // 
            this.bttOK.Location = new System.Drawing.Point(12, 207);
            this.bttOK.Name = "bttOK";
            this.bttOK.Size = new System.Drawing.Size(96, 23);
            this.bttOK.TabIndex = 13;
            this.bttOK.Text = "OK";
            this.bttOK.UseVisualStyleBackColor = true;
            this.bttOK.Click += new System.EventHandler(this.bttOK_Click);
            // 
            // bttExit
            // 
            this.bttExit.Location = new System.Drawing.Point(302, 207);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(96, 23);
            this.bttExit.TabIndex = 14;
            this.bttExit.Text = "Exit";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // ContracteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 245);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.bttOK);
            this.Controls.Add(this.lblObiectulContractului);
            this.Controls.Add(this.txtObiectulContractului);
            this.Controls.Add(this.lblObservatii);
            this.Controls.Add(this.lblUAT);
            this.Controls.Add(this.txtUAT);
            this.Controls.Add(this.lblDataContract);
            this.Controls.Add(this.comboBeneficiar);
            this.Controls.Add(this.lblBeneficiar);
            this.Controls.Add(this.lblNrContract);
            this.Controls.Add(this.dateTimePicker_Contracte);
            this.Controls.Add(this.txtObservatii);
            this.Controls.Add(this.txtNumarContract);
            this.Name = "ContracteForm";
            this.Text = "Contracte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumarContract;
        private System.Windows.Forms.TextBox txtObservatii;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Contracte;
        private System.Windows.Forms.Label lblNrContract;
        private System.Windows.Forms.Label lblBeneficiar;
        private System.Windows.Forms.ComboBox comboBeneficiar;
        private System.Windows.Forms.Label lblDataContract;
        private System.Windows.Forms.TextBox txtUAT;
        private System.Windows.Forms.Label lblUAT;
        private System.Windows.Forms.Label lblObservatii;
        private System.Windows.Forms.TextBox txtObiectulContractului;
        private System.Windows.Forms.Label lblObiectulContractului;
        private System.Windows.Forms.Button bttOK;
        private System.Windows.Forms.Button bttExit;
    }
}