using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                await Task.Delay(300);
                button2.Text = i.ToString();
            }
            button2.Text = "The end";
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Думаю";
            //
            await Task.Delay(1000);
            button1.Text = DateTime.Now.ToString();
        }
    }
}
