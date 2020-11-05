using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.Win32;

using MadMilkman.Ini;

namespace WebAccessCheckFiles
{
    public partial class Form1 : MetroForm
    {
        int local_idx, target_idx;

        int miss = 0, dismatch = 0, match = 0;

        string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

        CommonBase baseObj = new CommonBase();

        Transfer transObj = new Transfer();

        public Form1()
        {
            InitializeComponent();

            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            listBoxStandard.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxStandard.DrawItem += listBox_DrawItem;

            InitializeNode();

            metroCheckBoxAll.Checked = false;
            metroCheckBoxExe.Checked = true;
            metroCheckBoxDll.Checked = true;

            //InitializeLocal();
        }
        WaitWnd.WaitWndFun waitForm = new WaitWnd.WaitWndFun();

        System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
         {
             string dllName = args.Name.Contains(",") ? args.Name.Substring(0, args.Name.IndexOf(',')) : args.Name.Replace(".dll", "");
 
             dllName = dllName.Replace(".", "_");
 
             if (dllName.EndsWith("_resources")) return null;
 
             System.Resources.ResourceManager rm = new System.Resources.ResourceManager(GetType().Namespace + ".Properties.Resources", System.Reflection.Assembly.GetExecutingAssembly());
 
             byte[] bytes = (byte[])rm.GetObject(dllName);
 
             return System.Reflection.Assembly.Load(bytes);
         }

