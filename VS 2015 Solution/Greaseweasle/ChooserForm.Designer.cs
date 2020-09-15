// ChooserForm.Designer.cs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooserForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuProfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUSBSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowsEXE = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipChooser = new System.Windows.Forms.ToolTip(this.components);
            this.rbSetDelays = new System.Windows.Forms.RadioButton();
            this.rbPin = new System.Windows.Forms.RadioButton();
            this.rbReset = new System.Windows.Forms.RadioButton();
            this.rbBandwidth = new System.Windows.Forms.RadioButton();
            this.rbEraseDisk = new System.Windows.Forms.RadioButton();
            this.rbInfo = new System.Windows.Forms.RadioButton();
            this.rbF7 = new System.Windows.Forms.RadioButton();
            this.rbSeekCyl = new System.Windows.Forms.RadioButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbGWsmall = new System.Windows.Forms.PictureBox();
            this.gbActionSelect = new System.Windows.Forms.GroupBox();
            this.rbReadDisk = new System.Windows.Forms.RadioButton();
            this.rbUpdateFirmware = new System.Windows.Forms.RadioButton();
            this.rbWriteDisk = new System.Windows.Forms.RadioButton();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbF1 = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.gbUSBPorts = new System.Windows.Forms.GroupBox();
            this.chkLegacyUSB = new System.Windows.Forms.CheckBox();
            this.btnRefreshUSB = new System.Windows.Forms.Button();
            this.lbUSBPorts = new System.Windows.Forms.ListBox();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGWsmall)).BeginInit();
            this.gbActionSelect.SuspendLayout();
            this.gbType.SuspendLayout();
            this.gbUSBPorts.SuspendLayout();
            this.gbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfiles,
            this.mnuInfo,
            this.mnuSettings,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(488, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.toolTipChooser.SetToolTip(this.menuStrip1, "Click me for more information");
            // 
            // mnuProfiles
            // 
            this.mnuProfiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfileNew,
            this.mnuDelete});
            this.mnuProfiles.Name = "mnuProfiles";
            this.mnuProfiles.Size = new System.Drawing.Size(76, 25);
            this.mnuProfiles.Text = "Profiles";
            // 
            // mnuProfileNew
            // 
            this.mnuProfileNew.Name = "mnuProfileNew";
            this.mnuProfileNew.Size = new System.Drawing.Size(153, 30);
            this.mnuProfileNew.Text = "-New-";
            this.mnuProfileNew.Click += new System.EventHandler(this.mnuProfileNew_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(153, 30);
            this.mnuDelete.Text = "-Delete-";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuInfo
            // 
            this.mnuInfo.Name = "mnuInfo";
            this.mnuInfo.Size = new System.Drawing.Size(51, 25);
            this.mnuInfo.Text = "Info";
            this.mnuInfo.Click += new System.EventHandler(this.mnuInfo_Click);
            // 
            // mnuSettings
            // 
            this.mnuSettings.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUSBSupport,
            this.mnuWindowsEXE});
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(82, 25);
            this.mnuSettings.Text = "Settings";
            // 
            // mnuUSBSupport
            // 
            this.mnuUSBSupport.Name = "mnuUSBSupport";
            this.mnuUSBSupport.Size = new System.Drawing.Size(283, 30);
            this.mnuUSBSupport.Text = "Enable USB Support";
            this.mnuUSBSupport.ToolTipText = "Required for Host Tools earlier than v0.11";
            this.mnuUSBSupport.CheckedChanged += new System.EventHandler(this.mnuUSBSupport_CheckChanged);
            this.mnuUSBSupport.Click += new System.EventHandler(this.mnuUSBSupport_Click);
            // 
            // mnuWindowsEXE
            // 
            this.mnuWindowsEXE.Name = "mnuWindowsEXE";
            this.mnuWindowsEXE.Size = new System.Drawing.Size(283, 30);
            this.mnuWindowsEXE.Text = "Self-contained Executable";
            this.mnuWindowsEXE.ToolTipText = "Host Tools v0.17 or later";
            this.mnuWindowsEXE.Click += new System.EventHandler(this.mnuWindowsEXE_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rbSetDelays
            // 
            this.rbSetDelays.AutoSize = true;
            this.rbSetDelays.Location = new System.Drawing.Point(40, 128);
            this.rbSetDelays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSetDelays.Name = "rbSetDelays";
            this.rbSetDelays.Size = new System.Drawing.Size(110, 24);
            this.rbSetDelays.TabIndex = 10;
            this.rbSetDelays.TabStop = true;
            this.rbSetDelays.Text = "Set Delays";
            this.toolTipChooser.SetToolTip(this.rbSetDelays, "Host Tools v0.06 or later");
            this.rbSetDelays.UseVisualStyleBackColor = true;
            this.rbSetDelays.CheckedChanged += new System.EventHandler(this.rbSetDelays_CheckedChanged);
            // 
            // rbPin
            // 
            this.rbPin.AutoSize = true;
            this.rbPin.Location = new System.Drawing.Point(218, 60);
            this.rbPin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbPin.Name = "rbPin";
            this.rbPin.Size = new System.Drawing.Size(96, 24);
            this.rbPin.TabIndex = 12;
            this.rbPin.TabStop = true;
            this.rbPin.Text = "Pin Level";
            this.toolTipChooser.SetToolTip(this.rbPin, "Host Tools v0.12 or later");
            this.rbPin.UseVisualStyleBackColor = true;
            this.rbPin.CheckedChanged += new System.EventHandler(this.rbPin_CheckedChanged);
            // 
            // rbReset
            // 
            this.rbReset.AutoSize = true;
            this.rbReset.Location = new System.Drawing.Point(218, 94);
            this.rbReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbReset.Name = "rbReset";
            this.rbReset.Size = new System.Drawing.Size(128, 24);
            this.rbReset.TabIndex = 13;
            this.rbReset.TabStop = true;
            this.rbReset.Text = "Reset Device";
            this.toolTipChooser.SetToolTip(this.rbReset, "Host Tools v0.12 or later");
            this.rbReset.UseVisualStyleBackColor = true;
            this.rbReset.CheckedChanged += new System.EventHandler(this.rbReset_CheckedChanged);
            // 
            // rbBandwidth
            // 
            this.rbBandwidth.AutoSize = true;
            this.rbBandwidth.Location = new System.Drawing.Point(218, 128);
            this.rbBandwidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbBandwidth.Name = "rbBandwidth";
            this.rbBandwidth.Size = new System.Drawing.Size(174, 24);
            this.rbBandwidth.TabIndex = 14;
            this.rbBandwidth.TabStop = true;
            this.rbBandwidth.Text = "Measure Bandwidth";
            this.toolTipChooser.SetToolTip(this.rbBandwidth, "Host Tools v0.14 or later");
            this.rbBandwidth.UseVisualStyleBackColor = true;
            this.rbBandwidth.CheckedChanged += new System.EventHandler(this.rbBandwidth_CheckedChanged);
            // 
            // rbEraseDisk
            // 
            this.rbEraseDisk.AutoSize = true;
            this.rbEraseDisk.Location = new System.Drawing.Point(40, 94);
            this.rbEraseDisk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbEraseDisk.Name = "rbEraseDisk";
            this.rbEraseDisk.Size = new System.Drawing.Size(110, 24);
            this.rbEraseDisk.TabIndex = 9;
            this.rbEraseDisk.TabStop = true;
            this.rbEraseDisk.Text = "Erase Disk";
            this.toolTipChooser.SetToolTip(this.rbEraseDisk, "Host Tools v0.14 or later");
            this.rbEraseDisk.UseVisualStyleBackColor = true;
            this.rbEraseDisk.CheckedChanged += new System.EventHandler(this.rbErase_CheckedChanged);
            // 
            // rbInfo
            // 
            this.rbInfo.AutoSize = true;
            this.rbInfo.Location = new System.Drawing.Point(218, 161);
            this.rbInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbInfo.Name = "rbInfo";
            this.rbInfo.Size = new System.Drawing.Size(130, 24);
            this.rbInfo.TabIndex = 16;
            this.rbInfo.TabStop = true;
            this.rbInfo.Text = "Info on Setup";
            this.toolTipChooser.SetToolTip(this.rbInfo, "Host Tools v0.18 or later");
            this.rbInfo.UseVisualStyleBackColor = true;
            this.rbInfo.CheckedChanged += new System.EventHandler(this.rbInfo_CheckedChanged);
            // 
            // rbF7
            // 
            this.rbF7.AutoSize = true;
            this.rbF7.Location = new System.Drawing.Point(15, 71);
            this.rbF7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbF7.Name = "rbF7";
            this.rbF7.Size = new System.Drawing.Size(103, 24);
            this.rbF7.TabIndex = 5;
            this.rbF7.TabStop = true;
            this.rbF7.Text = "STM32F7";
            this.toolTipChooser.SetToolTip(this.rbF7, "Host Tools v0.07 or later");
            this.rbF7.UseVisualStyleBackColor = true;
            this.rbF7.CheckedChanged += new System.EventHandler(this.rbF7_CheckedChanged);
            // 
            // rbSeekCyl
            // 
            this.rbSeekCyl.AutoSize = true;
            this.rbSeekCyl.Location = new System.Drawing.Point(40, 161);
            this.rbSeekCyl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSeekCyl.Name = "rbSeekCyl";
            this.rbSeekCyl.Size = new System.Drawing.Size(130, 24);
            this.rbSeekCyl.TabIndex = 15;
            this.rbSeekCyl.TabStop = true;
            this.rbSeekCyl.Text = "Seek Cylinder";
            this.toolTipChooser.SetToolTip(this.rbSeekCyl, "Host Tools v0.21 or later");
            this.rbSeekCyl.UseVisualStyleBackColor = true;
            this.rbSeekCyl.CheckedChanged += new System.EventHandler(this.rbSeekCyl_CheckedChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 717);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(488, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.Stretch = false;
            this.statusStrip.TabIndex = 4;
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel.ToolTipText = "Click me for more infomation";
            // 
            // pbGWsmall
            // 
            this.pbGWsmall.Image = ((System.Drawing.Image)(resources.GetObject("pbGWsmall.Image")));
            this.pbGWsmall.Location = new System.Drawing.Point(25, 26);
            this.pbGWsmall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbGWsmall.Name = "pbGWsmall";
            this.pbGWsmall.Size = new System.Drawing.Size(264, 118);
            this.pbGWsmall.TabIndex = 10;
            this.pbGWsmall.TabStop = false;
            // 
            // gbActionSelect
            // 
            this.gbActionSelect.Controls.Add(this.rbSeekCyl);
            this.gbActionSelect.Controls.Add(this.rbInfo);
            this.gbActionSelect.Controls.Add(this.rbEraseDisk);
            this.gbActionSelect.Controls.Add(this.rbBandwidth);
            this.gbActionSelect.Controls.Add(this.rbReset);
            this.gbActionSelect.Controls.Add(this.rbPin);
            this.gbActionSelect.Controls.Add(this.rbReadDisk);
            this.gbActionSelect.Controls.Add(this.rbUpdateFirmware);
            this.gbActionSelect.Controls.Add(this.rbSetDelays);
            this.gbActionSelect.Controls.Add(this.rbWriteDisk);
            this.gbActionSelect.Location = new System.Drawing.Point(25, 151);
            this.gbActionSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbActionSelect.Name = "gbActionSelect";
            this.gbActionSelect.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbActionSelect.Size = new System.Drawing.Size(413, 204);
            this.gbActionSelect.TabIndex = 6;
            this.gbActionSelect.TabStop = false;
            this.gbActionSelect.Text = "Action";
            // 
            // rbReadDisk
            // 
            this.rbReadDisk.AutoSize = true;
            this.rbReadDisk.Location = new System.Drawing.Point(40, 26);
            this.rbReadDisk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbReadDisk.Name = "rbReadDisk";
            this.rbReadDisk.Size = new System.Drawing.Size(143, 24);
            this.rbReadDisk.TabIndex = 7;
            this.rbReadDisk.TabStop = true;
            this.rbReadDisk.Text = "Read from Disk";
            this.rbReadDisk.UseVisualStyleBackColor = true;
            this.rbReadDisk.CheckedChanged += new System.EventHandler(this.rbReadDisk_CheckedChanged);
            // 
            // rbUpdateFirmware
            // 
            this.rbUpdateFirmware.AutoSize = true;
            this.rbUpdateFirmware.Location = new System.Drawing.Point(218, 26);
            this.rbUpdateFirmware.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbUpdateFirmware.Name = "rbUpdateFirmware";
            this.rbUpdateFirmware.Size = new System.Drawing.Size(155, 24);
            this.rbUpdateFirmware.TabIndex = 11;
            this.rbUpdateFirmware.TabStop = true;
            this.rbUpdateFirmware.Text = "Update Firmware";
            this.rbUpdateFirmware.UseVisualStyleBackColor = true;
            this.rbUpdateFirmware.CheckedChanged += new System.EventHandler(this.rbUpdateFirmware_CheckedChanged);
            // 
            // rbWriteDisk
            // 
            this.rbWriteDisk.AutoSize = true;
            this.rbWriteDisk.Location = new System.Drawing.Point(40, 60);
            this.rbWriteDisk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbWriteDisk.Name = "rbWriteDisk";
            this.rbWriteDisk.Size = new System.Drawing.Size(123, 24);
            this.rbWriteDisk.TabIndex = 8;
            this.rbWriteDisk.TabStop = true;
            this.rbWriteDisk.Text = "Write to Disk";
            this.rbWriteDisk.UseVisualStyleBackColor = true;
            this.rbWriteDisk.CheckedChanged += new System.EventHandler(this.rbWriteDisk_CheckedChanged);
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbF7);
            this.gbType.Controls.Add(this.rbF1);
            this.gbType.Location = new System.Drawing.Point(303, 20);
            this.gbType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbType.Name = "gbType";
            this.gbType.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbType.Size = new System.Drawing.Size(135, 122);
            this.gbType.TabIndex = 3;
            this.gbType.TabStop = false;
            this.gbType.Text = "Type";
            // 
            // rbF1
            // 
            this.rbF1.AutoSize = true;
            this.rbF1.Checked = true;
            this.rbF1.Location = new System.Drawing.Point(15, 39);
            this.rbF1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbF1.Name = "rbF1";
            this.rbF1.Size = new System.Drawing.Size(103, 24);
            this.rbF1.TabIndex = 4;
            this.rbF1.TabStop = true;
            this.rbF1.Text = "STM32F1";
            this.rbF1.UseVisualStyleBackColor = true;
            this.rbF1.CheckedChanged += new System.EventHandler(this.rbF1_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(270, 586);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 36);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(70, 586);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(122, 36);
            this.btnSelect.TabIndex = 21;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gbUSBPorts
            // 
            this.gbUSBPorts.Controls.Add(this.chkLegacyUSB);
            this.gbUSBPorts.Controls.Add(this.btnRefreshUSB);
            this.gbUSBPorts.Controls.Add(this.lbUSBPorts);
            this.gbUSBPorts.Location = new System.Drawing.Point(25, 362);
            this.gbUSBPorts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUSBPorts.Name = "gbUSBPorts";
            this.gbUSBPorts.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUSBPorts.Size = new System.Drawing.Size(413, 208);
            this.gbUSBPorts.TabIndex = 17;
            this.gbUSBPorts.TabStop = false;
            this.gbUSBPorts.Text = "USB Ports";
            // 
            // chkLegacyUSB
            // 
            this.chkLegacyUSB.AutoSize = true;
            this.chkLegacyUSB.Location = new System.Drawing.Point(45, 157);
            this.chkLegacyUSB.Name = "chkLegacyUSB";
            this.chkLegacyUSB.Size = new System.Drawing.Size(85, 24);
            this.chkLegacyUSB.TabIndex = 19;
            this.chkLegacyUSB.Text = "Legacy";
            this.chkLegacyUSB.UseVisualStyleBackColor = true;
            this.chkLegacyUSB.CheckedChanged += new System.EventHandler(this.chkLegacyUSB_CheckedChanged);
            // 
            // btnRefreshUSB
            // 
            this.btnRefreshUSB.Location = new System.Drawing.Point(245, 151);
            this.btnRefreshUSB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshUSB.Name = "btnRefreshUSB";
            this.btnRefreshUSB.Size = new System.Drawing.Size(122, 36);
            this.btnRefreshUSB.TabIndex = 20;
            this.btnRefreshUSB.Text = "Refresh";
            this.btnRefreshUSB.UseVisualStyleBackColor = true;
            this.btnRefreshUSB.Click += new System.EventHandler(this.btnRefreshUSB_Click);
            // 
            // lbUSBPorts
            // 
            this.lbUSBPorts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbUSBPorts.FormattingEnabled = true;
            this.lbUSBPorts.ItemHeight = 20;
            this.lbUSBPorts.Location = new System.Drawing.Point(26, 32);
            this.lbUSBPorts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbUSBPorts.Name = "lbUSBPorts";
            this.lbUSBPorts.Size = new System.Drawing.Size(360, 104);
            this.lbUSBPorts.TabIndex = 18;
            this.lbUSBPorts.SelectedIndexChanged += new System.EventHandler(this.lbUSBPorts_SelectedIndexChanged);
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.gbUSBPorts);
            this.gbAction.Controls.Add(this.btnSelect);
            this.gbAction.Controls.Add(this.btnClose);
            this.gbAction.Controls.Add(this.gbType);
            this.gbAction.Controls.Add(this.gbActionSelect);
            this.gbAction.Controls.Add(this.pbGWsmall);
            this.gbAction.Location = new System.Drawing.Point(14, 36);
            this.gbAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAction.Name = "gbAction";
            this.gbAction.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAction.Size = new System.Drawing.Size(461, 651);
            this.gbAction.TabIndex = 1;
            this.gbAction.TabStop = false;
            // 
            // ChooserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 739);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ChooserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Action";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGWsmall)).EndInit();
            this.gbActionSelect.ResumeLayout(false);
            this.gbActionSelect.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbUSBPorts.ResumeLayout(false);
            this.gbUSBPorts.PerformLayout();
            this.gbAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuUSBSupport;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipChooser;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowsEXE;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem mnuInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuProfiles;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.PictureBox pbGWsmall;
        private System.Windows.Forms.GroupBox gbActionSelect;
        private System.Windows.Forms.RadioButton rbInfo;
        private System.Windows.Forms.RadioButton rbEraseDisk;
        private System.Windows.Forms.RadioButton rbBandwidth;
        private System.Windows.Forms.RadioButton rbReset;
        private System.Windows.Forms.RadioButton rbPin;
        private System.Windows.Forms.RadioButton rbReadDisk;
        private System.Windows.Forms.RadioButton rbUpdateFirmware;
        private System.Windows.Forms.RadioButton rbSetDelays;
        private System.Windows.Forms.RadioButton rbWriteDisk;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbF7;
        private System.Windows.Forms.RadioButton rbF1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox gbUSBPorts;
        private System.Windows.Forms.CheckBox chkLegacyUSB;
        private System.Windows.Forms.Button btnRefreshUSB;
        private System.Windows.Forms.ListBox lbUSBPorts;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.RadioButton rbSeekCyl;
    }
}