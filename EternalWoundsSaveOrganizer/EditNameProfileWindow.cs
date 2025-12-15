using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EternalWoundsSaveOrganizer
{
    public partial class EditNameProfileWindow : Form
    {
        private string originalProfileName = "";

        public EditNameProfileWindow(string originalProfileName)
        {
            InitializeComponent();
            this.originalProfileName = originalProfileName;
            this.Text = "Edit " + originalProfileName;
            ProfileNameText.Text = originalProfileName;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ProfileNameText.Text) && !Properties.Settings.Default.Profiles.Contains(ProfileNameText.Text))
            {
                for(int i = 0; i < Properties.Settings.Default.Profiles.Count; i++)
                {
                    if (Properties.Settings.Default.Profiles[i] == originalProfileName)
                    {
                        Properties.Settings.Default.Profiles[i] = ProfileNameText.Text;
                        break;
                    }
                }
                Properties.Settings.Default.Save();
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
