namespace ContabilitatePrimaraPFA.UserControls
{
    partial class ucLucrari
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttNewLucrare = new System.Windows.Forms.Button();
            this.bttEditLucrare = new System.Windows.Forms.Button();
            this.bttDeleteLucrari = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.grBoxLucrare = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTermenSolutionare = new System.Windows.Forms.Label();
            this.lblDataInreg = new System.Windows.Forms.Label();
            this.dateTimePickerInreg = new System.Windows.Forms.DateTimePicker();
            this.cbTipLucrare = new System.Windows.Forms.ComboBox();
            this.lblTipLucrare = new System.Windows.Forms.Label();
            this.txtInreg = new System.Windows.Forms.TextBox();
            this.cbContract = new System.Windows.Forms.ComboBox();
            this.lblContract = new System.Windows.Forms.Label();
            this.cbAcceptResp = new System.Windows.Forms.ComboBox();
            this.cbReceptionatRespins = new System.Windows.Forms.ComboBox();
            this.lblReceptionatRespins = new System.Windows.Forms.Label();
            this.lblNrInregOCPI = new System.Windows.Forms.Label();
            this.txtUAT = new System.Windows.Forms.TextBox();
            this.lblAcceptResp = new System.Windows.Forms.Label();
            this.lblCadastralTop = new System.Windows.Forms.Label();
            this.txtCad = new System.Windows.Forms.TextBox();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.lblUAT = new System.Windows.Forms.Label();
            this.lblAvizReg = new System.Windows.Forms.Label();
            this.txtAvizator = new System.Windows.Forms.TextBox();
            this.lblObservatii = new System.Windows.Forms.Label();
            this.lblNrDoc = new System.Windows.Forms.Label();
            this.txtObservatii = new System.Windows.Forms.TextBox();
            this.pControls = new System.Windows.Forms.Panel();
            this.grBoxLucrare.SuspendLayout();
            this.pControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttNewLucrare
            // 
            this.bttNewLucrare.Location = new System.Drawing.Point(11, 17);
            this.bttNewLucrare.Name = "bttNewLucrare";
            this.bttNewLucrare.Size = new System.Drawing.Size(51, 23);
            this.bttNewLucrare.TabIndex = 0;
            this.bttNewLucrare.Text = "New";
            this.bttNewLucrare.UseVisualStyleBackColor = true;
            // 
            // bttEditLucrare
            // 
            this.bttEditLucrare.Location = new System.Drawing.Point(87, 17);
            this.bttEditLucrare.Name = "bttEditLucrare";
            this.bttEditLucrare.Size = new System.Drawing.Size(51, 23);
            this.bttEditLucrare.TabIndex = 1;
            this.bttEditLucrare.Text = "Edit";
            this.bttEditLucrare.UseVisualStyleBackColor = true;
            // 
            // bttDeleteLucrari
            // 
            this.bttDeleteLucrari.Location = new System.Drawing.Point(163, 17);
            this.bttDeleteLucrari.Name = "bttDeleteLucrari";
            this.bttDeleteLucrari.Size = new System.Drawing.Size(51, 23);
            this.bttDeleteLucrari.TabIndex = 2;
            this.bttDeleteLucrari.Text = "Delete";
            this.bttDeleteLucrari.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(0, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(691, 590);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // grBoxLucrare
            // 
            this.grBoxLucrare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxLucrare.Controls.Add(this.pControls);
            this.grBoxLucrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxLucrare.Location = new System.Drawing.Point(690, 52);
            this.grBoxLucrare.Name = "grBoxLucrare";
            this.grBoxLucrare.Size = new System.Drawing.Size(238, 597);
            this.grBoxLucrare.TabIndex = 4;
            this.grBoxLucrare.TabStop = false;
            this.grBoxLucrare.Text = "Lucrare";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lblTermenSolutionare
            // 
            this.lblTermenSolutionare.AutoSize = true;
            this.lblTermenSolutionare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermenSolutionare.Location = new System.Drawing.Point(6, 143);
            this.lblTermenSolutionare.Name = "lblTermenSolutionare";
            this.lblTermenSolutionare.Size = new System.Drawing.Size(74, 15);
            this.lblTermenSolutionare.TabIndex = 0;
            this.lblTermenSolutionare.Text = "Termen Sol.";
            // 
            // lblDataInreg
            // 
            this.lblDataInreg.AutoSize = true;
            this.lblDataInreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInreg.Location = new System.Drawing.Point(6, 110);
            this.lblDataInreg.Name = "lblDataInreg";
            this.lblDataInreg.Size = new System.Drawing.Size(67, 15);
            this.lblDataInreg.TabIndex = 0;
            this.lblDataInreg.Text = "Data Inreg.";
            // 
            // dateTimePickerInreg
            // 
            this.dateTimePickerInreg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInreg.Location = new System.Drawing.Point(99, 109);
            this.dateTimePickerInreg.Name = "dateTimePickerInreg";
            this.dateTimePickerInreg.Size = new System.Drawing.Size(121, 21);
            this.dateTimePickerInreg.TabIndex = 5;
            // 
            // cbTipLucrare
            // 
            this.cbTipLucrare.FormattingEnabled = true;
            this.cbTipLucrare.Location = new System.Drawing.Point(99, 173);
            this.cbTipLucrare.Name = "cbTipLucrare";
            this.cbTipLucrare.Size = new System.Drawing.Size(121, 23);
            this.cbTipLucrare.TabIndex = 7;
            // 
            // lblTipLucrare
            // 
            this.lblTipLucrare.AutoSize = true;
            this.lblTipLucrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipLucrare.Location = new System.Drawing.Point(6, 176);
            this.lblTipLucrare.Name = "lblTipLucrare";
            this.lblTipLucrare.Size = new System.Drawing.Size(69, 15);
            this.lblTipLucrare.TabIndex = 0;
            this.lblTipLucrare.Text = "Tip Lucrare";
            // 
            // txtInreg
            // 
            this.txtInreg.Location = new System.Drawing.Point(99, 77);
            this.txtInreg.Name = "txtInreg";
            this.txtInreg.Size = new System.Drawing.Size(121, 21);
            this.txtInreg.TabIndex = 4;
            // 
            // cbContract
            // 
            this.cbContract.FormattingEnabled = true;
            this.cbContract.Location = new System.Drawing.Point(99, 207);
            this.cbContract.Name = "cbContract";
            this.cbContract.Size = new System.Drawing.Size(121, 23);
            this.cbContract.TabIndex = 8;
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContract.Location = new System.Drawing.Point(6, 209);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(52, 15);
            this.lblContract.TabIndex = 0;
            this.lblContract.Text = "Contract";
            // 
            // cbAcceptResp
            // 
            this.cbAcceptResp.FormattingEnabled = true;
            this.cbAcceptResp.Location = new System.Drawing.Point(99, 43);
            this.cbAcceptResp.Name = "cbAcceptResp";
            this.cbAcceptResp.Size = new System.Drawing.Size(121, 23);
            this.cbAcceptResp.TabIndex = 3;
            // 
            // cbReceptionatRespins
            // 
            this.cbReceptionatRespins.FormattingEnabled = true;
            this.cbReceptionatRespins.Location = new System.Drawing.Point(99, 241);
            this.cbReceptionatRespins.Name = "cbReceptionatRespins";
            this.cbReceptionatRespins.Size = new System.Drawing.Size(121, 23);
            this.cbReceptionatRespins.TabIndex = 9;
            // 
            // lblReceptionatRespins
            // 
            this.lblReceptionatRespins.AutoSize = true;
            this.lblReceptionatRespins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionatRespins.Location = new System.Drawing.Point(6, 242);
            this.lblReceptionatRespins.Name = "lblReceptionatRespins";
            this.lblReceptionatRespins.Size = new System.Drawing.Size(75, 15);
            this.lblReceptionatRespins.TabIndex = 0;
            this.lblReceptionatRespins.Text = "Recep/Resp";
            // 
            // lblNrInregOCPI
            // 
            this.lblNrInregOCPI.AutoSize = true;
            this.lblNrInregOCPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrInregOCPI.Location = new System.Drawing.Point(3, 77);
            this.lblNrInregOCPI.Name = "lblNrInregOCPI";
            this.lblNrInregOCPI.Size = new System.Drawing.Size(88, 15);
            this.lblNrInregOCPI.TabIndex = 2;
            this.lblNrInregOCPI.Text = "Nr. Inreg. OCPI";
            // 
            // txtUAT
            // 
            this.txtUAT.Location = new System.Drawing.Point(99, 278);
            this.txtUAT.Name = "txtUAT";
            this.txtUAT.Size = new System.Drawing.Size(121, 21);
            this.txtUAT.TabIndex = 10;
            // 
            // lblAcceptResp
            // 
            this.lblAcceptResp.AutoSize = true;
            this.lblAcceptResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceptResp.Location = new System.Drawing.Point(6, 44);
            this.lblAcceptResp.Name = "lblAcceptResp";
            this.lblAcceptResp.Size = new System.Drawing.Size(78, 15);
            this.lblAcceptResp.TabIndex = 2;
            this.lblAcceptResp.Text = "Accept/Resp.";
            // 
            // lblCadastralTop
            // 
            this.lblCadastralTop.AutoSize = true;
            this.lblCadastralTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastralTop.Location = new System.Drawing.Point(6, 314);
            this.lblCadastralTop.Name = "lblCadastralTop";
            this.lblCadastralTop.Size = new System.Drawing.Size(53, 15);
            this.lblCadastralTop.TabIndex = 0;
            this.lblCadastralTop.Text = "Cad/Top";
            // 
            // txtCad
            // 
            this.txtCad.Location = new System.Drawing.Point(99, 314);
            this.txtCad.Name = "txtCad";
            this.txtCad.Size = new System.Drawing.Size(121, 21);
            this.txtCad.TabIndex = 10;
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(99, 11);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(121, 21);
            this.txtDoc.TabIndex = 1;
            // 
            // lblUAT
            // 
            this.lblUAT.AutoSize = true;
            this.lblUAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUAT.Location = new System.Drawing.Point(12, 278);
            this.lblUAT.Name = "lblUAT";
            this.lblUAT.Size = new System.Drawing.Size(39, 15);
            this.lblUAT.TabIndex = 0;
            this.lblUAT.Text = "U.A.T.";
            // 
            // lblAvizReg
            // 
            this.lblAvizReg.AutoSize = true;
            this.lblAvizReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvizReg.Location = new System.Drawing.Point(6, 358);
            this.lblAvizReg.Name = "lblAvizReg";
            this.lblAvizReg.Size = new System.Drawing.Size(60, 15);
            this.lblAvizReg.TabIndex = 0;
            this.lblAvizReg.Text = "Aviz./Reg.";
            // 
            // txtAvizator
            // 
            this.txtAvizator.Location = new System.Drawing.Point(99, 352);
            this.txtAvizator.Multiline = true;
            this.txtAvizator.Name = "txtAvizator";
            this.txtAvizator.Size = new System.Drawing.Size(121, 42);
            this.txtAvizator.TabIndex = 11;
            // 
            // lblObservatii
            // 
            this.lblObservatii.AutoSize = true;
            this.lblObservatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservatii.Location = new System.Drawing.Point(6, 416);
            this.lblObservatii.Name = "lblObservatii";
            this.lblObservatii.Size = new System.Drawing.Size(61, 15);
            this.lblObservatii.TabIndex = 0;
            this.lblObservatii.Text = "Observatii";
            // 
            // lblNrDoc
            // 
            this.lblNrDoc.AutoSize = true;
            this.lblNrDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrDoc.Location = new System.Drawing.Point(3, 11);
            this.lblNrDoc.Name = "lblNrDoc";
            this.lblNrDoc.Size = new System.Drawing.Size(48, 15);
            this.lblNrDoc.TabIndex = 0;
            this.lblNrDoc.Text = "Nr. Doc";
            // 
            // txtObservatii
            // 
            this.txtObservatii.Location = new System.Drawing.Point(99, 410);
            this.txtObservatii.Multiline = true;
            this.txtObservatii.Name = "txtObservatii";
            this.txtObservatii.Size = new System.Drawing.Size(121, 68);
            this.txtObservatii.TabIndex = 11;
            // 
            // pControls
            // 
            this.pControls.AutoScroll = true;
            this.pControls.AutoSize = true;
            this.pControls.Controls.Add(this.txtObservatii);
            this.pControls.Controls.Add(this.lblNrDoc);
            this.pControls.Controls.Add(this.lblObservatii);
            this.pControls.Controls.Add(this.txtAvizator);
            this.pControls.Controls.Add(this.lblAvizReg);
            this.pControls.Controls.Add(this.lblUAT);
            this.pControls.Controls.Add(this.txtDoc);
            this.pControls.Controls.Add(this.txtCad);
            this.pControls.Controls.Add(this.lblCadastralTop);
            this.pControls.Controls.Add(this.lblAcceptResp);
            this.pControls.Controls.Add(this.txtUAT);
            this.pControls.Controls.Add(this.lblNrInregOCPI);
            this.pControls.Controls.Add(this.lblReceptionatRespins);
            this.pControls.Controls.Add(this.cbReceptionatRespins);
            this.pControls.Controls.Add(this.cbAcceptResp);
            this.pControls.Controls.Add(this.lblContract);
            this.pControls.Controls.Add(this.cbContract);
            this.pControls.Controls.Add(this.txtInreg);
            this.pControls.Controls.Add(this.lblTipLucrare);
            this.pControls.Controls.Add(this.cbTipLucrare);
            this.pControls.Controls.Add(this.dateTimePickerInreg);
            this.pControls.Controls.Add(this.lblDataInreg);
            this.pControls.Controls.Add(this.lblTermenSolutionare);
            this.pControls.Controls.Add(this.dateTimePicker1);
            this.pControls.Location = new System.Drawing.Point(7, 21);
            this.pControls.Name = "pControls";
            this.pControls.Size = new System.Drawing.Size(231, 573);
            this.pControls.TabIndex = 0;
            this.pControls.TabStop = true;
            // 
            // ucLucrari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grBoxLucrare);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bttDeleteLucrari);
            this.Controls.Add(this.bttEditLucrare);
            this.Controls.Add(this.bttNewLucrare);
            this.Name = "ucLucrari";
            this.Size = new System.Drawing.Size(931, 649);
            this.grBoxLucrare.ResumeLayout(false);
            this.grBoxLucrare.PerformLayout();
            this.pControls.ResumeLayout(false);
            this.pControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttNewLucrare;
        private System.Windows.Forms.Button bttEditLucrare;
        private System.Windows.Forms.Button bttDeleteLucrari;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox grBoxLucrare;
        private System.Windows.Forms.Panel pControls;
        private System.Windows.Forms.TextBox txtObservatii;
        private System.Windows.Forms.Label lblNrDoc;
        private System.Windows.Forms.Label lblObservatii;
        private System.Windows.Forms.TextBox txtAvizator;
        private System.Windows.Forms.Label lblAvizReg;
        private System.Windows.Forms.Label lblUAT;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.TextBox txtCad;
        private System.Windows.Forms.Label lblCadastralTop;
        private System.Windows.Forms.Label lblAcceptResp;
        private System.Windows.Forms.TextBox txtUAT;
        private System.Windows.Forms.Label lblNrInregOCPI;
        private System.Windows.Forms.Label lblReceptionatRespins;
        private System.Windows.Forms.ComboBox cbReceptionatRespins;
        private System.Windows.Forms.ComboBox cbAcceptResp;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.ComboBox cbContract;
        private System.Windows.Forms.TextBox txtInreg;
        private System.Windows.Forms.Label lblTipLucrare;
        private System.Windows.Forms.ComboBox cbTipLucrare;
        private System.Windows.Forms.DateTimePicker dateTimePickerInreg;
        private System.Windows.Forms.Label lblDataInreg;
        private System.Windows.Forms.Label lblTermenSolutionare;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
