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
            this.gbFilename = new System.Windows.Forms.GroupBox();
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
            this.chkLegacySS = new System.Windows.Forms.CheckBox();
            this.chkHeadsSet = new System.Windows.Forms.CheckBox();
            this.txtHeadsSet = new System.Windows.Forms.TextBox();
            this.chkCylSet = new System.Windows.Forms.CheckBox();
            this.txtCylSet = new System.Windows.Forms.TextBox();
            this.txtDriveRpmRFD = new System.Windows.Forms.TextBox();
            this.chkDriveRpmRFD = new System.Windows.Forms.CheckBox();
            this.gbFlippy = new System.Windows.Forms.GroupBox();
            this.chkFlippyOffset = new System.Windows.Forms.CheckBox();
            this.rbFlippyPanasonic = new System.Windows.Forms.RadioButton();
            this.rbFlippyTeac = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDriveRateRFD = new System.Windows.Forms.TextBox();
            this.chkDriveRateRFD = new System.Windows.Forms.CheckBox();
            this.txtDriveSelectRFD = new System.Windows.Forms.TextBox();
            this.chkDriveSelectRFD = new System.Windows.Forms.CheckBox();
            this.txtDoubleStep = new System.Windows.Forms.TextBox();
            this.chkDoubleStep = new System.Windows.Forms.CheckBox();
            this.chkRevsPerTrack = new System.Windows.Forms.CheckBox();
            this.txtRevsPerTrack = new System.Windows.Forms.TextBox();
            this.toolTipRFD = new System.Windows.Forms.ToolTip(this.components);
            this.lblHostTools = new System.Windows.Forms.Label();
            this.gbReadFromDisk.SuspendLayout();
            this.gbFilename.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbFlippy.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReadFromDisk
            // 
            this.gbReadFromDisk.Controls.Add(this.gbFilename);
            this.gbReadFromDisk.Controls.Add(this.btnBack);
            this.gbReadFromDisk.Controls.Add(this.txtRFDCommandLine);
            this.gbReadFromDisk.Controls.Add(this.lblCommandLine);
            this.gbReadFromDisk.Controls.Add(this.btnRFDSelectFile);
            this.gbReadFromDisk.Controls.Add(this.btnLaunch);
            this.gbReadFromDisk.Controls.Add(this.btnRFDSelectFolder);
            this.gbReadFromDisk.Controls.Add(this.groupBox1);
            this.gbReadFromDisk.Location = new System.Drawing.Point(0, -4);
            this.gbReadFromDisk.Name = "gbReadFromDisk";
            this.gbReadFromDisk.Size = new System.Drawing.Size(780, 425);
            this.gbReadFromDisk.TabIndex = 0;
            this.gbReadFromDisk.TabStop = false;
            // 
            // gbFilename
            // 
            this.gbFilename.Controls.Add(this.chkAutoInc);
            this.gbFilename.Controls.Add(this.btnDec);
            this.gbFilename.Controls.Add(this.btnInc);
            this.gbFilename.Controls.Add(this.tbSuffix);
            this.gbFilename.Controls.Add(this.lblSuffix);
            this.gbFilename.Controls.Add(this.tbFilename);
            this.gbFilename.Controls.Add(this.lblFilename);
            this.gbFilename.Location = new System.Drawing.Point(12, 209);
            this.gbFilename.Name = "gbFilename";
            this.gbFilename.Size = new System.Drawing.Size(757, 73);
            this.gbFilename.TabIndex = 4;
            this.gbFilename.TabStop = false;
            // 
            // chkAutoInc
            // 
            this.chkAutoInc.AutoSize = true;
            this.chkAutoInc.Location = new System.Drawing.Point(18, 44);
            this.chkAutoInc.Name = "chkAutoInc";
            this.chkAutoInc.Size = new System.Drawing.Size(176, 21);
            this.chkAutoInc.TabIndex = 35;
            this.chkAutoInc.Text = "Increment after Launch";
            this.chkAutoInc.UseVisualStyleBackColor = true;
            // 
            // btnDec
            // 
            this.btnDec.BackColor = System.Drawing.Color.Maroon;
            this.btnDec.Location = new System.Drawing.Point(677, 16);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(58, 29);
            this.btnDec.TabIndex = 34;
            this.btnDec.Text = "<<<<";
            this.btnDec.UseVisualStyleBackColor = false;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnInc
            // 
            this.btnInc.BackColor = System.Drawing.Color.Maroon;
            this.btnInc.Location = new System.Drawing.Point(582, 16);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(58, 29);
            this.btnInc.TabIndex = 33;
            this.btnInc.Text = ">>>>";
            this.btnInc.UseVisualStyleBackColor = false;
            this.btnInc.Click += new System.EventHandler(this.btnInc_Click);
            // 
            // tbSuffix
            // 
            this.tbSuffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbSuffix.ForeColor = System.Drawing.Color.White;
            this.tbSuffix.Location = new System.Drawing.Point(486, 18);
            this.tbSuffix.MaxLength = 3;
            this.tbSuffix.Name = "tbSuffix";
            this.tbSuffix.Size = new System.Drawing.Size(58, 22);
            this.tbSuffix.TabIndex = 32;
            this.tbSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSuffix.TextChanged += new System.EventHandler(this.tbSuffix_TextChanged);
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(396, 21);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(77, 17);
            this.lblSuffix.TabIndex = 31;
            this.lblSuffix.Text = "Nbr. Suffix:";
            // 
            // tbFilename
            // 
            this.tbFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbFilename.ForeColor = System.Drawing.Color.White;
            this.tbFilename.Location = new System.Drawing.Point(161, 18);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(197, 22);
            this.tbFilename.TabIndex = 30;
            this.tbFilename.Text = "mydisk.scp";
            this.tbFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFilename.TextChanged += new System.EventHandler(this.tbFilename_TextChanged);
            // 
            // lblFilename
            // 
            this.lblFilename.Location = new System.Drawing.Point(18, 18);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(100, 23);
            this.lblFilename.TabIndex = 29;
            this.lblFilename.Text = "Filename:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(596, 377);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRFDCommandLine
            // 
            this.txtRFDCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtRFDCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtRFDCommandLine.Location = new System.Drawing.Point(12, 311);
            this.txtRFDCommandLine.Multiline = true;
            this.txtRFDCommandLine.Name = "txtRFDCommandLine";
            this.txtRFDCommandLine.Size = new System.Drawing.Size(757, 54);
            this.txtRFDCommandLine.TabIndex = 37;
            // 
            // lblCommandLine
            // 
            this.lblCommandLine.AutoSize = true;
            this.lblCommandLine.Location = new System.Drawing.Point(339, 288);
            this.lblCommandLine.Name = "lblCommandLine";
            this.lblCommandLine.Size = new System.Drawing.Size(102, 17);
            this.lblCommandLine.TabIndex = 36;
            this.lblCommandLine.Text = "Command Line";
            // 
            // btnRFDSelectFile
            // 
            this.btnRFDSelectFile.BackColor = System.Drawing.Color.Maroon;
            this.btnRFDSelectFile.Location = new System.Drawing.Point(250, 377);
            this.btnRFDSelectFile.Name = "btnRFDSelectFile";
            this.btnRFDSelectFile.Size = new System.Drawing.Size(108, 29);
            this.btnRFDSelectFile.TabIndex = 39;
            this.btnRFDSelectFile.Text = "Select File";
            this.btnRFDSelectFile.UseVisualStyleBackColor = false;
            this.btnRFDSelectFile.Click += new System.EventHandler(this.btnRFDSelectFile_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(423, 377);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 40;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnRFDSelectFolder
            // 
            this.btnRFDSelectFolder.BackColor = System.Drawing.Color.Maroon;
            this.btnRFDSelectFolder.Location = new System.Drawing.Point(77, 377);
            this.btnRFDSelectFolder.Name = "btnRFDSelectFolder";
            this.btnRFDSelectFolder.Size = new System.Drawing.Size(108, 29);
            this.btnRFDSelectFolder.TabIndex = 38;
            this.btnRFDSelectFolder.Text = "Select Folder";
            this.btnRFDSelectFolder.UseVisualStyleBackColor = false;
            this.btnRFDSelectFolder.Click += new System.EventHandler(this.btnRFDSelectFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkLegacySS);
            this.groupBox3.Controls.Add(this.chkHeadsSet);
            this.groupBox3.Controls.Add(this.txtHeadsSet);
            this.groupBox3.Controls.Add(this.chkCylSet);
            this.groupBox3.Controls.Add(this.txtCylSet);
            this.groupBox3.Controls.Add(this.txtDriveRpmRFD);
            this.groupBox3.Controls.Add(this.chkDriveRpmRFD);
            this.groupBox3.Controls.Add(this.gbFlippy);
            this.groupBox3.Location = new System.Drawing.Point(384, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 164);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // chkLegacySS
            // 
            this.chkLegacySS.AutoSize = true;
            this.chkLegacySS.Location = new System.Drawing.Point(253, 81);
            this.chkLegacySS.Name = "chkLegacySS";
            this.chkLegacySS.Size = new System.Drawing.Size(98, 21);
            this.chkLegacySS.TabIndex = 25;
            this.chkLegacySS.Text = "SS Legacy";
            this.chkLegacySS.UseVisualStyleBackColor = true;
            this.chkLegacySS.CheckedChanged += new System.EventHandler(this.chkLegacySS_CheckedChanged);
            // 
            // chkHeadsSet
            // 
            this.chkHeadsSet.AutoSize = true;
            this.chkHeadsSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHeadsSet.Location = new System.Drawing.Point(21, 81);
            this.chkHeadsSet.Name = "chkHeadsSet";
            this.chkHeadsSet.Size = new System.Drawing.Size(94, 21);
            this.chkHeadsSet.TabIndex = 21;
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
            this.txtHeadsSet.Location = new System.Drawing.Point(141, 79);
            this.txtHeadsSet.Name = "txtHeadsSet";
            this.txtHeadsSet.Size = new System.Drawing.Size(99, 22);
            this.txtHeadsSet.TabIndex = 22;
            this.txtHeadsSet.Text = "0-1";
            this.txtHeadsSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipRFD.SetToolTip(this.txtHeadsSet, "Host Tools v0.22 or later");
            this.txtHeadsSet.TextChanged += new System.EventHandler(this.txtHeadsSet_TextChanged);
            // 
            // chkCylSet
            // 
            this.chkCylSet.AutoSize = true;
            this.chkCylSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCylSet.Location = new System.Drawing.Point(21, 53);
            this.chkCylSet.Name = "chkCylSet";
            this.chkCylSet.Size = new System.Drawing.Size(111, 21);
            this.chkCylSet.TabIndex = 19;
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
            this.txtCylSet.Location = new System.Drawing.Point(141, 51);
            this.txtCylSet.Name = "txtCylSet";
            this.txtCylSet.Size = new System.Drawing.Size(210, 22);
            this.txtCylSet.TabIndex = 20;
            this.txtCylSet.Text = "0-34,35-79";
            this.txtCylSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipRFD.SetToolTip(this.txtCylSet, "Host Tools v0.22 or later");
            this.txtCylSet.TextChanged += new System.EventHandler(this.txtCylSet_TextChanged);
            // 
            // txtDriveRpmRFD
            // 
            this.txtDriveRpmRFD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDriveRpmRFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriveRpmRFD.ForeColor = System.Drawing.Color.White;
            this.txtDriveRpmRFD.Location = new System.Drawing.Point(141, 23);
            this.txtDriveRpmRFD.MaxLength = 3;
            this.txtDriveRpmRFD.Name = "txtDriveRpmRFD";
            this.txtDriveRpmRFD.Size = new System.Drawing.Size(210, 22);
            this.txtDriveRpmRFD.TabIndex = 18;
            this.txtDriveRpmRFD.Text = "300";
            this.txtDriveRpmRFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDriveRpmRFD.TextChanged += new System.EventHandler(this.txtDriveRpmRFD_TextChanged);
            // 
            // chkDriveRpmRFD
            // 
            this.chkDriveRpmRFD.AutoSize = true;
            this.chkDriveRpmRFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDriveRpmRFD.Location = new System.Drawing.Point(21, 25);
            this.chkDriveRpmRFD.Name = "chkDriveRpmRFD";
            this.chkDriveRpmRFD.Size = new System.Drawing.Size(60, 21);
            this.chkDriveRpmRFD.TabIndex = 17;
            this.chkDriveRpmRFD.Text = "RPM";
            this.toolTipRFD.SetToolTip(this.chkDriveRpmRFD, "Host Tools v0.18 or later");
            this.chkDriveRpmRFD.UseVisualStyleBackColor = true;
            this.chkDriveRpmRFD.CheckedChanged += new System.EventHandler(this.chkDriveRpmRFD_CheckedChanged);
            // 
            // gbFlippy
            // 
            this.gbFlippy.Controls.Add(this.chkFlippyOffset);
            this.gbFlippy.Controls.Add(this.rbFlippyPanasonic);
            this.gbFlippy.Controls.Add(this.rbFlippyTeac);
            this.gbFlippy.Location = new System.Drawing.Point(12, 103);
            this.gbFlippy.Name = "gbFlippy";
            this.gbFlippy.Size = new System.Drawing.Size(339, 48);
            this.gbFlippy.TabIndex = 26;
            this.gbFlippy.TabStop = false;
            this.toolTipRFD.SetToolTip(this.gbFlippy, "C64 flippy\r\nc=0-39:h=0,1:step=2:h1.off=-8");
            // 
            // chkFlippyOffset
            // 
            this.chkFlippyOffset.AutoSize = true;
            this.chkFlippyOffset.Location = new System.Drawing.Point(11, 18);
            this.chkFlippyOffset.Name = "chkFlippyOffset";
            this.chkFlippyOffset.Size = new System.Drawing.Size(106, 21);
            this.chkFlippyOffset.TabIndex = 26;
            this.chkFlippyOffset.Text = "Flippy offset";
            this.toolTipRFD.SetToolTip(this.chkFlippyOffset, "Host Tools v0.22 or later");
            this.chkFlippyOffset.UseVisualStyleBackColor = true;
            this.chkFlippyOffset.CheckedChanged += new System.EventHandler(this.chkFlippyOffset_CheckedChanged);
            // 
            // rbFlippyPanasonic
            // 
            this.rbFlippyPanasonic.AutoSize = true;
            this.rbFlippyPanasonic.Location = new System.Drawing.Point(133, 18);
            this.rbFlippyPanasonic.Name = "rbFlippyPanasonic";
            this.rbFlippyPanasonic.Size = new System.Drawing.Size(95, 21);
            this.rbFlippyPanasonic.TabIndex = 27;
            this.rbFlippyPanasonic.Text = "Panasonic";
            this.toolTipRFD.SetToolTip(this.rbFlippyPanasonic, "Host Tools v0.22 or later");
            this.rbFlippyPanasonic.UseVisualStyleBackColor = true;
            this.rbFlippyPanasonic.CheckedChanged += new System.EventHandler(this.rbFlippyPanasonic_CheckedChanged);
            // 
            // rbFlippyTeac
            // 
            this.rbFlippyTeac.AutoSize = true;
            this.rbFlippyTeac.Location = new System.Drawing.Point(258, 18);
            this.rbFlippyTeac.Name = "rbFlippyTeac";
            this.rbFlippyTeac.Size = new System.Drawing.Size(61, 21);
            this.rbFlippyTeac.TabIndex = 28;
            this.rbFlippyTeac.Text = "Teac";
            this.toolTipRFD.SetToolTip(this.rbFlippyTeac, "Host Tools v0.22 or later");
            this.rbFlippyTeac.UseVisualStyleBackColor = true;
            this.rbFlippyTeac.CheckedChanged += new System.EventHandler(this.rbFlippyTeac_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDriveRateRFD);
            this.groupBox2.Controls.Add(this.chkDriveRateRFD);
            this.groupBox2.Controls.Add(this.txtDriveSelectRFD);
            this.groupBox2.Controls.Add(this.chkDriveSelectRFD);
            this.groupBox2.Controls.Add(this.txtDoubleStep);
            this.groupBox2.Controls.Add(this.chkDoubleStep);
            this.groupBox2.Controls.Add(this.chkRevsPerTrack);
            this.groupBox2.Controls.Add(this.txtRevsPerTrack);
            this.groupBox2.Location = new System.Drawing.Point(11, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtDriveRateRFD
            // 
            this.txtDriveRateRFD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDriveRateRFD.ForeColor = System.Drawing.Color.White;
            this.txtDriveRateRFD.Location = new System.Drawing.Point(263, 110);
            this.txtDriveRateRFD.MaxLength = 3;
            this.txtDriveRateRFD.Name = "txtDriveRateRFD";
            this.txtDriveRateRFD.Size = new System.Drawing.Size(84, 22);
            this.txtDriveRateRFD.TabIndex = 16;
            this.txtDriveRateRFD.Text = "250";
            this.txtDriveRateRFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDriveRateRFD.TextChanged += new System.EventHandler(this.txtDriveRateRFD_TextChanged);
            // 
            // chkDriveRateRFD
            // 
            this.chkDriveRateRFD.AutoSize = true;
            this.chkDriveRateRFD.Location = new System.Drawing.Point(18, 112);
            this.chkDriveRateRFD.Name = "chkDriveRateRFD";
            this.chkDriveRateRFD.Size = new System.Drawing.Size(107, 21);
            this.chkDriveRateRFD.TabIndex = 15;
            this.chkDriveRateRFD.Text = "Rate (kbit/s)";
            this.toolTipRFD.SetToolTip(this.chkDriveRateRFD, "Host Tools v0.18 or later");
            this.chkDriveRateRFD.UseVisualStyleBackColor = true;
            this.chkDriveRateRFD.CheckedChanged += new System.EventHandler(this.chkDriveRateRFD_CheckedChanged);
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
            this.chkDriveSelectRFD.Location = new System.Drawing.Point(18, 83);
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
            this.txtDoubleStep.Location = new System.Drawing.Point(263, 23);
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
            this.chkDoubleStep.Location = new System.Drawing.Point(18, 27);
            this.chkDoubleStep.Name = "chkDoubleStep";
            this.chkDoubleStep.Size = new System.Drawing.Size(190, 21);
            this.chkDoubleStep.TabIndex = 5;
            this.chkDoubleStep.Text = "Double-Step (steps [0-9])";
            this.toolTipRFD.SetToolTip(this.chkDoubleStep, "Host Tools v0.12 or later");
            this.chkDoubleStep.UseVisualStyleBackColor = true;
            this.chkDoubleStep.CheckedChanged += new System.EventHandler(this.chkDoubleStep_CheckedChanged);
            // 
            // chkRevsPerTrack
            // 
            this.chkRevsPerTrack.AutoSize = true;
            this.chkRevsPerTrack.Location = new System.Drawing.Point(18, 54);
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
            this.txtRevsPerTrack.Location = new System.Drawing.Point(263, 52);
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
            this.lblHostTools.Location = new System.Drawing.Point(207, 426);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(367, 23);
            this.lblHostTools.TabIndex = 5;
            this.lblHostTools.Text = "for Host Tools v0.24";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(781, 456);
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
            this.gbFlippy.ResumeLayout(false);
            this.gbFlippy.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtDriveRpmRFD;
        private System.Windows.Forms.CheckBox chkDriveRpmRFD;
        private System.Windows.Forms.GroupBox gbFlippy;
        private System.Windows.Forms.CheckBox chkFlippyOffset;
        private System.Windows.Forms.RadioButton rbFlippyPanasonic;
        private System.Windows.Forms.RadioButton rbFlippyTeac;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDriveRateRFD;
        private System.Windows.Forms.CheckBox chkDriveRateRFD;
        private System.Windows.Forms.TextBox txtDriveSelectRFD;
        private System.Windows.Forms.CheckBox chkDriveSelectRFD;
        private System.Windows.Forms.TextBox txtDoubleStep;
        private System.Windows.Forms.CheckBox chkDoubleStep;
        private System.Windows.Forms.CheckBox chkRevsPerTrack;
        private System.Windows.Forms.TextBox txtRevsPerTrack;
        private System.Windows.Forms.Label lblHostTools;
    }
}