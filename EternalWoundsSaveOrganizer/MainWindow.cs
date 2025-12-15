namespace EternalWoundsSaveOrganizer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ProfileWindow w = new ProfileWindow();
            this.AddOwnedForm(w);
            w.ShowDialog();
        }
    }
}
