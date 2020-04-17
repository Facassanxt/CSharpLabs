using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveControleMouse
{
    public partial class Form1 : Form
    {
        private Point startPoint { get; set; }

        public Form1()
        {
            InitializeComponent();

            pictureBox1.MouseDown += All_MouseDown;
            pictureBox1.MouseMove += All_MouseMove;

            pictureBox2.MouseDown += All_MouseDown;
            pictureBox2.MouseMove += All_MouseMove;

            pictureBox1.MouseWheel += PictureBox1_MouseWheel;
        }

        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            int xDelta = e.Delta > 0 ? 2 : -2;
            if (sender is Control x) 
            {
                x.Location = new Point(x.Location.X + xDelta*-1, x.Location.Y + xDelta*-1);
                x.Width += xDelta * 2;
                x.Height += xDelta * 2;

            }
        }

        private void All_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point x = new Point(Cursor.Position.X - startPoint.X, Cursor.Position.Y - startPoint.Y);
                if (sender is Control)
                    ((Control)sender).Location = PointToClient(x);
            }
        }

        private void All_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(e.X, e.Y);
        }

    }
}
