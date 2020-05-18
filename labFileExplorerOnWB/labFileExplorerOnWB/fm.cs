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

namespace labFileExplorerOnWB
{
    public partial class fm : Form
    {
        public fm()
        {
            InitializeComponent();
            edDir.Text = Directory.GetCurrentDirectory();
            buBack.Click += (s, e) => wb.GoBack();
            buForward.Click += (s, e) => wb.GoForward();
            buUp.Click += (s, e) => wb.Url = new Uri(Directory.GetParent(edDir.Text).ToString());
            BuDirSelect.Click += BuDirSelect_Click;
            wb.DocumentCompleted += (s, e) => edDir.Text = wb.Url.LocalPath;
            wb.Url = new Uri(edDir.Text);
        }

        private void BuDirSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                wb.Url = new Uri(dialog.SelectedPath);
            }
        }
    }
}
