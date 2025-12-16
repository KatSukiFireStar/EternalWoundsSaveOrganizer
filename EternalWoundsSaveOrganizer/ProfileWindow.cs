using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EternalWoundsSaveOrganizer
{
    public partial class ProfileWindow : Form
    {
        public ProfileWindow()
        {
            InitializeComponent();
            SaveLocation.Text = Properties.Settings.Default.SaveLocation;
            ProfileDirectory.Text = Properties.Settings.Default.ProfileDirectory;

            if(String.IsNullOrEmpty(Properties.Settings.Default.ProfileDirectory))
            {
                NewProfileButton.Enabled = false;
            }
            CheckSelection();


            if (Properties.Settings.Default.Profiles != null)
                PrintProfiles();
            else
                Properties.Settings.Default.Profiles = new();

            ProfileList.SelectedIndexChanged += ProfileList_SelectedIndexChanged;
        }

        private void CheckSelection()
        {
            if (ProfileList.SelectedItems.Count == 0)
            {
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
            else
            {
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
        }

        private void ProfileList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            CheckSelection();
        }

        private void BrowseSaveButton_Click(object sender, EventArgs e)
        {
            string filePath = "";

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((filePath = fileDialog.FileName) != null)
                {
                    SaveLocation.Text = filePath;
                    Properties.Settings.Default.SaveLocation = filePath;
                    Properties.Settings.Default.Save();
                }
            }
            CheckSelection();
        }

        private void BrowseProfileButton_Click(object sender, EventArgs e)
        {
            string folderPath = "";

            FolderBrowserDialog fileDialog = new FolderBrowserDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((folderPath = fileDialog.SelectedPath) != null)
                {
                    ProfileDirectory.Text = folderPath;
                    Properties.Settings.Default.ProfileDirectory = folderPath;
                    
                    Properties.Settings.Default.Profiles.Clear();
                    foreach (string dir in Directory.EnumerateDirectories(folderPath))
                    {
                        string name = Path.GetFileName(dir);
                        Properties.Settings.Default.Profiles.Add(name);
                    }

                    Properties.Settings.Default.Save();
                    NewProfileButton.Enabled = true;
                    PrintProfiles();
                }
            }
            CheckSelection();
        }

        private void NewProfileButton_Click(object sender, EventArgs e)
        {
            NameProfileWindow w = new NameProfileWindow();
            w.FormClosed += (s, args) => { PrintProfiles(); };
            w.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ProfileList.SelectedItems.Count == 0)
                return;

            var item = ProfileList.SelectedItems[0];
            EditNameProfileWindow w = new EditNameProfileWindow(item?.ToString()!);            
            w.FormClosed += (s, args) => { PrintProfiles(); };
            w.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProfileList.SelectedItems.Count == 0)
                return;

            string? name = ProfileList.SelectedItems?[0]?.ToString();

            ProfileDeleteWindow w = new ProfileDeleteWindow(name!);
            w.FormClosed += (s, args) => { PrintProfiles(); };
            w.ShowDialog();
        }

        private void PrintProfiles()
        {
            ProfileList.Items.Clear();
            foreach (string? s in Properties.Settings.Default.Profiles)
            {
                ProfileList.Items.Add(s!);
            }
            CheckSelection();
        }
    }
}
