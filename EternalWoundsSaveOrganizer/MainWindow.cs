namespace EternalWoundsSaveOrganizer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Profiles != null)
                UpdateProfileList();
            else
                Properties.Settings.Default.Profiles = new();

            DropDownProfile.SelectedIndexChanged += DropDownProfile_SelectedIndexChanged;
            ReloadSaveList();

            if(SaveList.SelectedItems.Count == 0)
            {
                LoadButton.Enabled = false;
                Replace.Enabled = false;
                EditSaveName.Enabled = false;
                Delete.Enabled = false;
            }
            SaveList.SelectedIndexChanged += SaveList_SelectedIndexChanged;
        }

        private void SaveList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (SaveList.SelectedItems.Count == 0)
            {
                LoadButton.Enabled = false;
                Replace.Enabled = false;
                EditSaveName.Enabled = false;
                Delete.Enabled = false;
            }
            else
            {
                LoadButton.Enabled = true;
                Replace.Enabled = true;
                EditSaveName.Enabled = true;
                Delete.Enabled = true;
            }
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ProfileWindow w = new ProfileWindow();
            this.AddOwnedForm(w);
            w.FormClosed += (s, args) => { UpdateProfileList(); };
            w.ShowDialog();
            LoadButton.Enabled = false;
            Replace.Enabled = false;
            EditSaveName.Enabled = false;
            Delete.Enabled = false;
        }

        private void UpdateProfileList()
        {
            DropDownProfile.Items.Clear();
            DropDownProfile.Text = "";
            if (Properties.Settings.Default.Profiles.Count == 0)
                return;

            foreach (string? s in Properties.Settings.Default.Profiles)
            {
                DropDownProfile.Items.Add(s!);
            }
            DropDownProfile.SelectedIndex = 0;
        }

        private void DropDownProfile_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string itemName = DropDownProfile.Items[DropDownProfile.SelectedIndex]!.ToString()!;

            Properties.Settings.Default.CurrentProfilePath = System.IO.Path.Combine(Properties.Settings.Default.ProfileDirectory, itemName);
            Properties.Settings.Default.Save();
            ReloadSaveList();
        }

        private void ReloadSaveList()
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.CurrentProfilePath))
                return;

            SaveList.Items.Clear();
            foreach (var item in Directory.GetFiles(Properties.Settings.Default.CurrentProfilePath))
            {
                SaveList.Items.Add(System.IO.Path.GetFileName(item));
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            string defaultSaveName = System.IO.Path.GetFileName(Properties.Settings.Default.SaveLocation);
            string saveName = defaultSaveName;
            int i = 0;

            List<string> filesPath = Directory.GetFiles(Properties.Settings.Default.CurrentProfilePath).ToList();

            List<string> files = new();
            foreach (var file in filesPath)
            {
                files.Add(System.IO.Path.GetFileName(file));
            }

            while (files.Contains(saveName))
            {
                saveName = defaultSaveName + "_" + i;
                i++;
            }

            File.Copy(Properties.Settings.Default.SaveLocation,
                System.IO.Path.Combine(Properties.Settings.Default.CurrentProfilePath, saveName), false);
            UpdateProfileList();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (SaveList.SelectedItems.Count == 0)
                return;

            string? name = SaveList.SelectedItems?[0]?.ToString();
            File.Delete(System.IO.Path.Combine(Properties.Settings.Default.CurrentProfilePath, name!));
            ReloadSaveList();
            LoadButton.Enabled = false;
            Replace.Enabled = false;
            EditSaveName.Enabled = false;
            Delete.Enabled = false;
        }
    }
}
