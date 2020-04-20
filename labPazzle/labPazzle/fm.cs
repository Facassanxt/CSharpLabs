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

        private int curRow;
        private int curCol;
        private Bitmap b;
        private int xCellWidth;
        private int xCellHeight;
        private PictureBox[,] pics;
        private Point startPoint;
        Image pazzle;

        /* Динамическая сетка F4 +
         * Выбор картинок F5 +
         * Фулскрин картинка +
         * Картинки Показывают куда притянутся и притягиваются к сетке +
         * Картинки нельзя выкинуть за край +
         * Картинки нельзя накладывать друг на друга +
         * Проверка на полную сборку +
         */

        public fm()
        {
            InitializeComponent();

            CreateCells();
            StartLocationCells();
            pazzle = Resources.pic1 as Image;
            ResizeCells(pazzle);
            DrawCells();
            this.Text += $"(F1 - Собрать, F2 - Перемешать, F3 - Перестроить F4 - Новый размер F5 - Новая картинка) { curRow} {curCol} {Rows} {Cols}";
            this.KeyDown += Fm_KeyDown;
            this.Paint += Fm_Paint;
            this.Resize += Fm_Resize;
        }


        private void Fm_Resize(object sender, EventArgs e)
        {
            //ResizeCells();
            //DrawCells();
            this.CreateGraphics().DrawImage(b, new Point(0, 0));

        }
        private void Fm_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImage(b, new Point(0, 0));
        }
        private void DrawCells()
        {
            //var g = Graphics.FromImage(b);
            //g.Dispose();

            using (var g = Graphics.FromImage(b))
            {
                for (int i = 0; i < Rows; i++)
                {
                    g.DrawLine(new Pen(Color.LightBlue, 1), 0, i * xCellHeight, Cols * xCellWidth, i * xCellHeight);
                }

                for (int j = 0; j < Cols; j++)
                {
                    g.DrawLine(new Pen(Color.LightBlue, 1), j * xCellWidth, 0, j * xCellWidth, Rows * xCellHeight);
                }
            }
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
                    ResizeCells(pazzle);
                    break;
                case Keys.F4:
                    Efm Dialog = new Efm(Rows, Cols);
                    if(Dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        Cols = Dialog.getCol();
                        Rows = Dialog.getRow();
                        Controls.Clear();
                        b = null;
                        pics = null;
                        CreateCells();
                        StartLocationCells();
                        ResizeCells(pazzle);
                        DrawCells();
                    }
                    break;
                case Keys.F5:
                    downloadNewPhoto();
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

        private void downloadNewPhoto()
        {
            Bitmap image; //Bitmap для открываемого изображения

            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    pazzle = image as Image;
                    ResizeCells(pazzle);
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResizeCells(Image pazzle)
        {
            //namepic = Resources.pic1 as Image;
            b = new Bitmap(pazzle, new Size(ClientSize.Width, ClientSize.Height));

            xCellWidth = ClientSize.Width / Cols;
            xCellHeight = ClientSize.Height / Rows;

            int ImageHeight = pazzle.Height / Rows;
            int ImageWidth = pazzle.Width / Cols;

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    pics[i, j].Width = xCellWidth;
                    pics[i, j].Height = xCellHeight;
                    pics[i, j].Image = new Bitmap(xCellWidth, xCellHeight);
                    var g = Graphics.FromImage(pics[i, j].Image);
                    //g.Clear(Color.LightGreen);
                    g.DrawImage(pazzle,
                        new Rectangle(0,0,pics[i,j].Width,pics[i,j].Height),
                        new Rectangle(j * ImageWidth, i * ImageHeight, ImageWidth, ImageHeight),
                        GraphicsUnit.Pixel);

                    g.Dispose();
                }
        }

        private void StartLocationCells()
        {
            xCellWidth = ClientSize.Width / Cols;
            xCellHeight = ClientSize.Height / Rows;
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    pics[i, j].Location = new Point(j * xCellWidth, i * xCellHeight);
                }
        }

        private void CreateCells()
        {
            pics = new PictureBox[Rows, Cols];
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    pics[i, j] = new PictureBox();
                    pics[i, j].SendToBack();
                    pics[i, j].BorderStyle = BorderStyle.FixedSingle;
                    pics[i, j].MouseDown += PictureBoxAll_MouseDown;
                    pics[i, j].MouseMove += PictureBoxAll_MouseMove;
                    pics[i, j].MouseUp += PictureBoxAll_MouseUp;
                    this.Controls.Add(pics[i, j]);
                }
        }
        private void PictureBoxAll_MouseUp(object sender, MouseEventArgs e)
        {
            Point pos = new Point(Cursor.Position.X - startPoint.X, Cursor.Position.Y - startPoint.Y);
            var XY = PointToClient(pos);
            if (curRow < Rows && curCol < Cols && curRow >= 0 && curCol >= 0 && XY.Y > -xCellHeight/2 && XY.X > -xCellWidth/2)
            {
                Point x = new Point(curCol * xCellWidth, curRow * xCellHeight);
                Boolean flag = false;
                if (sender is Control a)
                {
                    for (int i = 0; i < Rows; i++)
                        for (int j = 0; j < Cols; j++)
                            if (pics[i, j].Location == x)
                            {
                                flag = true;
                                return;
                            }
                    if (!flag)
                    {
                        a.Location = x;
                        a.SendToBack();
                        int win = 0;
                        for (int i = 0; i < Rows; i++)
                            for (int j = 0; j < Cols; j++)
                            {
                                Point pwin = new Point(j * xCellWidth, i * xCellHeight);
                                if (pics[i, j].Location == pwin) win++;
                            }
                        if (win == Rows * Cols)
                        {
                            MessageBox.Show("WIN");
                        }
                    }
                }
            }
            else 
            {
                if (sender is Control a)
                    a.Location = startPoint;
            }
        }

        private void PictureBoxAll_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point x = new Point(Cursor.Position.X - startPoint.X, Cursor.Position.Y - startPoint.Y);
                if (sender is Control a)
                {
                    a.BringToFront();
                    var XY = PointToClient(x);
                    a.Location = XY;
                    curRow = (XY.Y + xCellHeight / 2) / xCellHeight;
                    curCol = (XY.X + xCellWidth / 2) / xCellWidth;
                    if (curRow < Rows && curCol < Cols && curRow >= 0 && curCol >= 0)
                    {
                        using (var g = Graphics.FromImage(b))
                        {
                            g.Clear(DefaultBackColor);
                            g.DrawRectangle(new Pen(Color.Red, 4), curCol * xCellWidth, curRow * xCellHeight, xCellWidth, xCellHeight);
                        }
                        this.CreateGraphics().DrawImage(b, new Point(0, 0));
                        Text = $" (F1 - Собрать, F2 - Перемешать, F3 - Перестроить F4 - Новый размер F5 - Новая картинка) { curRow} {curCol} {Rows} {Cols}";
                    }
                }
            }
        }

        private void PictureBoxAll_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(e.X, e.Y);
        }
    }
}
