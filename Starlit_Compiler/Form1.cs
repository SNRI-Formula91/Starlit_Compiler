using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starlit_Compiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if(!string.IsNullOrEmpty(ConfigurationManager.AppSettings["workspacePath"]))
            {
                this.textBox1.Text = ConfigurationManager.AppSettings["workspacePath"];
            }
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["commukitPath"]))
            {
                this.textBox2.Text = ConfigurationManager.AppSettings["commukitPath"];
            }
            checkedListBox1.CheckOnClick = true;
            checkedListBox2.CheckOnClick = true;
            checkedListBox3.CheckOnClick = true;
            checkedListBox4.CheckOnClick = true;
            checkedListBox5.CheckOnClick = true;
            checkedListBox6.CheckOnClick = true;
            checkedListBox7.CheckOnClick = true;
            checkedListBox8.CheckOnClick = true;
            checkedListBox9.CheckOnClick = true;
            checkedListBox10.CheckOnClick = true;
            checkedListBox11.CheckOnClick = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            workspacePathDialogue = new FolderBrowserDialog
            {
                Description = "Select the folder containing the translation workspace.",
                RootFolder = Environment.SpecialFolder.Desktop,
                ShowNewFolderButton = false
            };
            if (workspacePathDialogue.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = workspacePathDialogue.SelectedPath;
                UpdateConfigs("workspacePath", workspacePathDialogue.SelectedPath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            commukitPathDialogue = new FolderBrowserDialog
            {
                Description = "Select the folder containing the Commu-Kit.",
                RootFolder = Environment.SpecialFolder.Desktop,
                ShowNewFolderButton = false
            };
            if (commukitPathDialogue.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = commukitPathDialogue.SelectedPath;
                UpdateConfigs("commukitPath", commukitPathDialogue.SelectedPath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string FullUpdaterPath = textBox1.Text + "\\FullUpdate.bat";
            string EngPatchPath = textBox1.Text + "\\Export_EngPatch.bat";
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to update every file?", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Process fullUpdater = new Process();
                fullUpdater.StartInfo.FileName = FullUpdaterPath;
                if (File.Exists(fullUpdater.StartInfo.FileName) && File.Exists(EngPatchPath))
                {
                    DisableAllUpdates();
                    fullUpdater.Start();
                    fullUpdater.WaitForExit();
                    EnableAllUpdates();
                }
                else
                {
                    MessageBox.Show("\"FullUpdate.bat\" could not be found in the specified workspace directory.",
                        "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (!File.Exists(EngPatchPath))
                    {
                        MessageBox.Show("\"Export_EngPatch.bat\" could not be found in the specified workspace directory.",
                            "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string EngPatchPath = textBox1.Text + "\\Export_EngPatch.bat";
            DialogResult result;
            result = MessageBox.Show("Do you want to proceed?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string TempBatchPath = textBox1.Text + "\\TempUpdate.bat";
                if (File.Exists(EngPatchPath))
                {
                    DisableAllUpdates();
                    CreateTempBatch(TempBatchPath);
                    /*Process quickUpdater = new Process();
                    quickUpdater.StartInfo.FileName = TempBatchPath;
                    quickUpdater.Start();
                    quickUpdater.WaitForExit();*/
                    //File.Delete(TempBatchPath);
                    EnableAllUpdates();
                }
                else
                {
                    MessageBox.Show("\"Export_EngPatch.bat\" could not be found in the specified workspace directory.",
                            "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process uiUpdater = new Process();
            uiUpdater.StartInfo.FileName = textBox1.Text+"\\Export_EngPatch.bat";
            if(File.Exists(uiUpdater.StartInfo.FileName))
            {
                DisableAllUpdates();
                uiUpdater.Start();
                uiUpdater.WaitForExit();
                EnableAllUpdates();
            }
            else
            {
                MessageBox.Show("\"Export_EngPatch.bat\" could not be found in the specified workspace directory.", 
                    "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateConfigs(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            settings[key].Value = value;
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox4.Items.Count; i++)
            {
                checkedListBox4.SetItemChecked(i, true);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox6.Items.Count; i++)
            {
                checkedListBox6.SetItemChecked(i, true);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox7.Items.Count; i++)
            {
                checkedListBox7.SetItemChecked(i, true);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox9.Items.Count; i++)
            {
                checkedListBox9.SetItemChecked(i, true);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox11.Items.Count; i++)
            {
                checkedListBox11.SetItemChecked(i, true);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, true);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox3.Items.Count; i++)
            {
                checkedListBox3.SetItemChecked(i, true);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox5.Items.Count; i++)
            {
                checkedListBox5.SetItemChecked(i, true);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox8.Items.Count; i++)
            {
                checkedListBox8.SetItemChecked(i, true);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox10.Items.Count; i++)
            {
                checkedListBox10.SetItemChecked(i, true);
            }
        }

        private void DisableAllUpdates()
        {
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void EnableAllUpdates()
        {
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void CreateTempBatch(string path)
        {
            using (StreamWriter quickUpdater = new StreamWriter(path))
            {
                quickUpdater.WriteLine("@echo on");
                quickUpdater.WriteLine("call: QUICK_UPDATE > \"%cd%\\quick_update.log\"");
                quickUpdater.WriteLine("exit /B");
                quickUpdater.WriteLine("");
                quickUpdater.WriteLine(":QUICK_UPDATE");
                quickUpdater.WriteLine("ECHO Downloading Commu files... &ECHO.");

                foreach (CommuFile checkedItem in checkedListBox1.CheckedItems)
                {
                    quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + checkedItem.FilePath + "\" \"" + checkedItem.FileUrl + "\"");
                }
                foreach (CommuFile checkedItem in checkedListBox2.CheckedItems)
                {
                    quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + checkedItem.FilePath + "\" \"" + checkedItem.FileUrl + "\"");
                }
                foreach (CommuFile checkedItem in checkedListBox3.CheckedItems)
                {
                    if (checkedItem.FileUrl != "NULL")
                    {
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + checkedItem.FilePath + "\" \"" + checkedItem.FileUrl + "\"");
                    }
                }
                foreach (CommuFile checkedItem in checkedListBox4.CheckedItems)
                {
                    if (checkedItem.FileUrl != "NULL")
                    {
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + checkedItem.FilePath + "\" \"" + checkedItem.FileUrl + "\"");
                    }
                }
                foreach (CommuFile checkedItem in checkedListBox5.CheckedItems)
                {
                    if (checkedItem.FileUrl != "NULL")
                    {
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + checkedItem.FilePath + "\" \"" + checkedItem.FileUrl + "\"");
                    }
                }
                foreach (CommuFile checkedItem in checkedListBox6.CheckedItems)
                {
                    if (checkedItem.FileUrl != "NULL")
                    {
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + checkedItem.FilePath + "\" \"" + checkedItem.FileUrl + "\"");
                    }
                }
                foreach (CommuFile checkedItem in checkedListBox7.CheckedItems)
                {
                    quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + checkedItem.FilePath + "\" \"" + checkedItem.FileUrl + "\"");
                }
                foreach (CommuFile checkedItem in checkedListBox8.CheckedItems)
                {
                    quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + checkedItem.FilePath + "\" \"" + checkedItem.FileUrl + "\"");
                }
                foreach (CommuFile checkedItem in checkedListBox9.CheckedItems)
                {
                    quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + checkedItem.FilePath + "\" \"" + checkedItem.FileUrl + "\"");
                }
                foreach (CommuFile checkedItem in checkedListBox10.CheckedItems)
                {
                    if (checkedItem.FileUrl == "NONE")
                    {
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\CML_GameOver000.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vQGJB6boiekTXPP801pBPenajqjkuOt4nn57OUuEMDyP0dhq-dMD2BhEowN1VrKWffmWg0BZ2EJ7ajZ/pub?gid=0&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0004_02.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=1715384074&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0004_03.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=1371257039&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0004_04.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=369414826&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0005_01.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=1972035438&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0005_02.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=278063590&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0005_03.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=72203270&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0005_04.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=334270960&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0006_01.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=2130778494&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0006_02.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=1750001407&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0006_03.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=65550961&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0006_04.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=1402478348&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0007_01.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=2112872985&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0007_02.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=15844309&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0007_03.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=832510217&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0007_04.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=1872157724&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0008_03.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=418733638&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0008_04.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vRl5KECNBZKurkdHkVciJBBWhzdytJx-6XDrWPpL_5d96WrD__X9ipgzWlVSAJB4PeKI98WKTHtLBjq/pub?gid=1365967696&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0009_01.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=2132832283&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0009_02.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=673985233&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0009_03.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=382643967&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0009_04.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=1603267711&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0010_01.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=1862052712&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0010_02.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=327389709&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0010_03.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=913908743&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0010_04.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=774690158&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0011_01.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=1883115183&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0011_02.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=821216063&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0011_03.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=44231773&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0011_04.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=2030580429&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0012_01.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=1289683929&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0012_02.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=209331563&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0012_03.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=684839089&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Badend\\CML_GameOver_04_0012_04.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vTEu7iQTh2EOtKhpRJIrSZZvOwy6dI9pYWw1ABGFdOXE_p8T-1uf7uoPw4VHllRXP3Mei0dOcO2pLwl/pub?gid=1260893778&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Order\\CML_GameOver_02_0000_00.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vQGJB6boiekTXPP801pBPenajqjkuOt4nn57OUuEMDyP0dhq-dMD2BhEowN1VrKWffmWg0BZ2EJ7ajZ/pub?gid=1439123824&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Order\\CML_GameOver_02_0001_00.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vQGJB6boiekTXPP801pBPenajqjkuOt4nn57OUuEMDyP0dhq-dMD2BhEowN1VrKWffmWg0BZ2EJ7ajZ/pub?gid=1009020609&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Stage\\CML_GameOver_03_0000_00.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vQGJB6boiekTXPP801pBPenajqjkuOt4nn57OUuEMDyP0dhq-dMD2BhEowN1VrKWffmWg0BZ2EJ7ajZ/pub?gid=1441533144&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Stage\\CML_GameOver_03_0001_00.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vQGJB6boiekTXPP801pBPenajqjkuOt4nn57OUuEMDyP0dhq-dMD2BhEowN1VrKWffmWg0BZ2EJ7ajZ/pub?gid=311404926&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Stage\\CML_GameOver_03_0002_00.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vQGJB6boiekTXPP801pBPenajqjkuOt4nn57OUuEMDyP0dhq-dMD2BhEowN1VrKWffmWg0BZ2EJ7ajZ/pub?gid=319751758&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Stage\\CML_GameOver_03_0003_00.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vQGJB6boiekTXPP801pBPenajqjkuOt4nn57OUuEMDyP0dhq-dMD2BhEowN1VrKWffmWg0BZ2EJ7ajZ/pub?gid=1674256&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Stage\\CML_GameOver_03_0004_00.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vQGJB6boiekTXPP801pBPenajqjkuOt4nn57OUuEMDyP0dhq-dMD2BhEowN1VrKWffmWg0BZ2EJ7ajZ/pub?gid=455608798&single=true&output=csv\"");
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\Task\\CML_GameOver_01_0000_00.csv\" \"https://docs.google.com/spreadsheets/d/e/2PACX-1vQGJB6boiekTXPP801pBPenajqjkuOt4nn57OUuEMDyP0dhq-dMD2BhEowN1VrKWffmWg0BZ2EJ7ajZ/pub?gid=983473035&single=true&output=csv\"");
                    }
                    else
                    {
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + checkedItem.FilePath + "\" \"" + checkedItem.FileUrl + "\"");
                    }
                }
                foreach (CommuFile checkedItem in checkedListBox11.CheckedItems)
                {
                    if (checkedItem.FileUrl != "NULL")
                    {
                        quickUpdater.WriteLine("curl -L -o \"" + textBox1.Text + checkedItem.FilePath + "\" \"" + checkedItem.FileUrl + "\"");
                    }
                }

                quickUpdater.WriteLine("ECHO Importing Commu translations... &ECHO.");
                quickUpdater.WriteLine("call Import_UAsset_Updates.bat");
                quickUpdater.WriteLine("ECHO Updating UI and creating mods... &ECHO.");
                quickUpdater.WriteLine("call Export_EngPatch.bat");
            }
        }
    }
}
