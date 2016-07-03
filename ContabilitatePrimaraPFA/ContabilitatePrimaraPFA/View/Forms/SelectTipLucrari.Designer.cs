namespace ContabilitatePrimaraPFA.View.Forms
{
    partial class SelectTipLucrari
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
            this.bttCloseTiplucrare = new System.Windows.Forms.Button();
            this.listViewTipLucrare = new System.Windows.Forms.ListView();
            this.NrCrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodLucrare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipLucrare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // bttCloseTiplucrare
            // 
            this.bttCloseTiplucrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCloseTiplucrare.Location = new System.Drawing.Point(383, 117);
            this.bttCloseTiplucrare.Name = "bttCloseTiplucrare";
            this.bttCloseTiplucrare.Size = new System.Drawing.Size(79, 23);
            this.bttCloseTiplucrare.TabIndex = 1;
            this.bttCloseTiplucrare.Text = "Close";
            this.bttCloseTiplucrare.UseVisualStyleBackColor = true;
            this.bttCloseTiplucrare.Click += new System.EventHandler(this.bttCloseTiplucrare_Click);
            // 
            // listViewTipLucrare
            // 
            this.listViewTipLucrare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NrCrt,
            this.CodLucrare,
            this.TipLucrare});
            this.listViewTipLucrare.FullRowSelect = true;
            this.listViewTipLucrare.GridLines = true;
            this.listViewTipLucrare.HideSelection = false;
            this.listViewTipLucrare.Location = new System.Drawing.Point(12, 12);
            this.listViewTipLucrare.MaximumSize = new System.Drawing.Size(450, 97);
            this.listViewTipLucrare.MinimumSize = new System.Drawing.Size(450, 97);
            this.listViewTipLucrare.MultiSelect = false;
            this.listViewTipLucrare.Name = "listViewTipLucrare";
            this.listViewTipLucrare.Size = new System.Drawing.Size(450, 97);
            this.listViewTipLucrare.TabIndex = 0;
            this.listViewTipLucrare.UseCompatibleStateImageBehavior = false;
            this.listViewTipLucrare.View = System.Windows.Forms.View.Details;
            this.listViewTipLucrare.DoubleClick += new System.EventHandler(this.listViewTipLucrare_SelectedIndexChanged);
            // 
            // NrCrt
            // 
            this.NrCrt.Text = "Nr.Crt";
            this.NrCrt.Width = 40;
            // 
            // CodLucrare
            // 
            this.CodLucrare.Text = "Cod Lucrare";
            this.CodLucrare.Width = 95;
            // 
            // TipLucrare
            // 
            this.TipLucrare.Text = "TipLucrare";
            this.TipLucrare.Width = 285;
            // 
            // SelectTipLucrari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 152);
            this.Controls.Add(this.listViewTipLucrare);
            this.Controls.Add(this.bttCloseTiplucrare);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 191);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(490, 191);
            this.Name = "SelectTipLucrari";
            this.Text = "Selecteaza Tip Lucrare";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttCloseTiplucrare;
        private System.Windows.Forms.ListView listViewTipLucrare;
        private System.Windows.Forms.ColumnHeader NrCrt;
        private System.Windows.Forms.ColumnHeader CodLucrare;
        private System.Windows.Forms.ColumnHeader TipLucrare;
    }
}