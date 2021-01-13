// InfoForm.cs
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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greaseweazle
{
    public partial class InfoForm : Form
    {
        private const int WM_CLOSE = 0x0010;
        private Form m_frmChooser = null;
        private string m_sUSBPort = "UNKNOWN";
        private bool m_bUSBSupport = false;
        private bool m_bLegacyUSB = true;
        private bool m_bWindowsEXE = false;
        private bool m_bF7Type = true;

        #region InfoForm
        public InfoForm(ChooserForm newForm)
        {
            m_frmChooser = newForm;
            InitializeComponent();

            // disable maximize box
            this.MaximizeBox = false;

            // extend tooltip time
            toolTip1.ShowAlways = true;
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
            startInfo.Arguments = "/K " + "\"" + txtInfoCommandLine.Text + "\"";
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

        #region CreateCommandLine
        private void CreateCommandLine()
        {
            if (true == m_bWindowsEXE)
                txtInfoCommandLine.Text = "gw.exe info";
            else
                txtInfoCommandLine.Text = "python.exe " + ChooserForm.m_sGWscript + " info";
            if (chkBootLoader.Checked == true)
                txtInfoCommandLine.Text += " --bootloader";
            if ((m_bLegacyUSB == false) && (m_bUSBSupport == true) && (m_sUSBPort != "UNKNOWN"))
                txtInfoCommandLine.Text += " --device=" + m_sUSBPort;
            if ((m_bLegacyUSB == true) && (m_bUSBSupport == true) && (m_sUSBPort != "UNKNOWN"))
                txtInfoCommandLine.Text += " " + m_sUSBPort;
        }
        #endregion

        #region iniWriteFile
        public void iniWriteFile()
        {
            ChooserForm.m_Ini.IniWriteValue("gbInfo", "txtInfoCommandLine", txtInfoCommandLine.Text);
        }
        #endregion

        #region iniReadFile
        public void iniReadFile()
        {
            string sRet;

            // find out the controller type
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbType", "rbF7", "garbage").Trim())) != "garbage")
            {
                if (sRet != "True")
                    m_bF7Type = false;
            }

            // usb port
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbUSBPorts", "m_sUSBPort", "garbage").Trim())) != "garbage")
                m_sUSBPort = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbUSBPorts", "mnuUSBSupport", "garbage").Trim())) != "garbage")
                m_bUSBSupport = (sRet == "True");
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbUSBPorts", "chkLegacyUSB", "garbage").Trim())) != "garbage")
                m_bLegacyUSB = (sRet == "True");

            // windows executable
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWindowsEXE", "mnuWindowsEXE", "garbage").Trim())) != "garbage")
                m_bWindowsEXE = (sRet == "True");
        }
        #endregion

        #region btnLaunch_Click
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            LaunchPython();
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

        #region InfoForm_Load
        private void InfoForm_Load(object sender, EventArgs e)
        {
            // initialize status label
            this.toolStripStatusLabel.Text = ChooserForm.m_sStatusLine.Trim();
            this.toolStripStatusLabel.BackColor = ChooserForm.m_StatusColor;
            this.statusStrip.BackColor = ChooserForm.m_StatusColor;

            // bootloader support enabled in v0.16 for type F7
            if ((ChooserForm.m_GWToolsVersion < (decimal)0.16) || (!m_bF7Type))
                this.chkBootLoader.BackColor =  Color.FromArgb(255, 182, 193);

            iniReadFile();
            CreateCommandLine();
        }
        #endregion

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

        #region chkBootLoader_CheckedChanged
        private void chkBootLoader_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion
    }
}
