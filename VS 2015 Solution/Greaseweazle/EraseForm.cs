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
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Greaseweazle
{
    public partial class EraseForm : Form
    {
        #region declarations
        private const int WM_CLOSE = 0x0010;
        private string m_sUSBPort = "UNKNOWN";
        private bool m_bUSBSupport = false;
        private bool m_bWindowsEXE = false;
        private Form m_frmChooser = null;
        private bool m_bElapsedTime = false;
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
            //m_frmChooser.Show();
            this.Close();
        }
        #endregion

        #region iniWriteFile
        public void iniWriteFile()
        {
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "chkCylSet", (chkCylSet.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "txtCylSet", txtCylSet.Text);
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "chkHeadsSet", (chkHeadsSet.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "txtHeadsSet", txtHeadsSet.Text);
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "txtDriveSelect", txtDriveSelect.Text);
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "chkDriveSelect", (chkDriveSelect.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbEraseDisk", "txtEraseCommandLine", txtEraseCommandLine.Text);
        }
        #endregion

        #region iniReadFile
        public void iniReadFile()
        {
            string sRet;

            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbEraseDisk", "chkCylSet", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkCylSet.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbEraseDisk", "txtCylSet", "garbage").Trim())) != "garbage")
                txtCylSet.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbEraseDisk", "chkHeadsSet", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkHeadsSet.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbEraseDisk", "txtHeadsSet", "garbage").Trim())) != "garbage")
                txtHeadsSet.Text = sRet;
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
            string sTracks = " --tracks=";

            if (true == m_bWindowsEXE)
                txtEraseCommandLine.Text = "gw.exe";
            else
                txtEraseCommandLine.Text = "python.exe " + ChooserForm.m_sGWscript;
            if (true == m_bElapsedTime)
                txtEraseCommandLine.Text += " --time";
            txtEraseCommandLine.Text += " erase";
            if ((chkDriveSelect.Enabled == true) && (chkDriveSelect.Checked == true))
                txtEraseCommandLine.Text += " --drive=" + txtDriveSelect.Text;
            if (chkHeadsSet.Checked == true)
                sTracks += "h=" + txtHeadsSet.Text + ":";
            if (chkCylSet.Checked == true)
                sTracks += "c=" + txtCylSet.Text + ":";
            if (sTracks != " --tracks=")
            {
                if (sTracks.Substring(sTracks.Length - 1, 1) == ":") // remove trailing colon
                    sTracks = sTracks.Remove(sTracks.Length - 1, 1); ;
                txtEraseCommandLine.Text += sTracks;
            }

            if ((m_bUSBSupport == true) && (m_sUSBPort != "UNKNOWN"))
                txtEraseCommandLine.Text += " --device=" + m_sUSBPort;
        }
        #endregion

        #region LaunchPython
        private void LaunchPython()
        {
            // only allow one instance at a time
            if (ChooserForm.existsGWProcess())
                return;

            // create the command console
            ChooserForm.createCmdConsole("/K " + "\"" + txtEraseCommandLine.Text + "\"");
        }
        #endregion

        #region LaunchPythonNew
        private void LaunchPythonNew()
        {
            ClearlbOutput();

            string sFn = "gw.exe";
            string args = txtEraseCommandLine.Text;

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
        }
        #endregion

        #region EraseForm_Load
        private void EraseForm_Load(object sender, EventArgs e)
        {
            // set colors
            this.lbOutput.BackColor = ChooserForm.cLightBrown;
            this.ctxClearOutput.BackColor = ChooserForm.cDarkBrown;
            this.ctxSaveOutput.BackColor = ChooserForm.cDarkBrown;
            this.lblHostTools.Text = ChooserForm.m_sStatusLine;
            this.BackColor = ChooserForm.cChocolate;
            this.txtCylSet.BackColor = ChooserForm.cLightBrown;
            this.txtHeadsSet.BackColor = ChooserForm.cLightBrown;
            this.txtDriveSelect.BackColor = ChooserForm.cLightBrown;
            this.txtEraseCommandLine.BackColor = ChooserForm.cLightBrown;
            this.btnLaunch.BackColor = ChooserForm.cDarkBrown;
            this.btnBack.BackColor = ChooserForm.cDarkBrown;

            iniReadFile();
            CreateCommandLine();

            if (ChooserForm.m_bUseCmdConsole == true)
            {
                lbOutput.Items.Add("");
                lbOutput.Items.Add(ChooserForm.m_sConsoleMsg);
            }
            else
                ContextMenuStrip = ctxOutput;
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

        #region changed

        private void chkDriveSelect_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

       private void gbEraseDisk_Enter(object sender, EventArgs e)
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

        #region chkCylSet_CheckedChanged
        private void chkCylSet_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region txtCylSet_TextChanged
        private void txtCylSet_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region chkHeadsSet_CheckedChanged
        private void chkHeadsSet_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region txtHeadsSet_TextChanged
        private void txtHeadsSet_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
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
