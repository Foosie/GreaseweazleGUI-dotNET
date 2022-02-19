// ReadForm.Designer.cs
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
    partial class ReadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadForm));
            this.gbReadFromDisk = new System.Windows.Forms.GroupBox();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.gbFilename = new System.Windows.Forms.GroupBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.lblDiskType = new System.Windows.Forms.Label();
            this.cbExtension = new System.Windows.Forms.ComboBox();
            this.chkAutoInc = new System.Windows.Forms.CheckBox();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnInc = new System.Windows.Forms.Button();
            this.tbSuffix = new System.Windows.Forms.TextBox();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRFDCommandLine = new System.Windows.Forms.TextBox();
            this.lblCommandLine = new System.Windows.Forms.Label();
            this.btnRFDSelectFile = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnRFDSelectFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbAdjustSpeed = new System.Windows.Forms.GroupBox();
            this.cbAdjustSpeed = new System.Windows.Forms.ComboBox();
            this.txtAdjustSpeed = new System.Windows.Forms.TextBox();
            this.chkAdjustSpeed = new System.Windows.Forms.CheckBox();
            this.chkHeadSwap = new System.Windows.Forms.CheckBox();
            this.chkLegacySS = new System.Windows.Forms.CheckBox();
            this.chkHeadsSet = new System.Windows.Forms.CheckBox();
            this.txtHeadsSet = new System.Windows.Forms.TextBox();
            this.chkCylSet = new System.Windows.Forms.CheckBox();
            this.txtCylSet = new System.Windows.Forms.TextBox();
            this.gbFlippy = new System.Windows.Forms.GroupBox();
            this.chkFlippyOffset = new System.Windows.Forms.CheckBox();
            this.rbFlippyPanasonic = new System.Windows.Forms.RadioButton();
            this.rbFlippyTeac = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFakeIndex = new System.Windows.Forms.TextBox();
            this.cbFakeIndex = new System.Windows.Forms.ComboBox();
            this.chkFakeIndex = new System.Windows.Forms.CheckBox();
            this.chkRaw = new System.Windows.Forms.CheckBox();
            this.chkNoClobber = new System.Windows.Forms.CheckBox();
            this.txtDriveRetriesRFD = new System.Windows.Forms.TextBox();
            this.chkDriveRetriesRFD = new System.Windows.Forms.CheckBox();
            this.txtBitrateRFD = new System.Windows.Forms.TextBox();
            this.chkBitrateRFD = new System.Windows.Forms.CheckBox();
            this.txtDriveSelectRFD = new System.Windows.Forms.TextBox();
            this.chkDriveSelectRFD = new System.Windows.Forms.CheckBox();
            this.txtDoubleStep = new System.Windows.Forms.TextBox();
            this.chkDoubleStep = new System.Windows.Forms.CheckBox();
            this.chkRevsPerTrack = new System.Windows.Forms.CheckBox();
            this.txtRevsPerTrack = new System.Windows.Forms.TextBox();
            this.toolTipRFD = new System.Windows.Forms.ToolTip(this.components);
            this.lblHostTools = new System.Windows.Forms.Label();
            this.threadWorker = new System.ComponentModel.BackgroundWorker();
            this.ctxOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxClearOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSaveOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.gbReadFromDisk.SuspendLayout();
            this.gbFilename.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbAdjustSpeed.SuspendLayout();
            this.gbFlippy.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ctxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReadFromDisk
            // 
            this.gbReadFromDisk.Controls.Add(this.lbOutput);
            this.gbReadFromDisk.Controls.Add(this.gbFilename);
            this.gbReadFromDisk.Controls.Add(this.btnBack);
            this.gbReadFromDisk.Controls.Add(this.txtRFDCommandLine);
            this.gbReadFromDisk.Controls.Add(this.lblCommandLine);
            this.gbReadFromDisk.Controls.Add(this.btnRFDSelectFile);
            this.gbReadFromDisk.Controls.Add(this.btnLaunch);
            this.gbReadFromDisk.Controls.Add(this.btnRFDSelectFolder);
            this.gbReadFromDisk.Controls.Add(this.groupBox1);
            this.gbReadFromDisk.Location = new System.Drawing.Point(14, 8);
            this.gbReadFromDisk.Name = "gbReadFromDisk";
            this.gbReadFromDisk.Size = new System.Drawing.Size(782, 680);
            this.gbReadFromDisk.TabIndex = 0;
            this.gbReadFromDisk.TabStop = false;
            // 
            // lbOutput
            // 
            this.lbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbOutput.ForeColor = System.Drawing.Color.White;
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.HorizontalScrollbar = true;
            this.lbOutput.ItemHeight = 16;
            this.lbOutput.Location = new System.Drawing.Point(13, 468);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(757, 132);
            this.lbOutput.TabIndex = 53;
            this.toolTipRFD.SetToolTip(this.lbOutput, "Right click for options");
            // 
            // gbFilename
            // 
            this.gbFilename.Controls.Add(this.lblFormat);
            this.gbFilename.Controls.Add(this.cbFormat);
            this.gbFilename.Controls.Add(this.lblDiskType);
            this.gbFilename.Controls.Add(this.cbExtension);
            this.gbFilename.Controls.Add(this.chkAutoInc);
            this.gbFilename.Controls.Add(this.btnDec);
            this.gbFilename.Controls.Add(this.btnInc);
            this.gbFilename.Controls.Add(this.tbSuffix);
            this.gbFilename.Controls.Add(this.lblSuffix);
            this.gbFilename.Controls.Add(this.tbFilename);
            this.gbFilename.Controls.Add(this.lblFilename);
            this.gbFilename.Location = new System.Drawing.Point(13, 283);
            this.gbFilename.Name = "gbFilename";
            this.gbFilename.Size = new System.Drawing.Size(757, 89);
            this.gbFilename.TabIndex = 39;
            this.gbFilename.TabStop = false;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(402, 56);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(56, 17);
            this.lblFormat.TabIndex = 49;
            this.lblFormat.Text = "Format:";
            // 
            // cbFormat
            // 
            this.cbFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbFormat.ForeColor = System.Drawing.Color.White;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "",
            "acorn.dfs.ss",
            "acorn.dfs.ds",
            "acorn.adfs.160",
            "acorn.adfs.320",
            "acorn.adfs.640",
            "acorn.adfs.800",
            "acorn.adfs.1600",
            "amiga.amigados",
            "amiga.amigados_hd",
            "atarist.360",
            "atarist.400",
            "atarist.440",
            "atarist.720",
            "atarist.800",
            "atarist.880",
            "commodore.1581",
            "ibm.180",
            "ibm.360",
            "ibm.720",
            "ibm.1200",
            "ibm.1440",
            "sega.sf7000"});
            this.cbFormat.Location = new System.Drawing.Point(483, 53);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(251, 24);
            this.cbFormat.TabIndex = 50;
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // lblDiskType
            // 
            this.lblDiskType.AutoSize = true;
            this.lblDiskType.Location = new System.Drawing.Point(18, 53);
            this.lblDiskType.Name = "lblDiskType";
            this.lblDiskType.Size = new System.Drawing.Size(71, 17);
            this.lblDiskType.TabIndex = 47;
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
            ".ads",
            ".adm",
            ".adl",
            ".d81",
            ".dsd",
            ".dsk",
            ".hfe",
            ".img",
            ".ima",
            ".scp",
            ".scp::disktype=amiga",
            ".scp::disktype=c64",
            ".sf7",
            ".ssd",
            ".st",
            ".ipf"});
            this.cbExtension.Location = new System.Drawing.Point(104, 53);
            this.cbExtension.Name = "cbExtension";
            this.cbExtension.Size = new System.Drawing.Size(258, 24);
            this.cbExtension.TabIndex = 48;
            this.cbExtension.SelectedIndexChanged += new System.EventHandler(this.cbExtension_SelectedIndexChanged);
            // 
            // chkAutoInc
            // 
            this.chkAutoInc.AutoSize = true;
            this.chkAutoInc.Location = new System.Drawing.Point(405, 21);
            this.chkAutoInc.Name = "chkAutoInc";
            this.chkAutoInc.Size = new System.Drawing.Size(64, 21);
            this.chkAutoInc.TabIndex = 42;
            this.chkAutoInc.Text = "Inc++";
            this.chkAutoInc.UseVisualStyleBackColor = true;
            // 
            // btnDec
            // 
            this.btnDec.BackColor = System.Drawing.Color.Maroon;
            this.btnDec.Location = new System.Drawing.Point(680, 17);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(58, 29);
            this.btnDec.TabIndex = 46;
            this.btnDec.Text = "<<<<";
            this.btnDec.UseVisualStyleBackColor = false;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnInc
            // 
            this.btnInc.BackColor = System.Drawing.Color.Maroon;
            this.btnInc.Location = new System.Drawing.Point(614, 17);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(58, 29);
            this.btnInc.TabIndex = 45;
            this.btnInc.Text = ">>>>";
            this.btnInc.UseVisualStyleBackColor = false;
            this.btnInc.Click += new System.EventHandler(this.btnInc_Click);
            // 
            // tbSuffix
            // 
            this.tbSuffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbSuffix.ForeColor = System.Drawing.Color.White;
            this.tbSuffix.Location = new System.Drawing.Point(547, 20);
            this.tbSuffix.MaxLength = 3;
            this.tbSuffix.Name = "tbSuffix";
            this.tbSuffix.Size = new System.Drawing.Size(58, 22);
            this.tbSuffix.TabIndex = 44;
            this.tbSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSuffix.TextChanged += new System.EventHandler(this.tbSuffix_TextChanged);
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(498, 23);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(46, 17);
            this.lblSuffix.TabIndex = 43;
            this.lblSuffix.Text = "Suffix:";
            // 
            // tbFilename
            // 
            this.tbFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbFilename.ForeColor = System.Drawing.Color.White;
            this.tbFilename.Location = new System.Drawing.Point(104, 20);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(254, 22);
            this.tbFilename.TabIndex = 41;
            this.tbFilename.Text = "mydisk.scp";
            this.tbFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFilename.TextChanged += new System.EventHandler(this.tbFilename_TextChanged);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(18, 23);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(69, 17);
            this.lblFilename.TabIndex = 40;
            this.lblFilename.Text = "Filename:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(597, 610);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRFDCommandLine
            // 
            this.txtRFDCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtRFDCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtRFDCommandLine.Location = new System.Drawing.Point(13, 403);
            this.txtRFDCommandLine.Multiline = true;
            this.txtRFDCommandLine.Name = "txtRFDCommandLine";
            this.txtRFDCommandLine.Size = new System.Drawing.Size(757, 54);
            this.txtRFDCommandLine.TabIndex = 52;
            // 
            // lblCommandLine
            // 
            this.lblCommandLine.AutoSize = true;
            this.lblCommandLine.Location = new System.Drawing.Point(340, 378);
            this.lblCommandLine.Name = "lblCommandLine";
            this.lblCommandLine.Size = new System.Drawing.Size(102, 17);
            this.lblCommandLine.TabIndex = 51;
            this.lblCommandLine.Text = "Command Line";
            // 
            // btnRFDSelectFile
            // 
            this.btnRFDSelectFile.BackColor = System.Drawing.Color.Maroon;
            this.btnRFDSelectFile.Location = new System.Drawing.Point(251, 610);
            this.btnRFDSelectFile.Name = "btnRFDSelectFile";
            this.btnRFDSelectFile.Size = new System.Drawing.Size(108, 29);
            this.btnRFDSelectFile.TabIndex = 55;
            this.btnRFDSelectFile.Text = "Select File";
            this.btnRFDSelectFile.UseVisualStyleBackColor = false;
            this.btnRFDSelectFile.Click += new System.EventHandler(this.btnRFDSelectFile_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(424, 610);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 56;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnRFDSelectFolder
            // 
            this.btnRFDSelectFolder.BackColor = System.Drawing.Color.Maroon;
            this.btnRFDSelectFolder.Location = new System.Drawing.Point(78, 610);
            this.btnRFDSelectFolder.Name = "btnRFDSelectFolder";
            this.btnRFDSelectFolder.Size = new System.Drawing.Size(108, 29);
            this.btnRFDSelectFolder.TabIndex = 54;
            this.btnRFDSelectFolder.Text = "Select Folder";
            this.btnRFDSelectFolder.UseVisualStyleBackColor = false;
            this.btnRFDSelectFolder.Click += new System.EventHandler(this.btnRFDSelectFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 264);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbAdjustSpeed);
            this.groupBox3.Controls.Add(this.chkHeadSwap);
            this.groupBox3.Controls.Add(this.chkLegacySS);
            this.groupBox3.Controls.Add(this.chkHeadsSet);
            this.groupBox3.Controls.Add(this.txtHeadsSet);
            this.groupBox3.Controls.Add(this.chkCylSet);
            this.groupBox3.Controls.Add(this.txtCylSet);
            this.groupBox3.Controls.Add(this.gbFlippy);
            this.groupBox3.Location = new System.Drawing.Point(384, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 238);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // gbAdjustSpeed
            // 
            this.gbAdjustSpeed.Controls.Add(this.cbAdjustSpeed);
            this.gbAdjustSpeed.Controls.Add(this.txtAdjustSpeed);
            this.gbAdjustSpeed.Controls.Add(this.chkAdjustSpeed);
            this.gbAdjustSpeed.Location = new System.Drawing.Point(10, 168);
            this.gbAdjustSpeed.Name = "gbAdjustSpeed";
            this.gbAdjustSpeed.Size = new System.Drawing.Size(340, 58);
            this.gbAdjustSpeed.TabIndex = 35;
            this.gbAdjustSpeed.TabStop = false;
            // 
            // cbAdjustSpeed
            // 
            this.cbAdjustSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbAdjustSpeed.ForeColor = System.Drawing.Color.White;
            this.cbAdjustSpeed.FormattingEnabled = true;
            this.cbAdjustSpeed.Items.AddRange(new object[] {
            "",
            "rpm",
            "ms",
            "us",
            "ns",
            "scp"});
            this.cbAdjustSpeed.Location = new System.Drawing.Point(235, 20);
            this.cbAdjustSpeed.Name = "cbAdjustSpeed";
            this.cbAdjustSpeed.Size = new System.Drawing.Size(90, 24);
            this.cbAdjustSpeed.TabIndex = 38;
            this.cbAdjustSpeed.SelectedIndexChanged += new System.EventHandler(this.cbAdjustSpeed_SelectedIndexChanged);
            // 
            // txtAdjustSpeed
            // 
            this.txtAdjustSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtAdjustSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjustSpeed.ForeColor = System.Drawing.Color.White;
            this.txtAdjustSpeed.Location = new System.Drawing.Point(131, 20);
            this.txtAdjustSpeed.MaxLength = 3;
            this.txtAdjustSpeed.Name = "txtAdjustSpeed";
            this.txtAdjustSpeed.Size = new System.Drawing.Size(90, 22);
            this.txtAdjustSpeed.TabIndex = 37;
            this.txtAdjustSpeed.Text = "300";
            this.txtAdjustSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdjustSpeed.TextChanged += new System.EventHandler(this.txtAdjustSpeed_TextChanged);
            // 
            // chkAdjustSpeed
            // 
            this.chkAdjustSpeed.AutoSize = true;
            this.chkAdjustSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdjustSpeed.Location = new System.Drawing.Point(11, 22);
            this.chkAdjustSpeed.Name = "chkAdjustSpeed";
            this.chkAdjustSpeed.Size = new System.Drawing.Size(115, 21);
            this.chkAdjustSpeed.TabIndex = 36;
            this.chkAdjustSpeed.Text = "Adjust-Speed";
            this.toolTipRFD.SetToolTip(this.chkAdjustSpeed, "Host Tools v0.18 or later");
            this.chkAdjustSpeed.UseVisualStyleBackColor = true;
            this.chkAdjustSpeed.CheckedChanged += new System.EventHandler(this.chkAdjustSpeed_CheckedChanged);
            // 
            // chkHeadSwap
            // 
            this.chkHeadSwap.AutoSize = true;
            this.chkHeadSwap.Location = new System.Drawing.Point(21, 85);
            this.chkHeadSwap.Name = "chkHeadSwap";
            this.chkHeadSwap.Size = new System.Drawing.Size(102, 21);
            this.chkHeadSwap.TabIndex = 29;
            this.chkHeadSwap.Text = "Head Swap";
            this.chkHeadSwap.UseVisualStyleBackColor = true;
            this.chkHeadSwap.CheckedChanged += new System.EventHandler(this.chkHeadSwap_CheckedChanged);
            // 
            // chkLegacySS
            // 
            this.chkLegacySS.AutoSize = true;
            this.chkLegacySS.Location = new System.Drawing.Point(141, 85);
            this.chkLegacySS.Name = "chkLegacySS";
            this.chkLegacySS.Size = new System.Drawing.Size(98, 21);
            this.chkLegacySS.TabIndex = 30;
            this.chkLegacySS.Text = "SS Legacy";
            this.chkLegacySS.UseVisualStyleBackColor = true;
            this.chkLegacySS.CheckedChanged += new System.EventHandler(this.chkLegacySS_CheckedChanged);
            // 
            // chkHeadsSet
            // 
            this.chkHeadsSet.AutoSize = true;
            this.chkHeadsSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHeadsSet.Location = new System.Drawing.Point(21, 57);
            this.chkHeadsSet.Name = "chkHeadsSet";
            this.chkHeadsSet.Size = new System.Drawing.Size(94, 21);
            this.chkHeadsSet.TabIndex = 27;
            this.chkHeadsSet.Text = "Head sets";
            this.toolTipRFD.SetToolTip(this.chkHeadsSet, "Host Tools v0.22 or later");
            this.chkHeadsSet.UseVisualStyleBackColor = true;
            this.chkHeadsSet.CheckedChanged += new System.EventHandler(this.chkHeadsSet_CheckedChanged);
            // 
            // txtHeadsSet
            // 
            this.txtHeadsSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtHeadsSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadsSet.ForeColor = System.Drawing.Color.White;
            this.txtHeadsSet.Location = new System.Drawing.Point(141, 55);
            this.txtHeadsSet.Name = "txtHeadsSet";
            this.txtHeadsSet.Size = new System.Drawing.Size(99, 22);
            this.txtHeadsSet.TabIndex = 28;
            this.txtHeadsSet.Text = "0-1";
            this.txtHeadsSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipRFD.SetToolTip(this.txtHeadsSet, "Host Tools v0.22 or later");
            this.txtHeadsSet.TextChanged += new System.EventHandler(this.txtHeadsSet_TextChanged);
            // 
            // chkCylSet
            // 
            this.chkCylSet.AutoSize = true;
            this.chkCylSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCylSet.Location = new System.Drawing.Point(21, 27);
            this.chkCylSet.Name = "chkCylSet";
            this.chkCylSet.Size = new System.Drawing.Size(111, 21);
            this.chkCylSet.TabIndex = 25;
            this.chkCylSet.Text = "Cylinder sets";
            this.toolTipRFD.SetToolTip(this.chkCylSet, "Host Tools v0.22 or later");
            this.chkCylSet.UseVisualStyleBackColor = true;
            this.chkCylSet.CheckedChanged += new System.EventHandler(this.chkCylSet_CheckedChanged);
            // 
            // txtCylSet
            // 
            this.txtCylSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCylSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCylSet.ForeColor = System.Drawing.Color.White;
            this.txtCylSet.Location = new System.Drawing.Point(141, 25);
            this.txtCylSet.Name = "txtCylSet";
            this.txtCylSet.Size = new System.Drawing.Size(210, 22);
            this.txtCylSet.TabIndex = 26;
            this.txtCylSet.Text = "0-34,35-79";
            this.txtCylSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipRFD.SetToolTip(this.txtCylSet, "Host Tools v0.22 or later");
            this.txtCylSet.TextChanged += new System.EventHandler(this.txtCylSet_TextChanged);
            // 
            // gbFlippy
            // 
            this.gbFlippy.Controls.Add(this.chkFlippyOffset);
            this.gbFlippy.Controls.Add(this.rbFlippyPanasonic);
            this.gbFlippy.Controls.Add(this.rbFlippyTeac);
            this.gbFlippy.Location = new System.Drawing.Point(12, 107);
            this.gbFlippy.Name = "gbFlippy";
            this.gbFlippy.Size = new System.Drawing.Size(340, 58);
            this.gbFlippy.TabIndex = 31;
            this.gbFlippy.TabStop = false;
            this.toolTipRFD.SetToolTip(this.gbFlippy, "C64 flippy\r\nc=0-39:h=0,1:step=2:h1.off=-8");
            // 
            // chkFlippyOffset
            // 
            this.chkFlippyOffset.AutoSize = true;
            this.chkFlippyOffset.Location = new System.Drawing.Point(11, 21);
            this.chkFlippyOffset.Name = "chkFlippyOffset";
            this.chkFlippyOffset.Size = new System.Drawing.Size(106, 21);
            this.chkFlippyOffset.TabIndex = 32;
            this.chkFlippyOffset.Text = "Flippy offset";
            this.toolTipRFD.SetToolTip(this.chkFlippyOffset, "Host Tools v0.22 or later");
            this.chkFlippyOffset.UseVisualStyleBackColor = true;
            this.chkFlippyOffset.CheckedChanged += new System.EventHandler(this.chkFlippyOffset_CheckedChanged);
            // 
            // rbFlippyPanasonic
            // 
            this.rbFlippyPanasonic.AutoSize = true;
            this.rbFlippyPanasonic.Location = new System.Drawing.Point(133, 22);
            this.rbFlippyPanasonic.Name = "rbFlippyPanasonic";
            this.rbFlippyPanasonic.Size = new System.Drawing.Size(95, 21);
            this.rbFlippyPanasonic.TabIndex = 33;
            this.rbFlippyPanasonic.Text = "Panasonic";
            this.toolTipRFD.SetToolTip(this.rbFlippyPanasonic, "Host Tools v0.22 or later");
            this.rbFlippyPanasonic.UseVisualStyleBackColor = true;
            this.rbFlippyPanasonic.CheckedChanged += new System.EventHandler(this.rbFlippyPanasonic_CheckedChanged);
            // 
            // rbFlippyTeac
            // 
            this.rbFlippyTeac.AutoSize = true;
            this.rbFlippyTeac.Location = new System.Drawing.Point(258, 22);
            this.rbFlippyTeac.Name = "rbFlippyTeac";
            this.rbFlippyTeac.Size = new System.Drawing.Size(61, 21);
            this.rbFlippyTeac.TabIndex = 34;
            this.rbFlippyTeac.Text = "Teac";
            this.toolTipRFD.SetToolTip(this.rbFlippyTeac, "Host Tools v0.22 or later");
            this.rbFlippyTeac.UseVisualStyleBackColor = true;
            this.rbFlippyTeac.CheckedChanged += new System.EventHandler(this.rbFlippyTeac_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFakeIndex);
            this.groupBox2.Controls.Add(this.cbFakeIndex);
            this.groupBox2.Controls.Add(this.chkFakeIndex);
            this.groupBox2.Controls.Add(this.chkRaw);
            this.groupBox2.Controls.Add(this.chkNoClobber);
            this.groupBox2.Controls.Add(this.txtDriveRetriesRFD);
            this.groupBox2.Controls.Add(this.chkDriveRetriesRFD);
            this.groupBox2.Controls.Add(this.txtBitrateRFD);
            this.groupBox2.Controls.Add(this.chkBitrateRFD);
            this.groupBox2.Controls.Add(this.txtDriveSelectRFD);
            this.groupBox2.Controls.Add(this.chkDriveSelectRFD);
            this.groupBox2.Controls.Add(this.txtDoubleStep);
            this.groupBox2.Controls.Add(this.chkDoubleStep);
            this.groupBox2.Controls.Add(this.chkRevsPerTrack);
            this.groupBox2.Controls.Add(this.txtRevsPerTrack);
            this.groupBox2.Location = new System.Drawing.Point(11, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 238);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtFakeIndex
            // 
            this.txtFakeIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtFakeIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFakeIndex.ForeColor = System.Drawing.Color.White;
            this.txtFakeIndex.Location = new System.Drawing.Point(142, 165);
            this.txtFakeIndex.MaxLength = 3;
            this.txtFakeIndex.Name = "txtFakeIndex";
            this.txtFakeIndex.Size = new System.Drawing.Size(90, 22);
            this.txtFakeIndex.TabIndex = 20;
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
            this.cbFakeIndex.Location = new System.Drawing.Point(263, 164);
            this.cbFakeIndex.Name = "cbFakeIndex";
            this.cbFakeIndex.Size = new System.Drawing.Size(84, 24);
            this.cbFakeIndex.TabIndex = 21;
            this.cbFakeIndex.SelectedIndexChanged += new System.EventHandler(this.cbFakeIndex_SelectedIndexChanged);
            // 
            // chkFakeIndex
            // 
            this.chkFakeIndex.AutoSize = true;
            this.chkFakeIndex.Location = new System.Drawing.Point(20, 166);
            this.chkFakeIndex.Name = "chkFakeIndex";
            this.chkFakeIndex.Size = new System.Drawing.Size(98, 21);
            this.chkFakeIndex.TabIndex = 19;
            this.chkFakeIndex.Text = "Fake Index";
            this.chkFakeIndex.UseVisualStyleBackColor = true;
            this.chkFakeIndex.CheckedChanged += new System.EventHandler(this.chkFakeIndex_CheckedChanged);
            // 
            // chkRaw
            // 
            this.chkRaw.AutoSize = true;
            this.chkRaw.Location = new System.Drawing.Point(142, 194);
            this.chkRaw.Name = "chkRaw";
            this.chkRaw.Size = new System.Drawing.Size(57, 21);
            this.chkRaw.TabIndex = 23;
            this.chkRaw.Text = "Raw";
            this.chkRaw.UseVisualStyleBackColor = true;
            this.chkRaw.CheckedChanged += new System.EventHandler(this.chkRaw_CheckedChanged);
            // 
            // chkNoClobber
            // 
            this.chkNoClobber.AutoSize = true;
            this.chkNoClobber.Location = new System.Drawing.Point(20, 194);
            this.chkNoClobber.Name = "chkNoClobber";
            this.chkNoClobber.Size = new System.Drawing.Size(101, 21);
            this.chkNoClobber.TabIndex = 22;
            this.chkNoClobber.Text = "No Clobber";
            this.chkNoClobber.UseVisualStyleBackColor = true;
            this.chkNoClobber.CheckedChanged += new System.EventHandler(this.chkNoClobber_CheckedChanged);
            // 
            // txtDriveRetriesRFD
            // 
            this.txtDriveRetriesRFD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDriveRetriesRFD.ForeColor = System.Drawing.Color.White;
            this.txtDriveRetriesRFD.Location = new System.Drawing.Point(263, 137);
            this.txtDriveRetriesRFD.MaxLength = 3;
            this.txtDriveRetriesRFD.Name = "txtDriveRetriesRFD";
            this.txtDriveRetriesRFD.Size = new System.Drawing.Size(84, 22);
            this.txtDriveRetriesRFD.TabIndex = 18;
            this.txtDriveRetriesRFD.Text = "3";
            this.txtDriveRetriesRFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDriveRetriesRFD.TextChanged += new System.EventHandler(this.txtDriveRetriesRFD_TextChanged);
            // 
            // chkDriveRetriesRFD
            // 
            this.chkDriveRetriesRFD.AutoSize = true;
            this.chkDriveRetriesRFD.Location = new System.Drawing.Point(20, 138);
            this.chkDriveRetriesRFD.Name = "chkDriveRetriesRFD";
            this.chkDriveRetriesRFD.Size = new System.Drawing.Size(75, 21);
            this.chkDriveRetriesRFD.TabIndex = 17;
            this.chkDriveRetriesRFD.Text = "Retries";
            this.chkDriveRetriesRFD.UseVisualStyleBackColor = true;
            this.chkDriveRetriesRFD.CheckedChanged += new System.EventHandler(this.chkDriveRetriesRFD_CheckedChanged);
            // 
            // txtBitrateRFD
            // 
            this.txtBitrateRFD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtBitrateRFD.ForeColor = System.Drawing.Color.White;
            this.txtBitrateRFD.Location = new System.Drawing.Point(263, 109);
            this.txtBitrateRFD.MaxLength = 4;
            this.txtBitrateRFD.Name = "txtBitrateRFD";
            this.txtBitrateRFD.Size = new System.Drawing.Size(84, 22);
            this.txtBitrateRFD.TabIndex = 16;
            this.txtBitrateRFD.Text = "250";
            this.txtBitrateRFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBitrateRFD.TextChanged += new System.EventHandler(this.txtBitrateRFD_TextChanged);
            // 
            // chkBitrateRFD
            // 
            this.chkBitrateRFD.AutoSize = true;
            this.chkBitrateRFD.Location = new System.Drawing.Point(20, 110);
            this.chkBitrateRFD.Name = "chkBitrateRFD";
            this.chkBitrateRFD.Size = new System.Drawing.Size(149, 21);
            this.chkBitrateRFD.TabIndex = 15;
            this.chkBitrateRFD.Text = "Bitrate (HFE kbit/s)";
            this.toolTipRFD.SetToolTip(this.chkBitrateRFD, "Host Tools v0.18 or later");
            this.chkBitrateRFD.UseVisualStyleBackColor = true;
            this.chkBitrateRFD.CheckedChanged += new System.EventHandler(this.chkBitrateRFD_CheckedChanged);
            // 
            // txtDriveSelectRFD
            // 
            this.txtDriveSelectRFD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDriveSelectRFD.ForeColor = System.Drawing.Color.White;
            this.txtDriveSelectRFD.Location = new System.Drawing.Point(263, 81);
            this.txtDriveSelectRFD.MaxLength = 1;
            this.txtDriveSelectRFD.Name = "txtDriveSelectRFD";
            this.txtDriveSelectRFD.Size = new System.Drawing.Size(84, 22);
            this.txtDriveSelectRFD.TabIndex = 14;
            this.txtDriveSelectRFD.Text = "A";
            this.txtDriveSelectRFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDriveSelectRFD.TextChanged += new System.EventHandler(this.txtDriveSelectRFD_TextChanged);
            // 
            // chkDriveSelectRFD
            // 
            this.chkDriveSelectRFD.AutoSize = true;
            this.chkDriveSelectRFD.Location = new System.Drawing.Point(20, 82);
            this.chkDriveSelectRFD.Name = "chkDriveSelectRFD";
            this.chkDriveSelectRFD.Size = new System.Drawing.Size(182, 21);
            this.chkDriveSelectRFD.TabIndex = 13;
            this.chkDriveSelectRFD.Text = "F7 Drive Select (AB012)";
            this.toolTipRFD.SetToolTip(this.chkDriveSelectRFD, "Host Tools v0.10 or later\r\nRequires F7 type");
            this.chkDriveSelectRFD.UseVisualStyleBackColor = true;
            this.chkDriveSelectRFD.CheckedChanged += new System.EventHandler(this.chkDriveSelectRFD_CheckedChanged);
            // 
            // txtDoubleStep
            // 
            this.txtDoubleStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDoubleStep.ForeColor = System.Drawing.Color.White;
            this.txtDoubleStep.Location = new System.Drawing.Point(263, 25);
            this.txtDoubleStep.Name = "txtDoubleStep";
            this.txtDoubleStep.Size = new System.Drawing.Size(84, 22);
            this.txtDoubleStep.TabIndex = 6;
            this.txtDoubleStep.Text = "2";
            this.txtDoubleStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDoubleStep.TextChanged += new System.EventHandler(this.txtDoubleStep_TextChanged);
            // 
            // chkDoubleStep
            // 
            this.chkDoubleStep.AutoSize = true;
            this.chkDoubleStep.Location = new System.Drawing.Point(20, 26);
            this.chkDoubleStep.Name = "chkDoubleStep";
            this.chkDoubleStep.Size = new System.Drawing.Size(142, 21);
            this.chkDoubleStep.TabIndex = 5;
            this.chkDoubleStep.Text = "Double-Step [0-9]";
            this.toolTipRFD.SetToolTip(this.chkDoubleStep, "Host Tools v0.12 or later");
            this.chkDoubleStep.UseVisualStyleBackColor = true;
            this.chkDoubleStep.CheckedChanged += new System.EventHandler(this.chkDoubleStep_CheckedChanged);
            // 
            // chkRevsPerTrack
            // 
            this.chkRevsPerTrack.AutoSize = true;
            this.chkRevsPerTrack.Location = new System.Drawing.Point(20, 54);
            this.chkRevsPerTrack.Name = "chkRevsPerTrack";
            this.chkRevsPerTrack.Size = new System.Drawing.Size(171, 21);
            this.chkRevsPerTrack.TabIndex = 7;
            this.chkRevsPerTrack.Text = "Revs to read per track";
            this.chkRevsPerTrack.UseVisualStyleBackColor = true;
            this.chkRevsPerTrack.CheckedChanged += new System.EventHandler(this.chkRevsPerTrack_CheckedChanged);
            // 
            // txtRevsPerTrack
            // 
            this.txtRevsPerTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtRevsPerTrack.ForeColor = System.Drawing.Color.White;
            this.txtRevsPerTrack.Location = new System.Drawing.Point(263, 53);
            this.txtRevsPerTrack.Name = "txtRevsPerTrack";
            this.txtRevsPerTrack.Size = new System.Drawing.Size(84, 22);
            this.txtRevsPerTrack.TabIndex = 8;
            this.txtRevsPerTrack.Text = "3";
            this.txtRevsPerTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRevsPerTrack.TextChanged += new System.EventHandler(this.txtRevsPerTrack_TextChanged);
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(222, 653);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(367, 23);
            this.lblHostTools.TabIndex = 58;
            this.lblHostTools.Text = "for Host Tools v0.00";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ctxOutput.Size = new System.Drawing.Size(163, 52);
            // 
            // ctxClearOutput
            // 
            this.ctxClearOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctxClearOutput.ForeColor = System.Drawing.Color.White;
            this.ctxClearOutput.Name = "ctxClearOutput";
            this.ctxClearOutput.Size = new System.Drawing.Size(162, 24);
            this.ctxClearOutput.Text = "Clear Output";
            this.ctxClearOutput.Click += new System.EventHandler(this.ctxClearOutput_Click);
            // 
            // ctxSaveOutput
            // 
            this.ctxSaveOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctxSaveOutput.ForeColor = System.Drawing.Color.White;
            this.ctxSaveOutput.Name = "ctxSaveOutput";
            this.ctxSaveOutput.Size = new System.Drawing.Size(162, 24);
            this.ctxSaveOutput.Text = "Save Output";
            this.ctxSaveOutput.Click += new System.EventHandler(this.ctxSaveOutput_Click);
            // 
            // ReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(811, 696);
            this.Controls.Add(this.lblHostTools);
            this.Controls.Add(this.gbReadFromDisk);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Read From Disk";
            this.Load += new System.EventHandler(this.ReadForm_Load);
            this.gbReadFromDisk.ResumeLayout(false);
            this.gbReadFromDisk.PerformLayout();
            this.gbFilename.ResumeLayout(false);
            this.gbFilename.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbAdjustSpeed.ResumeLayout(false);
            this.gbAdjustSpeed.PerformLayout();
            this.gbFlippy.ResumeLayout(false);
            this.gbFlippy.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ctxOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReadFromDisk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTipRFD;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtRFDCommandLine;
        private System.Windows.Forms.Label lblCommandLine;
        private System.Windows.Forms.Button btnRFDSelectFile;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnRFDSelectFolder;
        private System.Windows.Forms.GroupBox gbFilename;
        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button btnInc;
        private System.Windows.Forms.TextBox tbSuffix;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.CheckBox chkAutoInc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkLegacySS;
        private System.Windows.Forms.CheckBox chkHeadsSet;
        private System.Windows.Forms.TextBox txtHeadsSet;
        private System.Windows.Forms.CheckBox chkCylSet;
        private System.Windows.Forms.TextBox txtCylSet;
        private System.Windows.Forms.GroupBox gbFlippy;
        private System.Windows.Forms.CheckBox chkFlippyOffset;
        private System.Windows.Forms.RadioButton rbFlippyPanasonic;
        private System.Windows.Forms.RadioButton rbFlippyTeac;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBitrateRFD;
        private System.Windows.Forms.CheckBox chkBitrateRFD;
        private System.Windows.Forms.TextBox txtDriveSelectRFD;
        private System.Windows.Forms.CheckBox chkDriveSelectRFD;
        private System.Windows.Forms.TextBox txtDoubleStep;
        private System.Windows.Forms.CheckBox chkDoubleStep;
        private System.Windows.Forms.CheckBox chkRevsPerTrack;
        private System.Windows.Forms.TextBox txtRevsPerTrack;
        private System.Windows.Forms.Label lblHostTools;
        private System.Windows.Forms.TextBox txtDriveRetriesRFD;
        private System.Windows.Forms.CheckBox chkDriveRetriesRFD;
        private System.Windows.Forms.ComboBox cbExtension;
        private System.Windows.Forms.Label lblDiskType;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.ListBox lbOutput;
        private System.ComponentModel.BackgroundWorker threadWorker;
        private System.Windows.Forms.ContextMenuStrip ctxOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxClearOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxSaveOutput;
        private System.Windows.Forms.CheckBox chkHeadSwap;
        private System.Windows.Forms.CheckBox chkNoClobber;
        private System.Windows.Forms.CheckBox chkRaw;
        private System.Windows.Forms.GroupBox gbAdjustSpeed;
        private System.Windows.Forms.ComboBox cbAdjustSpeed;
        private System.Windows.Forms.TextBox txtAdjustSpeed;
        private System.Windows.Forms.CheckBox chkAdjustSpeed;
        private System.Windows.Forms.CheckBox chkFakeIndex;
        private System.Windows.Forms.ComboBox cbFakeIndex;
        private System.Windows.Forms.TextBox txtFakeIndex;
    }
}