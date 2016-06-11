namespace View.View.UserControls
{
    partial class ucOperatiuni
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
            this.grBoxControale = new System.Windows.Forms.GroupBox();
            this.grBoxView = new System.Windows.Forms.GroupBox();
            this.pView = new System.Windows.Forms.Panel();
            this.grBoxForm = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbIncasare = new System.Windows.Forms.RadioButton();
            this.rbPlata = new System.Windows.Forms.RadioButton();
            this.lblTipDoc = new System.Windows.Forms.Label();
            this.cbTipDoc = new System.Windows.Forms.ComboBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumar = new System.Windows.Forms.Label();
            this.txtNumar = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSuma = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCotaTva = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkTVA = new System.Windows.Forms.CheckBox();
            this.lblFeluloperatiunii = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblContract = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.grBoxView.SuspendLayout();
            this.grBoxForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxControale
            // 
            this.grBoxControale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxControale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxControale.Location = new System.Drawing.Point(12, 14);
            this.grBoxControale.Name = "grBoxControale";
            this.grBoxControale.Size = new System.Drawing.Size(970, 49);
            this.grBoxControale.TabIndex = 0;
            this.grBoxControale.TabStop = false;
            this.grBoxControale.Text = "groupBox1";
            // 
            // grBoxView
            // 
            this.grBoxView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxView.Controls.Add(this.grBoxControale);
            this.grBoxView.Controls.Add(this.pView);
            this.grBoxView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxView.Location = new System.Drawing.Point(3, 147);
            this.grBoxView.Name = "grBoxView";
            this.grBoxView.Size = new System.Drawing.Size(994, 585);
            this.grBoxView.TabIndex = 1;
            this.grBoxView.TabStop = false;
            this.grBoxView.Text = "Registru incasari si plati";
            // 
            // pView
            // 
            this.pView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pView.AutoScroll = true;
            this.pView.Location = new System.Drawing.Point(0, 74);
            this.pView.Name = "pView";
            this.pView.Size = new System.Drawing.Size(988, 511);
            this.pView.TabIndex = 0;
            // 
            // grBoxForm
            // 
            this.grBoxForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxForm.Controls.Add(this.panel1);
            this.grBoxForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxForm.Location = new System.Drawing.Point(3, 3);
            this.grBoxForm.Name = "grBoxForm";
            this.grBoxForm.Size = new System.Drawing.Size(994, 138);
            this.grBoxForm.TabIndex = 2;
            this.grBoxForm.TabStop = false;
            this.grBoxForm.Text = "Operatiune";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.lblContract);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.lblFeluloperatiunii);
            this.panel1.Controls.Add(this.checkTVA);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.lblCotaTva);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lblSuma);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.txtNumar);
            this.panel1.Controls.Add(this.lblNumar);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblSerie);
            this.panel1.Controls.Add(this.cbTipDoc);
            this.panel1.Controls.Add(this.lblTipDoc);
            this.panel1.Controls.Add(this.rbPlata);
            this.panel1.Controls.Add(this.rbIncasare);
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 114);
            this.panel1.TabIndex = 0;
            // 
            // rbIncasare
            // 
            this.rbIncasare.AutoSize = true;
            this.rbIncasare.Checked = true;
            this.rbIncasare.Location = new System.Drawing.Point(7, 11);
            this.rbIncasare.Name = "rbIncasare";
            this.rbIncasare.Size = new System.Drawing.Size(74, 17);
            this.rbIncasare.TabIndex = 0;
            this.rbIncasare.TabStop = true;
            this.rbIncasare.Text = "Incasare";
            this.rbIncasare.UseVisualStyleBackColor = true;
            // 
            // rbPlata
            // 
            this.rbPlata.AutoSize = true;
            this.rbPlata.Location = new System.Drawing.Point(116, 11);
            this.rbPlata.Name = "rbPlata";
            this.rbPlata.Size = new System.Drawing.Size(54, 17);
            this.rbPlata.TabIndex = 1;
            this.rbPlata.TabStop = true;
            this.rbPlata.Text = "Plata";
            this.rbPlata.UseVisualStyleBackColor = true;
            // 
            // lblTipDoc
            // 
            this.lblTipDoc.AutoSize = true;
            this.lblTipDoc.Location = new System.Drawing.Point(327, 12);
            this.lblTipDoc.Name = "lblTipDoc";
            this.lblTipDoc.Size = new System.Drawing.Size(86, 13);
            this.lblTipDoc.TabIndex = 2;
            this.lblTipDoc.Text = "Tip Document";
            // 
            // cbTipDoc
            // 
            this.cbTipDoc.FormattingEnabled = true;
            this.cbTipDoc.ItemHeight = 13;
            this.cbTipDoc.Location = new System.Drawing.Point(419, 9);
            this.cbTipDoc.Name = "cbTipDoc";
            this.cbTipDoc.Size = new System.Drawing.Size(124, 21);
            this.cbTipDoc.TabIndex = 3;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(549, 13);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(36, 13);
            this.lblSerie.TabIndex = 4;
            this.lblSerie.Text = "Serie";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(591, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblNumar
            // 
            this.lblNumar.AutoSize = true;
            this.lblNumar.Location = new System.Drawing.Point(655, 13);
            this.lblNumar.Name = "lblNumar";
            this.lblNumar.Size = new System.Drawing.Size(43, 13);
            this.lblNumar.TabIndex = 6;
            this.lblNumar.Text = "Numar";
            // 
            // txtNumar
            // 
            this.txtNumar.Location = new System.Drawing.Point(704, 10);
            this.txtNumar.Name = "txtNumar";
            this.txtNumar.Size = new System.Drawing.Size(79, 20);
            this.txtNumar.TabIndex = 7;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(801, 13);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 13);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(841, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(14, 64);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(38, 13);
            this.lblSuma.TabIndex = 10;
            this.lblSuma.Text = "Suma";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 11;
            // 
            // lblCotaTva
            // 
            this.lblCotaTva.AutoSize = true;
            this.lblCotaTva.Location = new System.Drawing.Point(181, 64);
            this.lblCotaTva.Name = "lblCotaTva";
            this.lblCotaTva.Size = new System.Drawing.Size(74, 13);
            this.lblCotaTva.TabIndex = 12;
            this.lblCotaTva.Text = "Cota TVA %";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(261, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(58, 20);
            this.textBox3.TabIndex = 13;
            // 
            // checkTVA
            // 
            this.checkTVA.AutoSize = true;
            this.checkTVA.Location = new System.Drawing.Point(199, 11);
            this.checkTVA.Name = "checkTVA";
            this.checkTVA.Size = new System.Drawing.Size(106, 17);
            this.checkTVA.TabIndex = 14;
            this.checkTVA.Text = "Platitor T.V.A.";
            this.checkTVA.UseVisualStyleBackColor = true;
            // 
            // lblFeluloperatiunii
            // 
            this.lblFeluloperatiunii.AutoSize = true;
            this.lblFeluloperatiunii.Location = new System.Drawing.Point(327, 64);
            this.lblFeluloperatiunii.Name = "lblFeluloperatiunii";
            this.lblFeluloperatiunii.Size = new System.Drawing.Size(99, 13);
            this.lblFeluloperatiunii.TabIndex = 15;
            this.lblFeluloperatiunii.Text = "Felul Operatiunii";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(432, 60);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(266, 40);
            this.textBox4.TabIndex = 16;
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(707, 68);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(76, 13);
            this.lblContract.TabIndex = 17;
            this.lblContract.Text = "Nr. Contract";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(804, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(153, 20);
            this.textBox5.TabIndex = 18;
            // 
            // ucOperatiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grBoxForm);
            this.Controls.Add(this.grBoxView);
            this.Name = "ucOperatiuni";
            this.Size = new System.Drawing.Size(1000, 742);
            this.grBoxView.ResumeLayout(false);
            this.grBoxForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxControale;
        private System.Windows.Forms.GroupBox grBoxView;
        private System.Windows.Forms.GroupBox grBoxForm;
        private System.Windows.Forms.Panel pView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPlata;
        private System.Windows.Forms.RadioButton rbIncasare;
        private System.Windows.Forms.ComboBox cbTipDoc;
        private System.Windows.Forms.Label lblTipDoc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtNumar;
        private System.Windows.Forms.Label lblNumar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCotaTva;
        private System.Windows.Forms.CheckBox checkTVA;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblFeluloperatiunii;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.TextBox textBox5;
    }
}
