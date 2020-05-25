using MaterialSkin;
using MaterialSkin.Controls;
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

namespace labGraphOfFunction
{
    public partial class Fm : MaterialForm
    {
        const int pix = 20;
        private sbyte graph = -1;
        private Bitmap Bmarkup, BGraph;
        private float numK = 1, numB = 1;
        public Fm()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey100, Accent.Red400, TextShade.WHITE);
            Resize += (s,e) => Fm_Resize();
            button0.Click += (s, e) => { graph = 0; Fm_Resize(); };
            button1.Click += (s, e) => { graph = 1; Fm_Resize(); };
            button2.Click += (s, e) => { graph = 2; Fm_Resize(); };
            button3.Click += (s, e) => { graph = 3; Fm_Resize(); };
            button4.Click += (s, e) => { graph = 4; Fm_Resize(); };
            button5.Click += (s, e) => { graph = 5; Fm_Resize(); };
            button6.Click += (s, e) => { graph = 6; Fm_Resize(); };
            button7.Click += (s, e) => { graph = 7; Fm_Resize(); };
            button8.Click += (s, e) => { graph = 8; Fm_Resize(); };
            button9.Click += (s, e) => { graph = 9; Fm_Resize(); };
            button10.Click += (s, e) => { graph = 10; Fm_Resize(); };
            button11.Click += (s, e) => { graph = 11; Fm_Resize(); };
            button12.Click += (s, e) => { graph = 12; Fm_Resize(); };
            button13.Click += (s, e) => { graph = 13; Fm_Resize(); };
            PiGraph.Paint += PiGraph_Paint;
            trackBarK.ValueChanged += (s,e) => { numK = trackBarK.Value/100; Fm_Resize(); };
            trackBarB.ValueChanged += (s, e) => { numB = trackBarB.Value; Fm_Resize(); };
            //numericK.ValueChanged += (s, e) => numK = numericK.Value;
            //numericB.ValueChanged += (s, e) => numB = numericB.Value;


