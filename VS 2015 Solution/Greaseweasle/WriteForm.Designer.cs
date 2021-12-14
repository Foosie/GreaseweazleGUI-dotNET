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
            this.gbDiskType = new System.Windows.Forms.GroupBox();
            this.lblDiskType = new System.Windows.Forms.Label();
            this.cbExtension = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnWTDSelectFile = new System.Windows.Forms.Button();
            this.txtWTDCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.gbWriteToDisk = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.txtPrecomp = new System.Windows.Forms.TextBox();
            this.chkPrecomp = new System.Windows.Forms.CheckBox();
            this.chkEraseEmpty = new System.Windows.Forms.CheckBox();
            this.txtDriveSelectWTD = new System.Windows.Forms.TextBox();
            this.chkDriveSelectWTD = new System.Windows.Forms.CheckBox();
            this.txtDoubleStep = new System.Windows.Forms.TextBox();
            this.chkDoubleStep = new System.Windows.Forms.CheckBox();
            this.toolTipWTD = new System.Windows.Forms.ToolTip(this.components);
            this.lblHostTools = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.gbDiskType.SuspendLayout();
            this.gbWriteToDisk.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbFlippy.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbDiskType);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnLaunch);
            this.groupBox1.Controls.Add(this.btnWTDSelectFile);
            this.groupBox1.Controls.Add(this.txtWTDCommandLine);
            this.groupBox1.Controls.Add(this.lblStaticCL);
            this.groupBox1.Controls.Add(this.gbWriteToDisk);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 407);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // gbDiskType
            // 
            this.gbDiskType.Controls.Add(this.lblFormat);
            this.gbDiskType.Controls.Add(this.cbFormat);
            this.gbDiskType.Controls.Add(this.lblDiskType);
            this.gbDiskType.Controls.Add(this.cbExtension);
            this.gbDiskType.Location = new System.Drawing.Point(11, 209);
            this.gbDiskType.Name = "gbDiskType";
            this.gbDiskType.Size = new System.Drawing.Size(753, 61);
            this.gbDiskType.TabIndex = 26;
            this.gbDiskType.TabStop = false;
            // 
            // lblDiskType
            // 
            this.lblDiskType.AutoSize = true;
            this.lblDiskType.Location = new System.Drawing.Point(51, 24);
            this.lblDiskType.Name = "lblDiskType";
            this.lblDiskType.Size = new System.Drawing.Size(71, 17);
            this.lblDiskType.TabIndex = 27;
            this.lblDiskType.Text = "DiskType:";
            // 
            // cbExtension
            // 
            this.cbExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbExtension.ForeColor = System.Drawing.Color.White;
            this.cbExtension.FormattingEnabled = true;
            this.cbExtension.Items.AddRange(new object[] {
            "",
            ".adf",
            ".d81",
            ".dsk",
            ".img",
            ".ima",
            ".st",
            ".ipf",
            ".hfe",
            ".scp",
            ".scp::disktype=amiga",
            ".scp::disktype=c64"});
            this.cbExtension.Location = new System.Drawing.Point(151, 21);
            this.cbExtension.Name = "cbExtension";
            this.cbExtension.Size = new System.Drawing.Size(177, 24);
            this.cbExtension.TabIndex = 28;
            this.cbExtension.SelectedIndexChanged += new System.EventHandler(this.cbExtension_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(460, 366);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(334, 366);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 34;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnWTDSelectFile
            // 
            this.btnWTDSelectFile.BackColor = System.Drawing.Color.Maroon;
            this.btnWTDSelectFile.Location = new System.Drawing.Point(208, 366);
            this.btnWTDSelectFile.Name = "btnWTDSelectFile";
            this.btnWTDSelectFile.Size = new System.Drawing.Size(108, 29);
            this.btnWTDSelectFile.TabIndex = 33;
            this.btnWTDSelectFile.Text = "Select File";
            this.toolTipWTD.SetToolTip(this.btnWTDSelectFile, "HFE & IPF require Host Tools v0.13 or later");
            this.btnWTDSelectFile.UseVisualStyleBackColor = false;
            this.btnWTDSelectFile.Click += new System.EventHandler(this.btnWTDSelectFile_Click);
            // 
            // txtWTDCommandLine
            // 
            this.txtWTDCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtWTDCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtWTDCommandLine.Location = new System.Drawing.Point(11, 301);
            this.txtWTDCommandLine.Multiline = true;
            this.txtWTDCommandLine.Name = "txtWTDCommandLine";
            this.txtWTDCommandLine.Size = new System.Drawing.Size(753, 56);
            this.txtWTDCommandLine.TabIndex = 32;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(337, 277);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 31;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbWriteToDisk
            // 
            this.gbWriteToDisk.Controls.Add(this.groupBox3);
            this.gbWriteToDisk.Controls.Add(this.groupBox2);
            this.gbWriteToDisk.Location = new System.Drawing.Point(11, 14);
            this.gbWriteToDisk.Name = "gbWriteToDisk";
            this.gbWriteToDisk.Size = new System.Drawing.Size(753, 189);
            this.gbWriteToDisk.TabIndex = 2;
            this.gbWriteToDisk.TabStop = false;
            this.gbWriteToDisk.Enter += new System.EventHandler(this.gbWriteToDisk_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRetries);
            this.groupBox3.Controls.Add(this.chkRetries);
            this.groupBox3.Controls.Add(this.chkHeadsSet);
            this.groupBox3.Controls.Add(this.txtHeadsSet);
            this.groupBox3.Controls.Add(this.chkCylSet);
            this.groupBox3.Controls.Add(this.txtCylSet);
            this.groupBox3.Controls.Add(this.gbFlippy);
            this.groupBox3.Location = new System.Drawing.Point(380, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 160);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // txtRetries
            // 
            this.txtRetries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtRetries.ForeColor = System.Drawing.Color.White;
            this.txtRetries.Location = new System.Drawing.Point(141, 20);
            this.txtRetries.MaxLength = 3;
            this.txtRetries.Name = "txtRetries";
            this.txtRetries.Size = new System.Drawing.Size(209, 22);
            this.txtRetries.TabIndex = 17;
            this.txtRetries.Text = "3";
            this.txtRetries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRetries.TextChanged += new System.EventHandler(this.txtRetries_TextChanged);
            // 
            // chkRetries
            // 
            this.chkRetries.AutoSize = true;
            this.chkRetries.Location = new System.Drawing.Point(21, 21);
            this.chkRetries.Name = "chkRetries";
            this.chkRetries.Size = new System.Drawing.Size(75, 21);
            this.chkRetries.TabIndex = 16;
            this.chkRetries.Text = "Retries";
            this.chkRetries.UseVisualStyleBackColor = true;
            this.chkRetries.CheckedChanged += new System.EventHandler(this.chkRetries_CheckedChanged);
            // 
            // chkHeadsSet
            // 
            this.chkHeadsSet.AutoSize = true;
            this.chkHeadsSet.Location = new System.Drawing.Point(21, 78);
            this.chkHeadsSet.Name = "chkHeadsSet";
            this.chkHeadsSet.Size = new System.Drawing.Size(94, 21);
            this.chkHeadsSet.TabIndex = 20;
            this.chkHeadsSet.Text = "Head sets";
            this.toolTipWTD.SetToolTip(this.chkHeadsSet, "Host Tools v0.22 or later");
            this.chkHeadsSet.UseVisualStyleBackColor = true;
            this.chkHeadsSet.CheckedChanged += new System.EventHandler(this.chkHeadsSet_CheckedChanged);
            // 
            // txtHeadsSet
            // 
            this.txtHeadsSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtHeadsSet.ForeColor = System.Drawing.Color.White;
            this.txtHeadsSet.Location = new System.Drawing.Point(141, 77);
            this.txtHeadsSet.Name = "txtHeadsSet";
            this.txtHeadsSet.Size = new System.Drawing.Size(210, 22);
            this.txtHeadsSet.TabIndex = 21;
            this.txtHeadsSet.Text = "0,1";
            this.txtHeadsSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipWTD.SetToolTip(this.txtHeadsSet, "Host Tools v0.22 or later");
            this.txtHeadsSet.TextChanged += new System.EventHandler(this.txtHeadsSet_TextChanged);
            // 
            // chkCylSet
            // 
            this.chkCylSet.AutoSize = true;
            this.chkCylSet.Location = new System.Drawing.Point(21, 49);
            this.chkCylSet.Name = "chkCylSet";
            this.chkCylSet.Size = new System.Drawing.Size(111, 21);
            this.chkCylSet.TabIndex = 18;
            this.chkCylSet.Text = "Cylinder sets";
            this.toolTipWTD.SetToolTip(this.chkCylSet, "Host Tools v0.22 or later");
            this.chkCylSet.UseVisualStyleBackColor = true;
            this.chkCylSet.CheckedChanged += new System.EventHandler(this.chkCylSet_CheckedChanged);
            // 
            // txtCylSet
            // 
            this.txtCylSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCylSet.ForeColor = System.Drawing.Color.White;
            this.txtCylSet.Location = new System.Drawing.Point(141, 48);
            this.txtCylSet.Name = "txtCylSet";
            this.txtCylSet.Size = new System.Drawing.Size(210, 22);
            this.txtCylSet.TabIndex = 19;
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
            this.gbFlippy.Location = new System.Drawing.Point(12, 100);
            this.gbFlippy.Name = "gbFlippy";
            this.gbFlippy.Size = new System.Drawing.Size(339, 48);
            this.gbFlippy.TabIndex = 22;
            this.gbFlippy.TabStop = false;
            this.toolTipWTD.SetToolTip(this.gbFlippy, "C64 flippy\r\nc=0-39:h=0,1:step=2:h1.off=-8\r\n");
            // 
            // chkFlippyOffset
            // 
            this.chkFlippyOffset.AutoSize = true;
            this.chkFlippyOffset.Location = new System.Drawing.Point(11, 18);
            this.chkFlippyOffset.Name = "chkFlippyOffset";
            this.chkFlippyOffset.Size = new System.Drawing.Size(106, 21);
            this.chkFlippyOffset.TabIndex = 23;
            this.chkFlippyOffset.Text = "Flippy offset";
            this.toolTipWTD.SetToolTip(this.chkFlippyOffset, "Host Tools v0.22 or later");
            this.chkFlippyOffset.UseVisualStyleBackColor = true;
            this.chkFlippyOffset.CheckedChanged += new System.EventHandler(this.chkFlippyOffset_CheckedChanged);
            // 
            // rbFlippyPanasonic
            // 
            this.rbFlippyPanasonic.AutoSize = true;
            this.rbFlippyPanasonic.Location = new System.Drawing.Point(133, 19);
            this.rbFlippyPanasonic.Name = "rbFlippyPanasonic";
            this.rbFlippyPanasonic.Size = new System.Drawing.Size(95, 21);
            this.rbFlippyPanasonic.TabIndex = 24;
            this.rbFlippyPanasonic.Text = "Panasonic";
            this.toolTipWTD.SetToolTip(this.rbFlippyPanasonic, "Host Tools v0.22 or later");
            this.rbFlippyPanasonic.UseVisualStyleBackColor = true;
            this.rbFlippyPanasonic.CheckedChanged += new System.EventHandler(this.rbFlippyPanasonic_CheckedChanged);
            // 
            // rbFlippyTeac
            // 
            this.rbFlippyTeac.AutoSize = true;
            this.rbFlippyTeac.Location = new System.Drawing.Point(258, 18);
            this.rbFlippyTeac.Name = "rbFlippyTeac";
            this.rbFlippyTeac.Size = new System.Drawing.Size(61, 21);
            this.rbFlippyTeac.TabIndex = 25;
            this.rbFlippyTeac.Text = "Teac";
            this.toolTipWTD.SetToolTip(this.rbFlippyTeac, "Host Tools v0.22 or later");
            this.rbFlippyTeac.UseVisualStyleBackColor = true;
            this.rbFlippyTeac.CheckedChanged += new System.EventHandler(this.rbFlippyTeac_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrecomp);
            this.groupBox2.Controls.Add(this.chkPrecomp);
            this.groupBox2.Controls.Add(this.chkEraseEmpty);
            this.groupBox2.Controls.Add(this.txtDriveSelectWTD);
            this.groupBox2.Controls.Add(this.chkDriveSelectWTD);
            this.groupBox2.Controls.Add(this.txtDoubleStep);
            this.groupBox2.Controls.Add(this.chkDoubleStep);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 160);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtPrecomp
            // 
            this.txtPrecomp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPrecomp.ForeColor = System.Drawing.Color.White;
            this.txtPrecomp.Location = new System.Drawing.Point(214, 124);
            this.txtPrecomp.Name = "txtPrecomp";
            this.txtPrecomp.Size = new System.Drawing.Size(132, 22);
            this.txtPrecomp.TabIndex = 15;
            this.txtPrecomp.Text = "type=mfm:40=125";
            this.txtPrecomp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipWTD.SetToolTip(this.txtPrecomp, "Host Tools v0.24 or later");
            this.txtPrecomp.TextChanged += new System.EventHandler(this.txtPrecomp_TextChanged);
            // 
            // chkPrecomp
            // 
            this.chkPrecomp.AutoSize = true;
            this.chkPrecomp.Location = new System.Drawing.Point(17, 126);
            this.chkPrecomp.Name = "chkPrecomp";
            this.chkPrecomp.Size = new System.Drawing.Size(140, 21);
            this.chkPrecomp.TabIndex = 14;
            this.chkPrecomp.Text = "Precompensation";
            this.toolTipWTD.SetToolTip(this.chkPrecomp, "Host Tools v0.24 or later");
            this.chkPrecomp.UseVisualStyleBackColor = true;
            this.chkPrecomp.CheckedChanged += new System.EventHandler(this.chkPrecomp_CheckedChanged);
            // 
            // chkEraseEmpty
            // 
            this.chkEraseEmpty.AutoSize = true;
            this.chkEraseEmpty.Location = new System.Drawing.Point(18, 21);
            this.chkEraseEmpty.Name = "chkEraseEmpty";
            this.chkEraseEmpty.Size = new System.Drawing.Size(110, 21);
            this.chkEraseEmpty.TabIndex = 5;
            this.chkEraseEmpty.Text = "Erase Empty";
            this.toolTipWTD.SetToolTip(this.chkEraseEmpty, "Host Tools v0.20 or later");
            this.chkEraseEmpty.UseVisualStyleBackColor = true;
            this.chkEraseEmpty.CheckedChanged += new System.EventHandler(this.chkEraseEmpty_CheckedChanged);
            // 
            // txtDriveSelectWTD
            // 
            this.txtDriveSelectWTD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDriveSelectWTD.ForeColor = System.Drawing.Color.White;
            this.txtDriveSelectWTD.Location = new System.Drawing.Point(214, 87);
            this.txtDriveSelectWTD.MaxLength = 1;
            this.txtDriveSelectWTD.Name = "txtDriveSelectWTD";
            this.txtDriveSelectWTD.Size = new System.Drawing.Size(133, 22);
            this.txtDriveSelectWTD.TabIndex = 13;
            this.txtDriveSelectWTD.Text = "A";
            this.txtDriveSelectWTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDriveSelectWTD.TextChanged += new System.EventHandler(this.txtDriveSelectWTD_TextChanged);
            // 
            // chkDriveSelectWTD
            // 
            this.chkDriveSelectWTD.AutoSize = true;
            this.chkDriveSelectWTD.Location = new System.Drawing.Point(18, 89);
            this.chkDriveSelectWTD.Name = "chkDriveSelectWTD";
            this.chkDriveSelectWTD.Size = new System.Drawing.Size(182, 21);
            this.chkDriveSelectWTD.TabIndex = 12;
            this.chkDriveSelectWTD.Text = "F7 Drive Select (AB012)";
            this.chkDriveSelectWTD.UseVisualStyleBackColor = true;
            this.chkDriveSelectWTD.CheckedChanged += new System.EventHandler(this.chkDriveSelectWTD_CheckedChanged);
            // 
            // txtDoubleStep
            // 
            this.txtDoubleStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDoubleStep.ForeColor = System.Drawing.Color.White;
            this.txtDoubleStep.Location = new System.Drawing.Point(214, 50);
            this.txtDoubleStep.Name = "txtDoubleStep";
            this.txtDoubleStep.Size = new System.Drawing.Size(133, 22);
            this.txtDoubleStep.TabIndex = 7;
            this.txtDoubleStep.Text = "2";
            this.txtDoubleStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDoubleStep.TextChanged += new System.EventHandler(this.txtDoubleStep_TextChanged);
            // 
            // chkDoubleStep
            // 
            this.chkDoubleStep.AutoSize = true;
            this.chkDoubleStep.Location = new System.Drawing.Point(18, 54);
            this.chkDoubleStep.Name = "chkDoubleStep";
            this.chkDoubleStep.Size = new System.Drawing.Size(190, 21);
            this.chkDoubleStep.TabIndex = 6;
            this.chkDoubleStep.Text = "Double-Step (steps [0-9])";
            this.chkDoubleStep.UseVisualStyleBackColor = true;
            this.chkDoubleStep.CheckedChanged += new System.EventHandler(this.chkDoubleStep_CheckedChanged);
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(209, 420);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(367, 23);
            this.lblHostTools.TabIndex = 36;
            this.lblHostTools.Text = "for Host Tools v0.00";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(424, 24);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(56, 17);
            this.lblFormat.TabIndex = 29;
            this.lblFormat.Text = "Format:";
            // 
            // cbFormat
            // 
            this.cbFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbFormat.ForeColor = System.Drawing.Color.White;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "",
            "amiga.amigados",
            "atarist.360",
            "atarist.400",
            "atarist.440",
            "atarist.720",
            "atarist.800",
            "atarist.880",
            "commodore.1581",
            "ibm.1200",
            "ibm.1440",
            "ibm.180",
            "ibm.360",
            "ibm.720"});
            this.cbFormat.Location = new System.Drawing.Point(523, 21);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(177, 24);
            this.cbFormat.TabIndex = 30;
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // WriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 452);
            this.Controls.Add(this.lblHostTools);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblHostTools;
        private System.Windows.Forms.TextBox txtRetries;
        private System.Windows.Forms.CheckBox chkRetries;
        private System.Windows.Forms.GroupBox gbDiskType;
        private System.Windows.Forms.Label lblDiskType;
        private System.Windows.Forms.ComboBox cbExtension;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.ComboBox cbFormat;
    }
}