using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labEvent
{
    public partial class Fm : Form
    {
        public Fm()
        {
            InitializeComponent();
            button2.Click += Button2_Click;
            button3.Click += delegate
            {
                MessageBox.Show("Способ 3");
            };
            button3.Click += Button2_Click;
            button4.Click += (sender, e) => MessageBox.Show("Способ 4");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Способ 2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать =)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Способ 1");
        }
    }
}
