// CleanForm.cs
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
using System.Windows.Forms;

namespace Greaseweazle
{
    public partial class CleanForm : Form
    {
        #region declarations
        private const int WM_CLOSE = 0x0010;
        private Form m_frmChooser = null;
        private string m_sUSBPort = "UNKNOWN";
        private bool m_bUSBSupport = false;
        private bool m_bWindowsEXE = false;
        private bool m_bElapsedTime = false;
        #endregion

        #region ResetForm
        public CleanForm(ChooserForm newForm)
        {
            m_frmChooser = newForm;
            InitializeComponent();

            // disable maximize box
            this.MaximizeBox = false;
        }
        #endregion

        #region LaunchPython
        private void LaunchPython()
        {
            // only allow one instance at a time
            if (ChooserForm.existsGWProcess())
                return;

            // create the command console
            ChooserForm.createCmdConsole("/K " + "\"" + txtCleanCommandLine.Text + "\"");
        }
        #endregion

        #region LaunchPythonNew
        private void LaunchPythonNew()
        {
            ClearlbOutput();

            string sFn = "gw.exe";
            string args = txtCleanCommandLine.Text;

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
            btnBack.Enabled = true;
        }
        #endregion

        #region CreateCommandLine
        private void CreateCommandLine()
        {
            if (true == m_bWindowsEXE)
                txtCleanCommandLine.Text = "gw.exe";
            else
                txtCleanCommandLine.Text = "python.exe " + ChooserForm.m_sGWscript;
            if (true == m_bElapsedTime)
                txtCleanCommandLine.Text += " --time";
            txtCleanCommandLine.Text += " clean";
            if ((chkDriveSelect.Enabled == true) && (chkDriveSelect.Checked == true))
                txtCleanCommandLine.Text += " --drive=" + txtDriveSelect.Text;
            if (chkPasses.Checked == true)
                txtCleanCommandLine.Text += " --passes=" + txtPasses.Text;
            if (chkLinger.Checked == true)
                txtCleanCommandLine.Text += " --linger=" + txtLinger.Text;
            if (chkCylSet.Checked == true)
                txtCleanCommandLine.Text += " cyls=" + txtCylSet.Text;
            if ((m_bUSBSupport == true) && (m_sUSBPort != "UNKNOWN"))
                txtCleanCommandLine.Text += " --device=" + m_sUSBPort;
        }
        #endregion

        #region iniWriteFile
        public void iniWriteFile()
        {
            // reset controller
            ChooserForm.m_Ini.IniWriteValue("gbClean", "txtCleanCommandLine", txtCleanCommandLine.Text);
            ChooserForm.m_Ini.IniWriteValue("gbClean", "chkCylSet", (chkCylSet.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbClean", "txtCylSet", txtCylSet.Text);
            ChooserForm.m_Ini.IniWriteValue("gbClean", "txtDriveSelect", txtDriveSelect.Text);
            ChooserForm.m_Ini.IniWriteValue("gbClean", "chkDriveSelect", (chkDriveSelect.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbClean", "txtPasses", txtPasses.Text);
            ChooserForm.m_Ini.IniWriteValue("gbClean", "chkPasses", (chkPasses.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbClean", "txtLinger", txtLinger.Text);
            ChooserForm.m_Ini.IniWriteValue("gbClean", "chkLinger", (chkLinger.Checked == true).ToString());
        }
        #endregion

        #region iniReadFile
        public void iniReadFile()
        {
            string sRet;

            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbClean", "chkCylSet", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkCylSet.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbClean", "txtCylSet", "garbage").Trim())) != "garbage")
                txtCylSet.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbClean", "txtDriveSelect", "garbage").Trim())) != "garbage")
                txtDriveSelect.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbClean", "chkDriveSelect", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDriveSelect.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbClean", "chkPasses", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkPasses.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbClean", "txtPasses", "garbage").Trim())) != "garbage")
                txtPasses.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbClean", "chkLinger", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkLinger.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbClean", "txtLinger", "garbage").Trim())) != "garbage")
                txtLinger.Text = sRet;

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

        #region btnLaunch_Click
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (ChooserForm.m_bUseCmdConsole == true)
                LaunchPython();
            else
            {
                btnLaunch.Enabled = false;
                btnBack.Enabled = false;
                threadWorker.RunWorkerAsync();
            }
        }
        #endregion

        #region btnBack_Click
        private void btnBack_Click(object sender, EventArgs e)
        {
            iniWriteFile();
            //m_frmChooser.Show();
            this.Close();
        }
        #endregion

        #region CleanForm_Load
        private void CleanForm_Load(object sender, EventArgs e)
        {
            iniReadFile();

            // set colors
            this.txtPasses.BackColor = ChooserForm.cLightBrown;
            this.txtLinger.BackColor = ChooserForm.cLightBrown;
            this.txtCylSet.BackColor = ChooserForm.cLightBrown;
            this.txtDriveSelect.BackColor = ChooserForm.cLightBrown;
            this.lbOutput.BackColor = ChooserForm.cLightBrown;
            this.ctxClearOutput.BackColor = ChooserForm.cDarkBrown;
            this.ctxSaveOutput.BackColor = ChooserForm.cDarkBrown;
            this.lblHostTools.Text = ChooserForm.m_sStatusLine;
            this.BackColor = ChooserForm.cChocolate;
            this.txtCleanCommandLine.BackColor = ChooserForm.cLightBrown;
            this.btnLaunch.BackColor = ChooserForm.cDarkBrown;
            this.btnBack.BackColor = ChooserForm.cDarkBrown;

            if (ChooserForm.m_bUseCmdConsole == true)
            {
                lbOutput.Items.Add("");
                lbOutput.Items.Add(ChooserForm.m_sConsoleMsg);
            }
            else
                ContextMenuStrip = ctxOutput;

            // create the command line
            CreateCommandLine();
        }
        #endregion

        #region WndProc
        protected override void WndProc(ref Message m) // capture close message so we can save our settings
        {
            if (m.Msg == WM_CLOSE)
            {
                // confirm close if windowed process is still running
                if (!ChooserForm.confirmCloseProcess(this.btnLaunch))
                    return;

                // write inifile
                iniWriteFile();

                // show main form
                ChooserForm.m_frmChooser.Show();
            }
            base.WndProc(ref m);
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

        #region Changed

        private void chkCylSet_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtCylSet_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkLinger_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtLinger_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDriveSelect_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDriveSelect_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkPasses_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtPasses_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        #endregion
    }
}
