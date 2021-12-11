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
            Process fullUpdater = new Process();
            fullUpdater.StartInfo.FileName = textBox1.Text + "\\FullUpdate.bat";
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to update every file?", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (File.Exists(fullUpdater.StartInfo.FileName))
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
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisableAllUpdates();
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
            //button4.Enabled = true;
            button5.Enabled = true;
        }
    }
}
