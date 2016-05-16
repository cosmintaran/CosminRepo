﻿namespace ContabilitatePrimaraPFA.View.UserControls
{
    partial class UcContracte
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
            this.bttNewContract = new System.Windows.Forms.Button();
            this.bttDeleteContract = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttSearchContract = new System.Windows.Forms.Button();
            this.grBoxContract = new System.Windows.Forms.GroupBox();
            this.bttBeneficiar = new System.Windows.Forms.Button();
            this.dateTimePickerContr = new System.Windows.Forms.DateTimePicker();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtObiect = new System.Windows.Forms.TextBox();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtNrContr = new System.Windows.Forms.TextBox();
            this.lblBeneficiar = new System.Windows.Forms.Label();
            this.lblDataContr = new System.Windows.Forms.Label();
            this.lblObservatii = new System.Windows.Forms.Label();
            this.lblObiect = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblNrContract = new System.Windows.Forms.Label();
            this.gridViewContract = new System.Windows.Forms.DataGridView();
            this.bttEdit = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grBoxContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContract)).BeginInit();
            this.SuspendLayout();
            // 
            // bttNewContract
            // 
            this.bttNewContract.Location = new System.Drawing.Point(6, 16);
            this.bttNewContract.Name = "bttNewContract";
            this.bttNewContract.Size = new System.Drawing.Size(51, 23);
            this.bttNewContract.TabIndex = 1;
            this.bttNewContract.Text = "New";
            this.bttNewContract.UseVisualStyleBackColor = true;
            this.bttNewContract.Click += new System.EventHandler(this.bttNewContract_Click);
            // 
            // bttDeleteContract
            // 
            this.bttDeleteContract.Location = new System.Drawing.Point(72, 16);
            this.bttDeleteContract.Name = "bttDeleteContract";
            this.bttDeleteContract.Size = new System.Drawing.Size(51, 23);
            this.bttDeleteContract.TabIndex = 3;
            this.bttDeleteContract.Text = "Delete";
            this.bttDeleteContract.UseVisualStyleBackColor = true;
            this.bttDeleteContract.Click += new System.EventHandler(this.bttDeleteContract_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bttSearchContract);
            this.groupBox1.Controls.Add(this.bttNewContract);
            this.groupBox1.Controls.Add(this.bttDeleteContract);
            this.groupBox1.Location = new System.Drawing.Point(3, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // bttSearchContract
            // 
            this.bttSearchContract.Location = new System.Drawing.Point(155, 16);
            this.bttSearchContract.Name = "bttSearchContract";
            this.bttSearchContract.Size = new System.Drawing.Size(60, 23);
            this.bttSearchContract.TabIndex = 5;
            this.bttSearchContract.Text = "Search...";
            this.bttSearchContract.UseVisualStyleBackColor = true;
            this.bttSearchContract.Click += new System.EventHandler(this.bttSearchContract_Click);
            // 
            // grBoxContract
            // 
            this.grBoxContract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxContract.Controls.Add(this.bttClear);
            this.grBoxContract.Controls.Add(this.bttSave);
            this.grBoxContract.Controls.Add(this.bttCancel);
            this.grBoxContract.Controls.Add(this.bttEdit);
            this.grBoxContract.Controls.Add(this.bttBeneficiar);
            this.grBoxContract.Controls.Add(this.dateTimePickerContr);
            this.grBoxContract.Controls.Add(this.txtObs);
            this.grBoxContract.Controls.Add(this.txtObiect);
            this.grBoxContract.Controls.Add(this.txtSuma);
            this.grBoxContract.Controls.Add(this.txtNrContr);
            this.grBoxContract.Controls.Add(this.lblBeneficiar);
            this.grBoxContract.Controls.Add(this.lblDataContr);
            this.grBoxContract.Controls.Add(this.lblObservatii);
            this.grBoxContract.Controls.Add(this.lblObiect);
            this.grBoxContract.Controls.Add(this.lblSuma);
            this.grBoxContract.Controls.Add(this.lblNrContract);
            this.grBoxContract.Enabled = false;
            this.grBoxContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxContract.Location = new System.Drawing.Point(656, 22);
            this.grBoxContract.Name = "grBoxContract";
            this.grBoxContract.Size = new System.Drawing.Size(341, 715);
            this.grBoxContract.TabIndex = 5;
            this.grBoxContract.TabStop = false;
            this.grBoxContract.Text = "Contract";
            // 
            // bttBeneficiar
            // 
            this.bttBeneficiar.Location = new System.Drawing.Point(99, 123);
            this.bttBeneficiar.Name = "bttBeneficiar";
            this.bttBeneficiar.Size = new System.Drawing.Size(208, 23);
            this.bttBeneficiar.TabIndex = 3;
            this.bttBeneficiar.Text = "Beneficiar...";
            this.bttBeneficiar.UseVisualStyleBackColor = true;
            this.bttBeneficiar.Click += new System.EventHandler(this.bttBeneficiar_Click);
            // 
            // dateTimePickerContr
            // 
            this.dateTimePickerContr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerContr.Location = new System.Drawing.Point(99, 78);
            this.dateTimePickerContr.Name = "dateTimePickerContr";
            this.dateTimePickerContr.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerContr.TabIndex = 2;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(100, 316);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(208, 65);
            this.txtObs.TabIndex = 1;
            // 
            // txtObiect
            // 
            this.txtObiect.Location = new System.Drawing.Point(100, 225);
            this.txtObiect.Multiline = true;
            this.txtObiect.Name = "txtObiect";
            this.txtObiect.Size = new System.Drawing.Size(208, 65);
            this.txtObiect.TabIndex = 1;
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(100, 170);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(208, 20);
            this.txtSuma.TabIndex = 1;
            // 
            // txtNrContr
            // 
            this.txtNrContr.Location = new System.Drawing.Point(99, 33);
            this.txtNrContr.Name = "txtNrContr";
            this.txtNrContr.Size = new System.Drawing.Size(208, 20);
            this.txtNrContr.TabIndex = 1;
            // 
            // lblBeneficiar
            // 
            this.lblBeneficiar.AutoSize = true;
            this.lblBeneficiar.Location = new System.Drawing.Point(7, 128);
            this.lblBeneficiar.Name = "lblBeneficiar";
            this.lblBeneficiar.Size = new System.Drawing.Size(64, 13);
            this.lblBeneficiar.TabIndex = 0;
            this.lblBeneficiar.Text = "Beneficiar";
            // 
            // lblDataContr
            // 
            this.lblDataContr.AutoSize = true;
            this.lblDataContr.Location = new System.Drawing.Point(6, 78);
            this.lblDataContr.Name = "lblDataContr";
            this.lblDataContr.Size = new System.Drawing.Size(86, 13);
            this.lblDataContr.TabIndex = 0;
            this.lblDataContr.Text = "Data Contract";
            // 
            // lblObservatii
            // 
            this.lblObservatii.AutoSize = true;
            this.lblObservatii.Location = new System.Drawing.Point(7, 338);
            this.lblObservatii.Name = "lblObservatii";
            this.lblObservatii.Size = new System.Drawing.Size(64, 13);
            this.lblObservatii.TabIndex = 0;
            this.lblObservatii.Text = "Observatii";
            // 
            // lblObiect
            // 
            this.lblObiect.AutoSize = true;
            this.lblObiect.Location = new System.Drawing.Point(7, 247);
            this.lblObiect.Name = "lblObiect";
            this.lblObiect.Size = new System.Drawing.Size(92, 13);
            this.lblObiect.TabIndex = 0;
            this.lblObiect.Text = "ObiectContract";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(7, 173);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(81, 13);
            this.lblSuma.TabIndex = 0;
            this.lblSuma.Text = "Val. Contract";
            // 
            // lblNrContract
            // 
            this.lblNrContract.AutoSize = true;
            this.lblNrContract.Location = new System.Drawing.Point(6, 36);
            this.lblNrContract.Name = "lblNrContract";
            this.lblNrContract.Size = new System.Drawing.Size(76, 13);
            this.lblNrContract.TabIndex = 0;
            this.lblNrContract.Text = "Nr. Contract";
            // 
            // gridViewContract
            // 
            this.gridViewContract.AllowUserToDeleteRows = false;
            this.gridViewContract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewContract.BackgroundColor = System.Drawing.Color.White;
            this.gridViewContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewContract.Location = new System.Drawing.Point(4, 77);
            this.gridViewContract.MultiSelect = false;
            this.gridViewContract.Name = "gridViewContract";
            this.gridViewContract.Size = new System.Drawing.Size(646, 660);
            this.gridViewContract.TabIndex = 6;
            this.gridViewContract.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewContract_CellClick);
            this.gridViewContract.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewContract_CellDoubleClick);
            // 
            // bttEdit
            // 
            this.bttEdit.Location = new System.Drawing.Point(10, 530);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(75, 23);
            this.bttEdit.TabIndex = 4;
            this.bttEdit.Text = "Edit";
            this.bttEdit.UseVisualStyleBackColor = true;
            this.bttEdit.Visible = false;
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(232, 530);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 5;
            this.bttCancel.Text = "Cancel";
            this.bttCancel.UseVisualStyleBackColor = true;
            this.bttCancel.Visible = false;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(10, 530);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 6;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttClear
            // 
            this.bttClear.Location = new System.Drawing.Point(232, 530);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(75, 23);
            this.bttClear.TabIndex = 7;
            this.bttClear.Text = "Clear";
            this.bttClear.UseVisualStyleBackColor = true;
            this.bttClear.Click += new System.EventHandler(this.bttClear_Click);
            // 
            // UcContracte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridViewContract);
            this.Controls.Add(this.grBoxContract);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcContracte";
            this.Size = new System.Drawing.Size(1000, 742);
            this.groupBox1.ResumeLayout(false);
            this.grBoxContract.ResumeLayout(false);
            this.grBoxContract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttNewContract;
        private System.Windows.Forms.Button bttDeleteContract;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttSearchContract;
        private System.Windows.Forms.GroupBox grBoxContract;
        private System.Windows.Forms.DataGridView gridViewContract;
        private System.Windows.Forms.Label lblNrContract;
        private System.Windows.Forms.Button bttBeneficiar;
        private System.Windows.Forms.DateTimePicker dateTimePickerContr;
        private System.Windows.Forms.TextBox txtNrContr;
        private System.Windows.Forms.Label lblBeneficiar;
        private System.Windows.Forms.Label lblDataContr;
        private System.Windows.Forms.TextBox txtObiect;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label lblObiect;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObservatii;
        private System.Windows.Forms.Button bttEdit;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttClear;
        private System.Windows.Forms.Button bttSave;
    }
}
