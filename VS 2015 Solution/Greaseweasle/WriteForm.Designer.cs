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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnWTDSelectFile = new System.Windows.Forms.Button();
            this.txtWTDCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.gbWriteToDisk = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbWriteSingleSided = new System.Windows.Forms.RadioButton();
            this.rbWriteDoubleSided = new System.Windows.Forms.RadioButton();
            this.chkHeadsSet = new System.Windows.Forms.CheckBox();
            this.txtHeadsSet = new System.Windows.Forms.TextBox();
            this.chkCylSet = new System.Windows.Forms.CheckBox();
            this.txtCylSet = new System.Windows.Forms.TextBox();
            this.gbFlippy = new System.Windows.Forms.GroupBox();
            this.chkFlippyOffset = new System.Windows.Forms.CheckBox();
            this.rbFlippyPanasonic = new System.Windows.Forms.RadioButton();
            this.rbFlippyTeac = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkEraseEmpty = new System.Windows.Forms.CheckBox();
            this.chkWTDAdjustSpeed = new System.Windows.Forms.CheckBox();
            this.txtDriveSelectWTD = new System.Windows.Forms.TextBox();
            this.chkDriveSelectWTD = new System.Windows.Forms.CheckBox();
            this.txtDoubleStep = new System.Windows.Forms.TextBox();
            this.chkDoubleStep = new System.Windows.Forms.CheckBox();
            this.chkWriteFirstCyl = new System.Windows.Forms.CheckBox();
            this.txtWriteFirstCyl = new System.Windows.Forms.TextBox();
            this.chkWriteLastCyl = new System.Windows.Forms.CheckBox();
            this.txtWriteLastCyl = new System.Windows.Forms.TextBox();
            this.toolTipWTD = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPrecomp = new System.Windows.Forms.TextBox();
            this.chkPrecomp = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.gbWriteToDisk.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbFlippy.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnLaunch);
            this.groupBox1.Controls.Add(this.btnWTDSelectFile);
            this.groupBox1.Controls.Add(this.txtWTDCommandLine);
            this.groupBox1.Controls.Add(this.lblStaticCL);
            this.groupBox1.Controls.Add(this.gbWriteToDisk);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(460, 335);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(334, 335);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 28;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnWTDSelectFile
            // 
            this.btnWTDSelectFile.Location = new System.Drawing.Point(208, 335);
            this.btnWTDSelectFile.Name = "btnWTDSelectFile";
            this.btnWTDSelectFile.Size = new System.Drawing.Size(108, 29);
            this.btnWTDSelectFile.TabIndex = 27;
            this.btnWTDSelectFile.Text = "Select File";
            this.toolTipWTD.SetToolTip(this.btnWTDSelectFile, "HFE & IPF require Host Tools v0.13 or later");
            this.btnWTDSelectFile.UseVisualStyleBackColor = true;
            this.btnWTDSelectFile.Click += new System.EventHandler(this.btnWTDSelectFile_Click);
            // 
            // txtWTDCommandLine
            // 
            this.txtWTDCommandLine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtWTDCommandLine.Location = new System.Drawing.Point(19, 270);
            this.txtWTDCommandLine.Multiline = true;
            this.txtWTDCommandLine.Name = "txtWTDCommandLine";
            this.txtWTDCommandLine.Size = new System.Drawing.Size(745, 56);
            this.txtWTDCommandLine.TabIndex = 26;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(337, 250);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 25;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbWriteToDisk
            // 
            this.gbWriteToDisk.Controls.Add(this.groupBox3);
            this.gbWriteToDisk.Controls.Add(this.groupBox2);
            this.gbWriteToDisk.Location = new System.Drawing.Point(11, 12);
            this.gbWriteToDisk.Name = "gbWriteToDisk";
            this.gbWriteToDisk.Size = new System.Drawing.Size(753, 229);
            this.gbWriteToDisk.TabIndex = 2;
            this.gbWriteToDisk.TabStop = false;
            this.gbWriteToDisk.Enter += new System.EventHandler(this.gbWriteToDisk_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.chkHeadsSet);
            this.groupBox3.Controls.Add(this.txtHeadsSet);
            this.groupBox3.Controls.Add(this.chkCylSet);
            this.groupBox3.Controls.Add(this.txtCylSet);
            this.groupBox3.Controls.Add(this.gbFlippy);
            this.groupBox3.Location = new System.Drawing.Point(380, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 207);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbWriteSingleSided);
            this.groupBox4.Controls.Add(this.rbWriteDoubleSided);
            this.groupBox4.Location = new System.Drawing.Point(12, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 49);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            // 
            // rbWriteSingleSided
            // 
            this.rbWriteSingleSided.AutoSize = true;
            this.rbWriteSingleSided.Location = new System.Drawing.Point(9, 19);
            this.rbWriteSingleSided.Name = "rbWriteSingleSided";
            this.rbWriteSingleSided.Size = new System.Drawing.Size(108, 21);
            this.rbWriteSingleSided.TabIndex = 20;
            this.rbWriteSingleSided.Text = "Single Sided";
            this.toolTipWTD.SetToolTip(this.rbWriteSingleSided, "Host Tools v0.21 or earlier");
            this.rbWriteSingleSided.UseVisualStyleBackColor = true;
            this.rbWriteSingleSided.CheckedChanged += new System.EventHandler(this.rbWriteSingleSided_CheckedChanged);
            // 
            // rbWriteDoubleSided
            // 
            this.rbWriteDoubleSided.AutoSize = true;
            this.rbWriteDoubleSided.Location = new System.Drawing.Point(129, 19);
            this.rbWriteDoubleSided.Name = "rbWriteDoubleSided";
            this.rbWriteDoubleSided.Size = new System.Drawing.Size(114, 21);
            this.rbWriteDoubleSided.TabIndex = 21;
            this.rbWriteDoubleSided.Text = "Double Sided";
            this.toolTipWTD.SetToolTip(this.rbWriteDoubleSided, "Host Tools v0.21 or earlier");
            this.rbWriteDoubleSided.UseVisualStyleBackColor = true;
            this.rbWriteDoubleSided.CheckedChanged += new System.EventHandler(this.rbWriteDoubleSided_CheckedChanged);
            // 
            // chkHeadsSet
            // 
            this.chkHeadsSet.AutoSize = true;
            this.chkHeadsSet.Location = new System.Drawing.Point(21, 49);
            this.chkHeadsSet.Name = "chkHeadsSet";
            this.chkHeadsSet.Size = new System.Drawing.Size(94, 21);
            this.chkHeadsSet.TabIndex = 18;
            this.chkHeadsSet.Text = "Head sets";
            this.toolTipWTD.SetToolTip(this.chkHeadsSet, "Host Tools v0.22 or later");
            this.chkHeadsSet.UseVisualStyleBackColor = true;
            this.chkHeadsSet.CheckedChanged += new System.EventHandler(this.chkHeadsSet_CheckedChanged);
            // 
            // txtHeadsSet
            // 
            this.txtHeadsSet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtHeadsSet.Location = new System.Drawing.Point(141, 47);
            this.txtHeadsSet.Name = "txtHeadsSet";
            this.txtHeadsSet.Size = new System.Drawing.Size(210, 22);
            this.txtHeadsSet.TabIndex = 19;
            this.txtHeadsSet.Text = "0,1";
            this.txtHeadsSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipWTD.SetToolTip(this.txtHeadsSet, "Host Tools v0.22 or later");
            this.txtHeadsSet.TextChanged += new System.EventHandler(this.txtHeadsSet_TextChanged);
            // 
            // chkCylSet
            // 
            this.chkCylSet.AutoSize = true;
            this.chkCylSet.Location = new System.Drawing.Point(21, 21);
            this.chkCylSet.Name = "chkCylSet";
            this.chkCylSet.Size = new System.Drawing.Size(111, 21);
            this.chkCylSet.TabIndex = 16;
            this.chkCylSet.Text = "Cylinder sets";
            this.toolTipWTD.SetToolTip(this.chkCylSet, "Host Tools v0.22 or later");
            this.chkCylSet.UseVisualStyleBackColor = true;
            this.chkCylSet.CheckedChanged += new System.EventHandler(this.chkCylSet_CheckedChanged);
            // 
            // txtCylSet
            // 
            this.txtCylSet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCylSet.Location = new System.Drawing.Point(141, 19);
            this.txtCylSet.Name = "txtCylSet";
            this.txtCylSet.Size = new System.Drawing.Size(210, 22);
            this.txtCylSet.TabIndex = 17;
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
            this.gbFlippy.Location = new System.Drawing.Point(12, 120);
            this.gbFlippy.Name = "gbFlippy";
            this.gbFlippy.Size = new System.Drawing.Size(339, 48);
            this.gbFlippy.TabIndex = 39;
            this.gbFlippy.TabStop = false;
            this.toolTipWTD.SetToolTip(this.gbFlippy, "C64 flippy\r\nc=0-39:h=0,1:step=2:h1.off=-8\r\n");
            // 
            // chkFlippyOffset
            // 
            this.chkFlippyOffset.AutoSize = true;
            this.chkFlippyOffset.Location = new System.Drawing.Point(13, 18);
            this.chkFlippyOffset.Name = "chkFlippyOffset";
            this.chkFlippyOffset.Size = new System.Drawing.Size(106, 21);
            this.chkFlippyOffset.TabIndex = 22;
            this.chkFlippyOffset.Text = "Flippy offset";
            this.toolTipWTD.SetToolTip(this.chkFlippyOffset, "Host Tools v0.22 or later");
            this.chkFlippyOffset.UseVisualStyleBackColor = true;
            this.chkFlippyOffset.CheckedChanged += new System.EventHandler(this.chkFlippyOffset_CheckedChanged);
            // 
            // rbFlippyPanasonic
            // 
            this.rbFlippyPanasonic.AutoSize = true;
            this.rbFlippyPanasonic.Location = new System.Drawing.Point(133, 18);
            this.rbFlippyPanasonic.Name = "rbFlippyPanasonic";
            this.rbFlippyPanasonic.Size = new System.Drawing.Size(95, 21);
            this.rbFlippyPanasonic.TabIndex = 23;
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
            this.rbFlippyTeac.TabIndex = 24;
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
            this.groupBox2.Controls.Add(this.chkWTDAdjustSpeed);
            this.groupBox2.Controls.Add(this.txtDriveSelectWTD);
            this.groupBox2.Controls.Add(this.chkDriveSelectWTD);
            this.groupBox2.Controls.Add(this.txtDoubleStep);
            this.groupBox2.Controls.Add(this.chkDoubleStep);
            this.groupBox2.Controls.Add(this.chkWriteFirstCyl);
            this.groupBox2.Controls.Add(this.txtWriteFirstCyl);
            this.groupBox2.Controls.Add(this.chkWriteLastCyl);
            this.groupBox2.Controls.Add(this.txtWriteLastCyl);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 207);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // chkEraseEmpty
            // 
            this.chkEraseEmpty.AutoSize = true;
            this.chkEraseEmpty.Location = new System.Drawing.Point(237, 21);
            this.chkEraseEmpty.Name = "chkEraseEmpty";
            this.chkEraseEmpty.Size = new System.Drawing.Size(110, 21);
            this.chkEraseEmpty.TabIndex = 5;
            this.chkEraseEmpty.Text = "Erase Empty";
            this.toolTipWTD.SetToolTip(this.chkEraseEmpty, "Host Tools v0.20 or later");
            this.chkEraseEmpty.UseVisualStyleBackColor = true;
            this.chkEraseEmpty.CheckedChanged += new System.EventHandler(this.chkEraseEmpty_CheckedChanged);
            // 
            // chkWTDAdjustSpeed
            // 
            this.chkWTDAdjustSpeed.AutoSize = true;
            this.chkWTDAdjustSpeed.Location = new System.Drawing.Point(19, 21);
            this.chkWTDAdjustSpeed.Name = "chkWTDAdjustSpeed";
            this.chkWTDAdjustSpeed.Size = new System.Drawing.Size(114, 21);
            this.chkWTDAdjustSpeed.TabIndex = 4;
            this.chkWTDAdjustSpeed.Text = "Adjust Speed";
            this.toolTipWTD.SetToolTip(this.chkWTDAdjustSpeed, "Host Tools v0.05 through v0.12");
            this.chkWTDAdjustSpeed.UseVisualStyleBackColor = true;
            this.chkWTDAdjustSpeed.CheckedChanged += new System.EventHandler(this.chkWTDAdjustSpeed_CheckedChanged);
            // 
            // txtDriveSelectWTD
            // 
            this.txtDriveSelectWTD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDriveSelectWTD.Location = new System.Drawing.Point(214, 141);
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
            this.chkDriveSelectWTD.Location = new System.Drawing.Point(18, 143);
            this.chkDriveSelectWTD.Name = "chkDriveSelectWTD";
            this.chkDriveSelectWTD.Size = new System.Drawing.Size(162, 21);
            this.chkDriveSelectWTD.TabIndex = 12;
            this.chkDriveSelectWTD.Text = "Drive Select (AB012)";
            this.chkDriveSelectWTD.UseVisualStyleBackColor = true;
            this.chkDriveSelectWTD.CheckedChanged += new System.EventHandler(this.chkDriveSelectWTD_CheckedChanged);
            // 
            // txtDoubleStep
            // 
            this.txtDoubleStep.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            // chkWriteFirstCyl
            // 
            this.chkWriteFirstCyl.AutoSize = true;
            this.chkWriteFirstCyl.Location = new System.Drawing.Point(18, 82);
            this.chkWriteFirstCyl.Name = "chkWriteFirstCyl";
            this.chkWriteFirstCyl.Size = new System.Drawing.Size(159, 21);
            this.chkWriteFirstCyl.TabIndex = 8;
            this.chkWriteFirstCyl.Text = "First cylinder to write";
            this.toolTipWTD.SetToolTip(this.chkWriteFirstCyl, "Host Tools v0.21 or earlier");
            this.chkWriteFirstCyl.UseVisualStyleBackColor = true;
            this.chkWriteFirstCyl.CheckedChanged += new System.EventHandler(this.chkWriteFirstCyl_CheckedChanged);
            // 
            // txtWriteFirstCyl
            // 
            this.txtWriteFirstCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtWriteFirstCyl.Location = new System.Drawing.Point(214, 81);
            this.txtWriteFirstCyl.Name = "txtWriteFirstCyl";
            this.txtWriteFirstCyl.Size = new System.Drawing.Size(133, 22);
            this.txtWriteFirstCyl.TabIndex = 9;
            this.txtWriteFirstCyl.Text = "0";
            this.txtWriteFirstCyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipWTD.SetToolTip(this.txtWriteFirstCyl, "Host Tools v0.21 or earlier");
            this.txtWriteFirstCyl.TextChanged += new System.EventHandler(this.txtWriteFirstCyl_TextChanged);
            // 
            // chkWriteLastCyl
            // 
            this.chkWriteLastCyl.AutoSize = true;
            this.chkWriteLastCyl.Location = new System.Drawing.Point(18, 112);
            this.chkWriteLastCyl.Name = "chkWriteLastCyl";
            this.chkWriteLastCyl.Size = new System.Drawing.Size(159, 21);
            this.chkWriteLastCyl.TabIndex = 10;
            this.chkWriteLastCyl.Text = "Last cylinder to write";
            this.toolTipWTD.SetToolTip(this.chkWriteLastCyl, "Host Tools v0.21 or earlier");
            this.chkWriteLastCyl.UseVisualStyleBackColor = true;
            this.chkWriteLastCyl.CheckedChanged += new System.EventHandler(this.chkWriteLastCyl_CheckedChanged);
            // 
            // txtWriteLastCyl
            // 
            this.txtWriteLastCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtWriteLastCyl.Location = new System.Drawing.Point(214, 111);
            this.txtWriteLastCyl.Name = "txtWriteLastCyl";
            this.txtWriteLastCyl.Size = new System.Drawing.Size(133, 22);
            this.txtWriteLastCyl.TabIndex = 11;
            this.txtWriteLastCyl.Text = "79";
            this.txtWriteLastCyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipWTD.SetToolTip(this.txtWriteLastCyl, "Host Tools v0.21 or earlier");
            this.txtWriteLastCyl.TextChanged += new System.EventHandler(this.txtWriteLastCyl_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 391);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 25);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(143, 20);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // txtPrecomp
            // 
            this.txtPrecomp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPrecomp.Location = new System.Drawing.Point(214, 171);
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
            this.chkPrecomp.Location = new System.Drawing.Point(17, 173);
            this.chkPrecomp.Name = "chkPrecomp";
            this.chkPrecomp.Size = new System.Drawing.Size(140, 21);
            this.chkPrecomp.TabIndex = 14;
            this.chkPrecomp.Text = "Precompensation";
            this.toolTipWTD.SetToolTip(this.chkPrecomp, "Host Tools v0.24 or later");
            this.chkPrecomp.UseVisualStyleBackColor = true;
            this.chkPrecomp.CheckedChanged += new System.EventHandler(this.chkPrecomp_CheckedChanged);
            // 
            // WriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 416);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Write to Disk";
            this.Load += new System.EventHandler(this.WriteForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbWriteToDisk.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbFlippy.ResumeLayout(false);
            this.gbFlippy.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDriveSelectWTD;
        private System.Windows.Forms.CheckBox chkDriveSelectWTD;
        private System.Windows.Forms.TextBox txtDoubleStep;
        private System.Windows.Forms.CheckBox chkDoubleStep;
        private System.Windows.Forms.CheckBox chkWriteFirstCyl;
        private System.Windows.Forms.TextBox txtWriteFirstCyl;
        private System.Windows.Forms.CheckBox chkWriteLastCyl;
        private System.Windows.Forms.TextBox txtWriteLastCyl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbWriteSingleSided;
        private System.Windows.Forms.RadioButton rbWriteDoubleSided;
        private System.Windows.Forms.CheckBox chkHeadsSet;
        private System.Windows.Forms.TextBox txtHeadsSet;
        private System.Windows.Forms.CheckBox chkCylSet;
        private System.Windows.Forms.TextBox txtCylSet;
        private System.Windows.Forms.GroupBox gbFlippy;
        private System.Windows.Forms.CheckBox chkFlippyOffset;
        private System.Windows.Forms.RadioButton rbFlippyPanasonic;
        private System.Windows.Forms.RadioButton rbFlippyTeac;
        private System.Windows.Forms.CheckBox chkEraseEmpty;
        private System.Windows.Forms.CheckBox chkWTDAdjustSpeed;
        private System.Windows.Forms.TextBox txtPrecomp;
        private System.Windows.Forms.CheckBox chkPrecomp;
    }
}