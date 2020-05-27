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
        private const int screenSize = 900;

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

            Resize += Fm_Resize;
            Load += Fm_Load;
            startForm();
        }

        private void startForm()
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height / 3 * 2;
            this.Width = Screen.PrimaryScreen.Bounds.Width / 3 * 2;
            gameScreen.Height = Height - 64 - 2;
            gameScreen.Width = Width - 4;

            engine = new Engine(gameScreen.Width / cellSize, gameScreen.Height / cellSize);


            gameScreen.Location = new Point(2, 64);
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

            engine = new Engine(engine.Height, engine.Width);
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
                gameScreen.Controls[linearIndex].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            }

        }

        private void Fm_Load(object sender, EventArgs e)
        {
            for (int j = 0; j + cellSize <= gameScreen.Height; j += cellSize)
                for (int i = 0; i + cellSize <= gameScreen.Width; i += cellSize)
                {
                    Button newButton = new Button();
                    newButton.Size = new Size(cellSize, cellSize);
                    newButton.Location = new Point(i, j);
                    newButton.Click += ClickCell;
                    gameScreen.Controls.Add(newButton);
                }

            UpdateCells();
            buReset_Click(sender, e);
        }

        private void Fm_Resize(object sender, EventArgs e)
        {
           
        }
    }
}
