using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labWebBrowser
{
    public partial class Fm : Form
    {
        public Fm()
        {
            InitializeComponent();
            buGo.Click += (sender, e) => wb.Navigate(edURL.Text);
            buBack.Click += (sender, e) => wb.GoBack();
            buForward.Click += (sender, e) => wb.GoForward();
            buReload.Click += (sender, e) => wb.Refresh();
            buStop.Click += (sender, e) => wb.Stop();
            wb.DocumentCompleted += (sender, e) => edURL.Text = wb.Url.ToString();

            edURL.KeyDown += EdURL_KeyDown;
        }

        private void EdURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                wb.Navigate(edURL.Text);
        }

        private void Fm_Load(object sender, EventArgs e)
        {

        }
    }
}
