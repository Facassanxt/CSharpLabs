using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabParallel
{
    public partial class Form1 : Form
    {
        private readonly int countFiles = 100;

        public Form1()
        {
            InitializeComponent();

            edDirTemp.Text = Path.Combine(Path.GetTempPath(), Application.ProductName);
            Directory.CreateDirectory(edDirTemp.Text);
            buCreateFiles.Click += BuCreateFiles_Click;
            buDeleteFiles.Click += Button2_Click;
            button3.Click += Button3_Click;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Parallel.Invoke(() => { },
                            () => { },
                            () => { },
                            () => { });
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Parallel.For(0, countFiles, (v) => File.Delete(Path.Combine(edDirTemp.Text, $"файл{v}.txt")));
        }

        private void BuCreateFiles_Click(object sender, EventArgs e)
        {
            Parallel.For(0, countFiles, CreateFile);
        }

        private void CreateFile(int v)
        {
            File.Create(Path.Combine(edDirTemp.Text, $"файл{v}.txt")).Close();
        }
    }
}
