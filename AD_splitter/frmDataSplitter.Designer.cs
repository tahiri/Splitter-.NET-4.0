﻿namespace AD_Splitter
{
    partial class frmDataAD
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataAD));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lnkSplitOutFolder = new System.Windows.Forms.LinkLabel();
			this.chkHTML = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmdStart = new System.Windows.Forms.Button();
			this.txtPrefix = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.txtOutFolder4Split = new System.Windows.Forms.TextBox();
			this.txtSplitChar = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.radMS = new System.Windows.Forms.RadioButton();
			this.radGoogle = new System.Windows.Forms.RadioButton();
			this.lblStartTime = new System.Windows.Forms.Label();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.linkGoogleOut = new System.Windows.Forms.LinkLabel();
			this.linkGoogleInput = new System.Windows.Forms.LinkLabel();
			this.cmdPause = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.txtSeconds = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtMins = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cmdGoogleOutFolder = new System.Windows.Forms.Button();
			this.txtGoogleOutFolder = new System.Windows.Forms.TextBox();
			this.txtChunk = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cmdGoogleInputFolder = new System.Windows.Forms.Button();
			this.txtGoogleInFolder = new System.Windows.Forms.TextBox();
			this.lblMessage = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtLangTo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtLangFrom = new System.Windows.Forms.TextBox();
			this.cmdGoogleTranslate = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aLLAHcomMuhammadcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.of1 = new System.Windows.Forms.OpenFileDialog();
			this.fb1 = new System.Windows.Forms.FolderBrowserDialog();
			this.timerPause = new System.Windows.Forms.Timer(this.components);
			this.bgWorker = new System.ComponentModel.BackgroundWorker();
			this.bgWorker2 = new System.ComponentModel.BackgroundWorker();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(7, 33);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(751, 469);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage1.Size = new System.Drawing.Size(743, 440);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Split Topics";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lnkSplitOutFolder);
			this.groupBox1.Controls.Add(this.chkHTML);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.cmdStart);
			this.groupBox1.Controls.Add(this.txtPrefix);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.txtOutFolder4Split);
			this.groupBox1.Controls.Add(this.txtSplitChar);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.txtFileName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(712, 427);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// lnkSplitOutFolder
			// 
			this.lnkSplitOutFolder.AutoSize = true;
			this.lnkSplitOutFolder.Location = new System.Drawing.Point(8, 103);
			this.lnkSplitOutFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lnkSplitOutFolder.Name = "lnkSplitOutFolder";
			this.lnkSplitOutFolder.Size = new System.Drawing.Size(127, 17);
			this.lnkSplitOutFolder.TabIndex = 41;
			this.lnkSplitOutFolder.TabStop = true;
			this.lnkSplitOutFolder.Text = "Destination Folder:";
			this.lnkSplitOutFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSplitOutFolder_LinkClicked);
			// 
			// chkHTML
			// 
			this.chkHTML.AutoSize = true;
			this.chkHTML.Checked = true;
			this.chkHTML.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkHTML.Location = new System.Drawing.Point(12, 190);
			this.chkHTML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chkHTML.Name = "chkHTML";
			this.chkHTML.Size = new System.Drawing.Size(139, 21);
			this.chkHTML.TabIndex = 12;
			this.chkHTML.Text = "Make HTML Files";
			this.chkHTML.UseVisualStyleBackColor = true;
			this.chkHTML.CheckedChanged += new System.EventHandler(this.chkHTML_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(12, 262);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Size = new System.Drawing.Size(692, 12);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			// 
			// cmdStart
			// 
			this.cmdStart.Location = new System.Drawing.Point(143, 219);
			this.cmdStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmdStart.Name = "cmdStart";
			this.cmdStart.Size = new System.Drawing.Size(116, 36);
			this.cmdStart.TabIndex = 10;
			this.cmdStart.Text = "Start Task";
			this.cmdStart.UseVisualStyleBackColor = true;
			this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
			// 
			// txtPrefix
			// 
			this.txtPrefix.Location = new System.Drawing.Point(258, 143);
			this.txtPrefix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPrefix.Name = "txtPrefix";
			this.txtPrefix.Size = new System.Drawing.Size(402, 22);
			this.txtPrefix.TabIndex = 9;
			this.txtPrefix.Text = "Koran";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 146);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(251, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Target File Prefix (not used for HTML):";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(671, 97);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(33, 28);
			this.button2.TabIndex = 7;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtOutFolder4Split
			// 
			this.txtOutFolder4Split.Location = new System.Drawing.Point(143, 100);
			this.txtOutFolder4Split.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtOutFolder4Split.Name = "txtOutFolder4Split";
			this.txtOutFolder4Split.Size = new System.Drawing.Size(517, 22);
			this.txtOutFolder4Split.TabIndex = 6;
			// 
			// txtSplitChar
			// 
			this.txtSplitChar.Location = new System.Drawing.Point(143, 64);
			this.txtSplitChar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtSplitChar.Name = "txtSplitChar";
			this.txtSplitChar.Size = new System.Drawing.Size(517, 22);
			this.txtSplitChar.TabIndex = 4;
			this.txtSplitChar.Text = "|";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 68);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Split Character:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(671, 25);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(33, 28);
			this.button1.TabIndex = 2;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtFileName
			// 
			this.txtFileName.Location = new System.Drawing.Point(143, 28);
			this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(517, 22);
			this.txtFileName.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Choose File:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage2.Size = new System.Drawing.Size(743, 440);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Translations";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.radMS);
			this.groupBox3.Controls.Add(this.radGoogle);
			this.groupBox3.Controls.Add(this.lblStartTime);
			this.groupBox3.Controls.Add(this.txtLog);
			this.groupBox3.Controls.Add(this.linkGoogleOut);
			this.groupBox3.Controls.Add(this.linkGoogleInput);
			this.groupBox3.Controls.Add(this.cmdPause);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.txtSeconds);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.txtMins);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.cmdGoogleOutFolder);
			this.groupBox3.Controls.Add(this.txtGoogleOutFolder);
			this.groupBox3.Controls.Add(this.txtChunk);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.cmdGoogleInputFolder);
			this.groupBox3.Controls.Add(this.txtGoogleInFolder);
			this.groupBox3.Controls.Add(this.lblMessage);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.txtLangTo);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.txtLangFrom);
			this.groupBox3.Controls.Add(this.cmdGoogleTranslate);
			this.groupBox3.Location = new System.Drawing.Point(8, 7);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Size = new System.Drawing.Size(712, 420);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			// 
			// radMS
			// 
			this.radMS.AutoSize = true;
			this.radMS.Location = new System.Drawing.Point(343, 178);
			this.radMS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.radMS.Name = "radMS";
			this.radMS.Size = new System.Drawing.Size(86, 21);
			this.radMS.TabIndex = 44;
			this.radMS.Text = "Microsoft";
			this.radMS.UseVisualStyleBackColor = true;
			// 
			// radGoogle
			// 
			this.radGoogle.AutoSize = true;
			this.radGoogle.Checked = true;
			this.radGoogle.Location = new System.Drawing.Point(244, 178);
			this.radGoogle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.radGoogle.Name = "radGoogle";
			this.radGoogle.Size = new System.Drawing.Size(75, 21);
			this.radGoogle.TabIndex = 43;
			this.radGoogle.TabStop = true;
			this.radGoogle.Text = "Google";
			this.radGoogle.UseVisualStyleBackColor = true;
			// 
			// lblStartTime
			// 
			this.lblStartTime.AutoSize = true;
			this.lblStartTime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblStartTime.Location = new System.Drawing.Point(256, 96);
			this.lblStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblStartTime.Name = "lblStartTime";
			this.lblStartTime.Size = new System.Drawing.Size(77, 17);
			this.lblStartTime.TabIndex = 42;
			this.lblStartTime.Text = "Start Time:";
			// 
			// txtLog
			// 
			this.txtLog.Location = new System.Drawing.Point(17, 267);
			this.txtLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtLog.Size = new System.Drawing.Size(643, 144);
			this.txtLog.TabIndex = 41;
			// 
			// linkGoogleOut
			// 
			this.linkGoogleOut.AutoSize = true;
			this.linkGoogleOut.Location = new System.Drawing.Point(8, 55);
			this.linkGoogleOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkGoogleOut.Name = "linkGoogleOut";
			this.linkGoogleOut.Size = new System.Drawing.Size(110, 17);
			this.linkGoogleOut.TabIndex = 40;
			this.linkGoogleOut.TabStop = true;
			this.linkGoogleOut.Text = "Translation Out:";
			this.linkGoogleOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGoogleOut_LinkClicked);
			// 
			// linkGoogleInput
			// 
			this.linkGoogleInput.AutoSize = true;
			this.linkGoogleInput.Location = new System.Drawing.Point(8, 20);
			this.linkGoogleInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkGoogleInput.Name = "linkGoogleInput";
			this.linkGoogleInput.Size = new System.Drawing.Size(98, 17);
			this.linkGoogleInput.TabIndex = 39;
			this.linkGoogleInput.TabStop = true;
			this.linkGoogleInput.Text = "Tranlsation In:";
			this.linkGoogleInput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGoogleInput_LinkClicked);
			// 
			// cmdPause
			// 
			this.cmdPause.Enabled = false;
			this.cmdPause.Location = new System.Drawing.Point(545, 121);
			this.cmdPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmdPause.Name = "cmdPause";
			this.cmdPause.Size = new System.Drawing.Size(116, 36);
			this.cmdPause.TabIndex = 38;
			this.cmdPause.Text = "Pause Now";
			this.cmdPause.UseVisualStyleBackColor = true;
			this.cmdPause.Click += new System.EventHandler(this.cmdPause_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(393, 130);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(61, 17);
			this.label13.TabIndex = 37;
			this.label13.Text = "seconds";
			// 
			// txtSeconds
			// 
			this.txtSeconds.Location = new System.Drawing.Point(325, 127);
			this.txtSeconds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtSeconds.Name = "txtSeconds";
			this.txtSeconds.Size = new System.Drawing.Size(59, 22);
			this.txtSeconds.TabIndex = 36;
			this.txtSeconds.Text = "10";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(240, 130);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(78, 17);
			this.label12.TabIndex = 35;
			this.label12.Text = "minutes for";
			// 
			// txtMins
			// 
			this.txtMins.Location = new System.Drawing.Point(195, 127);
			this.txtMins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMins.Name = "txtMins";
			this.txtMins.Size = new System.Drawing.Size(39, 22);
			this.txtMins.TabIndex = 34;
			this.txtMins.Text = "1";
			this.txtMins.TextChanged += new System.EventHandler(this.txtMins_TextChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(8, 130);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(188, 17);
			this.label11.TabIndex = 33;
			this.label11.Text = "Automatic Pause After Every";
			// 
			// cmdGoogleOutFolder
			// 
			this.cmdGoogleOutFolder.Location = new System.Drawing.Point(671, 49);
			this.cmdGoogleOutFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmdGoogleOutFolder.Name = "cmdGoogleOutFolder";
			this.cmdGoogleOutFolder.Size = new System.Drawing.Size(33, 28);
			this.cmdGoogleOutFolder.TabIndex = 32;
			this.cmdGoogleOutFolder.Text = "...";
			this.cmdGoogleOutFolder.UseVisualStyleBackColor = true;
			this.cmdGoogleOutFolder.Click += new System.EventHandler(this.cmdGoogleFolder_Click);
			// 
			// txtGoogleOutFolder
			// 
			this.txtGoogleOutFolder.Location = new System.Drawing.Point(124, 52);
			this.txtGoogleOutFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtGoogleOutFolder.Name = "txtGoogleOutFolder";
			this.txtGoogleOutFolder.Size = new System.Drawing.Size(536, 22);
			this.txtGoogleOutFolder.TabIndex = 31;
			// 
			// txtChunk
			// 
			this.txtChunk.Location = new System.Drawing.Point(180, 92);
			this.txtChunk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtChunk.Name = "txtChunk";
			this.txtChunk.Size = new System.Drawing.Size(59, 22);
			this.txtChunk.TabIndex = 29;
			this.txtChunk.Text = "300";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 96);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(165, 17);
			this.label9.TabIndex = 28;
			this.label9.Text = "Max Words Per Request:";
			// 
			// cmdGoogleInputFolder
			// 
			this.cmdGoogleInputFolder.Location = new System.Drawing.Point(671, 17);
			this.cmdGoogleInputFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmdGoogleInputFolder.Name = "cmdGoogleInputFolder";
			this.cmdGoogleInputFolder.Size = new System.Drawing.Size(33, 28);
			this.cmdGoogleInputFolder.TabIndex = 26;
			this.cmdGoogleInputFolder.Text = "...";
			this.cmdGoogleInputFolder.UseVisualStyleBackColor = true;
			this.cmdGoogleInputFolder.Click += new System.EventHandler(this.cmdGoogleFile_Click);
			// 
			// txtGoogleInFolder
			// 
			this.txtGoogleInFolder.Location = new System.Drawing.Point(124, 20);
			this.txtGoogleInFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtGoogleInFolder.Name = "txtGoogleInFolder";
			this.txtGoogleInFolder.Size = new System.Drawing.Size(536, 22);
			this.txtGoogleInFolder.TabIndex = 27;
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblMessage.Location = new System.Drawing.Point(155, 226);
			this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(352, 17);
			this.lblMessage.TabIndex = 24;
			this.lblMessage.Text = "Please use 2 letters. e.g. Arabic is ar and English is en";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(120, 181);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 17);
			this.label6.TabIndex = 23;
			this.label6.Text = "To:";
			// 
			// txtLangTo
			// 
			this.txtLangTo.Location = new System.Drawing.Point(159, 177);
			this.txtLangTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtLangTo.Name = "txtLangTo";
			this.txtLangTo.Size = new System.Drawing.Size(45, 22);
			this.txtLangTo.TabIndex = 22;
			this.txtLangTo.Text = "en";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 181);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 17);
			this.label5.TabIndex = 21;
			this.label5.Text = "From:";
			// 
			// txtLangFrom
			// 
			this.txtLangFrom.Location = new System.Drawing.Point(65, 177);
			this.txtLangFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtLangFrom.Name = "txtLangFrom";
			this.txtLangFrom.Size = new System.Drawing.Size(45, 22);
			this.txtLangFrom.TabIndex = 19;
			this.txtLangFrom.Text = "ar";
			// 
			// cmdGoogleTranslate
			// 
			this.cmdGoogleTranslate.Location = new System.Drawing.Point(17, 209);
			this.cmdGoogleTranslate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmdGoogleTranslate.Name = "cmdGoogleTranslate";
			this.cmdGoogleTranslate.Size = new System.Drawing.Size(116, 50);
			this.cmdGoogleTranslate.TabIndex = 18;
			this.cmdGoogleTranslate.Text = "Translate";
			this.cmdGoogleTranslate.UseVisualStyleBackColor = true;
			this.cmdGoogleTranslate.Click += new System.EventHandler(this.cmdGoogleTranslate_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(761, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLLAHcomMuhammadcomToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// aLLAHcomMuhammadcomToolStripMenuItem
			// 
			this.aLLAHcomMuhammadcomToolStripMenuItem.Name = "aLLAHcomMuhammadcomToolStripMenuItem";
			this.aLLAHcomMuhammadcomToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
			this.aLLAHcomMuhammadcomToolStripMenuItem.Text = "ALLAH.com Muhammad.com";
			this.aLLAHcomMuhammadcomToolStripMenuItem.Click += new System.EventHandler(this.aLLAHcomMuhammadcomToolStripMenuItem_Click);
			// 
			// of1
			// 
			this.of1.FileName = "openFileDialog1";
			// 
			// timerPause
			// 
			this.timerPause.Tick += new System.EventHandler(this.timerPause_Tick);
			// 
			// bgWorker
			// 
			this.bgWorker.WorkerReportsProgress = true;
			this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
			this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
			this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
			// 
			// bgWorker2
			// 
			this.bgWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker2_DoWork);
			// 
			// frmDataAD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(761, 505);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmDataAD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Data Splitter & Translation";
			this.Load += new System.EventHandler(this.frmDataAD_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLLAHcomMuhammadcomToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog of1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSplitChar;
        private System.Windows.Forms.FolderBrowserDialog fb1;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkHTML;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdGoogleTranslate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLangFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLangTo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button cmdGoogleInputFolder;
        private System.Windows.Forms.TextBox txtGoogleInFolder;
        private System.Windows.Forms.TextBox txtChunk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtOutFolder4Split;
        private System.Windows.Forms.Button cmdGoogleOutFolder;
        private System.Windows.Forms.TextBox txtGoogleOutFolder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMins;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timerPause;
        private System.Windows.Forms.Button cmdPause;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.ComponentModel.BackgroundWorker bgWorker2;
        private System.Windows.Forms.LinkLabel linkGoogleInput;
        private System.Windows.Forms.LinkLabel linkGoogleOut;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.RadioButton radGoogle;
        private System.Windows.Forms.RadioButton radMS;
        private System.Windows.Forms.LinkLabel lnkSplitOutFolder;
    }
}

