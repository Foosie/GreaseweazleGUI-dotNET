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
            this.mnuElapsedTime = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipChooser = new System.Windows.Forms.ToolTip(this.components);
            this.rbSetDelays = new System.Windows.Forms.RadioButton();
            this.rbPin = new System.Windows.Forms.RadioButton();
            this.rbReset = new System.Windows.Forms.RadioButton();
            this.rbBandwidth = new System.Windows.Forms.RadioButton();
            this.rbEraseDisk = new System.Windows.Forms.RadioButton();
            this.rbInfo = new System.Windows.Forms.RadioButton();
            this.rbSeekCyl = new System.Windows.Forms.RadioButton();
            this.pbGWsmall = new System.Windows.Forms.PictureBox();
            this.rbCleanHeads = new System.Windows.Forms.RadioButton();
            this.gbActionSelect = new System.Windows.Forms.GroupBox();
            this.rbReadDisk = new System.Windows.Forms.RadioButton();
            this.rbUpdateFirmware = new System.Windows.Forms.RadioButton();
            this.rbWriteDisk = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.gbUSBPorts = new System.Windows.Forms.GroupBox();
            this.btnRefreshUSB = new System.Windows.Forms.Button();
            this.lbUSBPorts = new System.Windows.Forms.ListBox();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.lblHostTools = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGWsmall)).BeginInit();
            this.gbActionSelect.SuspendLayout();
            this.gbUSBPorts.SuspendLayout();
            this.gbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfiles,
            this.mnuInfo,
            this.mnuSettings,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.toolTipChooser.SetToolTip(this.menuStrip1, "Click me for more information");
            // 
            // mnuProfiles
            // 
            this.mnuProfiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfileNew,
            this.mnuDelete});
            this.mnuProfiles.ForeColor = System.Drawing.Color.White;
            this.mnuProfiles.Name = "mnuProfiles";
            this.mnuProfiles.Size = new System.Drawing.Size(70, 24);
            this.mnuProfiles.Text = "Profiles";
            // 
            // mnuProfileNew
            // 
            this.mnuProfileNew.BackColor = System.Drawing.SystemColors.Control;
            this.mnuProfileNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mnuProfileNew.Name = "mnuProfileNew";
            this.mnuProfileNew.Size = new System.Drawing.Size(140, 26);
            this.mnuProfileNew.Text = "-New-";
            this.mnuProfileNew.Click += new System.EventHandler(this.mnuProfileNew_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.BackColor = System.Drawing.SystemColors.Control;
            this.mnuDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(140, 26);
            this.mnuDelete.Text = "-Delete-";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuInfo
            // 
            this.mnuInfo.ForeColor = System.Drawing.Color.White;
            this.mnuInfo.Name = "mnuInfo";
            this.mnuInfo.Size = new System.Drawing.Size(47, 24);
            this.mnuInfo.Text = "Info";
            this.mnuInfo.Click += new System.EventHandler(this.mnuInfo_Click);
            // 
            // mnuSettings
            // 
            this.mnuSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUSBSupport,
            this.mnuWindowsEXE,
            this.mnuElapsedTime});
            this.mnuSettings.ForeColor = System.Drawing.Color.White;
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(71, 24);
            this.mnuSettings.Text = "Globals";
            // 
            // mnuUSBSupport
            // 
            this.mnuUSBSupport.Name = "mnuUSBSupport";
            this.mnuUSBSupport.Size = new System.Drawing.Size(257, 26);
            this.mnuUSBSupport.Text = "Enable USB Support";
            this.mnuUSBSupport.ToolTipText = "Required for Host Tools earlier than v0.11";
            this.mnuUSBSupport.CheckedChanged += new System.EventHandler(this.mnuUSBSupport_CheckChanged);
            this.mnuUSBSupport.Click += new System.EventHandler(this.mnuUSBSupport_Click);
            // 
            // mnuWindowsEXE
            // 
            this.mnuWindowsEXE.Name = "mnuWindowsEXE";
            this.mnuWindowsEXE.Size = new System.Drawing.Size(257, 26);
            this.mnuWindowsEXE.Text = "Self-contained Executable";
            this.mnuWindowsEXE.ToolTipText = "Host Tools v0.17 or later";
            this.mnuWindowsEXE.Click += new System.EventHandler(this.mnuWindowsEXE_Click);
            // 
            // mnuElapsedTime
            // 
            this.mnuElapsedTime.Name = "mnuElapsedTime";
            this.mnuElapsedTime.Size = new System.Drawing.Size(257, 26);
            this.mnuElapsedTime.Text = "Elapsed Time";
            this.mnuElapsedTime.Click += new System.EventHandler(this.mnuElapsedTime_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rbSetDelays
            // 
            this.rbSetDelays.AutoSize = true;
            this.rbSetDelays.Location = new System.Drawing.Point(342, 48);
            this.rbSetDelays.Name = "rbSetDelays";
            this.rbSetDelays.Size = new System.Drawing.Size(97, 21);
            this.rbSetDelays.TabIndex = 12;
            this.rbSetDelays.TabStop = true;
            this.rbSetDelays.Text = "Set Delays";
            this.toolTipChooser.SetToolTip(this.rbSetDelays, "Host Tools v0.06 or later");
            this.rbSetDelays.UseVisualStyleBackColor = true;
            this.rbSetDelays.CheckedChanged += new System.EventHandler(this.rbSetDelays_CheckedChanged);
            // 
            // rbPin
            // 
            this.rbPin.AutoSize = true;
            this.rbPin.Location = new System.Drawing.Point(173, 75);
            this.rbPin.Name = "rbPin";
            this.rbPin.Size = new System.Drawing.Size(87, 21);
            this.rbPin.TabIndex = 9;
            this.rbPin.TabStop = true;
            this.rbPin.Text = "Pin Level";
            this.toolTipChooser.SetToolTip(this.rbPin, "Host Tools v0.12 or later");
            this.rbPin.UseVisualStyleBackColor = true;
            this.rbPin.CheckedChanged += new System.EventHandler(this.rbPin_CheckedChanged);
            // 
            // rbReset
            // 
            this.rbReset.AutoSize = true;
            this.rbReset.Location = new System.Drawing.Point(173, 102);
            this.rbReset.Name = "rbReset";
            this.rbReset.Size = new System.Drawing.Size(113, 21);
            this.rbReset.TabIndex = 10;
            this.rbReset.TabStop = true;
            this.rbReset.Text = "Reset Device";
            this.toolTipChooser.SetToolTip(this.rbReset, "Host Tools v0.12 or later");
            this.rbReset.UseVisualStyleBackColor = true;
            this.rbReset.CheckedChanged += new System.EventHandler(this.rbReset_CheckedChanged);
            // 
            // rbBandwidth
            // 
            this.rbBandwidth.AutoSize = true;
            this.rbBandwidth.Location = new System.Drawing.Point(173, 48);
            this.rbBandwidth.Name = "rbBandwidth";
            this.rbBandwidth.Size = new System.Drawing.Size(153, 21);
            this.rbBandwidth.TabIndex = 8;
            this.rbBandwidth.TabStop = true;
            this.rbBandwidth.Text = "Measure Bandwidth";
            this.toolTipChooser.SetToolTip(this.rbBandwidth, "Host Tools v0.14 or later");
            this.rbBandwidth.UseVisualStyleBackColor = true;
            this.rbBandwidth.CheckedChanged += new System.EventHandler(this.rbBandwidth_CheckedChanged);
            // 
            // rbEraseDisk
            // 
            this.rbEraseDisk.AutoSize = true;
            this.rbEraseDisk.Location = new System.Drawing.Point(36, 102);
            this.rbEraseDisk.Name = "rbEraseDisk";
            this.rbEraseDisk.Size = new System.Drawing.Size(97, 21);
            this.rbEraseDisk.TabIndex = 6;
            this.rbEraseDisk.TabStop = true;
            this.rbEraseDisk.Text = "Erase Disk";
            this.toolTipChooser.SetToolTip(this.rbEraseDisk, "Host Tools v0.14 or later");
            this.rbEraseDisk.UseVisualStyleBackColor = true;
            this.rbEraseDisk.CheckedChanged += new System.EventHandler(this.rbErase_CheckedChanged);
            // 
            // rbInfo
            // 
            this.rbInfo.AutoSize = true;
            this.rbInfo.Location = new System.Drawing.Point(173, 21);
            this.rbInfo.Name = "rbInfo";
            this.rbInfo.Size = new System.Drawing.Size(113, 21);
            this.rbInfo.TabIndex = 7;
            this.rbInfo.TabStop = true;
            this.rbInfo.Text = "Info on Setup";
            this.toolTipChooser.SetToolTip(this.rbInfo, "Host Tools v0.18 or later");
            this.rbInfo.UseVisualStyleBackColor = true;
            this.rbInfo.CheckedChanged += new System.EventHandler(this.rbInfo_CheckedChanged);
            // 
            // rbSeekCyl
            // 
            this.rbSeekCyl.AutoSize = true;
            this.rbSeekCyl.Location = new System.Drawing.Point(342, 21);
            this.rbSeekCyl.Name = "rbSeekCyl";
            this.rbSeekCyl.Size = new System.Drawing.Size(116, 21);
            this.rbSeekCyl.TabIndex = 11;
            this.rbSeekCyl.TabStop = true;
            this.rbSeekCyl.Text = "Seek Cylinder";
            this.toolTipChooser.SetToolTip(this.rbSeekCyl, "Host Tools v0.21 or later");
            this.rbSeekCyl.UseVisualStyleBackColor = true;
            this.rbSeekCyl.CheckedChanged += new System.EventHandler(this.rbSeekCyl_CheckedChanged);
            // 
            // pbGWsmall
            // 
            this.pbGWsmall.Image = ((System.Drawing.Image)(resources.GetObject("pbGWsmall.Image")));
            this.pbGWsmall.Location = new System.Drawing.Point(95, 21);
            this.pbGWsmall.Name = "pbGWsmall";
            this.pbGWsmall.Size = new System.Drawing.Size(366, 146);
            this.pbGWsmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGWsmall.TabIndex = 10;
            this.pbGWsmall.TabStop = false;
            this.toolTipChooser.SetToolTip(this.pbGWsmall, "Click Me");
            this.pbGWsmall.Click += new System.EventHandler(this.pbGWsmall_Click);
            // 
            // rbCleanHeads
            // 
            this.rbCleanHeads.AutoSize = true;
            this.rbCleanHeads.Location = new System.Drawing.Point(35, 75);
            this.rbCleanHeads.Name = "rbCleanHeads";
            this.rbCleanHeads.Size = new System.Drawing.Size(110, 21);
            this.rbCleanHeads.TabIndex = 5;
            this.rbCleanHeads.TabStop = true;
            this.rbCleanHeads.Text = "Clean Heads";
            this.toolTipChooser.SetToolTip(this.rbCleanHeads, "Host Tools v0.18 or later");
            this.rbCleanHeads.UseVisualStyleBackColor = true;
            this.rbCleanHeads.CheckedChanged += new System.EventHandler(this.rbCleanHeads_CheckedChanged);
            // 
            // gbActionSelect
            // 
            this.gbActionSelect.Controls.Add(this.rbCleanHeads);
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
            this.gbActionSelect.ForeColor = System.Drawing.Color.White;
            this.gbActionSelect.Location = new System.Drawing.Point(24, 176);
            this.gbActionSelect.Name = "gbActionSelect";
            this.gbActionSelect.Size = new System.Drawing.Size(510, 137);
            this.gbActionSelect.TabIndex = 2;
            this.gbActionSelect.TabStop = false;
            this.gbActionSelect.Text = "Action";
            // 
            // rbReadDisk
            // 
            this.rbReadDisk.AutoSize = true;
            this.rbReadDisk.Location = new System.Drawing.Point(36, 21);
            this.rbReadDisk.Name = "rbReadDisk";
            this.rbReadDisk.Size = new System.Drawing.Size(126, 21);
            this.rbReadDisk.TabIndex = 3;
            this.rbReadDisk.TabStop = true;
            this.rbReadDisk.Text = "Read from Disk";
            this.rbReadDisk.UseVisualStyleBackColor = true;
            this.rbReadDisk.CheckedChanged += new System.EventHandler(this.rbReadDisk_CheckedChanged);
            // 
            // rbUpdateFirmware
            // 
            this.rbUpdateFirmware.AutoSize = true;
            this.rbUpdateFirmware.Location = new System.Drawing.Point(342, 75);
            this.rbUpdateFirmware.Name = "rbUpdateFirmware";
            this.rbUpdateFirmware.Size = new System.Drawing.Size(136, 21);
            this.rbUpdateFirmware.TabIndex = 13;
            this.rbUpdateFirmware.TabStop = true;
            this.rbUpdateFirmware.Text = "Update Firmware";
            this.rbUpdateFirmware.UseVisualStyleBackColor = true;
            this.rbUpdateFirmware.CheckedChanged += new System.EventHandler(this.rbUpdateFirmware_CheckedChanged);
            // 
            // rbWriteDisk
            // 
            this.rbWriteDisk.AutoSize = true;
            this.rbWriteDisk.Location = new System.Drawing.Point(36, 48);
            this.rbWriteDisk.Name = "rbWriteDisk";
            this.rbWriteDisk.Size = new System.Drawing.Size(109, 21);
            this.rbWriteDisk.TabIndex = 4;
            this.rbWriteDisk.TabStop = true;
            this.rbWriteDisk.Text = "Write to Disk";
            this.rbWriteDisk.UseVisualStyleBackColor = true;
            this.rbWriteDisk.CheckedChanged += new System.EventHandler(this.rbWriteDisk_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(313, 464);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 29);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Maroon;
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(135, 464);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(108, 29);
            this.btnSelect.TabIndex = 18;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gbUSBPorts
            // 
            this.gbUSBPorts.Controls.Add(this.btnRefreshUSB);
            this.gbUSBPorts.Controls.Add(this.lbUSBPorts);
            this.gbUSBPorts.ForeColor = System.Drawing.Color.White;
            this.gbUSBPorts.Location = new System.Drawing.Point(23, 320);
            this.gbUSBPorts.Name = "gbUSBPorts";
            this.gbUSBPorts.Size = new System.Drawing.Size(511, 130);
            this.gbUSBPorts.TabIndex = 14;
            this.gbUSBPorts.TabStop = false;
            this.gbUSBPorts.Text = "USB Ports";
            // 
            // btnRefreshUSB
            // 
            this.btnRefreshUSB.BackColor = System.Drawing.Color.Maroon;
            this.btnRefreshUSB.ForeColor = System.Drawing.Color.White;
            this.btnRefreshUSB.Location = new System.Drawing.Point(387, 55);
            this.btnRefreshUSB.Name = "btnRefreshUSB";
            this.btnRefreshUSB.Size = new System.Drawing.Size(108, 29);
            this.btnRefreshUSB.TabIndex = 17;
            this.btnRefreshUSB.Text = "Refresh";
            this.btnRefreshUSB.UseVisualStyleBackColor = false;
            this.btnRefreshUSB.Click += new System.EventHandler(this.btnRefreshUSB_Click);
            // 
            // lbUSBPorts
            // 
            this.lbUSBPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUSBPorts.ForeColor = System.Drawing.Color.White;
            this.lbUSBPorts.FormattingEnabled = true;
            this.lbUSBPorts.ItemHeight = 16;
            this.lbUSBPorts.Location = new System.Drawing.Point(23, 26);
            this.lbUSBPorts.Name = "lbUSBPorts";
            this.lbUSBPorts.Size = new System.Drawing.Size(349, 84);
            this.lbUSBPorts.TabIndex = 19;
            this.lbUSBPorts.SelectedIndexChanged += new System.EventHandler(this.lbUSBPorts_SelectedIndexChanged);
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.gbUSBPorts);
            this.gbAction.Controls.Add(this.btnSelect);
            this.gbAction.Controls.Add(this.btnClose);
            this.gbAction.Controls.Add(this.gbActionSelect);
            this.gbAction.Controls.Add(this.pbGWsmall);
            this.gbAction.ForeColor = System.Drawing.Color.White;
            this.gbAction.Location = new System.Drawing.Point(12, 31);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(557, 507);
            this.gbAction.TabIndex = 1;
            this.gbAction.TabStop = false;
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(125, 544);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(334, 31);
            this.lblHostTools.TabIndex = 24;
            this.lblHostTools.Text = "for Host Tools v0.00";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(585, 582);
            this.Controls.Add(this.lblHostTools);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ChooserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Action";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGWsmall)).EndInit();
            this.gbActionSelect.ResumeLayout(false);
            this.gbActionSelect.PerformLayout();
            this.gbUSBPorts.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox gbUSBPorts;
        private System.Windows.Forms.Button btnRefreshUSB;
        private System.Windows.Forms.ListBox lbUSBPorts;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.RadioButton rbSeekCyl;
        private System.Windows.Forms.Label lblHostTools;
        private System.Windows.Forms.RadioButton rbCleanHeads;
        private System.Windows.Forms.ToolStripMenuItem mnuElapsedTime;
    }
}