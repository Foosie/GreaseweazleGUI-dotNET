// Ini.cs
//
// Greaseweazle GUI Wrapper
//
// Copyright (c) 2019 Don Mankin <don.mankin@yahoo.com>
//
// MIT License
//
// See the file LICENSE for more details, or visit <https://opensource.org/licenses/MIT>.

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Greaseweazle
{
	public class IniFile
	{
		public string path;

		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string section,
			string key,string val,string filePath);
		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string section,
			string key,string def, StringBuilder retVal,
			int size,string filePath);

		/// <summary>
		/// INIFile Constructor.
		/// </summary>
		/// <PARAM name="INIPath"></PARAM>

		public IniFile(string INIPath)
		{
			path = INIPath;
		}

		/// <summary>
		/// Write Data to the INI File
		/// </summary>
		/// <PARAM name="Section"></PARAM>
		/// Section name
		/// <PARAM name="Key"></PARAM>
		/// Key Name
		/// <PARAM name="Value"></PARAM>
		/// Value Name

		public void IniWriteValue(string Section,string Key,string Value)
		{
			WritePrivateProfileString(Section,Key,Value,this.path);
		}
        
		/// <summary>
		/// Read Data Value From the Ini File
		/// </summary>
		/// <PARAM name="Section"></PARAM>
		/// <PARAM name="Key"></PARAM>
		/// <PARAM name="DefPath"></PARAM>
		/// <returns></returns>

		public string IniReadValue(string sSection, string sKey, string sDef)
		{
			StringBuilder temp = new StringBuilder(255);
			int i = GetPrivateProfileString ( sSection, sKey, "", temp, 255, this.path );
			string sTemp = temp.ToString();
			if (sTemp == string.Empty)
				sTemp = sDef;
			return sTemp;
		} 
	}

}
