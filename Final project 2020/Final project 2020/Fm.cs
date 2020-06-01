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

namespace Final_project_2020
{
    public partial class Fm : MaterialForm
    {
        private Engine engine = null;
        private const int cellSize = 25;
        private Point StartPoint;
        private Point CurPoint;
        private Bitmap b;
        private int screenSize;
        private int cX;
        private int cY;
        private int col = 60; // Сетка 
        private int row = 60; // Сетка 
        List<Button> listBtn = new List<Button> { };
        SolidBrush Brush = new SolidBrush(Color.Green);

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
            Resize += Fm_Resize;

            startForm();
            //drawButton();
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
                            g.FillRectangle(Brush, EndPointX * cX, cY * EndPointY, cX, cY);
                            Text = $"| {EndPointX} | {EndPointY} |";
                        }
                    }
                }
                Refresh();
            }
            catch
            {
                //
            }
        }

        private void PiGame_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = e.Location;
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
                            g.FillRectangle(Brush, EndPointX * cX, cY * EndPointY, cX, cY);
                            Text = $"| {EndPointX} | {EndPointY} |";
                        }
                        piGame.Refresh();
                    }
                }
                catch
                {
                    //
                }
            }
            Refresh();
        }

        private void PiGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(b, CurPoint);
        }

        private void ResizeCells()
        {
            cX = piGame.Width / col / 2;
            cY = piGame.Width / row / 2;
        }
        private void DrawCells()
        {
            using (Graphics g = Graphics.FromImage(b))
                for (int i = 0; i < col * 2 + 1 ; i++)
                {
                    g.DrawLine(new Pen(Color.Silver, 1), i * cX, 0, i * cX, row * cY);
                    for (int j = 0; j < row + 1; j++)
                       g.DrawLine(new Pen(Color.Silver, 1), 0, j * cY, col * 2 * cX, j * cY);
                }
            this.Invoke((MethodInvoker)delegate () { piGame.Refresh(); });
        }

        private void BuRR_Click(object sender, EventArgs e)
        {
            buReset.PerformClick();

            int maxr = screenSize / cellSize;
            listBtn[26 + maxr * 1].PerformClick();
            listBtn[24 + maxr * 2].PerformClick();
            listBtn[26 + maxr * 2].PerformClick();
            listBtn[14 + maxr * 3].PerformClick();
            listBtn[15 + maxr * 3].PerformClick();
            listBtn[22 + maxr * 3].PerformClick();
            listBtn[23 + maxr * 3].PerformClick();
            listBtn[36 + maxr * 3].PerformClick();
            listBtn[37 + maxr * 3].PerformClick();
            listBtn[13 + maxr * 4].PerformClick();
            listBtn[17 + maxr * 4].PerformClick();
            listBtn[22 + maxr * 4].PerformClick();
            listBtn[23 + maxr * 4].PerformClick();
            listBtn[36 + maxr * 4].PerformClick();
            listBtn[37 + maxr * 4].PerformClick();
            listBtn[2 + maxr * 5].PerformClick();
            listBtn[3 + maxr * 5].PerformClick();
            listBtn[12 + maxr * 5].PerformClick();
            listBtn[18 + maxr * 5].PerformClick();
            listBtn[22 + maxr * 5].PerformClick();
            listBtn[23 + maxr * 5].PerformClick();
            listBtn[2 + maxr * 6].PerformClick();
            listBtn[3 + maxr * 6].PerformClick();
            listBtn[12 + maxr * 6].PerformClick();
            listBtn[16 + maxr * 6].PerformClick();
            listBtn[18 + maxr * 6].PerformClick();
            listBtn[19 + maxr * 6].PerformClick();
            listBtn[24 + maxr * 6].PerformClick();
            listBtn[26 + maxr * 6].PerformClick();
            listBtn[12 + maxr * 7].PerformClick();
            listBtn[18 + maxr * 7].PerformClick();
            listBtn[26 + maxr * 7].PerformClick();
            listBtn[13 + maxr * 8].PerformClick();
            listBtn[17 + maxr * 8].PerformClick();
            listBtn[14 + maxr * 9].PerformClick();
            listBtn[15 + maxr * 9].PerformClick();
            UpdateCells();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                engine.Tick();
                UpdateCells();
            });
        }

        private async void BuRnd_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                return;
            Random rnd = new Random();
            await Task.Run(() => 
            {
                for (int i = 0; i < col * row; i++)
                {
                    int EndPointX = rnd.Next(0, col * 2);
                    int EndPointY = rnd.Next(0, row);
                    using (Graphics g = Graphics.FromImage(b))
                    {
                        g.FillRectangle(Brush, EndPointX * cX, cY * EndPointY, cX, cY);
                    }
                }
            });
        }

        private async void startForm()
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height / 10 * 9;
            this.Width = Screen.PrimaryScreen.Bounds.Width / 10 * 9;
            screenSize = Width / 10 * 9;
            piGame.Height = Height - 64 - 2;
            piGame.Width = Width - 4;
            engine = new Engine(piGame.Height / cellSize, screenSize/ cellSize);
            piGame.Location = new Point(2, 64);


            b = new Bitmap(piGame.Width * 2, piGame.Height * 2);

            ResizeCells();
            await Task.Run(() => DrawCells());
            //await Task.Run(() => drawButton());
            //drawButton();
        }
        private void Fm_Resize(object sender, EventArgs e)
        {
            piGame.Height = Height - 64 - 2;
            piGame.Width = Width - 4;
        }

        private void drawButton()
        {
            for (int j = 0; j + cellSize <= piGame.Height; j += cellSize)
                for (int i = 0; i + cellSize <= screenSize; i += cellSize)
                {
                    Button newButton = new Button();
                    newButton.Parent = piGame;
                    newButton.Size = new Size(cellSize, cellSize);
                    newButton.Location = new Point(i, j);
                    newButton.Click += ClickCell;
                    newButton.BackColor = Color.Transparent;
                    newButton.FlatStyle = FlatStyle.Flat;
                    newButton.FlatAppearance.BorderSize = 0;
                    listBtn.Add(newButton);
                }
        }

        private void buPlay_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            buPlay.Enabled = false;
            buStop.Enabled = true;
        }

        private void buStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            buStop.Enabled = false;
            buPlay.Enabled = true;
        }

        private async void buReset_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            buStop.Enabled = false;
            buPlay.Enabled = true;

            engine = new Engine(piGame.Height / cellSize, screenSize / cellSize);

            b = new Bitmap(piGame.Width * 2, piGame.Height * 2);
            ResizeCells();
            await Task.Run(() => DrawCells());
        }

        private void ClickCell(object sender, EventArgs e)
        {
            if (timer.Enabled)
                return;

            int buttonLinearIndex = listBtn.IndexOf(sender as Button);
            int y = buttonLinearIndex / engine.Width;
            int x = buttonLinearIndex % engine.Width;

            engine[y, x] = !engine[y, x];
            ((Button)sender).BackColor = engine[y, x] ? Color.Green : Color.Transparent;
        }

        private async void UpdateCells()
        {
            await Task.Run(() =>
            {
                for (int linearIndex = 0; linearIndex < listBtn.Count; ++linearIndex)
                {
                    int x = linearIndex / engine.Width;
                    int y = linearIndex % engine.Width;
                    if (listBtn[linearIndex].BackColor == Color.Green)
                        this.Invoke((MethodInvoker)delegate () { listBtn[linearIndex].BackColor = Color.PeachPuff; });
                    if (engine[x, y])
                        this.Invoke((MethodInvoker)delegate () { listBtn[linearIndex].BackColor = Color.Green; });
                }
            });
        }
    }
}
