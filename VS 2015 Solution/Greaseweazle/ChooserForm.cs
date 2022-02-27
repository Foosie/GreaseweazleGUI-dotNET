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
using System.IO.Ports;
using IWshRuntimeLibrary;

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
        private Form m_frmClean = null;
        private Form m_frmSeek = null;
        private Form m_frmRPM = null;
        private Form m_frmConvert = null;
        private Form m_frmPicture = null;
        public static string m_sExeDir = "";
        public string m_action = "read";
        public const int WM_CLOSE = 0x0010;
        public static Boolean m_bF7Type = false;
        public static Boolean m_bWindowsEXE = false;
        public static Boolean m_bElapsedTime = false;
        public static Boolean m_bUseCmdConsole = true;
        public static string m_sConsoleMsg = "Using CMD Console mode";
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
        public static string m_sStatusLine = "for Host Tools v0.39";
        public static Color cChocolate = Color.FromArgb(100, 82, 72);
        public static Color cLightBrown = Color.FromArgb(150, 114, 93);
        public static Color cDarkBrown = Color.FromArgb(74, 61, 53);
        public static Color cWhite = Color.FromArgb(0, 0, 0);
        public static Color cBrown = Color.FromArgb(128, 64, 64);
        private string m_sInfo = "The GUI executable only supports the Host Tools version identified in the GUI's status bar. The GUI will always use the Host Tools from the folder from which the executable was placed. Use the 'info' Greaseweazle option to determine the firmware's current version.";
        private ToolStripMenuItem[] m_mnuItems;
        #endregion

        #region ChooserForm
        public ChooserForm()
        {
            InitializeComponent();
            //menuStrip1.Renderer = new myRenderer();  // change menu strip highlight color
            menuStrip1.Renderer = new ChocolateRenderer();
            InitializeMyStuff();
        }
        #endregion

        #region ChocolateRenderer
        private class ChocolateRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = ChooserForm.cChocolate;
                using (SolidBrush brush = new SolidBrush(c))
                    e.Graphics.FillRectangle(brush, rc);
            }
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
            m_frmClean = new CleanForm(this);
            m_frmSeek = new SeekForm(this);
            m_frmRPM = new RPMForm(this);
            m_frmConvert = new ConvertForm(this);
            m_frmPicture = new PictureForm(this);

            // get version from Project, GreaseweaselGUI Properties, Assembly Information
            m_sVersion = Application.ProductVersion;
            string[] tokens = m_sVersion.Split('.');
            m_sVersion = "v" + tokens[2] + "." + tokens[3];
            this.Text = "GreaseweazleGUI " + m_sVersion;

            // initialize some stuff
            m_Ini = new IniFile(m_sIniFile);
            rbReadDisk.Checked = true;
            m_frmChooser = this;

            // new color stufff
            this.lblHostTools.Text = m_sStatusLine;
            this.BackColor = cChocolate;
            this.ForeColor = cWhite;
            this.menuStrip1.BackColor = cChocolate;
            this.menuStrip1.ForeColor = cWhite;
            this.btnRefreshUSB.BackColor = cDarkBrown;
            this.btnSelect.BackColor = cDarkBrown;
            this.btnClose.BackColor = cDarkBrown;
            this.lbUSBPorts.BackColor = cLightBrown;
            this.mnuSettings.ForeColor = Color.White;
            this.mnuCreateShortcut.ForeColor = Color.White;
            this.mnuUseCmdConsole.ForeColor = Color.White;
            this.mnuProfileNew.ForeColor = Color.White;
            this.mnuDelete.ForeColor = Color.White;
            this.mnuUSBSupport.ForeColor = Color.White;
            this.mnuWindowsEXE.ForeColor = Color.White;
            this.mnuElapsedTime.ForeColor = Color.White;

            // set working directory to executable directory
            m_sExeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Directory.SetCurrentDirectory(m_sExeDir);

            // check for existance of gw.py
            if (!System.IO.File.Exists(m_sExeDir + "\\gw.py") && !System.IO.File.Exists(m_sExeDir + "\\gw") && !System.IO.File.Exists(m_sExeDir + "\\gw.exe"))
                System.Windows.Forms.MessageBox.Show("GreaseweazleGUI.exe must be moved to same folder as the controllers CURRENT firmware 'Host Tools' support files were extracted.", "Oops!");

            // determine which way to invoke the script
            // this is overwridden if the user selects exe in settings
            if (System.IO.File.Exists(m_sExeDir + "\\gw"))
                m_sGWscript = "gw";
            else m_sGWscript = "gw.py";

            // stub ini file if necessary
            if (!System.IO.File.Exists(m_sIniFile))
                m_Ini.IniWriteValue("gbMisc", "txtProfile", "GreaseweazleGUI");

            // build the profile menu
            BuildProfileMenu();

            // now restore the selected profile
            restoreSelectedProfile();

            // finally read our settings
            iniReadFile();

            // if compiled windows version check it
            if (System.IO.File.Exists(m_sExeDir + "\\gw.exe"))
            {
                if (!mnuWindowsEXE.Checked)
                    AutoClosingMessageBox.Show("Found gw.exe in folder\n\nChange 'Globals\\Windows Self-contained Executable' to enable", this.Text, 10000);
            }
            else if (mnuWindowsEXE.Checked)
            {
                AutoClosingMessageBox.Show("Missing gw.exe in folder.\n\nWindows Self-contained Executable mode deselected", this.Text, 10000);
                mnuWindowsEXE.Checked = false;
                m_bWindowsEXE = false;
            }

            // set default folders
            if (m_sReadDiskFolder.Length == 0)
                m_sReadDiskFolder = m_sExeDir;
            if (m_sWriteDiskFolder.Length == 0)
                m_sWriteDiskFolder = m_sExeDir;
            if (m_sUpdateFirmwareFolder.Length == 0)
                m_sUpdateFirmwareFolder = m_sExeDir;

            // Get a list of serial port names.
            refreshUSBPorts();
        }
        #endregion

        #region iniReadFile
        public void iniReadFile()
        {
            string sRet;

            // get rid of previous ini file version
            if (System.IO.File.Exists(m_Ini.path))
            {
                if ((m_Ini.IniReadValue("gbCommandLine", "m_sPythonFolder", "garbage").Trim()) != "garbage")
                {
                    // delete the old format ini file if it exists
                    System.IO.File.Delete(m_Ini.path);

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
            if ((sRet = (m_Ini.IniReadValue("gbAction", "rbCleanHeads", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbCleanHeads.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbAction", "rbSeekCyl", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbSeekCyl.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbAction", "rbConvert", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbConvert.Checked = true;
            }
            if ((sRet = (m_Ini.IniReadValue("gbAction", "rbRPMspindle", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    rbRPMspindle.Checked = true;
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
            if ((sRet = (m_Ini.IniReadValue("gbGlobals", "mnuWindowsEXE", "garbage").Trim())) != "garbage")
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

            // Elapsed Time
            if ((sRet = (m_Ini.IniReadValue("gbGlobals", "mnuElapsedTime", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                {
                    mnuElapsedTime.Checked = true;
                    m_bElapsedTime = true;
                }
                else
                {
                    mnuElapsedTime.Checked = false;
                    m_bElapsedTime = false;
                }
            }

            // Cmd Console
            if ((sRet = (m_Ini.IniReadValue("gbGlobals", "mnuUseCmdConsole", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                {
                    mnuUseCmdConsole.Checked = true;
                    m_bUseCmdConsole = true;
                }
                else
                {
                    mnuUseCmdConsole.Checked = false;
                    m_bUseCmdConsole = false;
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
            m_Ini.IniWriteValue("gbAction", "rbCleanHeads", (rbCleanHeads.Checked == true).ToString());
            m_Ini.IniWriteValue("gbAction", "rbSeekCyl", (rbSeekCyl.Checked == true).ToString());
            m_Ini.IniWriteValue("gbAction", "rbConvert", (rbConvert.Checked == true).ToString());
            m_Ini.IniWriteValue("gbAction", "rbRPMspindle", (rbRPMspindle.Checked == true).ToString());

            // usb port
            m_Ini.IniWriteValue("gbUSBPorts", "mnuUSBSupport", (mnuUSBSupport.Checked == true).ToString());
            m_Ini.IniWriteValue("gbUSBPorts", "m_sUSBPort", m_sUSBPort);

            // globals
            m_Ini.IniWriteValue("gbGlobals", "mnuWindowsEXE", (mnuWindowsEXE.Checked == true).ToString());
            m_Ini.IniWriteValue("gbGlobals", "mnuElapsedTime", (mnuElapsedTime.Checked == true).ToString());
            m_Ini.IniWriteValue("gbGlobals", "mnuUseCmdConsole", (mnuUseCmdConsole.Checked == true).ToString());
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
                if (existsGWProcess())
                    return;

                // write inifile
                iniWriteFile();

                // save the selected profile
                saveSelectedProfile();

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
            if (existsGWProcess())
                return;

            // save our profile
            iniWriteFile();

            // save the selected profile
            saveSelectedProfile();

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
                case "clean":
                    if (m_frmClean.Visible)
                    {
                        m_frmClean.WindowState = FormWindowState.Normal;
                        m_frmClean.BringToFront();
                    }
                    else
                    {
                        m_frmClean.Dispose();
                        m_frmClean = new CleanForm(this);  /// fix
                        m_frmClean.ShowDialog(this);
                    }
                    break;
                case "seek":
                    if (m_frmSeek.Visible)
                    {
                        m_frmSeek.WindowState = FormWindowState.Normal;
                        m_frmSeek.BringToFront();
                    }
                    else
                    {
                        m_frmSeek.Dispose();
                        m_frmSeek = new SeekForm(this);
                        m_frmSeek.ShowDialog(this);
                    }
                    break;
                case "rpm":
                    if (m_frmRPM.Visible)
                    {
                        m_frmRPM.WindowState = FormWindowState.Normal;
                        m_frmRPM.BringToFront();
                    }
                    else
                    {
                        m_frmRPM.Dispose();
                        m_frmRPM = new RPMForm(this);
                        m_frmRPM.ShowDialog(this);
                    }
                    break;
                case "convert":
                    if (m_frmConvert.Visible)
                    {
                        m_frmConvert.WindowState = FormWindowState.Normal;
                        m_frmConvert.BringToFront();
                    }
                    else
                    {
                        m_frmConvert.Dispose();
                        m_frmConvert = new ConvertForm(this);
                        m_frmConvert.ShowDialog(this);
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

        #region rbCleanHeads_CheckedChanged
        private void rbCleanHeads_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCleanHeads.Checked == true)
                m_action = "clean";
        }
        #endregion

        #region mnuInfo_Click
        private void mnuInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m_sInfo);
        }
        #endregion

        #region BuildProfileMenu
        private void BuildProfileMenu()
        {
            string[] filePaths = Directory.GetFiles(m_sExeDir, "*.ini");
            m_mnuItems = null; // and dispose of any sub-items

            m_mnuItems = new ToolStripMenuItem[filePaths.Length];
            string fname;

            for (int i = 0; i < m_mnuItems.Length; i++)
            {
                fname = Path.GetFileNameWithoutExtension(filePaths[i]);
                m_mnuItems[i] = new ToolStripMenuItem();
                m_mnuItems[i].BackColor = cChocolate;
                m_mnuItems[i].ForeColor = Color.White;
                m_mnuItems[i].Name = "mnu" + fname;
                m_mnuItems[i].Text = fname;
                m_mnuItems[i].Click += new EventHandler(MenuItemClickHandler);              
            }

            mnuProfiles.DropDownItems.AddRange(m_mnuItems);
        }
        #endregion

        #region MenuItemClickHandler
        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            for (int i = 0; i < m_mnuItems.Length; i++)
            { 
                m_mnuItems[i].Checked = false;
                if (m_mnuItems[i] == clickedItem)
                    m_mnuItems[i].Checked = true;
            }
            m_sIniFile = ".\\" + clickedItem + ".ini";
            m_Ini = new IniFile(m_sIniFile);
            iniReadFile();
        }
        #endregion

        #region mnuProfileNew_Click
        private void mnuProfileNew_Click(object sender, EventArgs e)
        { 
            InputForm m_frmInput = new InputForm(this);
            m_frmInput.ShowDialog(this);

            // now restart the application
            Application.Restart();
        }
        #endregion

        #region restoreSelectedProfile
        private void restoreSelectedProfile()
        {
            string sRet;
            IniFile ifile = new IniFile(".\\GreaseweazleGUI.ini");
            sRet = m_Ini.IniReadValue("gbMisc", "txtProfile", "garbage").Trim();
            for (int i = 0; i < m_mnuItems.Length; i++)
            {
                m_mnuItems[i].Checked = false;
                if (m_mnuItems[i].ToString() == sRet)
                {
                    m_mnuItems[i].Checked = true;
                    m_sIniFile = ".\\" + sRet + ".ini";
                    m_Ini = new IniFile(m_sIniFile);
                }
            }
        }
        #endregion

        #region saveSelectedProfile
        private void saveSelectedProfile()
        {
            bool bFound = false;
            IniFile ifile = new IniFile(".\\GreaseweazleGUI.ini");
            for (int i = 0; i < m_mnuItems.Length; i++)
            {
                if (m_mnuItems[i].Checked)
                {
                    ifile.IniWriteValue("gbMisc", "txtProfile", m_mnuItems[i].ToString());
                    bFound = true;
                }
            }
            if (!bFound)
                ifile.IniWriteValue("gbMisc", "txtProfile", "GreaseweazleGUI");
        }
        #endregion

        #region mnuDelete_Click
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.RestoreDirectory = true; // make sure directory is set to executable path
            openDialog.AddExtension = true;
            openDialog.CheckFileExists = true;
            openDialog.DefaultExt = "ini";
            openDialog.InitialDirectory = m_sExeDir;
            openDialog.Multiselect = false;
            openDialog.Title = "Select a profile (current profile excluded)";
            openDialog.Filter = "Profiles (*.INI;) | *.INI;";
            DialogResult drRet = DialogResult.Cancel;
            if ((drRet = openDialog.ShowDialog()) == DialogResult.OK)
            {
                while (Path.GetDirectoryName(openDialog.FileName) != Path.Combine(Path.GetDirectoryName(Application.StartupPath), m_sExeDir))
                {
                    MessageBox.Show("Please select a profile which is in the default folder", "Wrong folder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    drRet = openDialog.ShowDialog();
                }
                string sFilename = openDialog.FileName;
                string sProfilename = Path.GetFileNameWithoutExtension(sFilename);
                if (sProfilename == "GreaseweazleGUI")
                    MessageBox.Show("You cannot delete the default profile", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    // determine the selected profile
                    for (int i = 0; i < m_mnuItems.Length; i++)
                    {
                        if ((m_mnuItems[i].Checked) && (m_mnuItems[i].ToString() == sProfilename))
                        {
                            MessageBox.Show("You cannot delete the current profile", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    drRet = MessageBox.Show("Delete profile " + sProfilename.ToUpper() + ".\n\n Are you sure?", "Delete Profile", MessageBoxButtons.YesNo);
                    if (drRet == DialogResult.Yes)
                    {
                        System.IO.File.Delete(sFilename);
                        Application.Restart();
                    }
                }
            }
        }
        #endregion

        #region rbSeekCyl_CheckedChanged
        private void rbSeekCyl_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSeekCyl.Checked == true)
                m_action = "seek";
        }
        #endregion

        #region pbGWsmall_Click
        private void pbGWsmall_Click(object sender, EventArgs e)
        {
            if (m_frmPicture.Visible)
            {
                m_frmPicture.WindowState = FormWindowState.Normal;
                m_frmPicture.BringToFront();
            }
            else
            {
                m_frmPicture.Dispose();
                m_frmPicture = new PictureForm(this);
                m_frmPicture.ShowDialog(this);
            }
        }
        #endregion

        #region mnuElapsedTime_Click
        private void mnuElapsedTime_Click(object sender, EventArgs e)
        {
            m_bElapsedTime = mnuElapsedTime.Checked = !mnuElapsedTime.Checked;
        }
        #endregion

        #region mnuUseCmdConsole_Click
        private void mnuUseCmdConsole_Click(object sender, EventArgs e)
        {
            if (existsGWProcess())
                return;
            else
                m_bUseCmdConsole = mnuUseCmdConsole.Checked = !mnuUseCmdConsole.Checked;
        }
        #endregion

        #region CreateShortcut
        public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);
            shortcut.Description = "GreaseweazleGUI";
            shortcut.TargetPath = targetFileLocation;
            shortcut.Save();
        }
        #endregion

        #region mnuCreateShortcut_Click
        private void mnuCreateShortcut_Click(object sender, EventArgs e)
        {
            CreateShortcut("GreaseweazleGUI", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Assembly.GetExecutingAssembly().Location);
        }
        #endregion

        #region saveLbItemsToFile
        public static void saveLbItemsToFile(ListBox lb)
        {
            string sFilename = "";
            string sDiskFolder = "";
            string sFilespec = "";
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.RestoreDirectory = true; // make sure directory is set to executable path
            openDialog.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            openDialog.Multiselect = false;
            openDialog.CheckFileExists = false;
            openDialog.Title = "Enter a file name:";
            openDialog.Filter = "Text |*.txt|All files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                sFilename = openDialog.SafeFileName;
                sDiskFolder = Path.GetDirectoryName(openDialog.FileName);
                sFilespec = sDiskFolder + "\\" + sFilename;
                if (System.IO.File.Exists(sFilespec))
                {
                    DialogResult dr = MessageBox.Show("Shall we overwite?", "Existing File", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes != dr)
                        return;
                }
                using (StreamWriter writer = new StreamWriter(sFilespec, false)) // true to append data to the file
                {
                    for (int i = 0; i < lb.Items.Count; i++)
                        writer.WriteLine(lb.Items[i].ToString());
                }
            }
        }
        #endregion

        #region existsGWProcess
        public static Boolean existsGWProcess()
        {
            // only allow one instance at a time
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                if (theprocess.Id > 0)
                {
                    if (ChooserForm.m_ProcessId == theprocess.Id)
                    {
                        if (m_bUseCmdConsole)
                            System.Windows.Forms.MessageBox.Show("You must first close the previous Greaseweazle command console", "Oops!");
                        else
                            System.Windows.Forms.MessageBox.Show("You must let the current operation complete", "Oops!");
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion

        #region createCmdConsole
        public static void createCmdConsole(string args)
        {
            // hide main form
            if (m_frmChooser.Visible == true)
                m_frmChooser.Hide();

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "C:\\WINDOWS\\SYSTEM32\\cmd.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = args;
            try
            {
                Process exeProcess = Process.Start(startInfo);
                ChooserForm.m_ProcessId = exeProcess.Id;
            }
            catch (Exception e)
            {
                string sMessage = e.Message.ToString();
                MessageBox.Show("An error has occured\n" + sMessage, "Oops!");
            }
        }
        #endregion

        #region confirmCloseProcess
        public static Boolean confirmCloseProcess(Button btnLaunch)
        {
            // hide main form
            if (m_frmChooser.Visible == true)
                m_frmChooser.Hide();

            // the process thread is running if eithger button is disabled
            if (btnLaunch.Enabled == true)
                return true; // allow close

            // abort close
            System.Windows.Forms.MessageBox.Show("You must let the disk operation complete", "Oops!");
            return false;
        }
        #endregion

        #region rbRPMspindle_CheckedChanged
        private void rbRPMspindle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRPMspindle.Checked == true)
                m_action = "rpm";
        }
        #endregion

        #region rbConvert_CheckedChanged
        private void rbConvert_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConvert.Checked == true)
                m_action = "convert";
        }
        #endregion
    }

    #region AutoClosingMessageBox
    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        AutoClosingMessageBox(string text, string caption, int timeout)
        {
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            using (_timeoutTimer)
                MessageBox.Show(text, caption);
        }
        public static void Show(string text, string caption, int timeout)
        {
            new AutoClosingMessageBox(text, caption, timeout);
        }
        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }
    #endregion

}
