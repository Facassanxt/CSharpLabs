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
using System.Runtime.InteropServices;
using labRoadEditor.Properties;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;

namespace labRoadEditor
{
    public partial class fm : MaterialForm
    {
        private Bitmap b, bl;
        private Point StartPoint;
        private Point CurPoint;
        private int cX;
        private int cY;
        private int col = 40; // Сетка 
        private int row = 40; // Сетка 
        private int XYmap = 32 * 8; // Размер блока 32px * 8 (Один элмемент)
        private int AmountX = 4; // Блоков по ширине
        private int AmountY = 3; // Блоков в высоту
        private List<Rectangle> Mapparts;
        private int mode = 4; //Выбранный элемент
        private int[,] SaveMap;
        private bool DrawCellsFlag = true;
        public fm()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.Blue50, Accent.Lime400, TextShade.WHITE);

            Mapparts = new List<Rectangle> { };
            for (int i = 0; i < AmountX; i++)
                for (int j = 0; j < AmountY; j++)
                {
                    Mapparts.Add(new Rectangle(i * XYmap, j * XYmap, XYmap, XYmap));
                }

            PiMap.MouseDown += PiMap_MouseDown;
            PiMap.MouseMove += PiMap_MouseMove;
            PiMap.Paint += PiMap_Paint;
            Save.Click += async (s,e) => await Task.Run(() => Save_Click());
            Download.Click += async (s, e) =>
            {
                b = new Bitmap(PiMap.Width, PiMap.Height);
                bl = new Bitmap(PiMap.Width, PiMap.Height);
                await Task.Run(() => DrawCells()); //Асинхонный метод (Позволяет сократить время отрисовки + убирает длительное провисание)
                SaveMap = new int[col, row];
                await Task.Run(() => Download_Click());//Асинхонный метод (Позволяет сократить время Загрузки и отрисовки + убирает длительное провисание)
                PiMap.Refresh();
            };
            Resize += Fm_Resize;
            PiSample.MouseDown += PiSample_MouseDown;
            Cleaning.Click += Cleaning_Click;
            checkDrawCellsFlag.Click += CheckDrawCellsFlag_Click;
            StartForm();
        }
        private async void CheckDrawCellsFlag_Click(object sender, EventArgs e)
        {
            if (checkDrawCellsFlag.Checked) DrawCellsFlag = false;
            else DrawCellsFlag = true;
            bl = new Bitmap(PiMap.Width, PiMap.Height);
            await Task.Run(() => DrawCells()); //Асинхонный метод (Позволяет сократить время отрисовки + убирает длительное провисание)
            PiMap.Refresh();
        }

        private async void StartForm()
        {
            this.Height = 1080;
            this.Width = 1920;
            PiMap.Height = 4000;
            PiMap.Width = 4000;

            b = new Bitmap(PiMap.Width, PiMap.Height);
            bl = new Bitmap(PiMap.Width, PiMap.Height);
            ResizeCells();
            await Task.Run(() => DrawCells()); //Асинхонный метод (Позволяет сократить время отрисовки + убирает длительное провисание)

            PiPreview.Width = 8 * 20;
            PiPreview.Height = 8 * 20;
            PiSample.Width = 32 * 10;
            PiSample.Height = 24 * 10;
            AllPanel.Width = Width - 4;
            AllPanel.Height = Height - 64 - 2;
            AllPanel.Location = new Point(2, 64);
            PiMap.Location = new Point(0, 0);
            PiSample.Location = new Point(10, Height - PiSample.Height - 10);
            PiPreview.Location = new Point(10, PiSample.Location.Y - PiPreview.Height - 10);
            LaPreview.Parent = PiMap;
            LaPreview.Location = new Point(4, AllPanel.Height - 10 - PiSample.Height - 10 - PiPreview.Height - LaPreview.Height);
            XYPiSample.Parent = PiMap;
            XYPiSample.Location = new Point(10 + PiPreview.Width + 10, AllPanel.Height - 10 - PiSample.Height - XYPiSample.Height);
            PiPreview.Image = Resources.road.Clone(Mapparts[mode], PixelFormat.Format32bppArgb);
            SaveMap = new int[col, row];

            PiMap.Refresh();
        }
        private void PiMap_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(b, CurPoint);
            e.Graphics.DrawImage(bl, CurPoint);
        }
        private void PiMap_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (PiMap.Capture)
                    {
                        CurPoint.X += e.X - StartPoint.X;
                        CurPoint.Y += e.Y - StartPoint.Y;
                        StartPoint = e.Location;
                        PiMap.Refresh();
                    }
                }
                else if (e.Button == MouseButtons.Left)
                {
                    using (Graphics g = Graphics.FromImage(b))
                    {
                        g.SmoothingMode = SmoothingMode.HighQuality;
                        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        int EndPointX = (e.X - CurPoint.X) / cX;
                        int EndPointY = (e.Y - CurPoint.Y) / cY;
                        Image image = Resources.road.Clone(Mapparts[mode], PixelFormat.Format32bppArgb);
                        g.DrawImage(image, EndPointX * cX, cY * EndPointY, cX, cY);
                        SaveMap[EndPointX, EndPointY] = mode + 1;
                        PiMap.Refresh();
                    }
                }
            }
            catch
            {
                //
            }
        }
        private void PiMap_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = e.Location;
            if (e.Button == MouseButtons.Left) 
            {
                try
                {
                    using (Graphics g = Graphics.FromImage(b))
                    {
                        g.SmoothingMode = SmoothingMode.HighQuality;
                        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        int EndPointX = (e.X - CurPoint.X) / cX;
                        int EndPointY = (e.Y - CurPoint.Y) / cY;
                        Image image = Resources.road.Clone(Mapparts[mode], PixelFormat.Format32bppArgb);
                        g.DrawImage(image, EndPointX * cX, cY * EndPointY, cX, cY);
                        SaveMap[EndPointX, EndPointY] = mode + 1;
                    }
                    PiMap.Refresh();
                }
                catch
                {
                    //
                }
            }
        }
        private void PiSample_MouseDown(object sender, MouseEventArgs e)
        {
            int Count = 0;
            int x = e.X * AmountX / PiSample.Width;
            int y = e.Y * AmountY / PiSample.Height;
            for (int i = 0; i < AmountX; i++)
                for (int j = 0; j < AmountY; j++)
                    if (i == x && j == y)
                    {
                        PiPreview.Image = Resources.road.Clone(Mapparts[Count], PixelFormat.Format32bppArgb);
                        mode = Count;
                        XYPiSample.Text = $"{{ {x} : {y} }}";
                        return;
                    }
                    else Count++;
        }
        private void Fm_Resize(object sender, EventArgs e)
        {
            AllPanel.Width = Width - 4;
            AllPanel.Height = Height - 64 - 2;
            AllPanel.Location = new Point(2, 64);
            LaPreview.Location = new Point(4, AllPanel.Height - 10 - PiSample.Height - 10 - PiPreview.Height - LaPreview.Height);
            XYPiSample.Location = new Point(10 + PiPreview.Width + 10, AllPanel.Height - 10 - PiSample.Height - XYPiSample.Height);
        }
        private void ResizeCells()
        {
            cX = PiMap.Width / col;
            cY = PiMap.Height / row;
        }
        private async void DrawCells()
        {
            using (Graphics g = Graphics.FromImage(bl))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                if (DrawCellsFlag) 
                    for (int i = 0; i <= row; i++) 
                    {
                        for (int j = 0; j <= col; j++)
                        {
                            await Task.Run(() =>
                            {
                                g.DrawLine(new Pen(Color.Silver), 0, i * cY, col * cX, i * cY);
                                g.DrawLine(new Pen(Color.Silver, 1), j * cX, 0, j * cX, row * cY);
                            });
                        }
                        if( i % 10 == 0) this.Invoke((MethodInvoker)delegate () { PiMap.Refresh(); });
                    }
                await Task.Run(() => 
                {
                    g.DrawLine(new Pen(Color.White, 1), 0, 0, col * cX, row * cY); // Диагональ ⤡
                    g.DrawLine(new Pen(Color.White, 1), 0, cY * row, cX * col, 0); // Диагональ ⤢
                    g.DrawLine(new Pen(Color.Beige, 5), 0, 0, cX * col, 0); // Линия ➜ 🗘
                    g.DrawLine(new Pen(Color.Beige, 5), cX * col, 0, cX * col, cY * row); // Линия 🠗
                    g.DrawLine(new Pen(Color.Beige, 5), cX * col, cY * row, 0, cX * col); // Линия 🠔
                    g.DrawLine(new Pen(Color.Beige, 5), 0, cY * row, 0, 0); // Линия 🠕
                    this.Invoke((MethodInvoker)delegate () { PiMap.Refresh(); });
                } );

            } 
        }
        private async void Cleaning_Click(object sender, EventArgs e)
        {
            b = new Bitmap(PiMap.Width, PiMap.Height);
            bl = new Bitmap(PiMap.Width, PiMap.Height);
            SaveMap = new int[col, row];
            await Task.Run(() => DrawCells()); //Асинхонный метод (Позволяет сократить время отрисовки + убирает длительное провисание)
            PiMap.Refresh();
        }
        private void Save_Click()
        {
            String fullPath = Application.StartupPath.ToString();
            try
            {
                if (!Directory.Exists($"{ fullPath }\\cfg"))
                {
                    Directory.CreateDirectory($"{ fullPath }\\cfg");
                }
                StreamWriter strwrt = new StreamWriter($"{ fullPath }\\cfg\\MapRoad.txt", false);
                for (int i = 0; i < col; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        if (SaveMap[j, i] == 0)
                        {
                            strwrt.Write("*|");
                        }
                        else
                        {
                            strwrt.Write($"{SaveMap[j, i]}|");
                        }
                    }
                    strwrt.WriteLine();
                }
                strwrt.Close();

            }
            catch
            {
                DialogResult rezult = MessageBox.Show("Непредвиденная ошибка",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void Download_Click()
        {
            String fullPath = Application.StartupPath.ToString();
            try
            {
                if (!Directory.Exists($"{ fullPath }\\cfg"))
                {
                    DialogResult rezult = MessageBox.Show("Директория не найдена.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!File.Exists($"{ fullPath }\\cfg\\MapRoad.txt"))
                {
                    DialogResult rezult = MessageBox.Show("Файл для загрузки не найден или еще не был создан.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string[] lines = File.ReadAllLines($"{ fullPath }\\cfg\\MapRoad.txt");
                using (Graphics g = Graphics.FromImage(b))
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] temp = lines[i].Split('|');
                        for (int j = 0; j < temp.Length - 1; j++)
                        {
                            if (temp[j] != "*")
                            {
                                int num = Int32.Parse(temp[j]);
                                Image image = Resources.road.Clone(Mapparts[num - 1], PixelFormat.Format32bppArgb);
                                SaveMap[j, i] = num;
                                await Task.Run(() => 
                                {
                                    g.DrawImage(image, j * cX, cY * i, cX, cY);
                                });
                            }
                        }
                        this.Invoke((MethodInvoker)delegate () { PiMap.Refresh(); });
                    }
                }
            }
            catch
            {
                DialogResult rezult = MessageBox.Show("Непредвиденная ошибка",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}