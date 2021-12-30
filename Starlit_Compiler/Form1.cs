using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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
            txtMetadataUrl.Text = ConfigurationManager.AppSettings["metadataUrl"];
            CsvMetadataString = ConfigurationManager.AppSettings["csvMetadata"];
            checkLists = new Dictionary<string, MultiCheckList>();
            try
            {
                ConvertMetadataStringToArray(CsvMetadataString);
            }
            catch
            {
                CsvMetadataString = "";
                csvMetadata = new CommuFile[] { };
            }
            InitialiseCheckListsFromArray();
        }

        private void ConvertMetadataStringToArray(string metadataString)
        {
            using (var reader = new StringReader(metadataString))
            {
                using (var csvReader = new CsvHelper.CsvReader(
                    reader,
                    new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture) { MissingFieldFound = null }
                    ))
                {
                    csvMetadata = csvReader.GetRecords<CommuFile>().ToArray();
                }
            }
        }

        private void InitialiseCheckListsFromArray()
        {
            foreach (var multiCheckList in checkLists.Values)
            {
                flowLayoutPanel1.Controls.Remove(multiCheckList);
                multiCheckList.Dispose();
            }
            checkLists.Clear();
            foreach (CommuFile record in csvMetadata)
            {
                if (urlRegex.IsMatch(record.FileUrl))
                {
                    bool hasValue = checkLists.TryGetValue(record.Category, out MultiCheckList multiCheckList);
                    if (!hasValue)
                    {
                        multiCheckList = new MultiCheckList() { Title = record.Category };
                        checkLists.Add(record.Category, multiCheckList);
                        flowLayoutPanel1.Controls.Add(multiCheckList);
                    }
                    if (!multiCheckList.Items.Contains(record.Label))
                    {
                        multiCheckList.Items.Add(record.Label);
                    }
                }
            }
        }

        private readonly Regex urlRegex = new Regex(@"^https://docs.google.com/spreadsheets/d/e/[0-9A-Za-z\-_]{86}/pub\?gid=[0-9]+&single=true&output=csv$");

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

        private string MetadataUrl => txtMetadataUrl.Text;
        private bool MetadataUrlIsValid => urlRegex.IsMatch(MetadataUrl);

        private string csvMetadataString;
        private string CsvMetadataString
        {
            get => csvMetadataString;
            set
            {
                csvMetadataString = value;
                UpdateConfigs("csvMetadata", value);
            }
        }
        private CommuFile[] csvMetadata;
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

        private void TxtMetadataUrl_TextChanged(object sender, EventArgs e)
        {
            txtMetadataUrl.ForeColor = MetadataUrlIsValid ? System.Drawing.SystemColors.WindowText : System.Drawing.SystemColors.GrayText;
            btnFetchMetadata.Enabled = MetadataUrlIsValid;
        }

        private async void BtnFetchMetadata_Click(object sender, EventArgs e)
        {
            if (MetadataUrlIsValid)
            {
                DisableAllUpdates();
                progressLabel.Text = "Fetching metadata...";
                await FetchMetadata();
                UpdateConfigs("metadataUrl", MetadataUrl);
                progressLabel.Text = "Finished fetching metadata.";
                EnableAllUpdates();
            }
        }

        private async Task FetchMetadata()
        {
            string metadataString;
            using (var webClient = new System.Net.WebClient())
            {
                metadataString = await webClient.DownloadStringTaskAsync(MetadataUrl);
            }
            try
            {
                ConvertMetadataStringToArray(metadataString);
                CsvMetadataString = metadataString;
                InitialiseCheckListsFromArray();
            }
            catch (CsvHelper.BadDataException)
            {
                MessageBox.Show($"Downloaded metadata could not be successfully parsed.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            foreach (CommuFile record in csvMetadata)
            {
                MultiCheckList checkList = checkLists[record.Category];
                if (downloadAll || checkList.IsChecked(record.Label))
                {
                    DownloadTask downloadTask = new DownloadTask(record.FileUrl, WorkspacePath + record.FilePath);
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
