// PinForm.Designer.cs
//
// Greaseweazle GUI Wrapper
//
// Copyright (c) 2019 Don Mankin <don.mankin@yahoo.com>
//
// MIT License
//
// See the file LICENSE more details, or visit <https://opensource.org/licenses/MIT>.

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
    public partial class PinForm : Form
    {
        private const int WM_CLOSE = 0x0010;
        private Form m_frmChooser = null;
        private string m_sUSBPort = "UNKNOWN";
        private bool m_bUSBSupport = false;
        private bool m_bLegacyUSB = true;
        private bool m_bWindowsEXE = false;

        public PinForm(ChooserForm newForm)
        {
            m_frmChooser = newForm;
            InitializeComponent();

            // disable maximize box
            this.MaximizeBox = false;
        }

        #region iniWriteFile
        public void iniWriteFile()
        {
            // update firmware
            ChooserForm.m_Ini.IniWriteValue("gbPinLevel", "txtPin", txtPin.Text);
            ChooserForm.m_Ini.IniWriteValue("gbPinLevel", "rbLow", (rbLow.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbPinLevel", "rbHigh", (rbHigh.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbPinLevel", "txtPinCommandLine", txtPinCommandLine.Text);
        }
        #endregion

        #region iniReadFile
        public void iniReadFile()
        {
            string sRet;

            // pin level
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbPinLevel", "txtPin", "garbage").Trim())) != "garbage")
                txtPin.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbPinLevel", "rbLow", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbLow.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbPinLevel", "rbHigh", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbHigh.Checked = true;
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

        #region CreateCommandLine
        private void CreateCommandLine()
        {
            if (true == m_bWindowsEXE)
                txtPinCommandLine.Text = "gw.exe pin " + txtPin.Text;
            else
                txtPinCommandLine.Text = "python.exe " + ChooserForm.m_sGWscript + " pin " + txtPin.Text;
            if (rbHigh.Checked == true)
                txtPinCommandLine.Text += " H";
            else
                txtPinCommandLine.Text += " L";
            if ((m_bLegacyUSB == false) && (m_bUSBSupport == true) && (m_sUSBPort != "UNKNOWN"))
                txtPinCommandLine.Text += " --device=" + m_sUSBPort;
            if ((m_bLegacyUSB == true) && (m_bUSBSupport == true) && (m_sUSBPort != "UNKNOWN"))
                txtPinCommandLine.Text += " " + m_sUSBPort;
        }
        #endregion

        #region btnLaunch_Click
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            LaunchPython();
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
            startInfo.Arguments = "/K " + "\"" + txtPinCommandLine.Text + "\"";
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

        #region btnBack_Click
        private void btnBack_Click(object sender, EventArgs e)
        {
            iniWriteFile();
            m_frmChooser.Show();
            this.Close();
        }
        #endregion

        #region PinForm_Load
        private void PinForm_Load(object sender, EventArgs e)
        {
            // read inifile
            iniReadFile();

            // initialize status label
            this.toolStripStatusLabel.Text = ChooserForm.m_sStatusLine.Trim();
            this.toolStripStatusLabel.BackColor = ChooserForm.m_StatusColor;
            this.statusStrip.BackColor = ChooserForm.m_StatusColor;

            CreateCommandLine();
        }
        #endregion

        #region rbHigh_CheckedChanged
        private void rbHigh_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region rbLow_CheckedChanged
        private void rbLow_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region txtPin_TextChanged
        private void txtPin_TextChanged(object sender, EventArgs e)
        {
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
    }
}
