﻿// EraseForm.Designer.cs
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
    partial class RPMForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPMForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.lblHostTools = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.gbEraseDisk = new System.Windows.Forms.GroupBox();
            this.chkIterations = new System.Windows.Forms.CheckBox();
            this.txtDriveSelect = new System.Windows.Forms.TextBox();
            this.chkDriveSelect = new System.Windows.Forms.CheckBox();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.threadWorker = new System.ComponentModel.BackgroundWorker();
            this.ctxOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxClearOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSaveOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.gbEraseDisk.SuspendLayout();
            this.ctxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbOutput);
            this.groupBox1.Controls.Add(this.lblHostTools);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnLaunch);
            this.groupBox1.Controls.Add(this.txtCommandLine);
            this.groupBox1.Controls.Add(this.lblStaticCL);
            this.groupBox1.Controls.Add(this.gbEraseDisk);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 420);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbOutput
            // 
            this.lbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbOutput.ForeColor = System.Drawing.Color.White;
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.HorizontalScrollbar = true;
            this.lbOutput.ItemHeight = 16;
            this.lbOutput.Location = new System.Drawing.Point(16, 236);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(513, 100);
            this.lbOutput.TabIndex = 53;
            this.toolTip.SetToolTip(this.lbOutput, "Right click for options");
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(89, 384);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(367, 23);
            this.lblHostTools.TabIndex = 14;
            this.lblHostTools.Text = "for Host Tools v0.00";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(329, 346);
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
            this.btnLaunch.Location = new System.Drawing.Point(108, 346);
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
            this.txtCommandLine.Location = new System.Drawing.Point(16, 148);
            this.txtCommandLine.Multiline = true;
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(512, 74);
            this.txtCommandLine.TabIndex = 10;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(221, 120);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 9;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbEraseDisk
            // 
            this.gbEraseDisk.Controls.Add(this.chkIterations);
            this.gbEraseDisk.Controls.Add(this.txtDriveSelect);
            this.gbEraseDisk.Controls.Add(this.chkDriveSelect);
            this.gbEraseDisk.Controls.Add(this.txtIterations);
            this.gbEraseDisk.Location = new System.Drawing.Point(16, 16);
            this.gbEraseDisk.Name = "gbEraseDisk";
            this.gbEraseDisk.Size = new System.Drawing.Size(512, 95);
            this.gbEraseDisk.TabIndex = 2;
            this.gbEraseDisk.TabStop = false;
            this.gbEraseDisk.Enter += new System.EventHandler(this.gbEraseDisk_Enter);
            // 
            // chkIterations
            // 
            this.chkIterations.AutoSize = true;
            this.chkIterations.Location = new System.Drawing.Point(107, 26);
            this.chkIterations.Name = "chkIterations";
            this.chkIterations.Size = new System.Drawing.Size(88, 21);
            this.chkIterations.TabIndex = 8;
            this.chkIterations.Text = "Iterations";
            this.toolTip.SetToolTip(this.chkIterations, "Host Tools v0.27 or later\r\n");
            this.chkIterations.UseVisualStyleBackColor = true;
            this.chkIterations.CheckedChanged += new System.EventHandler(this.chkMotorOn_CheckedChanged);
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
            this.chkDriveSelect.Location = new System.Drawing.Point(107, 53);
            this.chkDriveSelect.Name = "chkDriveSelect";
            this.chkDriveSelect.Size = new System.Drawing.Size(182, 21);
            this.chkDriveSelect.TabIndex = 5;
            this.chkDriveSelect.Text = "F7 Drive Select (AB012)";
            this.toolTip.SetToolTip(this.chkDriveSelect, "Host Tools v0.18 or later\r\nRequires F7 type");
            this.chkDriveSelect.UseVisualStyleBackColor = true;
            this.chkDriveSelect.CheckedChanged += new System.EventHandler(this.chkDriveSelect_CheckedChanged);
            // 
            // txtIterations
            // 
            this.txtIterations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtIterations.ForeColor = System.Drawing.Color.White;
            this.txtIterations.Location = new System.Drawing.Point(352, 25);
            this.txtIterations.MaxLength = 2;
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(54, 22);
            this.txtIterations.TabIndex = 4;
            this.txtIterations.Text = "1";
            this.txtIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIterations.TextChanged += new System.EventHandler(this.txtWriteFirstCyl_TextChanged);
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
            // RPMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(574, 451);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPMForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Measure RPM of drive spindle";
            this.Load += new System.EventHandler(this.RPMForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEraseDisk.ResumeLayout(false);
            this.gbEraseDisk.PerformLayout();
            this.ctxOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbEraseDisk;
        private System.Windows.Forms.TextBox txtDriveSelect;
        private System.Windows.Forms.CheckBox chkDriveSelect;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox chkIterations;
        private System.Windows.Forms.Label lblHostTools;
        private System.Windows.Forms.ListBox lbOutput;
        private System.ComponentModel.BackgroundWorker threadWorker;
        private System.Windows.Forms.ContextMenuStrip ctxOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxClearOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxSaveOutput;
    }
}