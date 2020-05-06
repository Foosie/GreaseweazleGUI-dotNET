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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.btnSelectUpdateFile = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.gbUpdateFirmware = new System.Windows.Forms.GroupBox();
            this.txtUpdateCommandLine = new System.Windows.Forms.TextBox();
            this.gbUpdateFirmware.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectUpdateFile
            // 
            this.btnSelectUpdateFile.Location = new System.Drawing.Point(80, 136);
            this.btnSelectUpdateFile.Name = "btnSelectUpdateFile";
            this.btnSelectUpdateFile.Size = new System.Drawing.Size(108, 29);
            this.btnSelectUpdateFile.TabIndex = 4;
            this.btnSelectUpdateFile.Text = "Select File";
            this.btnSelectUpdateFile.UseVisualStyleBackColor = true;
            this.btnSelectUpdateFile.Click += new System.EventHandler(this.btnSelectUpdateFile_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(214, 136);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(108, 29);
            this.btnLaunch.TabIndex = 5;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(348, 136);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(221, 21);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(102, 17);
            this.lblStaticCL.TabIndex = 2;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbUpdateFirmware
            // 
            this.gbUpdateFirmware.Controls.Add(this.txtUpdateCommandLine);
            this.gbUpdateFirmware.Controls.Add(this.lblStaticCL);
            this.gbUpdateFirmware.Controls.Add(this.btnBack);
            this.gbUpdateFirmware.Controls.Add(this.btnLaunch);
            this.gbUpdateFirmware.Controls.Add(this.btnSelectUpdateFile);
            this.gbUpdateFirmware.Location = new System.Drawing.Point(12, 12);
            this.gbUpdateFirmware.Name = "gbUpdateFirmware";
            this.gbUpdateFirmware.Size = new System.Drawing.Size(545, 185);
            this.gbUpdateFirmware.TabIndex = 1;
            this.gbUpdateFirmware.TabStop = false;
            // 
            // txtUpdateCommandLine
            // 
            this.txtUpdateCommandLine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUpdateCommandLine.Location = new System.Drawing.Point(15, 49);
            this.txtUpdateCommandLine.Multiline = true;
            this.txtUpdateCommandLine.Name = "txtUpdateCommandLine";
            this.txtUpdateCommandLine.Size = new System.Drawing.Size(512, 74);
            this.txtUpdateCommandLine.TabIndex = 3;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 209);
            this.Controls.Add(this.gbUpdateFirmware);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Firmware";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.gbUpdateFirmware.ResumeLayout(false);
            this.gbUpdateFirmware.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectUpdateFile;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.GroupBox gbUpdateFirmware;
        private System.Windows.Forms.TextBox txtUpdateCommandLine;
    }
}