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
    public partial class NameProfileWindow : Form
    {
        public NameProfileWindow()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ProfileNameText.Text) && !Properties.Settings.Default.Profiles.Contains(ProfileNameText.Text))
            {
                Properties.Settings.Default.Profiles.Add(ProfileNameText.Text);
                Directory.CreateDirectory(System.IO.Path.Combine(Properties.Settings.Default.ProfileDirectory, ProfileNameText.Text));
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
