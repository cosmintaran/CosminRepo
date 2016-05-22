namespace ContabilitatePrimaraPFA.View.UserControls
{
    partial class ucFacturi
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
            this.grBoxForm = new System.Windows.Forms.GroupBox();
            this.pView = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grBoxFactura = new System.Windows.Forms.GroupBox();
            this.ckBoxPlatitor = new System.Windows.Forms.CheckBox();
            this.lblFSerie = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbFNr = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblFData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grBoxView.SuspendLayout();
            this.grBoxForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grBoxFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxControale
            // 
            this.grBoxControale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxControale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxControale.Location = new System.Drawing.Point(3, 22);
            this.grBoxControale.Name = "grBoxControale";
            this.grBoxControale.Size = new System.Drawing.Size(637, 49);
            this.grBoxControale.TabIndex = 0;
            this.grBoxControale.TabStop = false;
            this.grBoxControale.Text = "groupBox1";
            // 
            // grBoxView
            // 
            this.grBoxView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxView.Controls.Add(this.pView);
            this.grBoxView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxView.Location = new System.Drawing.Point(3, 72);
            this.grBoxView.Name = "grBoxView";
            this.grBoxView.Size = new System.Drawing.Size(637, 660);
            this.grBoxView.TabIndex = 1;
            this.grBoxView.TabStop = false;
            this.grBoxView.Text = "Registru incasari si plati";
            // 
            // grBoxForm
            // 
            this.grBoxForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxForm.Controls.Add(this.panel1);
            this.grBoxForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxForm.Location = new System.Drawing.Point(646, 22);
            this.grBoxForm.Name = "grBoxForm";
            this.grBoxForm.Size = new System.Drawing.Size(351, 715);
            this.grBoxForm.TabIndex = 2;
            this.grBoxForm.TabStop = false;
            this.grBoxForm.Text = "Documentul";
            // 
            // pView
            // 
            this.pView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pView.AutoScroll = true;
            this.pView.Location = new System.Drawing.Point(0, 20);
            this.pView.Name = "pView";
            this.pView.Size = new System.Drawing.Size(637, 640);
            this.pView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grBoxFactura);
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 695);
            this.panel1.TabIndex = 0;
            // 
            // grBoxFactura
            // 
            this.grBoxFactura.Controls.Add(this.label1);
            this.grBoxFactura.Controls.Add(this.dateTimePicker1);
            this.grBoxFactura.Controls.Add(this.lblFData);
            this.grBoxFactura.Controls.Add(this.textBox2);
            this.grBoxFactura.Controls.Add(this.lbFNr);
            this.grBoxFactura.Controls.Add(this.textBox1);
            this.grBoxFactura.Controls.Add(this.lblFSerie);
            this.grBoxFactura.Controls.Add(this.ckBoxPlatitor);
            this.grBoxFactura.Location = new System.Drawing.Point(3, 3);
            this.grBoxFactura.Name = "grBoxFactura";
            this.grBoxFactura.Size = new System.Drawing.Size(345, 373);
            this.grBoxFactura.TabIndex = 0;
            this.grBoxFactura.TabStop = false;
            this.grBoxFactura.Text = "Factura";
            // 
            // ckBoxPlatitor
            // 
            this.ckBoxPlatitor.AutoSize = true;
            this.ckBoxPlatitor.Location = new System.Drawing.Point(4, 20);
            this.ckBoxPlatitor.Name = "ckBoxPlatitor";
            this.ckBoxPlatitor.Size = new System.Drawing.Size(106, 17);
            this.ckBoxPlatitor.TabIndex = 0;
            this.ckBoxPlatitor.Text = "Platitor T.V.A.";
            this.ckBoxPlatitor.UseVisualStyleBackColor = true;
            // 
            // lblFSerie
            // 
            this.lblFSerie.AutoSize = true;
            this.lblFSerie.Location = new System.Drawing.Point(7, 47);
            this.lblFSerie.Name = "lblFSerie";
            this.lblFSerie.Size = new System.Drawing.Size(40, 13);
            this.lblFSerie.TabIndex = 1;
            this.lblFSerie.Text = "Serie:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lbFNr
            // 
            this.lbFNr.AutoSize = true;
            this.lbFNr.Location = new System.Drawing.Point(102, 46);
            this.lbFNr.Name = "lbFNr";
            this.lbFNr.Size = new System.Drawing.Size(24, 13);
            this.lbFNr.TabIndex = 3;
            this.lbFNr.Text = "Nr.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 20);
            this.textBox2.TabIndex = 4;
            // 
            // lblFData
            // 
            this.lblFData.AutoSize = true;
            this.lblFData.Location = new System.Drawing.Point(187, 47);
            this.lblFData.Name = "lblFData";
            this.lblFData.Size = new System.Drawing.Size(38, 13);
            this.lblFData.TabIndex = 5;
            this.lblFData.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Felul Opertiunii";
            // 
            // ucFacturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grBoxForm);
            this.Controls.Add(this.grBoxView);
            this.Controls.Add(this.grBoxControale);
            this.Name = "ucFacturi";
            this.Size = new System.Drawing.Size(1000, 742);
            this.grBoxView.ResumeLayout(false);
            this.grBoxForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grBoxFactura.ResumeLayout(false);
            this.grBoxFactura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxControale;
        private System.Windows.Forms.GroupBox grBoxView;
        private System.Windows.Forms.GroupBox grBoxForm;
        private System.Windows.Forms.Panel pView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grBoxFactura;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFData;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbFNr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFSerie;
        private System.Windows.Forms.CheckBox ckBoxPlatitor;
        private System.Windows.Forms.Label label1;
    }
}