        void InitializeNode() {
            try
            {
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)) 
                using (var key = hklm.OpenSubKey(@"SOFTWARE\WebAccess"))
                {
                    if (key != null)
                    {
                        Object o = key.GetValue("svDir");
                        if (o != null)
                        {
                            CommonBase.szNodeLoaction = o.ToString();
                        }
                    }
                }
            }
            catch (Exception ex){
                //react appropriately
            }
        }

        void InitializeLocal() {

            //local_idx = 0;

            listBoxLocal.Items.Clear();

            InitializeLocalAll();
            //InitializeLocaDLL();
            //InitializeLocaExe();
        }

        void InitializeLocalAll()
        {
            //var filesInfo = new DirectoryInfo(appPath).GetFiles("*.*"); //, SearchOption.AllDirectories

            appPath = CommonBase.szNodeLoaction;

            baseObj.szLocalFiles.Clear();
            baseObj.szLocalChecksum.Clear();

            string checksum = string.Empty;

            local_idx = 0;

            if (metroCheckBoxAll.Checked == true)
            {
                var filesInfoDriver = new DirectoryInfo(appPath + "\\driver").GetFiles("*.dll", SearchOption.TopDirectoryOnly); //Search "driver" folder only
                var filesInfoDLL = new DirectoryInfo(appPath).GetFiles("*.dll", SearchOption.AllDirectories); //Seach "Node" folder only, not including any subfolder
                var filesInfoEXE = new DirectoryInfo(appPath).GetFiles("*.exe", SearchOption.AllDirectories); //Seach "Node" folder, including subfolder

                foreach (var file in filesInfoDriver)
                {
                    if (file.DirectoryName.Contains("opcua_import_tool") || file.DirectoryName.Contains("licence"))
                    {
                        continue;
                    }

                    checksum = transObj.GetMD5HashFromFile(file.DirectoryName + "\\" + file.Name);
                    
                    //SetupIniIP.IniWriteValue("Node", file.Name, checksum, CommonBase.szIniFileName);
                    if (checksum != "")
                    { 
                        baseObj.szLocalFiles.Add(file.DirectoryName + "/" + file);
                        baseObj.szLocalChecksum.Add(checksum);
                        local_idx++;
                    }
                }

                foreach (var file in filesInfoDLL)
                {
                    if (file.DirectoryName.Contains("opcua_import_tool") || file.Name.Contains("System.dll") || file.DirectoryName.Contains("licence"))
                    {
                        continue;
                    }

                    checksum = transObj.GetMD5HashFromFile(file.DirectoryName + "\\" + file.Name);

                    //If this file is driver dll, then skip this for-loop, i.e. Do not insert to "baseObj" List   
                    if (baseObj.szLocalChecksum.Contains(checksum))
                    {
                        continue;
                    }

                    //SetupIniIP.IniWriteValue("Node", file.Name, checksum, CommonBase.szIniFileName);
                    if (checksum != "")
                    {
                        baseObj.szLocalFiles.Add(file.DirectoryName + "/" + file);
                        baseObj.szLocalChecksum.Add(checksum);
                        local_idx++;
                    }
                }

                foreach (var file in filesInfoEXE)
                {
                    if (file.DirectoryName.Contains("opcua_import_tool") || file.DirectoryName.Contains("licence"))
                    {
                        continue;
                    }

                    checksum = transObj.GetMD5HashFromFile(file.DirectoryName + "\\" + file.Name);

                    //SetupIniIP.IniWriteValue("Node", file.Name, checksum, CommonBase.szIniFileName);
                    if (checksum != "")
                    {
                        baseObj.szLocalFiles.Add(file.DirectoryName + "/" + file);
                        baseObj.szLocalChecksum.Add(checksum);
                        local_idx++;
                    }
                }

            }
            else {
                if (metroCheckBoxDll.Checked == true) {

                    var filesInfoDriver = new DirectoryInfo(appPath + "\\driver").GetFiles("*.dll", SearchOption.TopDirectoryOnly); //Search "driver" folder only
                    var filesInfoDLL  = new DirectoryInfo(appPath).GetFiles("*.dll", SearchOption.AllDirectories);

                    foreach (var file in filesInfoDriver)
                    {
                        if (file.DirectoryName.Contains("opcua_import_tool") || file.DirectoryName.Contains("licence"))
                        {
                            continue;
                        }

                        checksum = transObj.GetMD5HashFromFile(file.DirectoryName + "\\" + file.Name);

                        //SetupIniIP.IniWriteValue("Node", file.Name, checksum, CommonBase.szIniFileName);
                        if (checksum != "")
                        {
                            baseObj.szLocalFiles.Add(file.DirectoryName + "/" + file);
                            baseObj.szLocalChecksum.Add(checksum);
                            local_idx++;
                        }
                    }

                    foreach (var file in filesInfoDLL)
                    {
                        
                        if (file.DirectoryName.Contains("opcua_import_tool") || file.Name.Contains("System.dll") || file.DirectoryName.Contains("licence"))
                        {
                            continue;
                        }
                        
                        checksum = transObj.GetMD5HashFromFile(file.DirectoryName + "/" + file);

                        //SetupIniIP.IniWriteValue("Node", file.Name, checksum, CommonBase.szIniFileName);

                        //If this file is driver dll, then skip this for-loop, i.e. Do not insert to "baseObj" List                        
                        if (baseObj.szLocalChecksum.Contains(checksum))
                        {
                            continue;
                        }

                        if (checksum != "")
                        {
                            baseObj.szLocalFiles.Add(file.DirectoryName + "/" + file);
                            baseObj.szLocalChecksum.Add(checksum);
                            local_idx++;
                        }
                    }
                }
                if (metroCheckBoxExe.Checked == true)
                {

                    var filesInfoEXE = new DirectoryInfo(appPath).GetFiles("*.exe", SearchOption.AllDirectories); //, SearchOption.AllDirectories

                    foreach (var file in filesInfoEXE)
                    {
                        if (file.DirectoryName.Contains("opcua_import_tool") || file.DirectoryName.Contains("licence"))
                        {
                            continue;
                        }

                        checksum = transObj.GetMD5HashFromFile(file.DirectoryName + "/" + file);

                        //SetupIniIP.IniWriteValue("Node", file.Name, checksum, CommonBase.szIniFileName);
                        if (checksum != "")
                        {
                            baseObj.szLocalFiles.Add(file.DirectoryName + "/" + file);
                            baseObj.szLocalChecksum.Add(checksum);
                            local_idx++;
                        }
                        //listBoxLocal.Items.Add(file.Name);                        
                    }
                }
            }
            //listBoxLocal.DataSource = baseObj.szLocalFiles;
        }

        //Create a task to process import data
        Task ProcessImport(List<string> data, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProgress = data.Count;
            var progressReport = new ProgressReport();

            miss = 0; dismatch = 0; match = 0;

            //Create a new thread
            return Task.Run(() =>
            {
                baseObj.szFailFiles.Clear();

                SetupIniIP.IniWriteValue("Diff", null, null, CommonBase.szIniLogFileName);
                SetupIniIP.IniWriteValue("Miss", null, null, CommonBase.szIniLogFileName);

                for (int i = 0; i < totalProgress; i++) {
                    for (int j = 0; j< local_idx; j++) {

                        if (baseObj.szLocalFiles[j] == baseObj.szTargetFiles[i])
                        {
                            if (baseObj.szLocalChecksum[j] != baseObj.szTargetChecksum[i])
                            {
                                baseObj.szFailFiles.Add("(diff) " + baseObj.szTargetFiles[i]);
                                SetupIniIP.IniWriteValue("Diff", dismatch.ToString(), baseObj.szTargetFiles[i], CommonBase.szIniLogFileName);
                                dismatch++;
                            }
                            else
                            {
                                baseObj.szFailFiles.Add("(match) " + baseObj.szTargetFiles[i]);
                                //SetupIniIP.IniWriteValue("Match", match.ToString(), baseObj.szTargetFiles[i], CommonBase.szIniLogFileName);
                                match++;
                            }
                            break;
                        }
                        else if(j== (local_idx-1) )
                        {
                            baseObj.szFailFiles.Add("(miss)  " + baseObj.szTargetFiles[i]);
                            SetupIniIP.IniWriteValue("Miss", miss.ToString(), baseObj.szTargetFiles[i], CommonBase.szIniLogFileName);
                            miss ++;
                        }
                    }
                    progressReport.PercentComplete = index++ * 100 / totalProgress;
                    progress.Report(progressReport);
                    Thread.Sleep(10);
                }
                
            });
        }

        Task ProcessDetect() {
            return Task.Run(() => {

                InitializeLocalAll();
            });
        }
        private void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                Brush mybsh = Brushes.Black;
               
                if (listBoxStandard.Items[e.Index].ToString().IndexOf("(match) ") != -1)
                {
                    mybsh = Brushes.Green;
                }
                else if (listBoxStandard.Items[e.Index].ToString().IndexOf("(error) ") != -1)
                {
                    mybsh = Brushes.Red;
                }
                else if (listBoxStandard.Items[e.Index].ToString().IndexOf("(miss) ") != -1)
                {
                    mybsh = Brushes.Blue;
                }
                // 焦点框
                e.DrawFocusRectangle();
                //文本 
                e.Graphics.DrawString(listBoxStandard.Items[e.Index].ToString(), e.Font, mybsh, e.Bounds, StringFormat.GenericDefault);
            }
        }

        private async void metroButtonTest_Click(object sender, EventArgs e)
        {
            metroProgressBar1.Value = 0;
            //Init data
            List<string> list = new List<string>();

            for (int i = 0; i < target_idx; i++){
                list.Add(i.ToString());
            }

            var progressReport = new Progress<ProgressReport>();

            progressReport.ProgressChanged += (o, report) =>
            {
                //Update your percentage
                //lblProcess.Text = string.Format("Processing...{0}%", report.PercentComplete);
                metroProgressBar1.Value = report.PercentComplete;
                metroProgressBar1.Update();
            };

            //Process import data
            await ProcessImport(list, progressReport);

            metroLabelDismatchNumber.Text = dismatch.ToString();
            metroLabelMatchNumber.Text = match.ToString();
            metroLabelMissNumber.Text = miss.ToString();

            listBoxStandard.Items.Clear();

            
            List<string> MissFile  = baseObj.szFailFiles.FindAll(x => x.Contains("(miss) "));
            List<string> DiffFile  = baseObj.szFailFiles.FindAll(x => x.Contains("(diff) "));
            List<string> MatchFile = baseObj.szFailFiles.FindAll(x => x.Contains("(match) "));
            List<string> result    = MissFile.Concat(DiffFile).Concat(MatchFile).ToList();
            
            foreach (var item in result) {                
                    listBoxStandard.Items.Add(item);
            }
            
        }

        private void metroCheckBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBoxAll.Checked)
            {
                metroCheckBoxExe.Checked = false;
                metroCheckBoxDll.Checked = false;

                metroCheckBoxExe.Enabled = false;
                metroCheckBoxDll.Enabled = false;
            }
            else {
                metroCheckBoxExe.Enabled = true;
                metroCheckBoxDll.Enabled = true;
            }     
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBoxStandard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxLocal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void metroButtonInit_Click(object sender, EventArgs e)
        {
            local_idx = 0;
            baseObj.szLocalFiles.Clear();
            baseObj.szLocalChecksum.Clear();

            metroButtonDetect.Enabled = false;
            metroButtonExport.Enabled = false;
            metroButtonTest.Enabled = false;

            waitForm.Show(this);

            var detectProgress = new Progress<ProgressReport>();

            listBoxLocal.Items.Clear();

            await ProcessDetect();

            foreach (var item in baseObj.szLocalFiles)
            {
                listBoxLocal.Items.Add(item);
            }

            metroButtonDetect.Enabled = true;
            metroButtonExport.Enabled = true;
            metroButtonTest.Enabled = true;

            waitForm.Close();
            //InitializeLocal();
        }

        private void metroButtonExport_Click(object sender, EventArgs e)
        {
            string fileName = "Export_TemplateName_01";

            if (ExportDialog.InputBox("", "Please enter a valid file name: (.ini)", ref fileName) == DialogResult.OK)
            {
                fileName = fileName + ".ini";

                waitForm.Show(this);
                for (int i = 0; i < local_idx; i++)
                {
                    SetupIniIP.IniWriteValue("Node", baseObj.szLocalFiles[i], baseObj.szLocalChecksum[i], fileName);
                }
                waitForm.Close();
            }
        }

        private void metroButtonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                listBoxStandard.Items.Clear();

                baseObj.szTargetFiles.Clear();
                baseObj.szTargetChecksum.Clear();

                string file = openFileDialog1.FileName;
                try
                {
                    IniFile ini = new IniFile();
                    ini.Load(file);

                    target_idx = 0;

                    foreach (IniSection section in ini.Sections)
                    {
                        foreach (IniKey key in section.Keys)
                        {
                            string sectionName = section.Name;
                            string keyName = key.Name;
                            string keyValue = key.Value;

                            listBoxStandard.Items.Add(keyName);

                            baseObj.szTargetFiles.Add(keyName);
                            baseObj.szTargetChecksum.Add(keyValue);

                            target_idx++;
                        }
                    }
                }
                catch (IOException)
                {
                }
            }
        }

    }
}
