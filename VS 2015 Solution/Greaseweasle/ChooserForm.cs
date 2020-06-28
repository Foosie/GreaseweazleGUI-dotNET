// ChooserForm.cs
//
// Greaseweazle GUI Wrapper
//
// Copyright (c) 2019 Don Mankin <don.mankin@yahoo.com>
//
// MIT License
//
// See the file LICENSE for more details, or visit <https://opensource.org/licenses/MIT>.

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
    public partial class ChooserForm : Form
    {
        #region declarations
        public static Form m_frmChooser = null;
        private Form m_frmRead = null;
        private Form m_frmWrite = null;
        private Form m_frmDelays = null;
        private Form m_frmUpdate = null;
        private Form m_frmPin = null;
        private Form m_frmReset = null;
        private Form m_frmErase = null;
        private Form m_frmBandwidth = null;
        private Form m_frmInfo = null;
        public string sExeDir = "";
        public string m_action = "read";
        public const int WM_CLOSE = 0x0010;
        public static Boolean m_bF7Type = false;
        public static Boolean m_bWindowsEXE = false;
        public static string m_sGWscript = "gw.py";
        public static string m_sUSBPort = "UNKNOWN";
        public static string m_sIniFile = ".\\GreaseweazleGUI.ini";
        public static IniFile m_Ini = null;
        public string m_sVersion = "";
        public Mutex m_exclusiveMutex = null;
        public static int m_ProcessId = 0;
        private string m_sReadDiskFolder = "";
        private string m_sWriteDiskFolder = "";
        private string m_sUpdateFirmwareFolder = "";
        private static string m_sGWVersionMajor = "0";
        private static string m_sGWVersionMinor = "00";
        private static string m_sGUISupportedVersionMajor = "0";
        private static string m_sGUISupportedVersionMinor = "19";
        private static decimal m_GUIToolsVersion = decimal.Parse(m_sGUISupportedVersionMajor + "." + m_sGUISupportedVersionMinor);
        public static decimal m_GWToolsVersion = decimal.Parse(m_sGWVersionMajor + "." + m_sGWVersionMinor);
        public static string m_sStatusLine = "";
        public static Color m_StatusColor = Color.FromArgb(173, 255, 47); // green ok
        #endregion

        #region ChooserForm
        public ChooserForm()
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

            // create our forms in advance
            m_frmRead = new ReadForm(this);
            m_frmWrite = new WriteForm(this);
            m_frmDelays = new DelaysForm(this);
            m_frmUpdate = new UpdateForm(this);
            m_frmPin = new PinForm(this);
            m_frmReset = new ResetForm(this);
            m_frmErase = new EraseForm(this);
            m_frmBandwidth = new BandwidthForm(this);
            m_frmInfo = new InfoForm(this);

            // get version from Project, GreaseweaselGUI Properties, Assembly Information
            m_sVersion = Application.ProductVersion;
            string[] tokens = m_sVersion.Split('.');
            m_sVersion = "v" + tokens[2] + "." + tokens[3];
            //this.Text = "GUI " + m_sVersion + " - Host Tools v0.19";
            this.Text = "GUI " + m_sVersion + " - Host Tools v" + m_sGUISupportedVersionMajor + "." + m_sGUISupportedVersionMinor;

            // initialize some stuff
            m_Ini = new IniFile(m_sIniFile);
            rbReadDisk.Checked = true;
            m_frmChooser = this;
            menuStrip1.BackColor = mnuSettings.BackColor;

            // set working directory to executable directory
            sExeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Directory.SetCurrentDirectory(sExeDir);

            // check for existance of gw.py
            if (!File.Exists(sExeDir + "\\gw.py") && !File.Exists(sExeDir + "\\gw") && !File.Exists(sExeDir + "\\gw.exe"))
                System.Windows.Forms.MessageBox.Show("GreaseweazleGUI.exe must be moved to same folder as the controllers CURRENT firmware 'Host Tools' support files were extracted.", "Oops!");
            else
            {
                if (chkVersions(sExeDir))
                {
                    m_GWToolsVersion = decimal.Parse(m_sGWVersionMajor + "." + m_sGWVersionMinor);
                    string sHTVer = "Host Tools v" + m_sGWVersionMajor + "." + m_sGWVersionMinor;
                    if (m_GWToolsVersion == m_GUIToolsVersion)
                    {
                        m_sStatusLine = "        GUI supports all current options in " + sHTVer;
                        toolStripStatusLabel.Text = m_sStatusLine;
                        toolStripStatusLabel.BackColor = Color.FromArgb(173, 255, 47);
                        this.statusStrip.BackColor = ChooserForm.m_StatusColor;
                    }
                    else
                    {                  
                        m_StatusColor = Color.FromArgb(255, 182, 193);
                        toolStripStatusLabel.BackColor = m_StatusColor;
                        this.statusStrip.BackColor = ChooserForm.m_StatusColor;
                        if (m_GWToolsVersion < m_GUIToolsVersion)
                            m_sStatusLine = "    " + sHTVer + " doesn't support all options in the GUI";
                        else
                            m_sStatusLine = "      GUI will not support newer options in " + sHTVer;
                        toolStripStatusLabel.Text = m_sStatusLine;
                    }        
                } else
                {
                    m_sStatusLine = "          GUI cannot locate the Greaseweazle version file!            ";
                    toolStripStatusLabel.Text = m_sStatusLine;
                    m_StatusColor = Color.FromArgb(255, 182, 193);
                    toolStripStatusLabel.BackColor = m_StatusColor;
                }

                // version options check
                if (ChooserForm.m_GWToolsVersion < (decimal)0.06)
                    this.rbSetDelays.BackColor = Color.FromArgb(255, 182, 193);

                if (ChooserForm.m_GWToolsVersion < (decimal)0.12)
                {
                    this.rbPin.BackColor = Color.FromArgb(255, 182, 193);
                    this.rbReset.BackColor = Color.FromArgb(255, 182, 193);
                }
                if (ChooserForm.m_GWToolsVersion < (decimal)0.14)
                {
                    this.rbEraseDisk.BackColor = Color.FromArgb(255, 182, 193);
                    this.rbBandwidth.BackColor = Color.FromArgb(255, 182, 193);
                }
                if (ChooserForm.m_GWToolsVersion < (decimal)0.18)
                    this.rbInfo.BackColor = Color.FromArgb(255, 182, 193);
            }

            // determine which way to invoke the script
            // this is overwridden if the user selects exe in settings
            if (File.Exists(sExeDir + "\\gw"))
                m_sGWscript = "gw";
            else m_sGWscript = "gw.py";

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
        }
        #endregion

        #region chkVersions
        public bool chkVersions(string sExeDir)
        {
            bool b1 = false;
            bool b2 = false;

            string fname = sExeDir + "\\scripts\\greaseweazle\\version.py";
            if (File.Exists(fname))
            {
                string[] lines = System.IO.File.ReadAllLines(@fname);
                foreach (string line in lines)
                {
                    string[] values = line.Split('=');
                    if (values[0].Trim().ToLower() == "major")
                    {
                        b1 = true;
                        m_sGWVersionMajor = values[1].Trim();
                    }
                    else
                    {
                        if (values[0].Trim().ToLower() == "minor")
                        {
                            b2 = true;
                            m_sGWVersionMinor = values[1].Trim();
                        }
                    }
                }

            }
            if (b1 && b2)
                return true;
            else
            {
                // stub in correct version number so everything is enabled
                // m_GWToolsVersion = decimal.Parse(m_sGUISupportedVersionMajor + "." + m_sGUISupportedVersionMinor);
                return false;
            }
        }
        #endregion 

        #region iniReadFile
        public void iniReadFile()
        {
            string sRet;

            // get rid of previous ini file version
            if (File.Exists(m_Ini.path))
            {
                if ((m_Ini.IniReadValue("gbCommandLine", "m_sPythonFolder", "garbage").Trim()) != "garbage")
                {
                    // delete the old format ini file if it exists
                    File.Delete(m_Ini.path);

                    // disable usb port support
                    m_Ini.IniWriteValue("gbUSBPorts", "mnuUSBSupport", "False");
                    foreach (Control ctrl in gbUSBPorts.Controls)
                        ctrl.Enabled = false;
                    mnuUSBSupport.Checked = false;
                }
            }
            else
            {
                // inifile does not exist, disable usb suport the first run
                m_Ini.IniWriteValue("gbUSBPorts", "mnuUSBSupport", "False");
                foreach (Control ctrl in gbUSBPorts.Controls)
                    ctrl.Enabled = false;
                mnuUSBSupport.Checked = false;
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
            if ((sRet = (m_Ini.IniReadValue("gbAction", "rbEraseDisk", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbEraseDisk.Checked = true;
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
            if ((sRet = (m_Ini.IniReadValue("gbAction", "rbPin", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbPin.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbAction", "rbReset", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbReset.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbAction", "rbBandwidth", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbBandwidth.Checked = true;
            }

            if ((sRet = (m_Ini.IniReadValue("gbAction", "rbInfo", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbInfo.Checked = true;
            }

            // type
            if ((sRet = (m_Ini.IniReadValue("gbType", "rbF1", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbF1.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbType", "rbF7", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbF7.Checked = true;
            }

            // usb port
            if ((sRet = (m_Ini.IniReadValue("gbUSBPorts", "m_sUSBPort", "garbage").Trim())) != "garbage")
                m_sUSBPort = sRet;
            if ((sRet = (m_Ini.IniReadValue("gbUSBPorts", "mnuUSBSupport", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                {
                    // enable all the usb groupbox controls
                    foreach (Control ctrl in gbUSBPorts.Controls)
                        ctrl.Enabled = true;

                    // set selected usb port if remembered
                    if (m_sUSBPort != "UNKNOWN")
                    {
                        int iIndex = lbUSBPorts.FindString(m_sUSBPort);
                        if ((m_sUSBPort.Length > 0) && (iIndex != -1))
                            lbUSBPorts.SetSelected(iIndex, true);
                    }
                    mnuUSBSupport.Checked = true;
                }
                else
                {
                    // disable all the usb groupbox controls
                    foreach (Control ctrl in gbUSBPorts.Controls)
                        ctrl.Enabled = false;
                    mnuUSBSupport.Checked = false;
                }
            }

            // Windows Executable
            if ((sRet = (m_Ini.IniReadValue("gbWindowsEXE", "mnuWindowsEXE", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                {
                    mnuWindowsEXE.Checked = true;
                    m_bWindowsEXE = true;
                }
                else
                {
                    mnuWindowsEXE.Checked = false;
                    m_bWindowsEXE = false;
                }
            }
        }
        #endregion

        #region iniWriteFile
        public void iniWriteFile()
        {
            // action
            m_Ini.IniWriteValue("gbAction", "rbReadDisk", (rbReadDisk.Checked == true).ToString());
            m_Ini.IniWriteValue("gbAction", "rbWriteDisk", (rbWriteDisk.Checked == true).ToString());
            m_Ini.IniWriteValue("gbAction", "rbEraseDisk", (rbEraseDisk.Checked == true).ToString());
            m_Ini.IniWriteValue("gbAction", "rbSetDelays", (rbSetDelays.Checked == true).ToString());
            m_Ini.IniWriteValue("gbAction", "rbUpdateFirmware", (rbUpdateFirmware.Checked == true).ToString());
            m_Ini.IniWriteValue("gbAction", "rbPin", (rbPin.Checked == true).ToString());
            m_Ini.IniWriteValue("gbAction", "rbReset", (rbReset.Checked == true).ToString());
            m_Ini.IniWriteValue("gbAction", "rbBandwidth", (rbBandwidth.Checked == true).ToString());
            m_Ini.IniWriteValue("gbAction", "rbInfo", (rbInfo.Checked == true).ToString());

            // type
            m_Ini.IniWriteValue("gbType", "rbF1", (rbF1.Checked == true).ToString());
            m_Ini.IniWriteValue("gbType", "rbF7", (rbF7.Checked == true).ToString());

            // usb port
            m_Ini.IniWriteValue("gbUSBPorts", "mnuUSBSupport", (mnuUSBSupport.Checked == true).ToString());
            m_Ini.IniWriteValue("gbUSBPorts", "m_sUSBPort", m_sUSBPort);

            // windows executable
            m_Ini.IniWriteValue("gbWindowsEXE", "mnuWindowsEXE", (mnuWindowsEXE.Checked == true).ToString());
        }
        #endregion

        #region refreshUSBPorts
        private void refreshUSBPorts()
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            // clear port list
            lbUSBPorts.Items.Clear();

            // now rebuild the listbox
            foreach (string port in ports)
                lbUSBPorts.Items.Add(port);

            // set selected usb port if remembered
            int iIndex = lbUSBPorts.FindString(m_sUSBPort);
            if ((mnuUSBSupport.Checked == true) && (m_sUSBPort.Length > 0) && (iIndex != -1))
                lbUSBPorts.SetSelected(iIndex, true);
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

        #region WndProc
        protected override void WndProc(ref Message m) // capture close message so we can save our settings
        {
            if (m.Msg == WM_CLOSE)
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

                // write inifile
                iniWriteFile();

                // release mutex
                if (null != m_exclusiveMutex)
                    m_exclusiveMutex.Close();
            }
            base.WndProc(ref m);
        }

        #endregion

        #region btnClose_Click
        private void btnClose_Click(object sender, EventArgs e)
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

            iniWriteFile();
            Application.Exit();
        }
        #endregion

        #region btnRefreshUSB_Click
        private void btnRefreshUSB_Click(object sender, EventArgs e)
        {
            refreshUSBPorts();
        }
        #endregion

        #region lbUSBPorts_SelectedIndexChanged
        private void lbUSBPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((mnuUSBSupport.Checked == true) && (lbUSBPorts.SelectedIndex != -1))
            {
                m_sUSBPort = lbUSBPorts.Items[lbUSBPorts.SelectedIndex].ToString();
            }
        }
        #endregion

        #region mnuUSBSupport_Click
        private void mnuUSBSupport_Click(object sender, EventArgs e)
        {
            if (mnuUSBSupport.Checked != true)
                mnuUSBSupport.Checked = true;
            else
                mnuUSBSupport.Checked = false;

        }
        #endregion

        #region mnuUSBSupport_CheckChanged
        private void mnuUSBSupport_CheckChanged(object sender, EventArgs e)
        {
            if (mnuUSBSupport.Checked == true)
            {
                // enable all the usb groupbox controls
                foreach (Control ctrl in gbUSBPorts.Controls)
                    ctrl.Enabled = true;
                // set selected usb port if remembered
                int iIndex = lbUSBPorts.FindString(m_sUSBPort);
                if ((m_sUSBPort.Length > 0) && (iIndex != -1))
                    lbUSBPorts.SetSelected(iIndex, true);
            }
            else
            {
                // disable all the usb groupbox controls
                foreach (Control ctrl in gbUSBPorts.Controls)
                    ctrl.Enabled = false;
                lbUSBPorts.SelectedIndex = -1;
            }
        }
        #endregion

        #region btnSelect_Click
        private void btnSelect_Click(object sender, EventArgs e)
        {
            // save ini settings
            iniWriteFile();

            // minimize main window
            this.Hide();

            // close all open forms
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "ChooserForm")
                {
                    Application.OpenForms[i].Close();
                }
            }

            switch (m_action)
            {
                case "update":
                    if (m_frmUpdate.Visible)
                    {
                        m_frmUpdate.WindowState = FormWindowState.Normal;
                        m_frmUpdate.BringToFront();
                    }
                    else
                    {
                        m_frmUpdate.Dispose();
                        m_frmUpdate = new UpdateForm(this);
                        m_frmUpdate.ShowDialog(this);
                    }
                    break;
                case "delays":
                    if (m_frmDelays.Visible)
                    {
                        m_frmDelays.WindowState = FormWindowState.Normal;
                        m_frmDelays.BringToFront();
                    }
                    else
                    {
                        m_frmDelays.Dispose();
                        m_frmDelays = new DelaysForm(this);
                        m_frmDelays.ShowDialog(this);
                    }
                    break;
                case "read":
                    if (m_frmRead.Visible)
                    {
                        m_frmRead.WindowState = FormWindowState.Normal;
                        m_frmRead.BringToFront();
                    }
                    else
                    {
                        m_frmRead.Dispose();
                        m_frmRead = new ReadForm(this);
                        m_frmRead.ShowDialog(this);
                    }
                    break;
                case "write":
                    if (m_frmWrite.Visible)
                    {
                        m_frmWrite.WindowState = FormWindowState.Normal;
                        m_frmWrite.BringToFront();
                    }
                    else
                    {
                        m_frmWrite.Dispose();
                        m_frmWrite = new WriteForm(this);
                        m_frmWrite.ShowDialog(this);
                    }
                    break;
                case "pinlevel":
                    if (m_frmPin.Visible)
                    {
                        m_frmPin.WindowState = FormWindowState.Normal;
                        m_frmPin.BringToFront();
                    }
                    else
                    {
                        m_frmPin.Dispose();
                        m_frmPin = new PinForm(this);
                        m_frmPin.ShowDialog(this);
                    }
                    break;
                case "reset":
                    if (m_frmReset.Visible)
                    {
                        m_frmReset.WindowState = FormWindowState.Normal;
                        m_frmReset.BringToFront();
                    }
                    else
                    {
                        m_frmReset.Dispose();
                        m_frmReset = new ResetForm(this);
                        m_frmReset.ShowDialog(this);
                    }
                    break;
                case "erase":
                    if (m_frmErase.Visible)
                    {
                        m_frmErase.WindowState = FormWindowState.Normal;
                        m_frmErase.BringToFront();
                    }
                    else
                    {
                        m_frmErase.Dispose();
                        m_frmErase = new EraseForm(this);
                        m_frmErase.ShowDialog(this);
                    }
                    break;
                case "bandwidth":
                    if (m_frmBandwidth.Visible)
                    {
                        m_frmBandwidth.WindowState = FormWindowState.Normal;
                        m_frmBandwidth.BringToFront();
                    }
                    else
                    {
                        m_frmBandwidth.Dispose();
                        m_frmBandwidth = new BandwidthForm(this);
                        m_frmBandwidth.ShowDialog(this);
                    }
                    break;
                case "info":
                    if (m_frmInfo.Visible)
                    {
                        m_frmInfo.WindowState = FormWindowState.Normal;
                        m_frmInfo.BringToFront();
                    }
                    else
                    {
                        m_frmInfo.Dispose();
                        m_frmInfo = new InfoForm(this);
                        m_frmInfo.ShowDialog(this);
                    }
                    break;
            }
        }
        #endregion

        #region rbUpdateFirmware_CheckedChanged
        private void rbUpdateFirmware_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUpdateFirmware.Checked == true)
            {
                m_action = "update";
            }
        }
        #endregion

        #region rbSetDelays_CheckedChanged
        private void rbSetDelays_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSetDelays.Checked == true)
                m_action = "delays";
        }
        #endregion

        #region rbReadDisk_CheckedChanged
        private void rbReadDisk_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReadDisk.Checked == true)
                m_action = "read";
        }
        #endregion

        #region rbWriteDisk_CheckedChanged
        private void rbWriteDisk_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWriteDisk.Checked == true)
                m_action = "write";
        }
        #endregion

        #region rbPin_CheckedChanged
        private void rbPin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPin.Checked == true)
                m_action = "pinlevel";
        }
        #endregion

        #region rbReset_CheckedChanged
        private void rbReset_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReset.Checked == true)
                m_action = "reset";
        }
        #endregion

        #region rbF7_CheckedChanged
        private void rbF7_CheckedChanged(object sender, EventArgs e)
        {
            if (rbF7.Checked)
                m_bF7Type = true;
        }
        #endregion

        #region rbF1_CheckedChanged
        private void rbF1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbF1.Checked)
                m_bF7Type = false;
        }
        #endregion

        #region aboutToolStripMenuItem_Click
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form m_frmAbout = new AboutForm();
            m_frmAbout.ShowDialog(m_frmChooser);
        }
        #endregion

        #region rbBandwidth_CheckedChanged
        private void rbBandwidth_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBandwidth.Checked == true)
                m_action = "bandwidth";
        }
        #endregion

        #region rbErase_CheckedChanged
        private void rbErase_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEraseDisk.Checked == true)
                m_action = "erase";
        }
        #endregion

        #region mnuWindowsEXE_Click
        private void mnuWindowsEXE_Click(object sender, EventArgs e)
        {
            if (mnuWindowsEXE.Checked != true)
            {
                mnuWindowsEXE.Checked = true;
                m_bWindowsEXE = true;
            }
            else
            {
                mnuWindowsEXE.Checked = false;
                m_bWindowsEXE = false;
            }
        }
        #endregion

        #region rbInfo_CheckedChanged
        private void rbInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInfo.Checked == true)
                m_action = "info";
        }
        #endregion

        #region statusStrip_ItemClicked
        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("The GUI executable supports Host Tools versions up to the one identified in the GUI's title bar. The GUI will always choose the Host Tools from the folder the executable was placed. If you use a previous version of Host Tools, make sure you only choose GUI options that are supported. If you put the executable in a newer version folder of Host Tools than identified in the title bar, all older functions should work unless removed in the newer version. The GUI cannot identify the actual firmware version burned to the controller. Use the 'info' Greaseweazle option to retrieve this information.");
        }
        #endregion

        #region mnuInfo_Click
        private void mnuInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The GUI executable supports Host Tools versions up to the one identified in the GUI's title bar. The GUI will always choose the Host Tools from the folder the executable was placed. If you use a previous version of Host Tools, make sure you only choose GUI options that are supported. If you put the executable in a newer version folder of Host Tools than identified in the title bar, all older functions should work unless removed in the newer version. The GUI cannot identify the actual firmware version burned to the controller. Use the 'info' Greaseweazle option to retrieve this information.");
        }
        #endregion
    }
}
