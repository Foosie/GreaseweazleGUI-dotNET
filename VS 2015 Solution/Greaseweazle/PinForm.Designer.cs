// PinForm.Designer.cs
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
    partial class PinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinForm));
            this.gbPin = new System.Windows.Forms.GroupBox();
            this.lblHostTools = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.gbHighLow = new System.Windows.Forms.GroupBox();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.gbGetSet = new System.Windows.Forms.GroupBox();
            this.rbGet = new System.Windows.Forms.RadioButton();
            this.rbSet = new System.Windows.Forms.RadioButton();
            this.lblSelectedPin = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPinCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.threadWorker = new System.ComponentModel.BackgroundWorker();
            this.ctxOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxClearOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSaveOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipChooser = new System.Windows.Forms.ToolTip(this.components);
            this.gbPin.SuspendLayout();
            this.gb1.SuspendLayout();
            this.gbHighLow.SuspendLayout();
            this.gbGetSet.SuspendLayout();
            this.ctxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPin
            // 
            this.gbPin.Controls.Add(this.lblHostTools);
            this.gbPin.Controls.Add(this.lbOutput);
            this.gbPin.Controls.Add(this.gb1);
            this.gbPin.Controls.Add(this.btnBack);
            this.gbPin.Controls.Add(this.txtPinCommandLine);
            this.gbPin.Controls.Add(this.lblStaticCL);
            this.gbPin.Controls.Add(this.btnLaunch);
            this.gbPin.Location = new System.Drawing.Point(16, 12);
            this.gbPin.Name = "gbPin";
            this.gbPin.Size = new System.Drawing.Size(545, 484);
            this.gbPin.TabIndex = 0;
            this.gbPin.TabStop = false;
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(89, 449);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(367, 23);
            this.lblHostTools.TabIndex = 54;
            this.lblHostTools.Text = "for Host Tools v0.00";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOutput
            // 
            this.lbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbOutput.ForeColor = System.Drawing.Color.White;
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.HorizontalScrollbar = true;
            this.lbOutput.ItemHeight = 16;
            this.lbOutput.Location = new System.Drawing.Point(16, 270);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(512, 132);
            this.lbOutput.TabIndex = 53;
            this.toolTipChooser.SetToolTip(this.lbOutput, "Right click for options");
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.gbHighLow);
            this.gb1.Controls.Add(this.gbGetSet);
            this.gb1.Controls.Add(this.lblSelectedPin);
            this.gb1.Controls.Add(this.txtPin);
            this.gb1.Location = new System.Drawing.Point(16, 21);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(512, 124);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            // 
            // gbHighLow
            // 
            this.gbHighLow.Controls.Add(this.rbHigh);
            this.gbHighLow.Controls.Add(this.rbLow);
            this.gbHighLow.Location = new System.Drawing.Point(289, 50);
            this.gbHighLow.Name = "gbHighLow";
            this.gbHighLow.Size = new System.Drawing.Size(200, 51);
            this.gbHighLow.TabIndex = 7;
            this.gbHighLow.TabStop = false;
            // 
            // rbHigh
            // 
            this.rbHigh.AutoSize = true;
            this.rbHigh.Location = new System.Drawing.Point(23, 18);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(80, 21);
            this.rbHigh.TabIndex = 8;
            this.rbHigh.Text = "High Lvl";
            this.rbHigh.UseVisualStyleBackColor = true;
            this.rbHigh.CheckedChanged += new System.EventHandler(this.rbHigh_CheckedChanged);
            // 
            // rbLow
            // 
            this.rbLow.AutoSize = true;
            this.rbLow.Location = new System.Drawing.Point(109, 18);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(76, 21);
            this.rbLow.TabIndex = 9;
            this.rbLow.Text = "Low Lvl";
            this.rbLow.UseVisualStyleBackColor = true;
            this.rbLow.CheckedChanged += new System.EventHandler(this.rbLow_CheckedChanged);
            // 
            // gbGetSet
            // 
            this.gbGetSet.Controls.Add(this.rbGet);
            this.gbGetSet.Controls.Add(this.rbSet);
            this.gbGetSet.Location = new System.Drawing.Point(24, 50);
            this.gbGetSet.Name = "gbGetSet";
            this.gbGetSet.Size = new System.Drawing.Size(200, 51);
            this.gbGetSet.TabIndex = 4;
            this.gbGetSet.TabStop = false;
            // 
            // rbGet
            // 
            this.rbGet.AutoSize = true;
            this.rbGet.Location = new System.Drawing.Point(19, 18);
            this.rbGet.Name = "rbGet";
            this.rbGet.Size = new System.Drawing.Size(52, 21);
            this.rbGet.TabIndex = 5;
            this.rbGet.Text = "Get";
            this.rbGet.UseVisualStyleBackColor = true;
            this.rbGet.CheckedChanged += new System.EventHandler(this.rbGet_CheckedChanged);
            // 
            // rbSet
            // 
            this.rbSet.AutoSize = true;
            this.rbSet.Checked = true;
            this.rbSet.Location = new System.Drawing.Point(110, 18);
            this.rbSet.Name = "rbSet";
            this.rbSet.Size = new System.Drawing.Size(50, 21);
            this.rbSet.TabIndex = 6;
            this.rbSet.TabStop = true;
            this.rbSet.Text = "Set";
            this.rbSet.UseVisualStyleBackColor = true;
            this.rbSet.CheckedChanged += new System.EventHandler(this.rbSet_CheckedChanged);
            // 
            // lblSelectedPin
            // 
            this.lblSelectedPin.AutoSize = true;
            this.lblSelectedPin.Location = new System.Drawing.Point(107, 22);
            this.lblSelectedPin.Name = "lblSelectedPin";
            this.lblSelectedPin.Size = new System.Drawing.Size(149, 17);
            this.lblSelectedPin.TabIndex = 2;
            this.lblSelectedPin.Text = "Selected Pin (8,26,28)";
            // 
            // txtPin
            // 
            this.txtPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPin.ForeColor = System.Drawing.Color.White;
            this.txtPin.Location = new System.Drawing.Point(289, 22);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(31, 22);
            this.txtPin.TabIndex = 3;
            this.txtPin.Text = "26";
            this.txtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(312, 413);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPinCommandLine
            // 
            this.txtPinCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPinCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtPinCommandLine.Location = new System.Drawing.Point(16, 182);
            this.txtPinCommandLine.Multiline = true;
            this.txtPinCommandLine.Name = "txtPinCommandLine";
            this.txtPinCommandLine.Size = new System.Drawing.Size(512, 74);
            this.txtPinCommandLine.TabIndex = 11;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(221, 154);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 10;
            this.lblStaticCL.Text = "Command Line";
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(125, 413);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 12;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
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
            // PinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(576, 511);
            this.Controls.Add(this.gbPin);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pin Level";
            this.Load += new System.EventHandler(this.PinForm_Load);
            this.gbPin.ResumeLayout(false);
            this.gbPin.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gbHighLow.ResumeLayout(false);
            this.gbHighLow.PerformLayout();
            this.gbGetSet.ResumeLayout(false);
            this.gbGetSet.PerformLayout();
            this.ctxOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPin;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.Label lblSelectedPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPinCommandLine;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.RadioButton rbSet;
        private System.Windows.Forms.RadioButton rbGet;
        private System.Windows.Forms.GroupBox gbHighLow;
        private System.Windows.Forms.GroupBox gbGetSet;
        private System.Windows.Forms.Label lblHostTools;
        private System.Windows.Forms.ListBox lbOutput;
        private System.ComponentModel.BackgroundWorker threadWorker;
        private System.Windows.Forms.ContextMenuStrip ctxOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxClearOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxSaveOutput;
        private System.Windows.Forms.ToolTip toolTipChooser;
    }
}