// AboutForm.Designer.cs
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
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.llDSS = new System.Windows.Forms.LinkLabel();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblGuiBy = new System.Windows.Forms.Label();
            this.gbGW = new System.Windows.Forms.GroupBox();
            this.gbLine1 = new System.Windows.Forms.GroupBox();
            this.lblKF1 = new System.Windows.Forms.Label();
            this.llFFFB = new System.Windows.Forms.LinkLabel();
            this.lblFF = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.llFFGH = new System.Windows.Forms.LinkLabel();
            this.llGWFB = new System.Windows.Forms.LinkLabel();
            this.lblGW = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.llGWGH = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGW.SuspendLayout();
            this.SuspendLayout();
            // 
            // llDSS
            // 
            this.llDSS.AutoSize = true;
            this.llDSS.LinkColor = System.Drawing.Color.PeachPuff;
            this.llDSS.Location = new System.Drawing.Point(48, 308);
            this.llDSS.Name = "llDSS";
            this.llDSS.Size = new System.Drawing.Size(122, 17);
            this.llDSS.TabIndex = 11;
            this.llDSS.TabStop = true;
            this.llDSS.Text = "GreaseweazleGUI";
            this.llDSS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDSS_LinkClicked);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Maroon;
            this.btnOK.Location = new System.Drawing.Point(107, 355);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 29);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblGuiBy
            // 
            this.lblGuiBy.AutoSize = true;
            this.lblGuiBy.Location = new System.Drawing.Point(167, 308);
            this.lblGuiBy.Name = "lblGuiBy";
            this.lblGuiBy.Size = new System.Drawing.Size(102, 17);
            this.lblGuiBy.TabIndex = 12;
            this.lblGuiBy.Text = "by Don Mankin";
            // 
            // gbGW
            // 
            this.gbGW.Controls.Add(this.gbLine1);
            this.gbGW.Controls.Add(this.lblKF1);
            this.gbGW.Controls.Add(this.llFFFB);
            this.gbGW.Controls.Add(this.lblFF);
            this.gbGW.Controls.Add(this.lblText2);
            this.gbGW.Controls.Add(this.llFFGH);
            this.gbGW.Controls.Add(this.llGWFB);
            this.gbGW.Controls.Add(this.lblGW);
            this.gbGW.Controls.Add(this.lblText);
            this.gbGW.Controls.Add(this.llGWGH);
            this.gbGW.Location = new System.Drawing.Point(12, 10);
            this.gbGW.Name = "gbGW";
            this.gbGW.Size = new System.Drawing.Size(292, 283);
            this.gbGW.TabIndex = 1;
            this.gbGW.TabStop = false;
            // 
            // gbLine1
            // 
            this.gbLine1.Location = new System.Drawing.Point(0, 159);
            this.gbLine1.Name = "gbLine1";
            this.gbLine1.Size = new System.Drawing.Size(292, 13);
            this.gbLine1.TabIndex = 18;
            this.gbLine1.TabStop = false;
            // 
            // lblKF1
            // 
            this.lblKF1.AutoSize = true;
            this.lblKF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKF1.ForeColor = System.Drawing.Color.White;
            this.lblKF1.Location = new System.Drawing.Point(87, 18);
            this.lblKF1.Name = "lblKF1";
            this.lblKF1.Size = new System.Drawing.Size(119, 20);
            this.lblKF1.TabIndex = 2;
            this.lblKF1.Text = "Keir Fraser\'s";
            // 
            // llFFFB
            // 
            this.llFFFB.AutoSize = true;
            this.llFFFB.LinkColor = System.Drawing.Color.PeachPuff;
            this.llFFFB.Location = new System.Drawing.Point(139, 246);
            this.llFFFB.Name = "llFFFB";
            this.llFFFB.Size = new System.Drawing.Size(70, 17);
            this.llFFFB.TabIndex = 10;
            this.llFFFB.TabStop = true;
            this.llFFFB.Text = "Facebook";
            this.llFFFB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llFFFB_LinkClicked);
            // 
            // lblFF
            // 
            this.lblFF.AutoSize = true;
            this.lblFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFF.ForeColor = System.Drawing.Color.Yellow;
            this.lblFF.Location = new System.Drawing.Point(85, 168);
            this.lblFF.Name = "lblFF";
            this.lblFF.Size = new System.Drawing.Size(123, 25);
            this.lblFF.TabIndex = 7;
            this.lblFF.Text = "Flashfloppy";
            // 
            // lblText2
            // 
            this.lblText2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblText2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblText2.Location = new System.Drawing.Point(12, 197);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(269, 43);
            this.lblText2.TabIndex = 8;
            this.lblText2.Text = "A retro floppy emulator for the ubiquitous Gotek hardware.";
            // 
            // llFFGH
            // 
            this.llFFGH.AutoSize = true;
            this.llFFGH.LinkColor = System.Drawing.Color.PeachPuff;
            this.llFFGH.Location = new System.Drawing.Point(83, 246);
            this.llFFGH.Name = "llFFGH";
            this.llFFGH.Size = new System.Drawing.Size(50, 17);
            this.llFFGH.TabIndex = 9;
            this.llFFGH.TabStop = true;
            this.llFFGH.Text = "Github";
            this.llFFGH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llFFGH_LinkClicked);
            // 
            // llGWFB
            // 
            this.llGWFB.AutoSize = true;
            this.llGWFB.LinkColor = System.Drawing.Color.PeachPuff;
            this.llGWFB.Location = new System.Drawing.Point(141, 124);
            this.llGWFB.Name = "llGWFB";
            this.llGWFB.Size = new System.Drawing.Size(70, 17);
            this.llGWFB.TabIndex = 6;
            this.llGWFB.TabStop = true;
            this.llGWFB.Text = "Facebook";
            this.llGWFB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGWFB_LinkClicked);
            // 
            // lblGW
            // 
            this.lblGW.AutoSize = true;
            this.lblGW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGW.ForeColor = System.Drawing.Color.Yellow;
            this.lblGW.Location = new System.Drawing.Point(72, 48);
            this.lblGW.Name = "lblGW";
            this.lblGW.Size = new System.Drawing.Size(149, 25);
            this.lblGW.TabIndex = 3;
            this.lblGW.Text = "Greaseweazle";
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblText.Location = new System.Drawing.Point(12, 76);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(269, 43);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Tools and USB interface for accessing a floppy drive at the raw flux level ";
            // 
            // llGWGH
            // 
            this.llGWGH.ActiveLinkColor = System.Drawing.Color.Red;
            this.llGWGH.AutoSize = true;
            this.llGWGH.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.llGWGH.LinkColor = System.Drawing.Color.PeachPuff;
            this.llGWGH.Location = new System.Drawing.Point(82, 124);
            this.llGWGH.Name = "llGWGH";
            this.llGWGH.Size = new System.Drawing.Size(50, 17);
            this.llGWGH.TabIndex = 5;
            this.llGWGH.TabStop = true;
            this.llGWGH.Text = "Github";
            this.llGWGH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGWGH_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enhancements by Neil Balloch";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(316, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbGW);
            this.Controls.Add(this.lblGuiBy);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.llDSS);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.gbGW.ResumeLayout(false);
            this.gbGW.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llDSS;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblGuiBy;
        private System.Windows.Forms.GroupBox gbGW;
        private System.Windows.Forms.LinkLabel llGWFB;
        private System.Windows.Forms.Label lblGW;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.LinkLabel llGWGH;
        private System.Windows.Forms.LinkLabel llFFFB;
        private System.Windows.Forms.Label lblFF;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.LinkLabel llFFGH;
        private System.Windows.Forms.Label lblKF1;
        private System.Windows.Forms.GroupBox gbLine1;
        private System.Windows.Forms.Label label1;
    }
}