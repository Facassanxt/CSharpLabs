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
            string s = edDir.Text;
            var a = s.Split(new char[] { ' ', '\\', '«', '»', '(', ')' }).ToArray();
            a = a.Where(v => v.Length > 0).Select(v => v.TrimEnd(',')).OrderBy(v => v).ToArray();
            edTags.Text = string.Join(Environment.NewLine, a);
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
