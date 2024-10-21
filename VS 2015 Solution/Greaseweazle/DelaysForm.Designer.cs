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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelaysForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.lblHostTools = new System.Windows.Forms.Label();
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
            this.threadWorker = new System.ComponentModel.BackgroundWorker();
            this.ctxOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxClearOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSaveOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipChooser = new System.Windows.Forms.ToolTip(this.components);
            this.txtIdxMaskTime = new System.Windows.Forms.TextBox();
            this.chkIdxMaskTime = new System.Windows.Forms.CheckBox();
            this.txtDelayTrkWriteToChg = new System.Windows.Forms.TextBox();
            this.chkDelayTrkWriteToChg = new System.Windows.Forms.CheckBox();
            this.txtDelayTrkChgToWrite = new System.Windows.Forms.TextBox();
            this.chkDelayTrkChgToWrite = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.gbSetDelays.SuspendLayout();
            this.ctxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbOutput);
            this.groupBox1.Controls.Add(this.lblHostTools);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnLaunch);
            this.groupBox1.Controls.Add(this.btnDelaysDefaults);
            this.groupBox1.Controls.Add(this.txtDelaysCommandLine);
            this.groupBox1.Controls.Add(this.lblStaticCL);
            this.groupBox1.Controls.Add(this.gbSetDelays);
            this.groupBox1.Location = new System.Drawing.Point(10, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(408, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbOutput
            // 
            this.lbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbOutput.ForeColor = System.Drawing.Color.White;
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.HorizontalScrollbar = true;
            this.lbOutput.Location = new System.Drawing.Point(12, 330);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(386, 82);
            this.lbOutput.TabIndex = 20;
            this.toolTipChooser.SetToolTip(this.lbOutput, "Right click for options");
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(67, 450);
            this.lblHostTools.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(275, 19);
            this.lblHostTools.TabIndex = 24;
            this.lblHostTools.Text = "for Host Tools v0.00";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(267, 421);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 24);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(60, 421);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(81, 24);
            this.btnLaunch.TabIndex = 21;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnDelaysDefaults
            // 
            this.btnDelaysDefaults.BackColor = System.Drawing.Color.Maroon;
            this.btnDelaysDefaults.Location = new System.Drawing.Point(164, 421);
            this.btnDelaysDefaults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelaysDefaults.Name = "btnDelaysDefaults";
            this.btnDelaysDefaults.Size = new System.Drawing.Size(81, 24);
            this.btnDelaysDefaults.TabIndex = 22;
            this.btnDelaysDefaults.Text = "Defaults";
            this.btnDelaysDefaults.UseVisualStyleBackColor = false;
            this.btnDelaysDefaults.Click += new System.EventHandler(this.btnDelaysDefaults_Click);
            // 
            // txtDelaysCommandLine
            // 
            this.txtDelaysCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDelaysCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtDelaysCommandLine.Location = new System.Drawing.Point(12, 259);
            this.txtDelaysCommandLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDelaysCommandLine.Multiline = true;
            this.txtDelaysCommandLine.Name = "txtDelaysCommandLine";
            this.txtDelaysCommandLine.Size = new System.Drawing.Size(385, 61);
            this.txtDelaysCommandLine.TabIndex = 19;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(166, 240);
            this.lblStaticCL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(77, 13);
            this.lblStaticCL.TabIndex = 18;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbSetDelays
            // 
            this.gbSetDelays.Controls.Add(this.txtIdxMaskTime);
            this.gbSetDelays.Controls.Add(this.chkIdxMaskTime);
            this.gbSetDelays.Controls.Add(this.txtDelayTrkWriteToChg);
            this.gbSetDelays.Controls.Add(this.chkDelayTrkWriteToChg);
            this.gbSetDelays.Controls.Add(this.txtDelayTrkChgToWrite);
            this.gbSetDelays.Controls.Add(this.chkDelayTrkChgToWrite);
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
            this.gbSetDelays.Location = new System.Drawing.Point(12, 17);
            this.gbSetDelays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSetDelays.Name = "gbSetDelays";
            this.gbSetDelays.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSetDelays.Size = new System.Drawing.Size(384, 214);
            this.gbSetDelays.TabIndex = 1;
            this.gbSetDelays.TabStop = false;
            // 
            // txtDelayAutoDeselect
            // 
            this.txtDelayAutoDeselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDelayAutoDeselect.ForeColor = System.Drawing.Color.White;
            this.txtDelayAutoDeselect.Location = new System.Drawing.Point(301, 111);
            this.txtDelayAutoDeselect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDelayAutoDeselect.Name = "txtDelayAutoDeselect";
            this.txtDelayAutoDeselect.Size = new System.Drawing.Size(42, 20);
            this.txtDelayAutoDeselect.TabIndex = 11;
            this.txtDelayAutoDeselect.Text = "10000";
            this.txtDelayAutoDeselect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelayAutoDeselect.TextChanged += new System.EventHandler(this.txtDelayAutoDeselect_TextChanged);
            // 
            // chkDelayAutoDeselect
            // 
            this.chkDelayAutoDeselect.AutoSize = true;
            this.chkDelayAutoDeselect.Location = new System.Drawing.Point(42, 111);
            this.chkDelayAutoDeselect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDelayAutoDeselect.Name = "chkDelayAutoDeselect";
            this.chkDelayAutoDeselect.Size = new System.Drawing.Size(224, 17);
            this.chkDelayAutoDeselect.TabIndex = 10;
            this.chkDelayAutoDeselect.Text = "Quiescent time until auto deselect (msecs)";
            this.chkDelayAutoDeselect.UseVisualStyleBackColor = true;
            this.chkDelayAutoDeselect.CheckedChanged += new System.EventHandler(this.chkDelayAutoDeselect_CheckedChanged);
            // 
            // txtDelayMotorOn
            // 
            this.txtDelayMotorOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDelayMotorOn.ForeColor = System.Drawing.Color.White;
            this.txtDelayMotorOn.Location = new System.Drawing.Point(301, 88);
            this.txtDelayMotorOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDelayMotorOn.Name = "txtDelayMotorOn";
            this.txtDelayMotorOn.Size = new System.Drawing.Size(42, 20);
            this.txtDelayMotorOn.TabIndex = 9;
            this.txtDelayMotorOn.Text = "750";
            this.txtDelayMotorOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelayMotorOn.TextChanged += new System.EventHandler(this.txtDelayMotorOn_TextChanged);
            // 
            // chkDelayMotorOn
            // 
            this.chkDelayMotorOn.AutoSize = true;
            this.chkDelayMotorOn.Location = new System.Drawing.Point(42, 88);
            this.chkDelayMotorOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDelayMotorOn.Name = "chkDelayMotorOn";
            this.chkDelayMotorOn.Size = new System.Drawing.Size(160, 17);
            this.chkDelayMotorOn.TabIndex = 8;
            this.chkDelayMotorOn.Text = "Delay after motor on (msecs)";
            this.chkDelayMotorOn.UseVisualStyleBackColor = true;
            this.chkDelayMotorOn.CheckedChanged += new System.EventHandler(this.chkDelayMotorOn_CheckedChanged);
            // 
            // txtDelaySeekSettle
            // 
            this.txtDelaySeekSettle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDelaySeekSettle.ForeColor = System.Drawing.Color.White;
            this.txtDelaySeekSettle.Location = new System.Drawing.Point(301, 65);
            this.txtDelaySeekSettle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDelaySeekSettle.Name = "txtDelaySeekSettle";
            this.txtDelaySeekSettle.Size = new System.Drawing.Size(42, 20);
            this.txtDelaySeekSettle.TabIndex = 7;
            this.txtDelaySeekSettle.Text = "15";
            this.txtDelaySeekSettle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelaySeekSettle.TextChanged += new System.EventHandler(this.txtDelaySeekSettle_TextChanged);
            // 
            // chkDelaySeekSettle
            // 
            this.chkDelaySeekSettle.AutoSize = true;
            this.chkDelaySeekSettle.Location = new System.Drawing.Point(42, 65);
            this.chkDelaySeekSettle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDelaySeekSettle.Name = "chkDelaySeekSettle";
            this.chkDelaySeekSettle.Size = new System.Drawing.Size(170, 17);
            this.chkDelaySeekSettle.TabIndex = 6;
            this.chkDelaySeekSettle.Text = "Settle delay after seek (msecs)";
            this.chkDelaySeekSettle.UseVisualStyleBackColor = true;
            this.chkDelaySeekSettle.CheckedChanged += new System.EventHandler(this.chkDelaySeekSettle_CheckedChanged);
            // 
            // txtDelayDriveSelect
            // 
            this.txtDelayDriveSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDelayDriveSelect.ForeColor = System.Drawing.Color.White;
            this.txtDelayDriveSelect.Location = new System.Drawing.Point(301, 17);
            this.txtDelayDriveSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDelayDriveSelect.Name = "txtDelayDriveSelect";
            this.txtDelayDriveSelect.Size = new System.Drawing.Size(42, 20);
            this.txtDelayDriveSelect.TabIndex = 3;
            this.txtDelayDriveSelect.Text = "10";
            this.txtDelayDriveSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelayDriveSelect.TextChanged += new System.EventHandler(this.txtDelayDriveSelect_TextChanged);
            // 
            // chkDelayDriveSelect
            // 
            this.chkDelayDriveSelect.AutoSize = true;
            this.chkDelayDriveSelect.Location = new System.Drawing.Point(42, 17);
            this.chkDelayDriveSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDelayDriveSelect.Name = "chkDelayDriveSelect";
            this.chkDelayDriveSelect.Size = new System.Drawing.Size(171, 17);
            this.chkDelayDriveSelect.TabIndex = 2;
            this.chkDelayDriveSelect.Text = "Delay after drive select (usecs)";
            this.chkDelayDriveSelect.UseVisualStyleBackColor = true;
            this.chkDelayDriveSelect.CheckedChanged += new System.EventHandler(this.chkDelayDriveSelect_CheckedChanged);
            // 
            // txtDelayHeadSteps
            // 
            this.txtDelayHeadSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDelayHeadSteps.ForeColor = System.Drawing.Color.White;
            this.txtDelayHeadSteps.Location = new System.Drawing.Point(301, 41);
            this.txtDelayHeadSteps.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDelayHeadSteps.Name = "txtDelayHeadSteps";
            this.txtDelayHeadSteps.Size = new System.Drawing.Size(42, 20);
            this.txtDelayHeadSteps.TabIndex = 5;
            this.txtDelayHeadSteps.Text = "3000";
            this.txtDelayHeadSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelayHeadSteps.TextChanged += new System.EventHandler(this.txtDelayHeadSteps_TextChanged);
            // 
            // chkDelayHeadSteps
            // 
            this.chkDelayHeadSteps.AutoSize = true;
            this.chkDelayHeadSteps.Location = new System.Drawing.Point(42, 41);
            this.chkDelayHeadSteps.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDelayHeadSteps.Name = "chkDelayHeadSteps";
            this.chkDelayHeadSteps.Size = new System.Drawing.Size(189, 17);
            this.chkDelayHeadSteps.TabIndex = 4;
            this.chkDelayHeadSteps.Text = "Delay between head steps (usecs)";
            this.chkDelayHeadSteps.UseVisualStyleBackColor = true;
            this.chkDelayHeadSteps.CheckedChanged += new System.EventHandler(this.chkDelayHeadSteps_CheckedChanged);
            // 
            // threadWorker
            // 
            this.threadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadWorker_DoWork);
            this.threadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadWorker_RunWorkerCompleted);
            // 
            // ctxOutput
            // 
            this.ctxOutput.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxClearOutput,
            this.ctxSaveOutput});
            this.ctxOutput.Name = "ctxOutput";
            this.ctxOutput.Size = new System.Drawing.Size(143, 48);
            // 
            // ctxClearOutput
            // 
            this.ctxClearOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctxClearOutput.ForeColor = System.Drawing.Color.White;
            this.ctxClearOutput.Name = "ctxClearOutput";
            this.ctxClearOutput.Size = new System.Drawing.Size(142, 22);
            this.ctxClearOutput.Text = "Clear Output";
            this.ctxClearOutput.Click += new System.EventHandler(this.ctxClearOutput_Click);
            // 
            // ctxSaveOutput
            // 
            this.ctxSaveOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctxSaveOutput.ForeColor = System.Drawing.Color.White;
            this.ctxSaveOutput.Name = "ctxSaveOutput";
            this.ctxSaveOutput.Size = new System.Drawing.Size(142, 22);
            this.ctxSaveOutput.Text = "Save Output";
            this.ctxSaveOutput.Click += new System.EventHandler(this.ctxSaveOutput_Click);
            // 
            // txtIdxMaskTime
            // 
            this.txtIdxMaskTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtIdxMaskTime.ForeColor = System.Drawing.Color.White;
            this.txtIdxMaskTime.Location = new System.Drawing.Point(300, 180);
            this.txtIdxMaskTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdxMaskTime.Name = "txtIdxMaskTime";
            this.txtIdxMaskTime.Size = new System.Drawing.Size(42, 20);
            this.txtIdxMaskTime.TabIndex = 17;
            this.txtIdxMaskTime.Text = "15";
            this.txtIdxMaskTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdxMaskTime.TextChanged += new System.EventHandler(this.txtIdxMaskTime_TextChanged);
            // 
            // chkIdxMaskTime
            // 
            this.chkIdxMaskTime.AutoSize = true;
            this.chkIdxMaskTime.Location = new System.Drawing.Point(41, 180);
            this.chkIdxMaskTime.Margin = new System.Windows.Forms.Padding(2);
            this.chkIdxMaskTime.Name = "chkIdxMaskTime";
            this.chkIdxMaskTime.Size = new System.Drawing.Size(196, 17);
            this.chkIdxMaskTime.TabIndex = 16;
            this.chkIdxMaskTime.Text = "Index post-trigger mask time (msecs)";
            this.chkIdxMaskTime.UseVisualStyleBackColor = true;
            this.chkIdxMaskTime.CheckedChanged += new System.EventHandler(this.chkIdxMaskTime_CheckedChanged);
            // 
            // txtDelayTrkWriteToChg
            // 
            this.txtDelayTrkWriteToChg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDelayTrkWriteToChg.ForeColor = System.Drawing.Color.White;
            this.txtDelayTrkWriteToChg.Location = new System.Drawing.Point(300, 157);
            this.txtDelayTrkWriteToChg.Margin = new System.Windows.Forms.Padding(2);
            this.txtDelayTrkWriteToChg.Name = "txtDelayTrkWriteToChg";
            this.txtDelayTrkWriteToChg.Size = new System.Drawing.Size(42, 20);
            this.txtDelayTrkWriteToChg.TabIndex = 15;
            this.txtDelayTrkWriteToChg.Text = "15";
            this.txtDelayTrkWriteToChg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelayTrkWriteToChg.TextChanged += new System.EventHandler(this.txtDelayTrkWriteToChg_TextChanged);
            // 
            // chkDelayTrkWriteToChg
            // 
            this.chkDelayTrkWriteToChg.AutoSize = true;
            this.chkDelayTrkWriteToChg.Location = new System.Drawing.Point(41, 157);
            this.chkDelayTrkWriteToChg.Margin = new System.Windows.Forms.Padding(2);
            this.chkDelayTrkWriteToChg.Name = "chkDelayTrkWriteToChg";
            this.chkDelayTrkWriteToChg.Size = new System.Drawing.Size(254, 17);
            this.chkDelayTrkWriteToChg.TabIndex = 14;
            this.chkDelayTrkWriteToChg.Text = "Min. time from write end to track change (msecs)";
            this.chkDelayTrkWriteToChg.UseVisualStyleBackColor = true;
            this.chkDelayTrkWriteToChg.CheckedChanged += new System.EventHandler(this.chkDelayTrkWriteToChg_CheckedChanged);
            // 
            // txtDelayTrkChgToWrite
            // 
            this.txtDelayTrkChgToWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDelayTrkChgToWrite.ForeColor = System.Drawing.Color.White;
            this.txtDelayTrkChgToWrite.Location = new System.Drawing.Point(300, 134);
            this.txtDelayTrkChgToWrite.Margin = new System.Windows.Forms.Padding(2);
            this.txtDelayTrkChgToWrite.Name = "txtDelayTrkChgToWrite";
            this.txtDelayTrkChgToWrite.Size = new System.Drawing.Size(42, 20);
            this.txtDelayTrkChgToWrite.TabIndex = 13;
            this.txtDelayTrkChgToWrite.Text = "15";
            this.txtDelayTrkChgToWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelayTrkChgToWrite.TextChanged += new System.EventHandler(this.txtDelayTrkChgToWrite_TextChanged);
            // 
            // chkDelayTrkChgToWrite
            // 
            this.chkDelayTrkChgToWrite.AutoSize = true;
            this.chkDelayTrkChgToWrite.Location = new System.Drawing.Point(41, 134);
            this.chkDelayTrkChgToWrite.Margin = new System.Windows.Forms.Padding(2);
            this.chkDelayTrkChgToWrite.Name = "chkDelayTrkChgToWrite";
            this.chkDelayTrkChgToWrite.Size = new System.Drawing.Size(256, 17);
            this.chkDelayTrkChgToWrite.TabIndex = 12;
            this.chkDelayTrkChgToWrite.Text = "Min. time from track change to write start (msecs)";
            this.chkDelayTrkChgToWrite.UseVisualStyleBackColor = true;
            this.chkDelayTrkChgToWrite.CheckedChanged += new System.EventHandler(this.chkDelayTrkChgToWrite_CheckedChanged);
            // 
            // DelaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(430, 506);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DelaysForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Delays";
            this.Load += new System.EventHandler(this.DelaysForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSetDelays.ResumeLayout(false);
            this.gbSetDelays.PerformLayout();
            this.ctxOutput.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox lbOutput;
        private System.ComponentModel.BackgroundWorker threadWorker;
        private System.Windows.Forms.ContextMenuStrip ctxOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxClearOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxSaveOutput;
        private System.Windows.Forms.ToolTip toolTipChooser;
        private System.Windows.Forms.TextBox txtIdxMaskTime;
        private System.Windows.Forms.CheckBox chkIdxMaskTime;
        private System.Windows.Forms.TextBox txtDelayTrkWriteToChg;
        private System.Windows.Forms.CheckBox chkDelayTrkWriteToChg;
        private System.Windows.Forms.TextBox txtDelayTrkChgToWrite;
        private System.Windows.Forms.CheckBox chkDelayTrkChgToWrite;
    }
}