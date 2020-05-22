using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labGraphOfFunction
{
    public partial class Fm : MaterialForm
    {
        const int pix = 20;
        private Bitmap Bmarkup;
        public Fm()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey100, Accent.Red400, TextShade.WHITE);
            Resize += Fm_Resize;
            button1.Click += Button1_Click;
            PiGraph.Paint += PiGraph_Paint;


            Bmarkup = new Bitmap(Screen.PrimaryScreen.Bounds.Width*2, Screen.PrimaryScreen.Bounds.Height*2);
            StartForm();
        }

        private void Fm_Resize(object sender, EventArgs e)
        {
            PiGraph.Height = Height - 64 - 2;
            PiGraph.Width = Width * 4 / 5 - 2;
            PiGraph.Location = new Point(Width - Width * 4 / 5, 64);

            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics g = Graphics.FromImage(Bmarkup))
            {
                g.Clear(BackColor);
                g.DrawImage(Bmarkup, 0, 0);
                g.TranslateTransform(w, h);
                DrawXAxis(new Point(-w, 0), new Point(w, 0), g);
                DrawYAxis(new Point(0, h), new Point(0, -h), g);
                g.FillEllipse(Brushes.Red, -2, -2, 4, 4);
            }
        }
        private void PiGraph_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Bmarkup, 0, 0);
            e.Graphics.TranslateTransform(PiGraph.Width / 2, PiGraph.Height / 2);
        }
        private void DrawXAxis(Point start, Point end, Graphics g)
        {
            for (int i = pix; i < end.X; i += pix)
            {
                g.DrawLine(Pens.RosyBrown, i, -5, i, 5);
                DrawText(new Point(i, 5), (i / pix).ToString(), g);
                g.DrawLine(Pens.RosyBrown, -i, -5, -i, 5);
                DrawText(new Point(-i, 5), (-i / pix).ToString(), g);
            }
            g.DrawLine(Pens.RosyBrown, start, end);
        }

        private void DrawYAxis(Point start, Point end, Graphics g)
        {
            for (int i = pix; i < start.Y; i += pix)
            {
                g.DrawLine(Pens.RosyBrown, -5, i, 5, i);
                DrawText(new Point(5, i), (-i / pix).ToString(), g, true);
                g.DrawLine(Pens.RosyBrown, -5, -i, 5, -i);
                DrawText(new Point(5, -i), (i / pix).ToString(), g, true);
            }
            g.DrawLine(Pens.RosyBrown, start, end);
        }

        private void DrawText(Point point, string text, Graphics g, bool isYAxis = false)
        {
            var f = new Font(Font.FontFamily, 8);
            var size = g.MeasureString(text, f);
            var pt = isYAxis
                ? new PointF(point.X + 1, point.Y - size.Height / 2)
                : new PointF(point.X - size.Width / 2, point.Y + 1);
            var rect = new RectangleF(pt, size);
            g.DrawString(text, f, Brushes.Tomato, rect);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics BG = Graphics.FromImage(Bmarkup))
            {
                BG.TranslateTransform(w, h);
                for (float x = -30; x <= 30; x += 0.001F)
                {
                    float y = x * x;
                    BG.FillEllipse(Brushes.White, x * 30, -y * 30, 2, 2);
                }
                PiGraph.Refresh();
            }
        }

        private void StartForm()
        {
            this.Height = 1080;
            this.Width = 1920;
            PiGraph.Height = Height - 64 - 2;
            PiGraph.Width = Width * 4 / 5 - 2;
            PiGraph.Location = new Point(Width - Width * 4 / 5, 64);
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics g = Graphics.FromImage(Bmarkup))
            {
                g.Clear(BackColor);
                g.TranslateTransform(w, h);
                DrawXAxis(new Point(-w, 0), new Point(w, 0), g);
                DrawYAxis(new Point(0, h), new Point(0, -h), g);
                g.FillEllipse(Brushes.Red, -2, -2, 4, 4);
            }
        }
    }
}
