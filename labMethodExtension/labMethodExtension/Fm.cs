using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labMethodExtension
{
    public partial class Fm : Form
    {
        public Fm()
        {
            InitializeComponent();

            button1.Click += (s, e) => button1.Text = textBox1.TextUpper();
        }
    }
}
