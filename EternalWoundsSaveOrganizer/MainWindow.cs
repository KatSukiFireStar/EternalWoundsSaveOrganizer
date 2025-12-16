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

            if (SaveList.SelectedItems.Count == 0)
            {
                ChangeActiveButton(false);
            }
            SaveList.SelectedIndexChanged += SaveList_SelectedIndexChanged;
        }

        private void SaveList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (SaveList.SelectedItems.Count == 0)
            {
                ChangeActiveButton(false);
            }
            else
            {
                ChangeActiveButton(true);
            }
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ProfileWindow w = new ProfileWindow();
            w.FormClosed += (s, args) => { UpdateProfileList(); };
            w.ShowDialog();
            ChangeActiveButton(false);
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
            if (String.IsNullOrEmpty(Properties.Settings.Default.CurrentProfilePath) || !Directory.Exists(Properties.Settings.Default.CurrentProfilePath))
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

            SavestateDeleteWindow w = new SavestateDeleteWindow(name!);
            w.FormClosed += (s, args) => { ReloadSaveList(); };
            w.ShowDialog();
            ChangeActiveButton(false);
        }

        private void ChangeActiveButton(bool active)
        {
            LoadButton.Enabled = active;
            Replace.Enabled = active;
            EditSaveName.Enabled = active;
            Delete.Enabled = active;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (SaveList.SelectedItems.Count == 0)
                return;

            string? name = SaveList.SelectedItems?[0]?.ToString();

            File.Copy(System.IO.Path.Combine(Properties.Settings.Default.CurrentProfilePath, name!),
                Properties.Settings.Default.SaveLocation, true);
            
            MessageBox.Show("Save load successfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            if (SaveList.SelectedItems.Count == 0)
                return;

            string? name = SaveList.SelectedItems?[0]?.ToString();
            SavestateReplaceWindow w = new SavestateReplaceWindow(name!);
            w.FormClosed += (s, args) => { ReloadSaveList(); };
            w.ShowDialog();
            ChangeActiveButton(false);
        }

        private void EditSaveName_Click(object sender, EventArgs e)
        {
            if (SaveList.SelectedItems.Count == 0)
                return;

            string? name = SaveList.SelectedItems?[0]?.ToString();
            SavestateEditNameWindow w = new SavestateEditNameWindow(name!);
            w.FormClosed += (s, args) => { ReloadSaveList(); };
            w.ShowDialog();
            ChangeActiveButton(false);
        }
    }
}
