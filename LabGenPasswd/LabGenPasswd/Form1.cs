using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabGenPassword;

namespace LabGenPasswd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnGen.Click += delegate
            {
                passwd.Text = Utils.RandomStr((int)numericUpDown1.Value,
                checkDown.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
            };
        }
    }
}
