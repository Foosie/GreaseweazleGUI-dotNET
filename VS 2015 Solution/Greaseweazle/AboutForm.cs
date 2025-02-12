// AboutForm.cs
//
// Greaseweazle GUI Wrapper
//
// Copyright (c) 2019 Don Mankin <don.mankin@yahoo.com>
//
// MIT License
//
// See the file LICENSE for more details, or visit <https://opensource.org/licenses/MIT>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greaseweazle
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            gbLine1.Height = 2;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ControlBox = false;
            this.BackColor = ChooserForm.cChocolate;
            this.lblText.BackColor = ChooserForm.cLightBrown;
            this.lblText2.BackColor = ChooserForm.cLightBrown;
            this.btnOK.BackColor = ChooserForm.cDarkBrown;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // brring up main applicaiton form
            ChooserForm.m_frmChooser.BringToFront();
            this.Close();
            this.Dispose();
        }

        private void llDSS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //Open the default browser with a URL:
                System.Diagnostics.Process.Start("https://desertsagesolutions.com/software/Greaseweazlegui/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked - "+ ex.Message);
            }
        }

        private void llGWGH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //Open the default browser with a URL:
                System.Diagnostics.Process.Start("https://github.com/keirf/Greaseweazle/wiki/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked - " + ex.Message);
            }
        }

        private void llGWFB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //Open the default browser with a URL:
                System.Diagnostics.Process.Start("https://www.facebook.com/groups/greaseweazle/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked - " + ex.Message);
            }
        }

        private void llFFGH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //Open the default browser with a URL:
                System.Diagnostics.Process.Start("https://github.com/keirf/flashfloppy/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked - " + ex.Message);
            }
        }

        private void llFFFB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //Open the default browser with a URL:
                System.Diagnostics.Process.Start("https://www.facebook.com/groups/flashfloppy/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked - " + ex.Message);
            }
        }
        #region ProcessCmdKey
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
    }

}
