using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace labPaint
{
    public partial class fm : MaterialForm
    {
        private bool isPressed;
        private Point prevPoint;
        private Bitmap b;
        int x, y = 0;
        private int mode;

        public fm()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.Blue50, Accent.Lime400, TextShade.WHITE);

            paImage.MouseDown += PaImage_MouseDown;
            paImage.MouseUp += PaImage_MouseUp;
            paImage.MouseMove += PaImage_MouseMove;
            paImage.Paint += PaImage_Paint;
            Resize += Fm_Resize;
            StartFormPosition();
            toolsBar.ImageList = imageList;
            intitModePanel(toolsBar.Buttons.Cast);
        }

        private void StartFormPosition()
        {
            toolsBar.Location = new Point(0, 64);
            toolsBar.Height = this.Height - 64;
            instpanel.Location = new Point(toolsBar.Width, 64);
            instpanel.Height = 60;
            instpanel.Width = this.Width - toolsBar.Width - 1;
            paImage.Location = new Point(toolsBar.Width, instpanel.Location.Y + instpanel.Height);
            paImage.Height = this.Height - 64 - instpanel.Height - 1;
            paImage.Width = this.Width - toolsBar.Width - 1;
            b = new Bitmap(paImage.Width, paImage.Height);
        }

        private void Fm_Resize(object sender, EventArgs e)
        {
            toolsBar.Height = this.Height - 64;
            instpanel.Width = this.Width - toolsBar.Width - 1;
            paImage.Height = this.Height - 64 - instpanel.Height - 1;
            paImage.Width = this.Width - toolsBar.Width - 1;
            b = new Bitmap(paImage.Width, paImage.Height);
        }

        private void PaImage_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(b, new Point(0, 0));
        }

        private void PaImage_MouseMove(object sender, MouseEventArgs e)
        {
            MouseLocation.Text = e.Location.ToString();
            if (!isPressed) return;
            var g = Graphics.FromImage(b);
            g.DrawLine(new Pen(Color.Red, 5), new Point(x, y), e.Location);
            g.DrawLine(new Pen(Color.Red, 5), e.X, e.Y - 1, e.X, e.Y + 1);
            g.DrawLine(new Pen(Color.Red, 5), e.X + 1, e.Y, e.X - 1, e.Y);
            x = e.X;
            y = e.Y;
            g.Dispose();
            paImage.CreateGraphics().DrawImage(b, new Point(0, 0));
            MouseLocation.Text = e.Location.ToString();
        }

        private void PaImage_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void PaImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isPressed = true;
                x = e.X;
                y = e.Y;
                MouseLocation.Text = e.Location.ToString();
            }
        }
        private void intitModePanel(List<Button> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Click += ClickButtonsOnPanelMode;
            }
        }

        private void ClickButtonsOnPanelMode(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                switch (Convert.ToInt32(((Button)sender).Tag))
                {
                    case 0:
                        mode = 0;
                        break;
                    case 1:
                        mode = 1;
                        break;
                    case 2:
                        mode = 2;
                        break;
                    case 3:
                        mode = 3;
                        break;
                    case 4:
                        mode = 4;
                        break;
                    case 5:
                        mode = 5;
                        break;
                    case 6:
                        mode = 6;
                        break;
                }
            }
        }
        private void PaImage_MouseClick(object sender, MouseEventArgs e)
        {
            switch (mode)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    penDraw(e);
                    break;
                case 4:
                    drawRectangle(e);
                    break;
                case 5:
                    drawCircle(e);
                    break;
                case 6:
                    drawLine(e);
                    break;
            }
        }
    }
}
