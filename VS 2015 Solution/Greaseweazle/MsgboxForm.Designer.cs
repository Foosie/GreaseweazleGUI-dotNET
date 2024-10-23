// MsgboxForm.Designer.cs
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
    partial class MsgboxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgboxForm));
            this.btnOK = new System.Windows.Forms.Button();
            this.defDefaultsLink = new System.Windows.Forms.LinkLabel();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Maroon;
            this.btnOK.Location = new System.Drawing.Point(80, 195);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 24);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // defDefaultsLink
            // 
            this.defDefaultsLink.ActiveLinkColor = System.Drawing.Color.Red;
            this.defDefaultsLink.AutoSize = true;
            this.defDefaultsLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.defDefaultsLink.LinkColor = System.Drawing.Color.PeachPuff;
            this.defDefaultsLink.Location = new System.Drawing.Point(42, 166);
            this.defDefaultsLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.defDefaultsLink.Name = "defDefaultsLink";
            this.defDefaultsLink.Size = new System.Drawing.Size(152, 13);
            this.defDefaultsLink.TabIndex = 15;
            this.defDefaultsLink.TabStop = true;
            this.defDefaultsLink.Text = "Keir Fraser\'s latest diskdefs.cfg";
            this.defDefaultsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.defDefaultsLink_Clicked);
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblText.Location = new System.Drawing.Point(14, 25);
            this.lblText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(209, 135);
            this.lblText.TabIndex = 16;
            this.lblText.Text = resources.GetString("lblText.Text");
            // 
            // MsgboxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(237, 235);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.defDefaultsLink);
            this.Controls.Add(this.btnOK);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MsgboxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.LinkLabel defDefaultsLink;
        private System.Windows.Forms.Label lblText;
    }
}