using labImageScrollHorz.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labImageScrollHorz
{
    public partial class fm : Form
    {
        private Bitmap ImBG;
        private Bitmap b;
        private Graphics g;
        private Point startPoint;
        private int drawX;

        public fm()
        {
            InitializeComponent();

            ImBG = Resources.Game_Background_17;
            this.Height = ImBG.Height;
            b = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            g = Graphics.FromImage(b);

            this.DoubleBuffered = true;
            this.Paint += (s, e) => { UpdateBG(); e.Graphics.DrawImage(b, 0, 0); };
            this.MouseDown += (s, e) => startPoint = e.Location;
            this.MouseMove += Fm_MouseMove;
            this.KeyPreview = true;
            this.KeyDown += Fm_KeyDown;

        }

        private void Fm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    UpdateDrawX(-2);
                    break;
                case Keys.Right:
                    UpdateDrawX(2);
                    break;
            }
            this.Invalidate();
        }

        private void UpdateDrawX(int v)
        {
            Text = $"{Application.ProductName} : {drawX}, {v}";
            drawX -= v;
            if (drawX > 0)
            {
                drawX -= ImBG.Width;
            }
            else 
            {
                if (drawX < -ImBG.Width)
                {
                    drawX += ImBG.Width;
                }
            }
        }

        private void UpdateBG()
        {
            for (int i = 0; i < 2; i++)
            {
                g.DrawImage(ImBG, drawX + ImBG.Width * i, 0);
            }
        }

        private void Fm_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Capture)
            {
                UpdateDrawX(startPoint.X - e.X);
                startPoint = e.Location;
                this.Invalidate();
            }
        }
    }
}
