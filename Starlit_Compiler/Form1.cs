using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Starlit_Compiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WorkspacePath = ConfigurationManager.AppSettings["workspacePath"];
            CommuKitPath = ConfigurationManager.AppSettings["commukitPath"];
            checkLists = new Dictionary<string, MultiCheckList>();
            InitialiseCheckLists(CommuFile.data);
        }

        private void InitialiseCheckLists(IEnumerable<CommuFile> csvMetadatas)
        {
            foreach (var multiCheckList in checkLists.Values)
            {
                flowLayoutPanel1.Controls.Remove(multiCheckList);
                multiCheckList.Dispose();
            }
            checkLists.Clear();
            foreach (CommuFile csvMetadata in csvMetadatas)
            {
                bool hasValue = checkLists.TryGetValue(csvMetadata.Category, out MultiCheckList multiCheckList);
                if (!hasValue)
                {
                    multiCheckList = new MultiCheckList() { Title = csvMetadata.Category };
                    checkLists.Add(csvMetadata.Category, multiCheckList);
                    flowLayoutPanel1.Controls.Add(multiCheckList);
                }
                if (!multiCheckList.Items.Contains(csvMetadata.Label))
                {
                    multiCheckList.Items.Add(csvMetadata.Label);
                }
            }
        }

        private string WorkspacePath
        {
            get => textBox1.Text;
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                textBox1.Text = value;
                UpdateConfigs("workspacePath", value);
            }
        }
        private string CommuKitPath
        {
            get => textBox2.Text;
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                textBox2.Text = value;
                UpdateConfigs("commukitPath", value);
            }
        }
        private readonly Dictionary<string, MultiCheckList> checkLists;

        private void button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog("Select translation workspace folder.")
            {
                IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                WorkspacePath = dialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog("Select Commu-Kit folder.")
            {
                IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                CommuKitPath = dialog.FileName;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to download every file?", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 
            if (result != DialogResult.Yes)
            {
                return;
            }
            DisableAllUpdates();
            await DownloadFiles(true);
            EnableAllUpdates();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Download selected commus?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result != DialogResult.Yes)
            {
                return;
            }
            DisableAllUpdates();
            await DownloadFiles(false);
            EnableAllUpdates();
        }

        private void btnConvertCsv_Click(object sender, EventArgs e)
        {
            RunBatchFile("Import_UAsset_Updates.bat");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RunBatchFile("Export_EngPatch.bat");
        }

        private async void BtnFetchMetadata_Click(object sender, EventArgs e)
        {
            DisableAllUpdates();
            await FetchMetadata();
            EnableAllUpdates();
        }

        private async Task FetchMetadata()
        {
            string csvData;
            using (var webClient = new System.Net.WebClient())
            {
                csvData = await webClient.DownloadStringTaskAsync("https://docs.google.com/spreadsheets/d/e/2PACX-1vRWmIqtwbGay6DKz64lY3oz3ttQkXt0j7hOsWGrV3K_AmTATOyzVPm1CPc9jx86WWh4mAUEWNjw18ee/pub?gid=0&single=true&output=csv");
            }
            using (var reader = new StringReader(csvData))
            {
                using (var csvReader = new CsvHelper.CsvReader(
                    reader,
                    new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture) { MissingFieldFound = null }
                    ))
                {
                    var data = csvReader.GetRecords<CommuFile>();
                    InitialiseCheckLists(data);
                }
            }
        }

        private void RunBatchFile(string batchPath)
        {
            Process uiUpdater = new Process();
            uiUpdater.StartInfo.FileName = $"{WorkspacePath}\\{batchPath}";
            if (File.Exists(uiUpdater.StartInfo.FileName))
            {
                DisableAllUpdates();
                uiUpdater.Start();
                uiUpdater.WaitForExit();
                EnableAllUpdates();
            }
            else
            {
                MessageBox.Show($"{batchPath} could not be found in the specified workspace directory.",
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

        private void DisableAllUpdates()
        {
            Enabled = false;
        }

        private void EnableAllUpdates()
        {
            Enabled = true;
        }

        private async Task DownloadFiles(bool downloadAll)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<DownloadTask> downloadTasks = new List<DownloadTask>();
            foreach (var csvMetadata in CommuFile.data)
            {
                MultiCheckList checkList = checkLists[csvMetadata.Category];
                if (!string.IsNullOrEmpty(csvMetadata.FileUrl) && 
                    (downloadAll || checkList.IsChecked(csvMetadata.Label)))
                {
                    DownloadTask downloadTask = new DownloadTask(csvMetadata.FileUrl, WorkspacePath + csvMetadata.FilePath);
                    downloadTask.ProgressChanged += () => DownloadProgressChanged(downloadTasks);
                    downloadTasks.Add(downloadTask);
                }
            }
            await Task.WhenAll(downloadTasks.Select(t => t.Task));
            foreach (var downloadTask in downloadTasks)
            {
                downloadTask.Dispose();
            }
            stopwatch.Stop();
            progressLabel.Text = $"Done!        {progressLabel.Text}        {stopwatch.ElapsedMilliseconds / 1000.0f} seconds";
        }

        private void DownloadProgressChanged(List<DownloadTask> downloadTasks)
        {
            int taskCount = downloadTasks.Count;
            int completedCount = downloadTasks.Where(t => t.Completed).Count();
            long received = downloadTasks.Select(t => t.BytesReceived).Sum();
            progressLabel.Text = $"{completedCount}/{taskCount} files        {received / 1024} KB";
            progressBar.Value = 100 * completedCount / taskCount;
        }
    }
}
