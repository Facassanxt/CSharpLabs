using GameOfLife;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Final_project_2020
{
    public partial class Fm : MaterialForm
    {
        private Engine engine = null;
        private Point StartPoint;
        private Point CurPoint;
        private Bitmap b;
        private int cX;
        private int cY;
        private int col = 200; // Сетка 
        private int row = 200; // Сетка 
        SolidBrush Brush = new SolidBrush(Color.Green);
        SolidBrush Brush2 = new SolidBrush(Color.FromArgb(51,51,51));

        public Fm()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey100, Accent.Red400, TextShade.WHITE);

            buPlay.Click += buPlay_Click;
            buReset.Click += buReset_Click;
            buStop.Click += buStop_Click;
            buRnd.Click += BuRnd_Click;
            buRR.Click += BuRR_Click;
            buInfo.Click += (s, e) => System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/%D0%98%D0%B3%D1%80%D0%B0_%C2%AB%D0%96%D0%B8%D0%B7%D0%BD%D1%8C%C2%BB");
            timer.Tick += Timer_Tick;
            piGame.Paint += PiGame_Paint;
            piGame.MouseDown += PiGame_MouseDown;
            piGame.MouseMove += PiGame_MouseMove;
            piGame.MouseClick += PiGame_MouseClick;
            Resize += Fm_Resize;

            startForm();
        }

        private void PiGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    int EndPointX = (e.X - CurPoint.X) / cX;
                    int EndPointY = (e.Y - CurPoint.Y) / cY;
                    if (EndPointX < col * 2 && EndPointY < row)
                    {
                        using (Graphics g = Graphics.FromImage(b))
                        {
                            engine[EndPointY, EndPointX] = !engine[EndPointY, EndPointX];
                            if (engine[EndPointY, EndPointX]) g.FillRectangle(Brush, EndPointX * cX, EndPointY * cY, cX, cY);
                            else g.FillRectangle(Brush2, EndPointX * cX, EndPointY * cY, cX, cY);
                        }
                        piGame.Refresh();
                    }
                }
                catch
                {
                    //
                }
            }
        }

        private void PiGame_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (piGame.Capture)
                    {
                        CurPoint.X += e.X - StartPoint.X;
                        CurPoint.Y += e.Y - StartPoint.Y;
                        StartPoint = e.Location;
                        piGame.Refresh();
                    }
                }
                else if (e.Button == MouseButtons.Left)
                {
                    using (Graphics g = Graphics.FromImage(b))
                    {
                        int EndPointX = (e.X - CurPoint.X) / cX;
                        int EndPointY = (e.Y - CurPoint.Y) / cY;
                        if (EndPointX < col * 2 && EndPointY < row)
                        {
                            engine[EndPointY, EndPointX] = !engine[EndPointY, EndPointX];
                            if (engine[EndPointY, EndPointX]) g.FillRectangle(Brush, EndPointX * cX, EndPointY * cY, cX, cY);
                            else g.FillRectangle(Brush2, EndPointX * cX, EndPointY * cY, cX, cY);
                        }
                    }
                }
            }
            catch
            {
                //
            }
            piGame.Refresh();
        }

        private void PiGame_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = e.Location;
            Refresh();
        }

        private void PiGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(b, CurPoint);
        }

        private void ResizeCells()
        {
            cX = piGame.Width / col / 2;
            cY = cX;
        }
        private void DrawCells()
        {
            using (Graphics g = Graphics.FromImage(b))
            {
                g.DrawLine(new Pen(Color.Silver, 1), cX * col * 2, 0, cX * col * 2, cY * row); // Линия 🠗
                g.DrawLine(new Pen(Color.Silver, 1), cX * col * 2, cY * row, 0, cX * col); // Линия 🠔
                g.DrawLine(new Pen(Color.Silver, 1), 0, 0, cX * col * 2, 0); // Линия ➜ 🗘
                g.DrawLine(new Pen(Color.Silver, 1), 0, cY * row, 0, 0); // Линия 🠕
            }
             piGame.Refresh();
        }

        private void BuRR_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                return;
            buReset.PerformClick();
            string phrase = "1:26|2:24|2:26|3:14|3:15|3:22|3:23|3:36|3:37|4:13|4:17|4:22|4:23|4:36|4:37|5:2|5:3|5:12|5:18|5:22|5:23|6:2|6:3|6:12|6:16|6:18|6:19|6:24|6:26|7:12|7:18|7:26|8:13|8:17|9:14|9:15";
            int max = col / 20;
            foreach (var word in phrase.Split('|'))
            {
                string[] wo = word.Split(':');
                for (int i = 0; i < max; i++)
                {
                    engine[int.Parse(wo[0]), int.Parse(wo[1]) + i * 40] = !engine[int.Parse(wo[0]), int.Parse(wo[1]) + i *40];
                }
            }
            UpdateCells();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                engine.Tick();
            });
            UpdateCells();
        }

        private void BuRnd_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                return;
            Random rnd = new Random();
            for (int i = 0; i < col * row; i++)
            {
                int EndPointX = rnd.Next(0, col * 2);
                int EndPointY = rnd.Next(0, row);
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.FillRectangle(Brush, EndPointX * cX, cY * EndPointY, cX, cY);
                    engine[EndPointY, EndPointX] = !engine[EndPointY, EndPointX];
                }
            }
        }

        private async void startForm()
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height / 10 * 9;
            this.Width = Screen.PrimaryScreen.Bounds.Width / 10 * 9;
            piGame.Height = Height - 64 - 2;
            piGame.Width = Width - 4;
            engine = new Engine(row, col * 2);
            piGame.Location = new Point(2, 64);


            b = new Bitmap(piGame.Width * 2, piGame.Height * 2);

            ResizeCells();
            await Task.Run(() => DrawCells());
        }
        private void Fm_Resize(object sender, EventArgs e)
        {
            piGame.Height = Height - 64 - 2;
            piGame.Width = Width - 4;
        }

        private void buPlay_Click(object sender, EventArgs e)
        {
            piGame.Enabled = false;
            timer.Start();
            timer.Enabled = true;
            buPlay.Enabled = false;
            buStop.Enabled = true;
        }

        private void buStop_Click(object sender, EventArgs e)
        {
            piGame.Enabled = true;
            timer.Stop();
            timer.Enabled = false;
            buStop.Enabled = false;
            buPlay.Enabled = true;
        }

        private void buReset_Click(object sender, EventArgs e)
        {
            piGame.Enabled = true;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            timer.Stop();
            timer.Dispose();
            timer.Stop();
            timer.Enabled = false;
            buStop.Enabled = false;
            buPlay.Enabled = true;

            engine = new Engine(row, col * 2);

            b = new Bitmap(piGame.Width * 2, piGame.Height * 2);
            ResizeCells();
            DrawCells();
        }

        private async void UpdateCells()
        {
            using (Graphics g = Graphics.FromImage(b))
            {
                g.Clear(Brush2.Color);
                    for (int i = 0; i < col * 2; i++)
                        for (int j = 0; j < row; j++)
                            if (engine[j, i]) g.FillRectangle(Brush, i * cX, j * cY, cX, cY);

                await Task.Run(() =>
                {
                    g.DrawLine(new Pen(Color.Silver, 1), cX * col * 2, 0, cX * col * 2, cY * row); // Линия 🠗
                    g.DrawLine(new Pen(Color.Silver, 1), cX * col * 2, cY * row, 0, cX * col); // Линия 🠔
                    g.DrawLine(new Pen(Color.Silver, 1), 0, 0, cX * col * 2, 0); // Линия ➜ 🗘
                    g.DrawLine(new Pen(Color.Silver, 1), 0, cY * row, 0, 0); // Линия 🠕
                });
                piGame.Refresh();
            }
        }
    }
}
