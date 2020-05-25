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
            Resize += Fm_Resize;
            edDir.Text = Directory.GetCurrentDirectory();
            startform();
            
        }

        private void startform()
        {
            Height = Screen.PrimaryScreen.Bounds.Height / 3 * 2;
            Width = Screen.PrimaryScreen.Bounds.Width / 3 * 2;
            laTags.Location = new Point(0, panelMenu.Height);
            label1.Location = new Point(Width - label1.Width, panelMenu.Height);
            edTags.Location = new Point(0, panelMenu.Height + label1.Height);
            panelMenu.Width = Width;
            toolMenu.Width = panelMenu.Width;
            panelMenu.Location = new Point(0, 0);
            edDir.Width = Width - buDirSelect.Width - 25;
        }

        private void Fm_Resize(object sender, EventArgs e)
        {
            panelMenu.Width = Width;
            toolMenu.Width = panelMenu.Width;
            edDir.Width = Width - buDirSelect.Width - 25;
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
