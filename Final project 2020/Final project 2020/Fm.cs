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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Final_project_2020
{
    public partial class Fm : MaterialForm
    {
        private Engine engine = null;
        private const int cellSize = 30;
        private int screenSize;
        List<Button> listBtn = new List<Button> { };
        Random rnd = new Random();

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
            timer.Tick += Timer_Tick;


            startForm();
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
            await Task.Run(() => 
            {
                for (int i = 0; i < listBtn.Count; i++)
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
            drawButton();
            UpdateCells();

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
                    newButton.BackColor = Color.LightSlateGray;
                    newButton.BackgroundImageLayout = ImageLayout.Center;
                    newButton.BackgroundImage = Resources.Blank_Star;
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
            ((Button)sender).BackgroundImage = engine[y, x] ? Resources.GlowStar_16x : Resources.Blank_Star;
        }

        private void UpdateCells()
        {
            for (int linearIndex = 0; linearIndex < listBtn.Count; ++linearIndex)
            {
                int x = linearIndex / engine.Width;
                int y = linearIndex % engine.Width;
                if (engine[x, y])
                {
                    this.Invoke((MethodInvoker)delegate () { listBtn[linearIndex].BackgroundImage = Resources.GlowStar_16x; });
                }
                else 
                {
                    listBtn[linearIndex].BackgroundImage = Resources.Blank_Star;
                }
            }
        }
    }
}
