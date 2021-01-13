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
    partial class EraseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EraseForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.txtEraseCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.gbEraseDisk = new System.Windows.Forms.GroupBox();
            this.txtDriveSelect = new System.Windows.Forms.TextBox();
            this.chkDriveSelect = new System.Windows.Forms.CheckBox();
            this.rbWriteDoubleSided = new System.Windows.Forms.RadioButton();
            this.rbWriteSingleSided = new System.Windows.Forms.RadioButton();
            this.txtWriteLastCyl = new System.Windows.Forms.TextBox();
            this.chkWriteLastCyl = new System.Windows.Forms.CheckBox();
            this.txtWriteFirstCyl = new System.Windows.Forms.TextBox();
            this.chkWriteFirstCyl = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkHeadsSet = new System.Windows.Forms.CheckBox();
            this.txtHeadsSet = new System.Windows.Forms.TextBox();
            this.chkCylSet = new System.Windows.Forms.CheckBox();
            this.txtCylSet = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbEraseDisk.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnLaunch);
            this.groupBox1.Controls.Add(this.txtEraseCommandLine);
            this.groupBox1.Controls.Add(this.lblStaticCL);
            this.groupBox1.Controls.Add(this.gbEraseDisk);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 414);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(332, 365);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(111, 365);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 18;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // txtEraseCommandLine
            // 
            this.txtEraseCommandLine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtEraseCommandLine.Location = new System.Drawing.Point(19, 272);
            this.txtEraseCommandLine.Multiline = true;
            this.txtEraseCommandLine.Name = "txtEraseCommandLine";
            this.txtEraseCommandLine.Size = new System.Drawing.Size(512, 74);
            this.txtEraseCommandLine.TabIndex = 17;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(225, 244);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 16;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbEraseDisk
            // 
            this.gbEraseDisk.Controls.Add(this.chkHeadsSet);
            this.gbEraseDisk.Controls.Add(this.txtHeadsSet);
            this.gbEraseDisk.Controls.Add(this.chkCylSet);
            this.gbEraseDisk.Controls.Add(this.txtCylSet);
            this.gbEraseDisk.Controls.Add(this.txtDriveSelect);
            this.gbEraseDisk.Controls.Add(this.chkDriveSelect);
            this.gbEraseDisk.Controls.Add(this.rbWriteDoubleSided);
            this.gbEraseDisk.Controls.Add(this.rbWriteSingleSided);
            this.gbEraseDisk.Controls.Add(this.txtWriteLastCyl);
            this.gbEraseDisk.Controls.Add(this.chkWriteLastCyl);
            this.gbEraseDisk.Controls.Add(this.txtWriteFirstCyl);
            this.gbEraseDisk.Controls.Add(this.chkWriteFirstCyl);
            this.gbEraseDisk.Location = new System.Drawing.Point(19, 21);
            this.gbEraseDisk.Name = "gbEraseDisk";
            this.gbEraseDisk.Size = new System.Drawing.Size(512, 208);
            this.gbEraseDisk.TabIndex = 2;
            this.gbEraseDisk.TabStop = false;
            this.gbEraseDisk.Enter += new System.EventHandler(this.gbEraseDisk_Enter);
            // 
            // txtDriveSelect
            // 
            this.txtDriveSelect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDriveSelect.Location = new System.Drawing.Point(313, 137);
            this.txtDriveSelect.MaxLength = 1;
            this.txtDriveSelect.Name = "txtDriveSelect";
            this.txtDriveSelect.Size = new System.Drawing.Size(93, 22);
            this.txtDriveSelect.TabIndex = 13;
            this.txtDriveSelect.Text = "A";
            this.txtDriveSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDriveSelect.TextChanged += new System.EventHandler(this.txtDriveSelect_TextChanged);
            // 
            // chkDriveSelect
            // 
            this.chkDriveSelect.AutoSize = true;
            this.chkDriveSelect.Location = new System.Drawing.Point(107, 139);
            this.chkDriveSelect.Name = "chkDriveSelect";
            this.chkDriveSelect.Size = new System.Drawing.Size(162, 21);
            this.chkDriveSelect.TabIndex = 12;
            this.chkDriveSelect.Text = "Drive Select (AB012)";
            this.toolTip.SetToolTip(this.chkDriveSelect, "Host Tools v0.18 or later\r\nRequires F7 type");
            this.chkDriveSelect.UseVisualStyleBackColor = true;
            this.chkDriveSelect.CheckedChanged += new System.EventHandler(this.chkDriveSelect_CheckedChanged);
            // 
            // rbWriteDoubleSided
            // 
            this.rbWriteDoubleSided.AutoSize = true;
            this.rbWriteDoubleSided.Checked = true;
            this.rbWriteDoubleSided.Location = new System.Drawing.Point(224, 172);
            this.rbWriteDoubleSided.Name = "rbWriteDoubleSided";
            this.rbWriteDoubleSided.Size = new System.Drawing.Size(114, 21);
            this.rbWriteDoubleSided.TabIndex = 15;
            this.rbWriteDoubleSided.TabStop = true;
            this.rbWriteDoubleSided.Text = "Double Sided";
            this.rbWriteDoubleSided.UseVisualStyleBackColor = true;
            this.rbWriteDoubleSided.CheckedChanged += new System.EventHandler(this.rbWriteDoubleSided_CheckedChanged);
            // 
            // rbWriteSingleSided
            // 
            this.rbWriteSingleSided.AutoSize = true;
            this.rbWriteSingleSided.Location = new System.Drawing.Point(107, 172);
            this.rbWriteSingleSided.Name = "rbWriteSingleSided";
            this.rbWriteSingleSided.Size = new System.Drawing.Size(108, 21);
            this.rbWriteSingleSided.TabIndex = 14;
            this.rbWriteSingleSided.TabStop = true;
            this.rbWriteSingleSided.Text = "Single Sided";
            this.rbWriteSingleSided.UseVisualStyleBackColor = true;
            this.rbWriteSingleSided.CheckedChanged += new System.EventHandler(this.rbWriteSingleSided_CheckedChanged);
            // 
            // txtWriteLastCyl
            // 
            this.txtWriteLastCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtWriteLastCyl.Location = new System.Drawing.Point(313, 53);
            this.txtWriteLastCyl.Name = "txtWriteLastCyl";
            this.txtWriteLastCyl.Size = new System.Drawing.Size(93, 22);
            this.txtWriteLastCyl.TabIndex = 7;
            this.txtWriteLastCyl.Text = "79";
            this.txtWriteLastCyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWriteLastCyl.TextChanged += new System.EventHandler(this.txtWriteLastCyl_TextChanged);
            // 
            // chkWriteLastCyl
            // 
            this.chkWriteLastCyl.AutoSize = true;
            this.chkWriteLastCyl.Location = new System.Drawing.Point(107, 54);
            this.chkWriteLastCyl.Name = "chkWriteLastCyl";
            this.chkWriteLastCyl.Size = new System.Drawing.Size(166, 21);
            this.chkWriteLastCyl.TabIndex = 6;
            this.chkWriteLastCyl.Text = "Last cylinder to erase";
            this.chkWriteLastCyl.UseVisualStyleBackColor = true;
            this.chkWriteLastCyl.CheckedChanged += new System.EventHandler(this.chkWriteLastCyl_CheckedChanged);
            // 
            // txtWriteFirstCyl
            // 
            this.txtWriteFirstCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtWriteFirstCyl.Location = new System.Drawing.Point(313, 25);
            this.txtWriteFirstCyl.Name = "txtWriteFirstCyl";
            this.txtWriteFirstCyl.Size = new System.Drawing.Size(93, 22);
            this.txtWriteFirstCyl.TabIndex = 5;
            this.txtWriteFirstCyl.Text = "0";
            this.txtWriteFirstCyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWriteFirstCyl.TextChanged += new System.EventHandler(this.txtWriteFirstCyl_TextChanged);
            // 
            // chkWriteFirstCyl
            // 
            this.chkWriteFirstCyl.AutoSize = true;
            this.chkWriteFirstCyl.Location = new System.Drawing.Point(107, 26);
            this.chkWriteFirstCyl.Name = "chkWriteFirstCyl";
            this.chkWriteFirstCyl.Size = new System.Drawing.Size(166, 21);
            this.chkWriteFirstCyl.TabIndex = 4;
            this.chkWriteFirstCyl.Text = "First cylinder to erase";
            this.chkWriteFirstCyl.UseVisualStyleBackColor = true;
            this.chkWriteFirstCyl.CheckedChanged += new System.EventHandler(this.chkWriteFirstCyl_CheckedChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 449);
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
            // chkHeadsSet
            // 
            this.chkHeadsSet.AutoSize = true;
            this.chkHeadsSet.Location = new System.Drawing.Point(107, 111);
            this.chkHeadsSet.Name = "chkHeadsSet";
            this.chkHeadsSet.Size = new System.Drawing.Size(94, 21);
            this.chkHeadsSet.TabIndex = 10;
            this.chkHeadsSet.Text = "Head sets";
            this.chkHeadsSet.UseVisualStyleBackColor = true;
            this.chkHeadsSet.CheckedChanged += new System.EventHandler(this.chkHeadsSet_CheckedChanged);
            // 
            // txtHeadsSet
            // 
            this.txtHeadsSet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtHeadsSet.Location = new System.Drawing.Point(313, 109);
            this.txtHeadsSet.Name = "txtHeadsSet";
            this.txtHeadsSet.Size = new System.Drawing.Size(93, 22);
            this.txtHeadsSet.TabIndex = 11;
            this.txtHeadsSet.Text = "0,1";
            this.txtHeadsSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeadsSet.TextChanged += new System.EventHandler(this.txtHeadsSet_TextChanged);
            // 
            // chkCylSet
            // 
            this.chkCylSet.AutoSize = true;
            this.chkCylSet.Location = new System.Drawing.Point(107, 83);
            this.chkCylSet.Name = "chkCylSet";
            this.chkCylSet.Size = new System.Drawing.Size(111, 21);
            this.chkCylSet.TabIndex = 8;
            this.chkCylSet.Text = "Cylinder sets";
            this.chkCylSet.UseVisualStyleBackColor = true;
            this.chkCylSet.CheckedChanged += new System.EventHandler(this.chkCylSet_CheckedChanged);
            // 
            // txtCylSet
            // 
            this.txtCylSet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCylSet.Location = new System.Drawing.Point(313, 81);
            this.txtCylSet.Name = "txtCylSet";
            this.txtCylSet.Size = new System.Drawing.Size(93, 22);
            this.txtCylSet.TabIndex = 9;
            this.txtCylSet.Text = "0-34,35-79";
            this.txtCylSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCylSet.TextChanged += new System.EventHandler(this.txtCylSet_TextChanged);
            // 
            // EraseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 474);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EraseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Erase Disk";
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
        private System.Windows.Forms.RadioButton rbWriteDoubleSided;
        private System.Windows.Forms.RadioButton rbWriteSingleSided;
        private System.Windows.Forms.TextBox txtWriteLastCyl;
        private System.Windows.Forms.CheckBox chkWriteLastCyl;
        private System.Windows.Forms.TextBox txtWriteFirstCyl;
        private System.Windows.Forms.CheckBox chkWriteFirstCyl;
        private System.Windows.Forms.TextBox txtEraseCommandLine;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.CheckBox chkHeadsSet;
        private System.Windows.Forms.TextBox txtHeadsSet;
        private System.Windows.Forms.CheckBox chkCylSet;
        private System.Windows.Forms.TextBox txtCylSet;
    }
}