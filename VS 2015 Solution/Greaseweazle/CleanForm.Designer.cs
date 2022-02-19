// ResetForm.Designer.cs
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
    partial class CleanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CleanForm));
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.gbEraseDisk = new System.Windows.Forms.GroupBox();
            this.chkLinger = new System.Windows.Forms.CheckBox();
            this.txtLinger = new System.Windows.Forms.TextBox();
            this.chkPasses = new System.Windows.Forms.CheckBox();
            this.txtPasses = new System.Windows.Forms.TextBox();
            this.chkCylSet = new System.Windows.Forms.CheckBox();
            this.txtCylSet = new System.Windows.Forms.TextBox();
            this.txtDriveSelect = new System.Windows.Forms.TextBox();
            this.chkDriveSelect = new System.Windows.Forms.CheckBox();
            this.txtCleanCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.lblHostTools = new System.Windows.Forms.Label();
            this.threadWorker = new System.ComponentModel.BackgroundWorker();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.toolTipChooser = new System.Windows.Forms.ToolTip(this.components);
            this.ctxOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxClearOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSaveOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.gbEraseDisk.SuspendLayout();
            this.ctxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.gbEraseDisk);
            this.gb1.Controls.Add(this.txtCleanCommandLine);
            this.gb1.Controls.Add(this.lblStaticCL);
            this.gb1.Location = new System.Drawing.Point(15, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(543, 289);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            // 
            // gbEraseDisk
            // 
            this.gbEraseDisk.Controls.Add(this.chkLinger);
            this.gbEraseDisk.Controls.Add(this.txtLinger);
            this.gbEraseDisk.Controls.Add(this.chkPasses);
            this.gbEraseDisk.Controls.Add(this.txtPasses);
            this.gbEraseDisk.Controls.Add(this.chkCylSet);
            this.gbEraseDisk.Controls.Add(this.txtCylSet);
            this.gbEraseDisk.Controls.Add(this.txtDriveSelect);
            this.gbEraseDisk.Controls.Add(this.chkDriveSelect);
            this.gbEraseDisk.Location = new System.Drawing.Point(15, 17);
            this.gbEraseDisk.Name = "gbEraseDisk";
            this.gbEraseDisk.Size = new System.Drawing.Size(512, 148);
            this.gbEraseDisk.TabIndex = 1;
            this.gbEraseDisk.TabStop = false;
            // 
            // chkLinger
            // 
            this.chkLinger.AutoSize = true;
            this.chkLinger.Location = new System.Drawing.Point(108, 81);
            this.chkLinger.Name = "chkLinger";
            this.chkLinger.Size = new System.Drawing.Size(102, 21);
            this.chkLinger.TabIndex = 6;
            this.chkLinger.Text = "Linger (ms)";
            this.chkLinger.UseVisualStyleBackColor = true;
            this.chkLinger.CheckedChanged += new System.EventHandler(this.chkLinger_CheckedChanged);
            // 
            // txtLinger
            // 
            this.txtLinger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtLinger.ForeColor = System.Drawing.Color.White;
            this.txtLinger.Location = new System.Drawing.Point(314, 79);
            this.txtLinger.Name = "txtLinger";
            this.txtLinger.Size = new System.Drawing.Size(93, 22);
            this.txtLinger.TabIndex = 7;
            this.txtLinger.Text = "100";
            this.txtLinger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLinger.TextChanged += new System.EventHandler(this.txtLinger_TextChanged);
            // 
            // chkPasses
            // 
            this.chkPasses.AutoSize = true;
            this.chkPasses.Location = new System.Drawing.Point(108, 53);
            this.chkPasses.Name = "chkPasses";
            this.chkPasses.Size = new System.Drawing.Size(76, 21);
            this.chkPasses.TabIndex = 4;
            this.chkPasses.Text = "Passes";
            this.chkPasses.UseVisualStyleBackColor = true;
            this.chkPasses.CheckedChanged += new System.EventHandler(this.chkPasses_CheckedChanged);
            // 
            // txtPasses
            // 
            this.txtPasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPasses.ForeColor = System.Drawing.Color.White;
            this.txtPasses.Location = new System.Drawing.Point(314, 51);
            this.txtPasses.Name = "txtPasses";
            this.txtPasses.Size = new System.Drawing.Size(93, 22);
            this.txtPasses.TabIndex = 5;
            this.txtPasses.Text = "3";
            this.txtPasses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPasses.TextChanged += new System.EventHandler(this.txtPasses_TextChanged);
            // 
            // chkCylSet
            // 
            this.chkCylSet.AutoSize = true;
            this.chkCylSet.Location = new System.Drawing.Point(107, 25);
            this.chkCylSet.Name = "chkCylSet";
            this.chkCylSet.Size = new System.Drawing.Size(88, 21);
            this.chkCylSet.TabIndex = 2;
            this.chkCylSet.Text = "Cylinders";
            this.chkCylSet.UseVisualStyleBackColor = true;
            this.chkCylSet.CheckedChanged += new System.EventHandler(this.chkCylSet_CheckedChanged);
            // 
            // txtCylSet
            // 
            this.txtCylSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCylSet.ForeColor = System.Drawing.Color.White;
            this.txtCylSet.Location = new System.Drawing.Point(313, 23);
            this.txtCylSet.Name = "txtCylSet";
            this.txtCylSet.Size = new System.Drawing.Size(93, 22);
            this.txtCylSet.TabIndex = 3;
            this.txtCylSet.Text = "80";
            this.txtCylSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCylSet.TextChanged += new System.EventHandler(this.txtCylSet_TextChanged);
            // 
            // txtDriveSelect
            // 
            this.txtDriveSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDriveSelect.ForeColor = System.Drawing.Color.White;
            this.txtDriveSelect.Location = new System.Drawing.Point(314, 108);
            this.txtDriveSelect.MaxLength = 1;
            this.txtDriveSelect.Name = "txtDriveSelect";
            this.txtDriveSelect.Size = new System.Drawing.Size(93, 22);
            this.txtDriveSelect.TabIndex = 9;
            this.txtDriveSelect.Text = "A";
            this.txtDriveSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDriveSelect.TextChanged += new System.EventHandler(this.txtDriveSelect_TextChanged);
            // 
            // chkDriveSelect
            // 
            this.chkDriveSelect.AutoSize = true;
            this.chkDriveSelect.Location = new System.Drawing.Point(108, 110);
            this.chkDriveSelect.Name = "chkDriveSelect";
            this.chkDriveSelect.Size = new System.Drawing.Size(182, 21);
            this.chkDriveSelect.TabIndex = 8;
            this.chkDriveSelect.Text = "F7 Drive Select (AB012)";
            this.chkDriveSelect.UseVisualStyleBackColor = true;
            this.chkDriveSelect.CheckedChanged += new System.EventHandler(this.chkDriveSelect_CheckedChanged);
            // 
            // txtCleanCommandLine
            // 
            this.txtCleanCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCleanCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtCleanCommandLine.Location = new System.Drawing.Point(16, 195);
            this.txtCleanCommandLine.Multiline = true;
            this.txtCleanCommandLine.Name = "txtCleanCommandLine";
            this.txtCleanCommandLine.Size = new System.Drawing.Size(512, 74);
            this.txtCleanCommandLine.TabIndex = 11;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(221, 172);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 10;
            this.lblStaticCL.Text = "Command Line";
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(103, 541);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(367, 23);
            this.lblHostTools.TabIndex = 15;
            this.lblHostTools.Text = "for Host Tools v0.00";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // threadWorker
            // 
            this.threadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadWorker_DoWork);
            this.threadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadWorker_RunWorkerCompleted);
            // 
            // lbOutput
            // 
            this.lbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbOutput.ForeColor = System.Drawing.Color.White;
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.HorizontalScrollbar = true;
            this.lbOutput.ItemHeight = 16;
            this.lbOutput.Location = new System.Drawing.Point(15, 312);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(543, 180);
            this.lbOutput.TabIndex = 14;
            this.toolTipChooser.SetToolTip(this.lbOutput, "Right click for options");
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(326, 504);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(139, 504);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 16;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // CleanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(572, 573);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lblHostTools);
            this.Controls.Add(this.gb1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CleanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clean Heads";
            this.Load += new System.EventHandler(this.CleanForm_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gbEraseDisk.ResumeLayout(false);
            this.gbEraseDisk.PerformLayout();
            this.ctxOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtCleanCommandLine;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.Label lblHostTools;
        private System.ComponentModel.BackgroundWorker threadWorker;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.ToolTip toolTipChooser;
        private System.Windows.Forms.ContextMenuStrip ctxOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxClearOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxSaveOutput;
        private System.Windows.Forms.GroupBox gbEraseDisk;
        private System.Windows.Forms.CheckBox chkLinger;
        private System.Windows.Forms.TextBox txtLinger;
        private System.Windows.Forms.CheckBox chkPasses;
        private System.Windows.Forms.TextBox txtPasses;
        private System.Windows.Forms.CheckBox chkCylSet;
        private System.Windows.Forms.TextBox txtCylSet;
        private System.Windows.Forms.TextBox txtDriveSelect;
        private System.Windows.Forms.CheckBox chkDriveSelect;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLaunch;
    }
}