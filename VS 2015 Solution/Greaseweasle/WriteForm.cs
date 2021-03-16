// WriteForm.cs
//
// Greaseweazle GUI Wrapper
//
// Copyright (c) 2019 Don Mankin <don.mankin@yahoo.com>
//
// MIT License
//
// See the file LICENSE for more details, or visit <https://opensource.org/licenses/MIT>.using System;

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Greaseweazle
{
    public partial class WriteForm : Form
    {
        #region declarations
        private const int WM_CLOSE = 0x0010;
        private string m_sWriteDiskFolder = "";
        private string m_sWTDFilename = "mydisk.scp";
        private string m_sUSBPort = "UNKNOWN";
        private bool m_bWindowsEXE = false;
        private bool m_bUSBSupport = false;
        private bool m_bLegacyUSB = true;
        private Form m_frmChooser = null;
        private bool m_bElapsedTime = false;
        #endregion

        #region WriteForm
        public WriteForm(ChooserForm newForm)
        {
            m_frmChooser = newForm;
            InitializeComponent();
            InitializeMyStuff();
        }
        #endregion

        #region InitializeMyStuff
        private void InitializeMyStuff()
        {
            // disable maximize box
            this.MaximizeBox = false;

            // set working directory to executable directory
            string sExeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Directory.SetCurrentDirectory(sExeDir);

            if (m_sWriteDiskFolder.Length == 0)
                m_sWriteDiskFolder = sExeDir;
        }
        #endregion

        #region btnBack_Click
        private void btnBack_Click(object sender, EventArgs e)
        {
            iniWriteFile();
            m_frmChooser.Show();
            this.Close();
        }
        #endregion

        #region iniWriteFile
        public void iniWriteFile()
        {
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "m_sWTDFilename", m_sWTDFilename);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "cbExtension", cbExtension.Text);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "chkDoubleStep", (chkDoubleStep.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "txtDoubleStep", txtDoubleStep.Text);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "chkEraseEmpty", (chkEraseEmpty.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "txtDriveSelectWTD", txtDriveSelectWTD.Text);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "chkDriveSelectWTD", (chkDriveSelectWTD.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "txtPrecomp", txtPrecomp.Text);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "chkPrecomp", (chkPrecomp.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "m_sWriteDiskFolder", m_sWriteDiskFolder);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "txtRTDCommandLine", txtWTDCommandLine.Text);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "chkCylSet", (chkCylSet.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "txtCylSet", txtCylSet.Text);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "chkHeadsSet", (chkHeadsSet.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "txtHeadsSet", txtHeadsSet.Text);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "chkRetries", (chkRetries.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "txtRetries", txtRetries.Text);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "chkFlippyOffset", (chkFlippyOffset.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "rbFlippyPanasonic", (rbFlippyPanasonic.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "rbFlippyTeac", (rbFlippyTeac.Checked == true).ToString());
        }
        #endregion

        #region iniReadFile
        public void iniReadFile()
        {
            string sRet;

            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "cbExtension", "garbage").Trim())) != "garbage")
                cbExtension.SelectedIndex = cbExtension.FindString(sRet);
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "m_sWTDFilename", "garbage").Trim())) != "garbage")
                m_sWTDFilename = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "m_sWriteDiskFolder", "garbage").Trim())) != "garbage")
                m_sWriteDiskFolder = sRet;

            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "chkDoubleStep", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDoubleStep.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "txtDoubleStep", "garbage").Trim())) != "garbage")
                txtDoubleStep.Text = sRet;

            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "chkEraseEmpty", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkEraseEmpty.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "txtDriveSelectWTD", "garbage").Trim())) != "garbage")
                txtDriveSelectWTD.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "chkDriveSelectWTD", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDriveSelectWTD.Checked = true;
            }

            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "txtPrecomp", "garbage").Trim())) != "garbage")
                txtPrecomp.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "chkPrecomp", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkPrecomp.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "txtRetries", "garbage").Trim())) != "garbage")
                txtRetries.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "chkRetries", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkRetries.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "chkCylSet", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkCylSet.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "txtCylSet", "garbage").Trim())) != "garbage")
                txtCylSet.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "chkHeadsSet", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkHeadsSet.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "txtHeadsSet", "garbage").Trim())) != "garbage")
                txtHeadsSet.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "chkFlippyOffset", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkFlippyOffset.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "rbFlippyPanasonic", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbFlippyPanasonic.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "rbFlippyTeac", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbFlippyTeac.Checked = true;
            }

            // usb port
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbUSBPorts", "m_sUSBPort", "garbage").Trim())) != "garbage")
                m_sUSBPort = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbUSBPorts", "mnuUSBSupport", "garbage").Trim())) != "garbage")
                m_bUSBSupport = (sRet == "True");
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbUSBPorts", "chkLegacyUSB", "garbage").Trim())) != "garbage")
                m_bLegacyUSB = (sRet == "True");

            // globals
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbGlobals", "mnuWindowsEXE", "garbage").Trim())) != "garbage")
                m_bWindowsEXE = (sRet == "True");
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbGlobals", "mnuElapsedTime", "garbage").Trim())) != "garbage")
                m_bElapsedTime = (sRet == "True");
        }
        #endregion

        #region CreateCommandLine
        private void CreateCommandLine()
        {
            string sTrack = " --track=";

            if (true == m_bWindowsEXE)
                txtWTDCommandLine.Text = "gw.exe";
            else
                txtWTDCommandLine.Text = "python.exe " + ChooserForm.m_sGWscript;
            if (true == m_bElapsedTime)
                txtWTDCommandLine.Text += " --time";
            txtWTDCommandLine.Text += " write";
            if (chkRetries.Checked == true)
                txtWTDCommandLine.Text += " --retries=" + txtRetries.Text;
            if ((chkDriveSelectWTD.Enabled == true) && (chkDriveSelectWTD.Checked == true))
                txtWTDCommandLine.Text += " --drive=" + txtDriveSelectWTD.Text;
            if (chkPrecomp.Checked == true)
                txtWTDCommandLine.Text += " --precomp=" + txtPrecomp.Text;

            // conditional command line syntax
            if (chkDoubleStep.Checked == true)
                sTrack += "step=" + txtDoubleStep.Text + ":";

            if (chkEraseEmpty.Checked == true)
                txtWTDCommandLine.Text += " --erase-empty";
            if (chkHeadsSet.Checked == true)
                sTrack += "h=" + txtHeadsSet.Text + ":";
            if (chkCylSet.Checked == true)
                sTrack += "c=" + txtCylSet.Text + ":";
            if (chkFlippyOffset.Checked == true)
            {
                if (rbFlippyTeac.Checked == true)
                    sTrack += "h0.off=+8:";
                else if (rbFlippyPanasonic.Checked == true)
                    sTrack += "h1.off=-8:";
            }
            if (sTrack != " --track=")
            {
                if (sTrack.Substring(sTrack.Length - 1, 1) == ":") // remove trailing colon
                    sTrack = sTrack.Remove(sTrack.Length - 1, 1); ;
                txtWTDCommandLine.Text += sTrack;
            }

            // old syntax
            if ((m_bLegacyUSB == false) && (m_bUSBSupport == true) && (m_sUSBPort != "UNKNOWN"))
                txtWTDCommandLine.Text += " --device=" + m_sUSBPort;
            txtWTDCommandLine.Text += " " + "\"" + m_sWriteDiskFolder + "\\" + m_sWTDFilename + "\"";
            if ((m_bLegacyUSB == true) && (m_bUSBSupport == true) && (m_sUSBPort != "UNKNOWN"))
                txtWTDCommandLine.Text += " " + m_sUSBPort;
        }
        #endregion

        #region LaunchPython
        private void LaunchPython()
        {
            // only allow one instance at a time
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                if (theprocess.Id > 0)
                {
                    if (ChooserForm.m_ProcessId == theprocess.Id)
                    {
                        System.Windows.Forms.MessageBox.Show("You must first close the previous Greaseweazle command console", "Oops!");
                        return;
                    }
                }
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "C:\\WINDOWS\\SYSTEM32\\cmd.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            txtWTDCommandLine.Text = txtWTDCommandLine.Text.Trim(); // remove empty usb port if it exists
            startInfo.Arguments = "/K " + "\"" + txtWTDCommandLine.Text + "\"";
            try
            {
                Process exeProcess = Process.Start(startInfo);
                ChooserForm.m_ProcessId = exeProcess.Id;
            }
            catch (Exception e)
            {
                string sMessage = e.Message.ToString();
                MessageBox.Show(this, "An error has occured\n" + sMessage, "Oops!");
            }
        }
        #endregion

        #region WriteForm_Load
        private void WriteForm_Load(object sender, EventArgs e)
        {
            // set colors
            this.lblHostTools.Text = ChooserForm.m_sStatusLine;
            this.BackColor = ChooserForm.cChocolate;
            this.txtDoubleStep.BackColor = ChooserForm.cLightBrown;
            this.txtDriveSelectWTD.BackColor = ChooserForm.cLightBrown;
            this.txtPrecomp.BackColor = ChooserForm.cLightBrown;
            this.txtCylSet.BackColor = ChooserForm.cLightBrown;
            this.txtRetries.BackColor = ChooserForm.cLightBrown;
            this.txtHeadsSet.BackColor = ChooserForm.cLightBrown;
            this.cbExtension.BackColor = ChooserForm.cLightBrown;
            this.txtWTDCommandLine.BackColor = ChooserForm.cLightBrown;
            this.btnWTDSelectFile.BackColor = ChooserForm.cDarkBrown;
            this.btnLaunch.BackColor = ChooserForm.cDarkBrown;
            this.btnBack.BackColor = ChooserForm.cDarkBrown;

            iniReadFile();
            CreateCommandLine();
        }
        #endregion

        #region btnLaunch_Click
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            LaunchPython();
        }
        #endregion

        #region btnWTDSelectFile_Click
        private void btnWTDSelectFile_Click(object sender, EventArgs e)
        {
            // select file and folder where file is to be read from
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.RestoreDirectory = true; // make sure directory is set to executable path
            openDialog.InitialDirectory = m_sWriteDiskFolder;
            openDialog.Multiselect = false;
            openDialog.Title = "Select an image";
            openDialog.Filter = "Images|*.scp;*.hfe;*.adf;*.ipf;*.dsk|All files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                m_sWTDFilename = openDialog.SafeFileName;
                m_sWriteDiskFolder = Path.GetDirectoryName(openDialog.FileName);
                CreateCommandLine();
            }
        }
        #endregion

        #region changed

        private void txtWriteLastCyl_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }


        private void chkWTDAdjustSpeed_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDriveSelectWTD_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void gbWriteToDisk_Enter(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtWriteFirstCyl_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDriveSelectWTD_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDoubleStep_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkEraseEmpty_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkLegacySS_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDoubleStep_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

         private void chkCylSet_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtCylSet_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkHeadsSet_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtHeadsSet_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void rbFlippyPanasonic_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void rbFlippyTeac_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkFlippyOffset_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFlippyOffset.Checked)
            {
                chkHeadsSet.Checked = true;
                txtHeadsSet.Text = "0-1";
                chkDoubleStep.Checked = true;
                txtDoubleStep.Text = "2";
            }
            CreateCommandLine();
        }

        private void chkPrecomp_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtPrecomp_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }


        private void chkRetries_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtRetries_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        #endregion // changed

        #region WndProc
        protected override void WndProc(ref Message m) // capture close message so we can save our settings
        {
            if (m.Msg == WM_CLOSE)
            {
                // write inifile
                iniWriteFile();

                // show main form
                ChooserForm.m_frmChooser.Show();
            }
            base.WndProc(ref m);
        }
        #endregion

        #region cbExtension_SelectedIndexChanged
        private void cbExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_sWTDFilename = removeDiskType(m_sWTDFilename, true) + cbExtension.Text;      
            CreateCommandLine();
        }
        #endregion

        #region removeDiskType
        private string removeDiskType(string fn, bool noext)
        {
            string sRemove = ".scp::disktype=amiga";
            int pos = fn.IndexOf(sRemove);
            if (pos >= 0)
                return (fn.Substring(0, pos));
            sRemove = ".scp::disktype=c64";
            pos = fn.IndexOf(sRemove);
            if (pos >= 0)
                return (fn.Substring(0, pos));
            if (noext)
            {
                string s = Path.GetFileNameWithoutExtension(fn);
                if (s.EndsWith("."))
                    s = s.Remove(s.Length - 1);   // remove period
                return (s);
            }
            else
            {
                if (fn.EndsWith("."))
                    fn = fn.Remove(fn.Length - 1);   // remove period
                return (fn);
            }
        }
        #endregion
    }
}
