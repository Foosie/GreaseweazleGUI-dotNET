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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDoubleStep = new System.Windows.Forms.CheckBox();
            this.chkRevsPerTrack = new System.Windows.Forms.CheckBox();
            this.txtRevsPerTrack = new System.Windows.Forms.TextBox();
            this.chkReadFirstCyl = new System.Windows.Forms.CheckBox();
            this.txtReadFirstCyl = new System.Windows.Forms.TextBox();
            this.chkReadLastCyl = new System.Windows.Forms.CheckBox();
            this.txtDriveSelectRFD = new System.Windows.Forms.TextBox();
            this.txtReadLastCyl = new System.Windows.Forms.TextBox();
            this.chkDriveSelectRFD = new System.Windows.Forms.CheckBox();
            this.rbReadSingleSided = new System.Windows.Forms.RadioButton();
            this.rbReadDoubleSided = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRFDCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnRFDSelectFile = new System.Windows.Forms.Button();
            this.btnRFDSelectFolder = new System.Windows.Forms.Button();
            this.toolTipRFD = new System.Windows.Forms.ToolTip(this.components);
            this.gbReadFromDisk.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReadFromDisk
            // 
            this.gbReadFromDisk.Controls.Add(this.groupBox1);
            this.gbReadFromDisk.Controls.Add(this.btnBack);
            this.gbReadFromDisk.Controls.Add(this.txtRFDCommandLine);
            this.gbReadFromDisk.Controls.Add(this.lblStaticCL);
            this.gbReadFromDisk.Controls.Add(this.btnLaunch);
            this.gbReadFromDisk.Controls.Add(this.btnRFDSelectFile);
            this.gbReadFromDisk.Controls.Add(this.btnRFDSelectFolder);
            this.gbReadFromDisk.Location = new System.Drawing.Point(24, 24);
            this.gbReadFromDisk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbReadFromDisk.Name = "gbReadFromDisk";
            this.gbReadFromDisk.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbReadFromDisk.Size = new System.Drawing.Size(624, 512);
            this.gbReadFromDisk.TabIndex = 0;
            this.gbReadFromDisk.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDoubleStep);
            this.groupBox1.Controls.Add(this.chkRevsPerTrack);
            this.groupBox1.Controls.Add(this.txtRevsPerTrack);
            this.groupBox1.Controls.Add(this.chkReadFirstCyl);
            this.groupBox1.Controls.Add(this.txtReadFirstCyl);
            this.groupBox1.Controls.Add(this.chkReadLastCyl);
            this.groupBox1.Controls.Add(this.txtDriveSelectRFD);
            this.groupBox1.Controls.Add(this.txtReadLastCyl);
            this.groupBox1.Controls.Add(this.chkDriveSelectRFD);
            this.groupBox1.Controls.Add(this.rbReadSingleSided);
            this.groupBox1.Controls.Add(this.rbReadDoubleSided);
            this.groupBox1.Location = new System.Drawing.Point(26, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(576, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // chkDoubleStep
            // 
            this.chkDoubleStep.AutoSize = true;
            this.chkDoubleStep.Location = new System.Drawing.Point(120, 29);
            this.chkDoubleStep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDoubleStep.Name = "chkDoubleStep";
            this.chkDoubleStep.Size = new System.Drawing.Size(124, 24);
            this.chkDoubleStep.TabIndex = 2;
            this.chkDoubleStep.Text = "Double-Step";
<<<<<<< HEAD
            this.toolTipRFD.SetToolTip(this.chkDoubleStep, "Host Tools v0.12 or Later");
=======
            this.toolTipRFD.SetToolTip(this.chkDoubleStep, "Host Tools v0.12 or greater");
>>>>>>> 91deb9b9f6ff142c3fc0fb999daf0e4eb62d3e22
            this.chkDoubleStep.UseVisualStyleBackColor = true;
            this.chkDoubleStep.CheckedChanged += new System.EventHandler(this.chkDoubleStep_CheckedChanged);
            // 
            // chkRevsPerTrack
            // 
            this.chkRevsPerTrack.AutoSize = true;
            this.chkRevsPerTrack.Location = new System.Drawing.Point(120, 62);
            this.chkRevsPerTrack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkRevsPerTrack.Name = "chkRevsPerTrack";
            this.chkRevsPerTrack.Size = new System.Drawing.Size(190, 24);
            this.chkRevsPerTrack.TabIndex = 3;
            this.chkRevsPerTrack.Text = "Revs to read per track";
            this.chkRevsPerTrack.UseVisualStyleBackColor = true;
            this.chkRevsPerTrack.CheckedChanged += new System.EventHandler(this.chkRevsPerTrack_CheckedChanged);
            // 
            // txtRevsPerTrack
            // 
            this.txtRevsPerTrack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtRevsPerTrack.Location = new System.Drawing.Point(396, 60);
            this.txtRevsPerTrack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRevsPerTrack.Name = "txtRevsPerTrack";
            this.txtRevsPerTrack.Size = new System.Drawing.Size(60, 26);
            this.txtRevsPerTrack.TabIndex = 4;
            this.txtRevsPerTrack.Text = "3";
            this.txtRevsPerTrack.TextChanged += new System.EventHandler(this.txtRevsPerTrack_TextChanged);
            // 
            // chkReadFirstCyl
            // 
            this.chkReadFirstCyl.AutoSize = true;
            this.chkReadFirstCyl.Location = new System.Drawing.Point(120, 98);
            this.chkReadFirstCyl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkReadFirstCyl.Name = "chkReadFirstCyl";
            this.chkReadFirstCyl.Size = new System.Drawing.Size(176, 24);
            this.chkReadFirstCyl.TabIndex = 5;
            this.chkReadFirstCyl.Text = "First cylinder to read";
            this.chkReadFirstCyl.UseVisualStyleBackColor = true;
            this.chkReadFirstCyl.CheckedChanged += new System.EventHandler(this.chkReadFirstCyl_CheckedChanged);
            // 
            // txtReadFirstCyl
            // 
            this.txtReadFirstCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtReadFirstCyl.Location = new System.Drawing.Point(396, 96);
            this.txtReadFirstCyl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReadFirstCyl.Name = "txtReadFirstCyl";
            this.txtReadFirstCyl.Size = new System.Drawing.Size(60, 26);
            this.txtReadFirstCyl.TabIndex = 6;
            this.txtReadFirstCyl.Text = "0";
            this.txtReadFirstCyl.TextChanged += new System.EventHandler(this.txtReadFirstCyl_TextChanged);
            // 
            // chkReadLastCyl
            // 
            this.chkReadLastCyl.AutoSize = true;
            this.chkReadLastCyl.Location = new System.Drawing.Point(120, 135);
            this.chkReadLastCyl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkReadLastCyl.Name = "chkReadLastCyl";
            this.chkReadLastCyl.Size = new System.Drawing.Size(176, 24);
            this.chkReadLastCyl.TabIndex = 7;
            this.chkReadLastCyl.Text = "Last cylinder to read";
            this.chkReadLastCyl.UseVisualStyleBackColor = true;
            this.chkReadLastCyl.CheckedChanged += new System.EventHandler(this.chkReadLastCyl_CheckedChanged);
            // 
            // txtDriveSelectRFD
            // 
            this.txtDriveSelectRFD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDriveSelectRFD.Location = new System.Drawing.Point(396, 168);
            this.txtDriveSelectRFD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDriveSelectRFD.MaxLength = 1;
            this.txtDriveSelectRFD.Name = "txtDriveSelectRFD";
            this.txtDriveSelectRFD.Size = new System.Drawing.Size(60, 26);
            this.txtDriveSelectRFD.TabIndex = 10;
            this.txtDriveSelectRFD.Text = "A";
            this.txtDriveSelectRFD.TextChanged += new System.EventHandler(this.txtDriveSelectRFD_TextChanged);
            // 
            // txtReadLastCyl
            // 
            this.txtReadLastCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtReadLastCyl.Location = new System.Drawing.Point(396, 132);
            this.txtReadLastCyl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReadLastCyl.Name = "txtReadLastCyl";
            this.txtReadLastCyl.Size = new System.Drawing.Size(60, 26);
            this.txtReadLastCyl.TabIndex = 8;
            this.txtReadLastCyl.Text = "79";
            this.txtReadLastCyl.TextChanged += new System.EventHandler(this.txtReadLastCyl_TextChanged);
            // 
            // chkDriveSelectRFD
            // 
            this.chkDriveSelectRFD.AutoSize = true;
            this.chkDriveSelectRFD.Enabled = false;
            this.chkDriveSelectRFD.Location = new System.Drawing.Point(120, 170);
            this.chkDriveSelectRFD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDriveSelectRFD.Name = "chkDriveSelectRFD";
            this.chkDriveSelectRFD.Size = new System.Drawing.Size(182, 24);
            this.chkDriveSelectRFD.TabIndex = 9;
            this.chkDriveSelectRFD.Text = "Drive Select (AB012)";
<<<<<<< HEAD
            this.toolTipRFD.SetToolTip(this.chkDriveSelectRFD, "Host Tools v0.10 or Later");
=======
            this.toolTipRFD.SetToolTip(this.chkDriveSelectRFD, "Host Tools v0.10 or greater");
>>>>>>> 91deb9b9f6ff142c3fc0fb999daf0e4eb62d3e22
            this.chkDriveSelectRFD.UseVisualStyleBackColor = true;
            this.chkDriveSelectRFD.CheckedChanged += new System.EventHandler(this.chkDriveSelectRFD_CheckedChanged);
            // 
            // rbReadSingleSided
            // 
            this.rbReadSingleSided.AutoSize = true;
            this.rbReadSingleSided.Location = new System.Drawing.Point(120, 210);
            this.rbReadSingleSided.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbReadSingleSided.Name = "rbReadSingleSided";
            this.rbReadSingleSided.Size = new System.Drawing.Size(122, 24);
            this.rbReadSingleSided.TabIndex = 11;
            this.rbReadSingleSided.TabStop = true;
            this.rbReadSingleSided.Text = "Single Sided";
            this.rbReadSingleSided.UseVisualStyleBackColor = true;
            this.rbReadSingleSided.CheckedChanged += new System.EventHandler(this.rbReadSingleSided_CheckedChanged);
            // 
            // rbReadDoubleSided
            // 
            this.rbReadDoubleSided.AutoSize = true;
            this.rbReadDoubleSided.Checked = true;
            this.rbReadDoubleSided.Location = new System.Drawing.Point(249, 210);
            this.rbReadDoubleSided.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbReadDoubleSided.Name = "rbReadDoubleSided";
            this.rbReadDoubleSided.Size = new System.Drawing.Size(129, 24);
            this.rbReadDoubleSided.TabIndex = 12;
            this.rbReadDoubleSided.TabStop = true;
            this.rbReadDoubleSided.Text = "Double Sided";
            this.rbReadDoubleSided.UseVisualStyleBackColor = true;
            this.rbReadDoubleSided.CheckedChanged += new System.EventHandler(this.rbReadDoubleSided_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(443, 454);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 36);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRFDCommandLine
            // 
            this.txtRFDCommandLine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtRFDCommandLine.Location = new System.Drawing.Point(26, 344);
            this.txtRFDCommandLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRFDCommandLine.Multiline = true;
            this.txtRFDCommandLine.Name = "txtRFDCommandLine";
            this.txtRFDCommandLine.Size = new System.Drawing.Size(576, 92);
            this.txtRFDCommandLine.TabIndex = 14;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(258, 309);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(116, 20);
            this.lblStaticCL.TabIndex = 13;
            this.lblStaticCL.Text = "Command Line";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(315, 454);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(122, 36);
            this.btnLaunch.TabIndex = 17;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnRFDSelectFile
            // 
            this.btnRFDSelectFile.Location = new System.Drawing.Point(187, 454);
            this.btnRFDSelectFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRFDSelectFile.Name = "btnRFDSelectFile";
            this.btnRFDSelectFile.Size = new System.Drawing.Size(122, 36);
            this.btnRFDSelectFile.TabIndex = 16;
            this.btnRFDSelectFile.Text = "Select File";
            this.toolTipRFD.SetToolTip(this.btnRFDSelectFile, "HFE & IPF require Host Tools v0.13 or later");
            this.btnRFDSelectFile.UseVisualStyleBackColor = true;
            this.btnRFDSelectFile.Click += new System.EventHandler(this.btnRFDSelectFile_Click);
            // 
            // btnRFDSelectFolder
            // 
            this.btnRFDSelectFolder.Location = new System.Drawing.Point(58, 454);
            this.btnRFDSelectFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRFDSelectFolder.Name = "btnRFDSelectFolder";
            this.btnRFDSelectFolder.Size = new System.Drawing.Size(122, 36);
            this.btnRFDSelectFolder.TabIndex = 15;
            this.btnRFDSelectFolder.Text = "Select Folder";
            this.btnRFDSelectFolder.UseVisualStyleBackColor = true;
            this.btnRFDSelectFolder.Click += new System.EventHandler(this.btnRFDSelectFolder_Click);
            // 
            // ReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(672, 568);
            this.Controls.Add(this.gbReadFromDisk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Read From Disk";
            this.Load += new System.EventHandler(this.ReadForm_Load);
            this.gbReadFromDisk.ResumeLayout(false);
            this.gbReadFromDisk.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReadFromDisk;
        private System.Windows.Forms.TextBox txtDriveSelectRFD;
        private System.Windows.Forms.CheckBox chkDriveSelectRFD;
        private System.Windows.Forms.Button btnRFDSelectFile;
        private System.Windows.Forms.Button btnRFDSelectFolder;
        private System.Windows.Forms.RadioButton rbReadDoubleSided;
        private System.Windows.Forms.RadioButton rbReadSingleSided;
        private System.Windows.Forms.TextBox txtReadLastCyl;
        private System.Windows.Forms.CheckBox chkReadLastCyl;
        private System.Windows.Forms.TextBox txtReadFirstCyl;
        private System.Windows.Forms.CheckBox chkReadFirstCyl;
        private System.Windows.Forms.TextBox txtRevsPerTrack;
        private System.Windows.Forms.CheckBox chkRevsPerTrack;
        private System.Windows.Forms.TextBox txtRFDCommandLine;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDoubleStep;
        private System.Windows.Forms.ToolTip toolTipRFD;
    }
}