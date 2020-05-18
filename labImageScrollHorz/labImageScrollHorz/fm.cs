using labImageScrollHorz.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labImageScrollHorz
{
    public partial class fm : Form
    {
        private Bitmap ImG, ImBG;
        private Bitmap BitG, BitBG;
        private Graphics gG, gBG;
        private Point startPoint;
        private int drawXG, drawXBG;

        public fm()
        {
            InitializeComponent();

            ImG = Resources.Game;
            ImBG = Resources.Game_Background;
            this.Height = ImG.Height;
            BitG = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            gG = Graphics.FromImage(BitG);
            BitBG = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            gBG = Graphics.FromImage(BitBG);

            this.DoubleBuffered = true;
            this.Paint += (s, e) => { UpdateBG(); e.Graphics.DrawImage(BitBG, 0, 0); e.Graphics.DrawImage(BitG, 0, 0);};
            this.MouseDown += (s, e) => startPoint = e.Location;
            this.MouseMove += Fm_MouseMove;
            this.KeyPreview = true;
            this.KeyDown += Fm_KeyDown;
            this.MouseWheel += Fm_MouseWheel;

        }

        private void Fm_MouseWheel(object sender, MouseEventArgs e)
        {
            int rangeimage = e.Delta > 0 ? 10 : -10;
            UpdateDrawXG(rangeimage);
            UpdateDrawXBG(rangeimage/10);
            this.Invalidate();
        }

        private void Fm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    UpdateDrawXG(-10);
                    UpdateDrawXBG(-10 / 10);
                    break;
                case Keys.Right:
                    UpdateDrawXG(10);
                    UpdateDrawXBG(10 / 10);
                    break;
            }
            this.Invalidate();
        }

        private void UpdateDrawXG(int v)
        {
            drawXG -= v;
            if (drawXG > 0)
            {
                drawXG -= ImG.Width;
            }
            else
            {
                if (drawXG < -ImG.Width)
                {
                    drawXG += ImG.Width;
                }
            }
        }

        private void UpdateDrawXBG(int v)
        {
            drawXBG -= v;
            if (drawXBG > 0)
            {
                drawXBG -= ImG.Width;
            }
            else
            {
                if (drawXBG < -ImG.Width)
                {
                    drawXBG += ImG.Width;
                }
            }
        }

        private void UpdateBG()
        {
            for (int i = 0; i < 3; i++)
            {
                gBG.DrawImage(ImBG, drawXBG + ImBG.Width * i, 0, ImBG.Width, ImBG.Height);
                gG.DrawImage(ImG, drawXG + ImG.Width * i, 0, ImG.Width, ImG.Height);
            }
        }

        private void Fm_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Capture)
            {
                UpdateDrawXG(startPoint.X - e.X);
                UpdateDrawXBG((startPoint.X - e.X)/10);
                startPoint = e.Location;
                this.Invalidate();
            }
        }
    }
}
