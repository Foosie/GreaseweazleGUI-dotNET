// MainForm.Designer.cs
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
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mnuSettings = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPythonFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gbUSBPorts = new System.Windows.Forms.GroupBox();
            this.btnRefreshUSB = new System.Windows.Forms.Button();
            this.lbUSBPorts = new System.Windows.Forms.ListBox();
            this.gbLaunch = new System.Windows.Forms.GroupBox();
            this.lblImageDisk = new System.Windows.Forms.Label();
            this.btnSetPythonFolder = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.pbGWsmall = new System.Windows.Forms.PictureBox();
            this.rbReadDisk = new System.Windows.Forms.RadioButton();
            this.rbWriteDisk = new System.Windows.Forms.RadioButton();
            this.rbSetDelays = new System.Windows.Forms.RadioButton();
            this.rbUpdateFirmware = new System.Windows.Forms.RadioButton();
            this.gbReadFromDisk = new System.Windows.Forms.GroupBox();
            this.btnRFDSelectFile = new System.Windows.Forms.Button();
            this.txtRFDFilename = new System.Windows.Forms.TextBox();
            this.btnRFDSelectFolder = new System.Windows.Forms.Button();
            this.rbReadDoubleSided = new System.Windows.Forms.RadioButton();
            this.rbReadSingleSided = new System.Windows.Forms.RadioButton();
            this.txtReadLastCyl = new System.Windows.Forms.TextBox();
            this.chkReadLastCyl = new System.Windows.Forms.CheckBox();
            this.txtReadFirstCyl = new System.Windows.Forms.TextBox();
            this.chkReadFirstCyl = new System.Windows.Forms.CheckBox();
            this.txtRevsPerTrack = new System.Windows.Forms.TextBox();
            this.chkRevsPerTrack = new System.Windows.Forms.CheckBox();
            this.gbWriteToDisk = new System.Windows.Forms.GroupBox();
            this.txtWTDFilename = new System.Windows.Forms.TextBox();
            this.chkWTDAdjustSpeed = new System.Windows.Forms.CheckBox();
            this.btnWTDSelectFile = new System.Windows.Forms.Button();
            this.rbWriteDoubleSided = new System.Windows.Forms.RadioButton();
            this.rbWriteSingleSided = new System.Windows.Forms.RadioButton();
            this.txtWriteLastCyl = new System.Windows.Forms.TextBox();
            this.chkWriteLastCyl = new System.Windows.Forms.CheckBox();
            this.txtWriteFirstCyl = new System.Windows.Forms.TextBox();
            this.chkWriteFirstCyl = new System.Windows.Forms.CheckBox();
            this.gbSetDelays = new System.Windows.Forms.GroupBox();
            this.btnDelaysDefaults = new System.Windows.Forms.Button();
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
            this.gbUpdateFirmware = new System.Windows.Forms.GroupBox();
            this.txtUFFilename = new System.Windows.Forms.TextBox();
            this.btnSelectUpdateFile = new System.Windows.Forms.Button();
            this.gbCommandLine = new System.Windows.Forms.GroupBox();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.mnuSettings.SuspendLayout();
            this.gbUSBPorts.SuspendLayout();
            this.gbLaunch.SuspendLayout();
            this.gbAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGWsmall)).BeginInit();
            this.gbReadFromDisk.SuspendLayout();
            this.gbWriteToDisk.SuspendLayout();
            this.gbSetDelays.SuspendLayout();
            this.gbUpdateFirmware.SuspendLayout();
            this.gbCommandLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSettings
            // 
            this.mnuSettings.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.mnuSettings.Location = new System.Drawing.Point(0, 0);
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(855, 28);
            this.mnuSettings.TabIndex = 0;
            this.mnuSettings.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPythonFolder});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // mnuPythonFolder
            // 
            this.mnuPythonFolder.Name = "mnuPythonFolder";
            this.mnuPythonFolder.Size = new System.Drawing.Size(203, 26);
            this.mnuPythonFolder.Text = "Use Python Folder";
            this.mnuPythonFolder.CheckedChanged += new System.EventHandler(this.mnuPythonFolder_CheckChanged);
            this.mnuPythonFolder.Click += new System.EventHandler(this.mnuPythonFolder_Click);
            // 
            // gbUSBPorts
            // 
            this.gbUSBPorts.Controls.Add(this.btnRefreshUSB);
            this.gbUSBPorts.Controls.Add(this.lbUSBPorts);
            this.gbUSBPorts.Location = new System.Drawing.Point(428, 278);
            this.gbUSBPorts.Name = "gbUSBPorts";
            this.gbUSBPorts.Size = new System.Drawing.Size(175, 252);
            this.gbUSBPorts.TabIndex = 40;
            this.gbUSBPorts.TabStop = false;
            this.gbUSBPorts.Text = "USB Ports";
            // 
            // btnRefreshUSB
            // 
            this.btnRefreshUSB.Location = new System.Drawing.Point(18, 211);
            this.btnRefreshUSB.Name = "btnRefreshUSB";
            this.btnRefreshUSB.Size = new System.Drawing.Size(108, 29);
            this.btnRefreshUSB.TabIndex = 42;
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
            this.lbUSBPorts.Size = new System.Drawing.Size(139, 164);
            this.lbUSBPorts.TabIndex = 41;
            this.lbUSBPorts.SelectedIndexChanged += new System.EventHandler(this.lbUSBPorts_SelectedIndexChanged);
            // 
            // gbLaunch
            // 
            this.gbLaunch.Controls.Add(this.lblImageDisk);
            this.gbLaunch.Controls.Add(this.btnSetPythonFolder);
            this.gbLaunch.Controls.Add(this.btnStart);
            this.gbLaunch.Location = new System.Drawing.Point(619, 387);
            this.gbLaunch.Name = "gbLaunch";
            this.gbLaunch.Size = new System.Drawing.Size(228, 144);
            this.gbLaunch.TabIndex = 46;
            this.gbLaunch.TabStop = false;
            // 
            // lblImageDisk
            // 
            this.lblImageDisk.Location = new System.Drawing.Point(19, 18);
            this.lblImageDisk.Name = "lblImageDisk";
            this.lblImageDisk.Size = new System.Drawing.Size(193, 17);
            this.lblImageDisk.TabIndex = 47;
            this.lblImageDisk.Text = "Image or Disk";
            this.lblImageDisk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetPythonFolder
            // 
            this.btnSetPythonFolder.Location = new System.Drawing.Point(54, 44);
            this.btnSetPythonFolder.Name = "btnSetPythonFolder";
            this.btnSetPythonFolder.Size = new System.Drawing.Size(122, 50);
            this.btnSetPythonFolder.TabIndex = 48;
            this.btnSetPythonFolder.Text = "Python Folder";
            this.btnSetPythonFolder.UseVisualStyleBackColor = true;
            this.btnSetPythonFolder.Click += new System.EventHandler(this.btnSetPythonFolder_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(61, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 29);
            this.btnStart.TabIndex = 49;
            this.btnStart.Text = "Launch";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.pbGWsmall);
            this.gbAction.Controls.Add(this.rbReadDisk);
            this.gbAction.Controls.Add(this.rbWriteDisk);
            this.gbAction.Controls.Add(this.rbSetDelays);
            this.gbAction.Controls.Add(this.rbUpdateFirmware);
            this.gbAction.Location = new System.Drawing.Point(12, 35);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(277, 239);
            this.gbAction.TabIndex = 1;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Action";
            // 
            // pbGWsmall
            // 
            this.pbGWsmall.Image = ((System.Drawing.Image)(resources.GetObject("pbGWsmall.Image")));
            this.pbGWsmall.Location = new System.Drawing.Point(22, 22);
            this.pbGWsmall.Name = "pbGWsmall";
            this.pbGWsmall.Size = new System.Drawing.Size(235, 94);
            this.pbGWsmall.TabIndex = 10;
            this.pbGWsmall.TabStop = false;
            // 
            // rbReadDisk
            // 
            this.rbReadDisk.AutoSize = true;
            this.rbReadDisk.Checked = true;
            this.rbReadDisk.Location = new System.Drawing.Point(22, 178);
            this.rbReadDisk.Name = "rbReadDisk";
            this.rbReadDisk.Size = new System.Drawing.Size(126, 21);
            this.rbReadDisk.TabIndex = 4;
            this.rbReadDisk.TabStop = true;
            this.rbReadDisk.Text = "Read from Disk";
            this.rbReadDisk.UseVisualStyleBackColor = true;
            this.rbReadDisk.CheckedChanged += new System.EventHandler(this.rbReadDisk_CheckedChanged);
            // 
            // rbWriteDisk
            // 
            this.rbWriteDisk.AutoSize = true;
            this.rbWriteDisk.Location = new System.Drawing.Point(22, 205);
            this.rbWriteDisk.Name = "rbWriteDisk";
            this.rbWriteDisk.Size = new System.Drawing.Size(109, 21);
            this.rbWriteDisk.TabIndex = 5;
            this.rbWriteDisk.Text = "Write to Disk";
            this.rbWriteDisk.UseVisualStyleBackColor = true;
            this.rbWriteDisk.CheckedChanged += new System.EventHandler(this.rbWrite_CheckedChanged);
            // 
            // rbSetDelays
            // 
            this.rbSetDelays.AutoSize = true;
            this.rbSetDelays.Location = new System.Drawing.Point(22, 152);
            this.rbSetDelays.Name = "rbSetDelays";
            this.rbSetDelays.Size = new System.Drawing.Size(97, 21);
            this.rbSetDelays.TabIndex = 3;
            this.rbSetDelays.Text = "Set Delays";
            this.rbSetDelays.UseVisualStyleBackColor = true;
            this.rbSetDelays.CheckedChanged += new System.EventHandler(this.rbSetDelays_CheckedChanged);
            // 
            // rbUpdateFirmware
            // 
            this.rbUpdateFirmware.AutoSize = true;
            this.rbUpdateFirmware.Location = new System.Drawing.Point(22, 125);
            this.rbUpdateFirmware.Name = "rbUpdateFirmware";
            this.rbUpdateFirmware.Size = new System.Drawing.Size(136, 21);
            this.rbUpdateFirmware.TabIndex = 2;
            this.rbUpdateFirmware.Text = "Update Firmware";
            this.rbUpdateFirmware.UseVisualStyleBackColor = true;
            this.rbUpdateFirmware.CheckedChanged += new System.EventHandler(this.rbUpdateFirmware_CheckedChanged);
            // 
            // gbReadFromDisk
            // 
            this.gbReadFromDisk.Controls.Add(this.btnRFDSelectFile);
            this.gbReadFromDisk.Controls.Add(this.txtRFDFilename);
            this.gbReadFromDisk.Controls.Add(this.btnRFDSelectFolder);
            this.gbReadFromDisk.Controls.Add(this.rbReadDoubleSided);
            this.gbReadFromDisk.Controls.Add(this.rbReadSingleSided);
            this.gbReadFromDisk.Controls.Add(this.txtReadLastCyl);
            this.gbReadFromDisk.Controls.Add(this.chkReadLastCyl);
            this.gbReadFromDisk.Controls.Add(this.txtReadFirstCyl);
            this.gbReadFromDisk.Controls.Add(this.chkReadFirstCyl);
            this.gbReadFromDisk.Controls.Add(this.txtRevsPerTrack);
            this.gbReadFromDisk.Controls.Add(this.chkRevsPerTrack);
            this.gbReadFromDisk.Location = new System.Drawing.Point(300, 35);
            this.gbReadFromDisk.Name = "gbReadFromDisk";
            this.gbReadFromDisk.Size = new System.Drawing.Size(267, 239);
            this.gbReadFromDisk.TabIndex = 6;
            this.gbReadFromDisk.TabStop = false;
            this.gbReadFromDisk.Text = "Read from Disk";
            this.gbReadFromDisk.Enter += new System.EventHandler(this.gbReadFromDisk_Enter);
            // 
            // btnRFDSelectFile
            // 
            this.btnRFDSelectFile.Location = new System.Drawing.Point(139, 197);
            this.btnRFDSelectFile.Name = "btnRFDSelectFile";
            this.btnRFDSelectFile.Size = new System.Drawing.Size(108, 29);
            this.btnRFDSelectFile.TabIndex = 17;
            this.btnRFDSelectFile.Text = "Replace File";
            this.btnRFDSelectFile.UseVisualStyleBackColor = true;
            this.btnRFDSelectFile.Click += new System.EventHandler(this.btnRFDSelectFile_Click);
            // 
            // txtRFDFilename
            // 
            this.txtRFDFilename.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtRFDFilename.Location = new System.Drawing.Point(16, 139);
            this.txtRFDFilename.Name = "txtRFDFilename";
            this.txtRFDFilename.Size = new System.Drawing.Size(231, 22);
            this.txtRFDFilename.TabIndex = 15;
            this.txtRFDFilename.Text = "mydisk.scp";
            this.txtRFDFilename.TextChanged += new System.EventHandler(this.txtRFDFilename_TextChanged);
            // 
            // btnRFDSelectFolder
            // 
            this.btnRFDSelectFolder.Location = new System.Drawing.Point(16, 197);
            this.btnRFDSelectFolder.Name = "btnRFDSelectFolder";
            this.btnRFDSelectFolder.Size = new System.Drawing.Size(108, 29);
            this.btnRFDSelectFolder.TabIndex = 16;
            this.btnRFDSelectFolder.Text = "Select Folder";
            this.btnRFDSelectFolder.UseVisualStyleBackColor = true;
            this.btnRFDSelectFolder.Click += new System.EventHandler(this.btnRFDSelectFolder_Click);
            // 
            // rbReadDoubleSided
            // 
            this.rbReadDoubleSided.AutoSize = true;
            this.rbReadDoubleSided.Checked = true;
            this.rbReadDoubleSided.Location = new System.Drawing.Point(139, 112);
            this.rbReadDoubleSided.Name = "rbReadDoubleSided";
            this.rbReadDoubleSided.Size = new System.Drawing.Size(114, 21);
            this.rbReadDoubleSided.TabIndex = 14;
            this.rbReadDoubleSided.TabStop = true;
            this.rbReadDoubleSided.Text = "Double Sided";
            this.rbReadDoubleSided.UseVisualStyleBackColor = true;
            this.rbReadDoubleSided.CheckedChanged += new System.EventHandler(this.rbReadDoubleSided_CheckedChanged);
            // 
            // rbReadSingleSided
            // 
            this.rbReadSingleSided.AutoSize = true;
            this.rbReadSingleSided.Location = new System.Drawing.Point(16, 109);
            this.rbReadSingleSided.Name = "rbReadSingleSided";
            this.rbReadSingleSided.Size = new System.Drawing.Size(108, 21);
            this.rbReadSingleSided.TabIndex = 13;
            this.rbReadSingleSided.Text = "Single Sided";
            this.rbReadSingleSided.UseVisualStyleBackColor = true;
            this.rbReadSingleSided.CheckedChanged += new System.EventHandler(this.rbReadSingleSided_CheckedChanged);
            // 
            // txtReadLastCyl
            // 
            this.txtReadLastCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtReadLastCyl.Location = new System.Drawing.Point(193, 84);
            this.txtReadLastCyl.Name = "txtReadLastCyl";
            this.txtReadLastCyl.Size = new System.Drawing.Size(54, 22);
            this.txtReadLastCyl.TabIndex = 12;
            this.txtReadLastCyl.Text = "79";
            this.txtReadLastCyl.TextChanged += new System.EventHandler(this.txtReadLastCyl_TextChanged);
            // 
            // chkReadLastCyl
            // 
            this.chkReadLastCyl.AutoSize = true;
            this.chkReadLastCyl.Location = new System.Drawing.Point(16, 82);
            this.chkReadLastCyl.Name = "chkReadLastCyl";
            this.chkReadLastCyl.Size = new System.Drawing.Size(159, 21);
            this.chkReadLastCyl.TabIndex = 11;
            this.chkReadLastCyl.Text = "Last cylinder to read";
            this.chkReadLastCyl.UseVisualStyleBackColor = true;
            this.chkReadLastCyl.CheckedChanged += new System.EventHandler(this.chkReadLastCyl_CheckedChanged);
            // 
            // txtReadFirstCyl
            // 
            this.txtReadFirstCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtReadFirstCyl.Location = new System.Drawing.Point(193, 56);
            this.txtReadFirstCyl.Name = "txtReadFirstCyl";
            this.txtReadFirstCyl.Size = new System.Drawing.Size(54, 22);
            this.txtReadFirstCyl.TabIndex = 10;
            this.txtReadFirstCyl.Text = "0";
            this.txtReadFirstCyl.TextChanged += new System.EventHandler(this.txtReadFirstCyl_TextChanged);
            // 
            // chkReadFirstCyl
            // 
            this.chkReadFirstCyl.AutoSize = true;
            this.chkReadFirstCyl.Location = new System.Drawing.Point(16, 55);
            this.chkReadFirstCyl.Name = "chkReadFirstCyl";
            this.chkReadFirstCyl.Size = new System.Drawing.Size(159, 21);
            this.chkReadFirstCyl.TabIndex = 9;
            this.chkReadFirstCyl.Text = "First cylinder to read";
            this.chkReadFirstCyl.UseVisualStyleBackColor = true;
            this.chkReadFirstCyl.CheckedChanged += new System.EventHandler(this.chkReadFirstCyl_CheckedChanged);
            // 
            // txtRevsPerTrack
            // 
            this.txtRevsPerTrack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtRevsPerTrack.Location = new System.Drawing.Point(193, 28);
            this.txtRevsPerTrack.Name = "txtRevsPerTrack";
            this.txtRevsPerTrack.Size = new System.Drawing.Size(54, 22);
            this.txtRevsPerTrack.TabIndex = 8;
            this.txtRevsPerTrack.Text = "3";
            this.txtRevsPerTrack.TextChanged += new System.EventHandler(this.txtRevsPerTrack_TextChanged);
            // 
            // chkRevsPerTrack
            // 
            this.chkRevsPerTrack.AutoSize = true;
            this.chkRevsPerTrack.Location = new System.Drawing.Point(16, 28);
            this.chkRevsPerTrack.Name = "chkRevsPerTrack";
            this.chkRevsPerTrack.Size = new System.Drawing.Size(171, 21);
            this.chkRevsPerTrack.TabIndex = 7;
            this.chkRevsPerTrack.Text = "Revs to read per track";
            this.chkRevsPerTrack.UseVisualStyleBackColor = true;
            this.chkRevsPerTrack.CheckedChanged += new System.EventHandler(this.chkRevsPerTrack_CheckedChanged);
            // 
            // gbWriteToDisk
            // 
            this.gbWriteToDisk.Controls.Add(this.txtWTDFilename);
            this.gbWriteToDisk.Controls.Add(this.chkWTDAdjustSpeed);
            this.gbWriteToDisk.Controls.Add(this.btnWTDSelectFile);
            this.gbWriteToDisk.Controls.Add(this.rbWriteDoubleSided);
            this.gbWriteToDisk.Controls.Add(this.rbWriteSingleSided);
            this.gbWriteToDisk.Controls.Add(this.txtWriteLastCyl);
            this.gbWriteToDisk.Controls.Add(this.chkWriteLastCyl);
            this.gbWriteToDisk.Controls.Add(this.txtWriteFirstCyl);
            this.gbWriteToDisk.Controls.Add(this.chkWriteFirstCyl);
            this.gbWriteToDisk.Location = new System.Drawing.Point(578, 35);
            this.gbWriteToDisk.Name = "gbWriteToDisk";
            this.gbWriteToDisk.Size = new System.Drawing.Size(267, 237);
            this.gbWriteToDisk.TabIndex = 18;
            this.gbWriteToDisk.TabStop = false;
            this.gbWriteToDisk.Text = "Write to Disk";
            // 
            // txtWTDFilename
            // 
            this.txtWTDFilename.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtWTDFilename.Location = new System.Drawing.Point(15, 139);
            this.txtWTDFilename.Name = "txtWTDFilename";
            this.txtWTDFilename.Size = new System.Drawing.Size(229, 22);
            this.txtWTDFilename.TabIndex = 26;
            this.txtWTDFilename.Text = "mydisk.scp";
            this.txtWTDFilename.TextChanged += new System.EventHandler(this.txtWTDFilename_TextChanged);
            // 
            // chkWTDAdjustSpeed
            // 
            this.chkWTDAdjustSpeed.AutoSize = true;
            this.chkWTDAdjustSpeed.Location = new System.Drawing.Point(15, 27);
            this.chkWTDAdjustSpeed.Name = "chkWTDAdjustSpeed";
            this.chkWTDAdjustSpeed.Size = new System.Drawing.Size(114, 21);
            this.chkWTDAdjustSpeed.TabIndex = 19;
            this.chkWTDAdjustSpeed.Text = "Adjust Speed";
            this.chkWTDAdjustSpeed.UseVisualStyleBackColor = true;
            this.chkWTDAdjustSpeed.CheckedChanged += new System.EventHandler(this.chkWTDAdjustSpeed_CheckedChanged);
            // 
            // btnWTDSelectFile
            // 
            this.btnWTDSelectFile.Location = new System.Drawing.Point(15, 197);
            this.btnWTDSelectFile.Name = "btnWTDSelectFile";
            this.btnWTDSelectFile.Size = new System.Drawing.Size(108, 29);
            this.btnWTDSelectFile.TabIndex = 27;
            this.btnWTDSelectFile.Text = "Read File";
            this.btnWTDSelectFile.UseVisualStyleBackColor = true;
            this.btnWTDSelectFile.Click += new System.EventHandler(this.btnWTDSelectFile_Click);
            // 
            // rbWriteDoubleSided
            // 
            this.rbWriteDoubleSided.AutoSize = true;
            this.rbWriteDoubleSided.Checked = true;
            this.rbWriteDoubleSided.Location = new System.Drawing.Point(138, 112);
            this.rbWriteDoubleSided.Name = "rbWriteDoubleSided";
            this.rbWriteDoubleSided.Size = new System.Drawing.Size(114, 21);
            this.rbWriteDoubleSided.TabIndex = 25;
            this.rbWriteDoubleSided.TabStop = true;
            this.rbWriteDoubleSided.Text = "Double Sided";
            this.rbWriteDoubleSided.UseVisualStyleBackColor = true;
            this.rbWriteDoubleSided.CheckedChanged += new System.EventHandler(this.rbWriteDoubleSided_CheckedChanged);
            // 
            // rbWriteSingleSided
            // 
            this.rbWriteSingleSided.AutoSize = true;
            this.rbWriteSingleSided.Location = new System.Drawing.Point(15, 109);
            this.rbWriteSingleSided.Name = "rbWriteSingleSided";
            this.rbWriteSingleSided.Size = new System.Drawing.Size(108, 21);
            this.rbWriteSingleSided.TabIndex = 24;
            this.rbWriteSingleSided.Text = "Single Sided";
            this.rbWriteSingleSided.UseVisualStyleBackColor = true;
            this.rbWriteSingleSided.CheckedChanged += new System.EventHandler(this.rbWriteSingleSided_CheckedChanged);
            // 
            // txtWriteLastCyl
            // 
            this.txtWriteLastCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtWriteLastCyl.Location = new System.Drawing.Point(192, 84);
            this.txtWriteLastCyl.Name = "txtWriteLastCyl";
            this.txtWriteLastCyl.Size = new System.Drawing.Size(54, 22);
            this.txtWriteLastCyl.TabIndex = 23;
            this.txtWriteLastCyl.Text = "79";
            this.txtWriteLastCyl.TextChanged += new System.EventHandler(this.txtWriteLastCyl_TextChanged);
            // 
            // chkWriteLastCyl
            // 
            this.chkWriteLastCyl.AutoSize = true;
            this.chkWriteLastCyl.Location = new System.Drawing.Point(15, 82);
            this.chkWriteLastCyl.Name = "chkWriteLastCyl";
            this.chkWriteLastCyl.Size = new System.Drawing.Size(159, 21);
            this.chkWriteLastCyl.TabIndex = 22;
            this.chkWriteLastCyl.Text = "Last cylinder to write";
            this.chkWriteLastCyl.UseVisualStyleBackColor = true;
            this.chkWriteLastCyl.CheckedChanged += new System.EventHandler(this.chkWriteLastCyl_CheckedChanged);
            // 
            // txtWriteFirstCyl
            // 
            this.txtWriteFirstCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtWriteFirstCyl.Location = new System.Drawing.Point(192, 56);
            this.txtWriteFirstCyl.Name = "txtWriteFirstCyl";
            this.txtWriteFirstCyl.Size = new System.Drawing.Size(54, 22);
            this.txtWriteFirstCyl.TabIndex = 21;
            this.txtWriteFirstCyl.Text = "0";
            this.txtWriteFirstCyl.TextChanged += new System.EventHandler(this.txtWriteFirstCyl_TextChanged);
            // 
            // chkWriteFirstCyl
            // 
            this.chkWriteFirstCyl.AutoSize = true;
            this.chkWriteFirstCyl.Location = new System.Drawing.Point(15, 55);
            this.chkWriteFirstCyl.Name = "chkWriteFirstCyl";
            this.chkWriteFirstCyl.Size = new System.Drawing.Size(159, 21);
            this.chkWriteFirstCyl.TabIndex = 20;
            this.chkWriteFirstCyl.Text = "First cylinder to write";
            this.chkWriteFirstCyl.UseVisualStyleBackColor = true;
            this.chkWriteFirstCyl.CheckedChanged += new System.EventHandler(this.chkWriteFirstCyl_CheckedChanged);
            // 
            // gbSetDelays
            // 
            this.gbSetDelays.Controls.Add(this.btnDelaysDefaults);
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
            this.gbSetDelays.Location = new System.Drawing.Point(13, 278);
            this.gbSetDelays.Name = "gbSetDelays";
            this.gbSetDelays.Size = new System.Drawing.Size(400, 252);
            this.gbSetDelays.TabIndex = 28;
            this.gbSetDelays.TabStop = false;
            this.gbSetDelays.Text = "Set Delays";
            // 
            // btnDelaysDefaults
            // 
            this.btnDelaysDefaults.Location = new System.Drawing.Point(19, 211);
            this.btnDelaysDefaults.Name = "btnDelaysDefaults";
            this.btnDelaysDefaults.Size = new System.Drawing.Size(108, 29);
            this.btnDelaysDefaults.TabIndex = 39;
            this.btnDelaysDefaults.Text = "Defaults";
            this.btnDelaysDefaults.UseVisualStyleBackColor = true;
            this.btnDelaysDefaults.Click += new System.EventHandler(this.btnDelaysDefaults_Click);
            // 
            // txtDelayAutoDeselect
            // 
            this.txtDelayAutoDeselect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDelayAutoDeselect.Location = new System.Drawing.Point(324, 157);
            this.txtDelayAutoDeselect.Name = "txtDelayAutoDeselect";
            this.txtDelayAutoDeselect.Size = new System.Drawing.Size(54, 22);
            this.txtDelayAutoDeselect.TabIndex = 38;
            this.txtDelayAutoDeselect.Text = "10000";
            this.txtDelayAutoDeselect.TextChanged += new System.EventHandler(this.txtDelayAutoDeselect_TextChanged);
            // 
            // chkDelayAutoDeselect
            // 
            this.chkDelayAutoDeselect.AutoSize = true;
            this.chkDelayAutoDeselect.Location = new System.Drawing.Point(21, 158);
            this.chkDelayAutoDeselect.Name = "chkDelayAutoDeselect";
            this.chkDelayAutoDeselect.Size = new System.Drawing.Size(297, 21);
            this.chkDelayAutoDeselect.TabIndex = 37;
            this.chkDelayAutoDeselect.Text = "Quiescent time until auto deselect (msecs)";
            this.chkDelayAutoDeselect.UseVisualStyleBackColor = true;
            this.chkDelayAutoDeselect.CheckedChanged += new System.EventHandler(this.chkDelayAutoDeselect_CheckedChanged);
            // 
            // txtDelayMotorOn
            // 
            this.txtDelayMotorOn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDelayMotorOn.Location = new System.Drawing.Point(324, 124);
            this.txtDelayMotorOn.Name = "txtDelayMotorOn";
            this.txtDelayMotorOn.Size = new System.Drawing.Size(54, 22);
            this.txtDelayMotorOn.TabIndex = 36;
            this.txtDelayMotorOn.Text = "750";
            this.txtDelayMotorOn.TextChanged += new System.EventHandler(this.txtDelayMotorOn_TextChanged);
            // 
            // chkDelayMotorOn
            // 
            this.chkDelayMotorOn.AutoSize = true;
            this.chkDelayMotorOn.Location = new System.Drawing.Point(21, 125);
            this.chkDelayMotorOn.Name = "chkDelayMotorOn";
            this.chkDelayMotorOn.Size = new System.Drawing.Size(213, 21);
            this.chkDelayMotorOn.TabIndex = 35;
            this.chkDelayMotorOn.Text = "Delay after motor on (msecs)";
            this.chkDelayMotorOn.UseVisualStyleBackColor = true;
            this.chkDelayMotorOn.CheckedChanged += new System.EventHandler(this.chkDelayMotorOn_CheckedChanged);
            // 
            // txtDelaySeekSettle
            // 
            this.txtDelaySeekSettle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDelaySeekSettle.Location = new System.Drawing.Point(324, 91);
            this.txtDelaySeekSettle.Name = "txtDelaySeekSettle";
            this.txtDelaySeekSettle.Size = new System.Drawing.Size(54, 22);
            this.txtDelaySeekSettle.TabIndex = 34;
            this.txtDelaySeekSettle.Text = "15";
            this.txtDelaySeekSettle.TextChanged += new System.EventHandler(this.txtDelaySeekSettle_TextChanged);
            // 
            // chkDelaySeekSettle
            // 
            this.chkDelaySeekSettle.AutoSize = true;
            this.chkDelaySeekSettle.Location = new System.Drawing.Point(21, 92);
            this.chkDelaySeekSettle.Name = "chkDelaySeekSettle";
            this.chkDelaySeekSettle.Size = new System.Drawing.Size(225, 21);
            this.chkDelaySeekSettle.TabIndex = 33;
            this.chkDelaySeekSettle.Text = "Settle delay after seek (msecs)";
            this.chkDelaySeekSettle.UseVisualStyleBackColor = true;
            this.chkDelaySeekSettle.CheckedChanged += new System.EventHandler(this.chkDelaySeekSettle_CheckedChanged);
            // 
            // txtDelayDriveSelect
            // 
            this.txtDelayDriveSelect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDelayDriveSelect.Location = new System.Drawing.Point(324, 25);
            this.txtDelayDriveSelect.Name = "txtDelayDriveSelect";
            this.txtDelayDriveSelect.Size = new System.Drawing.Size(54, 22);
            this.txtDelayDriveSelect.TabIndex = 30;
            this.txtDelayDriveSelect.Text = "10";
            this.txtDelayDriveSelect.TextChanged += new System.EventHandler(this.txtDelayDriveSelect_TextChanged);
            // 
            // chkDelayDriveSelect
            // 
            this.chkDelayDriveSelect.AutoSize = true;
            this.chkDelayDriveSelect.Location = new System.Drawing.Point(21, 26);
            this.chkDelayDriveSelect.Name = "chkDelayDriveSelect";
            this.chkDelayDriveSelect.Size = new System.Drawing.Size(226, 21);
            this.chkDelayDriveSelect.TabIndex = 29;
            this.chkDelayDriveSelect.Text = "Delay after drive select (usecs)";
            this.chkDelayDriveSelect.UseVisualStyleBackColor = true;
            this.chkDelayDriveSelect.CheckedChanged += new System.EventHandler(this.chkDelayDriveSelect_CheckedChanged);
            // 
            // txtDelayHeadSteps
            // 
            this.txtDelayHeadSteps.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDelayHeadSteps.Location = new System.Drawing.Point(324, 58);
            this.txtDelayHeadSteps.Name = "txtDelayHeadSteps";
            this.txtDelayHeadSteps.Size = new System.Drawing.Size(54, 22);
            this.txtDelayHeadSteps.TabIndex = 32;
            this.txtDelayHeadSteps.Text = "3000";
            this.txtDelayHeadSteps.TextChanged += new System.EventHandler(this.txtDelayHeadSteps_TextChanged);
            // 
            // chkDelayHeadSteps
            // 
            this.chkDelayHeadSteps.AutoSize = true;
            this.chkDelayHeadSteps.Location = new System.Drawing.Point(21, 59);
            this.chkDelayHeadSteps.Name = "chkDelayHeadSteps";
            this.chkDelayHeadSteps.Size = new System.Drawing.Size(248, 21);
            this.chkDelayHeadSteps.TabIndex = 31;
            this.chkDelayHeadSteps.Text = "Delay between head steps (usecs)";
            this.chkDelayHeadSteps.UseVisualStyleBackColor = true;
            this.chkDelayHeadSteps.CheckedChanged += new System.EventHandler(this.chkDelayHeadSteps_CheckedChanged);
            // 
            // gbUpdateFirmware
            // 
            this.gbUpdateFirmware.Controls.Add(this.txtUFFilename);
            this.gbUpdateFirmware.Controls.Add(this.btnSelectUpdateFile);
            this.gbUpdateFirmware.Location = new System.Drawing.Point(618, 278);
            this.gbUpdateFirmware.Name = "gbUpdateFirmware";
            this.gbUpdateFirmware.Size = new System.Drawing.Size(229, 103);
            this.gbUpdateFirmware.TabIndex = 43;
            this.gbUpdateFirmware.TabStop = false;
            this.gbUpdateFirmware.Text = "Update Firmware";
            // 
            // txtUFFilename
            // 
            this.txtUFFilename.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUFFilename.Location = new System.Drawing.Point(13, 26);
            this.txtUFFilename.Name = "txtUFFilename";
            this.txtUFFilename.Size = new System.Drawing.Size(193, 22);
            this.txtUFFilename.TabIndex = 44;
            this.txtUFFilename.Text = "Greaseweazle-v0.6.upd";
            // 
            // btnSelectUpdateFile
            // 
            this.btnSelectUpdateFile.Location = new System.Drawing.Point(19, 59);
            this.btnSelectUpdateFile.Name = "btnSelectUpdateFile";
            this.btnSelectUpdateFile.Size = new System.Drawing.Size(108, 29);
            this.btnSelectUpdateFile.TabIndex = 45;
            this.btnSelectUpdateFile.Text = "Select File";
            this.btnSelectUpdateFile.UseVisualStyleBackColor = true;
            this.btnSelectUpdateFile.Click += new System.EventHandler(this.btnSelectUpdateFile_Click);
            // 
            // gbCommandLine
            // 
            this.gbCommandLine.Controls.Add(this.txtCommandLine);
            this.gbCommandLine.Controls.Add(this.lblStaticCL);
            this.gbCommandLine.Location = new System.Drawing.Point(13, 536);
            this.gbCommandLine.Name = "gbCommandLine";
            this.gbCommandLine.Size = new System.Drawing.Size(833, 139);
            this.gbCommandLine.TabIndex = 45;
            this.gbCommandLine.TabStop = false;
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCommandLine.Location = new System.Drawing.Point(19, 44);
            this.txtCommandLine.Multiline = true;
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.ReadOnly = true;
            this.txtCommandLine.Size = new System.Drawing.Size(799, 74);
            this.txtCommandLine.TabIndex = 47;
            this.txtCommandLine.Click += new System.EventHandler(this.txtCommandLine_Click);
            this.txtCommandLine.DoubleClick += new System.EventHandler(this.txtCommandLine_DoubleClick);
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(365, 19);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 46;
            this.lblStaticCL.Text = "Command Line";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(855, 686);
            this.Controls.Add(this.gbCommandLine);
            this.Controls.Add(this.gbUpdateFirmware);
            this.Controls.Add(this.gbSetDelays);
            this.Controls.Add(this.gbWriteToDisk);
            this.Controls.Add(this.gbReadFromDisk);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.gbLaunch);
            this.Controls.Add(this.gbUSBPorts);
            this.Controls.Add(this.mnuSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GreaseweazleGUI";
            this.mnuSettings.ResumeLayout(false);
            this.mnuSettings.PerformLayout();
            this.gbUSBPorts.ResumeLayout(false);
            this.gbLaunch.ResumeLayout(false);
            this.gbAction.ResumeLayout(false);
            this.gbAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGWsmall)).EndInit();
            this.gbReadFromDisk.ResumeLayout(false);
            this.gbReadFromDisk.PerformLayout();
            this.gbWriteToDisk.ResumeLayout(false);
            this.gbWriteToDisk.PerformLayout();
            this.gbSetDelays.ResumeLayout(false);
            this.gbSetDelays.PerformLayout();
            this.gbUpdateFirmware.ResumeLayout(false);
            this.gbUpdateFirmware.PerformLayout();
            this.gbCommandLine.ResumeLayout(false);
            this.gbCommandLine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox gbUSBPorts;
        private System.Windows.Forms.ListBox lbUSBPorts;
        private System.Windows.Forms.Button btnRefreshUSB;
        private System.Windows.Forms.GroupBox gbLaunch;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.RadioButton rbReadDisk;
        private System.Windows.Forms.RadioButton rbWriteDisk;
        private System.Windows.Forms.RadioButton rbSetDelays;
        private System.Windows.Forms.RadioButton rbUpdateFirmware;
        private System.Windows.Forms.GroupBox gbReadFromDisk;
        private System.Windows.Forms.GroupBox gbWriteToDisk;
        private System.Windows.Forms.GroupBox gbSetDelays;
        private System.Windows.Forms.GroupBox gbUpdateFirmware;
        private System.Windows.Forms.TextBox txtDelayHeadSteps;
        private System.Windows.Forms.CheckBox chkDelayHeadSteps;
        private System.Windows.Forms.TextBox txtDelayDriveSelect;
        private System.Windows.Forms.CheckBox chkDelayDriveSelect;
        private System.Windows.Forms.TextBox txtDelaySeekSettle;
        private System.Windows.Forms.CheckBox chkDelaySeekSettle;
        private System.Windows.Forms.TextBox txtDelayMotorOn;
        private System.Windows.Forms.CheckBox chkDelayMotorOn;
        private System.Windows.Forms.TextBox txtDelayAutoDeselect;
        private System.Windows.Forms.CheckBox chkDelayAutoDeselect;
        private System.Windows.Forms.Button btnSelectUpdateFile;
        private System.Windows.Forms.TextBox txtRevsPerTrack;
        private System.Windows.Forms.CheckBox chkRevsPerTrack;
        private System.Windows.Forms.TextBox txtReadFirstCyl;
        private System.Windows.Forms.CheckBox chkReadFirstCyl;
        private System.Windows.Forms.TextBox txtReadLastCyl;
        private System.Windows.Forms.CheckBox chkReadLastCyl;
        private System.Windows.Forms.RadioButton rbReadDoubleSided;
        private System.Windows.Forms.RadioButton rbReadSingleSided;
        private System.Windows.Forms.TextBox txtRFDFilename;
        private System.Windows.Forms.Button btnRFDSelectFolder;
        private System.Windows.Forms.CheckBox chkWTDAdjustSpeed;
        private System.Windows.Forms.Button btnWTDSelectFile;
        private System.Windows.Forms.RadioButton rbWriteDoubleSided;
        private System.Windows.Forms.RadioButton rbWriteSingleSided;
        private System.Windows.Forms.TextBox txtWriteLastCyl;
        private System.Windows.Forms.CheckBox chkWriteLastCyl;
        private System.Windows.Forms.TextBox txtWriteFirstCyl;
        private System.Windows.Forms.CheckBox chkWriteFirstCyl;
        private System.Windows.Forms.TextBox txtWTDFilename;
        private System.Windows.Forms.TextBox txtUFFilename;
        private System.Windows.Forms.GroupBox gbCommandLine;
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.Button btnSetPythonFolder;
        private System.Windows.Forms.Button btnDelaysDefaults;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPythonFolder;
        private System.Windows.Forms.Label lblImageDisk;
        private System.Windows.Forms.PictureBox pbGWsmall;
        private System.Windows.Forms.Button btnRFDSelectFile;
    }
}

