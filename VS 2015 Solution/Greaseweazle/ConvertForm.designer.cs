// ConvertForm.Designer.cs
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
    partial class ConvertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertForm));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.threadWorker = new System.ComponentModel.BackgroundWorker();
            this.ctxOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxClearOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSaveOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.lblHostTools = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.chkPLLSpec = new System.Windows.Forms.CheckBox();
            this.txtPLLPhase = new System.Windows.Forms.TextBox();
            this.lblPLLPhase = new System.Windows.Forms.Label();
            this.txtPLLPeriod = new System.Windows.Forms.TextBox();
            this.lblPLLPeriod = new System.Windows.Forms.Label();
            this.chkOutTracks = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOTHeadSwap = new System.Windows.Forms.CheckBox();
            this.txtOTDoubleStep = new System.Windows.Forms.TextBox();
            this.chkOTDoubleStep = new System.Windows.Forms.CheckBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.lblDiskType = new System.Windows.Forms.Label();
            this.cbExtension = new System.Windows.Forms.ComboBox();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.btnOutputFile = new System.Windows.Forms.Button();
            this.btnInputFile = new System.Windows.Forms.Button();
            this.txtConvertCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.gbConvert = new System.Windows.Forms.GroupBox();
            this.cbAdjustSpeed = new System.Windows.Forms.ComboBox();
            this.txtAdjustSpeed = new System.Windows.Forms.TextBox();
            this.chkAdjustSpeed = new System.Windows.Forms.CheckBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.chkHeadSwap = new System.Windows.Forms.CheckBox();
            this.txtDoubleStep = new System.Windows.Forms.TextBox();
            this.chkDoubleStep = new System.Windows.Forms.CheckBox();
            this.chkNoClobber = new System.Windows.Forms.CheckBox();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.chkHeadsSet = new System.Windows.Forms.CheckBox();
            this.txtHeadsSet = new System.Windows.Forms.TextBox();
            this.chkCylSet = new System.Windows.Forms.CheckBox();
            this.txtCylSet = new System.Windows.Forms.TextBox();
            this.chkHardSectors = new System.Windows.Forms.CheckBox();
            this.ctxOutput.SuspendLayout();
            this.gb1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gbConvert.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOutput
            // 
            this.lbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbOutput.ForeColor = System.Drawing.Color.White;
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.HorizontalScrollbar = true;
            this.lbOutput.ItemHeight = 24;
            this.lbOutput.Location = new System.Drawing.Point(22, 518);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(1464, 196);
            this.lbOutput.TabIndex = 37;
            this.toolTip.SetToolTip(this.lbOutput, "Right click for options");
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
            this.ctxOutput.Size = new System.Drawing.Size(206, 72);
            // 
            // ctxClearOutput
            // 
            this.ctxClearOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctxClearOutput.ForeColor = System.Drawing.Color.White;
            this.ctxClearOutput.Name = "ctxClearOutput";
            this.ctxClearOutput.Size = new System.Drawing.Size(205, 34);
            this.ctxClearOutput.Text = "Clear Output";
            this.ctxClearOutput.Click += new System.EventHandler(this.ctxClearOutput_Click);
            // 
            // ctxSaveOutput
            // 
            this.ctxSaveOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctxSaveOutput.ForeColor = System.Drawing.Color.White;
            this.ctxSaveOutput.Name = "ctxSaveOutput";
            this.ctxSaveOutput.Size = new System.Drawing.Size(205, 34);
            this.ctxSaveOutput.Text = "Save Output";
            this.ctxSaveOutput.Click += new System.EventHandler(this.ctxSaveOutput_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnBack);
            this.gb1.Controls.Add(this.btnLaunch);
            this.gb1.Controls.Add(this.lbOutput);
            this.gb1.Controls.Add(this.lblHostTools);
            this.gb1.Controls.Add(this.groupBox2);
            this.gb1.Location = new System.Drawing.Point(18, 4);
            this.gb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb1.Size = new System.Drawing.Size(1508, 836);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(832, 730);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 44);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(528, 730);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(148, 44);
            this.btnLaunch.TabIndex = 38;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(500, 784);
            this.lblHostTools.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(507, 34);
            this.lblHostTools.TabIndex = 40;
            this.lblHostTools.Text = "for Host Tools v0.00";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gb3);
            this.groupBox2.Controls.Add(this.gb2);
            this.groupBox2.Controls.Add(this.txtConvertCommandLine);
            this.groupBox2.Controls.Add(this.lblStaticCL);
            this.groupBox2.Controls.Add(this.gbConvert);
            this.groupBox2.Location = new System.Drawing.Point(23, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1462, 478);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.chkHardSectors);
            this.gb3.Controls.Add(this.chkPLLSpec);
            this.gb3.Controls.Add(this.txtPLLPhase);
            this.gb3.Controls.Add(this.lblPLLPhase);
            this.gb3.Controls.Add(this.txtPLLPeriod);
            this.gb3.Controls.Add(this.lblPLLPeriod);
            this.gb3.Controls.Add(this.chkOutTracks);
            this.gb3.Controls.Add(this.groupBox1);
            this.gb3.Location = new System.Drawing.Point(737, 21);
            this.gb3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb3.Name = "gb3";
            this.gb3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb3.Size = new System.Drawing.Size(704, 237);
            this.gb3.TabIndex = 16;
            this.gb3.TabStop = false;
            // 
            // chkPLLSpec
            // 
            this.chkPLLSpec.AutoSize = true;
            this.chkPLLSpec.Location = new System.Drawing.Point(26, 162);
            this.chkPLLSpec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPLLSpec.Name = "chkPLLSpec";
            this.chkPLLSpec.Size = new System.Drawing.Size(128, 29);
            this.chkPLLSpec.TabIndex = 23;
            this.chkPLLSpec.Text = "PLLSPEC";
            this.chkPLLSpec.UseVisualStyleBackColor = true;
            this.chkPLLSpec.CheckedChanged += new System.EventHandler(this.chkPLLSpec_CheckedChanged);
            // 
            // txtPLLPhase
            // 
            this.txtPLLPhase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPLLPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLLPhase.ForeColor = System.Drawing.Color.White;
            this.txtPLLPhase.Location = new System.Drawing.Point(454, 160);
            this.txtPLLPhase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPLLPhase.MaxLength = 3;
            this.txtPLLPhase.Name = "txtPLLPhase";
            this.txtPLLPhase.Size = new System.Drawing.Size(74, 28);
            this.txtPLLPhase.TabIndex = 27;
            this.txtPLLPhase.Text = "60";
            this.txtPLLPhase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPLLPhase.TextChanged += new System.EventHandler(this.txtPLLPhase_TextChanged);
            // 
            // lblPLLPhase
            // 
            this.lblPLLPhase.AutoSize = true;
            this.lblPLLPhase.Location = new System.Drawing.Point(382, 165);
            this.lblPLLPhase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPLLPhase.Name = "lblPLLPhase";
            this.lblPLLPhase.Size = new System.Drawing.Size(74, 25);
            this.lblPLLPhase.TabIndex = 26;
            this.lblPLLPhase.Text = "Phase:";
            // 
            // txtPLLPeriod
            // 
            this.txtPLLPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPLLPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLLPeriod.ForeColor = System.Drawing.Color.White;
            this.txtPLLPeriod.Location = new System.Drawing.Point(282, 160);
            this.txtPLLPeriod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPLLPeriod.MaxLength = 3;
            this.txtPLLPeriod.Name = "txtPLLPeriod";
            this.txtPLLPeriod.Size = new System.Drawing.Size(74, 28);
            this.txtPLLPeriod.TabIndex = 25;
            this.txtPLLPeriod.Text = "5";
            this.txtPLLPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPLLPeriod.TextChanged += new System.EventHandler(this.txtPLLPeriod_TextChanged);
            // 
            // lblPLLPeriod
            // 
            this.lblPLLPeriod.AutoSize = true;
            this.lblPLLPeriod.Location = new System.Drawing.Point(210, 165);
            this.lblPLLPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPLLPeriod.Name = "lblPLLPeriod";
            this.lblPLLPeriod.Size = new System.Drawing.Size(74, 25);
            this.lblPLLPeriod.TabIndex = 24;
            this.lblPLLPeriod.Text = "Period:";
            // 
            // chkOutTracks
            // 
            this.chkOutTracks.AutoSize = true;
            this.chkOutTracks.Location = new System.Drawing.Point(26, 63);
            this.chkOutTracks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkOutTracks.Name = "chkOutTracks";
            this.chkOutTracks.Size = new System.Drawing.Size(162, 29);
            this.chkOutTracks.TabIndex = 17;
            this.chkOutTracks.Text = "Output Tracks";
            this.chkOutTracks.UseVisualStyleBackColor = true;
            this.chkOutTracks.CheckedChanged += new System.EventHandler(this.chkOutTracks_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOTHeadSwap);
            this.groupBox1.Controls.Add(this.txtOTDoubleStep);
            this.groupBox1.Controls.Add(this.chkOTDoubleStep);
            this.groupBox1.Location = new System.Drawing.Point(213, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(459, 88);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // chkOTHeadSwap
            // 
            this.chkOTHeadSwap.AutoSize = true;
            this.chkOTHeadSwap.Location = new System.Drawing.Point(301, 33);
            this.chkOTHeadSwap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkOTHeadSwap.Name = "chkOTHeadSwap";
            this.chkOTHeadSwap.Size = new System.Drawing.Size(140, 29);
            this.chkOTHeadSwap.TabIndex = 21;
            this.chkOTHeadSwap.Text = "Head Swap";
            this.chkOTHeadSwap.UseVisualStyleBackColor = true;
            this.chkOTHeadSwap.CheckedChanged += new System.EventHandler(this.chkOTHeadSwap_CheckedChanged);
            // 
            // txtOTDoubleStep
            // 
            this.txtOTDoubleStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtOTDoubleStep.ForeColor = System.Drawing.Color.White;
            this.txtOTDoubleStep.Location = new System.Drawing.Point(223, 30);
            this.txtOTDoubleStep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOTDoubleStep.Name = "txtOTDoubleStep";
            this.txtOTDoubleStep.Size = new System.Drawing.Size(51, 29);
            this.txtOTDoubleStep.TabIndex = 20;
            this.txtOTDoubleStep.Text = "2";
            this.txtOTDoubleStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOTDoubleStep.TextChanged += new System.EventHandler(this.txtOTDoubleStep_TextChanged);
            // 
            // chkOTDoubleStep
            // 
            this.chkOTDoubleStep.AutoSize = true;
            this.chkOTDoubleStep.Location = new System.Drawing.Point(23, 32);
            this.chkOTDoubleStep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkOTDoubleStep.Name = "chkOTDoubleStep";
            this.chkOTDoubleStep.Size = new System.Drawing.Size(194, 29);
            this.chkOTDoubleStep.TabIndex = 19;
            this.chkOTDoubleStep.Text = "Double-Step [0-9]";
            this.chkOTDoubleStep.UseVisualStyleBackColor = true;
            this.chkOTDoubleStep.CheckedChanged += new System.EventHandler(this.chkOTDoubleStep_CheckedChanged);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.lblDiskType);
            this.gb2.Controls.Add(this.cbExtension);
            this.gb2.Controls.Add(this.txtOutputFile);
            this.gb2.Controls.Add(this.txtInputFile);
            this.gb2.Controls.Add(this.btnOutputFile);
            this.gb2.Controls.Add(this.btnInputFile);
            this.gb2.Location = new System.Drawing.Point(19, 267);
            this.gb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb2.Name = "gb2";
            this.gb2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb2.Size = new System.Drawing.Size(704, 188);
            this.gb2.TabIndex = 28;
            this.gb2.TabStop = false;
            // 
            // lblDiskType
            // 
            this.lblDiskType.AutoSize = true;
            this.lblDiskType.Location = new System.Drawing.Point(25, 136);
            this.lblDiskType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiskType.Name = "lblDiskType";
            this.lblDiskType.Size = new System.Drawing.Size(165, 25);
            this.lblDiskType.TabIndex = 33;
            this.lblDiskType.Text = "Output DiskType:";
            // 
            // cbExtension
            // 
            this.cbExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbExtension.ForeColor = System.Drawing.Color.White;
            this.cbExtension.FormattingEnabled = true;
            this.cbExtension.Location = new System.Drawing.Point(217, 132);
            this.cbExtension.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbExtension.Name = "cbExtension";
            this.cbExtension.Size = new System.Drawing.Size(224, 32);
            this.cbExtension.TabIndex = 34;
            this.cbExtension.SelectedIndexChanged += new System.EventHandler(this.cbExtension_SelectedIndexChanged);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtOutputFile.ForeColor = System.Drawing.Color.White;
            this.txtOutputFile.Location = new System.Drawing.Point(214, 81);
            this.txtOutputFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(460, 29);
            this.txtOutputFile.TabIndex = 32;
            this.txtOutputFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOutputFile.TextChanged += new System.EventHandler(this.txtOutputFile_TextChanged);
            // 
            // txtInputFile
            // 
            this.txtInputFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtInputFile.ForeColor = System.Drawing.Color.White;
            this.txtInputFile.Location = new System.Drawing.Point(214, 30);
            this.txtInputFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(460, 29);
            this.txtInputFile.TabIndex = 30;
            this.txtInputFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInputFile.TextChanged += new System.EventHandler(this.txtInputFile_TextChanged);
            // 
            // btnOutputFile
            // 
            this.btnOutputFile.BackColor = System.Drawing.Color.Maroon;
            this.btnOutputFile.Location = new System.Drawing.Point(25, 76);
            this.btnOutputFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOutputFile.Name = "btnOutputFile";
            this.btnOutputFile.Size = new System.Drawing.Size(158, 44);
            this.btnOutputFile.TabIndex = 31;
            this.btnOutputFile.Text = "Output Folder";
            this.btnOutputFile.UseVisualStyleBackColor = false;
            this.btnOutputFile.Click += new System.EventHandler(this.btnOutputFile_Click);
            // 
            // btnInputFile
            // 
            this.btnInputFile.BackColor = System.Drawing.Color.Maroon;
            this.btnInputFile.Location = new System.Drawing.Point(25, 26);
            this.btnInputFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(158, 44);
            this.btnInputFile.TabIndex = 29;
            this.btnInputFile.Text = "Input File";
            this.btnInputFile.UseVisualStyleBackColor = false;
            this.btnInputFile.Click += new System.EventHandler(this.btnInputFile_Click);
            // 
            // txtConvertCommandLine
            // 
            this.txtConvertCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtConvertCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtConvertCommandLine.Location = new System.Drawing.Point(737, 303);
            this.txtConvertCommandLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConvertCommandLine.Multiline = true;
            this.txtConvertCommandLine.Name = "txtConvertCommandLine";
            this.txtConvertCommandLine.Size = new System.Drawing.Size(702, 150);
            this.txtConvertCommandLine.TabIndex = 36;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(1037, 267);
            this.lblStaticCL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(145, 25);
            this.lblStaticCL.TabIndex = 35;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbConvert
            // 
            this.gbConvert.Controls.Add(this.cbAdjustSpeed);
            this.gbConvert.Controls.Add(this.txtAdjustSpeed);
            this.gbConvert.Controls.Add(this.chkAdjustSpeed);
            this.gbConvert.Controls.Add(this.lblFormat);
            this.gbConvert.Controls.Add(this.chkHeadSwap);
            this.gbConvert.Controls.Add(this.txtDoubleStep);
            this.gbConvert.Controls.Add(this.chkDoubleStep);
            this.gbConvert.Controls.Add(this.chkNoClobber);
            this.gbConvert.Controls.Add(this.cbFormat);
            this.gbConvert.Controls.Add(this.chkHeadsSet);
            this.gbConvert.Controls.Add(this.txtHeadsSet);
            this.gbConvert.Controls.Add(this.chkCylSet);
            this.gbConvert.Controls.Add(this.txtCylSet);
            this.gbConvert.Location = new System.Drawing.Point(19, 21);
            this.gbConvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConvert.Name = "gbConvert";
            this.gbConvert.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConvert.Size = new System.Drawing.Size(704, 237);
            this.gbConvert.TabIndex = 2;
            this.gbConvert.TabStop = false;
            // 
            // cbAdjustSpeed
            // 
            this.cbAdjustSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbAdjustSpeed.ForeColor = System.Drawing.Color.White;
            this.cbAdjustSpeed.FormattingEnabled = true;
            this.cbAdjustSpeed.Items.AddRange(new object[] {
            "",
            "rpm",
            "ms",
            "us",
            "ns",
            "scp"});
            this.cbAdjustSpeed.Location = new System.Drawing.Point(367, 124);
            this.cbAdjustSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAdjustSpeed.Name = "cbAdjustSpeed";
            this.cbAdjustSpeed.Size = new System.Drawing.Size(122, 32);
            this.cbAdjustSpeed.TabIndex = 13;
            this.cbAdjustSpeed.SelectedIndexChanged += new System.EventHandler(this.cbAdjustSpeed_SelectedIndexChanged);
            // 
            // txtAdjustSpeed
            // 
            this.txtAdjustSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtAdjustSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjustSpeed.ForeColor = System.Drawing.Color.White;
            this.txtAdjustSpeed.Location = new System.Drawing.Point(224, 126);
            this.txtAdjustSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdjustSpeed.MaxLength = 3;
            this.txtAdjustSpeed.Name = "txtAdjustSpeed";
            this.txtAdjustSpeed.Size = new System.Drawing.Size(122, 28);
            this.txtAdjustSpeed.TabIndex = 12;
            this.txtAdjustSpeed.Text = "300";
            this.txtAdjustSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdjustSpeed.TextChanged += new System.EventHandler(this.txtAdjustSpeed_TextChanged);
            // 
            // chkAdjustSpeed
            // 
            this.chkAdjustSpeed.AutoSize = true;
            this.chkAdjustSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdjustSpeed.Location = new System.Drawing.Point(25, 128);
            this.chkAdjustSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAdjustSpeed.Name = "chkAdjustSpeed";
            this.chkAdjustSpeed.Size = new System.Drawing.Size(150, 28);
            this.chkAdjustSpeed.TabIndex = 11;
            this.chkAdjustSpeed.Text = "Adjust-Speed";
            this.chkAdjustSpeed.UseVisualStyleBackColor = true;
            this.chkAdjustSpeed.CheckedChanged += new System.EventHandler(this.chkAdjustSpeed_CheckedChanged);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(129, 182);
            this.lblFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(79, 25);
            this.lblFormat.TabIndex = 14;
            this.lblFormat.Text = "Format:";
            // 
            // chkHeadSwap
            // 
            this.chkHeadSwap.AutoSize = true;
            this.chkHeadSwap.Location = new System.Drawing.Point(396, 80);
            this.chkHeadSwap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHeadSwap.Name = "chkHeadSwap";
            this.chkHeadSwap.Size = new System.Drawing.Size(140, 29);
            this.chkHeadSwap.TabIndex = 9;
            this.chkHeadSwap.Text = "Head Swap";
            this.chkHeadSwap.UseVisualStyleBackColor = true;
            this.chkHeadSwap.CheckedChanged += new System.EventHandler(this.chkHeadSwap_CheckedChanged);
            // 
            // txtDoubleStep
            // 
            this.txtDoubleStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDoubleStep.ForeColor = System.Drawing.Color.White;
            this.txtDoubleStep.Location = new System.Drawing.Point(223, 30);
            this.txtDoubleStep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoubleStep.Name = "txtDoubleStep";
            this.txtDoubleStep.Size = new System.Drawing.Size(152, 29);
            this.txtDoubleStep.TabIndex = 4;
            this.txtDoubleStep.Text = "2";
            this.txtDoubleStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDoubleStep.TextChanged += new System.EventHandler(this.txtDoubleStep_TextChanged);
            // 
            // chkDoubleStep
            // 
            this.chkDoubleStep.AutoSize = true;
            this.chkDoubleStep.Location = new System.Drawing.Point(23, 32);
            this.chkDoubleStep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDoubleStep.Name = "chkDoubleStep";
            this.chkDoubleStep.Size = new System.Drawing.Size(194, 29);
            this.chkDoubleStep.TabIndex = 3;
            this.chkDoubleStep.Text = "Double-Step [0-9]";
            this.chkDoubleStep.UseVisualStyleBackColor = true;
            this.chkDoubleStep.CheckedChanged += new System.EventHandler(this.chkDoubleStep_CheckedChanged);
            // 
            // chkNoClobber
            // 
            this.chkNoClobber.AutoSize = true;
            this.chkNoClobber.Location = new System.Drawing.Point(551, 80);
            this.chkNoClobber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNoClobber.Name = "chkNoClobber";
            this.chkNoClobber.Size = new System.Drawing.Size(137, 29);
            this.chkNoClobber.TabIndex = 10;
            this.chkNoClobber.Text = "No Clobber";
            this.chkNoClobber.UseVisualStyleBackColor = true;
            this.chkNoClobber.CheckedChanged += new System.EventHandler(this.chkNoClobber_CheckedChanged);
            // 
            // cbFormat
            // 
            this.cbFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbFormat.ForeColor = System.Drawing.Color.White;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(227, 177);
            this.cbFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(459, 32);
            this.cbFormat.TabIndex = 15;
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // chkHeadsSet
            // 
            this.chkHeadsSet.AutoSize = true;
            this.chkHeadsSet.Location = new System.Drawing.Point(396, 33);
            this.chkHeadsSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHeadsSet.Name = "chkHeadsSet";
            this.chkHeadsSet.Size = new System.Drawing.Size(126, 29);
            this.chkHeadsSet.TabIndex = 5;
            this.chkHeadsSet.Text = "Head sets";
            this.chkHeadsSet.UseVisualStyleBackColor = true;
            this.chkHeadsSet.CheckedChanged += new System.EventHandler(this.chkHeadsSet_CheckedChanged_1);
            // 
            // txtHeadsSet
            // 
            this.txtHeadsSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtHeadsSet.ForeColor = System.Drawing.Color.White;
            this.txtHeadsSet.Location = new System.Drawing.Point(529, 33);
            this.txtHeadsSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHeadsSet.Name = "txtHeadsSet";
            this.txtHeadsSet.Size = new System.Drawing.Size(152, 29);
            this.txtHeadsSet.TabIndex = 6;
            this.txtHeadsSet.Text = "0-1";
            this.txtHeadsSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeadsSet.TextChanged += new System.EventHandler(this.txtHeadsSet_TextChanged_1);
            // 
            // chkCylSet
            // 
            this.chkCylSet.AutoSize = true;
            this.chkCylSet.Location = new System.Drawing.Point(23, 80);
            this.chkCylSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCylSet.Name = "chkCylSet";
            this.chkCylSet.Size = new System.Drawing.Size(151, 29);
            this.chkCylSet.TabIndex = 7;
            this.chkCylSet.Text = "Cylinder sets";
            this.chkCylSet.UseVisualStyleBackColor = true;
            this.chkCylSet.CheckedChanged += new System.EventHandler(this.chkCylSet_CheckedChanged_1);
            // 
            // txtCylSet
            // 
            this.txtCylSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCylSet.ForeColor = System.Drawing.Color.White;
            this.txtCylSet.Location = new System.Drawing.Point(223, 78);
            this.txtCylSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCylSet.Name = "txtCylSet";
            this.txtCylSet.Size = new System.Drawing.Size(152, 29);
            this.txtCylSet.TabIndex = 8;
            this.txtCylSet.Text = "0-34,35-79";
            this.txtCylSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCylSet.TextChanged += new System.EventHandler(this.txtCylSet_TextChanged_1);
            // 
            // chkHardSectors
            // 
            this.chkHardSectors.AutoSize = true;
            this.chkHardSectors.Location = new System.Drawing.Point(26, 110);
            this.chkHardSectors.Margin = new System.Windows.Forms.Padding(4);
            this.chkHardSectors.Name = "chkHardSectors";
            this.chkHardSectors.Size = new System.Drawing.Size(152, 29);
            this.chkHardSectors.TabIndex = 22;
            this.chkHardSectors.Text = "Hard Sectors";
            this.chkHardSectors.UseVisualStyleBackColor = true;
            this.chkHardSectors.CheckedChanged += new System.EventHandler(this.chkHardSectors_CheckedChanged);
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1548, 860);
            this.Controls.Add(this.gb1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConvertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Convert Files";
            this.Load += new System.EventHandler(this.ConvertForm_Load);
            this.ctxOutput.ResumeLayout(false);
            this.gb1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gbConvert.ResumeLayout(false);
            this.gbConvert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.ComponentModel.BackgroundWorker threadWorker;
        private System.Windows.Forms.ContextMenuStrip ctxOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxClearOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxSaveOutput;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label lblHostTools;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.CheckBox chkOutTracks;
        private System.Windows.Forms.CheckBox chkOTHeadSwap;
        private System.Windows.Forms.TextBox txtOTDoubleStep;
        private System.Windows.Forms.CheckBox chkOTDoubleStep;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Button btnOutputFile;
        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.TextBox txtConvertCommandLine;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.GroupBox gbConvert;
        private System.Windows.Forms.ComboBox cbAdjustSpeed;
        private System.Windows.Forms.TextBox txtAdjustSpeed;
        private System.Windows.Forms.CheckBox chkAdjustSpeed;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.CheckBox chkHeadSwap;
        private System.Windows.Forms.TextBox txtDoubleStep;
        private System.Windows.Forms.CheckBox chkDoubleStep;
        private System.Windows.Forms.CheckBox chkNoClobber;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.CheckBox chkHeadsSet;
        private System.Windows.Forms.TextBox txtHeadsSet;
        private System.Windows.Forms.CheckBox chkCylSet;
        private System.Windows.Forms.TextBox txtCylSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkPLLSpec;
        private System.Windows.Forms.TextBox txtPLLPhase;
        private System.Windows.Forms.Label lblPLLPhase;
        private System.Windows.Forms.TextBox txtPLLPeriod;
        private System.Windows.Forms.Label lblPLLPeriod;
        private System.Windows.Forms.Label lblDiskType;
        private System.Windows.Forms.ComboBox cbExtension;
        private System.Windows.Forms.CheckBox chkHardSectors;
    }
}