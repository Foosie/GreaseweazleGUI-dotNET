// ReadForm.cs
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
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Greaseweazle
{
    public partial class ReadForm : Form
    {
        #region declarations
        private string m_sReadDiskFolder = "";
        private string m_sUSBPort = "UNKNOWN";
        private bool m_bUSBSupport = false;
        private bool m_bWindowsEXE = false;
        private Form m_frmChooser = null;
        private const int WM_CLOSE = 0x0010;
        private const string m_sSeperator = "--";
        private bool m_bElapsedTime = false;
        #endregion

        #region ReadForm
        public ReadForm(ChooserForm newForm)
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

            if (m_sReadDiskFolder.Length == 0)
                m_sReadDiskFolder = sExeDir;
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
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "m_sRFDFilename",tbFilename.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "cbExtension", cbExtension.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "cbFormat", cbFormat.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkDoubleStep", (chkDoubleStep.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtDoubleStep", txtDoubleStep.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkLegacySS", (chkLegacySS.Checked == true).ToString());          
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtRevsPerTrack", txtRevsPerTrack.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkRevsPerTrack", (chkRevsPerTrack.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtDriveSelectRFD", txtDriveSelectRFD.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkDriveSelectRFD", (chkDriveSelectRFD.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "m_sReadDiskFolder", m_sReadDiskFolder);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtRFDCommandLine", txtRFDCommandLine.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkDriveRateRFD", (chkDriveRateRFD.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtDriveRateRFD", txtDriveRateRFD.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkDriveRpmRFD", (chkDriveRpmRFD.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtDriveRpmRFD", txtDriveRpmRFD.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkDriveRetriesRFD", (chkDriveRetriesRFD.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtDriveRetriesRFD", txtDriveRetriesRFD.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkAutoInc", (chkAutoInc.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkCylSet", (chkCylSet.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtCylSet", txtCylSet.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkHeadsSet", (chkHeadsSet.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtHeadsSet", txtHeadsSet.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkFlippyOffset", (chkFlippyOffset.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "rbFlippyPanasonic", (rbFlippyPanasonic.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "rbFlippyTeac", (rbFlippyTeac.Checked == true).ToString());
        }
        #endregion

        #region iniReadFile
        public void iniReadFile()
        {
            string sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "cbExtension", "garbage").Trim())) != "garbage")
                cbExtension.SelectedIndex = cbExtension.FindString(sRet);
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "cbFormat", "garbage").Trim())) != "garbage")
                cbFormat.SelectedIndex = cbFormat.FindString(sRet);
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "m_sRFDFilename", "garbage").Trim())) != "garbage")
            {
                tbFilename.Text = sRet;
                SetFNSuffix();
                CreateCommandLine();           
            }          
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkLegacySS", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkLegacySS.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtRevsPerTrack", "garbage").Trim())) != "garbage")
                txtRevsPerTrack.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkRevsPerTrack", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkRevsPerTrack.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtDriveSelectRFD", "garbage").Trim())) != "garbage")
                txtDriveSelectRFD.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkDriveSelectRFD", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDriveSelectRFD.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "m_sReadDiskFolder", "garbage").Trim())) != "garbage")
                m_sReadDiskFolder = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkDoubleStep", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDoubleStep.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtDoubleStep", "garbage").Trim())) != "garbage")
                txtDoubleStep.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtDriveRateRFD", "garbage").Trim())) != "garbage")
                txtDriveRateRFD.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkDriveRateRFD", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDriveRateRFD.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtDriveRpmRFD", "garbage").Trim())) != "garbage")
                txtDriveRpmRFD.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkDriveRpmRFD", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDriveRpmRFD.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtDriveRetriesRFD", "garbage").Trim())) != "garbage")
                txtDriveRetriesRFD.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkDriveRetriesRFD", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDriveRetriesRFD.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkAutoInc", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkAutoInc.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkCylSet", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkCylSet.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtCylSet", "garbage").Trim())) != "garbage")
                txtCylSet.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkHeadsSet", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkHeadsSet.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtHeadsSet", "garbage").Trim())) != "garbage")
                txtHeadsSet.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkFlippyOffset", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkFlippyOffset.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "rbFlippyPanasonic", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbFlippyPanasonic.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "rbFlippyTeac", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbFlippyTeac.Checked = true;
            }

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
            string sTrack = " --track=";

            if (true == m_bWindowsEXE)
                txtRFDCommandLine.Text = "gw.exe";
            else
                txtRFDCommandLine.Text = "python.exe " + ChooserForm.m_sGWscript;
            if (true == m_bElapsedTime)
                txtRFDCommandLine.Text += " --time";
            txtRFDCommandLine.Text += " read";
            if (chkDriveRetriesRFD.Checked == true)
                txtRFDCommandLine.Text += " --retries=" + txtDriveRetriesRFD.Text;
            if (chkRevsPerTrack.Checked == true)
                txtRFDCommandLine.Text += " --revs=" + txtRevsPerTrack.Text;
            if (chkDriveRateRFD.Checked == true)
                txtRFDCommandLine.Text += " --rate=" + txtDriveRateRFD.Text;
            if (chkDriveRpmRFD.Checked == true)
                txtRFDCommandLine.Text += " --rpm=" + txtDriveRpmRFD.Text;
            if ((chkDriveSelectRFD.Enabled == true) && (chkDriveSelectRFD.Checked == true))
                txtRFDCommandLine.Text += " --drive=" + txtDriveSelectRFD.Text;
            if (chkDoubleStep.Checked == true)
                    sTrack += "step=" + txtDoubleStep.Text + ":";
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
                txtRFDCommandLine.Text += sTrack;
            }
            if (cbFormat.Text.Length > 0)
                txtRFDCommandLine.Text += " --format " + cbFormat.Text;
            if ((m_bUSBSupport == true) && (m_sUSBPort != "UNKNOWN"))
                txtRFDCommandLine.Text += " --device=" + m_sUSBPort;
            txtRFDCommandLine.Text += " " + "\"" + m_sReadDiskFolder + "\\" + tbFilename.Text.Trim();
            if (chkLegacySS.Checked == true)
                txtRFDCommandLine.Text += "::legacy_ss";
            txtRFDCommandLine.Text += "\"";
        }
        #endregion

        #region CheckedChanged
        private void chkRevsPerTrack_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDriveSelectRFD_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDoubleStep_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDriveRateRFD_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDriveRpmRFD_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDriveRetriesRFD_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDriveRateRFD_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDriveRpmRFD_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtRevsPerTrack_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtReadFirstCyl_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtReadLastCyl_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDriveSelectRFD_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkLegacySS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLegacySS.Checked)
            {
                chkHeadsSet.Checked = true;
                txtHeadsSet.Text = "0";
            }
            CreateCommandLine();
        }

        private void chkCylSet_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkHeadsSet_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkHeadsSet.Checked)
                chkLegacySS.Checked = false;
            CreateCommandLine();
        }

        private void chkFlippyOffset_CheckedChanged(object sender, EventArgs e)
        {
            // uncheck things here
            chkHeadsSet.Checked = true;
            txtHeadsSet.Text = "0-1";
            chkDoubleStep.Checked = true;
            txtDoubleStep.Text = "2";
            CreateCommandLine();
        }


        private void rbFlippyPanasonic_CheckedChanged(object sender, EventArgs e)
        {
            // turn off heads checkmark and set heads
            CreateCommandLine();
        }

        private void rbFlippyTeac_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtCylSet_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtHeadsSet_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDoubleStep_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtDriveRetriesRFD_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void cbExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilename.Text = removeDiskType(this.tbFilename.Text, true) + cbExtension.Text;
            //if (cbExtension.Text != ".ipf")
                //cbFormat.SelectedIndex = 0;
            CreateCommandLine();
        }

        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region ReadForm_Load
        private void ReadForm_Load(object sender, EventArgs e)
        {
            // set colors
            this.lblHostTools.Text = ChooserForm.m_sStatusLine;
            this.BackColor = ChooserForm.cChocolate;
            this.txtDoubleStep.BackColor = ChooserForm.cLightBrown;
            this.txtRevsPerTrack.BackColor = ChooserForm.cLightBrown;
            this.txtDriveSelectRFD.BackColor = ChooserForm.cLightBrown;
            this.txtDriveRateRFD.BackColor = ChooserForm.cLightBrown;
            this.txtDriveRetriesRFD.BackColor = ChooserForm.cLightBrown;
            this.txtDriveRpmRFD.BackColor = ChooserForm.cLightBrown;
            this.txtCylSet.BackColor = ChooserForm.cLightBrown;
            this.txtHeadsSet.BackColor = ChooserForm.cLightBrown;
            this.tbFilename.BackColor = ChooserForm.cLightBrown;
            this.tbSuffix.BackColor = ChooserForm.cLightBrown;
            this.cbExtension.ForeColor = Color.White;
            this.cbExtension.BackColor = ChooserForm.cLightBrown;
            this.cbFormat.ForeColor = Color.White;
            this.cbFormat.BackColor = ChooserForm.cLightBrown;
            this.btnInc.BackColor = ChooserForm.cDarkBrown;
            this.btnDec.BackColor = ChooserForm.cDarkBrown;
            this.txtRFDCommandLine.BackColor = ChooserForm.cLightBrown;
            this.btnRFDSelectFolder.BackColor = ChooserForm.cDarkBrown;
            this.btnRFDSelectFile.BackColor = ChooserForm.cDarkBrown;
            this.btnLaunch.BackColor = ChooserForm.cDarkBrown;
            this.btnBack.BackColor = ChooserForm.cDarkBrown;

            iniReadFile();
            CreateCommandLine();
        }
        #endregion  

        #region btnRFDSelectFolder_Click
        private void btnRFDSelectFolder_Click(object sender, EventArgs e)
        {
            // select folder where file is to be written to
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            ofd.SelectedPath = m_sReadDiskFolder;
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
                m_sReadDiskFolder = ofd.SelectedPath;

            // make sure directory is set to executable path
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            CreateCommandLine();
        }
        #endregion

        #region btnRFDSelectFile_Click
        private void btnRFDSelectFile_Click(object sender, EventArgs e)
        {
            // select file and folder where file is to be read from
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.RestoreDirectory = true; // make sure directory is set to executable path
            openDialog.InitialDirectory = m_sReadDiskFolder;
            openDialog.Multiselect = false;
            openDialog.Title = "Select an image";
            openDialog.Filter = "Images|*.adf;*.adl;*.adm;*.ads;*.dsd;*.dsk;*.hfe;*.ipf;*.scp;*.ssd|All files (*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                tbFilename.Text = openDialog.SafeFileName;
                m_sReadDiskFolder = Path.GetDirectoryName(openDialog.FileName);
                string sExt = Path.GetExtension(tbFilename.Text);
                int iIndex = cbExtension.FindString(sExt);
                cbExtension.SelectedIndex = iIndex;
                CreateCommandLine();
            }
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
            txtRFDCommandLine.Text = txtRFDCommandLine.Text.Trim(); // remove empty usb port if it exists
            startInfo.Arguments = "/K " + "\"" + txtRFDCommandLine.Text + "\"";
            try
            {
                Process exeProcess = Process.Start(startInfo);
                ChooserForm.m_ProcessId = exeProcess.Id;
                if (chkAutoInc.Checked)
                    ChgSuffix(1);
            }
            catch (Exception e)
            {
                string sMessage = e.Message.ToString();
                MessageBox.Show(this, "An error has occured\n" + sMessage, "Oops!");
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

        #region tbFilename_TextChanged
        private void tbFilename_TextChanged(object sender, EventArgs e)
        {
            GetFNSuffix();
            CreateCommandLine();
        }
        #endregion

        #region btnInc_Click
        private void btnInc_Click(object sender, EventArgs e)
        {
            ChgSuffix(1);
        }
        #endregion

        #region btnDec_Click
        private void btnDec_Click(object sender, EventArgs e)
        {
            ChgSuffix(2);
        }
        #endregion

        #region tbSuffix_TextChanged
        private void tbSuffix_TextChanged(object sender, EventArgs e)
        {
            ChgFilenameSuffix();
            CreateCommandLine();
        }
        #endregion

        #region SetFNSuffix
        private void SetFNSuffix()
        {
            int pos = -1;
            int n = -1;
            if (tbFilename.Text.Trim().Length > 0)
            {
                string sFN = removeDiskType(tbFilename.Text, true); // remove extension as well
                if ((pos = sFN.LastIndexOf(m_sSeperator)) != -1)
                    tbSuffix.Text = sFN.Substring(pos + m_sSeperator.Length, sFN.Length - pos - m_sSeperator.Length);
            }
        }
        #endregion

        #region GetFNSuffix
        private void GetFNSuffix()
        {
            int pos = -1;
            int n = -1;
            //string sFN = Path.GetFileNameWithoutExtension(tbFilename.Text);
            string sFN = removeDiskType(tbFilename.Text, true); // remove extension as well
            string sExt = Path.GetExtension(tbFilename.Text);
            if ((pos = sFN.IndexOf(m_sSeperator)) == -1)
                return;
            String sSuffix = sFN.Substring(pos+2);
            Int32.TryParse(sSuffix, out n);
            tbSuffix.Text = n.ToString();
        }
        #endregion

        #region ChgFilenameSuffix
        private void ChgFilenameSuffix()
        {
            int pos = -1;
            int n = -1;
            string sSuffix = "";
            if (tbSuffix.Text.Trim().Length > 0)
            {
                sSuffix = tbSuffix.Text.Trim();
                if (sSuffix.Length > 0)
                    Int32.TryParse(sSuffix.Trim(), out n);
            }
            string sFN = removeDiskType(tbFilename.Text, true);  // remove extension as well
            if ((pos = sFN.LastIndexOf(m_sSeperator)) != -1)
                sFN = sFN.Substring(0, pos);
            if (n != -1)
                tbFilename.Text = sFN + m_sSeperator + n.ToString() + cbExtension.Text;
            else
                tbFilename.Text = sFN + cbExtension.Text;
        }
        #endregion

        #region ChgSuffix
        private void ChgSuffix(int direction)
        {
            int n = -1;
            int increment = 1;
            int decrement = 2;
            if (direction != increment && direction != decrement)
                return;
            if (tbSuffix.Text.Trim().Length == 0)
                tbSuffix.Text = "0";
            else
                tbSuffix.Text = tbSuffix.Text.Trim();
            Int32.TryParse(tbSuffix.Text.Trim(), out n);
            if (direction == increment)
            {
                if (n < 999)
                {
                    n++;
                    tbSuffix.Text = n.ToString();
                }
            }
            else if (direction == decrement)
            {
                if (n > 1)
                {
                    n--;
                    tbSuffix.Text = n.ToString();
                }
                else
                    tbSuffix.Text = "";
            }
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
