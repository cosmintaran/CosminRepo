namespace ContaPFA.View.Forms
{
    partial class FilterForm
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
            this.bttCautaLucrare = new System.Windows.Forms.Button();
            this.txtCautaLucrare = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NrCtr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CriteriuCautare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttCautaLucrare
            // 
            this.bttCautaLucrare.Location = new System.Drawing.Point(294, 12);
            this.bttCautaLucrare.Name = "bttCautaLucrare";
            this.bttCautaLucrare.Size = new System.Drawing.Size(56, 23);
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
            this.txtCautaLucrare.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NrCtr,
            this.CriteriuCautare});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 39);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(259, 153);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // NrCtr
            // 
            this.NrCtr.Text = "Nr. Crt";
            this.NrCtr.Width = 50;
            // 
            // CriteriuCautare
            // 
            this.CriteriuCautare.Text = "Criteriu Cautare";
            this.CriteriuCautare.Width = 210;
            // 
            // bttExit
            // 
            this.bttExit.Location = new System.Drawing.Point(294, 53);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(56, 23);
            this.bttExit.TabIndex = 2;
            this.bttExit.Text = "Renunta";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 204);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtCautaLucrare);
            this.Controls.Add(this.bttCautaLucrare);
            this.MaximumSize = new System.Drawing.Size(377, 243);
            this.MinimumSize = new System.Drawing.Size(377, 243);
            this.Name = "FilterForm";
            this.Text = "Cautare Lucrari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttCautaLucrare;
        private System.Windows.Forms.TextBox txtCautaLucrare;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.ColumnHeader NrCtr;
        private System.Windows.Forms.ColumnHeader CriteriuCautare;
    }
}