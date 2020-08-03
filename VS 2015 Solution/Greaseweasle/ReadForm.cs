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
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkDoubleStep", (chkDoubleStep.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "rbReadDoubleSided", (rbReadDoubleSided.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "rbReadSingleSided", (rbReadSingleSided.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkLegacySS", (chkLegacySS.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtReadLastCyl", txtReadLastCyl.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkReadLastCyl", (chkReadLastCyl.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtReadFirstCyl", txtReadFirstCyl.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkReadFirstCyl", (chkReadFirstCyl.Checked == true).ToString());
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
        }
        #endregion

        #region iniReadFile
        public void iniReadFile()
        {
            string sRet;

            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "m_sRFDFilename", "garbage").Trim())) != "garbage")
            {
                tbFilename.Text = sRet;
                SetFNSuffix();
                CreateCommandLine();           
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "rbReadDoubleSided", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                {
                    rbReadDoubleSided.Checked = true;
                    rbReadSingleSided.Enabled = true;
                }
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "rbReadSingleSided", "garbage").Trim())) != "garbage")
            {
                if ((sRet == "True" && rbReadDoubleSided.Checked))
                   rbReadSingleSided.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkLegacySS", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkLegacySS.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtReadLastCyl", "garbage").Trim())) != "garbage")
                txtReadLastCyl.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkReadLastCyl", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkReadLastCyl.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtReadFirstCyl", "garbage").Trim())) != "garbage")
                txtReadFirstCyl.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkReadFirstCyl", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkReadFirstCyl.Checked = true;
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

            // found out the controller type
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbType", "rbF7", "garbage").Trim())) != "garbage")
            {
                if (sRet == "False")
                {
                    chkDriveSelectRFD.Checked = false;
                    chkDriveSelectRFD.BackColor = Color.FromArgb(255, 182, 193);
                    txtDriveSelectRFD.BackColor = Color.FromArgb(255, 182, 193);
                }
            }

            // usb port
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbUSBPorts", "m_sUSBPort", "garbage").Trim())) != "garbage")
                m_sUSBPort = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbUSBPorts", "mnuUSBSupport", "garbage").Trim())) != "garbage")
                m_bUSBSupport = (sRet == "True");

            // windows executable
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbWindowsEXE", "mnuWindowsEXE", "garbage").Trim())) != "garbage")
                m_bWindowsEXE = (sRet == "True");
        }
        #endregion

        #region CreateCommandLine
        private void CreateCommandLine()
        {
            if (true == m_bWindowsEXE)
                txtRFDCommandLine.Text = "gw.exe read";
            else
                txtRFDCommandLine.Text = "python.exe " + ChooserForm.m_sGWscript + " read";
            if (chkDoubleStep.Checked == true)
                txtRFDCommandLine.Text += " --double-step";
            if (chkRevsPerTrack.Checked == true)
                txtRFDCommandLine.Text += " --revs=" + txtRevsPerTrack.Text;
            if (chkReadFirstCyl.Checked == true)
                txtRFDCommandLine.Text += " --scyl=" + txtReadFirstCyl.Text;
            if (chkReadLastCyl.Checked == true)
                txtRFDCommandLine.Text += " --ecyl=" + txtReadLastCyl.Text;
            if (rbReadSingleSided.Checked == true)
                txtRFDCommandLine.Text += " --single-sided";
            if (chkDriveRateRFD.Checked == true)
                txtRFDCommandLine.Text += " --rate=" + txtDriveRateRFD.Text;
            if (chkDriveRpmRFD.Checked == true)
                txtRFDCommandLine.Text += " --rpm=" + txtDriveRpmRFD.Text;
            if ((chkDriveSelectRFD.Enabled == true) && (chkDriveSelectRFD.Checked == true))
                txtRFDCommandLine.Text += " --drive " + txtDriveSelectRFD.Text;
            txtRFDCommandLine.Text += " " + "\"" + m_sReadDiskFolder + "\\" + tbFilename.Text.Trim();
            if (chkLegacySS.Checked == true)
                txtRFDCommandLine.Text += "::legacy_ss";
            txtRFDCommandLine.Text += "\"";
            if ((m_bUSBSupport == true) && (m_sUSBPort != "UNKNOWN"))
                txtRFDCommandLine.Text += " " + m_sUSBPort;
        }
        #endregion

        #region CheckedChanged
        private void chkRevsPerTrack_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkReadFirstCyl_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkReadLastCyl_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDriveSelectRFD_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void rbReadSingleSided_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReadSingleSided.Checked)
                chkLegacySS.Enabled = true;
            else
                chkLegacySS.Enabled = false;
            CreateCommandLine();
        }

        private void rbReadDoubleSided_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReadSingleSided.Checked)
                chkLegacySS.Enabled = true;
            else
                chkLegacySS.Enabled = false;
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
            CreateCommandLine();
        }

        #endregion

        #region ReadForm_Load
        private void ReadForm_Load(object sender, EventArgs e)
        {
            // read inifile
            iniReadFile();

            // initialize status label
            this.toolStripStatusLabel.Text = ChooserForm.m_sStatusLine.Trim();
            this.toolStripStatusLabel.BackColor = ChooserForm.m_StatusColor;
            this.statusStrip.BackColor = ChooserForm.m_StatusColor;

            // version options check
            if (ChooserForm.m_GWToolsVersion < (decimal)0.12)
            {
                this.chkDoubleStep.BackColor = Color.FromArgb(255, 182, 193);
                this.chkDoubleStep.Checked = false;
            }

            if (ChooserForm.m_GWToolsVersion < (decimal)0.18)
            {
                this.chkDriveRateRFD.BackColor = Color.FromArgb(255, 182, 193);
                this.chkDriveRateRFD.Checked = false;
                this.txtDriveRateRFD.BackColor = Color.FromArgb(255, 182, 193);
                this.chkDriveRpmRFD.BackColor = Color.FromArgb(255, 182, 193);
                this.chkDriveRpmRFD.Checked = false;
                this.txtDriveRpmRFD.BackColor = Color.FromArgb(255, 182, 193);
            }

            if (ChooserForm.m_GWToolsVersion < (decimal)0.20)
            {
                this.chkLegacySS.BackColor = Color.FromArgb(255, 182, 193);
                this.chkLegacySS.Checked = false;
            }

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
            openDialog.Filter = "Formats (*.HFE; *.SCP;)| *.HFE; *.SCP; | All files(*.*) | *.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                tbFilename.Text = openDialog.SafeFileName;
                m_sReadDiskFolder = Path.GetDirectoryName(openDialog.FileName);
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
                string sFN = Path.GetFileNameWithoutExtension(tbFilename.Text);
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
            string sFN = Path.GetFileNameWithoutExtension(tbFilename.Text);
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
            string sFN = Path.GetFileNameWithoutExtension(tbFilename.Text);
            string sExt = Path.GetExtension(tbFilename.Text);
            if ((pos = sFN.LastIndexOf(m_sSeperator)) != -1)
                sFN = sFN.Substring(0, pos);
            if (n != -1)
                tbFilename.Text = sFN + m_sSeperator + n.ToString() + sExt;
            else
                tbFilename.Text = sFN + sExt;
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
                if (n > 0)
                {
                    n--;
                    tbSuffix.Text = n.ToString();
                }
                else
                    tbSuffix.Text = "";
            }
        }
        #endregion
    }
}
