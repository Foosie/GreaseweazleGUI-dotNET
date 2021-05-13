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
            this.lblSeekCyl = new System.Windows.Forms.Label();
            this.txtDriveSelect = new System.Windows.Forms.TextBox();
            this.chkDriveSelect = new System.Windows.Forms.CheckBox();
            this.txtSeekCyl = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblHostTools = new System.Windows.Forms.Label();
            this.chkForce = new System.Windows.Forms.CheckBox();
            this.chkMotorOn = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.gbEraseDisk.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnLaunch);
            this.groupBox1.Controls.Add(this.txtCommandLine);
            this.groupBox1.Controls.Add(this.lblStaticCL);
            this.groupBox1.Controls.Add(this.gbEraseDisk);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 355);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(332, 300);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(111, 300);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 11;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtCommandLine.Location = new System.Drawing.Point(19, 207);
            this.txtCommandLine.Multiline = true;
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(512, 74);
            this.txtCommandLine.TabIndex = 10;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(225, 177);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 9;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbEraseDisk
            // 
            this.gbEraseDisk.Controls.Add(this.chkMotorOn);
            this.gbEraseDisk.Controls.Add(this.chkForce);
            this.gbEraseDisk.Controls.Add(this.lblSeekCyl);
            this.gbEraseDisk.Controls.Add(this.txtDriveSelect);
            this.gbEraseDisk.Controls.Add(this.chkDriveSelect);
            this.gbEraseDisk.Controls.Add(this.txtSeekCyl);
            this.gbEraseDisk.Location = new System.Drawing.Point(19, 21);
            this.gbEraseDisk.Name = "gbEraseDisk";
            this.gbEraseDisk.Size = new System.Drawing.Size(512, 143);
            this.gbEraseDisk.TabIndex = 2;
            this.gbEraseDisk.TabStop = false;
            this.gbEraseDisk.Enter += new System.EventHandler(this.gbEraseDisk_Enter);
            // 
            // lblSeekCyl
            // 
            this.lblSeekCyl.AutoSize = true;
            this.lblSeekCyl.Location = new System.Drawing.Point(107, 27);
            this.lblSeekCyl.Name = "lblSeekCyl";
            this.lblSeekCyl.Size = new System.Drawing.Size(109, 17);
            this.lblSeekCyl.TabIndex = 3;
            this.lblSeekCyl.Text = "Cylinder to seek";
            // 
            // txtDriveSelect
            // 
            this.txtDriveSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDriveSelect.ForeColor = System.Drawing.Color.White;
            this.txtDriveSelect.Location = new System.Drawing.Point(352, 52);
            this.txtDriveSelect.MaxLength = 1;
            this.txtDriveSelect.Name = "txtDriveSelect";
            this.txtDriveSelect.Size = new System.Drawing.Size(54, 22);
            this.txtDriveSelect.TabIndex = 6;
            this.txtDriveSelect.Text = "A";
            this.txtDriveSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDriveSelect.TextChanged += new System.EventHandler(this.txtDriveSelect_TextChanged);
            // 
            // chkDriveSelect
            // 
            this.chkDriveSelect.AutoSize = true;
            this.chkDriveSelect.Location = new System.Drawing.Point(107, 54);
            this.chkDriveSelect.Name = "chkDriveSelect";
            this.chkDriveSelect.Size = new System.Drawing.Size(182, 21);
            this.chkDriveSelect.TabIndex = 5;
            this.chkDriveSelect.Text = "F7 Drive Select (AB012)";
            this.toolTip.SetToolTip(this.chkDriveSelect, "Host Tools v0.18 or later\r\nRequires F7 type");
            this.chkDriveSelect.UseVisualStyleBackColor = true;
            this.chkDriveSelect.CheckedChanged += new System.EventHandler(this.chkDriveSelect_CheckedChanged);
            // 
            // txtSeekCyl
            // 
            this.txtSeekCyl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtSeekCyl.ForeColor = System.Drawing.Color.White;
            this.txtSeekCyl.Location = new System.Drawing.Point(352, 25);
            this.txtSeekCyl.MaxLength = 2;
            this.txtSeekCyl.Name = "txtSeekCyl";
            this.txtSeekCyl.Size = new System.Drawing.Size(54, 22);
            this.txtSeekCyl.TabIndex = 4;
            this.txtSeekCyl.Text = "0";
            this.txtSeekCyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSeekCyl.TextChanged += new System.EventHandler(this.txtWriteFirstCyl_TextChanged);
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(105, 377);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(367, 23);
            this.lblHostTools.TabIndex = 13;
            this.lblHostTools.Text = "for Host Tools v0.24";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkForce
            // 
            this.chkForce.AutoSize = true;
            this.chkForce.Location = new System.Drawing.Point(107, 81);
            this.chkForce.Name = "chkForce";
            this.chkForce.Size = new System.Drawing.Size(187, 21);
            this.chkForce.TabIndex = 7;
            this.chkForce.Text = "Force Extreme Cycinders";
            this.toolTip.SetToolTip(this.chkForce, "Host Tools v0.27 or later");
            this.chkForce.UseVisualStyleBackColor = true;
            this.chkForce.CheckedChanged += new System.EventHandler(this.chkForce_CheckedChanged);
            // 
            // chkMotorOn
            // 
            this.chkMotorOn.AutoSize = true;
            this.chkMotorOn.Location = new System.Drawing.Point(107, 108);
            this.chkMotorOn.Name = "chkMotorOn";
            this.chkMotorOn.Size = new System.Drawing.Size(89, 21);
            this.chkMotorOn.TabIndex = 8;
            this.chkMotorOn.Text = "Motor On";
            this.toolTip.SetToolTip(this.chkMotorOn, "Host Tools v0.27 or later\r\n");
            this.chkMotorOn.UseVisualStyleBackColor = true;
            this.chkMotorOn.CheckedChanged += new System.EventHandler(this.chkMotorOn_CheckedChanged);
            // 
            // SeekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(576, 412);
            this.Controls.Add(this.lblHostTools);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeekForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seek Cylinder";
            this.Load += new System.EventHandler(this.SeekForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEraseDisk.ResumeLayout(false);
            this.gbEraseDisk.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblSeekCyl;
        private System.Windows.Forms.Label lblHostTools;
        private System.Windows.Forms.CheckBox chkMotorOn;
        private System.Windows.Forms.CheckBox chkForce;
    }
}