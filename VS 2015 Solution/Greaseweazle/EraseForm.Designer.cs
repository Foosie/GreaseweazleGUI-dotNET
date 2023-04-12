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
    partial class EraseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EraseForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.txtEraseCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.gbEraseDisk = new System.Windows.Forms.GroupBox();
            this.txtFakeIndex = new System.Windows.Forms.TextBox();
            this.cbFakeIndex = new System.Windows.Forms.ComboBox();
            this.chkHighFreq = new System.Windows.Forms.CheckBox();
            this.chkFakeIndex = new System.Windows.Forms.CheckBox();
            this.chkHeadsSet = new System.Windows.Forms.CheckBox();
            this.txtHeadsSet = new System.Windows.Forms.TextBox();
            this.chkCylSet = new System.Windows.Forms.CheckBox();
            this.txtCylSet = new System.Windows.Forms.TextBox();
            this.txtDriveSelect = new System.Windows.Forms.TextBox();
            this.chkDriveSelect = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblHostTools = new System.Windows.Forms.Label();
            this.threadWorker = new System.ComponentModel.BackgroundWorker();
            this.ctxOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxClearOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSaveOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.chkRevsPerTrack = new System.Windows.Forms.CheckBox();
            this.txtRevsPerTrack = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbEraseDisk.SuspendLayout();
            this.ctxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbOutput);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnLaunch);
            this.groupBox1.Controls.Add(this.txtEraseCommandLine);
            this.groupBox1.Controls.Add(this.lblStaticCL);
            this.groupBox1.Controls.Add(this.gbEraseDisk);
            this.groupBox1.Location = new System.Drawing.Point(13, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 537);
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
            this.lbOutput.Location = new System.Drawing.Point(19, 346);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(512, 132);
            this.lbOutput.TabIndex = 17;
            this.toolTip.SetToolTip(this.lbOutput, "Right click for options");
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(332, 491);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(111, 491);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 18;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // txtEraseCommandLine
            // 
            this.txtEraseCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtEraseCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtEraseCommandLine.Location = new System.Drawing.Point(19, 255);
            this.txtEraseCommandLine.Multiline = true;
            this.txtEraseCommandLine.Name = "txtEraseCommandLine";
            this.txtEraseCommandLine.Size = new System.Drawing.Size(512, 74);
            this.txtEraseCommandLine.TabIndex = 16;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(225, 230);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 15;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbEraseDisk
            // 
            this.gbEraseDisk.Controls.Add(this.chkRevsPerTrack);
            this.gbEraseDisk.Controls.Add(this.txtRevsPerTrack);
            this.gbEraseDisk.Controls.Add(this.txtFakeIndex);
            this.gbEraseDisk.Controls.Add(this.cbFakeIndex);
            this.gbEraseDisk.Controls.Add(this.chkHighFreq);
            this.gbEraseDisk.Controls.Add(this.chkFakeIndex);
            this.gbEraseDisk.Controls.Add(this.chkHeadsSet);
            this.gbEraseDisk.Controls.Add(this.txtHeadsSet);
            this.gbEraseDisk.Controls.Add(this.chkCylSet);
            this.gbEraseDisk.Controls.Add(this.txtCylSet);
            this.gbEraseDisk.Controls.Add(this.txtDriveSelect);
            this.gbEraseDisk.Controls.Add(this.chkDriveSelect);
            this.gbEraseDisk.Location = new System.Drawing.Point(19, 21);
            this.gbEraseDisk.Name = "gbEraseDisk";
            this.gbEraseDisk.Size = new System.Drawing.Size(512, 198);
            this.gbEraseDisk.TabIndex = 2;
            this.gbEraseDisk.TabStop = false;
            this.gbEraseDisk.Enter += new System.EventHandler(this.gbEraseDisk_Enter);
            // 
            // txtFakeIndex
            // 
            this.txtFakeIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtFakeIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFakeIndex.ForeColor = System.Drawing.Color.White;
            this.txtFakeIndex.Location = new System.Drawing.Point(220, 132);
            this.txtFakeIndex.MaxLength = 3;
            this.txtFakeIndex.Name = "txtFakeIndex";
            this.txtFakeIndex.Size = new System.Drawing.Size(73, 22);
            this.txtFakeIndex.TabIndex = 12;
            this.txtFakeIndex.Text = "300";
            this.txtFakeIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFakeIndex.TextChanged += new System.EventHandler(this.txtFakeIndex_TextChanged);
            // 
            // cbFakeIndex
            // 
            this.cbFakeIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbFakeIndex.ForeColor = System.Drawing.Color.White;
            this.cbFakeIndex.FormattingEnabled = true;
            this.cbFakeIndex.Items.AddRange(new object[] {
            "",
            "rpm",
            "ms",
            "us",
            "ns",
            "scp"});
            this.cbFakeIndex.Location = new System.Drawing.Point(313, 131);
            this.cbFakeIndex.Name = "cbFakeIndex";
            this.cbFakeIndex.Size = new System.Drawing.Size(93, 24);
            this.cbFakeIndex.TabIndex = 13;
            this.cbFakeIndex.SelectedIndexChanged += new System.EventHandler(this.cbFakeIndex_SelectedIndexChanged);
            // 
            // chkHighFreq
            // 
            this.chkHighFreq.AutoSize = true;
            this.chkHighFreq.Location = new System.Drawing.Point(107, 161);
            this.chkHighFreq.Name = "chkHighFreq";
            this.chkHighFreq.Size = new System.Drawing.Size(92, 21);
            this.chkHighFreq.TabIndex = 14;
            this.chkHighFreq.Text = "High Freq";
            this.chkHighFreq.UseVisualStyleBackColor = true;
            this.chkHighFreq.CheckedChanged += new System.EventHandler(this.chkHighFreq_CheckedChanged);
            // 
            // chkFakeIndex
            // 
            this.chkFakeIndex.AutoSize = true;
            this.chkFakeIndex.Location = new System.Drawing.Point(107, 133);
            this.chkFakeIndex.Name = "chkFakeIndex";
            this.chkFakeIndex.Size = new System.Drawing.Size(98, 21);
            this.chkFakeIndex.TabIndex = 11;
            this.chkFakeIndex.Text = "Fake Index";
            this.chkFakeIndex.UseVisualStyleBackColor = true;
            this.chkFakeIndex.CheckedChanged += new System.EventHandler(this.chkFakeIndex_CheckedChanged);
            // 
            // chkHeadsSet
            // 
            this.chkHeadsSet.AutoSize = true;
            this.chkHeadsSet.Location = new System.Drawing.Point(107, 51);
            this.chkHeadsSet.Name = "chkHeadsSet";
            this.chkHeadsSet.Size = new System.Drawing.Size(94, 21);
            this.chkHeadsSet.TabIndex = 5;
            this.chkHeadsSet.Text = "Head sets";
            this.chkHeadsSet.UseVisualStyleBackColor = true;
            this.chkHeadsSet.CheckedChanged += new System.EventHandler(this.chkHeadsSet_CheckedChanged);
            // 
            // txtHeadsSet
            // 
            this.txtHeadsSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtHeadsSet.ForeColor = System.Drawing.Color.White;
            this.txtHeadsSet.Location = new System.Drawing.Point(313, 50);
            this.txtHeadsSet.Name = "txtHeadsSet";
            this.txtHeadsSet.Size = new System.Drawing.Size(93, 22);
            this.txtHeadsSet.TabIndex = 6;
            this.txtHeadsSet.Text = "0-1";
            this.txtHeadsSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeadsSet.TextChanged += new System.EventHandler(this.txtHeadsSet_TextChanged);
            // 
            // chkCylSet
            // 
            this.chkCylSet.AutoSize = true;
            this.chkCylSet.Location = new System.Drawing.Point(107, 24);
            this.chkCylSet.Name = "chkCylSet";
            this.chkCylSet.Size = new System.Drawing.Size(111, 21);
            this.chkCylSet.TabIndex = 3;
            this.chkCylSet.Text = "Cylinder sets";
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
            this.txtCylSet.TabIndex = 4;
            this.txtCylSet.Text = "0-34,35-79";
            this.txtCylSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCylSet.TextChanged += new System.EventHandler(this.txtCylSet_TextChanged);
            // 
            // txtDriveSelect
            // 
            this.txtDriveSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDriveSelect.ForeColor = System.Drawing.Color.White;
            this.txtDriveSelect.Location = new System.Drawing.Point(313, 104);
            this.txtDriveSelect.MaxLength = 1;
            this.txtDriveSelect.Name = "txtDriveSelect";
            this.txtDriveSelect.Size = new System.Drawing.Size(93, 22);
            this.txtDriveSelect.TabIndex = 10;
            this.txtDriveSelect.Text = "A";
            this.txtDriveSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDriveSelect.TextChanged += new System.EventHandler(this.txtDriveSelect_TextChanged);
            // 
            // chkDriveSelect
            // 
            this.chkDriveSelect.AutoSize = true;
            this.chkDriveSelect.Location = new System.Drawing.Point(107, 105);
            this.chkDriveSelect.Name = "chkDriveSelect";
            this.chkDriveSelect.Size = new System.Drawing.Size(182, 21);
            this.chkDriveSelect.TabIndex = 9;
            this.chkDriveSelect.Text = "F7 Drive Select (AB012)";
            this.toolTip.SetToolTip(this.chkDriveSelect, "Host Tools v0.18 or later\r\nRequires F7 type");
            this.chkDriveSelect.UseVisualStyleBackColor = true;
            this.chkDriveSelect.CheckedChanged += new System.EventHandler(this.chkDriveSelect_CheckedChanged);
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(106, 553);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(369, 23);
            this.lblHostTools.TabIndex = 20;
            this.lblHostTools.Text = "for Host Tools v0.00";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // chkRevsPerTrack
            // 
            this.chkRevsPerTrack.AutoSize = true;
            this.chkRevsPerTrack.Location = new System.Drawing.Point(107, 78);
            this.chkRevsPerTrack.Name = "chkRevsPerTrack";
            this.chkRevsPerTrack.Size = new System.Drawing.Size(122, 21);
            this.chkRevsPerTrack.TabIndex = 7;
            this.chkRevsPerTrack.Text = "Revs per track";
            this.chkRevsPerTrack.UseVisualStyleBackColor = true;
            this.chkRevsPerTrack.CheckedChanged += new System.EventHandler(this.chkRevsPerTrack_CheckedChanged);
            // 
            // txtRevsPerTrack
            // 
            this.txtRevsPerTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtRevsPerTrack.ForeColor = System.Drawing.Color.White;
            this.txtRevsPerTrack.Location = new System.Drawing.Point(313, 77);
            this.txtRevsPerTrack.Name = "txtRevsPerTrack";
            this.txtRevsPerTrack.Size = new System.Drawing.Size(93, 22);
            this.txtRevsPerTrack.TabIndex = 8;
            this.txtRevsPerTrack.Text = "3";
            this.txtRevsPerTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRevsPerTrack.TextChanged += new System.EventHandler(this.txtRevsPerTrack_TextChanged);
            // 
            // EraseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(580, 584);
            this.Controls.Add(this.lblHostTools);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EraseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Erase Disk";
            this.Load += new System.EventHandler(this.EraseForm_Load);
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
        private System.Windows.Forms.TextBox txtEraseCommandLine;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox chkHeadsSet;
        private System.Windows.Forms.TextBox txtHeadsSet;
        private System.Windows.Forms.CheckBox chkCylSet;
        private System.Windows.Forms.TextBox txtCylSet;
        private System.Windows.Forms.Label lblHostTools;
        private System.ComponentModel.BackgroundWorker threadWorker;
        private System.Windows.Forms.ContextMenuStrip ctxOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxClearOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxSaveOutput;
        private System.Windows.Forms.CheckBox chkFakeIndex;
        private System.Windows.Forms.CheckBox chkHighFreq;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.TextBox txtFakeIndex;
        private System.Windows.Forms.ComboBox cbFakeIndex;
        private System.Windows.Forms.CheckBox chkRevsPerTrack;
        private System.Windows.Forms.TextBox txtRevsPerTrack;
    }
}