// DelayForm.cs
//
// Greaseweazle GUI Wrapper
//
// Copyright (c) 2019 Don Mankin <don.mankin@yahoo.com>
//
// MIT License
//
// See the file LICENSE for more details, or visit <https://opensource.org/licenses/MIT>.

using System;

using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Greaseweazle
{
    public partial class DelaysForm : Form
    {
        #region declarations
        private const int WM_CLOSE = 0x0010;
        private Form m_frmChooser = null;
        private string m_sUSBPort = "UNKNOWN";
        private bool m_bWindowsEXE = false;
        private bool m_bUSBSupport = false;
        private bool m_bElapsedTime = false;
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
            // disable maximize box
            this.MaximizeBox = false;

            // set working directory to executable directory
            string sExeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
        #endregion

        #region btnBack_Click
        private void btnBack_Click(object sender, EventArgs e)
        {
            iniWriteFile();
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
            if (true == m_bWindowsEXE)
                txtDelaysCommandLine.Text = "gw.exe";
            else
                txtDelaysCommandLine.Text = "python.exe " + ChooserForm.m_sGWscript;
            if (true == m_bElapsedTime)
                txtDelaysCommandLine.Text += " --time";
            txtDelaysCommandLine.Text += " delays";
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
                txtDelaysCommandLine.Text += " --device=" + m_sUSBPort;
        }
        #endregion

        #region DelaysForm_Load
        private void DelaysForm_Load(object sender, EventArgs e)
        {
            // set colors
            this.lbOutput.BackColor = ChooserForm.cLightBrown;
            this.ctxClearOutput.BackColor = ChooserForm.cDarkBrown;
            this.ctxSaveOutput.BackColor = ChooserForm.cDarkBrown;
            this.lblHostTools.Text = ChooserForm.m_sStatusLine;
            this.BackColor = ChooserForm.cChocolate;
            this.txtDelayDriveSelect.BackColor = ChooserForm.cLightBrown;
            this.txtDelayHeadSteps.BackColor = ChooserForm.cLightBrown;
            this.txtDelaySeekSettle.BackColor = ChooserForm.cLightBrown;
            this.txtDelayMotorOn.BackColor = ChooserForm.cLightBrown;
            this.txtDelayAutoDeselect.BackColor = ChooserForm.cLightBrown;
            this.txtDelaysCommandLine.BackColor = ChooserForm.cLightBrown;
            this.btnLaunch.BackColor = ChooserForm.cDarkBrown;
            this.btnDelaysDefaults.BackColor = ChooserForm.cDarkBrown;
            this.btnBack.BackColor = ChooserForm.cDarkBrown;

            if (ChooserForm.m_bUseCmdConsole == true)
            {
                lbOutput.Items.Add("");
                lbOutput.Items.Add(ChooserForm.m_sConsoleMsg);
            }
            else
                ContextMenuStrip = ctxOutput;

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
            if (ChooserForm.m_bUseCmdConsole == true)
                LaunchPython();
            else
            {
                btnLaunch.Enabled = false;
                threadWorker.RunWorkerAsync();
            }
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
            if (ChooserForm.existsGWProcess())
                return;

            // create the command console
            ChooserForm.createCmdConsole("/K " + "\"" + txtDelaysCommandLine.Text + "\"");
        }
        #endregion

        #region LaunchPythonNew
        private void LaunchPythonNew()
        {
            ClearlbOutput();

            string sFn = "gw.exe";
            string args = txtDelaysCommandLine.Text;

            if (args.StartsWith("gw.exe"))
            {
                args = args.Substring("gw.exe".Length + 1);
            }
            else if (args.StartsWith("python.exe"))
            {
                sFn = "python.exe";
                args = args.Substring("python.exe".Length + 1);
            }

            var proc = new Process
            {
                EnableRaisingEvents = true,
                StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = ChooserForm.m_sExeDir,
                    Arguments = args,
                    FileName = sFn,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };

            proc.ErrorDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);
            proc.OutputDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);

            proc.Start();
            ChooserForm.m_ProcessId = proc.Id;

            proc.BeginErrorReadLine();
            proc.BeginOutputReadLine();

            proc.WaitForExit();
        }

        void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (null != e.Data)
            {
                UpdatelbOutput(e.Data);
            }
        }

        private void UpdatelbOutput(string lineOutput)
        {
            if (lbOutput.InvokeRequired)
            {
                lbOutput.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread
                    lbOutputDoUpdate(lineOutput);
                });
            }
            else
            {
                lbOutputDoUpdate(lineOutput);
            }
        }

        private void lbOutputDoUpdate(string lineOutput)
        {
            lbOutput.Items.Add(lineOutput);
            lbOutput.SelectedIndex = lbOutput.Items.Count - 1;
        }

        private void ClearlbOutput()
        {
            if (lbOutput.InvokeRequired)
            {
                lbOutput.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread
                    lbOutput.Items.Clear();
                });
            }
            else
            {
                lbOutput.Items.Clear();
            }
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

        #region threadWorker_DoWork
        private void threadWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            LaunchPythonNew();
        }
        #endregion

        #region threadWorker_RunWorkerCompleted
        private void threadWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            btnLaunch.Enabled = true;
        }
        #endregion

        #region ctxClearOutput_Click
        private void ctxClearOutput_Click(object sender, EventArgs e)
        {
            if ((btnLaunch.Enabled == true) && (ChooserForm.m_bUseCmdConsole == false))
                ClearlbOutput();
        }
        #endregion

        #region ctxSaveOutput_Click
        private void ctxSaveOutput_Click(object sender, EventArgs e)
        {
            if ((btnLaunch.Enabled == true) && (ChooserForm.m_bUseCmdConsole == false))
                ChooserForm.saveLbItemsToFile(lbOutput);
        }
        #endregion
    }
}
