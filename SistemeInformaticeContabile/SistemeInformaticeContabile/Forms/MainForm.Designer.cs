namespace SistemeInformaticeContabile
{
    partial class MainForm
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
            this.dgViewDatabase = new System.Windows.Forms.DataGridView();
            this.bttnContracte = new System.Windows.Forms.Button();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.bttFacturi = new System.Windows.Forms.Button();
            this.bttnProceseVerbale = new System.Windows.Forms.Button();
            this.bttnLucrareNoua = new System.Windows.Forms.Button();
            this.groupBoxExport = new System.Windows.Forms.GroupBox();
            this.bttReceiptsJournal = new System.Windows.Forms.Button();
            this.bttnExports392B = new System.Windows.Forms.Button();
            this.bttnExportContracts = new System.Windows.Forms.Button();
            this.bttnExportJobs = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.comboBoxViewTable = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewDatabase)).BeginInit();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxExport.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgViewDatabase
            // 
            this.dgViewDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewDatabase.Location = new System.Drawing.Point(6, 19);
            this.dgViewDatabase.Name = "dgViewDatabase";
            this.dgViewDatabase.Size = new System.Drawing.Size(1038, 317);
            this.dgViewDatabase.TabIndex = 0;
            // 
            // bttnContracte
            // 
            this.bttnContracte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnContracte.Location = new System.Drawing.Point(6, 98);
            this.bttnContracte.Name = "bttnContracte";
            this.bttnContracte.Size = new System.Drawing.Size(159, 29);
            this.bttnContracte.TabIndex = 1;
            this.bttnContracte.Text = "Contract Nou";
            this.bttnContracte.UseVisualStyleBackColor = true;
            this.bttnContracte.Click += new System.EventHandler(this.bttnContracte_Click);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.bttFacturi);
            this.groupBoxEdit.Controls.Add(this.bttnProceseVerbale);
            this.groupBoxEdit.Controls.Add(this.bttnLucrareNoua);
            this.groupBoxEdit.Controls.Add(this.bttnContracte);
            this.groupBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEdit.Location = new System.Drawing.Point(23, 415);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(496, 147);
            this.groupBoxEdit.TabIndex = 2;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Editing buttons";
            // 
            // bttFacturi
            // 
            this.bttFacturi.Location = new System.Drawing.Point(270, 99);
            this.bttFacturi.Name = "bttFacturi";
            this.bttFacturi.Size = new System.Drawing.Size(159, 29);
            this.bttFacturi.TabIndex = 5;
            this.bttFacturi.Text = "Facturi Noi";
            this.bttFacturi.UseVisualStyleBackColor = true;
            // 
            // bttnProceseVerbale
            // 
            this.bttnProceseVerbale.Location = new System.Drawing.Point(270, 38);
            this.bttnProceseVerbale.Name = "bttnProceseVerbale";
            this.bttnProceseVerbale.Size = new System.Drawing.Size(159, 29);
            this.bttnProceseVerbale.TabIndex = 4;
            this.bttnProceseVerbale.Text = "Proces Verbal Nou";
            this.bttnProceseVerbale.UseVisualStyleBackColor = true;
            // 
            // bttnLucrareNoua
            // 
            this.bttnLucrareNoua.Location = new System.Drawing.Point(6, 38);
            this.bttnLucrareNoua.Name = "bttnLucrareNoua";
            this.bttnLucrareNoua.Size = new System.Drawing.Size(159, 29);
            this.bttnLucrareNoua.TabIndex = 3;
            this.bttnLucrareNoua.Text = "Lucrare Noua";
            this.bttnLucrareNoua.UseVisualStyleBackColor = true;
            this.bttnLucrareNoua.Click += new System.EventHandler(this.bttnLucrareNoua_Click);
            // 
            // groupBoxExport
            // 
            this.groupBoxExport.Controls.Add(this.bttReceiptsJournal);
            this.groupBoxExport.Controls.Add(this.bttnExports392B);
            this.groupBoxExport.Controls.Add(this.bttnExportContracts);
            this.groupBoxExport.Controls.Add(this.bttnExportJobs);
            this.groupBoxExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExport.Location = new System.Drawing.Point(571, 415);
            this.groupBoxExport.Name = "groupBoxExport";
            this.groupBoxExport.Size = new System.Drawing.Size(496, 147);
            this.groupBoxExport.TabIndex = 3;
            this.groupBoxExport.TabStop = false;
            this.groupBoxExport.Text = "Export Buttons";
            // 
            // bttReceiptsJournal
            // 
            this.bttReceiptsJournal.Location = new System.Drawing.Point(284, 99);
            this.bttReceiptsJournal.Name = "bttReceiptsJournal";
            this.bttReceiptsJournal.Size = new System.Drawing.Size(159, 29);
            this.bttReceiptsJournal.TabIndex = 3;
            this.bttReceiptsJournal.Text = "Receipts Journal";
            this.bttReceiptsJournal.UseVisualStyleBackColor = true;
            // 
            // bttnExports392B
            // 
            this.bttnExports392B.Location = new System.Drawing.Point(284, 39);
            this.bttnExports392B.Name = "bttnExports392B";
            this.bttnExports392B.Size = new System.Drawing.Size(159, 29);
            this.bttnExports392B.TabIndex = 2;
            this.bttnExports392B.Text = " 392B";
            this.bttnExports392B.UseVisualStyleBackColor = true;
            // 
            // bttnExportContracts
            // 
            this.bttnExportContracts.Location = new System.Drawing.Point(36, 99);
            this.bttnExportContracts.Name = "bttnExportContracts";
            this.bttnExportContracts.Size = new System.Drawing.Size(159, 29);
            this.bttnExportContracts.TabIndex = 1;
            this.bttnExportContracts.Text = " Contracts";
            this.bttnExportContracts.UseVisualStyleBackColor = true;
            // 
            // bttnExportJobs
            // 
            this.bttnExportJobs.Location = new System.Drawing.Point(36, 38);
            this.bttnExportJobs.Name = "bttnExportJobs";
            this.bttnExportJobs.Size = new System.Drawing.Size(159, 29);
            this.bttnExportJobs.TabIndex = 0;
            this.bttnExportJobs.Text = " Jobs";
            this.bttnExportJobs.UseVisualStyleBackColor = true;
            // 
            // bttnExit
            // 
            this.bttnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.Location = new System.Drawing.Point(908, 27);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(159, 29);
            this.bttnExit.TabIndex = 4;
            this.bttnExit.Text = "Exit";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.dgViewDatabase);
            this.groupBoxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxResults.Location = new System.Drawing.Point(23, 67);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(1050, 342);
            this.groupBoxResults.TabIndex = 6;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // comboBoxViewTable
            // 
            this.comboBoxViewTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxViewTable.FormattingEnabled = true;
            this.comboBoxViewTable.Location = new System.Drawing.Point(94, 27);
            this.comboBoxViewTable.Name = "comboBoxViewTable";
            this.comboBoxViewTable.Size = new System.Drawing.Size(180, 21);
            this.comboBoxViewTable.TabIndex = 7;
            this.comboBoxViewTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxViewTable_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 574);
            this.Controls.Add(this.comboBoxViewTable);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.groupBoxExport);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Contabilitate Primara";
            ((System.ComponentModel.ISupportInitialize)(this.dgViewDatabase)).EndInit();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxExport.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewDatabase;
        private System.Windows.Forms.Button bttnContracte;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button bttnLucrareNoua;
        private System.Windows.Forms.GroupBox groupBoxExport;
        private System.Windows.Forms.Button bttReceiptsJournal;
        private System.Windows.Forms.Button bttnExports392B;
        private System.Windows.Forms.Button bttnExportContracts;
        private System.Windows.Forms.Button bttnExportJobs;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.ComboBox comboBoxViewTable;
        private System.Windows.Forms.Button bttFacturi;
        private System.Windows.Forms.Button bttnProceseVerbale;
    }
}

