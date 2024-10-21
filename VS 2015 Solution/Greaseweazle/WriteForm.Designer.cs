// WriteForm.Designer.cs
//
// Greaseweazle GUI Wrapper
//
// Copyright (c) 2019 Don Mankin <don.mankin@yahoo.com>
//
// MIT License
//
// See the file LICENSE for more details, or visit <https://opensource.org/licenses/MIT>.

namespace Greaseweazle
{
    partial class WriteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHostTools = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.gbDiskType = new System.Windows.Forms.GroupBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.lblDiskType = new System.Windows.Forms.Label();
            this.cbExtension = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnWTDSelectFile = new System.Windows.Forms.Button();
            this.txtWTDCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.gbWriteToDisk = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkRevTrkData = new System.Windows.Forms.CheckBox();
            this.txtRetries = new System.Windows.Forms.TextBox();
            this.chkRetries = new System.Windows.Forms.CheckBox();
            this.chkHeadsSet = new System.Windows.Forms.CheckBox();
            this.txtHeadsSet = new System.Windows.Forms.TextBox();
            this.chkCylSet = new System.Windows.Forms.CheckBox();
            this.txtCylSet = new System.Windows.Forms.TextBox();
            this.gbFlippy = new System.Windows.Forms.GroupBox();
            this.chkFlippyOffset = new System.Windows.Forms.CheckBox();
            this.rbFlippyPanasonic = new System.Windows.Forms.RadioButton();
            this.rbFlippyTeac = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTG43 = new System.Windows.Forms.CheckBox();
            this.gbHighLow = new System.Windows.Forms.GroupBox();
            this.chkPin2High = new System.Windows.Forms.CheckBox();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.txtFakeIndex = new System.Windows.Forms.TextBox();
            this.cbFakeIndex = new System.Windows.Forms.ComboBox();
            this.chkFakeIndex = new System.Windows.Forms.CheckBox();
            this.txtPrecomp = new System.Windows.Forms.TextBox();
            this.chkPrecomp = new System.Windows.Forms.CheckBox();
            this.chkEraseEmpty = new System.Windows.Forms.CheckBox();
            this.txtDriveSelectWTD = new System.Windows.Forms.TextBox();
            this.chkDriveSelectWTD = new System.Windows.Forms.CheckBox();
            this.txtDoubleStep = new System.Windows.Forms.TextBox();
            this.chkDoubleStep = new System.Windows.Forms.CheckBox();
            this.toolTipWTD = new System.Windows.Forms.ToolTip(this.components);
            this.threadWorker = new System.ComponentModel.BackgroundWorker();
            this.ctxOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxClearOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSaveOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.chkHeadSwap = new System.Windows.Forms.CheckBox();
            this.chkHardSectors = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.gbDiskType.SuspendLayout();
            this.gbWriteToDisk.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbFlippy.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbHighLow.SuspendLayout();
            this.ctxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHostTools);
            this.groupBox1.Controls.Add(this.lbOutput);
            this.groupBox1.Controls.Add(this.gbDiskType);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnLaunch);
            this.groupBox1.Controls.Add(this.btnWTDSelectFile);
            this.groupBox1.Controls.Add(this.txtWTDCommandLine);
            this.groupBox1.Controls.Add(this.lblStaticCL);
            this.groupBox1.Controls.Add(this.gbWriteToDisk);
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(586, 521);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(155, 495);
            this.lblHostTools.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(275, 19);
            this.lblHostTools.TabIndex = 43;
            this.lblHostTools.Text = "for Host Tools v0.00";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOutput
            // 
            this.lbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbOutput.ForeColor = System.Drawing.Color.White;
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.HorizontalScrollbar = true;
            this.lbOutput.Location = new System.Drawing.Point(10, 325);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(2);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(566, 134);
            this.lbOutput.TabIndex = 39;
            this.toolTipWTD.SetToolTip(this.lbOutput, "Right click for options");
            // 
            // gbDiskType
            // 
            this.gbDiskType.Controls.Add(this.lblFormat);
            this.gbDiskType.Controls.Add(this.cbFormat);
            this.gbDiskType.Controls.Add(this.lblDiskType);
            this.gbDiskType.Controls.Add(this.cbExtension);
            this.gbDiskType.Location = new System.Drawing.Point(10, 203);
            this.gbDiskType.Margin = new System.Windows.Forms.Padding(2);
            this.gbDiskType.Name = "gbDiskType";
            this.gbDiskType.Padding = new System.Windows.Forms.Padding(2);
            this.gbDiskType.Size = new System.Drawing.Size(565, 50);
            this.gbDiskType.TabIndex = 32;
            this.gbDiskType.TabStop = false;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(297, 20);
            this.lblFormat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(42, 13);
            this.lblFormat.TabIndex = 35;
            this.lblFormat.Text = "Format:";
            // 
            // cbFormat
            // 
            this.cbFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbFormat.ForeColor = System.Drawing.Color.White;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(355, 17);
            this.cbFormat.Margin = new System.Windows.Forms.Padding(2);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(191, 21);
            this.cbFormat.TabIndex = 36;
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // lblDiskType
            // 
            this.lblDiskType.AutoSize = true;
            this.lblDiskType.Location = new System.Drawing.Point(11, 20);
            this.lblDiskType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiskType.Name = "lblDiskType";
            this.lblDiskType.Size = new System.Drawing.Size(55, 13);
            this.lblDiskType.TabIndex = 33;
            this.lblDiskType.Text = "DiskType:";
            // 
            // cbExtension
            // 
            this.cbExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbExtension.ForeColor = System.Drawing.Color.White;
            this.cbExtension.FormattingEnabled = true;
            this.cbExtension.Location = new System.Drawing.Point(86, 17);
            this.cbExtension.Margin = new System.Windows.Forms.Padding(2);
            this.cbExtension.Name = "cbExtension";
            this.cbExtension.Size = new System.Drawing.Size(191, 21);
            this.cbExtension.TabIndex = 34;
            this.cbExtension.SelectedIndexChanged += new System.EventHandler(this.cbExtension_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(346, 465);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 24);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(252, 465);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(81, 24);
            this.btnLaunch.TabIndex = 41;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnWTDSelectFile
            // 
            this.btnWTDSelectFile.BackColor = System.Drawing.Color.Maroon;
            this.btnWTDSelectFile.Location = new System.Drawing.Point(158, 465);
            this.btnWTDSelectFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnWTDSelectFile.Name = "btnWTDSelectFile";
            this.btnWTDSelectFile.Size = new System.Drawing.Size(81, 24);
            this.btnWTDSelectFile.TabIndex = 40;
            this.btnWTDSelectFile.Text = "Select File";
            this.toolTipWTD.SetToolTip(this.btnWTDSelectFile, "HFE & IPF require Host Tools v0.13 or later");
            this.btnWTDSelectFile.UseVisualStyleBackColor = false;
            this.btnWTDSelectFile.Click += new System.EventHandler(this.btnWTDSelectFile_Click);
            // 
            // txtWTDCommandLine
            // 
            this.txtWTDCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtWTDCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtWTDCommandLine.Location = new System.Drawing.Point(10, 270);
            this.txtWTDCommandLine.Margin = new System.Windows.Forms.Padding(2);
            this.txtWTDCommandLine.Multiline = true;
            this.txtWTDCommandLine.Name = "txtWTDCommandLine";
            this.txtWTDCommandLine.Size = new System.Drawing.Size(566, 46);
            this.txtWTDCommandLine.TabIndex = 38;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(254, 254);
            this.lblStaticCL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(77, 13);
            this.lblStaticCL.TabIndex = 37;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbWriteToDisk
            // 
            this.gbWriteToDisk.Controls.Add(this.groupBox3);
            this.gbWriteToDisk.Controls.Add(this.groupBox2);
            this.gbWriteToDisk.Location = new System.Drawing.Point(10, 10);
            this.gbWriteToDisk.Margin = new System.Windows.Forms.Padding(2);
            this.gbWriteToDisk.Name = "gbWriteToDisk";
            this.gbWriteToDisk.Padding = new System.Windows.Forms.Padding(2);
            this.gbWriteToDisk.Size = new System.Drawing.Size(565, 192);
            this.gbWriteToDisk.TabIndex = 2;
            this.gbWriteToDisk.TabStop = false;
            this.gbWriteToDisk.Enter += new System.EventHandler(this.gbWriteToDisk_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkHardSectors);
            this.groupBox3.Controls.Add(this.chkRevTrkData);
            this.groupBox3.Controls.Add(this.chkHeadSwap);
            this.groupBox3.Controls.Add(this.txtRetries);
            this.groupBox3.Controls.Add(this.chkRetries);
            this.groupBox3.Controls.Add(this.chkHeadsSet);
            this.groupBox3.Controls.Add(this.txtHeadsSet);
            this.groupBox3.Controls.Add(this.chkCylSet);
            this.groupBox3.Controls.Add(this.txtCylSet);
            this.groupBox3.Controls.Add(this.gbFlippy);
            this.groupBox3.Location = new System.Drawing.Point(285, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(272, 173);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // chkRevTrkData
            // 
            this.chkRevTrkData.AutoSize = true;
            this.chkRevTrkData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRevTrkData.Location = new System.Drawing.Point(106, 89);
            this.chkRevTrkData.Margin = new System.Windows.Forms.Padding(2);
            this.chkRevTrkData.Name = "chkRevTrkData";
            this.chkRevTrkData.Size = new System.Drawing.Size(103, 17);
            this.chkRevTrkData.TabIndex = 26;
            this.chkRevTrkData.Text = "Rev Track Data";
            this.chkRevTrkData.UseVisualStyleBackColor = true;
            this.chkRevTrkData.CheckedChanged += new System.EventHandler(this.chkRevTrkData_CheckedChanged);
            // 
            // txtRetries
            // 
            this.txtRetries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtRetries.ForeColor = System.Drawing.Color.White;
            this.txtRetries.Location = new System.Drawing.Point(106, 16);
            this.txtRetries.Margin = new System.Windows.Forms.Padding(2);
            this.txtRetries.MaxLength = 3;
            this.txtRetries.Name = "txtRetries";
            this.txtRetries.Size = new System.Drawing.Size(158, 20);
            this.txtRetries.TabIndex = 20;
            this.txtRetries.Text = "3";
            this.txtRetries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRetries.TextChanged += new System.EventHandler(this.txtRetries_TextChanged);
            // 
            // chkRetries
            // 
            this.chkRetries.AutoSize = true;
            this.chkRetries.Location = new System.Drawing.Point(16, 17);
            this.chkRetries.Margin = new System.Windows.Forms.Padding(2);
            this.chkRetries.Name = "chkRetries";
            this.chkRetries.Size = new System.Drawing.Size(59, 17);
            this.chkRetries.TabIndex = 19;
            this.chkRetries.Text = "Retries";
            this.chkRetries.UseVisualStyleBackColor = true;
            this.chkRetries.CheckedChanged += new System.EventHandler(this.chkRetries_CheckedChanged);
            // 
            // chkHeadsSet
            // 
            this.chkHeadsSet.AutoSize = true;
            this.chkHeadsSet.Location = new System.Drawing.Point(16, 63);
            this.chkHeadsSet.Margin = new System.Windows.Forms.Padding(2);
            this.chkHeadsSet.Name = "chkHeadsSet";
            this.chkHeadsSet.Size = new System.Drawing.Size(74, 17);
            this.chkHeadsSet.TabIndex = 23;
            this.chkHeadsSet.Text = "Head sets";
            this.toolTipWTD.SetToolTip(this.chkHeadsSet, "Host Tools v0.22 or later");
            this.chkHeadsSet.UseVisualStyleBackColor = true;
            this.chkHeadsSet.CheckedChanged += new System.EventHandler(this.chkHeadsSet_CheckedChanged);
            // 
            // txtHeadsSet
            // 
            this.txtHeadsSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtHeadsSet.ForeColor = System.Drawing.Color.White;
            this.txtHeadsSet.Location = new System.Drawing.Point(106, 63);
            this.txtHeadsSet.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeadsSet.Name = "txtHeadsSet";
            this.txtHeadsSet.Size = new System.Drawing.Size(158, 20);
            this.txtHeadsSet.TabIndex = 24;
            this.txtHeadsSet.Text = "0,1";
            this.txtHeadsSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipWTD.SetToolTip(this.txtHeadsSet, "Host Tools v0.22 or later");
            this.txtHeadsSet.TextChanged += new System.EventHandler(this.txtHeadsSet_TextChanged);
            // 
            // chkCylSet
            // 
            this.chkCylSet.AutoSize = true;
            this.chkCylSet.Location = new System.Drawing.Point(16, 40);
            this.chkCylSet.Margin = new System.Windows.Forms.Padding(2);
            this.chkCylSet.Name = "chkCylSet";
            this.chkCylSet.Size = new System.Drawing.Size(85, 17);
            this.chkCylSet.TabIndex = 21;
            this.chkCylSet.Text = "Cylinder sets";
            this.toolTipWTD.SetToolTip(this.chkCylSet, "Host Tools v0.22 or later");
            this.chkCylSet.UseVisualStyleBackColor = true;
            this.chkCylSet.CheckedChanged += new System.EventHandler(this.chkCylSet_CheckedChanged);
            // 
            // txtCylSet
            // 
            this.txtCylSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCylSet.ForeColor = System.Drawing.Color.White;
            this.txtCylSet.Location = new System.Drawing.Point(106, 39);
            this.txtCylSet.Margin = new System.Windows.Forms.Padding(2);
            this.txtCylSet.Name = "txtCylSet";
            this.txtCylSet.Size = new System.Drawing.Size(158, 20);
            this.txtCylSet.TabIndex = 22;
            this.txtCylSet.Text = "0-34,35-79";
            this.txtCylSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipWTD.SetToolTip(this.txtCylSet, "Host Tools v0.22 or later");
            this.txtCylSet.TextChanged += new System.EventHandler(this.txtCylSet_TextChanged);
            // 
            // gbFlippy
            // 
            this.gbFlippy.Controls.Add(this.chkFlippyOffset);
            this.gbFlippy.Controls.Add(this.rbFlippyPanasonic);
            this.gbFlippy.Controls.Add(this.rbFlippyTeac);
            this.gbFlippy.Location = new System.Drawing.Point(9, 125);
            this.gbFlippy.Margin = new System.Windows.Forms.Padding(2);
            this.gbFlippy.Name = "gbFlippy";
            this.gbFlippy.Padding = new System.Windows.Forms.Padding(2);
            this.gbFlippy.Size = new System.Drawing.Size(254, 39);
            this.gbFlippy.TabIndex = 28;
            this.gbFlippy.TabStop = false;
            this.toolTipWTD.SetToolTip(this.gbFlippy, "C64 flippy\r\nc=0-39:h=0,1:step=2:h1.off=-8\r\n");
            // 
            // chkFlippyOffset
            // 
            this.chkFlippyOffset.AutoSize = true;
            this.chkFlippyOffset.Location = new System.Drawing.Point(8, 15);
            this.chkFlippyOffset.Margin = new System.Windows.Forms.Padding(2);
            this.chkFlippyOffset.Name = "chkFlippyOffset";
            this.chkFlippyOffset.Size = new System.Drawing.Size(82, 17);
            this.chkFlippyOffset.TabIndex = 29;
            this.chkFlippyOffset.Text = "Flippy offset";
            this.toolTipWTD.SetToolTip(this.chkFlippyOffset, "Host Tools v0.22 or later");
            this.chkFlippyOffset.UseVisualStyleBackColor = true;
            this.chkFlippyOffset.CheckedChanged += new System.EventHandler(this.chkFlippyOffset_CheckedChanged);
            // 
            // rbFlippyPanasonic
            // 
            this.rbFlippyPanasonic.AutoSize = true;
            this.rbFlippyPanasonic.Location = new System.Drawing.Point(100, 15);
            this.rbFlippyPanasonic.Margin = new System.Windows.Forms.Padding(2);
            this.rbFlippyPanasonic.Name = "rbFlippyPanasonic";
            this.rbFlippyPanasonic.Size = new System.Drawing.Size(75, 17);
            this.rbFlippyPanasonic.TabIndex = 30;
            this.rbFlippyPanasonic.Text = "Panasonic";
            this.toolTipWTD.SetToolTip(this.rbFlippyPanasonic, "Host Tools v0.22 or later");
            this.rbFlippyPanasonic.UseVisualStyleBackColor = true;
            this.rbFlippyPanasonic.CheckedChanged += new System.EventHandler(this.rbFlippyPanasonic_CheckedChanged);
            // 
            // rbFlippyTeac
            // 
            this.rbFlippyTeac.AutoSize = true;
            this.rbFlippyTeac.Location = new System.Drawing.Point(194, 15);
            this.rbFlippyTeac.Margin = new System.Windows.Forms.Padding(2);
            this.rbFlippyTeac.Name = "rbFlippyTeac";
            this.rbFlippyTeac.Size = new System.Drawing.Size(50, 17);
            this.rbFlippyTeac.TabIndex = 31;
            this.rbFlippyTeac.Text = "Teac";
            this.toolTipWTD.SetToolTip(this.rbFlippyTeac, "Host Tools v0.22 or later");
            this.rbFlippyTeac.UseVisualStyleBackColor = true;
            this.rbFlippyTeac.CheckedChanged += new System.EventHandler(this.rbFlippyTeac_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTG43);
            this.groupBox2.Controls.Add(this.gbHighLow);
            this.groupBox2.Controls.Add(this.txtFakeIndex);
            this.groupBox2.Controls.Add(this.cbFakeIndex);
            this.groupBox2.Controls.Add(this.chkFakeIndex);
            this.groupBox2.Controls.Add(this.txtPrecomp);
            this.groupBox2.Controls.Add(this.chkPrecomp);
            this.groupBox2.Controls.Add(this.chkEraseEmpty);
            this.groupBox2.Controls.Add(this.txtDriveSelectWTD);
            this.groupBox2.Controls.Add(this.chkDriveSelectWTD);
            this.groupBox2.Controls.Add(this.txtDoubleStep);
            this.groupBox2.Controls.Add(this.chkDoubleStep);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(272, 173);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // chkTG43
            // 
            this.chkTG43.AutoSize = true;
            this.chkTG43.Location = new System.Drawing.Point(109, 18);
            this.chkTG43.Margin = new System.Windows.Forms.Padding(2);
            this.chkTG43.Name = "chkTG43";
            this.chkTG43.Size = new System.Drawing.Size(124, 17);
            this.chkTG43.TabIndex = 4;
            this.chkTG43.Text = "8\" Pin 2 TG43 signal";
            this.toolTipWTD.SetToolTip(this.chkTG43, "Host Tools v0.20 or later");
            this.chkTG43.UseVisualStyleBackColor = true;
            this.chkTG43.CheckedChanged += new System.EventHandler(this.chkTG43_CheckedChanged);
            // 
            // gbHighLow
            // 
            this.gbHighLow.Controls.Add(this.chkPin2High);
            this.gbHighLow.Controls.Add(this.rbHigh);
            this.gbHighLow.Controls.Add(this.rbLow);
            this.gbHighLow.Location = new System.Drawing.Point(8, 132);
            this.gbHighLow.Margin = new System.Windows.Forms.Padding(2);
            this.gbHighLow.Name = "gbHighLow";
            this.gbHighLow.Padding = new System.Windows.Forms.Padding(2);
            this.gbHighLow.Size = new System.Drawing.Size(252, 32);
            this.gbHighLow.TabIndex = 14;
            this.gbHighLow.TabStop = false;
            // 
            // chkPin2High
            // 
            this.chkPin2High.AutoSize = true;
            this.chkPin2High.Location = new System.Drawing.Point(7, 11);
            this.chkPin2High.Margin = new System.Windows.Forms.Padding(2);
            this.chkPin2High.Name = "chkPin2High";
            this.chkPin2High.Size = new System.Drawing.Size(93, 17);
            this.chkPin2High.TabIndex = 15;
            this.chkPin2High.Text = "5.25 Set Pin 2";
            this.chkPin2High.UseVisualStyleBackColor = true;
            this.chkPin2High.CheckedChanged += new System.EventHandler(this.chkPin2High_CheckedChanged);
            // 
            // rbHigh
            // 
            this.rbHigh.AutoSize = true;
            this.rbHigh.Location = new System.Drawing.Point(109, 11);
            this.rbHigh.Margin = new System.Windows.Forms.Padding(2);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(47, 17);
            this.rbHigh.TabIndex = 16;
            this.rbHigh.Text = "High";
            this.rbHigh.UseVisualStyleBackColor = true;
            this.rbHigh.CheckedChanged += new System.EventHandler(this.rbHigh_CheckedChanged);
            // 
            // rbLow
            // 
            this.rbLow.AutoSize = true;
            this.rbLow.Location = new System.Drawing.Point(188, 11);
            this.rbLow.Margin = new System.Windows.Forms.Padding(2);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(45, 17);
            this.rbLow.TabIndex = 17;
            this.rbLow.Text = "Low";
            this.rbLow.UseVisualStyleBackColor = true;
            this.rbLow.CheckedChanged += new System.EventHandler(this.rbLow_CheckedChanged);
            // 
            // txtFakeIndex
            // 
            this.txtFakeIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtFakeIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFakeIndex.ForeColor = System.Drawing.Color.White;
            this.txtFakeIndex.Location = new System.Drawing.Point(116, 111);
            this.txtFakeIndex.Margin = new System.Windows.Forms.Padding(2);
            this.txtFakeIndex.MaxLength = 3;
            this.txtFakeIndex.Name = "txtFakeIndex";
            this.txtFakeIndex.Size = new System.Drawing.Size(68, 19);
            this.txtFakeIndex.TabIndex = 12;
            this.txtFakeIndex.Text = "300";
            this.txtFakeIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFakeIndex.TextChanged += new System.EventHandler(this.txtFakeIndex_TextChanged);
            // 
            // cbFakeIndex
            // 
            this.cbFakeIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbFakeIndex.ForeColor = System.Drawing.Color.White;
            this.cbFakeIndex.FormattingEnabled = true;
            this.cbFakeIndex.Items.AddRange(new object[] {
            "",
            "rpm",
            "ms",
            "us",
            "ns",
            "scp"});
            this.cbFakeIndex.Location = new System.Drawing.Point(195, 110);
            this.cbFakeIndex.Margin = new System.Windows.Forms.Padding(2);
            this.cbFakeIndex.Name = "cbFakeIndex";
            this.cbFakeIndex.Size = new System.Drawing.Size(66, 21);
            this.cbFakeIndex.TabIndex = 13;
            this.cbFakeIndex.SelectedIndexChanged += new System.EventHandler(this.cbFakeIndex_SelectedIndexChanged);
            // 
            // chkFakeIndex
            // 
            this.chkFakeIndex.AutoSize = true;
            this.chkFakeIndex.Location = new System.Drawing.Point(14, 111);
            this.chkFakeIndex.Margin = new System.Windows.Forms.Padding(2);
            this.chkFakeIndex.Name = "chkFakeIndex";
            this.chkFakeIndex.Size = new System.Drawing.Size(79, 17);
            this.chkFakeIndex.TabIndex = 11;
            this.chkFakeIndex.Text = "Fake Index";
            this.chkFakeIndex.UseVisualStyleBackColor = true;
            this.chkFakeIndex.CheckedChanged += new System.EventHandler(this.chkFakeIndex_CheckedChanged);
            // 
            // txtPrecomp
            // 
            this.txtPrecomp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPrecomp.ForeColor = System.Drawing.Color.White;
            this.txtPrecomp.Location = new System.Drawing.Point(160, 87);
            this.txtPrecomp.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecomp.Name = "txtPrecomp";
            this.txtPrecomp.Size = new System.Drawing.Size(100, 20);
            this.txtPrecomp.TabIndex = 10;
            this.txtPrecomp.Text = "type=mfm:40=125";
            this.txtPrecomp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipWTD.SetToolTip(this.txtPrecomp, "Host Tools v0.24 or later");
            this.txtPrecomp.TextChanged += new System.EventHandler(this.txtPrecomp_TextChanged);
            // 
            // chkPrecomp
            // 
            this.chkPrecomp.AutoSize = true;
            this.chkPrecomp.Location = new System.Drawing.Point(14, 88);
            this.chkPrecomp.Margin = new System.Windows.Forms.Padding(2);
            this.chkPrecomp.Name = "chkPrecomp";
            this.chkPrecomp.Size = new System.Drawing.Size(108, 17);
            this.chkPrecomp.TabIndex = 9;
            this.chkPrecomp.Text = "Precompensation";
            this.toolTipWTD.SetToolTip(this.chkPrecomp, "Host Tools v0.24 or later");
            this.chkPrecomp.UseVisualStyleBackColor = true;
            this.chkPrecomp.CheckedChanged += new System.EventHandler(this.chkPrecomp_CheckedChanged);
            // 
            // chkEraseEmpty
            // 
            this.chkEraseEmpty.AutoSize = true;
            this.chkEraseEmpty.Location = new System.Drawing.Point(14, 17);
            this.chkEraseEmpty.Margin = new System.Windows.Forms.Padding(2);
            this.chkEraseEmpty.Name = "chkEraseEmpty";
            this.chkEraseEmpty.Size = new System.Drawing.Size(85, 17);
            this.chkEraseEmpty.TabIndex = 3;
            this.chkEraseEmpty.Text = "Erase Empty";
            this.toolTipWTD.SetToolTip(this.chkEraseEmpty, "Host Tools v0.20 or later");
            this.chkEraseEmpty.UseVisualStyleBackColor = true;
            this.chkEraseEmpty.CheckedChanged += new System.EventHandler(this.chkEraseEmpty_CheckedChanged);
            // 
            // txtDriveSelectWTD
            // 
            this.txtDriveSelectWTD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDriveSelectWTD.ForeColor = System.Drawing.Color.White;
            this.txtDriveSelectWTD.Location = new System.Drawing.Point(160, 63);
            this.txtDriveSelectWTD.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriveSelectWTD.MaxLength = 1;
            this.txtDriveSelectWTD.Name = "txtDriveSelectWTD";
            this.txtDriveSelectWTD.Size = new System.Drawing.Size(101, 20);
            this.txtDriveSelectWTD.TabIndex = 8;
            this.txtDriveSelectWTD.Text = "A";
            this.txtDriveSelectWTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDriveSelectWTD.TextChanged += new System.EventHandler(this.txtDriveSelectWTD_TextChanged);
            // 
            // chkDriveSelectWTD
            // 
            this.chkDriveSelectWTD.AutoSize = true;
            this.chkDriveSelectWTD.Location = new System.Drawing.Point(14, 64);
            this.chkDriveSelectWTD.Margin = new System.Windows.Forms.Padding(2);
            this.chkDriveSelectWTD.Name = "chkDriveSelectWTD";
            this.chkDriveSelectWTD.Size = new System.Drawing.Size(140, 17);
            this.chkDriveSelectWTD.TabIndex = 7;
            this.chkDriveSelectWTD.Text = "F7 Drive Select (AB012)";
            this.chkDriveSelectWTD.UseVisualStyleBackColor = true;
            this.chkDriveSelectWTD.CheckedChanged += new System.EventHandler(this.chkDriveSelectWTD_CheckedChanged);
            // 
            // txtDoubleStep
            // 
            this.txtDoubleStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDoubleStep.ForeColor = System.Drawing.Color.White;
            this.txtDoubleStep.Location = new System.Drawing.Point(160, 40);
            this.txtDoubleStep.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoubleStep.Name = "txtDoubleStep";
            this.txtDoubleStep.Size = new System.Drawing.Size(101, 20);
            this.txtDoubleStep.TabIndex = 6;
            this.txtDoubleStep.Text = "2";
            this.txtDoubleStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDoubleStep.TextChanged += new System.EventHandler(this.txtDoubleStep_TextChanged);
            // 
            // chkDoubleStep
            // 
            this.chkDoubleStep.AutoSize = true;
            this.chkDoubleStep.Location = new System.Drawing.Point(14, 41);
            this.chkDoubleStep.Margin = new System.Windows.Forms.Padding(2);
            this.chkDoubleStep.Name = "chkDoubleStep";
            this.chkDoubleStep.Size = new System.Drawing.Size(143, 17);
            this.chkDoubleStep.TabIndex = 5;
            this.chkDoubleStep.Text = "Double-Step (steps [0-9])";
            this.chkDoubleStep.UseVisualStyleBackColor = true;
            this.chkDoubleStep.CheckedChanged += new System.EventHandler(this.chkDoubleStep_CheckedChanged);
            // 
            // threadWorker
            // 
            this.threadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadWorker_DoWork);
            this.threadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadWorker_RunWorkerCompleted);
            // 
            // ctxOutput
            // 
            this.ctxOutput.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxClearOutput,
            this.ctxSaveOutput});
            this.ctxOutput.Name = "ctxOutput";
            this.ctxOutput.Size = new System.Drawing.Size(143, 48);
            // 
            // ctxClearOutput
            // 
            this.ctxClearOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctxClearOutput.ForeColor = System.Drawing.Color.White;
            this.ctxClearOutput.Name = "ctxClearOutput";
            this.ctxClearOutput.Size = new System.Drawing.Size(142, 22);
            this.ctxClearOutput.Text = "Clear Output";
            this.ctxClearOutput.Click += new System.EventHandler(this.ctxClearOutput_Click);
            // 
            // ctxSaveOutput
            // 
            this.ctxSaveOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctxSaveOutput.ForeColor = System.Drawing.Color.White;
            this.ctxSaveOutput.Name = "ctxSaveOutput";
            this.ctxSaveOutput.Size = new System.Drawing.Size(142, 22);
            this.ctxSaveOutput.Text = "Save Output";
            this.ctxSaveOutput.Click += new System.EventHandler(this.ctxSaveOutput_Click);
            // 
            // chkHeadSwap
            // 
            this.chkHeadSwap.AutoSize = true;
            this.chkHeadSwap.Location = new System.Drawing.Point(16, 89);
            this.chkHeadSwap.Margin = new System.Windows.Forms.Padding(2);
            this.chkHeadSwap.Name = "chkHeadSwap";
            this.chkHeadSwap.Size = new System.Drawing.Size(82, 17);
            this.chkHeadSwap.TabIndex = 25;
            this.chkHeadSwap.Text = "Head Swap";
            this.toolTipWTD.SetToolTip(this.chkHeadSwap, "Host Tools v0.22 or later");
            this.chkHeadSwap.UseVisualStyleBackColor = true;
            this.chkHeadSwap.CheckedChanged += new System.EventHandler(this.chkHeadSwap_CheckedChanged);
            // 
            // chkHardSectors
            // 
            this.chkHardSectors.AutoSize = true;
            this.chkHardSectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHardSectors.Location = new System.Drawing.Point(16, 111);
            this.chkHardSectors.Margin = new System.Windows.Forms.Padding(2);
            this.chkHardSectors.Name = "chkHardSectors";
            this.chkHardSectors.Size = new System.Drawing.Size(88, 17);
            this.chkHardSectors.TabIndex = 27;
            this.chkHardSectors.Text = "Hard Sectors";
            this.chkHardSectors.UseVisualStyleBackColor = true;
            this.chkHardSectors.CheckedChanged += new System.EventHandler(this.chkHardSectors_CheckedChanged);
            // 
            // WriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(604, 535);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Write to Disk";
            this.Load += new System.EventHandler(this.WriteForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDiskType.ResumeLayout(false);
            this.gbDiskType.PerformLayout();
            this.gbWriteToDisk.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbFlippy.ResumeLayout(false);
            this.gbFlippy.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbHighLow.ResumeLayout(false);
            this.gbHighLow.PerformLayout();
            this.ctxOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbWriteToDisk;
        private System.Windows.Forms.Button btnWTDSelectFile;
        private System.Windows.Forms.TextBox txtWTDCommandLine;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ToolTip toolTipWTD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDriveSelectWTD;
        private System.Windows.Forms.CheckBox chkDriveSelectWTD;
        private System.Windows.Forms.TextBox txtDoubleStep;
        private System.Windows.Forms.CheckBox chkDoubleStep;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkHeadsSet;
        private System.Windows.Forms.TextBox txtHeadsSet;
        private System.Windows.Forms.CheckBox chkCylSet;
        private System.Windows.Forms.TextBox txtCylSet;
        private System.Windows.Forms.GroupBox gbFlippy;
        private System.Windows.Forms.CheckBox chkFlippyOffset;
        private System.Windows.Forms.RadioButton rbFlippyPanasonic;
        private System.Windows.Forms.RadioButton rbFlippyTeac;
        private System.Windows.Forms.CheckBox chkEraseEmpty;
        private System.Windows.Forms.TextBox txtPrecomp;
        private System.Windows.Forms.CheckBox chkPrecomp;
        private System.Windows.Forms.TextBox txtRetries;
        private System.Windows.Forms.CheckBox chkRetries;
        private System.Windows.Forms.GroupBox gbDiskType;
        private System.Windows.Forms.Label lblDiskType;
        private System.Windows.Forms.ComboBox cbExtension;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Label lblHostTools;
        private System.ComponentModel.BackgroundWorker threadWorker;
        private System.Windows.Forms.ContextMenuStrip ctxOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxClearOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxSaveOutput;
        private System.Windows.Forms.CheckBox chkFakeIndex;
        private System.Windows.Forms.TextBox txtFakeIndex;
        private System.Windows.Forms.ComboBox cbFakeIndex;
        private System.Windows.Forms.GroupBox gbHighLow;
        private System.Windows.Forms.CheckBox chkPin2High;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.CheckBox chkTG43;
        private System.Windows.Forms.CheckBox chkRevTrkData;
        private System.Windows.Forms.CheckBox chkHeadSwap;
        private System.Windows.Forms.CheckBox chkHardSectors;
    }
}