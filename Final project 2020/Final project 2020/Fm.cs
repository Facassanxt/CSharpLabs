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

namespace Final_project_2020
{
    public partial class Fm : MaterialForm
    {
        private Engine engine = null;
        private const int cellSize = 25;
        private int screenSize;
        List<Button> listBtn = new List<Button> { };

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

            startForm();
            drawButton();
        }

        private void BuRR_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            buStop.Enabled = false;
            buPlay.Enabled = true;
            for (int linearIndex = 0; linearIndex < listBtn.Count; ++linearIndex)
                listBtn[linearIndex].BackColor = Color.Transparent;

            engine = new Engine(gameScreen.Height / cellSize, screenSize / cellSize);
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
                for (int i = 0; i < listBtn.Count / 2; i++)
                {
                    this.Invoke((MethodInvoker)delegate () { listBtn[rnd.Next(0, listBtn.Count)].PerformClick(); });
                }
            });
        }

        private void startForm()
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height / 10 * 9;
            this.Width = Screen.PrimaryScreen.Bounds.Width / 10 * 9;
            gameScreen.Height = Height - 66 - 2;
            screenSize = Width / 10 * 9;
            gameScreen.Width = screenSize - 4;
            engine = new Engine(gameScreen.Height / cellSize, screenSize/ cellSize);
            gameScreen.Location = new Point(Width/2 - screenSize/2, 66);

            MinimumSize = new Size(Width, Height);
            MaximumSize = new Size(Width, Height);
            //await Task.Run(() => drawButton());
            //drawButton();
        }

        private void drawButton()
        {
            for (int j = 0; j + cellSize <= gameScreen.Height; j += cellSize)
                for (int i = 0; i + cellSize <= screenSize; i += cellSize)
                {
                    Button newButton = new Button();
                    newButton.Parent = gameScreen;
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

        private void buReset_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            buStop.Enabled = false;
            buPlay.Enabled = true;
            for (int linearIndex = 0; linearIndex < listBtn.Count; ++linearIndex)
                listBtn[linearIndex].BackColor = Color.Transparent;

            engine = new Engine(gameScreen.Height / cellSize, screenSize / cellSize);
            UpdateCells();
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
