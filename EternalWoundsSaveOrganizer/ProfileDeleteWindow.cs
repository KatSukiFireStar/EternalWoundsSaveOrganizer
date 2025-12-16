using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EternalWoundsSaveOrganizer
{
    public partial class ProfileDeleteWindow : Form
    {
        private string originalProfileName = "";

        public ProfileDeleteWindow(string originalProfileName)
        {
            InitializeComponent();
            this.originalProfileName = originalProfileName;
            this.Text = "Delete " + originalProfileName;
            ConfirmationLabel.Text = "Are you sure you want to delete the profile\n\"" + originalProfileName + "\"?";
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Profiles.Remove(originalProfileName);
            Directory.Delete(System.IO.Path.Combine(Properties.Settings.Default.ProfileDirectory, originalProfileName), true);
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
