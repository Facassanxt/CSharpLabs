using labPazzle.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labPazzle
{
    public partial class fm : Form
    {
        public int Rows { get; private set; } = 3;
        public int Cols { get; private set; } = 4;
        private PictureBox[,] pics;
        private Point startPoint;

        public fm()
        {
            InitializeComponent();

            CreateCells();
            StartLocationCells();
            ResizeCells();
            this.Text += " (F1 - Собрать, F2 - Перемешать, F3 - Новый размер)";
            this.KeyDown += Fm_KeyDown;
            //RandomCells();

        }

        private void Fm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    StartLocationCells();
                    break;
                case Keys.F2:
                    RandomCells();
                    break;
                case Keys.F3:
                    StartLocationCells();
                    ResizeCells();
                    break;
                default:
                    break;
            }
        }

        private void RandomCells()
        {
            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    pics[i, j].Location = new Point(
                        rnd.Next(ClientSize.Width - pics[i, j].Width),
                        rnd.Next(ClientSize.Height - pics[i, j].Height)
                        );
                }
        }

        private void ResizeCells()
        {
            int xCellWidth = ClientSize.Width / Cols;
            int xCellHeight = ClientSize.Height / Rows;
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    pics[i, j].Width = xCellWidth;
                    pics[i, j].Height = xCellHeight;
                    pics[i, j].Image = new Bitmap(xCellWidth, xCellHeight);
                    var g = Graphics.FromImage(pics[i, j].Image);
                    //g.Clear(Color.LightGreen);
                    g.DrawImage(Resources.pic1,
                        new Rectangle(0,0,pics[i,j].Width,pics[i,j].Height),
                        new Rectangle(j * xCellWidth, i * xCellHeight, xCellWidth, xCellHeight),
                        GraphicsUnit.Pixel);
                    g.Dispose();
                }
        }

        private void StartLocationCells()
        {
            int xCellWidth = ClientSize.Width / Cols;
            int xCellHeight = ClientSize.Height / Rows;
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    pics[i, j].Location = new Point(j * xCellWidth + 10, i * xCellHeight + 10);
                }
        }

        private void CreateCells()
        {
            pics = new PictureBox[Rows, Cols];
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    pics[i, j] = new PictureBox();
                    pics[i, j].BorderStyle = BorderStyle.FixedSingle;
                    pics[i, j].MouseDown += PictureBoxAll_MouseDown;
                    pics[i, j].MouseMove += PictureBoxAll_MouseMove;
                    this.Controls.Add(pics[i, j]);
                }
        }

        private void PictureBoxAll_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point x = new Point(Cursor.Position.X - startPoint.X, Cursor.Position.Y - startPoint.Y);
                if (sender is Control b)
                {
                    b.BringToFront();
                    ((Control)sender).Location = PointToClient(x);
                }
            }
        }

        private void PictureBoxAll_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(e.X, e.Y);
        }
    }
}
