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
            this.chkOutTracks = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOTHeadSwap = new System.Windows.Forms.CheckBox();
            this.txtOTDoubleStep = new System.Windows.Forms.TextBox();
            this.chkOTDoubleStep = new System.Windows.Forms.CheckBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
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
            this.lbOutput.ItemHeight = 16;
            this.lbOutput.Location = new System.Drawing.Point(16, 345);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(1066, 132);
            this.lbOutput.TabIndex = 31;
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
            this.ctxOutput.Size = new System.Drawing.Size(163, 52);
            // 
            // ctxClearOutput
            // 
            this.ctxClearOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctxClearOutput.ForeColor = System.Drawing.Color.White;
            this.ctxClearOutput.Name = "ctxClearOutput";
            this.ctxClearOutput.Size = new System.Drawing.Size(162, 24);
            this.ctxClearOutput.Text = "Clear Output";
            this.ctxClearOutput.Click += new System.EventHandler(this.ctxClearOutput_Click);
            // 
            // ctxSaveOutput
            // 
            this.ctxSaveOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctxSaveOutput.ForeColor = System.Drawing.Color.White;
            this.ctxSaveOutput.Name = "ctxSaveOutput";
            this.ctxSaveOutput.Size = new System.Drawing.Size(162, 24);
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
            this.gb1.Location = new System.Drawing.Point(13, 3);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(1097, 557);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(605, 487);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(384, 487);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 32;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(364, 523);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(369, 23);
            this.lblHostTools.TabIndex = 30;
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
            this.groupBox2.Location = new System.Drawing.Point(17, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1063, 319);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.chkOutTracks);
            this.gb3.Controls.Add(this.groupBox1);
            this.gb3.Location = new System.Drawing.Point(536, 14);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(512, 158);
            this.gb3.TabIndex = 16;
            this.gb3.TabStop = false;
            // 
            // chkOutTracks
            // 
            this.chkOutTracks.AutoSize = true;
            this.chkOutTracks.Location = new System.Drawing.Point(19, 66);
            this.chkOutTracks.Name = "chkOutTracks";
            this.chkOutTracks.Size = new System.Drawing.Size(120, 21);
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
            this.groupBox1.Location = new System.Drawing.Point(155, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 59);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // chkOTHeadSwap
            // 
            this.chkOTHeadSwap.AutoSize = true;
            this.chkOTHeadSwap.Location = new System.Drawing.Point(219, 22);
            this.chkOTHeadSwap.Name = "chkOTHeadSwap";
            this.chkOTHeadSwap.Size = new System.Drawing.Size(102, 21);
            this.chkOTHeadSwap.TabIndex = 21;
            this.chkOTHeadSwap.Text = "Head Swap";
            this.chkOTHeadSwap.UseVisualStyleBackColor = true;
            this.chkOTHeadSwap.CheckedChanged += new System.EventHandler(this.chkOTHeadSwap_CheckedChanged);
            // 
            // txtOTDoubleStep
            // 
            this.txtOTDoubleStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtOTDoubleStep.ForeColor = System.Drawing.Color.White;
            this.txtOTDoubleStep.Location = new System.Drawing.Point(162, 20);
            this.txtOTDoubleStep.Name = "txtOTDoubleStep";
            this.txtOTDoubleStep.Size = new System.Drawing.Size(38, 22);
            this.txtOTDoubleStep.TabIndex = 20;
            this.txtOTDoubleStep.Text = "2";
            this.txtOTDoubleStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOTDoubleStep.TextChanged += new System.EventHandler(this.txtOTDoubleStep_TextChanged);
            // 
            // chkOTDoubleStep
            // 
            this.chkOTDoubleStep.AutoSize = true;
            this.chkOTDoubleStep.Location = new System.Drawing.Point(17, 21);
            this.chkOTDoubleStep.Name = "chkOTDoubleStep";
            this.chkOTDoubleStep.Size = new System.Drawing.Size(142, 21);
            this.chkOTDoubleStep.TabIndex = 19;
            this.chkOTDoubleStep.Text = "Double-Step [0-9]";
            this.chkOTDoubleStep.UseVisualStyleBackColor = true;
            this.chkOTDoubleStep.CheckedChanged += new System.EventHandler(this.chkOTDoubleStep_CheckedChanged);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.txtOutputFile);
            this.gb2.Controls.Add(this.txtInputFile);
            this.gb2.Controls.Add(this.btnOutputFile);
            this.gb2.Controls.Add(this.btnInputFile);
            this.gb2.Location = new System.Drawing.Point(14, 178);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(512, 125);
            this.gb2.TabIndex = 22;
            this.gb2.TabStop = false;
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtOutputFile.ForeColor = System.Drawing.Color.White;
            this.txtOutputFile.Location = new System.Drawing.Point(156, 65);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(336, 22);
            this.txtOutputFile.TabIndex = 26;
            this.txtOutputFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOutputFile.TextChanged += new System.EventHandler(this.txtOutputFile_TextChanged);
            // 
            // txtInputFile
            // 
            this.txtInputFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtInputFile.ForeColor = System.Drawing.Color.White;
            this.txtInputFile.Location = new System.Drawing.Point(156, 24);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(336, 22);
            this.txtInputFile.TabIndex = 24;
            this.txtInputFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInputFile.TextChanged += new System.EventHandler(this.txtInputFile_TextChanged);
            // 
            // btnOutputFile
            // 
            this.btnOutputFile.BackColor = System.Drawing.Color.Maroon;
            this.btnOutputFile.Location = new System.Drawing.Point(18, 62);
            this.btnOutputFile.Name = "btnOutputFile";
            this.btnOutputFile.Size = new System.Drawing.Size(115, 29);
            this.btnOutputFile.TabIndex = 25;
            this.btnOutputFile.Text = "Output Folder";
            this.btnOutputFile.UseVisualStyleBackColor = false;
            this.btnOutputFile.Click += new System.EventHandler(this.btnOutputFile_Click);
            // 
            // btnInputFile
            // 
            this.btnInputFile.BackColor = System.Drawing.Color.Maroon;
            this.btnInputFile.Location = new System.Drawing.Point(18, 21);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(115, 29);
            this.btnInputFile.TabIndex = 23;
            this.btnInputFile.Text = "Input File";
            this.btnInputFile.UseVisualStyleBackColor = false;
            this.btnInputFile.Click += new System.EventHandler(this.btnInputFile_Click);
            // 
            // txtConvertCommandLine
            // 
            this.txtConvertCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtConvertCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtConvertCommandLine.Location = new System.Drawing.Point(536, 202);
            this.txtConvertCommandLine.Multiline = true;
            this.txtConvertCommandLine.Name = "txtConvertCommandLine";
            this.txtConvertCommandLine.Size = new System.Drawing.Size(512, 101);
            this.txtConvertCommandLine.TabIndex = 28;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(754, 178);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 27;
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
            this.gbConvert.Location = new System.Drawing.Point(14, 14);
            this.gbConvert.Name = "gbConvert";
            this.gbConvert.Size = new System.Drawing.Size(512, 158);
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
            this.cbAdjustSpeed.Location = new System.Drawing.Point(267, 83);
            this.cbAdjustSpeed.Name = "cbAdjustSpeed";
            this.cbAdjustSpeed.Size = new System.Drawing.Size(90, 24);
            this.cbAdjustSpeed.TabIndex = 13;
            this.cbAdjustSpeed.SelectedIndexChanged += new System.EventHandler(this.cbAdjustSpeed_SelectedIndexChanged);
            // 
            // txtAdjustSpeed
            // 
            this.txtAdjustSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtAdjustSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjustSpeed.ForeColor = System.Drawing.Color.White;
            this.txtAdjustSpeed.Location = new System.Drawing.Point(163, 84);
            this.txtAdjustSpeed.MaxLength = 3;
            this.txtAdjustSpeed.Name = "txtAdjustSpeed";
            this.txtAdjustSpeed.Size = new System.Drawing.Size(90, 22);
            this.txtAdjustSpeed.TabIndex = 12;
            this.txtAdjustSpeed.Text = "300";
            this.txtAdjustSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdjustSpeed.TextChanged += new System.EventHandler(this.txtAdjustSpeed_TextChanged);
            // 
            // chkAdjustSpeed
            // 
            this.chkAdjustSpeed.AutoSize = true;
            this.chkAdjustSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdjustSpeed.Location = new System.Drawing.Point(18, 85);
            this.chkAdjustSpeed.Name = "chkAdjustSpeed";
            this.chkAdjustSpeed.Size = new System.Drawing.Size(115, 21);
            this.chkAdjustSpeed.TabIndex = 11;
            this.chkAdjustSpeed.Text = "Adjust-Speed";
            this.chkAdjustSpeed.UseVisualStyleBackColor = true;
            this.chkAdjustSpeed.CheckedChanged += new System.EventHandler(this.chkAdjustSpeed_CheckedChanged);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(94, 121);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(56, 17);
            this.lblFormat.TabIndex = 14;
            this.lblFormat.Text = "Format:";
            // 
            // chkHeadSwap
            // 
            this.chkHeadSwap.AutoSize = true;
            this.chkHeadSwap.Location = new System.Drawing.Point(288, 53);
            this.chkHeadSwap.Name = "chkHeadSwap";
            this.chkHeadSwap.Size = new System.Drawing.Size(102, 21);
            this.chkHeadSwap.TabIndex = 9;
            this.chkHeadSwap.Text = "Head Swap";
            this.chkHeadSwap.UseVisualStyleBackColor = true;
            this.chkHeadSwap.CheckedChanged += new System.EventHandler(this.chkHeadSwap_CheckedChanged);
            // 
            // txtDoubleStep
            // 
            this.txtDoubleStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDoubleStep.ForeColor = System.Drawing.Color.White;
            this.txtDoubleStep.Location = new System.Drawing.Point(162, 20);
            this.txtDoubleStep.Name = "txtDoubleStep";
            this.txtDoubleStep.Size = new System.Drawing.Size(112, 22);
            this.txtDoubleStep.TabIndex = 4;
            this.txtDoubleStep.Text = "2";
            this.txtDoubleStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDoubleStep.TextChanged += new System.EventHandler(this.txtDoubleStep_TextChanged);
            // 
            // chkDoubleStep
            // 
            this.chkDoubleStep.AutoSize = true;
            this.chkDoubleStep.Location = new System.Drawing.Point(17, 21);
            this.chkDoubleStep.Name = "chkDoubleStep";
            this.chkDoubleStep.Size = new System.Drawing.Size(142, 21);
            this.chkDoubleStep.TabIndex = 3;
            this.chkDoubleStep.Text = "Double-Step [0-9]";
            this.chkDoubleStep.UseVisualStyleBackColor = true;
            this.chkDoubleStep.CheckedChanged += new System.EventHandler(this.chkDoubleStep_CheckedChanged);
            // 
            // chkNoClobber
            // 
            this.chkNoClobber.AutoSize = true;
            this.chkNoClobber.Location = new System.Drawing.Point(401, 53);
            this.chkNoClobber.Name = "chkNoClobber";
            this.chkNoClobber.Size = new System.Drawing.Size(101, 21);
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
            this.cbFormat.Items.AddRange(new object[] {
            "",
            "acorn.dfs.ss",
            "acorn.dfs.ds",
            "acorn.adfs.160",
            "acorn.adfs.320",
            "acorn.adfs.640",
            "acorn.adfs.800",
            "acorn.adfs.1600",
            "amiga.amigados",
            "amiga.amigados_hd",
            "akai.800",
            "akai.1600",
            "atari.90",
            "atarist.360",
            "atarist.400",
            "atarist.440",
            "atarist.720",
            "atarist.800",
            "atarist.880",
            "commodore.1581",
            "ensoniq.800",
            "ensoniq.1600",
            "ibm.180",
            "ibm.360",
            "ibm.720",
            "ibm.1200",
            "ibm.1440",
            "ibm.1680",
            "ibm.dmf",
            "sega.sf7000"});
            this.cbFormat.Location = new System.Drawing.Point(165, 118);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(335, 24);
            this.cbFormat.TabIndex = 15;
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // chkHeadsSet
            // 
            this.chkHeadsSet.AutoSize = true;
            this.chkHeadsSet.Location = new System.Drawing.Point(288, 22);
            this.chkHeadsSet.Name = "chkHeadsSet";
            this.chkHeadsSet.Size = new System.Drawing.Size(94, 21);
            this.chkHeadsSet.TabIndex = 5;
            this.chkHeadsSet.Text = "Head sets";
            this.chkHeadsSet.UseVisualStyleBackColor = true;
            this.chkHeadsSet.CheckedChanged += new System.EventHandler(this.chkHeadsSet_CheckedChanged_1);
            // 
            // txtHeadsSet
            // 
            this.txtHeadsSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtHeadsSet.ForeColor = System.Drawing.Color.White;
            this.txtHeadsSet.Location = new System.Drawing.Point(385, 22);
            this.txtHeadsSet.Name = "txtHeadsSet";
            this.txtHeadsSet.Size = new System.Drawing.Size(112, 22);
            this.txtHeadsSet.TabIndex = 6;
            this.txtHeadsSet.Text = "0-1";
            this.txtHeadsSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeadsSet.TextChanged += new System.EventHandler(this.txtHeadsSet_TextChanged_1);
            // 
            // chkCylSet
            // 
            this.chkCylSet.AutoSize = true;
            this.chkCylSet.Location = new System.Drawing.Point(17, 53);
            this.chkCylSet.Name = "chkCylSet";
            this.chkCylSet.Size = new System.Drawing.Size(111, 21);
            this.chkCylSet.TabIndex = 7;
            this.chkCylSet.Text = "Cylinder sets";
            this.chkCylSet.UseVisualStyleBackColor = true;
            this.chkCylSet.CheckedChanged += new System.EventHandler(this.chkCylSet_CheckedChanged_1);
            // 
            // txtCylSet
            // 
            this.txtCylSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCylSet.ForeColor = System.Drawing.Color.White;
            this.txtCylSet.Location = new System.Drawing.Point(162, 52);
            this.txtCylSet.Name = "txtCylSet";
            this.txtCylSet.Size = new System.Drawing.Size(112, 22);
            this.txtCylSet.TabIndex = 8;
            this.txtCylSet.Text = "0-34,35-79";
            this.txtCylSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCylSet.TextChanged += new System.EventHandler(this.txtCylSet_TextChanged_1);
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1126, 573);
            this.Controls.Add(this.gb1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}