// MainForm.cs
//
// Greaseweazle GUI Wrapper
//
// Copyright (c) 2019 Don Mankin <don.mankin@yahoo.com>
//
// MIT License
//
// See the file LICENSE more details, or visit <https://opensource.org/licenses/MIT>.

using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.IO.Ports;

namespace Greaseweazle
{
    public partial class MainForm : Form
    {

        #region declarations
        public static string m_sReadDisk = "Read";
        public static string m_sWriteDisk = "Write";
        public static string m_sCommandLine = "";
        public string m_sReadWrite = m_sReadDisk;
        public string m_sUSBPort = "";
        public string m_sSides = "";
        public int m_iTrackStart = 0;
        public int m_iTrackEnd = 39;
        private const int WM_CLOSE = 0x0010;
        public static string m_sIniFile = ".\\GreaseweazleGUI.ini";
        public IniFile m_Ini = new IniFile(m_sIniFile);
        private string m_sVersion = "";
        public static Form m_frmMain = null;
        public Mutex m_exclusiveMutex = null;
        private string m_sReadDiskFolder = "";
        private string m_sWriteDiskFolder = "";
        private string m_sUpdateFirmwareFolder = "";
        private string m_sPythonFolder = "";
        private string m_sPythonExeName = "python.exe";
        private string m_sPythonPreface = "python.exe gw.py";
        private int m_ProcessId = 0;
        #endregion 

        #region Mainform contructor
        public MainForm() // constructor
        {
            InitializeComponent();
            InitializeMyStuff();
        }
        #endregion

        #region InitializeMyStuff
        private void InitializeMyStuff()
        {
            // open application only once
            if (!RequestMutex())
            {
                MessageBox.Show(this, "An instance of \"GreaseweazleGUI.exe\" is already running", "Oops!");
                Icon.Dispose();
                System.Environment.Exit(1);
            }

            // get version from Project, GreaseweaselGUI Properties, Assembly Information
            m_sVersion = Application.ProductVersion;
            string[] tokens = m_sVersion.Split('.');
            m_sVersion = "v" + tokens[2] + "." + tokens[3];
            this.Text = "GreaseweazleGUI " + m_sVersion + " - Host Tools v0.8";
            string sOops = "";
            rbReadDisk.Checked = true;
            txtWTDFilename.ReadOnly = true;
            txtUFFilename.ReadOnly = true;
            btnStart.BackColor = Color.LightBlue;
            btnSetPythonFolder.Text = "[Experimental]\nPython Folder";
            btnSetPythonFolder.Enabled = false;

            m_frmMain = this;
            mnuSettings.BackColor = txtCommandLine.BackColor;

            // set working directory to executable directory
            string sExeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Directory.SetCurrentDirectory(sExeDir);

            // check for existance of gw.py
            if (!File.Exists(sExeDir + "\\gw.py"))
                sOops = "GreaseweazleGUI.exe must be in the same folder as gw.py";

            // display error
            if (sOops.Length > 0)
                System.Windows.Forms.MessageBox.Show(sOops, "Oops!");

            // read our settings
            iniReadFile();

            // set default folders
            if (m_sReadDiskFolder.Length == 0)
                m_sReadDiskFolder = sExeDir;
            if (m_sWriteDiskFolder.Length == 0)
                m_sWriteDiskFolder = sExeDir;
            if (m_sUpdateFirmwareFolder.Length == 0)
                m_sUpdateFirmwareFolder = sExeDir;

            // Get a list of serial port names.
            refreshUSBPorts();

            // check if python is included in path or manually set
            string value = System.Environment.GetEnvironmentVariable("path").ToLower();
            if (!value.Contains("python") && (m_sPythonFolder.Length == 0))
                SetPythonFolder();

            // enable or disable controls based on selected action radio button
            SetControls();

            // Create the default command line
            CreateCommandLine();
        }
        #endregion

        // ----> USB Ports

        #region refreshUSBPorts
        private void refreshUSBPorts()
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            // Display each port name to the console
            lbUSBPorts.Items.Clear();

            // now rebuild the listbox
            foreach (string port in ports)
                lbUSBPorts.Items.Add(port);

            // set selected usb port if remembered
            int iIndex = lbUSBPorts.FindString(m_sUSBPort);
            if (iIndex != -1)
                lbUSBPorts.SetSelected(iIndex, true);
            CreateCommandLine();
        }
        #endregion

        #region btnRefreshUSB_Click
        private void btnRefreshUSB_Click(object sender, EventArgs e)
        {
            refreshUSBPorts();
            CreateCommandLine();
        }
        #endregion

