// EraseForm.Designer.cs
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
    partial class SeekForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeekForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.gbEraseDisk = new System.Windows.Forms.GroupBox();
            this.txtDriveSelect = new System.Windows.Forms.TextBox();
            this.chkDriveSelect = new System.Windows.Forms.CheckBox();
            this.txtSeekCyl = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeekCyl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbEraseDisk.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnLaunch);
            this.groupBox1.Controls.Add(this.txtCommandLine);
            this.groupBox1.Controls.Add(this.lblStaticCL);
            this.groupBox1.Controls.Add(this.gbEraseDisk);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(620, 378);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(374, 312);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 36);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(125, 312);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(122, 36);
            this.btnLaunch.TabIndex = 14;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCommandLine.Location = new System.Drawing.Point(21, 196);
            this.txtCommandLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCommandLine.Multiline = true;
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(576, 92);
            this.txtCommandLine.TabIndex = 13;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(253, 161);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(116, 20);
            this.lblStaticCL.TabIndex = 12;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbEraseDisk
            // 
            this.gbEraseDisk.Controls.Add(this.lblSeekCyl);
            this.gbEraseDisk.Controls.Add(this.txtDriveSelect);
            this.gbEraseDisk.Controls.Add(this.chkDriveSelect);
            this.gbEraseDisk.Controls.Add(this.txtSeekCyl);
            this.gbEraseDisk.Location = new System.Drawing.Point(21, 26);
            this.gbEraseDisk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEraseDisk.Name = "gbEraseDisk";
            this.gbEraseDisk.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEraseDisk.Size = new System.Drawing.Size(576, 117);
            this.gbEraseDisk.TabIndex = 2;
            this.gbEraseDisk.TabStop = false;
            this.gbEraseDisk.Enter += new System.EventHandler(this.gbEraseDisk_Enter);
            // 
            // txtDriveSelect
            // 
            this.txtDriveSelect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDriveSelect.Location = new System.Drawing.Point(396, 65);
            this.txtDriveSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDriveSelect.MaxLength = 1;
            this.txtDriveSelect.Name = "txtDriveSelect";
            this.txtDriveSelect.Size = new System.Drawing.Size(60, 26);
            this.txtDriveSelect.TabIndex = 9;
            this.txtDriveSelect.Text = "A";
            this.txtDriveSelect.TextChanged += new System.EventHandler(this.txtDriveSelect_TextChanged);
            // 
            // chkDriveSelect
            // 
            this.chkDriveSelect.AutoSize = true;
            this.chkDriveSelect.Location = new System.Drawing.Point(120, 67);
            this.chkDriveSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDriveSelect.Name = "chkDriveSelect";
            this.chkDriveSelect.Size = new System.Drawing.Size(182, 24);
            this.chkDriveSelect.TabIndex = 8;
            this.chkDriveSelect.Text = "Drive Select (AB012)";
            this.toolTip.SetToolTip(this.chkDriveSelect, "Host Tools v0.18 or later\r\nRequires F7 type");
            this.chkDriveSelect.UseVisualStyleBackColor = true;
            this.chkDriveSelect.CheckedChanged += new System.EventHandler(this.chkDriveSelect_CheckedChanged);
            // 
            // txtSeekCyl
            // 
            this.txtSeekCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSeekCyl.Location = new System.Drawing.Point(396, 31);
            this.txtSeekCyl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSeekCyl.MaxLength = 2;
            this.txtSeekCyl.Name = "txtSeekCyl";
            this.txtSeekCyl.Size = new System.Drawing.Size(60, 26);
            this.txtSeekCyl.TabIndex = 5;
            this.txtSeekCyl.Text = "0";
            this.txtSeekCyl.TextChanged += new System.EventHandler(this.txtWriteFirstCyl_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 413);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(648, 26);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(158, 21);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // lblSeekCyl
            // 
            this.lblSeekCyl.AutoSize = true;
            this.lblSeekCyl.Location = new System.Drawing.Point(120, 34);
            this.lblSeekCyl.Name = "lblSeekCyl";
            this.lblSeekCyl.Size = new System.Drawing.Size(121, 20);
            this.lblSeekCyl.TabIndex = 10;
            this.lblSeekCyl.Text = "Cylinder to seek";
            // 
            // SeekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(648, 439);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SeekForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seek Cylinder";
            this.Load += new System.EventHandler(this.EraseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEraseDisk.ResumeLayout(false);
            this.gbEraseDisk.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbEraseDisk;
        private System.Windows.Forms.TextBox txtDriveSelect;
        private System.Windows.Forms.CheckBox chkDriveSelect;
        private System.Windows.Forms.TextBox txtSeekCyl;
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label lblSeekCyl;
    }
}