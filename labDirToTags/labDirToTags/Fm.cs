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

namespace labDirToTags
{
    public partial class Fm : Form
    {
        private Tags tags = new Tags();
        public Fm()
        {
            InitializeComponent();
            buDirSelect.Click += BuDirSelect_Click;
            edDir.TextChanged += EdDir_TextChanged;

            //edTags
            edDir.Text = Directory.GetCurrentDirectory();
            
        }

        private void EdDir_TextChanged(object sender, EventArgs e)
        {
            edTags.Clear();
            var arr = tags.CountTags(edDir.Text);
            edTags.Text = string.Join(Environment.NewLine, arr);
            laTags.Text = $"Найдено Tag'ов - {tags.CountSearchTags}";
        }

        private void BuDirSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                edDir.Text = dialog.SelectedPath;
            }
        }
    }
}
