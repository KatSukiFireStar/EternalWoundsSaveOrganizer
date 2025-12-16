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
    public partial class SavestateEditNameWindow : Form
    {
        private string originalSaveName = "";

        public SavestateEditNameWindow(string originalSaveName)
        {
            InitializeComponent();
            this.originalSaveName = originalSaveName;
            this.Text = "Edit " + originalSaveName;
            SaveNameText.Text = originalSaveName;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SaveNameText.Text))
            {
                List<string> filesPath = Directory.GetFiles(Properties.Settings.Default.CurrentProfilePath).ToList();

                List<string> files = new();
                foreach (var file in filesPath)
                {
                    files.Add(System.IO.Path.GetFileName(file));
                }

                if (!files.Contains(SaveNameText.Text))
                {
                    File.Move(
                        System.IO.Path.Combine(Properties.Settings.Default.CurrentProfilePath, originalSaveName),
                        System.IO.Path.Combine(Properties.Settings.Default.CurrentProfilePath, SaveNameText.Text)
                    );
                }
                else
                {
                    MessageBox.Show("This name already exist !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
