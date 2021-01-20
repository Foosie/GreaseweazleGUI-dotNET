// DelayForm.Designer.cs
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
    partial class DelaysForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelaysForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnDelaysDefaults = new System.Windows.Forms.Button();
            this.txtDelaysCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.gbSetDelays = new System.Windows.Forms.GroupBox();
            this.txtDelayAutoDeselect = new System.Windows.Forms.TextBox();
            this.chkDelayAutoDeselect = new System.Windows.Forms.CheckBox();
            this.txtDelayMotorOn = new System.Windows.Forms.TextBox();
            this.chkDelayMotorOn = new System.Windows.Forms.CheckBox();
            this.txtDelaySeekSettle = new System.Windows.Forms.TextBox();
            this.chkDelaySeekSettle = new System.Windows.Forms.CheckBox();
            this.txtDelayDriveSelect = new System.Windows.Forms.TextBox();
            this.chkDelayDriveSelect = new System.Windows.Forms.CheckBox();
            this.txtDelayHeadSteps = new System.Windows.Forms.TextBox();
            this.chkDelayHeadSteps = new System.Windows.Forms.CheckBox();
            this.lblHostTools = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbSetDelays.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnLaunch);
            this.groupBox1.Controls.Add(this.btnDelaysDefaults);
            this.groupBox1.Controls.Add(this.txtDelaysCommandLine);
            this.groupBox1.Controls.Add(this.lblStaticCL);
            this.groupBox1.Controls.Add(this.gbSetDelays);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(357, 359);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(81, 359);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 14;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnDelaysDefaults
            // 
            this.btnDelaysDefaults.BackColor = System.Drawing.Color.Maroon;
            this.btnDelaysDefaults.Location = new System.Drawing.Point(219, 359);
            this.btnDelaysDefaults.Name = "btnDelaysDefaults";
            this.btnDelaysDefaults.Size = new System.Drawing.Size(108, 29);
            this.btnDelaysDefaults.TabIndex = 15;
            this.btnDelaysDefaults.Text = "Defaults";
            this.btnDelaysDefaults.UseVisualStyleBackColor = false;
            this.btnDelaysDefaults.Click += new System.EventHandler(this.btnDelaysDefaults_Click);
            // 
            // txtDelaysCommandLine
            // 
            this.txtDelaysCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDelaysCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtDelaysCommandLine.Location = new System.Drawing.Point(16, 268);
            this.txtDelaysCommandLine.Multiline = true;
            this.txtDelaysCommandLine.Name = "txtDelaysCommandLine";
            this.txtDelaysCommandLine.Size = new System.Drawing.Size(512, 74);
            this.txtDelaysCommandLine.TabIndex = 13;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(222, 240);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 12;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbSetDelays
            // 
            this.gbSetDelays.Controls.Add(this.txtDelayAutoDeselect);
            this.gbSetDelays.Controls.Add(this.chkDelayAutoDeselect);
            this.gbSetDelays.Controls.Add(this.txtDelayMotorOn);
            this.gbSetDelays.Controls.Add(this.chkDelayMotorOn);
            this.gbSetDelays.Controls.Add(this.txtDelaySeekSettle);
            this.gbSetDelays.Controls.Add(this.chkDelaySeekSettle);
            this.gbSetDelays.Controls.Add(this.txtDelayDriveSelect);
            this.gbSetDelays.Controls.Add(this.chkDelayDriveSelect);
            this.gbSetDelays.Controls.Add(this.txtDelayHeadSteps);
            this.gbSetDelays.Controls.Add(this.chkDelayHeadSteps);
            this.gbSetDelays.Location = new System.Drawing.Point(16, 21);
            this.gbSetDelays.Name = "gbSetDelays";
            this.gbSetDelays.Size = new System.Drawing.Size(512, 204);
            this.gbSetDelays.TabIndex = 1;
            this.gbSetDelays.TabStop = false;
            // 
            // txtDelayAutoDeselect
            // 
            this.txtDelayAutoDeselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDelayAutoDeselect.ForeColor = System.Drawing.Color.White;
            this.txtDelayAutoDeselect.Location = new System.Drawing.Point(395, 161);
            this.txtDelayAutoDeselect.Name = "txtDelayAutoDeselect";
            this.txtDelayAutoDeselect.Size = new System.Drawing.Size(54, 22);
            this.txtDelayAutoDeselect.TabIndex = 11;
            this.txtDelayAutoDeselect.Text = "10000";
            this.txtDelayAutoDeselect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelayAutoDeselect.TextChanged += new System.EventHandler(this.txtDelayAutoDeselect_TextChanged);
            // 
            // chkDelayAutoDeselect
            // 
            this.chkDelayAutoDeselect.AutoSize = true;
            this.chkDelayAutoDeselect.Location = new System.Drawing.Point(64, 161);
            this.chkDelayAutoDeselect.Name = "chkDelayAutoDeselect";
            this.chkDelayAutoDeselect.Size = new System.Drawing.Size(297, 21);
            this.chkDelayAutoDeselect.TabIndex = 10;
            this.chkDelayAutoDeselect.Text = "Quiescent time until auto deselect (msecs)";
            this.chkDelayAutoDeselect.UseVisualStyleBackColor = true;
            this.chkDelayAutoDeselect.CheckedChanged += new System.EventHandler(this.chkDelayAutoDeselect_CheckedChanged);
            // 
            // txtDelayMotorOn
            // 
            this.txtDelayMotorOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDelayMotorOn.ForeColor = System.Drawing.Color.White;
            this.txtDelayMotorOn.Location = new System.Drawing.Point(395, 128);
            this.txtDelayMotorOn.Name = "txtDelayMotorOn";
            this.txtDelayMotorOn.Size = new System.Drawing.Size(54, 22);
            this.txtDelayMotorOn.TabIndex = 9;
            this.txtDelayMotorOn.Text = "750";
            this.txtDelayMotorOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelayMotorOn.TextChanged += new System.EventHandler(this.txtDelayMotorOn_TextChanged);
            // 
            // chkDelayMotorOn
            // 
            this.chkDelayMotorOn.AutoSize = true;
            this.chkDelayMotorOn.Location = new System.Drawing.Point(64, 128);
            this.chkDelayMotorOn.Name = "chkDelayMotorOn";
            this.chkDelayMotorOn.Size = new System.Drawing.Size(213, 21);
            this.chkDelayMotorOn.TabIndex = 8;
            this.chkDelayMotorOn.Text = "Delay after motor on (msecs)";
            this.chkDelayMotorOn.UseVisualStyleBackColor = true;
            this.chkDelayMotorOn.CheckedChanged += new System.EventHandler(this.chkDelayMotorOn_CheckedChanged);
            // 
            // txtDelaySeekSettle
            // 
            this.txtDelaySeekSettle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDelaySeekSettle.ForeColor = System.Drawing.Color.White;
            this.txtDelaySeekSettle.Location = new System.Drawing.Point(395, 95);
            this.txtDelaySeekSettle.Name = "txtDelaySeekSettle";
            this.txtDelaySeekSettle.Size = new System.Drawing.Size(54, 22);
            this.txtDelaySeekSettle.TabIndex = 7;
            this.txtDelaySeekSettle.Text = "15";
            this.txtDelaySeekSettle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelaySeekSettle.TextChanged += new System.EventHandler(this.txtDelaySeekSettle_TextChanged);
            // 
            // chkDelaySeekSettle
            // 
            this.chkDelaySeekSettle.AutoSize = true;
            this.chkDelaySeekSettle.Location = new System.Drawing.Point(64, 95);
            this.chkDelaySeekSettle.Name = "chkDelaySeekSettle";
            this.chkDelaySeekSettle.Size = new System.Drawing.Size(225, 21);
            this.chkDelaySeekSettle.TabIndex = 6;
            this.chkDelaySeekSettle.Text = "Settle delay after seek (msecs)";
            this.chkDelaySeekSettle.UseVisualStyleBackColor = true;
            this.chkDelaySeekSettle.CheckedChanged += new System.EventHandler(this.chkDelaySeekSettle_CheckedChanged);
            // 
            // txtDelayDriveSelect
            // 
            this.txtDelayDriveSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDelayDriveSelect.ForeColor = System.Drawing.Color.White;
            this.txtDelayDriveSelect.Location = new System.Drawing.Point(395, 29);
            this.txtDelayDriveSelect.Name = "txtDelayDriveSelect";
            this.txtDelayDriveSelect.Size = new System.Drawing.Size(54, 22);
            this.txtDelayDriveSelect.TabIndex = 3;
            this.txtDelayDriveSelect.Text = "10";
            this.txtDelayDriveSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelayDriveSelect.TextChanged += new System.EventHandler(this.txtDelayDriveSelect_TextChanged);
            // 
            // chkDelayDriveSelect
            // 
            this.chkDelayDriveSelect.AutoSize = true;
            this.chkDelayDriveSelect.Location = new System.Drawing.Point(64, 29);
            this.chkDelayDriveSelect.Name = "chkDelayDriveSelect";
            this.chkDelayDriveSelect.Size = new System.Drawing.Size(226, 21);
            this.chkDelayDriveSelect.TabIndex = 2;
            this.chkDelayDriveSelect.Text = "Delay after drive select (usecs)";
            this.chkDelayDriveSelect.UseVisualStyleBackColor = true;
            this.chkDelayDriveSelect.CheckedChanged += new System.EventHandler(this.chkDelayDriveSelect_CheckedChanged);
            // 
            // txtDelayHeadSteps
            // 
            this.txtDelayHeadSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDelayHeadSteps.ForeColor = System.Drawing.Color.White;
            this.txtDelayHeadSteps.Location = new System.Drawing.Point(395, 62);
            this.txtDelayHeadSteps.Name = "txtDelayHeadSteps";
            this.txtDelayHeadSteps.Size = new System.Drawing.Size(54, 22);
            this.txtDelayHeadSteps.TabIndex = 5;
            this.txtDelayHeadSteps.Text = "3000";
            this.txtDelayHeadSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelayHeadSteps.TextChanged += new System.EventHandler(this.txtDelayHeadSteps_TextChanged);
            // 
            // chkDelayHeadSteps
            // 
            this.chkDelayHeadSteps.AutoSize = true;
            this.chkDelayHeadSteps.Location = new System.Drawing.Point(64, 62);
            this.chkDelayHeadSteps.Name = "chkDelayHeadSteps";
            this.chkDelayHeadSteps.Size = new System.Drawing.Size(248, 21);
            this.chkDelayHeadSteps.TabIndex = 4;
            this.chkDelayHeadSteps.Text = "Delay between head steps (usecs)";
            this.chkDelayHeadSteps.UseVisualStyleBackColor = true;
            this.chkDelayHeadSteps.CheckedChanged += new System.EventHandler(this.chkDelayHeadSteps_CheckedChanged);
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(104, 435);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(367, 23);
            this.lblHostTools.TabIndex = 8;
            this.lblHostTools.Text = "for Host Tools v0.24";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DelaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(574, 469);
            this.Controls.Add(this.lblHostTools);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DelaysForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Delays";
            this.Load += new System.EventHandler(this.DelaysForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSetDelays.ResumeLayout(false);
            this.gbSetDelays.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbSetDelays;
        private System.Windows.Forms.TextBox txtDelayAutoDeselect;
        private System.Windows.Forms.CheckBox chkDelayAutoDeselect;
        private System.Windows.Forms.TextBox txtDelayMotorOn;
        private System.Windows.Forms.CheckBox chkDelayMotorOn;
        private System.Windows.Forms.TextBox txtDelaySeekSettle;
        private System.Windows.Forms.CheckBox chkDelaySeekSettle;
        private System.Windows.Forms.TextBox txtDelayDriveSelect;
        private System.Windows.Forms.CheckBox chkDelayDriveSelect;
        private System.Windows.Forms.TextBox txtDelayHeadSteps;
        private System.Windows.Forms.CheckBox chkDelayHeadSteps;
        private System.Windows.Forms.TextBox txtDelaysCommandLine;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.Button btnDelaysDefaults;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Label lblHostTools;
    }
}