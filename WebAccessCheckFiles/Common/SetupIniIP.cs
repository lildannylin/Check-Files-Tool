using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.IO;

namespace WebAccessCheckFiles
{
    public class SetupIniIP
    {
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, 
            string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, int Key,
           string Value, [MarshalAs(UnmanagedType.LPArray)] byte[] Result,
           int Size, string FileName);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileSectionNames(byte[] lpszReturnBuffer, int nSize, string lpFileName);

        public static void IniWriteValue(string Section, string Key, string Value, string inipath)
        {
            WritePrivateProfileString(Section, Key, Value, Application.StartupPath + "\\" + inipath);
        }

        public static string IniReadValue(string Section, string Key, string inipath)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, Application.StartupPath + "\\" + inipath);
            return temp.ToString();
        }

        public static List<string> GetAllSections(string inipath)
        {
            List<string> szSessionList = new List<string>();

            byte[] buffer = new byte[1024];
 
            GetPrivateProfileSectionNames(buffer, buffer.Length, inipath);

            string allSections = System.Text.Encoding.Default.GetString(buffer);

            string[] sectionNames = allSections.Split('\0');

            string section = string.Empty;

            int valid = 0;

            //string[] sectionNames = allSections.Split(new string[] { "\0" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string sectionName in sectionNames)
            {
                if (sectionName != string.Empty)
                {
                    valid = 1;
                    section += sectionName;
                }
                else
                {
                    if (valid == 1)
                    {
                        szSessionList.Add(section);
                        section = string.Empty;
                    }
                    valid = 0;
                }
            }
            return szSessionList;
        }

    }
}
