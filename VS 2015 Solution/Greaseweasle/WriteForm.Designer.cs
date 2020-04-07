namespace Greaseweazle
{
    partial class WriteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnWTDSelectFile = new System.Windows.Forms.Button();
            this.txtWTDCommandLine = new System.Windows.Forms.TextBox();
            this.lblStaticCL = new System.Windows.Forms.Label();
            this.gbWriteToDisk = new System.Windows.Forms.GroupBox();
            this.txtDriveSelectWTD = new System.Windows.Forms.TextBox();
            this.chkDriveSelectWTD = new System.Windows.Forms.CheckBox();
            this.chkWTDAdjustSpeed = new System.Windows.Forms.CheckBox();
            this.rbWriteDoubleSided = new System.Windows.Forms.RadioButton();
            this.rbWriteSingleSided = new System.Windows.Forms.RadioButton();
            this.txtWriteLastCyl = new System.Windows.Forms.TextBox();
            this.chkWriteLastCyl = new System.Windows.Forms.CheckBox();
            this.txtWriteFirstCyl = new System.Windows.Forms.TextBox();
            this.chkWriteFirstCyl = new System.Windows.Forms.CheckBox();
            this.toolTipWTD = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.gbWriteToDisk.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnLaunch);
            this.groupBox1.Controls.Add(this.btnWTDSelectFile);
            this.groupBox1.Controls.Add(this.txtWTDCommandLine);
            this.groupBox1.Controls.Add(this.lblStaticCL);
            this.groupBox1.Controls.Add(this.gbWriteToDisk);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(620, 502);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(390, 442);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 36);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(249, 442);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(122, 36);
            this.btnLaunch.TabIndex = 15;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnWTDSelectFile
            // 
            this.btnWTDSelectFile.Location = new System.Drawing.Point(107, 442);
            this.btnWTDSelectFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWTDSelectFile.Name = "btnWTDSelectFile";
            this.btnWTDSelectFile.Size = new System.Drawing.Size(122, 36);
            this.btnWTDSelectFile.TabIndex = 14;
            this.btnWTDSelectFile.Text = "Select File";
            this.btnWTDSelectFile.UseVisualStyleBackColor = true;
            this.btnWTDSelectFile.Click += new System.EventHandler(this.btnWTDSelectFile_Click);
            // 
            // txtWTDCommandLine
            // 
            this.txtWTDCommandLine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtWTDCommandLine.Location = new System.Drawing.Point(21, 326);
            this.txtWTDCommandLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWTDCommandLine.Multiline = true;
            this.txtWTDCommandLine.Name = "txtWTDCommandLine";
            this.txtWTDCommandLine.Size = new System.Drawing.Size(576, 92);
            this.txtWTDCommandLine.TabIndex = 13;
            // 
            // lblStaticCL
            // 
            this.lblStaticCL.AutoSize = true;
            this.lblStaticCL.Location = new System.Drawing.Point(253, 291);
            this.lblStaticCL.Name = "lblStaticCL";
            this.lblStaticCL.Size = new System.Drawing.Size(116, 20);
            this.lblStaticCL.TabIndex = 12;
            this.lblStaticCL.Text = "Command Line";
            // 
            // gbWriteToDisk
            // 
            this.gbWriteToDisk.Controls.Add(this.txtDriveSelectWTD);
            this.gbWriteToDisk.Controls.Add(this.chkDriveSelectWTD);
            this.gbWriteToDisk.Controls.Add(this.chkWTDAdjustSpeed);
            this.gbWriteToDisk.Controls.Add(this.rbWriteDoubleSided);
            this.gbWriteToDisk.Controls.Add(this.rbWriteSingleSided);
            this.gbWriteToDisk.Controls.Add(this.txtWriteLastCyl);
            this.gbWriteToDisk.Controls.Add(this.chkWriteLastCyl);
            this.gbWriteToDisk.Controls.Add(this.txtWriteFirstCyl);
            this.gbWriteToDisk.Controls.Add(this.chkWriteFirstCyl);
            this.gbWriteToDisk.Location = new System.Drawing.Point(21, 26);
            this.gbWriteToDisk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbWriteToDisk.Name = "gbWriteToDisk";
            this.gbWriteToDisk.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbWriteToDisk.Size = new System.Drawing.Size(576, 245);
            this.gbWriteToDisk.TabIndex = 2;
            this.gbWriteToDisk.TabStop = false;
            this.gbWriteToDisk.Enter += new System.EventHandler(this.gbWriteToDisk_Enter);
            // 
            // txtDriveSelectWTD
            // 
            this.txtDriveSelectWTD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDriveSelectWTD.Location = new System.Drawing.Point(396, 141);
            this.txtDriveSelectWTD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDriveSelectWTD.MaxLength = 1;
            this.txtDriveSelectWTD.Name = "txtDriveSelectWTD";
            this.txtDriveSelectWTD.Size = new System.Drawing.Size(60, 26);
            this.txtDriveSelectWTD.TabIndex = 9;
            this.txtDriveSelectWTD.Text = "A";
            this.txtDriveSelectWTD.TextChanged += new System.EventHandler(this.txtDriveSelectWTD_TextChanged);
            // 
            // chkDriveSelectWTD
            // 
            this.chkDriveSelectWTD.AutoSize = true;
            this.chkDriveSelectWTD.Enabled = false;
            this.chkDriveSelectWTD.Location = new System.Drawing.Point(120, 145);
            this.chkDriveSelectWTD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDriveSelectWTD.Name = "chkDriveSelectWTD";
            this.chkDriveSelectWTD.Size = new System.Drawing.Size(182, 24);
            this.chkDriveSelectWTD.TabIndex = 8;
            this.chkDriveSelectWTD.Text = "Drive Select (AB012)";
            this.toolTipWTD.SetToolTip(this.chkDriveSelectWTD, "Host Tools v0.10 or greater");
            this.chkDriveSelectWTD.UseVisualStyleBackColor = true;
            this.chkDriveSelectWTD.CheckedChanged += new System.EventHandler(this.chkDriveSelectWTD_CheckedChanged);
            // 
            // chkWTDAdjustSpeed
            // 
            this.chkWTDAdjustSpeed.AutoSize = true;
            this.chkWTDAdjustSpeed.Location = new System.Drawing.Point(120, 39);
            this.chkWTDAdjustSpeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWTDAdjustSpeed.Name = "chkWTDAdjustSpeed";
            this.chkWTDAdjustSpeed.Size = new System.Drawing.Size(130, 24);
            this.chkWTDAdjustSpeed.TabIndex = 3;
            this.chkWTDAdjustSpeed.Text = "Adjust Speed";
            this.toolTipWTD.SetToolTip(this.chkWTDAdjustSpeed, "Host Tools v0.05 or greater");
            this.chkWTDAdjustSpeed.UseVisualStyleBackColor = true;
            this.chkWTDAdjustSpeed.CheckedChanged += new System.EventHandler(this.chkWTDAdjustSpeed_CheckedChanged_1);
            // 
            // rbWriteDoubleSided
            // 
            this.rbWriteDoubleSided.AutoSize = true;
            this.rbWriteDoubleSided.Checked = true;
            this.rbWriteDoubleSided.Location = new System.Drawing.Point(252, 188);
            this.rbWriteDoubleSided.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbWriteDoubleSided.Name = "rbWriteDoubleSided";
            this.rbWriteDoubleSided.Size = new System.Drawing.Size(129, 24);
            this.rbWriteDoubleSided.TabIndex = 11;
            this.rbWriteDoubleSided.TabStop = true;
            this.rbWriteDoubleSided.Text = "Double Sided";
            this.rbWriteDoubleSided.UseVisualStyleBackColor = true;
            this.rbWriteDoubleSided.CheckedChanged += new System.EventHandler(this.rbWriteDoubleSided_CheckedChanged);
            // 
            // rbWriteSingleSided
            // 
            this.rbWriteSingleSided.AutoSize = true;
            this.rbWriteSingleSided.Location = new System.Drawing.Point(120, 188);
            this.rbWriteSingleSided.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbWriteSingleSided.Name = "rbWriteSingleSided";
            this.rbWriteSingleSided.Size = new System.Drawing.Size(122, 24);
            this.rbWriteSingleSided.TabIndex = 10;
            this.rbWriteSingleSided.TabStop = true;
            this.rbWriteSingleSided.Text = "Single Sided";
            this.rbWriteSingleSided.UseVisualStyleBackColor = true;
            this.rbWriteSingleSided.CheckedChanged += new System.EventHandler(this.rbWriteSingleSided_CheckedChanged);
            // 
            // txtWriteLastCyl
            // 
            this.txtWriteLastCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtWriteLastCyl.Location = new System.Drawing.Point(396, 105);
            this.txtWriteLastCyl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWriteLastCyl.Name = "txtWriteLastCyl";
            this.txtWriteLastCyl.Size = new System.Drawing.Size(60, 26);
            this.txtWriteLastCyl.TabIndex = 7;
            this.txtWriteLastCyl.Text = "79";
            // 
            // chkWriteLastCyl
            // 
            this.chkWriteLastCyl.AutoSize = true;
            this.chkWriteLastCyl.Location = new System.Drawing.Point(120, 109);
            this.chkWriteLastCyl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWriteLastCyl.Name = "chkWriteLastCyl";
            this.chkWriteLastCyl.Size = new System.Drawing.Size(177, 24);
            this.chkWriteLastCyl.TabIndex = 6;
            this.chkWriteLastCyl.Text = "Last cylinder to write";
            this.chkWriteLastCyl.UseVisualStyleBackColor = true;
            this.chkWriteLastCyl.CheckedChanged += new System.EventHandler(this.chkWriteLastCyl_CheckedChanged_1);
            // 
            // txtWriteFirstCyl
            // 
            this.txtWriteFirstCyl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtWriteFirstCyl.Location = new System.Drawing.Point(396, 69);
            this.txtWriteFirstCyl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWriteFirstCyl.Name = "txtWriteFirstCyl";
            this.txtWriteFirstCyl.Size = new System.Drawing.Size(60, 26);
            this.txtWriteFirstCyl.TabIndex = 5;
            this.txtWriteFirstCyl.Text = "0";
            this.txtWriteFirstCyl.TextChanged += new System.EventHandler(this.txtWriteFirstCyl_TextChanged);
            // 
            // chkWriteFirstCyl
            // 
            this.chkWriteFirstCyl.AutoSize = true;
            this.chkWriteFirstCyl.Location = new System.Drawing.Point(120, 74);
            this.chkWriteFirstCyl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWriteFirstCyl.Name = "chkWriteFirstCyl";
            this.chkWriteFirstCyl.Size = new System.Drawing.Size(177, 24);
            this.chkWriteFirstCyl.TabIndex = 4;
            this.chkWriteFirstCyl.Text = "First cylinder to write";
            this.chkWriteFirstCyl.UseVisualStyleBackColor = true;
            this.chkWriteFirstCyl.CheckedChanged += new System.EventHandler(this.chkWriteFirstCyl_CheckedChanged_1);
            // 
            // WriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(648, 536);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Write to Disk";
            this.Load += new System.EventHandler(this.WriteForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbWriteToDisk.ResumeLayout(false);
            this.gbWriteToDisk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbWriteToDisk;
        private System.Windows.Forms.TextBox txtDriveSelectWTD;
        private System.Windows.Forms.CheckBox chkDriveSelectWTD;
        private System.Windows.Forms.CheckBox chkWTDAdjustSpeed;
        private System.Windows.Forms.RadioButton rbWriteDoubleSided;
        private System.Windows.Forms.RadioButton rbWriteSingleSided;
        private System.Windows.Forms.TextBox txtWriteLastCyl;
        private System.Windows.Forms.CheckBox chkWriteLastCyl;
        private System.Windows.Forms.TextBox txtWriteFirstCyl;
        private System.Windows.Forms.CheckBox chkWriteFirstCyl;
        private System.Windows.Forms.Button btnWTDSelectFile;
        private System.Windows.Forms.TextBox txtWTDCommandLine;
        private System.Windows.Forms.Label lblStaticCL;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ToolTip toolTipWTD;
    }
}