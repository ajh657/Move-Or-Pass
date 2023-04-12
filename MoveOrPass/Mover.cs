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
    public partial class Mover : Form
    {
        FileInfo[] files;
        string destination;
        public Mover(List<FileInfo> files, string destination)
        {
            this.files = files.ToArray();
            this.destination = destination;
            InitializeComponent();
        }

        private void MoveFiles()
        {
            progressBar1.Maximum = files.Length;
            for (int i = 0; i < files.Length; i++)
            {
                var file = files[i];
                File.Copy(file.FullName, Path.Combine(destination, file.Name));
                progressBar1.Value = i;
            }
            MessageBox.Show("Completed");
            Application.Exit();
        }

        private void Mover_Load(object sender, EventArgs e)
        {
            MoveFiles();
        }
    }
}
