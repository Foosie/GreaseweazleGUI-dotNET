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
            this.txtDriveSelectWTD = new System.Windows.Forms.TextBox();
            this.chkDriveSelectWTD = new System.Windows.Forms.CheckBox();
            this.chkWTDAdjustSpeed = new System.Windows.Forms.CheckBox();
            this.rbWriteDoubleSided = new System.Windows.Forms.RadioButton();
            this.rbWriteSingleSided = new System.Windows.Forms.RadioButton();
            this.txtWriteLastCyl = new System.Windows.Forms.TextBox();
            this.chkWriteLastCyl = new System.Windows.Forms.CheckBox();
            this.txtWriteFirstCyl = new System.Windows.Forms.TextBox();
            this.chkWriteFirstCyl = new System.Windows.Forms.CheckBox();
            this.toolTipWTD = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.gbWriteToDisk.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 402);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(347, 354);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(221, 354);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 15;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnWTDSelectFile
            // 
            this.btnWTDSelectFile.Location = new System.Drawing.Point(95, 354);
            this.btnWTDSelectFile.Name = "btnWTDSelectFile";
            this.btnWTDSelectFile.Size = new System.Drawing.Size(108, 29);
            this.btnWTDSelectFile.TabIndex = 14;
            this.btnWTDSelectFile.Text = "Select File";
            this.toolTipWTD.SetToolTip(this.btnWTDSelectFile, "HFE & IPF require Host Tools v0.13 or later");
            this.btnWTDSelectFile.UseVisualStyleBackColor = true;
            this.btnWTDSelectFile.Click += new System.EventHandler(this.btnWTDSelectFile_Click);
            // 
            // txtWTDCommandLine
            // 
            this.txtWTDCommandLine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtWTDCommandLine.Location = new System.Drawing.Point(19, 261);
            this.txtWTDCommandLine.Multiline = true;
            this.txtWTDCommandLine.Name = "txtWTDCommandLine";
            this.txtWTDCommandLine.Size = new System.Drawing.Size(512, 74);
            this.txtWTDCommandLine.TabIndex = 13;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(225, 233);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 12;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbWriteToDisk
            // 
            this.gbWriteToDisk.Controls.Add(this.txtDriveSelectWTD);
            this.gbWriteToDisk.Controls.Add(this.chkDriveSelectWTD);
            this.gbWriteToDisk.Controls.Add(this.chkWTDAdjustSpeed);
            this.gbWriteToDisk.Controls.Add(this.rbWriteDoubleSided);
            this.gbWriteToDisk.Controls.Add(this.rbWriteSingleSided);
            this.gbWriteToDisk.Controls.Add(this.txtWriteLastCyl);
            this.gbWriteToDisk.Controls.Add(this.chkWriteLastCyl);
            this.gbWriteToDisk.Controls.Add(this.txtWriteFirstCyl);
            this.gbWriteToDisk.Controls.Add(this.chkWriteFirstCyl);
            this.gbWriteToDisk.Location = new System.Drawing.Point(19, 21);
            this.gbWriteToDisk.Name = "gbWriteToDisk";
            this.gbWriteToDisk.Size = new System.Drawing.Size(512, 196);
            this.gbWriteToDisk.TabIndex = 2;
            this.gbWriteToDisk.TabStop = false;
            this.gbWriteToDisk.Enter += new System.EventHandler(this.gbWriteToDisk_Enter);
            // 
            // txtDriveSelectWTD
            // 
            this.txtDriveSelectWTD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDriveSelectWTD.Location = new System.Drawing.Point(352, 113);
            this.txtDriveSelectWTD.MaxLength = 1;
            this.txtDriveSelectWTD.Name = "txtDriveSelectWTD";
            this.txtDriveSelectWTD.Size = new System.Drawing.Size(54, 22);
            this.txtDriveSelectWTD.TabIndex = 9;
            this.txtDriveSelectWTD.Text = "A";
            this.txtDriveSelectWTD.TextChanged += new System.EventHandler(this.txtDriveSelectWTD_TextChanged);
            // 
            // chkDriveSelectWTD
            // 
            this.chkDriveSelectWTD.AutoSize = true;
            this.chkDriveSelectWTD.Location = new System.Drawing.Point(107, 116);
            this.chkDriveSelectWTD.Name = "chkDriveSelectWTD";
            this.chkDriveSelectWTD.Size = new System.Drawing.Size(162, 21);
            this.chkDriveSelectWTD.TabIndex = 8;
            this.chkDriveSelectWTD.Text = "Drive Select (AB012)";
            this.toolTipWTD.SetToolTip(this.chkDriveSelectWTD, "Host Tools v0.10 or Later");
            this.chkDriveSelectWTD.UseVisualStyleBackColor = true;
            this.chkDriveSelectWTD.CheckedChanged += new System.EventHandler(this.chkDriveSelectWTD_CheckedChanged);
            // 
            // chkWTDAdjustSpeed
            // 
            this.chkWTDAdjustSpeed.AutoSize = true;
            this.chkWTDAdjustSpeed.Location = new System.Drawing.Point(107, 31);
            this.chkWTDAdjustSpeed.Name = "chkWTDAdjustSpeed";
            this.chkWTDAdjustSpeed.Size = new System.Drawing.Size(114, 21);
            this.chkWTDAdjustSpeed.TabIndex = 3;
            this.chkWTDAdjustSpeed.Text = "Adjust Speed";
            this.toolTipWTD.SetToolTip(this.chkWTDAdjustSpeed, "Host Tools v0.05 through v0.12");
            this.chkWTDAdjustSpeed.UseVisualStyleBackColor = true;
            this.chkWTDAdjustSpeed.CheckedChanged += new System.EventHandler(this.chkWTDAdjustSpeed_CheckedChanged_1);
            // 
            // rbWriteDoubleSided
            // 
            this.rbWriteDoubleSided.AutoSize = true;
            this.rbWriteDoubleSided.Checked = true;
            this.rbWriteDoubleSided.Location = new System.Drawing.Point(224, 150);
            this.rbWriteDoubleSided.Name = "rbWriteDoubleSided";
            this.rbWriteDoubleSided.Size = new System.Drawing.Size(114, 21);
            this.rbWriteDoubleSided.TabIndex = 11;
            this.rbWriteDoubleSided.TabStop = true;
            this.rbWriteDoubleSided.Text = "Double Sided";
            this.rbWriteDoubleSided.UseVisualStyleBackColor = true;
            this.rbWriteDoubleSided.CheckedChanged += new System.EventHandler(this.rbWriteDoubleSided_CheckedChanged);
            // 
            // rbWriteSingleSided
            // 
            this.rbWriteSingleSided.AutoSize = true;
            this.rbWriteSingleSided.Location = new System.Drawing.Point(107, 150);
            this.rbWriteSingleSided.Name = "rbWriteSingleSided";
            this.rbWriteSingleSided.Size = new System.Drawing.Size(108, 21);
            this.rbWriteSingleSided.TabIndex = 10;
            this.rbWriteSingleSided.TabStop = true;
            this.rbWriteSingleSided.Text = "Single Sided";
            this.rbWriteSingleSided.UseVisualStyleBackColor = true;
            this.rbWriteSingleSided.CheckedChanged += new System.EventHandler(this.rbWriteSingleSided_CheckedChanged);
            // 
            // txtWriteLastCyl
            // 
            this.txtWriteLastCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtWriteLastCyl.Location = new System.Drawing.Point(352, 84);
            this.txtWriteLastCyl.Name = "txtWriteLastCyl";
            this.txtWriteLastCyl.Size = new System.Drawing.Size(54, 22);
            this.txtWriteLastCyl.TabIndex = 7;
            this.txtWriteLastCyl.Text = "79";
            // 
            // chkWriteLastCyl
            // 
            this.chkWriteLastCyl.AutoSize = true;
            this.chkWriteLastCyl.Location = new System.Drawing.Point(107, 87);
            this.chkWriteLastCyl.Name = "chkWriteLastCyl";
            this.chkWriteLastCyl.Size = new System.Drawing.Size(159, 21);
            this.chkWriteLastCyl.TabIndex = 6;
            this.chkWriteLastCyl.Text = "Last cylinder to write";
            this.chkWriteLastCyl.UseVisualStyleBackColor = true;
            this.chkWriteLastCyl.CheckedChanged += new System.EventHandler(this.chkWriteLastCyl_CheckedChanged_1);
            // 
            // txtWriteFirstCyl
            // 
            this.txtWriteFirstCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtWriteFirstCyl.Location = new System.Drawing.Point(352, 55);
            this.txtWriteFirstCyl.Name = "txtWriteFirstCyl";
            this.txtWriteFirstCyl.Size = new System.Drawing.Size(54, 22);
            this.txtWriteFirstCyl.TabIndex = 5;
            this.txtWriteFirstCyl.Text = "0";
            this.txtWriteFirstCyl.TextChanged += new System.EventHandler(this.txtWriteFirstCyl_TextChanged);
            // 
            // chkWriteFirstCyl
            // 
            this.chkWriteFirstCyl.AutoSize = true;
            this.chkWriteFirstCyl.Location = new System.Drawing.Point(107, 59);
            this.chkWriteFirstCyl.Name = "chkWriteFirstCyl";
            this.chkWriteFirstCyl.Size = new System.Drawing.Size(159, 21);
            this.chkWriteFirstCyl.TabIndex = 4;
            this.chkWriteFirstCyl.Text = "First cylinder to write";
            this.chkWriteFirstCyl.UseVisualStyleBackColor = true;
            this.chkWriteFirstCyl.CheckedChanged += new System.EventHandler(this.chkWriteFirstCyl_CheckedChanged_1);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 434);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(576, 25);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(143, 20);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // WriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 459);
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
            this.gbWriteToDisk.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbWriteToDisk;
        private System.Windows.Forms.TextBox txtDriveSelectWTD;
        private System.Windows.Forms.CheckBox chkDriveSelectWTD;
        private System.Windows.Forms.CheckBox chkWTDAdjustSpeed;
        private System.Windows.Forms.RadioButton rbWriteDoubleSided;
        private System.Windows.Forms.RadioButton rbWriteSingleSided;
        private System.Windows.Forms.TextBox txtWriteLastCyl;
        private System.Windows.Forms.CheckBox chkWriteLastCyl;
        private System.Windows.Forms.TextBox txtWriteFirstCyl;
        private System.Windows.Forms.CheckBox chkWriteFirstCyl;
        private System.Windows.Forms.Button btnWTDSelectFile;
        private System.Windows.Forms.TextBox txtWTDCommandLine;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ToolTip toolTipWTD;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}