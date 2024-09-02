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
            this.gbHighLow = new System.Windows.Forms.GroupBox();
            this.chkPin2High = new System.Windows.Forms.CheckBox();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.chkPLLSpec = new System.Windows.Forms.CheckBox();
            this.txtPLLPhase = new System.Windows.Forms.TextBox();
            this.lblPLLPhase = new System.Windows.Forms.Label();
            this.txtPLLPeriod = new System.Windows.Forms.TextBox();
            this.lblPLLPeriod = new System.Windows.Forms.Label();
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
            this.chkRevTrkData = new System.Windows.Forms.CheckBox();
            this.gbReadFromDisk.SuspendLayout();
            this.gbFilename.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbAdjustSpeed.SuspendLayout();
            this.gbFlippy.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbHighLow.SuspendLayout();
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
            this.gbReadFromDisk.Location = new System.Drawing.Point(10, 6);
            this.gbReadFromDisk.Margin = new System.Windows.Forms.Padding(2);
            this.gbReadFromDisk.Name = "gbReadFromDisk";
            this.gbReadFromDisk.Padding = new System.Windows.Forms.Padding(2);
            this.gbReadFromDisk.Size = new System.Drawing.Size(586, 537);
            this.gbReadFromDisk.TabIndex = 0;
            this.gbReadFromDisk.TabStop = false;
            // 
            // lbOutput
            // 
            this.lbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbOutput.ForeColor = System.Drawing.Color.White;
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.HorizontalScrollbar = true;
            this.lbOutput.Location = new System.Drawing.Point(10, 413);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(2);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(569, 69);
            this.lbOutput.TabIndex = 63;
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
            this.gbFilename.Location = new System.Drawing.Point(10, 267);
            this.gbFilename.Margin = new System.Windows.Forms.Padding(2);
            this.gbFilename.Name = "gbFilename";
            this.gbFilename.Padding = new System.Windows.Forms.Padding(2);
            this.gbFilename.Size = new System.Drawing.Size(568, 72);
            this.gbFilename.TabIndex = 49;
            this.gbFilename.TabStop = false;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(302, 43);
            this.lblFormat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(42, 13);
            this.lblFormat.TabIndex = 59;
            this.lblFormat.Text = "Format:";
            // 
            // cbFormat
            // 
            this.cbFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbFormat.ForeColor = System.Drawing.Color.White;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(361, 41);
            this.cbFormat.Margin = new System.Windows.Forms.Padding(2);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(192, 21);
            this.cbFormat.TabIndex = 60;
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // lblDiskType
            // 
            this.lblDiskType.AutoSize = true;
            this.lblDiskType.Location = new System.Drawing.Point(14, 43);
            this.lblDiskType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiskType.Name = "lblDiskType";
            this.lblDiskType.Size = new System.Drawing.Size(55, 13);
            this.lblDiskType.TabIndex = 52;
            this.lblDiskType.Text = "DiskType:";
            // 
            // cbExtension
            // 
            this.cbExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbExtension.ForeColor = System.Drawing.Color.White;
            this.cbExtension.FormattingEnabled = true;
            this.cbExtension.Location = new System.Drawing.Point(78, 41);
            this.cbExtension.Margin = new System.Windows.Forms.Padding(2);
            this.cbExtension.Name = "cbExtension";
            this.cbExtension.Size = new System.Drawing.Size(192, 21);
            this.cbExtension.TabIndex = 53;
            this.cbExtension.SelectedIndexChanged += new System.EventHandler(this.cbExtension_SelectedIndexChanged);
            // 
            // chkAutoInc
            // 
            this.chkAutoInc.AutoSize = true;
            this.chkAutoInc.Location = new System.Drawing.Point(304, 17);
            this.chkAutoInc.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoInc.Name = "chkAutoInc";
            this.chkAutoInc.Size = new System.Drawing.Size(53, 17);
            this.chkAutoInc.TabIndex = 54;
            this.chkAutoInc.Text = "Inc++";
            this.chkAutoInc.UseVisualStyleBackColor = true;
            // 
            // btnDec
            // 
            this.btnDec.BackColor = System.Drawing.Color.Maroon;
            this.btnDec.Location = new System.Drawing.Point(510, 14);
            this.btnDec.Margin = new System.Windows.Forms.Padding(2);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(44, 24);
            this.btnDec.TabIndex = 58;
            this.btnDec.Text = "<<<<";
            this.btnDec.UseVisualStyleBackColor = false;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnInc
            // 
            this.btnInc.BackColor = System.Drawing.Color.Maroon;
            this.btnInc.Location = new System.Drawing.Point(460, 14);
            this.btnInc.Margin = new System.Windows.Forms.Padding(2);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(44, 24);
            this.btnInc.TabIndex = 57;
            this.btnInc.Text = ">>>>";
            this.btnInc.UseVisualStyleBackColor = false;
            this.btnInc.Click += new System.EventHandler(this.btnInc_Click);
            // 
            // tbSuffix
            // 
            this.tbSuffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbSuffix.ForeColor = System.Drawing.Color.White;
            this.tbSuffix.Location = new System.Drawing.Point(410, 16);
            this.tbSuffix.Margin = new System.Windows.Forms.Padding(2);
            this.tbSuffix.MaxLength = 3;
            this.tbSuffix.Name = "tbSuffix";
            this.tbSuffix.Size = new System.Drawing.Size(44, 20);
            this.tbSuffix.TabIndex = 56;
            this.tbSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSuffix.TextChanged += new System.EventHandler(this.tbSuffix_TextChanged);
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(374, 19);
            this.lblSuffix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(36, 13);
            this.lblSuffix.TabIndex = 55;
            this.lblSuffix.Text = "Suffix:";
            // 
            // tbFilename
            // 
            this.tbFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbFilename.ForeColor = System.Drawing.Color.White;
            this.tbFilename.Location = new System.Drawing.Point(78, 16);
            this.tbFilename.Margin = new System.Windows.Forms.Padding(2);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(192, 20);
            this.tbFilename.TabIndex = 51;
            this.tbFilename.Text = "mydisk.scp";
            this.tbFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFilename.TextChanged += new System.EventHandler(this.tbFilename_TextChanged);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(14, 19);
            this.lblFilename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(52, 13);
            this.lblFilename.TabIndex = 50;
            this.lblFilename.Text = "Filename:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(448, 488);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 24);
            this.btnBack.TabIndex = 67;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRFDCommandLine
            // 
            this.txtRFDCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtRFDCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtRFDCommandLine.Location = new System.Drawing.Point(10, 361);
            this.txtRFDCommandLine.Margin = new System.Windows.Forms.Padding(2);
            this.txtRFDCommandLine.Multiline = true;
            this.txtRFDCommandLine.Name = "txtRFDCommandLine";
            this.txtRFDCommandLine.Size = new System.Drawing.Size(569, 45);
            this.txtRFDCommandLine.TabIndex = 62;
            // 
            // lblCommandLine
            // 
            this.lblCommandLine.AutoSize = true;
            this.lblCommandLine.Location = new System.Drawing.Point(255, 344);
            this.lblCommandLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCommandLine.Name = "lblCommandLine";
            this.lblCommandLine.Size = new System.Drawing.Size(77, 13);
            this.lblCommandLine.TabIndex = 61;
            this.lblCommandLine.Text = "Command Line";
            // 
            // btnRFDSelectFile
            // 
            this.btnRFDSelectFile.BackColor = System.Drawing.Color.Maroon;
            this.btnRFDSelectFile.Location = new System.Drawing.Point(198, 488);
            this.btnRFDSelectFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnRFDSelectFile.Name = "btnRFDSelectFile";
            this.btnRFDSelectFile.Size = new System.Drawing.Size(81, 24);
            this.btnRFDSelectFile.TabIndex = 65;
            this.btnRFDSelectFile.Text = "Select File";
            this.btnRFDSelectFile.UseVisualStyleBackColor = false;
            this.btnRFDSelectFile.Click += new System.EventHandler(this.btnRFDSelectFile_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(328, 488);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(81, 24);
            this.btnLaunch.TabIndex = 66;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnRFDSelectFolder
            // 
            this.btnRFDSelectFolder.BackColor = System.Drawing.Color.Maroon;
            this.btnRFDSelectFolder.Location = new System.Drawing.Point(68, 488);
            this.btnRFDSelectFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnRFDSelectFolder.Name = "btnRFDSelectFolder";
            this.btnRFDSelectFolder.Size = new System.Drawing.Size(81, 24);
            this.btnRFDSelectFolder.TabIndex = 64;
            this.btnRFDSelectFolder.Text = "Select Folder";
            this.btnRFDSelectFolder.UseVisualStyleBackColor = false;
            this.btnRFDSelectFolder.Click += new System.EventHandler(this.btnRFDSelectFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(568, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkRevTrkData);
            this.groupBox3.Controls.Add(this.gbAdjustSpeed);
            this.groupBox3.Controls.Add(this.chkHeadSwap);
            this.groupBox3.Controls.Add(this.chkLegacySS);
            this.groupBox3.Controls.Add(this.chkHeadsSet);
            this.groupBox3.Controls.Add(this.txtHeadsSet);
            this.groupBox3.Controls.Add(this.chkCylSet);
            this.groupBox3.Controls.Add(this.txtCylSet);
            this.groupBox3.Controls.Add(this.gbFlippy);
            this.groupBox3.Location = new System.Drawing.Point(288, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(272, 228);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // gbAdjustSpeed
            // 
            this.gbAdjustSpeed.Controls.Add(this.cbAdjustSpeed);
            this.gbAdjustSpeed.Controls.Add(this.txtAdjustSpeed);
            this.gbAdjustSpeed.Controls.Add(this.chkAdjustSpeed);
            this.gbAdjustSpeed.Location = new System.Drawing.Point(8, 169);
            this.gbAdjustSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.gbAdjustSpeed.Name = "gbAdjustSpeed";
            this.gbAdjustSpeed.Padding = new System.Windows.Forms.Padding(2);
            this.gbAdjustSpeed.Size = new System.Drawing.Size(255, 47);
            this.gbAdjustSpeed.TabIndex = 45;
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
            this.cbAdjustSpeed.Location = new System.Drawing.Point(176, 16);
            this.cbAdjustSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.cbAdjustSpeed.Name = "cbAdjustSpeed";
            this.cbAdjustSpeed.Size = new System.Drawing.Size(68, 21);
            this.cbAdjustSpeed.TabIndex = 48;
            this.cbAdjustSpeed.SelectedIndexChanged += new System.EventHandler(this.cbAdjustSpeed_SelectedIndexChanged);
            // 
            // txtAdjustSpeed
            // 
            this.txtAdjustSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtAdjustSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjustSpeed.ForeColor = System.Drawing.Color.White;
            this.txtAdjustSpeed.Location = new System.Drawing.Point(98, 16);
            this.txtAdjustSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdjustSpeed.MaxLength = 3;
            this.txtAdjustSpeed.Name = "txtAdjustSpeed";
            this.txtAdjustSpeed.Size = new System.Drawing.Size(68, 19);
            this.txtAdjustSpeed.TabIndex = 47;
            this.txtAdjustSpeed.Text = "300";
            this.txtAdjustSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdjustSpeed.TextChanged += new System.EventHandler(this.txtAdjustSpeed_TextChanged);
            // 
            // chkAdjustSpeed
            // 
            this.chkAdjustSpeed.AutoSize = true;
            this.chkAdjustSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdjustSpeed.Location = new System.Drawing.Point(8, 18);
            this.chkAdjustSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.chkAdjustSpeed.Name = "chkAdjustSpeed";
            this.chkAdjustSpeed.Size = new System.Drawing.Size(89, 17);
            this.chkAdjustSpeed.TabIndex = 46;
            this.chkAdjustSpeed.Text = "Adjust-Speed";
            this.toolTipRFD.SetToolTip(this.chkAdjustSpeed, "Host Tools v0.18 or later");
            this.chkAdjustSpeed.UseVisualStyleBackColor = true;
            this.chkAdjustSpeed.CheckedChanged += new System.EventHandler(this.chkAdjustSpeed_CheckedChanged);
            // 
            // chkHeadSwap
            // 
            this.chkHeadSwap.AutoSize = true;
            this.chkHeadSwap.Location = new System.Drawing.Point(16, 68);
            this.chkHeadSwap.Margin = new System.Windows.Forms.Padding(2);
            this.chkHeadSwap.Name = "chkHeadSwap";
            this.chkHeadSwap.Size = new System.Drawing.Size(82, 17);
            this.chkHeadSwap.TabIndex = 39;
            this.chkHeadSwap.Text = "Head Swap";
            this.chkHeadSwap.UseVisualStyleBackColor = true;
            this.chkHeadSwap.CheckedChanged += new System.EventHandler(this.chkHeadSwap_CheckedChanged);
            // 
            // chkLegacySS
            // 
            this.chkLegacySS.AutoSize = true;
            this.chkLegacySS.Location = new System.Drawing.Point(106, 69);
            this.chkLegacySS.Margin = new System.Windows.Forms.Padding(2);
            this.chkLegacySS.Name = "chkLegacySS";
            this.chkLegacySS.Size = new System.Drawing.Size(78, 17);
            this.chkLegacySS.TabIndex = 40;
            this.chkLegacySS.Text = "SS Legacy";
            this.chkLegacySS.UseVisualStyleBackColor = true;
            this.chkLegacySS.CheckedChanged += new System.EventHandler(this.chkLegacySS_CheckedChanged);
            // 
            // chkHeadsSet
            // 
            this.chkHeadsSet.AutoSize = true;
            this.chkHeadsSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHeadsSet.Location = new System.Drawing.Point(16, 46);
            this.chkHeadsSet.Margin = new System.Windows.Forms.Padding(2);
            this.chkHeadsSet.Name = "chkHeadsSet";
            this.chkHeadsSet.Size = new System.Drawing.Size(74, 17);
            this.chkHeadsSet.TabIndex = 37;
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
            this.txtHeadsSet.Location = new System.Drawing.Point(106, 45);
            this.txtHeadsSet.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeadsSet.Name = "txtHeadsSet";
            this.txtHeadsSet.Size = new System.Drawing.Size(75, 19);
            this.txtHeadsSet.TabIndex = 38;
            this.txtHeadsSet.Text = "0-1";
            this.txtHeadsSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipRFD.SetToolTip(this.txtHeadsSet, "Host Tools v0.22 or later");
            this.txtHeadsSet.TextChanged += new System.EventHandler(this.txtHeadsSet_TextChanged);
            // 
            // chkCylSet
            // 
            this.chkCylSet.AutoSize = true;
            this.chkCylSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCylSet.Location = new System.Drawing.Point(16, 22);
            this.chkCylSet.Margin = new System.Windows.Forms.Padding(2);
            this.chkCylSet.Name = "chkCylSet";
            this.chkCylSet.Size = new System.Drawing.Size(85, 17);
            this.chkCylSet.TabIndex = 35;
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
            this.txtCylSet.Location = new System.Drawing.Point(106, 20);
            this.txtCylSet.Margin = new System.Windows.Forms.Padding(2);
            this.txtCylSet.Name = "txtCylSet";
            this.txtCylSet.Size = new System.Drawing.Size(158, 19);
            this.txtCylSet.TabIndex = 36;
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
            this.gbFlippy.Location = new System.Drawing.Point(9, 118);
            this.gbFlippy.Margin = new System.Windows.Forms.Padding(2);
            this.gbFlippy.Name = "gbFlippy";
            this.gbFlippy.Padding = new System.Windows.Forms.Padding(2);
            this.gbFlippy.Size = new System.Drawing.Size(255, 47);
            this.gbFlippy.TabIndex = 41;
            this.gbFlippy.TabStop = false;
            this.toolTipRFD.SetToolTip(this.gbFlippy, "C64 flippy\r\nc=0-39:h=0,1:step=2:h1.off=-8");
            // 
            // chkFlippyOffset
            // 
            this.chkFlippyOffset.AutoSize = true;
            this.chkFlippyOffset.Location = new System.Drawing.Point(8, 17);
            this.chkFlippyOffset.Margin = new System.Windows.Forms.Padding(2);
            this.chkFlippyOffset.Name = "chkFlippyOffset";
            this.chkFlippyOffset.Size = new System.Drawing.Size(82, 17);
            this.chkFlippyOffset.TabIndex = 42;
            this.chkFlippyOffset.Text = "Flippy offset";
            this.toolTipRFD.SetToolTip(this.chkFlippyOffset, "Host Tools v0.22 or later");
            this.chkFlippyOffset.UseVisualStyleBackColor = true;
            this.chkFlippyOffset.CheckedChanged += new System.EventHandler(this.chkFlippyOffset_CheckedChanged);
            // 
            // rbFlippyPanasonic
            // 
            this.rbFlippyPanasonic.AutoSize = true;
            this.rbFlippyPanasonic.Location = new System.Drawing.Point(100, 18);
            this.rbFlippyPanasonic.Margin = new System.Windows.Forms.Padding(2);
            this.rbFlippyPanasonic.Name = "rbFlippyPanasonic";
            this.rbFlippyPanasonic.Size = new System.Drawing.Size(75, 17);
            this.rbFlippyPanasonic.TabIndex = 43;
            this.rbFlippyPanasonic.Text = "Panasonic";
            this.toolTipRFD.SetToolTip(this.rbFlippyPanasonic, "Host Tools v0.22 or later");
            this.rbFlippyPanasonic.UseVisualStyleBackColor = true;
            this.rbFlippyPanasonic.CheckedChanged += new System.EventHandler(this.rbFlippyPanasonic_CheckedChanged);
            // 
            // rbFlippyTeac
            // 
            this.rbFlippyTeac.AutoSize = true;
            this.rbFlippyTeac.Location = new System.Drawing.Point(194, 18);
            this.rbFlippyTeac.Margin = new System.Windows.Forms.Padding(2);
            this.rbFlippyTeac.Name = "rbFlippyTeac";
            this.rbFlippyTeac.Size = new System.Drawing.Size(50, 17);
            this.rbFlippyTeac.TabIndex = 44;
            this.rbFlippyTeac.Text = "Teac";
            this.toolTipRFD.SetToolTip(this.rbFlippyTeac, "Host Tools v0.22 or later");
            this.rbFlippyTeac.UseVisualStyleBackColor = true;
            this.rbFlippyTeac.CheckedChanged += new System.EventHandler(this.rbFlippyTeac_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbHighLow);
            this.groupBox2.Controls.Add(this.chkPLLSpec);
            this.groupBox2.Controls.Add(this.txtPLLPhase);
            this.groupBox2.Controls.Add(this.lblPLLPhase);
            this.groupBox2.Controls.Add(this.txtPLLPeriod);
            this.groupBox2.Controls.Add(this.lblPLLPeriod);
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
            this.groupBox2.Location = new System.Drawing.Point(8, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(272, 228);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // gbHighLow
            // 
            this.gbHighLow.Controls.Add(this.chkPin2High);
            this.gbHighLow.Controls.Add(this.rbHigh);
            this.gbHighLow.Controls.Add(this.rbLow);
            this.gbHighLow.Location = new System.Drawing.Point(10, 185);
            this.gbHighLow.Margin = new System.Windows.Forms.Padding(2);
            this.gbHighLow.Name = "gbHighLow";
            this.gbHighLow.Padding = new System.Windows.Forms.Padding(2);
            this.gbHighLow.Size = new System.Drawing.Size(252, 32);
            this.gbHighLow.TabIndex = 30;
            this.gbHighLow.TabStop = false;
            // 
            // chkPin2High
            // 
            this.chkPin2High.AutoSize = true;
            this.chkPin2High.Location = new System.Drawing.Point(7, 11);
            this.chkPin2High.Margin = new System.Windows.Forms.Padding(2);
            this.chkPin2High.Name = "chkPin2High";
            this.chkPin2High.Size = new System.Drawing.Size(93, 17);
            this.chkPin2High.TabIndex = 31;
            this.chkPin2High.Text = "5.25 Set Pin 2";
            this.chkPin2High.UseVisualStyleBackColor = true;
            this.chkPin2High.CheckedChanged += new System.EventHandler(this.chkPin2High_CheckedChanged);
            // 
            // rbHigh
            // 
            this.rbHigh.AutoSize = true;
            this.rbHigh.Location = new System.Drawing.Point(114, 11);
            this.rbHigh.Margin = new System.Windows.Forms.Padding(2);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(47, 17);
            this.rbHigh.TabIndex = 32;
            this.rbHigh.Text = "High";
            this.rbHigh.UseVisualStyleBackColor = true;
            this.rbHigh.CheckedChanged += new System.EventHandler(this.rbHigh_CheckedChanged);
            // 
            // rbLow
            // 
            this.rbLow.AutoSize = true;
            this.rbLow.Location = new System.Drawing.Point(200, 11);
            this.rbLow.Margin = new System.Windows.Forms.Padding(2);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(45, 17);
            this.rbLow.TabIndex = 33;
            this.rbLow.Text = "Low";
            this.rbLow.UseVisualStyleBackColor = true;
            this.rbLow.CheckedChanged += new System.EventHandler(this.rbLow_CheckedChanged);
            // 
            // chkPLLSpec
            // 
            this.chkPLLSpec.AutoSize = true;
            this.chkPLLSpec.Location = new System.Drawing.Point(15, 150);
            this.chkPLLSpec.Margin = new System.Windows.Forms.Padding(2);
            this.chkPLLSpec.Name = "chkPLLSpec";
            this.chkPLLSpec.Size = new System.Drawing.Size(73, 17);
            this.chkPLLSpec.TabIndex = 22;
            this.chkPLLSpec.Text = "PLLSPEC";
            this.chkPLLSpec.UseVisualStyleBackColor = true;
            this.chkPLLSpec.CheckedChanged += new System.EventHandler(this.PLLSpec_CheckedChanged);
            // 
            // txtPLLPhase
            // 
            this.txtPLLPhase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPLLPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLLPhase.ForeColor = System.Drawing.Color.White;
            this.txtPLLPhase.Location = new System.Drawing.Point(219, 150);
            this.txtPLLPhase.Margin = new System.Windows.Forms.Padding(2);
            this.txtPLLPhase.MaxLength = 3;
            this.txtPLLPhase.Name = "txtPLLPhase";
            this.txtPLLPhase.Size = new System.Drawing.Size(42, 19);
            this.txtPLLPhase.TabIndex = 26;
            this.txtPLLPhase.Text = "60";
            this.txtPLLPhase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPLLPhase.TextChanged += new System.EventHandler(this.txtPLLPhase_TextChanged);
            // 
            // lblPLLPhase
            // 
            this.lblPLLPhase.AutoSize = true;
            this.lblPLLPhase.Location = new System.Drawing.Point(180, 152);
            this.lblPLLPhase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPLLPhase.Name = "lblPLLPhase";
            this.lblPLLPhase.Size = new System.Drawing.Size(40, 13);
            this.lblPLLPhase.TabIndex = 25;
            this.lblPLLPhase.Text = "Phase:";
            // 
            // txtPLLPeriod
            // 
            this.txtPLLPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPLLPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLLPeriod.ForeColor = System.Drawing.Color.White;
            this.txtPLLPeriod.Location = new System.Drawing.Point(125, 150);
            this.txtPLLPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.txtPLLPeriod.MaxLength = 3;
            this.txtPLLPeriod.Name = "txtPLLPeriod";
            this.txtPLLPeriod.Size = new System.Drawing.Size(42, 19);
            this.txtPLLPeriod.TabIndex = 24;
            this.txtPLLPeriod.Text = "5";
            this.txtPLLPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPLLPeriod.TextChanged += new System.EventHandler(this.txtPLLPeriod_TextChanged);
            // 
            // lblPLLPeriod
            // 
            this.lblPLLPeriod.AutoSize = true;
            this.lblPLLPeriod.Location = new System.Drawing.Point(86, 152);
            this.lblPLLPeriod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPLLPeriod.Name = "lblPLLPeriod";
            this.lblPLLPeriod.Size = new System.Drawing.Size(40, 13);
            this.lblPLLPeriod.TabIndex = 23;
            this.lblPLLPeriod.Text = "Period:";
            // 
            // txtFakeIndex
            // 
            this.txtFakeIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtFakeIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFakeIndex.ForeColor = System.Drawing.Color.White;
            this.txtFakeIndex.Location = new System.Drawing.Point(125, 127);
            this.txtFakeIndex.Margin = new System.Windows.Forms.Padding(2);
            this.txtFakeIndex.MaxLength = 3;
            this.txtFakeIndex.Name = "txtFakeIndex";
            this.txtFakeIndex.Size = new System.Drawing.Size(68, 19);
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
            this.cbFakeIndex.Location = new System.Drawing.Point(197, 127);
            this.cbFakeIndex.Margin = new System.Windows.Forms.Padding(2);
            this.cbFakeIndex.Name = "cbFakeIndex";
            this.cbFakeIndex.Size = new System.Drawing.Size(64, 21);
            this.cbFakeIndex.TabIndex = 21;
            this.cbFakeIndex.SelectedIndexChanged += new System.EventHandler(this.cbFakeIndex_SelectedIndexChanged);
            // 
            // chkFakeIndex
            // 
            this.chkFakeIndex.AutoSize = true;
            this.chkFakeIndex.Location = new System.Drawing.Point(15, 128);
            this.chkFakeIndex.Margin = new System.Windows.Forms.Padding(2);
            this.chkFakeIndex.Name = "chkFakeIndex";
            this.chkFakeIndex.Size = new System.Drawing.Size(79, 17);
            this.chkFakeIndex.TabIndex = 19;
            this.chkFakeIndex.Text = "Fake Index";
            this.chkFakeIndex.UseVisualStyleBackColor = true;
            this.chkFakeIndex.CheckedChanged += new System.EventHandler(this.chkFakeIndex_CheckedChanged);
            // 
            // chkRaw
            // 
            this.chkRaw.AutoSize = true;
            this.chkRaw.Location = new System.Drawing.Point(124, 172);
            this.chkRaw.Margin = new System.Windows.Forms.Padding(2);
            this.chkRaw.Name = "chkRaw";
            this.chkRaw.Size = new System.Drawing.Size(48, 17);
            this.chkRaw.TabIndex = 29;
            this.chkRaw.Text = "Raw";
            this.chkRaw.UseVisualStyleBackColor = true;
            this.chkRaw.CheckedChanged += new System.EventHandler(this.chkRaw_CheckedChanged);
            // 
            // chkNoClobber
            // 
            this.chkNoClobber.AutoSize = true;
            this.chkNoClobber.Location = new System.Drawing.Point(16, 172);
            this.chkNoClobber.Margin = new System.Windows.Forms.Padding(2);
            this.chkNoClobber.Name = "chkNoClobber";
            this.chkNoClobber.Size = new System.Drawing.Size(79, 17);
            this.chkNoClobber.TabIndex = 28;
            this.chkNoClobber.Text = "No Clobber";
            this.chkNoClobber.UseVisualStyleBackColor = true;
            this.chkNoClobber.CheckedChanged += new System.EventHandler(this.chkNoClobber_CheckedChanged);
            // 
            // txtDriveRetriesRFD
            // 
            this.txtDriveRetriesRFD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDriveRetriesRFD.ForeColor = System.Drawing.Color.White;
            this.txtDriveRetriesRFD.Location = new System.Drawing.Point(197, 105);
            this.txtDriveRetriesRFD.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriveRetriesRFD.MaxLength = 3;
            this.txtDriveRetriesRFD.Name = "txtDriveRetriesRFD";
            this.txtDriveRetriesRFD.Size = new System.Drawing.Size(64, 20);
            this.txtDriveRetriesRFD.TabIndex = 18;
            this.txtDriveRetriesRFD.Text = "3";
            this.txtDriveRetriesRFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDriveRetriesRFD.TextChanged += new System.EventHandler(this.txtDriveRetriesRFD_TextChanged);
            // 
            // chkDriveRetriesRFD
            // 
            this.chkDriveRetriesRFD.AutoSize = true;
            this.chkDriveRetriesRFD.Location = new System.Drawing.Point(15, 106);
            this.chkDriveRetriesRFD.Margin = new System.Windows.Forms.Padding(2);
            this.chkDriveRetriesRFD.Name = "chkDriveRetriesRFD";
            this.chkDriveRetriesRFD.Size = new System.Drawing.Size(59, 17);
            this.chkDriveRetriesRFD.TabIndex = 17;
            this.chkDriveRetriesRFD.Text = "Retries";
            this.chkDriveRetriesRFD.UseVisualStyleBackColor = true;
            this.chkDriveRetriesRFD.CheckedChanged += new System.EventHandler(this.chkDriveRetriesRFD_CheckedChanged);
            // 
            // txtBitrateRFD
            // 
            this.txtBitrateRFD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtBitrateRFD.ForeColor = System.Drawing.Color.White;
            this.txtBitrateRFD.Location = new System.Drawing.Point(197, 82);
            this.txtBitrateRFD.Margin = new System.Windows.Forms.Padding(2);
            this.txtBitrateRFD.MaxLength = 4;
            this.txtBitrateRFD.Name = "txtBitrateRFD";
            this.txtBitrateRFD.Size = new System.Drawing.Size(64, 20);
            this.txtBitrateRFD.TabIndex = 16;
            this.txtBitrateRFD.Text = "250";
            this.txtBitrateRFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBitrateRFD.TextChanged += new System.EventHandler(this.txtBitrateRFD_TextChanged);
            // 
            // chkBitrateRFD
            // 
            this.chkBitrateRFD.AutoSize = true;
            this.chkBitrateRFD.Location = new System.Drawing.Point(15, 83);
            this.chkBitrateRFD.Margin = new System.Windows.Forms.Padding(2);
            this.chkBitrateRFD.Name = "chkBitrateRFD";
            this.chkBitrateRFD.Size = new System.Drawing.Size(116, 17);
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
            this.txtDriveSelectRFD.Location = new System.Drawing.Point(197, 59);
            this.txtDriveSelectRFD.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriveSelectRFD.MaxLength = 1;
            this.txtDriveSelectRFD.Name = "txtDriveSelectRFD";
            this.txtDriveSelectRFD.Size = new System.Drawing.Size(64, 20);
            this.txtDriveSelectRFD.TabIndex = 14;
            this.txtDriveSelectRFD.Text = "A";
            this.txtDriveSelectRFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDriveSelectRFD.TextChanged += new System.EventHandler(this.txtDriveSelectRFD_TextChanged);
            // 
            // chkDriveSelectRFD
            // 
            this.chkDriveSelectRFD.AutoSize = true;
            this.chkDriveSelectRFD.Location = new System.Drawing.Point(15, 60);
            this.chkDriveSelectRFD.Margin = new System.Windows.Forms.Padding(2);
            this.chkDriveSelectRFD.Name = "chkDriveSelectRFD";
            this.chkDriveSelectRFD.Size = new System.Drawing.Size(140, 17);
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
            this.txtDoubleStep.Location = new System.Drawing.Point(197, 14);
            this.txtDoubleStep.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoubleStep.Name = "txtDoubleStep";
            this.txtDoubleStep.Size = new System.Drawing.Size(64, 20);
            this.txtDoubleStep.TabIndex = 6;
            this.txtDoubleStep.Text = "2";
            this.txtDoubleStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDoubleStep.TextChanged += new System.EventHandler(this.txtDoubleStep_TextChanged);
            // 
            // chkDoubleStep
            // 
            this.chkDoubleStep.AutoSize = true;
            this.chkDoubleStep.Location = new System.Drawing.Point(15, 15);
            this.chkDoubleStep.Margin = new System.Windows.Forms.Padding(2);
            this.chkDoubleStep.Name = "chkDoubleStep";
            this.chkDoubleStep.Size = new System.Drawing.Size(109, 17);
            this.chkDoubleStep.TabIndex = 5;
            this.chkDoubleStep.Text = "Double-Step [0-9]";
            this.toolTipRFD.SetToolTip(this.chkDoubleStep, "Host Tools v0.12 or later");
            this.chkDoubleStep.UseVisualStyleBackColor = true;
            this.chkDoubleStep.CheckedChanged += new System.EventHandler(this.chkDoubleStep_CheckedChanged);
            // 
            // chkRevsPerTrack
            // 
            this.chkRevsPerTrack.AutoSize = true;
            this.chkRevsPerTrack.Location = new System.Drawing.Point(15, 37);
            this.chkRevsPerTrack.Margin = new System.Windows.Forms.Padding(2);
            this.chkRevsPerTrack.Name = "chkRevsPerTrack";
            this.chkRevsPerTrack.Size = new System.Drawing.Size(132, 17);
            this.chkRevsPerTrack.TabIndex = 7;
            this.chkRevsPerTrack.Text = "Revs to read per track";
            this.chkRevsPerTrack.UseVisualStyleBackColor = true;
            this.chkRevsPerTrack.CheckedChanged += new System.EventHandler(this.chkRevsPerTrack_CheckedChanged);
            // 
            // txtRevsPerTrack
            // 
            this.txtRevsPerTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtRevsPerTrack.ForeColor = System.Drawing.Color.White;
            this.txtRevsPerTrack.Location = new System.Drawing.Point(197, 37);
            this.txtRevsPerTrack.Margin = new System.Windows.Forms.Padding(2);
            this.txtRevsPerTrack.Name = "txtRevsPerTrack";
            this.txtRevsPerTrack.Size = new System.Drawing.Size(64, 20);
            this.txtRevsPerTrack.TabIndex = 8;
            this.txtRevsPerTrack.Text = "3";
            this.txtRevsPerTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRevsPerTrack.TextChanged += new System.EventHandler(this.txtRevsPerTrack_TextChanged);
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(166, 518);
            this.lblHostTools.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(275, 19);
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
            // chkRevTrkData
            // 
            this.chkRevTrkData.AutoSize = true;
            this.chkRevTrkData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRevTrkData.Location = new System.Drawing.Point(16, 89);
            this.chkRevTrkData.Margin = new System.Windows.Forms.Padding(2);
            this.chkRevTrkData.Name = "chkRevTrkData";
            this.chkRevTrkData.Size = new System.Drawing.Size(103, 17);
            this.chkRevTrkData.TabIndex = 41;
            this.chkRevTrkData.Text = "Rev Track Data";
            this.chkRevTrkData.UseVisualStyleBackColor = true;
            this.chkRevTrkData.CheckedChanged += new System.EventHandler(this.chkRevTrkData_CheckedChanged);
            // 
            // ReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(608, 553);
            this.Controls.Add(this.lblHostTools);
            this.Controls.Add(this.gbReadFromDisk);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.gbHighLow.ResumeLayout(false);
            this.gbHighLow.PerformLayout();
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
        private System.Windows.Forms.TextBox txtPLLPhase;
        private System.Windows.Forms.Label lblPLLPhase;
        private System.Windows.Forms.TextBox txtPLLPeriod;
        private System.Windows.Forms.Label lblPLLPeriod;
        private System.Windows.Forms.CheckBox chkPLLSpec;
        private System.Windows.Forms.GroupBox gbHighLow;
        private System.Windows.Forms.CheckBox chkPin2High;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.CheckBox chkRevTrkData;
    }
}