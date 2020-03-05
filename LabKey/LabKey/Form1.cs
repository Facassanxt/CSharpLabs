using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.Shift ? "Shift " + e.KeyCode.ToString() : e.KeyCode.ToString();

            switch (e.KeyCode) {
                case Keys.Left:
                    label1.Text = "Left";
                    break;

                case Keys.Right:
                    label1.Text = "Right";
                    break;
                case Keys.Up:
                    label1.Text = "UP";
                    break;
                case Keys.Down:
                    label1.Text = "Down";
                    break;
                case Keys.Space: 
                    if (e.Shift)
                    {
                        label1.Text = "shift + space";
                    }
                    else
                    {
                        label1.Text = "space";
                    }
                    break;
                case Keys.Z:
                    label1.Text = e.Shift ? "Shift + Z" : "Z";
                    break;
            }
            
        }
    }
}
