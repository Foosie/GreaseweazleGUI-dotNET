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
            this.btnSelectUpdateFile = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.gbUpdateFirmware = new System.Windows.Forms.GroupBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.chkBootLoader = new System.Windows.Forms.CheckBox();
            this.txtUpdateCommandLine = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblHostTools = new System.Windows.Forms.Label();
            this.gbUpdateFirmware.SuspendLayout();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectUpdateFile
            // 
            this.btnSelectUpdateFile.BackColor = System.Drawing.Color.Maroon;
            this.btnSelectUpdateFile.Location = new System.Drawing.Point(80, 238);
            this.btnSelectUpdateFile.Name = "btnSelectUpdateFile";
            this.btnSelectUpdateFile.Size = new System.Drawing.Size(108, 29);
            this.btnSelectUpdateFile.TabIndex = 6;
            this.btnSelectUpdateFile.Text = "Select File";
            this.btnSelectUpdateFile.UseVisualStyleBackColor = false;
            this.btnSelectUpdateFile.Click += new System.EventHandler(this.btnSelectUpdateFile_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Maroon;
            this.btnLaunch.Location = new System.Drawing.Point(214, 238);
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
            this.btnBack.Location = new System.Drawing.Point(348, 238);
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
            this.lblStaticCL.Location = new System.Drawing.Point(221, 123);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 4;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbUpdateFirmware
            // 
            this.gbUpdateFirmware.Controls.Add(this.gb1);
            this.gbUpdateFirmware.Controls.Add(this.txtUpdateCommandLine);
            this.gbUpdateFirmware.Controls.Add(this.lblStaticCL);
            this.gbUpdateFirmware.Controls.Add(this.btnBack);
            this.gbUpdateFirmware.Controls.Add(this.btnLaunch);
            this.gbUpdateFirmware.Controls.Add(this.btnSelectUpdateFile);
            this.gbUpdateFirmware.Location = new System.Drawing.Point(12, 12);
            this.gbUpdateFirmware.Name = "gbUpdateFirmware";
            this.gbUpdateFirmware.Size = new System.Drawing.Size(545, 284);
            this.gbUpdateFirmware.TabIndex = 1;
            this.gbUpdateFirmware.TabStop = false;
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
            this.txtUpdateCommandLine.Location = new System.Drawing.Point(15, 151);
            this.txtUpdateCommandLine.Multiline = true;
            this.txtUpdateCommandLine.Name = "txtUpdateCommandLine";
            this.txtUpdateCommandLine.Size = new System.Drawing.Size(512, 74);
            this.txtUpdateCommandLine.TabIndex = 5;
            // 
            // lblHostTools
            // 
            this.lblHostTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostTools.ForeColor = System.Drawing.Color.White;
            this.lblHostTools.Location = new System.Drawing.Point(101, 306);
            this.lblHostTools.Name = "lblHostTools";
            this.lblHostTools.Size = new System.Drawing.Size(367, 23);
            this.lblHostTools.TabIndex = 10;
            this.lblHostTools.Text = "for Host Tools v0.00";
            this.lblHostTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(569, 338);
            this.Controls.Add(this.lblHostTools);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectUpdateFile;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.GroupBox gbUpdateFirmware;
        private System.Windows.Forms.TextBox txtUpdateCommandLine;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.CheckBox chkBootLoader;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblHostTools;
    }
}