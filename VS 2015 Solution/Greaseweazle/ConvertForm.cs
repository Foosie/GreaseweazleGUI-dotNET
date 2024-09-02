// ConvertForm.cs
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
using System.Drawing;

namespace Greaseweazle
{
    public partial class ConvertForm : Form
    {
        #region declarations
        private const int WM_CLOSE = 0x0010;
        private string m_sUSBPort = "UNKNOWN";
        private bool m_bUSBSupport = false;
        private bool m_bWindowsEXE = false;
        private Form m_frmChooser = null;
        private bool m_bElapsedTime = false;
        private string m_sInputFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private string m_sOutputFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        #endregion

        #region ConvertForm
        public ConvertForm(ChooserForm newForm)
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

            // load disk formats
            cbFormat.Items.Clear();
            cbFormat.Text = "UNSPECIFIED FORMAT";
            foreach (string desc in ChooserForm.m_listCustomFormats)
            {
                // get definition description
                cbFormat.Items.Add(desc);
                Console.WriteLine(desc);
            }

            // load file extensions
            cbExtension.Items.Clear();
            foreach (string desc in ChooserForm.m_listExtensions)
            {
                // get definition description
                cbExtension.Items.Add(desc);
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
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkCylSet", (chkCylSet.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "txtCylSet", txtCylSet.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkHeadsSet", (chkHeadsSet.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "txtHeadsSet", txtHeadsSet.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "txtAdjustSpeed", txtAdjustSpeed.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkAdjustSpeed", chkAdjustSpeed.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkRevTrkData", chkRevTrkData.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "cbAdjustSpeed", txtAdjustSpeed.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "cbAdjustSpeed", txtAdjustSpeed.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkDoubleStep", (chkDoubleStep.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "txtDoubleStep", txtDoubleStep.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkAdjustSpeed", (chkAdjustSpeed.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkRevTrkData", (chkRevTrkData.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "txtAdjustSpeed", txtAdjustSpeed.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "cbAdjustSpeed", cbAdjustSpeed.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "cbFormat", cbFormat.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkCylSet", (chkCylSet.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "txtCylSet", txtCylSet.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkHeadsSet", (chkHeadsSet.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "txtHeadsSet", txtHeadsSet.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkHeadSwap", (chkHeadSwap.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "txtConvertCommandLine", txtConvertCommandLine.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkNoClobber", (chkNoClobber.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "m_sInputFolder", m_sInputFolder);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "m_sOutputFolder", m_sOutputFolder);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "txtInputFile", txtInputFile.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "txtOutputFile", txtOutputFile.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkOutTracks", (chkOutTracks.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkOTDoubleStep", (chkOTDoubleStep.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "txtOTDoubleStep", txtOTDoubleStep.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkOTHeadSwap", (chkOTHeadSwap.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkPLLSpec", (chkPLLSpec.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "chkHardSectors", (chkHardSectors.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "txtPLLPeriod", txtPLLPeriod.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "txtPLLPhase", txtPLLPhase.Text);
            ChooserForm.m_Ini.IniWriteValue("gbConvert", "cbExtension", cbExtension.Text);
        }
        #endregion

        #region iniReadFile
        public void iniReadFile()
        {
            string sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "cbFormat", "garbage").Trim())) != "garbage")
                cbFormat.SelectedIndex = cbFormat.FindString(sRet);
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "chkDoubleStep", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDoubleStep.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "txtDoubleStep", "garbage").Trim())) != "garbage")
                txtDoubleStep.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "txtAdjustSpeed", "garbage").Trim())) != "garbage")
                txtAdjustSpeed.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "chkAdjustSpeed", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkAdjustSpeed.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "chkRevTrkData", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkRevTrkData.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "cbAdjustSpeed", "garbage").Trim())) != "garbage")
                cbAdjustSpeed.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "chkCylSet", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkCylSet.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "txtCylSet", "garbage").Trim())) != "garbage")
                txtCylSet.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "chkHeadsSet", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkHeadsSet.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "txtHeadsSet", "garbage").Trim())) != "garbage")
                txtHeadsSet.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "chkHeadSwap", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkHeadSwap.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "chkNoClobber", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkNoClobber.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "chkHardSectors", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkHardSectors.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "m_sInputFolder", "garbage").Trim())) != "garbage")
                m_sInputFolder = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "txtInputFile", "garbage").Trim())) != "garbage")
                txtInputFile.Text = sRet;           
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "m_sOutputFolder", "garbage").Trim())) != "garbage")
                m_sOutputFolder = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "txtOutputFile", "garbage").Trim())) != "garbage")
                txtOutputFile.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "chkOutTracks", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkOutTracks.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "chkOTDoubleStep", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkOTDoubleStep.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "txtOTDoubleStep", "garbage").Trim())) != "garbage")
                txtOTDoubleStep.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "chkOTHeadSwap", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkOTHeadSwap.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "txtPLLPeriod", "garbage").Trim())) != "garbage")
            {
                txtPLLPeriod.Text = sRet;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "txtPLLPhase", "garbage").Trim())) != "garbage")
            {
                txtPLLPhase.Text = sRet;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "chkPLLSpec", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkPLLSpec.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbConvert", "cbExtension", "garbage").Trim())) != "garbage")
                cbExtension.SelectedIndex = cbExtension.FindString(sRet);

            // usb port
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbUSBPorts", "m_sUSBPort", "garbage").Trim())) != "garbage")
                m_sUSBPort = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbUSBPorts", "mnuUSBSupport", "garbage").Trim())) != "garbage")
                m_bUSBSupport = (sRet == "True");

            // windows executable
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
            string sOutputTracks = " --out-tracks=";

            if (true == m_bWindowsEXE)
                txtConvertCommandLine.Text = "gw.exe";
            else
                txtConvertCommandLine.Text = "python.exe " + ChooserForm.m_sGWscript;
            if (true == m_bElapsedTime)
                txtConvertCommandLine.Text += " --time";
            txtConvertCommandLine.Text += " convert";
            if ((ChooserForm.m_bUseCustomFormats == true) && (cbFormat.Text != "UNSPECIFIED FORMAT"))
                txtConvertCommandLine.Text += " --diskdefs " + "\"" + ChooserForm.m_sDisktDefsFN + "\"";
            if ((chkAdjustSpeed.Enabled == true) && (chkAdjustSpeed.Checked == true))
                txtConvertCommandLine.Text += " --adjust-speed=" + txtAdjustSpeed.Text + cbAdjustSpeed.Text;
            if (chkRevTrkData.Checked == true)
                txtConvertCommandLine.Text += " --reverse";
            if (chkPLLSpec.Checked == true)
                txtConvertCommandLine.Text += " --pll=period=" + txtPLLPeriod.Text + ":phase=" + txtPLLPhase.Text;
            if (chkHardSectors.Checked == true)
                txtConvertCommandLine.Text += " -hard-sectors";
            if (chkNoClobber.Checked == true)
                txtConvertCommandLine.Text += " --no-clobber";
            if ((cbFormat.Text.Length > 0) && (cbFormat.Text != "UNSPECIFIED FORMAT"))
                txtConvertCommandLine.Text += " --format=" + cbFormat.Text;
            if (chkCylSet.Checked == true)
            {
                sTracks += "c=" + txtCylSet.Text + ":";
                sOutputTracks += "c=" + txtCylSet.Text + ":";
            }
            if (chkHeadsSet.Checked == true)
            {
                sTracks += "h=" + txtHeadsSet.Text + ":";
                sOutputTracks += "h=" + txtHeadsSet.Text + ":";
            }
            if (chkDoubleStep.Checked == true)
                sTracks += "step=" + txtDoubleStep.Text + ":";
            if (chkHeadSwap.Checked == true)
                sTracks += "hswap:";

            if (sTracks != " --tracks=")
            {
                if (sTracks.Substring(sTracks.Length - 1, 1) == ":") // remove trailing colon
                    sTracks = sTracks.Remove(sTracks.Length - 1, 1); ;
                txtConvertCommandLine.Text += sTracks;
            }
            if (chkOutTracks.Checked == true)
            {
                if (chkOTDoubleStep.Checked == true)
                    sOutputTracks += "step=" + txtOTDoubleStep.Text + ":";
                if (chkOTHeadSwap.Checked == true)
                    sOutputTracks += "hswap:";
                if (sOutputTracks.Substring(sOutputTracks.Length - 1, 1) == ":") // remove trailing colon
                    sOutputTracks = sOutputTracks.Remove(sOutputTracks.Length - 1, 1); ;
                txtConvertCommandLine.Text += sOutputTracks;
            }

            txtConvertCommandLine.Text += " \"" + m_sInputFolder + "\\" + txtInputFile.Text + "\" \"" + m_sOutputFolder + "\\" + txtOutputFile.Text + "\"";
        }
        #endregion

        #region LaunchPython
        private void LaunchPython()
        {
            // only allow one instance at a time
            if (ChooserForm.existsGWProcess())
                return;

            // create the command console
            ChooserForm.createCmdConsole("/K " + "\"" + txtConvertCommandLine.Text + "\"");
        }
        #endregion

        #region LaunchPythonNew
        private void LaunchPythonNew()
        {
            ClearlbOutput();

            string sFn = "gw.exe";
            string args = txtConvertCommandLine.Text;

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

        #region ConvertForm_Load
        private void ConvertForm_Load(object sender, EventArgs e)
        {
            // set colors
            this.BackColor = ChooserForm.cChocolate;
            this.cbExtension.ForeColor = Color.White;
            this.cbExtension.BackColor = ChooserForm.cLightBrown;
            this.lblHostTools.Text = ChooserForm.m_sStatusLine;
            this.lbOutput.BackColor = ChooserForm.cLightBrown;
            this.txtCylSet.BackColor = ChooserForm.cLightBrown;
            this.txtHeadsSet.BackColor = ChooserForm.cLightBrown;
            this.txtAdjustSpeed.BackColor = ChooserForm.cLightBrown;
            this.cbAdjustSpeed.BackColor = ChooserForm.cLightBrown;
            this.txtDoubleStep.BackColor = ChooserForm.cLightBrown;
            this.txtInputFile.BackColor = ChooserForm.cLightBrown;
            this.txtOutputFile.BackColor = ChooserForm.cLightBrown;
            this.txtOTDoubleStep.BackColor = ChooserForm.cLightBrown;
            this.txtConvertCommandLine.BackColor = ChooserForm.cLightBrown;
            this.cbFormat.BackColor = ChooserForm.cLightBrown;
            this.ctxSaveOutput.BackColor = ChooserForm.cDarkBrown;
            this.btnLaunch.BackColor = ChooserForm.cDarkBrown;
            this.btnBack.BackColor = ChooserForm.cDarkBrown;
            this.btnOutputFile.BackColor = ChooserForm.cDarkBrown;
            this.btnInputFile.BackColor = ChooserForm.cDarkBrown;
            this.ctxClearOutput.BackColor = ChooserForm.cDarkBrown;
            this.txtPLLPeriod.BackColor = ChooserForm.cDarkBrown;
            this.txtPLLPhase.BackColor = ChooserForm.cDarkBrown;

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
            if (txtInputFile.Text.Length == 0)
            {
                MessageBox.Show(this, "You must first select an input filename", "Oops!");
                return;
            }
            if (txtOutputFile.Text.Length == 0)
            {
                MessageBox.Show(this, "You must first select an output filename", "Oops!");
                return;
            }
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

        #region changed

        private void chkDriveSelect_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDriveSelect_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkAdjustSpeed_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtAdjustSpeed_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void cbAdjustSpeed_SelectedIndexChanged(object sender, EventArgs e)
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

        private void chkHeadsSet_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtHeadsSet_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDoubleStep_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkCylSet_CheckedChanged_1(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkNoClobber_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDoubleStep_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtCylSet_TextChanged_1(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkHeadsSet_CheckedChanged_1(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkHeadSwap_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtHeadsSet_TextChanged_1(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbFormat.Text.Length > 0) && (cbFormat.Text != "UNSPECIFIED FORMAT"))  // black means disabled
            {
                chkCylSet.Checked = false;
                chkHeadsSet.Checked = false;
                chkDoubleStep.Checked = false;
                chkHeadSwap.Checked = false;
                chkAdjustSpeed.Checked = false;
            }
            CreateCommandLine();
        }

        private void btnInputFile_Click(object sender, EventArgs e)
        {
            // select file and folder where file is to be read from
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.RestoreDirectory = true; // make sure directory is set to executable path
            openDialog.InitialDirectory = m_sInputFolder;
            openDialog.Multiselect = false;
            openDialog.CheckFileExists = false;
            openDialog.Title = "Select an image";
            openDialog.Filter = ChooserForm.m_sExtFilter;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = openDialog.SafeFileName;
                m_sInputFolder = Path.GetDirectoryName(openDialog.FileName);
                CreateCommandLine();
            }
        }

        private void txtInputFile_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void btnOutputFile_Click(object sender, EventArgs e)
        {
            // select folder where file is to be written to
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            ofd.SelectedPath = m_sOutputFolder;
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
                m_sOutputFolder = ofd.SelectedPath;

            // make sure directory is set to executable path
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            CreateCommandLine();
        }

        private void chkFlippyOffset_CheckedChanged(object sender, EventArgs e)
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

        private void chkOutTracks_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkOTDoubleStep_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtOTDoubleStep_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkOTHeadSwap_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkPLLSpec_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkHardSectors_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtPLLPeriod_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtPLLPhase_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtOutputFile_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void cbExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sFn = removeDiskType(txtOutputFile.Text, true);
            txtOutputFile.Text = sFn + cbExtension.Text;
            CreateCommandLine();
        }

        private void chkRevTrkData_CheckedChanged(object sender, EventArgs e)
        {
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
            sRemove = ".hfe::version=3";
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
