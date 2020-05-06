// EraseForm.cs
//
// Greaseweazle GUI Wrapper
//
// Copyright (c) 2019 Don Mankin <don.mankin@yahoo.com>
//
// MIT License
//
// See the file LICENSE for more details, or visit <https://opensource.org/licenses/MIT>.using System;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greaseweazle
{
    public partial class EraseForm : Form
    {
        #region declarations
        private const int WM_CLOSE = 0x0010;
        private string m_sUSBPort = "UNKNOWN";
        private bool m_bUSBSupport = false;
        private Form m_frmChooser = null;
        #endregion

        #region EraseForm
        public EraseForm(ChooserForm newForm)
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
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "rbWriteDoubleSided", (rbWriteDoubleSided.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "rbWriteSingleSided", (rbWriteSingleSided.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "txtWriteLastCyl", txtWriteLastCyl.Text);
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "chkWriteLastCyl", (chkWriteLastCyl.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "txtWriteFirstCyl", txtWriteFirstCyl.Text);
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "chkWriteFirstCyl", (chkWriteFirstCyl.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "txtDriveSelect", txtDriveSelect.Text);
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "chkDriveSelect", (chkDriveSelect.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "txtEraseCommandLine", txtEraseCommandLine.Text);
        }
        #endregion

        #region iniReadFile
        public void iniReadFile()
        {
            string sRet;

            // found out the controller type
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbType", "rbF7", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                {
                    chkDriveSelect.Enabled = true;
                    txtDriveSelect.Enabled = true;
                }
                else
                {
                    chkDriveSelect.Enabled = false;
                    txtDriveSelect.Enabled = false;
                }
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbEraseDisk", "rbWriteDoubleSided", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbWriteDoubleSided.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbEraseDisk", "rbWriteSingleSided", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbWriteSingleSided.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbEraseDisk", "txtWriteLastCyl", "garbage").Trim())) != "garbage")
                txtWriteLastCyl.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbEraseDisk", "chkWriteLastCyl", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkWriteLastCyl.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbEraseDisk", "txtWriteFirstCyl", "garbage").Trim())) != "garbage")
                txtWriteFirstCyl.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbEraseDisk", "chkWriteFirstCyl", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkWriteFirstCyl.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbEraseDisk", "txtDriveSelect", "garbage").Trim())) != "garbage")
                txtDriveSelect.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbEraseDisk", "chkDriveSelect", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDriveSelect.Checked = true;
            }

            // usb port
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbUSBPorts", "m_sUSBPort", "garbage").Trim())) != "garbage")
                m_sUSBPort = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbUSBPorts", "mnuUSBSupport", "garbage").Trim())) != "garbage")
                m_bUSBSupport = (sRet == "True");
        }
        #endregion

        #region CreateCommandLine
        private void CreateCommandLine()
        {
            txtEraseCommandLine.Text = "python.exe gw.py erase";
            if (chkWriteFirstCyl.Checked == true)
                txtEraseCommandLine.Text += " --scyl=" + txtWriteFirstCyl.Text;
            if (chkWriteLastCyl.Checked == true)
                txtEraseCommandLine.Text += " --ecyl=" + txtWriteLastCyl.Text;
            if (rbWriteSingleSided.Checked == true)
                txtEraseCommandLine.Text += " --single-sided";
            if ((chkDriveSelect.Enabled == true) && (chkDriveSelect.Checked == true))
                txtEraseCommandLine.Text += " --drive=" + txtDriveSelect.Text;
            if ((m_bUSBSupport == true) && (m_sUSBPort != "UNKNOWN"))
                txtEraseCommandLine.Text += " " + m_sUSBPort;
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
            txtEraseCommandLine.Text = txtEraseCommandLine.Text.Trim(); // remove empty usb port if it exists
            startInfo.Arguments = "/K " + "\"" + txtEraseCommandLine.Text + "\"";
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

        #region EraseForm_Load
        private void EraseForm_Load(object sender, EventArgs e)
        {
            // read inifile
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

        #region changed

        private void chkWriteLastCyl_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkWriteFirstCyl_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDriveSelect_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

       private void gbEraseDisk_Enter(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void rbWriteSingleSided_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void rbWriteDoubleSided_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtWriteFirstCyl_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDriveSelect_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtWriteLastCyl_TextChanged(object sender, EventArgs e)
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

    }
}
