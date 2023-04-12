using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveOrPass
{
    public partial class MoveOrPass : Form
    {
        private readonly string fileSourcePath;
        private readonly string fileDestinationPath;

        private FileInfo[] files = new FileInfo[0];
        private readonly List<FileInfo> filesMoved = new();
        private int filesPassed = 0;
        private int index = 0;
        private int fileCount = 0;
        private bool CustomClosed = false;


        public MoveOrPass(string fileSourcePath, string fileDestinationPath)
        {
            InitializeComponent();
            this.fileSourcePath = fileSourcePath;
            this.fileDestinationPath = fileDestinationPath;
            InitFileInfos();
            InitImage();
        }

        private void MoveOrPass_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    filesMoved.Add(files[index]);
                    index++;
                    InitImage();
                    break;
                case Keys.Right:
                    filesPassed++;
                    index++;
                    InitImage();
                    break;
                default:
                    break;
            }
        }

        private void InitImage()
        {
            toolStripMovedLabel.Text = $"Moved: {filesMoved.Count}/{fileCount}";
            toolStripPassedLabel.Text = $"Passed: {filesPassed}/{fileCount}";

            toolStripProgressBar1.Value = filesMoved.Count + filesPassed;

            if (index != files.Length)
            {
                textBox1.Text = files[index].Name;
                ShowImageOnPictureBox(this.files[index]);
            }
            else
            {
                new Mover(filesMoved, fileDestinationPath).Show();
                CustomClosed = true;
                this.Close();
            }

        }

        private void InitFileInfos()
        {
            files = new DirectoryInfo(fileSourcePath).GetFiles();
            fileCount = files.Length;
            toolStripProgressBar1.Maximum = fileCount;
        }

        private void ShowImageOnPictureBox(FileInfo info)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            if (IsImageValid(info)) pictureBox1.Image = new Bitmap(info.FullName);
        }

        private bool IsImageValid(FileInfo info)
        {
            try
            {
                var image = new Bitmap(info.FullName);
                if (image == null) return false;
                image.Dispose();
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void MoveOrPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((e.CloseReason != CloseReason.FormOwnerClosing || e.CloseReason == CloseReason.MdiFormClosing) && !CustomClosed)
                Application.Exit();
        }
    }
}
