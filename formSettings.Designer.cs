namespace Nahravadlo
{
	partial class formSettings
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
            System.Windows.Forms.TabPage tabCommon;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnContainerHelp = new System.Windows.Forms.Button();
            this.chkUseMPEGTS = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtDefaultDirectory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectVLC = new System.Windows.Forms.Button();
            this.txtVLCPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tabOption = new System.Windows.Forms.TabControl();
            this.tabCommon2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkFilenameLowerCase = new System.Windows.Forms.CheckBox();
            this.cmbSpacesReplacement = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkFilenameWithoutDiacritics = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilenameMask = new System.Windows.Forms.TextBox();
            this.tabChannels = new System.Windows.Forms.TabPage();
            this.btnChannelDown = new System.Windows.Forms.Button();
            this.btnChannelUp = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblChannelId = new System.Windows.Forms.Label();
            this.lblChannelUri = new System.Windows.Forms.Label();
            this.lblChannelName = new System.Windows.Forms.Label();
            this.btnChannelSave = new System.Windows.Forms.Button();
            this.txtChannelId = new System.Windows.Forms.TextBox();
            this.txtChannelUri = new System.Windows.Forms.TextBox();
            this.txtChannelName = new System.Windows.Forms.TextBox();
            this.btnChannelAdd = new System.Windows.Forms.Button();
            this.btnChannelDelete = new System.Windows.Forms.Button();
            this.lstChannel = new System.Windows.Forms.ListBox();
            this.tabQuickAdd = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnScheduleHelp = new System.Windows.Forms.Button();
            this.btnRegisterScheduleProtocol = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numAddScheduleMinutes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.importFile = new System.Windows.Forms.OpenFileDialog();
            this.exportFile = new System.Windows.Forms.SaveFileDialog();
            this.btnUnregisterScheduleProtocol = new System.Windows.Forms.Button();
            tabCommon = new System.Windows.Forms.TabPage();
            tabCommon.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabOption.SuspendLayout();
            this.tabCommon2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabChannels.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabQuickAdd.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddScheduleMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCommon
            // 
            tabCommon.Controls.Add(this.groupBox1);
            tabCommon.Controls.Add(this.groupBox2);
            tabCommon.Location = new System.Drawing.Point(4, 22);
            tabCommon.Name = "tabCommon";
            tabCommon.Padding = new System.Windows.Forms.Padding(3);
            tabCommon.Size = new System.Drawing.Size(452, 249);
            tabCommon.TabIndex = 0;
            tabCommon.Text = "Obecné";
            tabCommon.ToolTipText = "Obecné nastavení Nahrávadla.";
            tabCommon.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnContainerHelp);
            this.groupBox1.Controls.Add(this.chkUseMPEGTS);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtDefaultDirectory);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSelectVLC);
            this.groupBox1.Controls.Add(this.txtVLCPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nastavení VLC a cesty ukládání";
            // 
            // btnContainerHelp
            // 
            this.btnContainerHelp.Location = new System.Drawing.Point(365, 96);
            this.btnContainerHelp.Name = "btnContainerHelp";
            this.btnContainerHelp.Size = new System.Drawing.Size(69, 23);
            this.btnContainerHelp.TabIndex = 7;
            this.btnContainerHelp.Text = "Nápověda";
            this.btnContainerHelp.UseVisualStyleBackColor = true;
            this.btnContainerHelp.Click += new System.EventHandler(this.btnContainerHelp_Click);
            // 
            // chkUseMPEGTS
            // 
            this.chkUseMPEGTS.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkUseMPEGTS.Location = new System.Drawing.Point(9, 96);
            this.chkUseMPEGTS.Name = "chkUseMPEGTS";
            this.chkUseMPEGTS.Size = new System.Drawing.Size(353, 60);
            this.chkUseMPEGTS.TabIndex = 6;
            this.chkUseMPEGTS.Text = resources.GetString("chkUseMPEGTS.Text");
            this.chkUseMPEGTS.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkUseMPEGTS.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(403, 54);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(34, 22);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtDefaultDirectory
            // 
            this.txtDefaultDirectory.Location = new System.Drawing.Point(121, 55);
            this.txtDefaultDirectory.Name = "txtDefaultDirectory";
            this.txtDefaultDirectory.Size = new System.Drawing.Size(279, 20);
            this.txtDefaultDirectory.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Výchozí adresář: \r\n(pro ukládání souboru)";
            // 
            // btnSelectVLC
            // 
            this.btnSelectVLC.Location = new System.Drawing.Point(403, 23);
            this.btnSelectVLC.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectVLC.Name = "btnSelectVLC";
            this.btnSelectVLC.Size = new System.Drawing.Size(34, 22);
            this.btnSelectVLC.TabIndex = 2;
            this.btnSelectVLC.Text = "...";
            this.btnSelectVLC.UseVisualStyleBackColor = true;
            this.btnSelectVLC.Click += new System.EventHandler(this.btnSelectVLC_Click);
            // 
            // txtVLCPath
            // 
            this.txtVLCPath.Location = new System.Drawing.Point(121, 24);
            this.txtVLCPath.Name = "txtVLCPath";
            this.txtVLCPath.Size = new System.Drawing.Size(279, 20);
            this.txtVLCPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cesta k VLC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.btnHelp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 72);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spustit pod uživatelem";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(71, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(191, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(71, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(191, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(268, 21);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(69, 22);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "Nápověda";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Heslo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uživatel:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Storno";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveAndClose.Location = new System.Drawing.Point(377, 293);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(95, 30);
            this.btnSaveAndClose.TabIndex = 2;
            this.btnSaveAndClose.Text = "Uložit && Zavřít";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // openFile
            // 
            this.openFile.Filter = "Spustitelné soubory|*.exe;*.com;*.cmd;*.bat|Všechny soubory|*.*";
            this.openFile.Title = "Nalezení programu VLC...";
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "Vyberte adresář, kam se budou ukládat soubory, pokud nebude u nich uvedena cesta." +
                "";
            // 
            // tabOption
            // 
            this.tabOption.Controls.Add(tabCommon);
            this.tabOption.Controls.Add(this.tabCommon2);
            this.tabOption.Controls.Add(this.tabChannels);
            this.tabOption.Controls.Add(this.tabQuickAdd);
            this.tabOption.ItemSize = new System.Drawing.Size(100, 18);
            this.tabOption.Location = new System.Drawing.Point(12, 12);
            this.tabOption.Name = "tabOption";
            this.tabOption.SelectedIndex = 0;
            this.tabOption.Size = new System.Drawing.Size(460, 275);
            this.tabOption.TabIndex = 4;
            // 
            // tabCommon2
            // 
            this.tabCommon2.Controls.Add(this.groupBox6);
            this.tabCommon2.Location = new System.Drawing.Point(4, 22);
            this.tabCommon2.Name = "tabCommon2";
            this.tabCommon2.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommon2.Size = new System.Drawing.Size(452, 249);
            this.tabCommon2.TabIndex = 3;
            this.tabCommon2.Text = "Obecné 2";
            this.tabCommon2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.chkFilenameLowerCase);
            this.groupBox6.Controls.Add(this.cmbSpacesReplacement);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.chkFilenameWithoutDiacritics);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txtFilenameMask);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(440, 206);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Jméno výstupního souboru";
            // 
            // chkFilenameLowerCase
            // 
            this.chkFilenameLowerCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFilenameLowerCase.AutoSize = true;
            this.chkFilenameLowerCase.Location = new System.Drawing.Point(259, 143);
            this.chkFilenameLowerCase.Name = "chkFilenameLowerCase";
            this.chkFilenameLowerCase.Size = new System.Drawing.Size(175, 17);
            this.chkFilenameLowerCase.TabIndex = 7;
            this.chkFilenameLowerCase.Text = "Jméno souboru malými písmeny";
            this.chkFilenameLowerCase.UseVisualStyleBackColor = true;
            // 
            // cmbSpacesReplacement
            // 
            this.cmbSpacesReplacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpacesReplacement.FormattingEnabled = true;
            this.cmbSpacesReplacement.Items.AddRange(new object[] {
            "Nepřevádět",
            "Podtržítka",
            "Pomlčky",
            "Odstranit mezery"});
            this.cmbSpacesReplacement.Location = new System.Drawing.Point(110, 166);
            this.cmbSpacesReplacement.Name = "cmbSpacesReplacement";
            this.cmbSpacesReplacement.Size = new System.Drawing.Size(138, 21);
            this.cmbSpacesReplacement.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mezery převést na:";
            // 
            // chkFilenameWithoutDiacritics
            // 
            this.chkFilenameWithoutDiacritics.AutoSize = true;
            this.chkFilenameWithoutDiacritics.Location = new System.Drawing.Point(9, 143);
            this.chkFilenameWithoutDiacritics.Name = "chkFilenameWithoutDiacritics";
            this.chkFilenameWithoutDiacritics.Size = new System.Drawing.Size(162, 17);
            this.chkFilenameWithoutDiacritics.TabIndex = 4;
            this.chkFilenameWithoutDiacritics.Text = "Jméno souboru bez diakritiky";
            this.chkFilenameWithoutDiacritics.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(159, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 98);
            this.label8.TabIndex = 3;
            this.label8.Text = "%D - Den\r\n%M - Měsíc\r\n%Y - Čtyřmístný rok\r\n%y - Dvoumístný rok\r\n\r\n%L - Délka pořa" +
                "du v minutách\r\n%% - Znak procenta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 70);
            this.label7.TabIndex = 2;
            this.label7.Text = "%N - Název pořadu \r\n%S - Stanice\r\n\r\n%H - Hodina začátku\r\n%i - Minuta začátku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Maska souboru:";
            // 
            // txtFilenameMask
            // 
            this.txtFilenameMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilenameMask.Location = new System.Drawing.Point(95, 19);
            this.txtFilenameMask.Name = "txtFilenameMask";
            this.txtFilenameMask.Size = new System.Drawing.Size(339, 20);
            this.txtFilenameMask.TabIndex = 0;
            // 
            // tabChannels
            // 
            this.tabChannels.Controls.Add(this.btnChannelDown);
            this.tabChannels.Controls.Add(this.btnChannelUp);
            this.tabChannels.Controls.Add(this.btnExport);
            this.tabChannels.Controls.Add(this.btnImport);
            this.tabChannels.Controls.Add(this.groupBox3);
            this.tabChannels.Controls.Add(this.btnChannelAdd);
            this.tabChannels.Controls.Add(this.btnChannelDelete);
            this.tabChannels.Controls.Add(this.lstChannel);
            this.tabChannels.Location = new System.Drawing.Point(4, 22);
            this.tabChannels.Name = "tabChannels";
            this.tabChannels.Size = new System.Drawing.Size(452, 249);
            this.tabChannels.TabIndex = 1;
            this.tabChannels.Text = "Stanice";
            this.tabChannels.ToolTipText = "Nastavení stanic, které se zobrazí při zakládání nového nahrávání.";
            this.tabChannels.UseVisualStyleBackColor = true;
            // 
            // btnChannelDown
            // 
            this.btnChannelDown.AutoSize = true;
            this.btnChannelDown.Enabled = false;
            this.btnChannelDown.Image = ((System.Drawing.Image)(resources.GetObject("btnChannelDown.Image")));
            this.btnChannelDown.Location = new System.Drawing.Point(138, 182);
            this.btnChannelDown.Name = "btnChannelDown";
            this.btnChannelDown.Size = new System.Drawing.Size(22, 33);
            this.btnChannelDown.TabIndex = 6;
            this.btnChannelDown.UseVisualStyleBackColor = true;
            this.btnChannelDown.Click += new System.EventHandler(this.btnChannelDown_Click);
            // 
            // btnChannelUp
            // 
            this.btnChannelUp.AutoSize = true;
            this.btnChannelUp.Enabled = false;
            this.btnChannelUp.Image = ((System.Drawing.Image)(resources.GetObject("btnChannelUp.Image")));
            this.btnChannelUp.Location = new System.Drawing.Point(138, 3);
            this.btnChannelUp.Name = "btnChannelUp";
            this.btnChannelUp.Size = new System.Drawing.Size(22, 33);
            this.btnChannelUp.TabIndex = 5;
            this.btnChannelUp.UseVisualStyleBackColor = true;
            this.btnChannelUp.Click += new System.EventHandler(this.btnChannelUp_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(376, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(73, 25);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Exportovat";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(297, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(73, 25);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Importovat";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblChannelId);
            this.groupBox3.Controls.Add(this.lblChannelUri);
            this.groupBox3.Controls.Add(this.lblChannelName);
            this.groupBox3.Controls.Add(this.btnChannelSave);
            this.groupBox3.Controls.Add(this.txtChannelId);
            this.groupBox3.Controls.Add(this.txtChannelUri);
            this.groupBox3.Controls.Add(this.txtChannelName);
            this.groupBox3.Location = new System.Drawing.Point(166, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 212);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vlastnosti stanice";
            // 
            // lblChannelId
            // 
            this.lblChannelId.AutoSize = true;
            this.lblChannelId.Location = new System.Drawing.Point(6, 74);
            this.lblChannelId.Name = "lblChannelId";
            this.lblChannelId.Size = new System.Drawing.Size(21, 13);
            this.lblChannelId.TabIndex = 8;
            this.lblChannelId.Text = "ID:";
            // 
            // lblChannelUri
            // 
            this.lblChannelUri.AutoSize = true;
            this.lblChannelUri.Location = new System.Drawing.Point(6, 48);
            this.lblChannelUri.Name = "lblChannelUri";
            this.lblChannelUri.Size = new System.Drawing.Size(29, 13);
            this.lblChannelUri.TabIndex = 7;
            this.lblChannelUri.Text = "URI:";
            // 
            // lblChannelName
            // 
            this.lblChannelName.AutoSize = true;
            this.lblChannelName.Location = new System.Drawing.Point(6, 22);
            this.lblChannelName.Name = "lblChannelName";
            this.lblChannelName.Size = new System.Drawing.Size(41, 13);
            this.lblChannelName.TabIndex = 6;
            this.lblChannelName.Text = "Název:";
            // 
            // btnChannelSave
            // 
            this.btnChannelSave.Enabled = false;
            this.btnChannelSave.Location = new System.Drawing.Point(205, 97);
            this.btnChannelSave.Name = "btnChannelSave";
            this.btnChannelSave.Size = new System.Drawing.Size(72, 25);
            this.btnChannelSave.TabIndex = 5;
            this.btnChannelSave.Text = "Uložit";
            this.btnChannelSave.UseVisualStyleBackColor = true;
            this.btnChannelSave.Click += new System.EventHandler(this.btnChannelSave_Click);
            // 
            // txtChannelId
            // 
            this.txtChannelId.Enabled = false;
            this.txtChannelId.Location = new System.Drawing.Point(47, 71);
            this.txtChannelId.Name = "txtChannelId";
            this.txtChannelId.Size = new System.Drawing.Size(230, 20);
            this.txtChannelId.TabIndex = 2;
            // 
            // txtChannelUri
            // 
            this.txtChannelUri.Enabled = false;
            this.txtChannelUri.Location = new System.Drawing.Point(47, 45);
            this.txtChannelUri.Name = "txtChannelUri";
            this.txtChannelUri.Size = new System.Drawing.Size(230, 20);
            this.txtChannelUri.TabIndex = 1;
            // 
            // txtChannelName
            // 
            this.txtChannelName.Enabled = false;
            this.txtChannelName.Location = new System.Drawing.Point(47, 19);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Size = new System.Drawing.Size(230, 20);
            this.txtChannelName.TabIndex = 0;
            // 
            // btnChannelAdd
            // 
            this.btnChannelAdd.Location = new System.Drawing.Point(3, 221);
            this.btnChannelAdd.Name = "btnChannelAdd";
            this.btnChannelAdd.Size = new System.Drawing.Size(60, 25);
            this.btnChannelAdd.TabIndex = 4;
            this.btnChannelAdd.Text = "Přidat";
            this.btnChannelAdd.UseVisualStyleBackColor = true;
            this.btnChannelAdd.Click += new System.EventHandler(this.btnChannelAdd_Click);
            // 
            // btnChannelDelete
            // 
            this.btnChannelDelete.Enabled = false;
            this.btnChannelDelete.Location = new System.Drawing.Point(69, 221);
            this.btnChannelDelete.Name = "btnChannelDelete";
            this.btnChannelDelete.Size = new System.Drawing.Size(63, 25);
            this.btnChannelDelete.TabIndex = 3;
            this.btnChannelDelete.Text = "Smazat";
            this.btnChannelDelete.UseVisualStyleBackColor = true;
            this.btnChannelDelete.Click += new System.EventHandler(this.btnChannelDelete_Click);
            // 
            // lstChannel
            // 
            this.lstChannel.FormattingEnabled = true;
            this.lstChannel.Location = new System.Drawing.Point(3, 3);
            this.lstChannel.Name = "lstChannel";
            this.lstChannel.Size = new System.Drawing.Size(129, 212);
            this.lstChannel.TabIndex = 0;
            this.lstChannel.SelectedIndexChanged += new System.EventHandler(this.lstChannel_SelectedIndexChanged);
            // 
            // tabQuickAdd
            // 
            this.tabQuickAdd.Controls.Add(this.groupBox5);
            this.tabQuickAdd.Controls.Add(this.groupBox4);
            this.tabQuickAdd.Location = new System.Drawing.Point(4, 22);
            this.tabQuickAdd.Name = "tabQuickAdd";
            this.tabQuickAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuickAdd.Size = new System.Drawing.Size(452, 249);
            this.tabQuickAdd.TabIndex = 2;
            this.tabQuickAdd.Text = "Rychlé přidání";
            this.tabQuickAdd.ToolTipText = "Nastavení vlastností rychlého přidání.";
            this.tabQuickAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnUnregisterScheduleProtocol);
            this.groupBox5.Controls.Add(this.btnScheduleHelp);
            this.groupBox5.Controls.Add(this.btnRegisterScheduleProtocol);
            this.groupBox5.Location = new System.Drawing.Point(6, 55);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(440, 128);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Protokol schedule";
            // 
            // btnScheduleHelp
            // 
            this.btnScheduleHelp.Location = new System.Drawing.Point(153, 91);
            this.btnScheduleHelp.Name = "btnScheduleHelp";
            this.btnScheduleHelp.Size = new System.Drawing.Size(120, 30);
            this.btnScheduleHelp.TabIndex = 1;
            this.btnScheduleHelp.Text = "Co to je?";
            this.btnScheduleHelp.UseVisualStyleBackColor = true;
            this.btnScheduleHelp.Click += new System.EventHandler(this.btnScheduleHelp_Click);
            // 
            // btnRegisterScheduleProtocol
            // 
            this.btnRegisterScheduleProtocol.Location = new System.Drawing.Point(105, 19);
            this.btnRegisterScheduleProtocol.Name = "btnRegisterScheduleProtocol";
            this.btnRegisterScheduleProtocol.Size = new System.Drawing.Size(230, 30);
            this.btnRegisterScheduleProtocol.TabIndex = 0;
            this.btnRegisterScheduleProtocol.Text = "Zaregistrovat protokol schedule";
            this.btnRegisterScheduleProtocol.UseVisualStyleBackColor = true;
            this.btnRegisterScheduleProtocol.Click += new System.EventHandler(this.btnRegisterScheduleProtocol_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numAddScheduleMinutes);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 43);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Přidání času";
            // 
            // numAddScheduleMinutes
            // 
            this.numAddScheduleMinutes.Location = new System.Drawing.Point(242, 14);
            this.numAddScheduleMinutes.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numAddScheduleMinutes.Name = "numAddScheduleMinutes";
            this.numAddScheduleMinutes.Size = new System.Drawing.Size(59, 20);
            this.numAddScheduleMinutes.TabIndex = 1;
            this.numAddScheduleMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Čas  přidaný na konec nahrávání (v minutách):";
            // 
            // importFile
            // 
            this.importFile.DefaultExt = "xspf";
            this.importFile.Filter = "XSPF playlist (*.xspf)|*.xspf|Všechny soubory (*.*)|*.*";
            this.importFile.Title = "Importovat kanály z ...";
            // 
            // exportFile
            // 
            this.exportFile.DefaultExt = "xspf";
            this.exportFile.Filter = "XSPF playlist (*.xspf)|*.xspf|Všechny soubory (*.*)|*.*";
            this.exportFile.Title = "Exportovat kanály do ...";
            // 
            // btnUnregisterScheduleProtocol
            // 
            this.btnUnregisterScheduleProtocol.Location = new System.Drawing.Point(105, 55);
            this.btnUnregisterScheduleProtocol.Name = "btnUnregisterScheduleProtocol";
            this.btnUnregisterScheduleProtocol.Size = new System.Drawing.Size(230, 30);
            this.btnUnregisterScheduleProtocol.TabIndex = 2;
            this.btnUnregisterScheduleProtocol.Text = "Odregistrovat protokol schedule";
            this.btnUnregisterScheduleProtocol.UseVisualStyleBackColor = true;
            this.btnUnregisterScheduleProtocol.Click += new System.EventHandler(this.btnUnregisterScheduleProtocol_Click);
            // 
            // formSettings
            // 
            this.AcceptButton = this.btnSaveAndClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(484, 334);
            this.Controls.Add(this.tabOption);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nastavení programu Nahrávadlo";
            tabCommon.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabOption.ResumeLayout(false);
            this.tabCommon2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabChannels.ResumeLayout(false);
            this.tabChannels.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabQuickAdd.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddScheduleMinutes)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSaveAndClose;
		private System.Windows.Forms.OpenFileDialog openFile;
		private System.Windows.Forms.FolderBrowserDialog folderBrowser;
		private System.Windows.Forms.TabControl tabOption;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnContainerHelp;
		private System.Windows.Forms.CheckBox chkUseMPEGTS;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtDefaultDirectory;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSelectVLC;
		private System.Windows.Forms.TextBox txtVLCPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.TabPage tabChannels;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblChannelId;
		private System.Windows.Forms.Label lblChannelUri;
		private System.Windows.Forms.Label lblChannelName;
		private System.Windows.Forms.Button btnChannelSave;
		private System.Windows.Forms.Button btnChannelAdd;
		private System.Windows.Forms.Button btnChannelDelete;
		private System.Windows.Forms.TextBox txtChannelId;
		private System.Windows.Forms.TextBox txtChannelUri;
		private System.Windows.Forms.TextBox txtChannelName;
		private System.Windows.Forms.ListBox lstChannel;
		private System.Windows.Forms.Button btnChannelDown;
		private System.Windows.Forms.Button btnChannelUp;
		private System.Windows.Forms.OpenFileDialog importFile;
		private System.Windows.Forms.SaveFileDialog exportFile;
		private System.Windows.Forms.TabPage tabQuickAdd;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.NumericUpDown numAddScheduleMinutes;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnRegisterScheduleProtocol;
		private System.Windows.Forms.Button btnScheduleHelp;
        private System.Windows.Forms.TabPage tabCommon2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtFilenameMask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSpacesReplacement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkFilenameWithoutDiacritics;
        private System.Windows.Forms.CheckBox chkFilenameLowerCase;
        private System.Windows.Forms.Button btnUnregisterScheduleProtocol;
	}
}