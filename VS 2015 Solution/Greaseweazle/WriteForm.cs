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
using System.Drawing;
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

            // load disk formats
            cbFormat.Items.Clear();
            cbFormat.Text = "UNSPECIFIED FORMAT";
            foreach (string desc in ChooserForm.m_listCustomFormats)
            {
                // get definition description
                cbFormat.Items.Add(desc);
                Console.WriteLine(desc);
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

        #region iniWriteFile
        public void iniWriteFile()
        {
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "m_sWTDFilename", m_sWTDFilename);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "cbExtension", cbExtension.Text);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "cbFormat", cbFormat.Text);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "chkDoubleStep", (chkDoubleStep.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "txtDoubleStep", txtDoubleStep.Text);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "chkEraseEmpty", (chkEraseEmpty.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "chkFakeIndex", (chkFakeIndex.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "txtFakeIndex", txtFakeIndex.Text);
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "cbFakeIndex", cbFakeIndex.Text);
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
            ChooserForm.m_Ini.IniWriteValue("gbWriteToDisk", "chkHeadSwap", (chkHeadSwap.Checked == true).ToString());
        }
        #endregion

        #region iniReadFile
        public void iniReadFile()
        {
            string sRet;

            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "cbExtension", "garbage").Trim())) != "garbage")
                cbExtension.SelectedIndex = cbExtension.FindString(sRet);
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "cbFormat", "garbage").Trim())) != "garbage")
                cbFormat.SelectedIndex = cbFormat.FindString(sRet);
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
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "chkFakeIndex", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkFakeIndex.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "txtFakeIndex", "garbage").Trim())) != "garbage")
            {
                txtFakeIndex.Text = sRet;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "cbFakeIndex", "garbage").Trim())) != "garbage")
            {
                cbFakeIndex.Text = sRet;
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
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWriteToDisk", "chkHeadSwap", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkHeadSwap.Checked = true;
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
                txtWTDCommandLine.Text = "gw.exe";
            else
                txtWTDCommandLine.Text = "python.exe " + ChooserForm.m_sGWscript;
            if (true == m_bElapsedTime)
                txtWTDCommandLine.Text += " --time";
            txtWTDCommandLine.Text += " write";
            if ((ChooserForm.m_bUseCustomFormats == true) && (cbFormat.Text != "UNSPECIFIED FORMAT"))
                txtWTDCommandLine.Text += " --diskdefs " + "\"" + ChooserForm.m_sDisktDefsFN + "\"";
            if ((cbFormat.Text.Length > 0) && (cbFormat.Text != "UNSPECIFIED FORMAT") && (cbFormat.ForeColor != Color.Black))  // black means disabled
                    txtWTDCommandLine.Text += " --format=" + cbFormat.Text;
            if (chkRetries.Checked == true)
                txtWTDCommandLine.Text += " --retries=" + txtRetries.Text;
            if ((chkDriveSelectWTD.Enabled == true) && (chkDriveSelectWTD.Checked == true))
                txtWTDCommandLine.Text += " --drive=" + txtDriveSelectWTD.Text;
            if (chkPrecomp.Checked == true)
                txtWTDCommandLine.Text += " --precomp=" + txtPrecomp.Text;
            if (chkDoubleStep.Checked == true)
                sTracks += "step=" + txtDoubleStep.Text + ":";
            if (chkEraseEmpty.Checked == true)
                txtWTDCommandLine.Text += " --erase-empty";
            if (chkFakeIndex.Checked == true)
                txtWTDCommandLine.Text += " --fake-index=" + txtFakeIndex.Text + cbFakeIndex.Text;
            if (chkCylSet.Checked == true)
                sTracks += "c=" + txtCylSet.Text + ":";
            if (chkHeadsSet.Checked == true)
                sTracks += "h=" + txtHeadsSet.Text + ":";
            if (chkHeadSwap.Checked == true)
                sTracks += "hswap:";
            if (chkFlippyOffset.Checked == true)
            {
                if (rbFlippyTeac.Checked == true)
                    sTracks += "h0.off=+8:";
                else if (rbFlippyPanasonic.Checked == true)
                    sTracks += "h1.off=-8:";
            }
            if (sTracks != " --tracks=")
            {
                if (sTracks.Substring(sTracks.Length - 1, 1) == ":") // remove trailing colon
                    sTracks = sTracks.Remove(sTracks.Length - 1, 1); ;
                txtWTDCommandLine.Text += sTracks;
            }
            if ((m_bUSBSupport == true) && (m_sUSBPort != "UNKNOWN"))
                txtWTDCommandLine.Text += " --device=" + m_sUSBPort;
            txtWTDCommandLine.Text += " " + "\"" + m_sWriteDiskFolder + "\\" + m_sWTDFilename + "\"";
        }
        #endregion

        #region LaunchPython
        private void LaunchPython()
        {
            // only allow one instance at a time
            if (ChooserForm.existsGWProcess())
                return;

            // create the command console
            ChooserForm.createCmdConsole("/K " + "\"" + txtWTDCommandLine.Text + "\"");
        }
        #endregion

        #region LaunchPythonNew
        private void LaunchPythonNew()
        {
            ClearlbOutput();

            string sFn = "gw.exe";
            string args = txtWTDCommandLine.Text;

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

        #region WriteForm_Load
        private void WriteForm_Load(object sender, EventArgs e)
        {
            // set colors
            this.lbOutput.BackColor = ChooserForm.cLightBrown;
            this.ctxClearOutput.BackColor = ChooserForm.cDarkBrown;
            this.ctxSaveOutput.BackColor = ChooserForm.cDarkBrown;
            this.lblHostTools.Text = ChooserForm.m_sStatusLine;
            this.BackColor = ChooserForm.cChocolate;
            this.txtDoubleStep.BackColor = ChooserForm.cLightBrown;
            this.txtDriveSelectWTD.BackColor = ChooserForm.cLightBrown;
            this.txtPrecomp.BackColor = ChooserForm.cLightBrown;
            this.txtCylSet.BackColor = ChooserForm.cLightBrown;
            this.txtRetries.BackColor = ChooserForm.cLightBrown;
            this.txtHeadsSet.BackColor = ChooserForm.cLightBrown;
            this.cbExtension.BackColor = ChooserForm.cLightBrown;
            this.cbFormat.BackColor = ChooserForm.cLightBrown;
            this.txtWTDCommandLine.BackColor = ChooserForm.cLightBrown;
            this.btnWTDSelectFile.BackColor = ChooserForm.cDarkBrown;
            this.btnLaunch.BackColor = ChooserForm.cDarkBrown;
            this.btnBack.BackColor = ChooserForm.cDarkBrown;
            this.txtFakeIndex.BackColor = ChooserForm.cLightBrown;
            this.cbFakeIndex.BackColor = ChooserForm.cLightBrown;

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
                btnBack.Enabled = false;
                threadWorker.RunWorkerAsync();
            }
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
            openDialog.Filter = ChooserForm.m_sExtFilter;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                m_sWTDFilename = openDialog.SafeFileName;
                m_sWriteDiskFolder = Path.GetDirectoryName(openDialog.FileName);
                string sExt = Path.GetExtension(m_sWTDFilename);
                int iIndex = cbExtension.FindString(sExt);
                cbExtension.SelectedIndex = iIndex;
                CreateCommandLine();
            }
        }
        #endregion

        #region changed

        private void txtWriteLastCyl_TextChanged(object sender, EventArgs e)
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

        private void chkHeadSwap_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkFakeIndex_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtFakeIndex_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void cbFakeIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        #endregion // changed

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

        #region cbExtension_SelectedIndexChanged
        private void cbExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
             string sFn = removeDiskType(this.m_sWTDFilename, true);
            m_sWTDFilename = sFn + cbExtension.Text;
            if (((cbExtension.Text == ".ipf") || (cbExtension.Text == ".dsk")) && (cbFormat.SelectedIndex != 0))
                cbFormat.ForeColor = Color.Black;
            else
                cbFormat.ForeColor = Color.White;
            CreateCommandLine();
        }
        #endregion 

        #region cbFormat_SelectedIndexChanged
        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbFormat.Text.Length > 0) && (cbFormat.Text != "UNSPECIFIED FORMAT") && (cbFormat.ForeColor != Color.Black))  // black means disabled
            {
                chkCylSet.Checked = false;
                chkHeadsSet.Checked = false;
                chkHeadSwap.Checked = false;
                chkDoubleStep.Checked = false;
                chkFlippyOffset.Checked = false;
            }
            CreateCommandLine();
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
