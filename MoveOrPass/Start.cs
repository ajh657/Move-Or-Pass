namespace MoveOrPass
{
    public partial class Start : Form
    {

        private bool CustomClosed = false;

        public Start()
        {
            InitializeComponent();
        }

        private void OpenSourceButton_Click(object sender, EventArgs e)
        {
            folderSourceDialog.ShowDialog();
            textBox1.Text = folderSourceDialog.SelectedPath;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox1.Text) && Directory.Exists(textBox2.Text))
            {
                new MoveOrPass(textBox1.Text, textBox2.Text).Show();
                CustomClosed = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Path is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenDestinationButton_Click(object sender, EventArgs e)
        {
            folderDestinationDialog.ShowDialog();
            textBox2.Text = folderDestinationDialog.SelectedPath;
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((e.CloseReason != CloseReason.FormOwnerClosing || e.CloseReason == CloseReason.MdiFormClosing) && !CustomClosed)
                Application.Exit();
        }
    }
}