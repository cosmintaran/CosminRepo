namespace Import_Excel_into_Database
{
    partial class Form1
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
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttClose = new System.Windows.Forms.Button();
            this.dataGridViewExcelContent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelContent)).BeginInit();
            this.SuspendLayout();
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(31, 270);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(119, 23);
            this.bttAdd.TabIndex = 0;
            this.bttAdd.Text = "Add ExcelFile";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttClose
            // 
            this.bttClose.Location = new System.Drawing.Point(450, 277);
            this.bttClose.Name = "bttClose";
            this.bttClose.Size = new System.Drawing.Size(95, 23);
            this.bttClose.TabIndex = 1;
            this.bttClose.Text = "Close";
            this.bttClose.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExcelContent
            // 
            this.dataGridViewExcelContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcelContent.Location = new System.Drawing.Point(13, 28);
            this.dataGridViewExcelContent.Name = "dataGridViewExcelContent";
            this.dataGridViewExcelContent.Size = new System.Drawing.Size(532, 219);
            this.dataGridViewExcelContent.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 312);
            this.Controls.Add(this.dataGridViewExcelContent);
            this.Controls.Add(this.bttClose);
            this.Controls.Add(this.bttAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttClose;
        private System.Windows.Forms.DataGridView dataGridViewExcelContent;
    }
}

