using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labPaint
{
    public partial class fm : Form
    {
        private bool isPressed;
        private Bitmap b;

        public fm()
        {
            InitializeComponent();

            b = new Bitmap(paImage.Width, paImage.Height);
            paImage.MouseDown += PaImage_MouseDown;
            paImage.MouseUp += PaImage_MouseUp;
            paImage.MouseMove += PaImage_MouseMove;
            paImage.Paint += PaImage_Paint;
        }

        private void PaImage_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(b, new Point(0, 0));
        }

        private void PaImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isPressed) return;
            var g = Graphics.FromImage(b);
            g.DrawLine(new Pen(Color.Red, 5), e.X - 10, e.Y - 10, e.X + 10, e.Y + 10);
            g.DrawLine(new Pen(Color.Red, 5), e.X - 10, e.Y + 10, e.X + 10, e.Y - 10);
            g.Dispose();
            paImage.CreateGraphics().DrawImage(b, new Point(0, 0));
        }

        private void PaImage_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void PaImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isPressed = true;
        }
    }
}
