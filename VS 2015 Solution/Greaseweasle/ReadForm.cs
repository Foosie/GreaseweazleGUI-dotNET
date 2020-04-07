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
    public partial class ReadForm : Form
    {
        #region declarations
        private string m_sRFDFilename = "mydisk.scp";
        private string m_sReadDiskFolder = "";
        private string m_sUSBPort = "UNKNOWN";
        private bool m_bUSBSupport = false;
        private Form m_frmChooser = null;
        private const int WM_CLOSE = 0x0010;
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
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "m_sRFDFilename", m_sRFDFilename);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkDoubleStep", (chkDoubleStep.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "rbReadDoubleSided", (rbReadDoubleSided.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "rbReadSingleSided", (rbReadSingleSided.Checked == true).ToString());
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
                    chkDriveSelectRFD.Enabled = true;
                    txtDriveSelectRFD.Enabled = true;
                }
                else
                {
                    chkDriveSelectRFD.Enabled = false;
                    txtDriveSelectRFD.Enabled = false;
                }
            }

            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "m_sRFDFilename", "garbage").Trim())) != "garbage")
                m_sRFDFilename = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "rbReadDoubleSided", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbReadDoubleSided.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "rbReadSingleSided", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbReadSingleSided.Checked = true;
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

            // usb port
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbUSBPorts", "m_sUSBPort", "garbage").Trim())) != "garbage")
                m_sUSBPort = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbUSBPorts", "mnuUSBSupport", "garbage").Trim())) != "garbage")
                m_bUSBSupport = (sRet == "True");
        }
        #endregion

        #region ReadForm_Load
        private void ReadForm_Load(object sender, EventArgs e)
        {
            // read inifile
            iniReadFile();
            CreateCommandLine();
        }
        #endregion

        #region CreateCommandLine
        private void CreateCommandLine()
        {
            txtRFDCommandLine.Text = "python.exe gw.py read";
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
            if ((chkDriveSelectRFD.Enabled == true) && (chkDriveSelectRFD.Checked == true))
                txtRFDCommandLine.Text += " --drive " + txtDriveSelectRFD.Text;
            txtRFDCommandLine.Text += " " + "\"" + m_sReadDiskFolder + "\\" + m_sRFDFilename + "\"";
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
            CreateCommandLine();
        }

        private void rbReadDoubleSided_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDoubleStep_CheckedChanged(object sender, EventArgs e)
        {
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
            openDialog.Filter = "SCP Files (*.scp)|*.scp" + "|" + "All Files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                m_sRFDFilename = openDialog.SafeFileName;
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

        #region txtRevsPerTrack_TextChanged
        private void txtRevsPerTrack_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region txtReadFirstCyl_TextChanged
        private void txtReadFirstCyl_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region txtReadLastCyl_TextChanged
        private void txtReadLastCyl_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region txtDriveSelectRFD_TextChanged
        private void txtDriveSelectRFD_TextChanged(object sender, EventArgs e)
        {
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
    }
}
