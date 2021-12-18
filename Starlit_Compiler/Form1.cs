using System;
using System.Collections.Generic;
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
            listBoxes = new Dictionary<string, CheckedListBox>()
            {
                { "765AS Commus", checkedListBox1 },
                { "765AS Work+Events", checkedListBox2 },
                { "CG/ML Work+Events", checkedListBox3 },
                { "CG/ML Commus", checkedListBox4 },
                { "SC/Other Work+Events", checkedListBox5 },
                { "SC/Other Commus", checkedListBox6 },
                { "Main Story", checkedListBox7 },
                { "NPC Dialogue+Commus", checkedListBox8 },
                { "Game Events", checkedListBox9 },
                { "Other", checkedListBox10 },
                { "DLC", checkedListBox11 },
            };
            foreach (CommuFile csvMetadata in CommuFile.data)
            {
                CheckedListBox listBox = listBoxes[csvMetadata.Category];
                if (!listBox.Items.Contains(csvMetadata.Label))
                {
                    listBox.Items.Add(csvMetadata.Label);
                }
            }
            foreach (CheckedListBox listBox in listBoxes.Values)
            {
                listBox.CheckOnClick = true;
            }
        }

        private readonly Dictionary<string, CheckedListBox> listBoxes;

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
            DialogResult result = MessageBox.Show("Are you sure you want to download every file?", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 
            if (result != DialogResult.Yes)
            {
                return;
            }
            DisableAllUpdates();
            DownloadFiles(true);
            EnableAllUpdates();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Download selected commus?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result != DialogResult.Yes)
            {
                return;
            }
            DisableAllUpdates();
            DownloadFiles(false);
            EnableAllUpdates();
        }

        private void btnConvertCsv_Click(object sender, EventArgs e)
        {
            Process uiUpdater = new Process();
            uiUpdater.StartInfo.FileName = textBox1.Text + "\\Import_UAsset_Updates.bat";
            if (File.Exists(uiUpdater.StartInfo.FileName))
            {
                DisableAllUpdates();
                uiUpdater.Start();
                uiUpdater.WaitForExit();
                EnableAllUpdates();
            }
            else
            {
                MessageBox.Show("\"Import_UAsset_Updates.bat\" could not be found in the specified workspace directory.",
                    "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            btnConvertCsv.Enabled = false;
        }

        private void EnableAllUpdates()
        {
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            btnConvertCsv.Enabled = true;
        }

        private List<DownloadTask> downloadTasks;

        private async void DownloadFiles(bool downloadAll)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            pnlProgress.Visible = true;
            downloadTasks = new List<DownloadTask>();
            foreach (var csvMetadata in CommuFile.data)
            {
                CheckedListBox listBox = listBoxes[csvMetadata.Category];
                int index = listBox.FindStringExact(csvMetadata.Label);
                if (!string.IsNullOrEmpty(csvMetadata.FileUrl) && 
                    (downloadAll || listBox.GetItemCheckState(index) == CheckState.Checked))
                {
                    DownloadTask downloadTask = new DownloadTask(csvMetadata.FileUrl, textBox1.Text + csvMetadata.FilePath);
                    downloadTask.ProgressChanged += DownloadProgressChanged;
                    downloadTasks.Add(downloadTask);
                }
            }
            await Task.WhenAll(downloadTasks.Select(t => t.Task));
            stopwatch.Stop();
            lblProgress.Text = $"Done!        {lblProgress.Text}        {stopwatch.ElapsedMilliseconds / 1000.0f} seconds";
        }

        private void DownloadProgressChanged()
        {
            int taskCount = downloadTasks.Count;
            int completedCount = downloadTasks.Where(t => t.Completed).Count();
            long received = downloadTasks.Select(t => t.BytesReceived).Sum();
            lblProgress.Text = $"{completedCount}/{taskCount} files        {received / 1024} KB";
            progressBar1.Value = (100 * completedCount) / taskCount;
        }
    }
}
