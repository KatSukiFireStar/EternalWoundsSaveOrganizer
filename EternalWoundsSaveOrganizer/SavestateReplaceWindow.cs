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
    public partial class SavestateReplaceWindow : Form
    {
        private string originalSaveName = "";

        public SavestateReplaceWindow(string originalSaveName)
        {
            InitializeComponent();
            this.originalSaveName = originalSaveName;
            this.Text = "Replace " + originalSaveName;
            ConfirmationLabel.Text = "Are you sure you want to replace the savestate\n\"" + originalSaveName + "\"?";
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            File.Copy(Properties.Settings.Default.SaveLocation,
                System.IO.Path.Combine(Properties.Settings.Default.CurrentProfilePath, originalSaveName), true);
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
