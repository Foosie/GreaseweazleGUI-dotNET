// UpdateForm.Designer.cs
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
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.gbUpdateFirmware = new System.Windows.Forms.GroupBox();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.lblHostTools = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.chkBootLoader = new System.Windows.Forms.CheckBox();
            this.txtUpdateCommandLine = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.threadWorker = new System.ComponentModel.BackgroundWorker();
            this.ctxOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxClearOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSaveOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.gbUpdateFirmware.SuspendLayout();
            this.gb1.SuspendLayout();
            this.ctxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(150, 389);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 7;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(284, 389);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(220, 109);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 4;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbUpdateFirmware
            // 
            this.gbUpdateFirmware.Controls.Add(this.lbOutput);
            this.gbUpdateFirmware.Controls.Add(this.lblHostTools);
            this.gbUpdateFirmware.Controls.Add(this.gb1);
            this.gbUpdateFirmware.Controls.Add(this.txtUpdateCommandLine);
            this.gbUpdateFirmware.Controls.Add(this.lblStaticCL);
            this.gbUpdateFirmware.Controls.Add(this.btnBack);
            this.gbUpdateFirmware.Controls.Add(this.btnLaunch);
            this.gbUpdateFirmware.Location = new System.Drawing.Point(15, 14);
            this.gbUpdateFirmware.Name = "gbUpdateFirmware";
            this.gbUpdateFirmware.Size = new System.Drawing.Size(543, 461);
            this.gbUpdateFirmware.TabIndex = 1;
            this.gbUpdateFirmware.TabStop = false;
            // 
            // lbOutput
            // 
            this.lbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbOutput.ForeColor = System.Drawing.Color.White;
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.HorizontalScrollbar = true;
            this.lbOutput.ItemHeight = 16;
            this.lbOutput.Location = new System.Drawing.Point(15, 228);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(512, 148);
            this.lbOutput.TabIndex = 53;
            this.toolTip1.SetToolTip(this.lbOutput, "Right click for options");
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(88, 425);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(367, 23);
            this.lblHostTools.TabIndex = 11;
            this.lblHostTools.Text = "for Host Tools v0.00";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.chkBootLoader);
            this.gb1.Location = new System.Drawing.Point(15, 20);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(512, 82);
            this.gb1.TabIndex = 2;
            this.gb1.TabStop = false;
            // 
            // chkBootLoader
            // 
            this.chkBootLoader.AutoSize = true;
            this.chkBootLoader.Location = new System.Drawing.Point(65, 35);
            this.chkBootLoader.Name = "chkBootLoader";
            this.chkBootLoader.Size = new System.Drawing.Size(179, 21);
            this.chkBootLoader.TabIndex = 3;
            this.chkBootLoader.Text = "Bootloader (Take Care)";
            this.toolTip1.SetToolTip(this.chkBootLoader, "Host Tools v0.16 or later\r\nNot normally required\r\nFailure may brick the Weazle an" +
        "d require full reflash\r\nNO jumper across GND and DCLK");
            this.chkBootLoader.UseVisualStyleBackColor = true;
            this.chkBootLoader.CheckedChanged += new System.EventHandler(this.chkBootLoader_CheckedChanged);
            // 
            // txtUpdateCommandLine
            // 
            this.txtUpdateCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtUpdateCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtUpdateCommandLine.Location = new System.Drawing.Point(15, 139);
            this.txtUpdateCommandLine.Multiline = true;
            this.txtUpdateCommandLine.Name = "txtUpdateCommandLine";
            this.txtUpdateCommandLine.Size = new System.Drawing.Size(512, 74);
            this.txtUpdateCommandLine.TabIndex = 5;
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
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(572, 488);
            this.Controls.Add(this.gbUpdateFirmware);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Firmware";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.gbUpdateFirmware.ResumeLayout(false);
            this.gbUpdateFirmware.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ctxOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.GroupBox gbUpdateFirmware;
        private System.Windows.Forms.TextBox txtUpdateCommandLine;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.CheckBox chkBootLoader;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblHostTools;
        private System.Windows.Forms.ListBox lbOutput;
        private System.ComponentModel.BackgroundWorker threadWorker;
        private System.Windows.Forms.ContextMenuStrip ctxOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxClearOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxSaveOutput;
    }
}