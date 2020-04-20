using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labFormDialogs
{
    public partial class fm : Form
    {
        public fm()
        {
            InitializeComponent();
            buDialog.Click += BuDialog_Click;
        }

        private void BuDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.InitialDirectory = OpenDialog.Text;
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenDialog.Text = openFileDialog.FileName;
            }
        }
    }
}