            Bmarkup = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            BGraph = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            trackBarK.Value = 1;
            StartForm();
        }

        private void Button13_Click()
        {
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics BG = Graphics.FromImage(Bmarkup))
            {
                BG.TranslateTransform(w, h);
                for (float x = -30; x <= 30; x += 0.001F)
                {
                    float y = numK * (float)Math.Abs(x) + numB;
                    BG.FillEllipse(Brushes.White, x * 30.00F, -y * 30.00f, 2.00F, 2.00F);
                }
                PiGraph.Refresh();
            }
        }

        private void Button12_Click()
        {
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics BG = Graphics.FromImage(Bmarkup))
            {
                BG.TranslateTransform(w, h);
                for (float x = -30; x <= 30; x += 0.001F)
                {
                    float y = (float)Math.Log(numK, x) + numB;
                    BG.FillEllipse(Brushes.White, x * 30.00F, -y * 30.00f, 2.00F, 2.00F);
                }
                PiGraph.Refresh();
            }
        }

        private void Button11_Click()
        {
            //int w = PiGraph.Width / 2;
            //int h = PiGraph.Height / 2;
            //using (Graphics BG = Graphics.FromImage(Bmarkup))
            //{
            //    BG.TranslateTransform(w, h);
            //    for (float x = -30; x <= 30; x += 0.001F)
            //    {
            //        float y = ((float)Math.Pow(numK, x) + numB)/1000;
            //        BG.FillEllipse(Brushes.White, x * 30.00F, -y, 2.00F, 2.00F);
            //    }
            //    PiGraph.Refresh();
            //}
        }

        private void Button10_Click()
        {
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics BG = Graphics.FromImage(Bmarkup))
            {
                BG.TranslateTransform(w, h);
                for (float x = -30; x <= 30; x += 0.001F)
                {
                    float y = numK * (float)1.0 / (float)Math.Tan(x) + numB;
                    BG.FillEllipse(Brushes.White, x * 30.00F, -y * 30.00f, 2.00F, 2.00F);
                }
                PiGraph.Refresh();
            }
        }

        private void Button9_Click()
        {
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics BG = Graphics.FromImage(Bmarkup))
            {
                BG.TranslateTransform(w, h);
                for (float x = -30; x <= 30; x += 0.001F)
                {
                    float y = numK * (float)Math.Tan(x) + numB;
                    BG.FillEllipse(Brushes.White, x * 30.00F, -y * 30.00f, 2.00F, 2.00F);
                }
                PiGraph.Refresh();
            }
        }

        private void Button8_Click()
        {
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics BG = Graphics.FromImage(Bmarkup))
            {
                BG.TranslateTransform(w, h);
                for (float x = -30; x <= 30; x += 0.001F)
                {
                    float y = numK * (float)Math.Sqrt(x) + numB;
                    BG.FillEllipse(Brushes.White, x * 30.00F, -y * 30.00f, 2.00F, 2.00F);
                }
                PiGraph.Refresh();
            }
        }

        private void Button7_Click()
        {
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics BG = Graphics.FromImage(Bmarkup))
            {
                BG.TranslateTransform(w, h);
                for (float x = -30; x <= 30; x += 0.001F)
                {
                    float y = numK * (float)Math.Sign(x) * (float)Math.Pow(Math.Abs(x), 1 / 3.0) + numB;
                    BG.FillEllipse(Brushes.White, x * 30.00F, -y * 30.00f, 2.00F, 2.00F);
                }
                PiGraph.Refresh();
            }
        }

        private void Button6_Click()
        {
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics BG = Graphics.FromImage(Bmarkup))
            {
                BG.TranslateTransform(w, h);
                for (float x = -30; x <= 30; x += 0.001F)
                {
                    float y = numK * (float)Math.Cos(x) + numB;
                    BG.FillEllipse(Brushes.White, x * 30.00F, -y * 30.00f, 2.00F, 2.00F);
                }
                PiGraph.Refresh();
            }
        }

        private void Button5_Click()
        {
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics BG = Graphics.FromImage(Bmarkup))
            {
                BG.TranslateTransform(w, h);
                for (float x = -30; x <= 30; x += 0.001F)
                {
                    float y = numK * (float)Math.Sin(x) + numB;
                    BG.FillEllipse(Brushes.White, x * 30.00F, -y * 30.00f, 2.00F, 2.00F);
                }
                PiGraph.Refresh();
            }
        }

        private void Button4_Click()
        {
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics BG = Graphics.FromImage(Bmarkup))
            {
                BG.TranslateTransform(w, h);
                for (float x = -30; x <= 30; x += 0.001F)
                {
                    float y = numK / x + numB;
                    BG.FillEllipse(Brushes.White, x * 30.00F, -y * 30.00f, 2.00F, 2.00F);
                }
                PiGraph.Refresh();
            }
        }

        private void Button3_Click()
        {
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics BG = Graphics.FromImage(Bmarkup))
            {
                BG.TranslateTransform(w, h);
                for (float x = -30; x <= 30; x += 0.001F)
                {
                    float y = numK * (float)Math.Pow(x, 3) + numB;
                    BG.FillEllipse(Brushes.White, x * 30.00F, -y * 30.00f, 2.00F, 2.00F);
                }
                PiGraph.Refresh();
            }
        }

        private void Button2_Click()
        {
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics BG = Graphics.FromImage(Bmarkup))
            {
                BG.TranslateTransform(w, h);
                for (float x = -30; x <= 30; x += 0.001F)
                {
                    float y = numK * (float)Math.Pow(x, 2) + numB;
                    BG.FillEllipse(Brushes.White, x * 30.00F, -y * 30.00f, 2.00F, 2.00F);
                }
                PiGraph.Refresh();
            }
        }

        private void Button1_Click()
        {
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics BG = Graphics.FromImage(Bmarkup))
            {
                BG.TranslateTransform(w, h);
                for (float x = -30; x <= 30; x += 0.001F)
                {
                    float y = numK * x + numB;
                    BG.FillEllipse(Brushes.White, x * 30.00F, -y * 30.00f, 2.00F, 2.00F);
                }
                PiGraph.Refresh();
            }
        }

        private void Button0_Click()
        {
            int w = PiGraph.Width / 2;
            int h = PiGraph.Height / 2;
            using (Graphics BG = Graphics.FromImage(Bmarkup))
            {
                BG.TranslateTransform(w, h);
                for (float x = -30; x <= 30; x += 0.001F)
                {
                    float y = numK * x;
                    BG.FillEllipse(Brushes.White, x * 30.00F, -y * 30.00f, 2.00F, 2.00F);
                }
                PiGraph.Refresh();
            }
        }
        //private void sdassa()
        //{
        //    Bitmap ResultBitmap = new Bitmap(Bmarkup.Width, Bmarkup.Height,
        //        PixelFormat.Format32bppArgb);
        //    Graphics graph = Graphics.FromImage(ResultBitmap);
        //    graph.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
        //    graph.DrawImage(Bmarkup, 0, 0);
        //    graph.DrawImage(BGraph, (Bmarkup.Width - BGraph.Width) / 2,
        //        (Bmarkup.Height - BGraph.Height) / 2,
        //        BGraph.Width, BGraph.Height);
        //    Bmarkup = ResultBitmap;
        //}

        private void Fm_Resize()
        {
            trackBarK.Width = Width - 4;
            trackBarK.Height = 30;
            trackBarB.Width = trackBarK.Width;
            trackBarB.Height = trackBarK.Height;
            trackBarK.Location = new Point(2, Height - trackBarB.Height - trackBarK.Height - 4);
            trackBarB.Location = new Point(2, Height - trackBarB.Height - 4);

            PiGraph.Height = Height - trackBarB.Height - trackBarK.Height - 4 - 64;
            PiGraph.Width = Width - button0.Width - 4;
            PiGraph.Location = new Point(button0.Width + 2, 64);

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
            numK = trackBarK.Value;
            numB = trackBarB.Value;
            if (graph == 0) Button0_Click();
            else if (graph == 1) Button1_Click();
            else if (graph == 2) Button2_Click();
            else if (graph == 3) Button3_Click();
            else if (graph == 4) Button4_Click();
            else if (graph == 5) Button5_Click();
            else if (graph == 6) Button6_Click();
            else if (graph == 7) Button7_Click();
            else if (graph == 8) Button8_Click();
            else if (graph == 9) Button9_Click();
            else if (graph == 10) Button10_Click();
            else if (graph == 11) Button11_Click();
            else if (graph == 12) Button12_Click();
            else if (graph == 13) Button13_Click();
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

        private void StartForm()
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height / 2;
            this.Width = Screen.PrimaryScreen.Bounds.Width / 2;
            trackBarK.Width = Width - 4;
            trackBarK.Height = 30;
            trackBarB.Width = trackBarK.Width;
            trackBarB.Height = trackBarK.Height;
            trackBarK.Location = new Point(2, Height - trackBarB.Height - trackBarK.Height - 4);
            trackBarB.Location = new Point(2, Height - trackBarB.Height - 4);

            PiGraph.Height = Height - trackBarB.Height - trackBarK.Height - 4 - 64;
            PiGraph.Width = Width - button0.Width - 4;
            PiGraph.Location = new Point(button0.Width + 2, 64);

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
