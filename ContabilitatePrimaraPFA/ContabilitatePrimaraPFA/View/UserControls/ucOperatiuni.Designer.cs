namespace ContaPFA.View.UserControls
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
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttNew = new System.Windows.Forms.Button();
            this.grBoxView = new System.Windows.Forms.GroupBox();
            this.pView = new System.Windows.Forms.Panel();
            this.grBoxForm = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblContract = new System.Windows.Forms.Label();
            this.txtFelOperatiune = new System.Windows.Forms.TextBox();
            this.lblFeluloperatiunii = new System.Windows.Forms.Label();
            this.checkTVA = new System.Windows.Forms.CheckBox();
            this.txtCotaTVA = new System.Windows.Forms.TextBox();
            this.lblCotaTva = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.txtNumar = new System.Windows.Forms.TextBox();
            this.lblNumar = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.cbTipDoc = new System.Windows.Forms.ComboBox();
            this.lblTipDoc = new System.Windows.Forms.Label();
            this.rbPlata = new System.Windows.Forms.RadioButton();
            this.rbIncasare = new System.Windows.Forms.RadioButton();
            this.txtContract = new System.Windows.Forms.TextBox();
            this.bttClear = new System.Windows.Forms.Button();
            this.grBoxControale.SuspendLayout();
            this.grBoxView.SuspendLayout();
            this.grBoxForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxControale
            // 
            this.grBoxControale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxControale.Controls.Add(this.bttClear);
            this.grBoxControale.Controls.Add(this.bttAdd);
            this.grBoxControale.Controls.Add(this.bttDelete);
            this.grBoxControale.Controls.Add(this.bttNew);
            this.grBoxControale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxControale.Location = new System.Drawing.Point(12, 14);
            this.grBoxControale.Name = "grBoxControale";
            this.grBoxControale.Size = new System.Drawing.Size(970, 49);
            this.grBoxControale.TabIndex = 0;
            this.grBoxControale.TabStop = false;
            // 
            // bttAdd
            // 
            this.bttAdd.Enabled = false;
            this.bttAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttAdd.Location = new System.Drawing.Point(152, 19);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(51, 23);
            this.bttAdd.TabIndex = 0;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Enabled = false;
            this.bttDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttDelete.Location = new System.Drawing.Point(79, 19);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(51, 23);
            this.bttDelete.TabIndex = 0;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            // 
            // bttNew
            // 
            this.bttNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttNew.Location = new System.Drawing.Point(6, 19);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(51, 23);
            this.bttNew.TabIndex = 0;
            this.bttNew.Text = "New";
            this.bttNew.UseVisualStyleBackColor = true;
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
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
            this.grBoxForm.Enabled = false;
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
            this.panel1.Controls.Add(this.txtContract);
            this.panel1.Controls.Add(this.lblContract);
            this.panel1.Controls.Add(this.txtFelOperatiune);
            this.panel1.Controls.Add(this.lblFeluloperatiunii);
            this.panel1.Controls.Add(this.checkTVA);
            this.panel1.Controls.Add(this.txtCotaTVA);
            this.panel1.Controls.Add(this.lblCotaTva);
            this.panel1.Controls.Add(this.txtSuma);
            this.panel1.Controls.Add(this.lblSuma);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.txtNumar);
            this.panel1.Controls.Add(this.lblNumar);
            this.panel1.Controls.Add(this.txtSerie);
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
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(707, 68);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(76, 13);
            this.lblContract.TabIndex = 17;
            this.lblContract.Text = "Nr. Contract";
            // 
            // txtFelOperatiune
            // 
            this.txtFelOperatiune.Location = new System.Drawing.Point(432, 60);
            this.txtFelOperatiune.Multiline = true;
            this.txtFelOperatiune.Name = "txtFelOperatiune";
            this.txtFelOperatiune.Size = new System.Drawing.Size(266, 40);
            this.txtFelOperatiune.TabIndex = 16;
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
            // txtCotaTVA
            // 
            this.txtCotaTVA.Location = new System.Drawing.Point(261, 61);
            this.txtCotaTVA.Name = "txtCotaTVA";
            this.txtCotaTVA.Size = new System.Drawing.Size(58, 20);
            this.txtCotaTVA.TabIndex = 13;
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
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(63, 61);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(112, 20);
            this.txtSuma.TabIndex = 11;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(841, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 9;
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
            // txtNumar
            // 
            this.txtNumar.Location = new System.Drawing.Point(704, 10);
            this.txtNumar.Name = "txtNumar";
            this.txtNumar.Size = new System.Drawing.Size(79, 20);
            this.txtNumar.TabIndex = 7;
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
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(591, 10);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(58, 20);
            this.txtSerie.TabIndex = 5;
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
            // cbTipDoc
            // 
            this.cbTipDoc.FormattingEnabled = true;
            this.cbTipDoc.ItemHeight = 13;
            this.cbTipDoc.Location = new System.Drawing.Point(419, 9);
            this.cbTipDoc.Name = "cbTipDoc";
            this.cbTipDoc.Size = new System.Drawing.Size(124, 21);
            this.cbTipDoc.TabIndex = 3;
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
            // txtContract
            // 
            this.txtContract.Location = new System.Drawing.Point(804, 65);
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(153, 20);
            this.txtContract.TabIndex = 18;
            // 
            // bttClear
            // 
            this.bttClear.Enabled = false;
            this.bttClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttClear.Location = new System.Drawing.Point(225, 19);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(51, 23);
            this.bttClear.TabIndex = 0;
            this.bttClear.Text = "Clear";
            this.bttClear.UseVisualStyleBackColor = true;
            this.bttClear.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // ucOperatiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grBoxForm);
            this.Controls.Add(this.grBoxView);
            this.Name = "ucOperatiuni";
            this.Size = new System.Drawing.Size(1000, 742);
            this.grBoxControale.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtNumar;
        private System.Windows.Forms.Label lblNumar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.TextBox txtCotaTVA;
        private System.Windows.Forms.Label lblCotaTva;
        private System.Windows.Forms.CheckBox checkTVA;
        private System.Windows.Forms.TextBox txtFelOperatiune;
        private System.Windows.Forms.Label lblFeluloperatiunii;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.TextBox txtContract;
        private System.Windows.Forms.Button bttClear;
    }
}
