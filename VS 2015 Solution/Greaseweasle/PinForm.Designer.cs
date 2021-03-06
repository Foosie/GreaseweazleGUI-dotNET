﻿// PinForm.Designer.cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinForm));
            this.gbPin = new System.Windows.Forms.GroupBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.lblSelectedPin = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPinCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.lblHostTools = new System.Windows.Forms.Label();
            this.rbGet = new System.Windows.Forms.RadioButton();
            this.rbSet = new System.Windows.Forms.RadioButton();
            this.gbGetSet = new System.Windows.Forms.GroupBox();
            this.gbHighLow = new System.Windows.Forms.GroupBox();
            this.gbPin.SuspendLayout();
            this.gb1.SuspendLayout();
            this.gbGetSet.SuspendLayout();
            this.gbHighLow.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPin
            // 
            this.gbPin.Controls.Add(this.gb1);
            this.gbPin.Controls.Add(this.btnBack);
            this.gbPin.Controls.Add(this.txtPinCommandLine);
            this.gbPin.Controls.Add(this.lblStaticCL);
            this.gbPin.Controls.Add(this.btnLaunch);
            this.gbPin.Location = new System.Drawing.Point(12, 12);
            this.gbPin.Name = "gbPin";
            this.gbPin.Size = new System.Drawing.Size(543, 326);
            this.gbPin.TabIndex = 0;
            this.gbPin.TabStop = false;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.gbHighLow);
            this.gb1.Controls.Add(this.gbGetSet);
            this.gb1.Controls.Add(this.lblSelectedPin);
            this.gb1.Controls.Add(this.txtPin);
            this.gb1.Location = new System.Drawing.Point(15, 21);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(512, 124);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
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
            // lblSelectedPin
            // 
            this.lblSelectedPin.AutoSize = true;
            this.lblSelectedPin.Location = new System.Drawing.Point(107, 22);
            this.lblSelectedPin.Name = "lblSelectedPin";
            this.lblSelectedPin.Size = new System.Drawing.Size(117, 17);
            this.lblSelectedPin.TabIndex = 2;
            this.lblSelectedPin.Text = "Selected Pin (22)";
            // 
            // txtPin
            // 
            this.txtPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPin.ForeColor = System.Drawing.Color.White;
            this.txtPin.Location = new System.Drawing.Point(289, 22);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(31, 22);
            this.txtPin.TabIndex = 3;
            this.txtPin.Text = "22";
            this.txtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(311, 278);
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
            this.txtPinCommandLine.Location = new System.Drawing.Point(15, 190);
            this.txtPinCommandLine.Multiline = true;
            this.txtPinCommandLine.Name = "txtPinCommandLine";
            this.txtPinCommandLine.Size = new System.Drawing.Size(512, 74);
            this.txtPinCommandLine.TabIndex = 11;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(220, 162);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 10;
            this.lblStaticCL.Text = "Command Line";
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(124, 278);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 12;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(103, 350);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(367, 23);
            this.lblHostTools.TabIndex = 14;
            this.lblHostTools.Text = "for Host Tools v0.00";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // PinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(572, 385);
            this.Controls.Add(this.lblHostTools);
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
            this.gbGetSet.ResumeLayout(false);
            this.gbGetSet.PerformLayout();
            this.gbHighLow.ResumeLayout(false);
            this.gbHighLow.PerformLayout();
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
        private System.Windows.Forms.Label lblHostTools;
        private System.Windows.Forms.RadioButton rbSet;
        private System.Windows.Forms.RadioButton rbGet;
        private System.Windows.Forms.GroupBox gbHighLow;
        private System.Windows.Forms.GroupBox gbGetSet;
    }
}