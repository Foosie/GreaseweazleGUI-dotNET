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
            this.BackColor = Color.LightBlue;
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
                MessageBox.Show("Unable to open link that was clicked.");
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
                MessageBox.Show("Unable to open link that was clicked.");
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
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void llFFGH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //Open the default browser with a URL:
                System.Diagnostics.Process.Start("https://github.com/keirf/FlashFloppy/wiki/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
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
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
    }

}
