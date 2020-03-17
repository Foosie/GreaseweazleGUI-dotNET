﻿namespace Greaseweazle
{
    partial class ChooserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooserForm));
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.gbUSBPorts = new System.Windows.Forms.GroupBox();
            this.btnRefreshUSB = new System.Windows.Forms.Button();
            this.lbUSBPorts = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbF7 = new System.Windows.Forms.RadioButton();
            this.rbF1 = new System.Windows.Forms.RadioButton();
            this.gbActionSelect = new System.Windows.Forms.GroupBox();
            this.rbReset = new System.Windows.Forms.RadioButton();
            this.rbPin = new System.Windows.Forms.RadioButton();
            this.rbReadDisk = new System.Windows.Forms.RadioButton();
            this.rbUpdateFirmware = new System.Windows.Forms.RadioButton();
            this.rbSetDelays = new System.Windows.Forms.RadioButton();
            this.rbWriteDisk = new System.Windows.Forms.RadioButton();
            this.pbGWsmall = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUSBSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAction.SuspendLayout();
            this.gbUSBPorts.SuspendLayout();
            this.gbType.SuspendLayout();
            this.gbActionSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGWsmall)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.gbUSBPorts);
            this.gbAction.Controls.Add(this.btnSelect);
            this.gbAction.Controls.Add(this.btnClose);
            this.gbAction.Controls.Add(this.gbType);
            this.gbAction.Controls.Add(this.gbActionSelect);
            this.gbAction.Controls.Add(this.pbGWsmall);
            this.gbAction.Location = new System.Drawing.Point(12, 29);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(402, 453);
            this.gbAction.TabIndex = 1;
            this.gbAction.TabStop = false;
            // 
            // gbUSBPorts
            // 
            this.gbUSBPorts.Controls.Add(this.btnRefreshUSB);
            this.gbUSBPorts.Controls.Add(this.lbUSBPorts);
            this.gbUSBPorts.Location = new System.Drawing.Point(22, 233);
            this.gbUSBPorts.Name = "gbUSBPorts";
            this.gbUSBPorts.Size = new System.Drawing.Size(357, 166);
            this.gbUSBPorts.TabIndex = 13;
            this.gbUSBPorts.TabStop = false;
            this.gbUSBPorts.Text = "USB Ports";
            // 
            // btnRefreshUSB
            // 
            this.btnRefreshUSB.Location = new System.Drawing.Point(124, 121);
            this.btnRefreshUSB.Name = "btnRefreshUSB";
            this.btnRefreshUSB.Size = new System.Drawing.Size(108, 29);
            this.btnRefreshUSB.TabIndex = 15;
            this.btnRefreshUSB.Text = "Refresh";
            this.btnRefreshUSB.UseVisualStyleBackColor = true;
            this.btnRefreshUSB.Click += new System.EventHandler(this.btnRefreshUSB_Click);
            // 
            // lbUSBPorts
            // 
            this.lbUSBPorts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbUSBPorts.FormattingEnabled = true;
            this.lbUSBPorts.ItemHeight = 16;
            this.lbUSBPorts.Location = new System.Drawing.Point(18, 26);
            this.lbUSBPorts.Name = "lbUSBPorts";
            this.lbUSBPorts.Size = new System.Drawing.Size(320, 84);
            this.lbUSBPorts.TabIndex = 14;
            this.lbUSBPorts.SelectedIndexChanged += new System.EventHandler(this.lbUSBPorts_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(59, 410);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(108, 29);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(237, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 29);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbF7);
            this.gbType.Controls.Add(this.rbF1);
            this.gbType.Location = new System.Drawing.Point(269, 16);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(110, 98);
            this.gbType.TabIndex = 3;
            this.gbType.TabStop = false;
            this.gbType.Text = "Type";
            // 
            // rbF7
            // 
            this.rbF7.AutoSize = true;
            this.rbF7.Location = new System.Drawing.Point(13, 57);
            this.rbF7.Name = "rbF7";
            this.rbF7.Size = new System.Drawing.Size(90, 21);
            this.rbF7.TabIndex = 5;
            this.rbF7.TabStop = true;
            this.rbF7.Text = "STM32F7";
            this.rbF7.UseVisualStyleBackColor = true;
            this.rbF7.CheckedChanged += new System.EventHandler(this.rbF7_CheckedChanged);
            // 
            // rbF1
            // 
            this.rbF1.AutoSize = true;
            this.rbF1.Checked = true;
            this.rbF1.Location = new System.Drawing.Point(13, 31);
            this.rbF1.Name = "rbF1";
            this.rbF1.Size = new System.Drawing.Size(90, 21);
            this.rbF1.TabIndex = 4;
            this.rbF1.TabStop = true;
            this.rbF1.Text = "STM32F1";
            this.rbF1.UseVisualStyleBackColor = true;
            this.rbF1.CheckedChanged += new System.EventHandler(this.rbF1_CheckedChanged);
            // 
            // gbActionSelect
            // 
            this.gbActionSelect.Controls.Add(this.rbReset);
            this.gbActionSelect.Controls.Add(this.rbPin);
            this.gbActionSelect.Controls.Add(this.rbReadDisk);
            this.gbActionSelect.Controls.Add(this.rbUpdateFirmware);
            this.gbActionSelect.Controls.Add(this.rbSetDelays);
            this.gbActionSelect.Controls.Add(this.rbWriteDisk);
            this.gbActionSelect.Location = new System.Drawing.Point(22, 121);
            this.gbActionSelect.Name = "gbActionSelect";
            this.gbActionSelect.Size = new System.Drawing.Size(357, 106);
            this.gbActionSelect.TabIndex = 6;
            this.gbActionSelect.TabStop = false;
            this.gbActionSelect.Text = "Action";
            // 
            // rbReset
            // 
            this.rbReset.AutoSize = true;
            this.rbReset.Location = new System.Drawing.Point(183, 72);
            this.rbReset.Name = "rbReset";
            this.rbReset.Size = new System.Drawing.Size(113, 21);
            this.rbReset.TabIndex = 12;
            this.rbReset.TabStop = true;
            this.rbReset.Text = "Reset Device";
            this.rbReset.UseVisualStyleBackColor = true;
            this.rbReset.CheckedChanged += new System.EventHandler(this.rbReset_CheckedChanged);
            // 
            // rbPin
            // 
            this.rbPin.AutoSize = true;
            this.rbPin.Location = new System.Drawing.Point(183, 48);
            this.rbPin.Name = "rbPin";
            this.rbPin.Size = new System.Drawing.Size(87, 21);
            this.rbPin.TabIndex = 11;
            this.rbPin.TabStop = true;
            this.rbPin.Text = "Pin Level";
            this.rbPin.UseVisualStyleBackColor = true;
            this.rbPin.CheckedChanged += new System.EventHandler(this.rbPin_CheckedChanged);
            // 
            // rbReadDisk
            // 
            this.rbReadDisk.AutoSize = true;
            this.rbReadDisk.Location = new System.Drawing.Point(25, 21);
            this.rbReadDisk.Name = "rbReadDisk";
            this.rbReadDisk.Size = new System.Drawing.Size(126, 21);
            this.rbReadDisk.TabIndex = 7;
            this.rbReadDisk.TabStop = true;
            this.rbReadDisk.Text = "Read from Disk";
            this.rbReadDisk.UseVisualStyleBackColor = true;
            this.rbReadDisk.CheckedChanged += new System.EventHandler(this.rbReadDisk_CheckedChanged);
            // 
            // rbUpdateFirmware
            // 
            this.rbUpdateFirmware.AutoSize = true;
            this.rbUpdateFirmware.Location = new System.Drawing.Point(183, 21);
            this.rbUpdateFirmware.Name = "rbUpdateFirmware";
            this.rbUpdateFirmware.Size = new System.Drawing.Size(136, 21);
            this.rbUpdateFirmware.TabIndex = 10;
            this.rbUpdateFirmware.TabStop = true;
            this.rbUpdateFirmware.Text = "Update Firmware";
            this.rbUpdateFirmware.UseVisualStyleBackColor = true;
            this.rbUpdateFirmware.CheckedChanged += new System.EventHandler(this.rbUpdateFirmware_CheckedChanged);
            // 
            // rbSetDelays
            // 
            this.rbSetDelays.AutoSize = true;
            this.rbSetDelays.Location = new System.Drawing.Point(25, 72);
            this.rbSetDelays.Name = "rbSetDelays";
            this.rbSetDelays.Size = new System.Drawing.Size(97, 21);
            this.rbSetDelays.TabIndex = 9;
            this.rbSetDelays.TabStop = true;
            this.rbSetDelays.Text = "Set Delays";
            this.rbSetDelays.UseVisualStyleBackColor = true;
            this.rbSetDelays.CheckedChanged += new System.EventHandler(this.rbSetDelays_CheckedChanged);
            // 
            // rbWriteDisk
            // 
            this.rbWriteDisk.AutoSize = true;
            this.rbWriteDisk.Location = new System.Drawing.Point(25, 48);
            this.rbWriteDisk.Name = "rbWriteDisk";
            this.rbWriteDisk.Size = new System.Drawing.Size(109, 21);
            this.rbWriteDisk.TabIndex = 8;
            this.rbWriteDisk.TabStop = true;
            this.rbWriteDisk.Text = "Write to Disk";
            this.rbWriteDisk.UseVisualStyleBackColor = true;
            this.rbWriteDisk.CheckedChanged += new System.EventHandler(this.rbWriteDisk_CheckedChanged);
            // 
            // pbGWsmall
            // 
            this.pbGWsmall.Image = ((System.Drawing.Image)(resources.GetObject("pbGWsmall.Image")));
            this.pbGWsmall.Location = new System.Drawing.Point(22, 21);
            this.pbGWsmall.Name = "pbGWsmall";
            this.pbGWsmall.Size = new System.Drawing.Size(235, 94);
            this.pbGWsmall.TabIndex = 10;
            this.pbGWsmall.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettings,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSettings
            // 
            this.mnuSettings.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUSBSupport});
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(74, 24);
            this.mnuSettings.Text = "Settings";
            // 
            // mnuUSBSupport
            // 
            this.mnuUSBSupport.Name = "mnuUSBSupport";
            this.mnuUSBSupport.Size = new System.Drawing.Size(217, 26);
            this.mnuUSBSupport.Text = "Enable USB Support";
            this.mnuUSBSupport.CheckedChanged += new System.EventHandler(this.mnuUSBSupport_CheckChanged);
            this.mnuUSBSupport.Click += new System.EventHandler(this.mnuUSBSupport_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ChooserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 492);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ChooserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Action";
            this.gbAction.ResumeLayout(false);
            this.gbUSBPorts.ResumeLayout(false);
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbActionSelect.ResumeLayout(false);
            this.gbActionSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGWsmall)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbF7;
        private System.Windows.Forms.RadioButton rbF1;
        private System.Windows.Forms.GroupBox gbActionSelect;
        private System.Windows.Forms.RadioButton rbReadDisk;
        private System.Windows.Forms.RadioButton rbUpdateFirmware;
        private System.Windows.Forms.RadioButton rbSetDelays;
        private System.Windows.Forms.RadioButton rbWriteDisk;
        private System.Windows.Forms.PictureBox pbGWsmall;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbUSBPorts;
        private System.Windows.Forms.Button btnRefreshUSB;
        private System.Windows.Forms.ListBox lbUSBPorts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuUSBSupport;
        private System.Windows.Forms.RadioButton rbReset;
        private System.Windows.Forms.RadioButton rbPin;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}