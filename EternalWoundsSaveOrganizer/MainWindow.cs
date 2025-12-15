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
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ProfileWindow w = new ProfileWindow();
            this.AddOwnedForm(w);
            w.ShowDialog();
        }

        private void UpdateProfileList()
        {
            DropDownProfile.Items.Clear();
            foreach (string s in Properties.Settings.Default.Profiles)
            {
                DropDownProfile.Items.Add(s);
            }
            DropDownProfile.SelectedIndex = 0;
        }

        private void DropDownProfile_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Handle profile change logic here
        }
    }
}
