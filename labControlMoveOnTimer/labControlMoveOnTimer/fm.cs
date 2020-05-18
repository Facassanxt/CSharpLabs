using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labControlMoveOnTimer
{
    public partial class fm : Form
    {
        private int deltaX, deltaY;

        public fm()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();

            this.MouseWheel += (s, e) =>
            {
                if (deltaX > 0)
                {
                    deltaX += (e.Delta > 0) ? 1 : -1;
                }
            };
            this.MouseClick += (s, e) => timer.Enabled = !timer.Enabled;
            Random rnd = new Random();
            deltaX = rnd.Next(-5, 5);
            deltaY = rnd.Next(-5, 5);

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           
            var x = pictureBox1;
            x.Location = new Point(x.Location.X + deltaX, x.Location.Y + deltaY);
            this.Text = $"{Application.ProductName} : {x.Location}, {deltaX}, {x.Width}, {ClientSize.Width}";
            if ((x.Location.X + x.Width + deltaX > ClientSize.Width) || (x.Location.X + deltaX < 0))
            {
                deltaX *= -1;
                Image image = pictureBox1.Image;
                image.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBox1.Image = image;
            }
            else if ((x.Location.Y + x.Height + deltaY > ClientSize.Height) || (x.Location.Y + deltaY < 0))
            {
                deltaY *= -1;
                Image image = pictureBox1.Image;
                image.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBox1.Image = image;
            }
        }
    }
}
