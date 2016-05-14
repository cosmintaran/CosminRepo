using System.Windows;
namespace ContabilitatePrimaraPFA.View.UserControls
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bttNewLucrare = new System.Windows.Forms.Button();
            this.bttEditLucrare = new System.Windows.Forms.Button();
            this.bttDeleteLucrari = new System.Windows.Forms.Button();
            this.grBoxLucrare = new System.Windows.Forms.GroupBox();
            this.pControls = new System.Windows.Forms.Panel();
            this.bttClearlucrare = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.txtObservatii = new System.Windows.Forms.TextBox();
            this.lblNrDoc = new System.Windows.Forms.Label();
            this.lblObservatii = new System.Windows.Forms.Label();
            this.txtAvizator = new System.Windows.Forms.TextBox();
            this.lblAvizReg = new System.Windows.Forms.Label();
            this.lblUAT = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.txtCad = new System.Windows.Forms.TextBox();
            this.lblCadastralTop = new System.Windows.Forms.Label();
            this.lblAcceptResp = new System.Windows.Forms.Label();
            this.txtUAT = new System.Windows.Forms.TextBox();
            this.lblNrInregOCPI = new System.Windows.Forms.Label();
            this.lblReceptionatRespins = new System.Windows.Forms.Label();
            this.cbReceptionatRespins = new System.Windows.Forms.ComboBox();
            this.cbAcceptResp = new System.Windows.Forms.ComboBox();
            this.lblContract = new System.Windows.Forms.Label();
            this.cbContract = new System.Windows.Forms.ComboBox();
            this.txtInreg = new System.Windows.Forms.TextBox();
            this.lblTipLucrare = new System.Windows.Forms.Label();
            this.cbTipLucrare = new System.Windows.Forms.ComboBox();
            this.dateTimePickerInreg = new System.Windows.Forms.DateTimePicker();
            this.lblDataInreg = new System.Windows.Forms.Label();
            this.lblTermenSolutionare = new System.Windows.Forms.Label();
            this.dateTimePickerTermen = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LucrariView = new System.Windows.Forms.DataGridView();
            this.errorProviderLucrari = new System.Windows.Forms.ErrorProvider(this.components);
            this.grBoxLucrare.SuspendLayout();
            this.pControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LucrariView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLucrari)).BeginInit();
            this.SuspendLayout();
            // 
            // bttNewLucrare
            // 
            this.bttNewLucrare.Location = new System.Drawing.Point(6, 16);
            this.bttNewLucrare.Name = "bttNewLucrare";
            this.bttNewLucrare.Size = new System.Drawing.Size(51, 23);
            this.bttNewLucrare.TabIndex = 0;
            this.bttNewLucrare.Text = "New";
            this.bttNewLucrare.UseVisualStyleBackColor = true;
            this.bttNewLucrare.Click += new System.EventHandler(this.bttNewLucrare_Click);
            // 
            // bttEditLucrare
            // 
            this.bttEditLucrare.Enabled = false;
            this.bttEditLucrare.Location = new System.Drawing.Point(66, 16);
            this.bttEditLucrare.Name = "bttEditLucrare";
            this.bttEditLucrare.Size = new System.Drawing.Size(51, 23);
            this.bttEditLucrare.TabIndex = 1;
            this.bttEditLucrare.Text = "Edit";
            this.bttEditLucrare.UseVisualStyleBackColor = true;
            // 
            // bttDeleteLucrari
            // 
            this.bttDeleteLucrari.Enabled = false;
            this.bttDeleteLucrari.Location = new System.Drawing.Point(120, 16);
            this.bttDeleteLucrari.Name = "bttDeleteLucrari";
            this.bttDeleteLucrari.Size = new System.Drawing.Size(51, 23);
            this.bttDeleteLucrari.TabIndex = 2;
            this.bttDeleteLucrari.Text = "Delete";
            this.bttDeleteLucrari.UseVisualStyleBackColor = true;
            // 
            // grBoxLucrare
            // 
            this.grBoxLucrare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxLucrare.Controls.Add(this.pControls);
            this.grBoxLucrare.Enabled = false;
            this.grBoxLucrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxLucrare.Location = new System.Drawing.Point(416, 17);
            this.grBoxLucrare.Name = "grBoxLucrare";
            this.grBoxLucrare.Size = new System.Drawing.Size(581, 456);
            this.grBoxLucrare.TabIndex = 4;
            this.grBoxLucrare.TabStop = false;
            this.grBoxLucrare.Text = "Lucrare";
            // 
            // pControls
            // 
            this.pControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pControls.AutoScroll = true;
            this.pControls.AutoSize = true;
            this.pControls.Controls.Add(this.bttClearlucrare);
            this.pControls.Controls.Add(this.bttSave);
            this.pControls.Controls.Add(this.txtObservatii);
            this.pControls.Controls.Add(this.lblNrDoc);
            this.pControls.Controls.Add(this.lblObservatii);
            this.pControls.Controls.Add(this.txtAvizator);
            this.pControls.Controls.Add(this.lblAvizReg);
            this.pControls.Controls.Add(this.lblUAT);
            this.pControls.Controls.Add(this.txtDoc);
            this.pControls.Controls.Add(this.txtCad);
            this.pControls.Controls.Add(this.lblCadastralTop);
            this.pControls.Controls.Add(this.lblAcceptResp);
            this.pControls.Controls.Add(this.txtUAT);
            this.pControls.Controls.Add(this.lblNrInregOCPI);
            this.pControls.Controls.Add(this.lblReceptionatRespins);
            this.pControls.Controls.Add(this.cbReceptionatRespins);
            this.pControls.Controls.Add(this.cbAcceptResp);
            this.pControls.Controls.Add(this.lblContract);
            this.pControls.Controls.Add(this.cbContract);
            this.pControls.Controls.Add(this.txtInreg);
            this.pControls.Controls.Add(this.lblTipLucrare);
            this.pControls.Controls.Add(this.cbTipLucrare);
            this.pControls.Controls.Add(this.dateTimePickerInreg);
            this.pControls.Controls.Add(this.lblDataInreg);
            this.pControls.Controls.Add(this.lblTermenSolutionare);
            this.pControls.Controls.Add(this.dateTimePickerTermen);
            this.pControls.Location = new System.Drawing.Point(6, 21);
            this.pControls.Name = "pControls";
            this.pControls.Size = new System.Drawing.Size(575, 435);
            this.pControls.TabIndex = 0;
            this.pControls.TabStop = true;
            // 
            // bttClearlucrare
            // 
            this.bttClearlucrare.Location = new System.Drawing.Point(472, 352);
            this.bttClearlucrare.Name = "bttClearlucrare";
            this.bttClearlucrare.Size = new System.Drawing.Size(75, 23);
            this.bttClearlucrare.TabIndex = 13;
            this.bttClearlucrare.Text = "Clear";
            this.bttClearlucrare.UseVisualStyleBackColor = true;
            this.bttClearlucrare.Click += new System.EventHandler(this.bttClearlucrare_Click);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(6, 352);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 12;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // txtObservatii
            // 
            this.txtObservatii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservatii.Location = new System.Drawing.Point(346, 242);
            this.txtObservatii.Multiline = true;
            this.txtObservatii.Name = "txtObservatii";
            this.txtObservatii.Size = new System.Drawing.Size(206, 42);
            this.txtObservatii.TabIndex = 11;
            // 
            // lblNrDoc
            // 
            this.lblNrDoc.AutoSize = true;
            this.lblNrDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrDoc.Location = new System.Drawing.Point(12, 12);
            this.lblNrDoc.Name = "lblNrDoc";
            this.lblNrDoc.Size = new System.Drawing.Size(48, 15);
            this.lblNrDoc.TabIndex = 0;
            this.lblNrDoc.Text = "Nr. Doc";
            // 
            // lblObservatii
            // 
            this.lblObservatii.AutoSize = true;
            this.lblObservatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservatii.Location = new System.Drawing.Point(279, 256);
            this.lblObservatii.Name = "lblObservatii";
            this.lblObservatii.Size = new System.Drawing.Size(61, 15);
            this.lblObservatii.TabIndex = 0;
            this.lblObservatii.Text = "Observatii";
            // 
            // txtAvizator
            // 
            this.txtAvizator.Location = new System.Drawing.Point(88, 242);
            this.txtAvizator.Multiline = true;
            this.txtAvizator.Name = "txtAvizator";
            this.txtAvizator.Size = new System.Drawing.Size(184, 42);
            this.txtAvizator.TabIndex = 11;
            // 
            // lblAvizReg
            // 
            this.lblAvizReg.AutoSize = true;
            this.lblAvizReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvizReg.Location = new System.Drawing.Point(12, 256);
            this.lblAvizReg.Name = "lblAvizReg";
            this.lblAvizReg.Size = new System.Drawing.Size(60, 15);
            this.lblAvizReg.TabIndex = 0;
            this.lblAvizReg.Text = "Aviz./Reg.";
            // 
            // lblUAT
            // 
            this.lblUAT.AutoSize = true;
            this.lblUAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUAT.Location = new System.Drawing.Point(12, 131);
            this.lblUAT.Name = "lblUAT";
            this.lblUAT.Size = new System.Drawing.Size(39, 15);
            this.lblUAT.TabIndex = 0;
            this.lblUAT.Text = "U.A.T.";
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(84, 9);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(59, 21);
            this.txtDoc.TabIndex = 1;
            this.txtDoc.Validating += new System.ComponentModel.CancelEventHandler(this.txtDoc_Validating);
            // 
            // txtCad
            // 
            this.txtCad.Location = new System.Drawing.Point(359, 128);
            this.txtCad.Name = "txtCad";
            this.txtCad.Size = new System.Drawing.Size(189, 21);
            this.txtCad.TabIndex = 10;
            this.txtCad.Validating += new System.ComponentModel.CancelEventHandler(this.txtCad_Validating);
            // 
            // lblCadastralTop
            // 
            this.lblCadastralTop.AutoSize = true;
            this.lblCadastralTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastralTop.Location = new System.Drawing.Point(279, 131);
            this.lblCadastralTop.Name = "lblCadastralTop";
            this.lblCadastralTop.Size = new System.Drawing.Size(53, 15);
            this.lblCadastralTop.TabIndex = 0;
            this.lblCadastralTop.Text = "Cad/Top";
            // 
            // lblAcceptResp
            // 
            this.lblAcceptResp.AutoSize = true;
            this.lblAcceptResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceptResp.Location = new System.Drawing.Point(278, 90);
            this.lblAcceptResp.Name = "lblAcceptResp";
            this.lblAcceptResp.Size = new System.Drawing.Size(81, 15);
            this.lblAcceptResp.TabIndex = 2;
            this.lblAcceptResp.Text = "Accept/Refuz.";
            // 
            // txtUAT
            // 
            this.txtUAT.Location = new System.Drawing.Point(87, 128);
            this.txtUAT.Name = "txtUAT";
            this.txtUAT.Size = new System.Drawing.Size(185, 21);
            this.txtUAT.TabIndex = 10;
            this.txtUAT.Validating += new System.ComponentModel.CancelEventHandler(this.txtUAT_Validating);
            // 
            // lblNrInregOCPI
            // 
            this.lblNrInregOCPI.AutoSize = true;
            this.lblNrInregOCPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrInregOCPI.Location = new System.Drawing.Point(163, 12);
            this.lblNrInregOCPI.Name = "lblNrInregOCPI";
            this.lblNrInregOCPI.Size = new System.Drawing.Size(88, 15);
            this.lblNrInregOCPI.TabIndex = 2;
            this.lblNrInregOCPI.Text = "Nr. Inreg. OCPI";
            // 
            // lblReceptionatRespins
            // 
            this.lblReceptionatRespins.AutoSize = true;
            this.lblReceptionatRespins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionatRespins.Location = new System.Drawing.Point(12, 90);
            this.lblReceptionatRespins.Name = "lblReceptionatRespins";
            this.lblReceptionatRespins.Size = new System.Drawing.Size(75, 15);
            this.lblReceptionatRespins.TabIndex = 0;
            this.lblReceptionatRespins.Text = "Recep/Resp";
            // 
            // cbReceptionatRespins
            // 
            this.cbReceptionatRespins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReceptionatRespins.FormattingEnabled = true;
            this.cbReceptionatRespins.Location = new System.Drawing.Point(88, 86);
            this.cbReceptionatRespins.Name = "cbReceptionatRespins";
            this.cbReceptionatRespins.Size = new System.Drawing.Size(184, 23);
            this.cbReceptionatRespins.TabIndex = 2;
            // 
            // cbAcceptResp
            // 
            this.cbAcceptResp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcceptResp.FormattingEnabled = true;
            this.cbAcceptResp.Location = new System.Drawing.Point(359, 86);
            this.cbAcceptResp.Name = "cbAcceptResp";
            this.cbAcceptResp.Size = new System.Drawing.Size(188, 23);
            this.cbAcceptResp.TabIndex = 2;
            this.cbAcceptResp.Validating += new System.ComponentModel.CancelEventHandler(this.cbAcceptResp_Validating);
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContract.Location = new System.Drawing.Point(10, 207);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(52, 15);
            this.lblContract.TabIndex = 0;
            this.lblContract.Text = "Contract";
            // 
            // cbContract
            // 
            this.cbContract.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbContract.FormattingEnabled = true;
            this.cbContract.Items.AddRange(new object[] {
            "<new...>"});
            this.cbContract.Location = new System.Drawing.Point(87, 203);
            this.cbContract.Name = "cbContract";
            this.cbContract.Size = new System.Drawing.Size(185, 23);
            this.cbContract.TabIndex = 5;
            this.cbContract.SelectedIndexChanged += new System.EventHandler(this.cbContract_SelectedIndexChanged);
            this.cbContract.Validating += new System.ComponentModel.CancelEventHandler(this.cbContract_Validating);
            // 
            // txtInreg
            // 
            this.txtInreg.Location = new System.Drawing.Point(257, 9);
            this.txtInreg.Name = "txtInreg";
            this.txtInreg.Size = new System.Drawing.Size(83, 21);
            this.txtInreg.TabIndex = 4;
            this.txtInreg.Validating += new System.ComponentModel.CancelEventHandler(this.txtInreg_Validating);
            // 
            // lblTipLucrare
            // 
            this.lblTipLucrare.AutoSize = true;
            this.lblTipLucrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipLucrare.Location = new System.Drawing.Point(12, 170);
            this.lblTipLucrare.Name = "lblTipLucrare";
            this.lblTipLucrare.Size = new System.Drawing.Size(69, 15);
            this.lblTipLucrare.TabIndex = 0;
            this.lblTipLucrare.Text = "Tip Lucrare";
            // 
            // cbTipLucrare
            // 
            this.cbTipLucrare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipLucrare.FormattingEnabled = true;
            this.cbTipLucrare.Location = new System.Drawing.Point(87, 166);
            this.cbTipLucrare.Name = "cbTipLucrare";
            this.cbTipLucrare.Size = new System.Drawing.Size(465, 23);
            this.cbTipLucrare.TabIndex = 4;
            this.cbTipLucrare.Validating += new System.ComponentModel.CancelEventHandler(this.cbTipLucrare_Validating);
            // 
            // dateTimePickerInreg
            // 
            this.dateTimePickerInreg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInreg.Location = new System.Drawing.Point(84, 41);
            this.dateTimePickerInreg.Name = "dateTimePickerInreg";
            this.dateTimePickerInreg.Size = new System.Drawing.Size(188, 21);
            this.dateTimePickerInreg.TabIndex = 5;
            // 
            // lblDataInreg
            // 
            this.lblDataInreg.AutoSize = true;
            this.lblDataInreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInreg.Location = new System.Drawing.Point(11, 44);
            this.lblDataInreg.Name = "lblDataInreg";
            this.lblDataInreg.Size = new System.Drawing.Size(67, 15);
            this.lblDataInreg.TabIndex = 0;
            this.lblDataInreg.Text = "Data Inreg.";
            // 
            // lblTermenSolutionare
            // 
            this.lblTermenSolutionare.AutoSize = true;
            this.lblTermenSolutionare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermenSolutionare.Location = new System.Drawing.Point(279, 44);
            this.lblTermenSolutionare.Name = "lblTermenSolutionare";
            this.lblTermenSolutionare.Size = new System.Drawing.Size(74, 15);
            this.lblTermenSolutionare.TabIndex = 0;
            this.lblTermenSolutionare.Text = "Termen Sol.";
            // 
            // dateTimePickerTermen
            // 
            this.dateTimePickerTermen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTermen.Location = new System.Drawing.Point(359, 41);
            this.dateTimePickerTermen.Name = "dateTimePickerTermen";
            this.dateTimePickerTermen.Size = new System.Drawing.Size(188, 21);
            this.dateTimePickerTermen.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bttSearch);
            this.groupBox1.Controls.Add(this.bttDeleteLucrari);
            this.groupBox1.Controls.Add(this.bttNewLucrare);
            this.groupBox1.Controls.Add(this.bttEditLucrare);
            this.groupBox1.Location = new System.Drawing.Point(3, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // bttSearch
            // 
            this.bttSearch.Location = new System.Drawing.Point(177, 16);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(59, 23);
            this.bttSearch.TabIndex = 4;
            this.bttSearch.Text = "Search...";
            this.bttSearch.UseVisualStyleBackColor = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LucrariView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 401);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Evidenta Lucrari";
            // 
            // LucrariView
            // 
            this.LucrariView.AllowUserToAddRows = false;
            this.LucrariView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LucrariView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LucrariView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LucrariView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LucrariView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LucrariView.DefaultCellStyle = dataGridViewCellStyle4;
            this.LucrariView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LucrariView.Location = new System.Drawing.Point(3, 16);
            this.LucrariView.Name = "LucrariView";
            this.LucrariView.RowHeadersVisible = false;
            this.LucrariView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LucrariView.Size = new System.Drawing.Size(401, 382);
            this.LucrariView.TabIndex = 0;
            // 
            // errorProviderLucrari
            // 
            this.errorProviderLucrari.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLucrari.ContainerControl = this;
            this.errorProviderLucrari.Tag = "Test";
            // 
            // ucLucrari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grBoxLucrare);
            this.Name = "ucLucrari";
            this.Size = new System.Drawing.Size(1000, 483);
            this.grBoxLucrare.ResumeLayout(false);
            this.grBoxLucrare.PerformLayout();
            this.pControls.ResumeLayout(false);
            this.pControls.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LucrariView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLucrari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttNewLucrare;
        private System.Windows.Forms.Button bttEditLucrare;
        private System.Windows.Forms.Button bttDeleteLucrari;
        private System.Windows.Forms.GroupBox grBoxLucrare;
        private System.Windows.Forms.Panel pControls;
        private System.Windows.Forms.TextBox txtObservatii;
        private System.Windows.Forms.Label lblNrDoc;
        private System.Windows.Forms.Label lblObservatii;
        private System.Windows.Forms.TextBox txtAvizator;
        private System.Windows.Forms.Label lblAvizReg;
        private System.Windows.Forms.Label lblUAT;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.TextBox txtCad;
        private System.Windows.Forms.Label lblCadastralTop;
        private System.Windows.Forms.Label lblAcceptResp;
        private System.Windows.Forms.TextBox txtUAT;
        private System.Windows.Forms.Label lblNrInregOCPI;
        private System.Windows.Forms.Label lblReceptionatRespins;
        private System.Windows.Forms.ComboBox cbReceptionatRespins;
        private System.Windows.Forms.ComboBox cbAcceptResp;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.ComboBox cbContract;
        private System.Windows.Forms.TextBox txtInreg;
        private System.Windows.Forms.Label lblTipLucrare;
        private System.Windows.Forms.ComboBox cbTipLucrare;
        private System.Windows.Forms.DateTimePicker dateTimePickerInreg;
        private System.Windows.Forms.Label lblDataInreg;
        private System.Windows.Forms.Label lblTermenSolutionare;
        private System.Windows.Forms.DateTimePicker dateTimePickerTermen;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttClearlucrare;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView LucrariView;
        private System.Windows.Forms.ErrorProvider errorProviderLucrari;
        private System.Windows.Forms.Button bttSearch;
    }
}
