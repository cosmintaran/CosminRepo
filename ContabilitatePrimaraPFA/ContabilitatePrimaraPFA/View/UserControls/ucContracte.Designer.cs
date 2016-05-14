namespace ContabilitatePrimaraPFA.View.UserControls
{
    partial class ucContracte
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
            this.bttEditContract = new System.Windows.Forms.Button();
            this.bttDeleteContract = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttSearchContract = new System.Windows.Forms.Button();
            this.grBoxContract = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttNewContract
            // 
            this.bttNewContract.Location = new System.Drawing.Point(6, 19);
            this.bttNewContract.Name = "bttNewContract";
            this.bttNewContract.Size = new System.Drawing.Size(51, 23);
            this.bttNewContract.TabIndex = 1;
            this.bttNewContract.Text = "New";
            this.bttNewContract.UseVisualStyleBackColor = true;
            // 
            // bttEditContract
            // 
            this.bttEditContract.Location = new System.Drawing.Point(63, 20);
            this.bttEditContract.Name = "bttEditContract";
            this.bttEditContract.Size = new System.Drawing.Size(51, 23);
            this.bttEditContract.TabIndex = 2;
            this.bttEditContract.Text = "Edit";
            this.bttEditContract.UseVisualStyleBackColor = true;
            // 
            // bttDeleteContract
            // 
            this.bttDeleteContract.Location = new System.Drawing.Point(120, 20);
            this.bttDeleteContract.Name = "bttDeleteContract";
            this.bttDeleteContract.Size = new System.Drawing.Size(51, 23);
            this.bttDeleteContract.TabIndex = 3;
            this.bttDeleteContract.Text = "Delete";
            this.bttDeleteContract.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bttSearchContract);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.bttNewContract);
            this.groupBox1.Controls.Add(this.bttDeleteContract);
            this.groupBox1.Controls.Add(this.bttEditContract);
            this.groupBox1.Location = new System.Drawing.Point(3, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 4;
            // 
            // bttSearchContract
            // 
            this.bttSearchContract.Location = new System.Drawing.Point(338, 20);
            this.bttSearchContract.Name = "bttSearchContract";
            this.bttSearchContract.Size = new System.Drawing.Size(51, 23);
            this.bttSearchContract.TabIndex = 5;
            this.bttSearchContract.Text = "Search";
            this.bttSearchContract.UseVisualStyleBackColor = true;
            // 
            // grBoxContract
            // 
            this.grBoxContract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxContract.Location = new System.Drawing.Point(416, 22);
            this.grBoxContract.Name = "grBoxContract";
            this.grBoxContract.Size = new System.Drawing.Size(581, 456);
            this.grBoxContract.TabIndex = 5;
            this.grBoxContract.TabStop = false;
            this.grBoxContract.Text = "Contract";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 401);
            this.dataGridView1.TabIndex = 6;
            // 
            // ucContracte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grBoxContract);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucContracte";
            this.Size = new System.Drawing.Size(1000, 483);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttNewContract;
        private System.Windows.Forms.Button bttEditContract;
        private System.Windows.Forms.Button bttDeleteContract;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttSearchContract;
        private System.Windows.Forms.GroupBox grBoxContract;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
