using labImageScroll.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labImageScroll
{
    public partial class fm : Form
    {
        private Bitmap b;
        private Point StartPoint;
        private Point CurPoint;

        public fm()
        {
            InitializeComponent();
            b = new Bitmap(Resources.pic1);
            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
            pictureBox1.Paint += PictureBox1_Paint;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (pictureBox1.Capture)
                {
                    CurPoint.X += e.X - StartPoint.X;
                    CurPoint.Y += e.Y - StartPoint.Y;

                    //curCol = (e.X - CurPoint.X) / sizeCellsMap;
                    //curRow = (e.Y - CurPoint.Y) / sizeCellsMap;

                    StartPoint = e.Location;
                    pictureBox1.Invalidate();
                }
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(b, CurPoint);
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //if (pictureBox1.Capture) 
            //{
            //    CurPoint.X += e.X - StartPoint.X;
            //    CurPoint.Y += e.Y - StartPoint.Y;
            //    StartPoint = e.Location;
            //    pictureBox1.Invalidate();
            //}
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = e.Location;
        }

    }
}