        #region lbUSBPorts_SelectedIndexChanged
        private void lbUSBPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUSBPorts.SelectedIndex != -1)
            {
                m_sUSBPort = lbUSBPorts.Items[lbUSBPorts.SelectedIndex].ToString();
                CreateCommandLine();
            }
        }
        #endregion

        // ----> Command Line

        #region txtCommandLine_Click
        private void txtCommandLine_Click(object sender, EventArgs e)
        {
            txtCommandLine.SelectionStart = 0;
            txtCommandLine.SelectionLength = txtCommandLine.Text.Length;
            Clipboard.SetText(txtCommandLine.Text);
        }
        #endregion

        #region txtCommandLine_DoubleClick
        private void txtCommandLine_DoubleClick(object sender, EventArgs e)
        {
            txtCommandLine.SelectionStart = 0;
            txtCommandLine.SelectionLength = txtCommandLine.Text.Length;
            Clipboard.SetText(txtCommandLine.Text);
        }
        #endregion

        #region CreateCommandLine
        private void CreateCommandLine()
        {
            m_sCommandLine = "";
            txtCommandLine.Text = m_sCommandLine;

            if ((mnuPythonFolder.Checked == true) && (m_sPythonFolder.Length > 0) && (m_sPythonExeName.Length > 0))
                m_sPythonPreface = "\"" + m_sPythonFolder + @"\" + m_sPythonExeName + "\"" + " gw.py";
            else
                m_sPythonPreface = "python.exe gw.py";


            if (rbUpdateFirmware.Checked == true)
            {
                m_sCommandLine = m_sPythonPreface + " update " + "\"" + m_sUpdateFirmwareFolder + "\\" + txtUFFilename.Text + "\"" + " " + m_sUSBPort;
                txtCommandLine.Text = m_sCommandLine;
            }
            else if (rbSetDelays.Checked == true)
            {
                if (chkDelayDriveSelect.Checked || chkDelayHeadSteps.Checked || chkDelaySeekSettle.Checked || chkDelayMotorOn.Checked || chkDelayAutoDeselect.Checked)
                {
                    m_sCommandLine = m_sPythonPreface + " delays";
                    if (chkDelayDriveSelect.Checked == true)
                        m_sCommandLine += " --select=" + txtDelayDriveSelect.Text;
                    if (chkDelayHeadSteps.Checked == true)
                        m_sCommandLine += " --step=" + txtDelayHeadSteps.Text;
                    if (chkDelaySeekSettle.Checked == true)
                        m_sCommandLine += " --settle=" + txtDelaySeekSettle.Text;
                    if (chkDelayMotorOn.Checked == true)
                        m_sCommandLine += " --motor=" + txtDelayMotorOn.Text;
                    if (chkDelayAutoDeselect.Checked == true)
                        m_sCommandLine += " --auto-off=" + txtDelayAutoDeselect.Text;
                    m_sCommandLine += " " + m_sUSBPort;
                }
                else
                    m_sCommandLine = "";
            }
            else if (rbReadDisk.Checked == true)
            {
                m_sCommandLine = m_sPythonPreface + " read";
                if (chkRevsPerTrack.Checked == true)
                    m_sCommandLine += " --revs=" + txtRevsPerTrack.Text;
                if (chkReadFirstCyl.Checked == true)
                    m_sCommandLine += " --scyl=" + txtReadFirstCyl.Text;
                if (chkReadLastCyl.Checked == true)
                    m_sCommandLine += " --ecyl=" + txtReadLastCyl.Text;
                if (rbReadSingleSided.Checked == true)
                    m_sCommandLine += " --single-sided";
                m_sCommandLine += " " + "\"" + m_sReadDiskFolder + "\\" + txtRFDFilename.Text + "\"" + " " + m_sUSBPort;

            }
            else if (rbWriteDisk.Checked == true)
            {
                m_sCommandLine = m_sPythonPreface + " write";
                if (chkWriteFirstCyl.Checked == true)
                    m_sCommandLine += " --scyl=" + txtWriteFirstCyl.Text;
                if (chkWriteLastCyl.Checked == true)
                    m_sCommandLine += " --ecyl=" + txtWriteLastCyl.Text;
                if (rbWriteSingleSided.Checked == true)
                    m_sCommandLine += " --single-sided";
                if (chkWTDAdjustSpeed.Checked == true)
                    m_sCommandLine += " --adjust-speed";
                m_sCommandLine += " " + "\"" + m_sWriteDiskFolder + "\\" + txtWTDFilename.Text + "\"" + " " + m_sUSBPort;
            }
            txtCommandLine.Text = m_sCommandLine;
        }
        #endregion

        // ----> Read from Disk

        #region rbReadDisk_CheckedChanged
        private void rbReadDisk_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReadDisk.Checked == true)
            {
                // disable all the appropriate groupbox controls
                foreach (Control ctrl in gbReadFromDisk.Controls)
                    ctrl.Enabled = true;
                foreach (Control ctrl in gbWriteToDisk.Controls)
                    ctrl.Enabled = false;
                foreach (Control ctrl in gbSetDelays.Controls)
                    ctrl.Enabled = false;
                foreach (Control ctrl in gbUpdateFirmware.Controls)
                    ctrl.Enabled = false;
                lblImageDisk.Text = "READ FROM DISK";
                CreateCommandLine();
            }
        }
        #endregion

        #region chkReadFirstCyl_CheckedChanged
        private void chkReadFirstCyl_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region chkReadLastCyl_CheckedChanged
        private void chkReadLastCyl_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region rbReadSingleSided_CheckedChanged
        private void rbReadSingleSided_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region rbReadDoubleSided_CheckedChanged
        private void rbReadDoubleSided_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region chkRevsPerTrack_CheckedChanged
        private void chkRevsPerTrack_CheckedChanged(object sender, EventArgs e)
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
                txtRFDFilename.Text = openDialog.SafeFileName;
                m_sReadDiskFolder = Path.GetDirectoryName(openDialog.FileName);
                CreateCommandLine();
            }
        }
        #endregion


        #region gbReadFromDisk_Enter
        private void gbReadFromDisk_Enter(object sender, EventArgs e)
        {
            CreateCommandLine();
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
            ValidateCyls(txtReadFirstCyl, 0);
            CreateCommandLine();
        }
        #endregion

        #region txtReadLastCyl_TextChanged
        private void txtReadLastCyl_TextChanged(object sender, EventArgs e)
        {
            ValidateCyls(txtReadLastCyl, 79);
            CreateCommandLine();
        }
        #endregion

        #region txtRFDFilename_TextChanged
        private void txtRFDFilename_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        // ----> Write to Disk

        #region rbWrite_CheckedChanged
        private void rbWrite_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWriteDisk.Checked == true)
            {
                // disable all the appropriate groupbox controls
                foreach (Control ctrl in gbReadFromDisk.Controls)
                    ctrl.Enabled = false;
                foreach (Control ctrl in gbWriteToDisk.Controls)
                    ctrl.Enabled = true;
                foreach (Control ctrl in gbSetDelays.Controls)
                    ctrl.Enabled = false;
                foreach (Control ctrl in gbUpdateFirmware.Controls)
                    ctrl.Enabled = false;
                lblImageDisk.Text = "WRITE TO DISK";
                CreateCommandLine();
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
            openDialog.Filter = "SCP Files (*.scp)|*.scp" + "|" + "All Files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                txtWTDFilename.Text = openDialog.SafeFileName;
                m_sWriteDiskFolder = Path.GetDirectoryName(openDialog.FileName);
                CreateCommandLine();
            }
        }
        #endregion

        #region chkWTDAdjustSpeed_CheckedChanged
        private void chkWTDAdjustSpeed_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region chkWriteFirstCyl_CheckedChanged
        private void chkWriteFirstCyl_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region chkWriteLastCyl_CheckedChanged
        private void chkWriteLastCyl_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region rbWriteSingleSided_CheckedChanged
        private void rbWriteSingleSided_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region rbWriteDoubleSided_CheckedChanged
        private void rbWriteDoubleSided_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region txtWriteFirstCyl_TextChanged
        private void txtWriteFirstCyl_TextChanged(object sender, EventArgs e)
        {
            ValidateCyls(txtWriteFirstCyl, 0);
            CreateCommandLine();
        }
        #endregion

        #region txtWriteLastCyl_TextChanged
        private void txtWriteLastCyl_TextChanged(object sender, EventArgs e)
        {
            ValidateCyls(txtWriteLastCyl, 79);
            CreateCommandLine();
        }
        #endregion

        #region txtWTDFilename_TextChanged
        private void txtWTDFilename_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        // ----> Update Firmware

        #region btnSelectUpdateFile_Click
        private void btnSelectUpdateFile_Click(object sender, EventArgs e)
        {
            // select file and folder where file is to be read from
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.RestoreDirectory = true; // make sure directory is set to executable path
            openDialog.InitialDirectory = m_sUpdateFirmwareFolder;
            openDialog.Multiselect = false;
            openDialog.Title = "Select an update file";
            openDialog.Filter = "UPD Files (*.upd)|*.upd" + "|" + "All Files (*.*)|*.*"; ;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                txtUFFilename.Text = openDialog.SafeFileName;
                m_sUpdateFirmwareFolder = Path.GetDirectoryName(openDialog.FileName);
                CreateCommandLine();
            }
        }
        #endregion

        #region rbUpdateFirmware_CheckedChanged
        private void rbUpdateFirmware_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUpdateFirmware.Checked == true)
            {
                // disable all the appropriate groupbox controls
                foreach (Control ctrl in gbReadFromDisk.Controls)
                    ctrl.Enabled = false;
                foreach (Control ctrl in gbWriteToDisk.Controls)
                    ctrl.Enabled = false;
                foreach (Control ctrl in gbSetDelays.Controls)
                    ctrl.Enabled = false;
                foreach (Control ctrl in gbUpdateFirmware.Controls)
                    ctrl.Enabled = true;
                lblImageDisk.Text = "UPDATE FIRMWARE";
                CreateCommandLine();
            }
        }
        #endregion

        // ---->  Delays

        #region chkDelayHeadSteps_CheckedChanged5
        private void chkDelayHeadSteps_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region chkDelayDriveSelect_CheckedChanged
        private void chkDelayDriveSelect_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region chkDelaySeekSettle_CheckedChanged
        private void chkDelaySeekSettle_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region chkDelayMotorOn_CheckedChanged
        private void chkDelayMotorOn_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region chkDelayAutoDeselect_CheckedChanged
        private void chkDelayAutoDeselect_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
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

        #region rbSetDelays_CheckedChanged
        private void rbSetDelays_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSetDelays.Checked == true)
            {
                // disable all the appropriate groupbox controls
                foreach (Control ctrl in gbReadFromDisk.Controls)
                    ctrl.Enabled = false;
                foreach (Control ctrl in gbWriteToDisk.Controls)
                    ctrl.Enabled = false;
                foreach (Control ctrl in gbSetDelays.Controls)
                    ctrl.Enabled = true;
                foreach (Control ctrl in gbUpdateFirmware.Controls)
                    ctrl.Enabled = false;
                lblImageDisk.Text = "SET DELAYS";
                CreateCommandLine();
            }
        }
        #endregion

        #region txtDelayDriveSelect_TextChanged
        private void txtDelayDriveSelect_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region txtDelayHeadSteps_TextChanged
        private void txtDelayHeadSteps_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region txtDelaySeekSettle_TextChanged
        private void txtDelaySeekSettle_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region txtDelayMotorOn_TextChanged
        private void txtDelayMotorOn_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        #region txtDelayAutoDeselect_TextChanged
        private void txtDelayAutoDeselect_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }
        #endregion

        // ----> Misc

        #region btnStart_Click
        private void btnStart_Click(object sender, EventArgs e) // starts up command console invoking python script
        {
            bool bError = false;

            // only allow one instance at a time
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                if (theprocess.Id > 0)
                {
                    if (m_ProcessId == theprocess.Id)
                    {
                        System.Windows.Forms.MessageBox.Show("You must first close the previous Greaseweazle command console", "Oops!");
                        return;
                    }
                }
            }

            // what no command line arguments?
            if ((m_sCommandLine.Length == 0) && (rbSetDelays.Checked == true))
            {
                bError = true;
                System.Windows.Forms.MessageBox.Show("You must select delay options first!", "Oops!");
            }

            if (lbUSBPorts.SelectedIndex == -1)
            {
                bError = true;
                System.Windows.Forms.MessageBox.Show("You must select a USB port first!", "Oops!");
            }

            // good to go?
            if (bError == false)
            {
                // launch the process
                LaunchPython();
            }
        }
        #endregion

        #region btnSetPythonFolder_Click
        private void btnSetPythonFolder_Click(object sender, EventArgs e)
        {
            SetPythonFolder();
        }
        #endregion

        #region aboutToolStripMenuItem_Click
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form m_frmAbout = new AboutForm();
            m_frmAbout.ShowDialog(m_frmMain);
        }
        #endregion

        #region mnuPythonFolder_Click
        private void mnuPythonFolder_Click(object sender, EventArgs e)
        {
            if (mnuPythonFolder.Checked != true)
                mnuPythonFolder.Checked = true;
            else
                mnuPythonFolder.Checked = false;

        }
        #endregion

        #region mnuPythonFolder_CheckChanged
        private void mnuPythonFolder_CheckChanged(object sender, EventArgs e)
        {
            if (mnuPythonFolder.Checked == true)
                btnSetPythonFolder.Enabled = true;
            else
                btnSetPythonFolder.Enabled = false;
            CreateCommandLine();
        }
        #endregion

        #region SetPythonFolder
        private void SetPythonFolder()
        {
            // select file and folder where file is to be read from
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.RestoreDirectory = true; // make sure directory is set to executable path
            openDialog.InitialDirectory = m_sPythonFolder;
            openDialog.Multiselect = false;
            openDialog.Title = "Select Python Executable";
            openDialog.Filter = "Python Files (*.exe)|*.exe";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                m_sPythonExeName = openDialog.SafeFileName;
                m_sPythonFolder = Path.GetDirectoryName(openDialog.FileName);
                CreateCommandLine();
            }
        }
        #endregion

        #region SetControls
        private void SetControls()
        {
            RadioButton radioBtn = this.gbAction.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                // disable all the appropriate groupbox controls
                switch (radioBtn.Name)
                {
                    case "rbUpdateFirmware":
                        foreach (Control ctrl in gbReadFromDisk.Controls)
                            ctrl.Enabled = false;
                        foreach (Control ctrl in gbWriteToDisk.Controls)
                            ctrl.Enabled = false;
                        foreach (Control ctrl in gbSetDelays.Controls)
                            ctrl.Enabled = false;
                        foreach (Control ctrl in gbUpdateFirmware.Controls)
                            ctrl.Enabled = true;
                        lblImageDisk.Text = "UPDATE FIRMWARE";
                        break;
                    case "rbSetDelays":
                        foreach (Control ctrl in gbReadFromDisk.Controls)
                            ctrl.Enabled = false;
                        foreach (Control ctrl in gbWriteToDisk.Controls)
                            ctrl.Enabled = false;
                        foreach (Control ctrl in gbSetDelays.Controls)
                            ctrl.Enabled = true;
                        foreach (Control ctrl in gbUpdateFirmware.Controls)
                            ctrl.Enabled = false;
                        lblImageDisk.Text = "SET DELAYS";
                        break;
                    case "rbReadDisk":
                        foreach (Control ctrl in gbReadFromDisk.Controls)
                            ctrl.Enabled = true;
                        foreach (Control ctrl in gbWriteToDisk.Controls)
                            ctrl.Enabled = false;
                        foreach (Control ctrl in gbSetDelays.Controls)
                            ctrl.Enabled = false;
                        foreach (Control ctrl in gbUpdateFirmware.Controls)
                            ctrl.Enabled = false;
                        lblImageDisk.Text = "READ FROM DISK";
                        break;
                    case "rbWriteDisk":
                        foreach (Control ctrl in gbReadFromDisk.Controls)
                            ctrl.Enabled = false;
                        foreach (Control ctrl in gbWriteToDisk.Controls)
                            ctrl.Enabled = true;
                        foreach (Control ctrl in gbSetDelays.Controls)
                            ctrl.Enabled = false;
                        foreach (Control ctrl in gbUpdateFirmware.Controls)
                            ctrl.Enabled = false;
                        lblImageDisk.Text = "WRITE TO DISK";
                        break;
                }
            }
        }
        #endregion

        #region DumpControlsToDisk
        private void DumpControlsToDisk()
        {
            if (File.Exists(@".\controls.txt"))
                File.Delete(@".\controls.txt");
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@".\controls.txt", true))
            {
                file.WriteLine("[" + gbAction.Name.ToString() + "]");
                foreach (Control ctrl in gbAction.Controls)
                    file.WriteLine(ctrl.Name.ToString());
                file.WriteLine("[" + gbReadFromDisk.Name.ToString() + "]");
                foreach (Control ctrl in gbReadFromDisk.Controls)
                    file.WriteLine(ctrl.Name.ToString());
                file.WriteLine("[" + gbWriteToDisk.Name.ToString() + "]");
                foreach (Control ctrl in gbWriteToDisk.Controls)
                    file.WriteLine(ctrl.Name.ToString());
                file.WriteLine("[" + gbSetDelays.Name.ToString() + "]");
                foreach (Control ctrl in gbSetDelays.Controls)
                    file.WriteLine(ctrl.Name.ToString());
                file.WriteLine("[" + gbUpdateFirmware.Name.ToString() + "]");
                foreach (Control ctrl in gbUpdateFirmware.Controls)
                    file.WriteLine(ctrl.Name.ToString());
                file.WriteLine("[" + gbUSBPorts.Name.ToString() + "]");
                foreach (Control ctrl in gbUSBPorts.Controls)
                    file.WriteLine(ctrl.Name.ToString());
                file.WriteLine("[" + gbCommandLine.Name.ToString() + "]");
                foreach (Control ctrl in gbCommandLine.Controls)
                    file.WriteLine(ctrl.Name.ToString());
                file.WriteLine("[" + gbLaunch.Name.ToString() + "]");
                foreach (Control ctrl in gbLaunch.Controls)
                    file.WriteLine(ctrl.Name.ToString());
            }
        }
        #endregion

        #region LaunchPython
        private void LaunchPython()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "C:\\WINDOWS\\SYSTEM32\\cmd.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "/K " + "\"" + m_sCommandLine + "\"";
            try
            {
                Process exeProcess = Process.Start(startInfo);
                m_ProcessId = exeProcess.Id;
            }
            catch (Exception e)
            {
                string sMessage = e.Message.ToString();
                MessageBox.Show(this, "An error has occured\n" + sMessage, "Oops!");
            }
        }
        #endregion

        #region iniWriteFile
        public void iniWriteFile()
        {
            // get rid of previous ini file version
            if (File.Exists(m_Ini.path))
            {
                if ((m_Ini.IniReadValue("GreaseweazleGUI", "TargetDir", "garbage").Trim()) != "garbage")
                    File.Delete(m_Ini.path);
            }

            // action
            m_Ini.IniWriteValue("gbAction", "rbReadDisk", (rbReadDisk.Checked == true).ToString());
            m_Ini.IniWriteValue("gbAction", "rbWriteDisk", (rbWriteDisk.Checked == true).ToString());
            m_Ini.IniWriteValue("gbAction", "rbSetDelays", (rbSetDelays.Checked == true).ToString());
            m_Ini.IniWriteValue("gbAction", "rbUpdateFirmware", (rbUpdateFirmware.Checked == true).ToString());

            // read disk
            m_Ini.IniWriteValue("gbReadFromDisk", "txtRFDFilename", txtRFDFilename.Text);
            m_Ini.IniWriteValue("gbReadFromDisk", "rbReadDoubleSided", (rbReadDoubleSided.Checked == true).ToString());
            m_Ini.IniWriteValue("gbReadFromDisk", "rbReadSingleSided", (rbReadSingleSided.Checked == true).ToString());
            m_Ini.IniWriteValue("gbReadFromDisk", "txtReadLastCyl", txtReadLastCyl.Text);
            m_Ini.IniWriteValue("gbReadFromDisk", "chkReadLastCyl", (chkReadLastCyl.Checked == true).ToString());
            m_Ini.IniWriteValue("gbReadFromDisk", "txtReadFirstCyl", txtReadFirstCyl.Text);
            m_Ini.IniWriteValue("gbReadFromDisk", "chkReadFirstCyl", (chkReadFirstCyl.Checked == true).ToString());
            m_Ini.IniWriteValue("gbReadFromDisk", "txtRevsPerTrack", txtRevsPerTrack.Text);
            m_Ini.IniWriteValue("gbReadFromDisk", "chkRevsPerTrack", (chkRevsPerTrack.Checked == true).ToString());
            m_Ini.IniWriteValue("gbReadFromDisk", "m_sReadDiskFolder", m_sReadDiskFolder);

            // write disk
            m_Ini.IniWriteValue("gbWriteToDisk", "txtWTDFilename", txtWTDFilename.Text);
            m_Ini.IniWriteValue("gbWriteToDisk", "chkWTDAdjustSpeed", (chkWTDAdjustSpeed.Checked == true).ToString());
            m_Ini.IniWriteValue("gbWriteToDisk", "rbWriteDoubleSided", (rbWriteDoubleSided.Checked == true).ToString());
            m_Ini.IniWriteValue("gbWriteToDisk", "rbWriteSingleSided", (rbWriteSingleSided.Checked == true).ToString());
            m_Ini.IniWriteValue("gbWriteToDisk", "txtWriteLastCyl", txtWriteLastCyl.Text);
            m_Ini.IniWriteValue("gbWriteToDisk", "chkWriteLastCyl", (chkWriteLastCyl.Checked == true).ToString());
            m_Ini.IniWriteValue("gbWriteToDisk", "txtWriteFirstCyl", txtWriteFirstCyl.Text);
            m_Ini.IniWriteValue("gbWriteToDisk", "chkWriteFirstCyl", (chkWriteFirstCyl.Checked == true).ToString());
            m_Ini.IniWriteValue("gbWriteToDisk", "m_sWriteDiskFolder", m_sWriteDiskFolder);

            // set delays
            m_Ini.IniWriteValue("gbSetDelays", "txtDelayAutoDeselect", txtDelayAutoDeselect.Text);
            m_Ini.IniWriteValue("gbSetDelays", "chkDelayAutoDeselect", (chkDelayAutoDeselect.Checked == true).ToString());
            m_Ini.IniWriteValue("gbSetDelays", "txtDelayMotorOn", txtDelayMotorOn.Text);
            m_Ini.IniWriteValue("gbSetDelays", "chkDelayMotorOn", (chkDelayMotorOn.Checked == true).ToString());
            m_Ini.IniWriteValue("gbSetDelays", "txtDelaySeekSettle", txtDelaySeekSettle.Text);
            m_Ini.IniWriteValue("gbSetDelays", "chkDelaySeekSettle", (chkDelaySeekSettle.Checked == true).ToString());
            m_Ini.IniWriteValue("gbSetDelays", "txtDelayDriveSelect", txtDelayDriveSelect.Text);
            m_Ini.IniWriteValue("gbSetDelays", "chkDelayDriveSelect", (chkDelayDriveSelect.Checked == true).ToString());
            m_Ini.IniWriteValue("gbSetDelays", "txtDelayHeadSteps", txtDelayHeadSteps.Text);
            m_Ini.IniWriteValue("gbSetDelays", "chkDelayHeadSteps", (chkDelayHeadSteps.Checked == true).ToString());

            // update firmware
            m_Ini.IniWriteValue("gbUpdateFirmware", "txtUFFilename", txtUFFilename.Text);
            m_Ini.IniWriteValue("gbUpdateFirmware", "m_sUpdateFirmwareFolder", m_sUpdateFirmwareFolder);

            // usb port
            m_Ini.IniWriteValue("gbUSBPorts", "m_sUSBPort", m_sUSBPort);

            // CommandLine
            m_Ini.IniWriteValue("gbCommandLine", "txtCommandLine", txtCommandLine.Text);
            m_Ini.IniWriteValue("gbCommandLine", "m_sPythonFolder", m_sPythonFolder);
            m_Ini.IniWriteValue("gbCommandLine", "m_sPythonExeName", m_sPythonExeName);
            m_Ini.IniWriteValue("gbCommandLine", "mnuPythonFolder", (mnuPythonFolder.Checked == true).ToString());
        }
        #endregion

        #region iniReadFile
        public void iniReadFile()
        {
            string sRet;

            // get rid of previous ini file version
            if (File.Exists(m_Ini.path))
            {
                if ((m_Ini.IniReadValue("GreaseweazleGUI", "TargetDir", "garbage").Trim()) != "garbage")
                    File.Delete(m_Ini.path);
            }

            // action
            if ((sRet = (m_Ini.IniReadValue("gbAction", "rbReadDisk", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbReadDisk.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbAction", "rbWriteDisk", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbWriteDisk.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbAction", "rbSetDelays", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbSetDelays.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbAction", "rbUpdateFirmware", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbUpdateFirmware.Checked = true;
            }


            // read disk
            if ((sRet = (m_Ini.IniReadValue("gbReadFromDisk", "txtRFDFilename", "garbage").Trim())) != "garbage")
                txtRFDFilename.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbReadFromDisk", "rbReadDoubleSided", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbReadDoubleSided.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbReadFromDisk", "rbReadSingleSided", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbReadSingleSided.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbReadFromDisk", "txtReadLastCyl", "garbage").Trim())) != "garbage")
                txtReadLastCyl.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbReadFromDisk", "chkReadLastCyl", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkReadLastCyl.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbReadFromDisk", "txtReadFirstCyl", "garbage").Trim())) != "garbage")
                txtReadFirstCyl.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbReadFromDisk", "chkReadFirstCyl", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkReadFirstCyl.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbReadFromDisk", "txtRevsPerTrack", "garbage").Trim())) != "garbage")
                txtRevsPerTrack.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbReadFromDisk", "chkRevsPerTrack", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkRevsPerTrack.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbReadFromDisk", "m_sReadDiskFolder", "garbage").Trim())) != "garbage")
                m_sReadDiskFolder = sRet;

            // write disk
            if ((sRet = (m_Ini.IniReadValue("gbWriteToDisk", "txtWTDFilename", "garbage").Trim())) != "garbage")
                txtWTDFilename.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbWriteToDisk", "txtWTDFilename", "garbage").Trim())) != "garbage")
                txtWTDFilename.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbWriteToDisk", "chkWTDAdjustSpeed", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkWTDAdjustSpeed.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbWriteToDisk", "rbWriteDoubleSided", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbWriteDoubleSided.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbWriteToDisk", "rbWriteSingleSided", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbWriteSingleSided.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbWriteToDisk", "txtWriteLastCyl", "garbage").Trim())) != "garbage")
                txtWriteLastCyl.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbWriteToDisk", "chkWriteLastCyl", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkWriteLastCyl.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbWriteToDisk", "txtWriteFirstCyl", "garbage").Trim())) != "garbage")
                txtWriteFirstCyl.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbWriteToDisk", "chkWriteFirstCyl", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkWriteFirstCyl.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbWriteToDisk", "m_sWriteDiskFolder", "garbage").Trim())) != "garbage")
                m_sWriteDiskFolder = sRet;

            // set delays
            if ((sRet = (m_Ini.IniReadValue("gbSetDelays", "txtDelayAutoDeselect", "garbage").Trim())) != "garbage")
                txtDelayAutoDeselect.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbSetDelays", "chkDelayAutoDeselect", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDelayAutoDeselect.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbSetDelays", "txtDelayMotorOn", "garbage").Trim())) != "garbage")
                txtDelayMotorOn.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbSetDelays", "chkDelayMotorOn", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDelayMotorOn.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbSetDelays", "txtDelaySeekSettle", "garbage").Trim())) != "garbage")
                txtDelaySeekSettle.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbSetDelays", "chkDelaySeekSettle", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDelaySeekSettle.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbSetDelays", "txtDelayDriveSelect", "garbage").Trim())) != "garbage")
                txtDelayDriveSelect.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbSetDelays", "chkDelayDriveSelect", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDelayDriveSelect.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbSetDelays", "txtDelayHeadSteps", "garbage").Trim())) != "garbage")
                txtDelayHeadSteps.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbSetDelays", "chkDelayHeadSteps", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkDelayHeadSteps.Checked = true;
            }

            // update firmware
            if ((sRet = (m_Ini.IniReadValue("gbUpdateFirmware", "txtUFFilename", "garbage").Trim())) != "garbage")
                txtUFFilename.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbUpdateFirmware", "m_sUpdateFirmwareFolder", "garbage").Trim())) != "garbage")
                m_sUpdateFirmwareFolder = sRet;

            // usb port
            if ((sRet = (m_Ini.IniReadValue("gbUSBPorts", "m_sUSBPort", "garbage").Trim())) != "garbage")
                m_sUSBPort = sRet;

            // CommandLine
            if ((sRet = (m_Ini.IniReadValue("gbCommandLine", "txtCommandLine", "garbage").Trim())) != "garbage")
                txtCommandLine.Text = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbCommandLine", "m_sPythonFolder", "garbage").Trim())) != "garbage")
                m_sPythonFolder = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbCommandLine", "m_sPythonExeName", "garbage").Trim())) != "garbage")
                m_sPythonExeName = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbCommandLine", "mnuPythonFolder", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    mnuPythonFolder.Checked = true;
            }
        }
        #endregion

        #region RequestMutex
        public bool RequestMutex()
        {
            // open mutex exclusively
            try
            {
                // make sure we were only called once
                bool requestInitialOwnership = true;
                bool mutexWasCreated;
                m_exclusiveMutex = new Mutex(requestInitialOwnership, "GreaseweazleMutex", out mutexWasCreated);
                return mutexWasCreated;
            }

            catch (Exception e)
            {
                Console.WriteLine("The following Exception reported: " + e.ToString());
                while (e.InnerException != null)
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("The following InnerException reported: " + e.InnerException.ToString());
                    e = e.InnerException;
                }
            }
            return false;
        }
        #endregion

        #region ValidateUpperCyls
        private void ValidateCyls(TextBox tb, int iDefault)
        {
            try
            {
                int m = Int32.Parse(tb.Text);
                if ((m < 0) || (m > 84))
                {
                    tb.Text = iDefault.ToString();
                    tb.SelectAll();
                    tb.Focus();
                }
            }
            catch (Exception ex)
            {
                tb.Text = iDefault.ToString();
                tb.SelectAll();
                tb.Focus();
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

                // release mutex
                if (null != m_exclusiveMutex)
                    m_exclusiveMutex.Close();
            }
            base.WndProc(ref m);
        }

        #endregion

    }
}

