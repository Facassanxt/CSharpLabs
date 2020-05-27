using Final_project_2020.Properties;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project_2020
{
    public partial class Fm : MaterialForm
    {
        private Engine engine = null;
        private static readonly Color aliveCell = Color.DimGray;
        private static readonly Color deadCell = Color.LightSlateGray;
        private const int cellSize = 40;
        private int screenSize = 900;
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
            timer.Tick += timer_Tick;
            buRnd.Click += BuRnd_Click;

            //Resize += Fm_Resize;
            startForm();
        }

        private void BuRnd_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                return;

            Random rnd = new Random();
            for (int i = 0; i < listBtn.Count; i++)
            {
                int a = rnd.Next(0, listBtn.Count);
                listBtn[a].PerformClick();
            }
        }

        private void startForm()
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height / 10 * 9;
            this.Width = Screen.PrimaryScreen.Bounds.Width / 10 * 9;
            gameScreen.Height = Height - 66 - 2;
            screenSize = Width / 10 * 9;
            gameScreen.Width = screenSize - 4;
            engine = new Engine(screenSize/ cellSize, screenSize/ cellSize);
            gameScreen.Location = new Point(Width/2 - screenSize/2, 66);

            MinimumSize = new Size(Width, Height);
            MaximumSize = new Size(Width, Height);
            drawButton();
        }

        private void drawButton()
        {
            for (int j = 0; j + cellSize <= gameScreen.Height; j += cellSize)
                for (int i = 0; i + cellSize <= screenSize; i += cellSize)
                {
                    Button newButton = new Button();
                    newButton.Size = new Size(cellSize, cellSize);
                    newButton.Location = new Point(i, j);
                    newButton.Click += ClickCell;
                    gameScreen.Controls.Add(newButton);
                    listBtn.Add(newButton);
                }

            UpdateCells();
            buReset.PerformClick();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            engine.Tick();
            Text = $"GameOfLife : {engine.Ticks.ToString()}";
            UpdateCells();
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

            engine = new Engine(screenSize / cellSize, screenSize / cellSize);
            Text = $"GameOfLife : {engine.Ticks.ToString()}";

            UpdateCells();
        }

        private void ClickCell(object sender, EventArgs e)
        {
            if (timer.Enabled)
                return;

            int buttonLinearIndex = gameScreen.Controls.IndexOf(sender as Control);
            int y = buttonLinearIndex / engine.Width;
            int x = buttonLinearIndex % engine.Width;

            engine[y, x] = !engine[y, x];
            ((Button)sender).BackColor = engine[y, x] ? aliveCell : deadCell;
            ((Button)sender).BackgroundImage = engine[y, x] ? Resources.GlowStar_16x : Resources.Blank_Star;
        }

        private void UpdateCells()
        {
            for (int linearIndex = 0; linearIndex < gameScreen.Controls.Count; ++linearIndex)
            {
                gameScreen.Controls[linearIndex].BackColor =
                    engine[linearIndex / engine.Width, linearIndex % engine.Width] ? aliveCell : deadCell;
                gameScreen.Controls[linearIndex].BackgroundImage =
                    engine[linearIndex / engine.Width, linearIndex % engine.Width] ? Resources.GlowStar_16x : Resources.Blank_Star;
                gameScreen.Controls[linearIndex].BackgroundImageLayout = ImageLayout.Center;
            }

        }

        //private void Fm_Resize(object sender, EventArgs e)
        //{
        //    gameScreen.Height = Height - 66 - 2;
        //    screenSize = gameScreen.Height + 80 * 6;
        //    screenSize = Width / 10 * 9;
        //    gameScreen.Width = screenSize - 4;
        //    gameScreen.Location = new Point(Width / 2 - gameScreen.Width / 2, 66);
        //}
    }
}
