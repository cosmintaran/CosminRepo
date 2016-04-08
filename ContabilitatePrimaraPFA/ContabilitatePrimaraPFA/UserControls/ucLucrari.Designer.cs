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
            this.listView1.Size = new System.Drawing.Size(426, 326);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // grBoxLucrare
            // 
            this.grBoxLucrare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxLucrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxLucrare.Location = new System.Drawing.Point(432, 52);
            this.grBoxLucrare.Name = "grBoxLucrare";
            this.grBoxLucrare.Size = new System.Drawing.Size(188, 333);
            this.grBoxLucrare.TabIndex = 4;
            this.grBoxLucrare.TabStop = false;
            this.grBoxLucrare.Text = "Lucrare";
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
            this.Size = new System.Drawing.Size(623, 385);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttNewLucrare;
        private System.Windows.Forms.Button bttEditLucrare;
        private System.Windows.Forms.Button bttDeleteLucrari;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox grBoxLucrare;
    }
}
