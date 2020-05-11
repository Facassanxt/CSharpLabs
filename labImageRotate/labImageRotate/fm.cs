using labImageRotate.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labImageRotate
{
    public partial class fm : Form
    {
        private Bitmap b;

        public fm()
        {
            InitializeComponent();


            b = new Bitmap(Resources._image);
            trackBar1.ValueChanged += (s, e) => pictureBox1.Invalidate();
            pictureBox1.Paint += PictureBox1_Paint;
            //pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);

            button1.Click += (s, e) => { b.RotateFlip(RotateFlipType.RotateNoneFlipX); pictureBox1.Invalidate(); };
            button2.Click += (s, e) => { b.RotateFlip(RotateFlipType.RotateNoneFlipY); pictureBox1.Invalidate(); };


        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(b.Width / 2, b.Height / 2);
            e.Graphics.RotateTransform(trackBar1.Value);
            e.Graphics.DrawImage(b, -b.Width/2, -b.Height/2);
        }
    }
}
