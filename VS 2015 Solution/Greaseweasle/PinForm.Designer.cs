// PinForm.Designer.cs
//
// Greaseweazle GUI Wrapper
//
// Copyright (c) 2019 Don Mankin <don.mankin@yahoo.com>
//
// MIT License
//
// See the file LICENSE more details, or visit <https://opensource.org/licenses/MIT>.

namespace Greaseweazle
{
    partial class PinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinForm));
            this.gbPin = new System.Windows.Forms.GroupBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.lblSelectedPin = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPinCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbPin.SuspendLayout();
            this.gb1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPin
            // 
            this.gbPin.Controls.Add(this.gb1);
            this.gbPin.Controls.Add(this.btnBack);
            this.gbPin.Controls.Add(this.txtPinCommandLine);
            this.gbPin.Controls.Add(this.lblStaticCL);
            this.gbPin.Controls.Add(this.btnLaunch);
            this.gbPin.Location = new System.Drawing.Point(12, 12);
            this.gbPin.Name = "gbPin";
            this.gbPin.Size = new System.Drawing.Size(543, 314);
            this.gbPin.TabIndex = 0;
            this.gbPin.TabStop = false;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rbLow);
            this.gb1.Controls.Add(this.rbHigh);
            this.gb1.Controls.Add(this.lblSelectedPin);
            this.gb1.Controls.Add(this.txtPin);
            this.gb1.Location = new System.Drawing.Point(15, 21);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(512, 100);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            // 
            // rbLow
            // 
            this.rbLow.AutoSize = true;
            this.rbLow.Location = new System.Drawing.Point(311, 61);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(92, 21);
            this.rbLow.TabIndex = 5;
            this.rbLow.Text = "Low Level";
            this.rbLow.UseVisualStyleBackColor = true;
            this.rbLow.CheckedChanged += new System.EventHandler(this.rbLow_CheckedChanged);
            // 
            // rbHigh
            // 
            this.rbHigh.AutoSize = true;
            this.rbHigh.Location = new System.Drawing.Point(124, 61);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(96, 21);
            this.rbHigh.TabIndex = 4;
            this.rbHigh.Text = "High Level";
            this.rbHigh.UseVisualStyleBackColor = true;
            this.rbHigh.CheckedChanged += new System.EventHandler(this.rbHigh_CheckedChanged);
            // 
            // lblSelectedPin
            // 
            this.lblSelectedPin.AutoSize = true;
            this.lblSelectedPin.Location = new System.Drawing.Point(124, 22);
            this.lblSelectedPin.Name = "lblSelectedPin";
            this.lblSelectedPin.Size = new System.Drawing.Size(117, 17);
            this.lblSelectedPin.TabIndex = 2;
            this.lblSelectedPin.Text = "Selected Pin (22)";
            // 
            // txtPin
            // 
            this.txtPin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPin.Location = new System.Drawing.Point(311, 19);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(31, 22);
            this.txtPin.TabIndex = 3;
            this.txtPin.Text = "22";
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(311, 267);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPinCommandLine
            // 
            this.txtPinCommandLine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPinCommandLine.Location = new System.Drawing.Point(15, 179);
            this.txtPinCommandLine.Multiline = true;
            this.txtPinCommandLine.Name = "txtPinCommandLine";
            this.txtPinCommandLine.Size = new System.Drawing.Size(512, 74);
            this.txtPinCommandLine.TabIndex = 7;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(220, 151);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 6;
            this.lblStaticCL.Text = "Command Line";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(124, 267);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 8;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 348);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(572, 25);
            this.statusStrip.TabIndex = 1;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(143, 20);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // PinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(572, 373);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbPin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pin Level";
            this.Load += new System.EventHandler(this.PinForm_Load);
            this.gbPin.ResumeLayout(false);
            this.gbPin.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPin;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.Label lblSelectedPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPinCommandLine;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}