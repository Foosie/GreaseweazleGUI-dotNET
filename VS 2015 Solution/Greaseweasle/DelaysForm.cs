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
    public partial class DelaysForm : Form
    {
        #region declarations
        public const int WM_CLOSE = 0x0010;
        private Form m_frmChooser = null;
        private string m_sUSBPort = "UNKNOWN";
        private bool m_bUSBSupport = false;
        #endregion

        #region DelaysForm
        public DelaysForm(ChooserForm newForm)
        {
            m_frmChooser = newForm;
            InitializeComponent();
            InitializeMyStuff();
        }
        #endregion

        #region InitializeMyStuff
        private void InitializeMyStuff()
        {
            // set working directory to executable directory
            string sExeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
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
            // set delays
            ChooserForm.m_Ini.IniWriteValue("gbSetDelays", "txtDelayAutoDeselect", txtDelayAutoDeselect.Text);
            ChooserForm.m_Ini.IniWriteValue("gbSetDelays", "chkDelayAutoDeselect", (chkDelayAutoDeselect.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbSetDelays", "txtDelayMotorOn", txtDelayMotorOn.Text);
            ChooserForm.m_Ini.IniWriteValue("gbSetDelays", "chkDelayMotorOn", (chkDelayMotorOn.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbSetDelays", "txtDelaySeekSettle", txtDelaySeekSettle.Text);
            ChooserForm.m_Ini.IniWriteValue("gbSetDelays", "chkDelaySeekSettle", (chkDelaySeekSettle.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbSetDelays", "txtDelayDriveSelect", txtDelayDriveSelect.Text);
            ChooserForm.m_Ini.IniWriteValue("gbSetDelays", "chkDelayDriveSelect", (chkDelayDriveSelect.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbSetDelays", "txtDelayHeadSteps", txtDelayHeadSteps.Text);
            ChooserForm.m_Ini.IniWriteValue("gbSetDelays", "chkDelayHeadSteps", (chkDelayHeadSteps.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbSetDelays", "txtDelaysCommandLine", txtDelaysCommandLine.Text);
        }
        #endregion

        #region iniReadFile
        public void iniReadFile()
        {
            string sRet;

            // set delays
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbSetDelays", "txtDelayAutoDeselect", "garbage").Trim())) != "garbage")
                txtDelayAutoDeselect.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbSetDelays", "chkDelayAutoDeselect", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDelayAutoDeselect.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbSetDelays", "txtDelayMotorOn", "garbage").Trim())) != "garbage")
                txtDelayMotorOn.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbSetDelays", "chkDelayMotorOn", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDelayMotorOn.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbSetDelays", "txtDelaySeekSettle", "garbage").Trim())) != "garbage")
                txtDelaySeekSettle.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbSetDelays", "chkDelaySeekSettle", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDelaySeekSettle.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbSetDelays", "txtDelayDriveSelect", "garbage").Trim())) != "garbage")
                txtDelayDriveSelect.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbSetDelays", "chkDelayDriveSelect", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDelayDriveSelect.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbSetDelays", "txtDelayHeadSteps", "garbage").Trim())) != "garbage")
                txtDelayHeadSteps.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbSetDelays", "chkDelayHeadSteps", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDelayHeadSteps.Checked = true;
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
            txtDelaysCommandLine.Text = "python.exe gw.py delays";
            if (chkDelayDriveSelect.Checked == true)
                txtDelaysCommandLine.Text += " --select=" + txtDelayDriveSelect.Text;
            if (chkDelayHeadSteps.Checked == true)
                txtDelaysCommandLine.Text += " --step=" + txtDelayHeadSteps.Text;
            if (chkDelaySeekSettle.Checked == true)
                txtDelaysCommandLine.Text += " --settle=" + txtDelaySeekSettle.Text;
            if (chkDelayMotorOn.Checked == true)
                txtDelaysCommandLine.Text += " --motor=" + txtDelayMotorOn.Text;
            if (chkDelayAutoDeselect.Checked == true)
                txtDelaysCommandLine.Text += " --auto-off=" + txtDelayAutoDeselect.Text;
            if ((m_bUSBSupport == true) && (m_sUSBPort != "UNKNOWN"))
                txtDelaysCommandLine.Text += " " + m_sUSBPort;
        }
        #endregion

        #region DelaysForm_Load
        private void DelaysForm_Load(object sender, EventArgs e)
        {
            // read inifile
            iniReadFile();
            CreateCommandLine();
        }
        #endregion

        #region Changed
        private void chkDelayDriveSelect_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDelayHeadSteps_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDelaySeekSettle_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDelayMotorOn_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDelayAutoDeselect_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDelayDriveSelect_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDelayHeadSteps_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDelaySeekSettle_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDelayMotorOn_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDelayAutoDeselect_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region btnLaunch_Click
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            LaunchPython();
        }
        #endregion

        #region btnDelaysDefaults_Click
        private void btnDelaysDefaults_Click(object sender, EventArgs e)
        {
            txtDelayDriveSelect.Text = "10";
            txtDelayHeadSteps.Text = "3000";
            txtDelaySeekSettle.Text = "15";
            txtDelayMotorOn.Text = "750";
            txtDelayAutoDeselect.Text = "10000";
            CreateCommandLine();
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
            startInfo.Arguments = "/K " + "\"" + txtDelaysCommandLine.Text + "\"";
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
    }
}
