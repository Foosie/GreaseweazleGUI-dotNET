namespace Greaseweazle
{
    partial class PictureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureForm));
            this.pbGWbig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGWbig)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGWbig
            // 
            this.pbGWbig.Image = ((System.Drawing.Image)(resources.GetObject("pbGWbig.Image")));
            this.pbGWbig.Location = new System.Drawing.Point(-2, -2);
            this.pbGWbig.Name = "pbGWbig";
            this.pbGWbig.Size = new System.Drawing.Size(1148, 603);
            this.pbGWbig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGWbig.TabIndex = 11;
            this.pbGWbig.TabStop = false;
            this.pbGWbig.Click += new System.EventHandler(this.pbGWbig_Click);
            // 
            // PictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 598);
            this.ControlBox = false;
            this.Controls.Add(this.pbGWbig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PictureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pbGWbig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGWbig;
    }
}