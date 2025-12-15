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

            if (Properties.Settings.Default.Profiles != null)
                PrintProfiles();
            else
                Properties.Settings.Default.Profiles = new();
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
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void NewProfileButton_Click(object sender, EventArgs e)
        {
            NameProfileWindow w = new NameProfileWindow();
            if(w.ShowDialog() == DialogResult.OK)
            {
                PrintProfiles();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Profiles.Remove(ProfileList.SelectedItems[0].Text);
            Properties.Settings.Default.Save();
            PrintProfiles();
        }

        private void PrintProfiles()
        {
            ProfileList.Items.Clear();
            foreach (string s in Properties.Settings.Default.Profiles)
            {
                ProfileList.Items.Add(s);
            }
        }
    }
}
