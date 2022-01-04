// InputForm.cs
//
// Greaseweazle GUI Wrapper
//
// Copyright (c) 2019 Don Mankin <don.mankin@yahoo.com>
//
// MIT License
//
// See the file LICENSE for more details, or visit <https://opensource.org/licenses/MIT>.

using System;
using System.Linq;
using System.Windows.Forms;

namespace Greaseweazle
{
    public partial class InputForm : Form
    {
        private Form m_frmChooser = null;

        #region InputForm
        public InputForm(ChooserForm newForm)
        {
            m_frmChooser = newForm;
            InitializeComponent();

            // disable maximize box
            this.MaximizeBox = false;
        }
        #endregion

        #region btnBack_Click
        private void btnBack_Click(object sender, EventArgs e)
        {
            m_frmChooser.Show();
            this.Close();
        }
        #endregion

        #region WndProc
        protected override void WndProc(ref Message m) // capture close message so we can save our settings
        {
            int WM_CLOSE = 0x0010;
            if (m.Msg == WM_CLOSE)
            {
                // show main form
                ChooserForm.m_frmChooser.Show();
            }
            base.WndProc(ref m);
        }
        #endregion

        #region btnOK_Click
        private void btnOK_Click(object sender, EventArgs e)
        {
            string sProfileName = String.Concat(txtProfileName.Text.Where(c => !Char.IsWhiteSpace(c)));
            if (sProfileName.Length > 0)
            {
                // save chosen profile to greaseweazleGUI.ini
                ChooserForm.m_Ini.IniWriteValue("gbMisc", "txtProfile", sProfileName);

                // create a new profile.ini stub
                IniFile ifile = new IniFile(".\\" + sProfileName + ".ini");
                ifile.IniWriteValue("gbInfo", "txtInfoCommandLine", "python.exe gw.py info");
            }
            m_frmChooser.Show();
            this.Close();
        }
        #endregion
    }
}
