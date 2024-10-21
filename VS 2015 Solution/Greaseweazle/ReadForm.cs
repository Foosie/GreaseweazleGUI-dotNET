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
using System.ComponentModel;

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
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "m_sRFDFilename", tbFilename.Text);
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
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkBitrateRFD", (chkBitrateRFD.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtBitrateRFD", txtBitrateRFD.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkAdjustSpeed", (chkAdjustSpeed.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtAdjustSpeed", txtAdjustSpeed.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "cbAdjustSpeed", cbAdjustSpeed.Text);
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
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkHeadSwap", (chkHeadSwap.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkRevTrkData", (chkRevTrkData.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkRaw", (chkRaw.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkNoClobber", (chkNoClobber.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkPin2High", (chkPin2High.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkFakeIndex", (chkFakeIndex.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtFakeIndex", txtFakeIndex.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "cbFakeIndex", cbFakeIndex.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkPLLSpec", (chkPLLSpec.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtPLLPeriod", txtPLLPeriod.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "txtPLLPhase", txtPLLPhase.Text);
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkPin2High", (chkPin2High.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "rbHigh", (rbHigh.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "rbLow", (rbLow.Checked == true).ToString());
            ChooserForm.m_Ini.IniWriteValue("gbReadFromDisk", "chkHardSectors", (chkHardSectors.Checked == true).ToString());
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
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtBitrateRFD", "garbage").Trim())) != "garbage")
                txtBitrateRFD.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkBitrateRFD", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkBitrateRFD.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtAdjustSpeed", "garbage").Trim())) != "garbage")
                txtAdjustSpeed.Text = sRet;
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkAdjustSpeed", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkAdjustSpeed.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "cbAdjustSpeed", "garbage").Trim())) != "garbage")
                cbAdjustSpeed.Text = sRet;
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
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkHeadSwap", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkHeadSwap.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkRevTrkData", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkRevTrkData.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkRaw", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkRaw.Checked = true;
            }

            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkFakeIndex", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkFakeIndex.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtFakeIndex", "garbage").Trim())) != "garbage")
            {
                txtFakeIndex.Text = sRet;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "cbFakeIndex", "garbage").Trim())) != "garbage")
            {
                cbFakeIndex.Text = sRet;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkNoClobber", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkNoClobber.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkPin2High", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkPin2High.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtPLLPeriod", "garbage").Trim())) != "garbage")
            {
                txtPLLPeriod.Text = sRet;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "txtPLLPhase", "garbage").Trim())) != "garbage")
            {
                txtPLLPhase.Text = sRet;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkPLLSpec", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkPLLSpec.Checked = true;
            }

            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkPin2High", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkPin2High.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "rbHigh", "garbage").Trim())) != "garbage")
            {
                if ((sRet == "True") && (chkPin2High.Checked == true))
                    rbHigh.Checked = true;
            }
            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "rbLow", "garbage").Trim())) != "garbage")
            {
                if ((sRet == "True") && (chkPin2High.Checked == true))
                    rbLow.Checked = true;
            }

            if ((sRet = (ChooserForm.m_Ini.IniReadValue("gbReadFromDisk", "chkHardSectors", "garbage").Trim())) != "garbage")
            {
                if (sRet == "True")
                    chkHardSectors.Checked = true;
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
            string sTracks = " --tracks=";

            // txtRFDCommandLine
            if (true == m_bWindowsEXE)
                txtRFDCommandLine.Text = "gw.exe";
            else
                txtRFDCommandLine.Text = "python.exe " + ChooserForm.m_sGWscript;
            if (true == m_bElapsedTime)
                txtRFDCommandLine.Text += " --time";
            txtRFDCommandLine.Text += " read";
            if  ((ChooserForm.m_bUseCustomFormats == true) && (cbFormat.Text != "UNSPECIFIED FORMAT"))
                txtRFDCommandLine.Text +=  " --diskdefs " + "\"" + ChooserForm.m_sDisktDefsFN + "\"";
            if ((cbFormat.Text.Length > 0) && (cbFormat.Text != "UNSPECIFIED FORMAT") && (cbFormat.ForeColor != Color.Black))  // black means disabled
                txtRFDCommandLine.Text += " --format=" + cbFormat.Text;
            if (chkDriveRetriesRFD.Checked == true)
                txtRFDCommandLine.Text += " --retries=" + txtDriveRetriesRFD.Text;
            if (chkNoClobber.Checked == true)
                txtRFDCommandLine.Text += " --no-clobber";
            if (chkPin2High.Checked == true)
            {
                if (rbHigh.Checked == true)
                    txtRFDCommandLine.Text += " --densel H";
                else if (rbLow.Checked == true)
                    txtRFDCommandLine.Text += " --densel L";
            }
            if (chkRevsPerTrack.Checked == true)
                txtRFDCommandLine.Text += " --revs=" + txtRevsPerTrack.Text;
            if (chkAdjustSpeed.Checked == true)
                txtRFDCommandLine.Text += " --adjust-speed=" + txtAdjustSpeed.Text + cbAdjustSpeed.Text;
            if (chkRaw.Checked == true)
                txtRFDCommandLine.Text += " --raw";
            if (chkFakeIndex.Checked == true)
                txtRFDCommandLine.Text += " --fake-index=" + txtFakeIndex.Text + cbFakeIndex.Text;
            if (chkPLLSpec.Checked == true)
                txtRFDCommandLine.Text += " --pll=period=" + txtPLLPeriod.Text + ":phase=" + txtPLLPhase.Text;
            if ((chkDriveSelectRFD.Enabled == true) && (chkDriveSelectRFD.Checked == true))
                txtRFDCommandLine.Text += " --drive=" + txtDriveSelectRFD.Text;
            if (chkRevTrkData.Checked == true)
                txtRFDCommandLine.Text += " --reverse";
            if (chkHardSectors.Checked == true)
                txtRFDCommandLine.Text += " --hard-sectors";

            // sTracks
            if (chkDoubleStep.Checked == true)
                sTracks += "step=" + txtDoubleStep.Text + ":";
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
                txtRFDCommandLine.Text += sTracks;
            }

            if ((m_bUSBSupport == true) && (m_sUSBPort != "UNKNOWN"))
                txtRFDCommandLine.Text += " --device=" + m_sUSBPort;
            txtRFDCommandLine.Text += " " + "\"" + m_sReadDiskFolder + "\\" + tbFilename.Text.Trim();
            if (chkLegacySS.Checked == true)
                txtRFDCommandLine.Text += "::legacy_ss";
            if (chkBitrateRFD.Checked == true)
                txtRFDCommandLine.Text += "::bitrate=" + txtBitrateRFD.Text;
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

        private void chkBitrateRFD_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkAdjustSpeed_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkDriveRetriesRFD_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtBitrateRFD_TextChanged(object sender, EventArgs e)
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
            if (chkHeadsSet.Checked == true)
            {
                chkHeadsSet.Checked = true;
                txtHeadsSet.Text = "0-1";
                chkDoubleStep.Checked = true;
                txtDoubleStep.Text = "2";
            }
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
            string sFn = removeDiskType(this.tbFilename.Text, true);
            tbFilename.Text = sFn + cbExtension.Text;
            if (((cbExtension.Text == ".ipf") || (cbExtension.Text == ".dsk")) && (cbFormat.SelectedIndex != 0))
                cbFormat.ForeColor = Color.Black;
            else
                cbFormat.ForeColor = Color.White;
            CreateCommandLine();
        }

        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbFormat.Text.Length > 0) && (cbFormat.Text != "UNSPECIFIED FORMAT") && (cbFormat.ForeColor != Color.Black))  // black means disabled
            {
                chkCylSet.Checked = false;
                chkHeadsSet.Checked = false;
                chkDoubleStep.Checked = false;
                chkHeadSwap.Checked = false;
                chkLegacySS.Checked = false;
                chkFlippyOffset.Checked = false;
                chkAdjustSpeed.Checked = false;
            }
            CreateCommandLine();
        }

        private void chkHeadSwap_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkNoClobber_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void chkRaw_CheckedChanged(object sender, EventArgs e)
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

        private void txtPLLPeriod_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void txtPLLPhase_TextChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void PLLSpec_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void rbHigh_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void rbLow_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        private void tbFilename_TextChanged(object sender, EventArgs e)
        {
            GetFNSuffix();
            CreateCommandLine();
        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            ChgSuffix(1);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            ChgSuffix(2);
        }

        private void tbSuffix_TextChanged(object sender, EventArgs e)
        {
            ChgFilenameSuffix();
            CreateCommandLine();
        }

        private void chkPin2High_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }


        private void chkRevTrkData_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }


        private void chkHardSectors_CheckedChanged(object sender, EventArgs e)
        {
            CreateCommandLine();
        }

        #endregion

        #region ReadForm_Load
        private void ReadForm_Load(object sender, EventArgs e)
        {
            // set colors
            this.lbOutput.BackColor = ChooserForm.cLightBrown;
            this.ctxClearOutput.BackColor = ChooserForm.cDarkBrown;
            this.ctxSaveOutput.BackColor = ChooserForm.cDarkBrown;
            this.lblHostTools.Text = ChooserForm.m_sStatusLine;
            this.BackColor = ChooserForm.cChocolate;
            this.txtDoubleStep.BackColor = ChooserForm.cLightBrown;
            this.txtRevsPerTrack.BackColor = ChooserForm.cLightBrown;
            this.txtDriveSelectRFD.BackColor = ChooserForm.cLightBrown;
            this.txtBitrateRFD.BackColor = ChooserForm.cLightBrown;
            this.txtDriveRetriesRFD.BackColor = ChooserForm.cLightBrown;
            this.txtAdjustSpeed.BackColor = ChooserForm.cLightBrown;
            this.txtFakeIndex.BackColor = ChooserForm.cLightBrown;
            this.cbFakeIndex.BackColor = ChooserForm.cLightBrown;
            this.txtPLLPeriod.BackColor = ChooserForm.cLightBrown;
            this.txtPLLPhase.BackColor = ChooserForm.cLightBrown;
            this.txtCylSet.BackColor = ChooserForm.cLightBrown;
            this.txtHeadsSet.BackColor = ChooserForm.cLightBrown;
            this.tbFilename.BackColor = ChooserForm.cLightBrown;
            this.tbSuffix.BackColor = ChooserForm.cLightBrown;
            this.cbExtension.ForeColor = Color.White;
            this.cbExtension.BackColor = ChooserForm.cLightBrown;
            this.txtAdjustSpeed.ForeColor = Color.White;
            this.txtAdjustSpeed.BackColor = ChooserForm.cLightBrown;
            this.cbAdjustSpeed.ForeColor = Color.White;
            this.cbAdjustSpeed.BackColor = ChooserForm.cLightBrown;
            this.cbFormat.ForeColor = Color.White;
            this.cbFormat.BackColor = ChooserForm.cLightBrown;
            this.btnInc.BackColor = ChooserForm.cDarkBrown;
            this.btnDec.BackColor = ChooserForm.cDarkBrown;
            this.txtRFDCommandLine.BackColor = ChooserForm.cLightBrown;
            this.btnRFDSelectFolder.BackColor = ChooserForm.cDarkBrown;
            this.btnRFDSelectFile.BackColor = ChooserForm.cDarkBrown;
            this.btnLaunch.BackColor = ChooserForm.cDarkBrown;
            this.btnBack.BackColor = ChooserForm.cDarkBrown;

            if (ChooserForm.m_bUseCmdConsole == true)
            {
                lbOutput.Items.Add("");
                lbOutput.Items.Add(ChooserForm.m_sConsoleMsg);
            }
            else
                ContextMenuStrip = ctxOutput;

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
            openDialog.Filter = ChooserForm.m_sExtFilter;

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

        #region LaunchPython
        private void LaunchPython()
        {
            // only allow one instance at a time
            if (ChooserForm.existsGWProcess())
                return;

            // create the command console
            ChooserForm.createCmdConsole("/K " + "\"" + txtRFDCommandLine.Text + "\"");
        }
        #endregion

        #region LaunchPythonNew
        private void LaunchPythonNew()
        {
            ClearlbOutput();

            string sFn = "gw.exe";
            string args = txtRFDCommandLine.Text;

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
                lbOutput.Invoke((MethodInvoker)delegate
                {
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
                lbOutput.Invoke((MethodInvoker)delegate
                {
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

            // continue
            base.WndProc(ref m);
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
            string sFN = removeDiskType(tbFilename.Text, true); // remove extension as well
            string sExt = Path.GetExtension(tbFilename.Text);
            if ((pos = sFN.IndexOf(m_sSeperator)) == -1)
                return;
            String sSuffix = sFN.Substring(pos + 2);
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
            string sRemove = "::";
            int pos = fn.IndexOf(sRemove);
            if (pos >= 0)
                fn = fn.Substring(0, pos);
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
