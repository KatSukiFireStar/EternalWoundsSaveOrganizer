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
    public partial class SavestateDeleteWindow : Form
    {
        private string originalSaveName = "";

        public SavestateDeleteWindow(string originalSaveName)
        {
            InitializeComponent();
            this.originalSaveName = originalSaveName;
            this.Text = "Delete " + originalSaveName;
            ConfirmationLabel.Text = "Are you sure you want to delete the savestate\n\"" + originalSaveName + "\"?";
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            File.Delete(System.IO.Path.Combine(Properties.Settings.Default.CurrentProfilePath, originalSaveName));
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
