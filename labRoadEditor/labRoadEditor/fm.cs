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
using System.Threading;
using System.Diagnostics;

namespace labRoadEditor
{
    public partial class fm : MaterialForm
    {
        public int DeltaZoom { get; private set; } = 30;
        private Bitmap b,bl;
        private Point StartPoint;
        private Point CurPoint;
        private int cX;
        private int cY;
        private int col = 40; // Сетка 
        private int row = 40; // Сетка 
        private int XYmap = 16 * 8; // Размер блока 16px * 8 (Один элмемент)
        private int AmountX = 4; // Блоков по ширине
        private int AmountY = 3; // Блоков в высоту
        private List<Rectangle> Mapparts;
        private int mode = 4; //Выбранный элемент
        private int[,] SaveMap;
        private bool DrawCellsFlag = true, RenderFlag = true;
        ImageList pics;
        Thread _REND;
        Thread _REND_Zoom;

        public fm()
        {
            InitializeComponent();

            _REND_Zoom = new Thread(REND_Zoom);
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.Blue50, Accent.Lime400, TextShade.WHITE);

            pics = new ImageList();
            pics.ImageSize = new Size(128, 128);
            Mapparts = new List<Rectangle> { };
            for (int i = 0; i < AmountX; i++)
                for (int j = 0; j < AmountY; j++)
                {
                    Mapparts.Add(new Rectangle(i * XYmap, j * XYmap, XYmap, XYmap));
                }
            for (int i = 0; i < AmountX * AmountY; i++)
            {
                Image image = Resources.road.Clone(Mapparts[i], PixelFormat.Format32bppArgb);
                pics.Images.Add(image);
            }


            PiMap.MouseDown += PiMap_MouseDown;
            PiMap.MouseMove += PiMap_MouseMove;
            PiMap.Paint += PiMap_Paint;
            Save.Click += async (s,e) => await Task.Run(() => Save_Click());
            Download.Click +=  (s, e) =>
            {
                Download_Click();
                PiMap.Refresh();
            };
            buFillin.Click += (s, e) =>
            {
                //myThread.Abort();
                b = new Bitmap(PiMap.Width*2, PiMap.Height*2);
                PiMap.Refresh();
                DrawCells();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                _REND = new Thread(REND);
                try
                {
                    _REND.Start();
                }
                catch (Exception)
                {
                    _REND.Abort();
                    _REND.Start();
                }
                PiMap.Refresh();
            };
            buX.Click += (s, e) => 
            {
                PiMap.Enabled = true;
                Save.Enabled = true;
                Download.Enabled = true;
                Cleaning.Enabled = true;
                buFillin.Enabled = true;
                buOk.Enabled = true;
                Gridsize.Enabled = true;
                label1.Enabled = true;
                checkDrawCellsFlag.Enabled = true;
                DownloadPanel.Visible = false;
            };
            Resize += Fm_Resize;
            PiSample.MouseDown += PiSample_MouseDown;
            Cleaning.Click += Cleaning_Click;
            checkDrawCellsFlag.Click += CheckDrawCellsFlag_Click;
            PiMap.MouseWheel += PiMap_MouseWheel;
            buOk.Click += BuOk_Click;
            StartForm();
        }

        private void BuOk_Click(object sender, EventArgs e)
        {
            int Size = (int)Gridsize.Value;
            if (Size > 80) DeltaZoom = 10;
            else if (Size > 50) DeltaZoom = 15;
            else if (Size > 30) DeltaZoom = 30;
            else if (Size > 20) DeltaZoom = 45;
            else if (Size > 10) DeltaZoom = 60;
            else if (Size > 0) DeltaZoom = 100;
            laZoom.Text = $"Zoom: {DeltaZoom}%";
            col = Size;
            row = Size;
            StartForm();
        }

        private void REND_Zoom()
        {
            try
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    for (int i = 0; i < col; i++)
                    {
                        for (int j = 0; j < row; j++)
                        {
                            int num = SaveMap[j, i];
                            if (num != -1 && num != 0)
                            {
                                g.DrawImage(pics.Images[num - 1], j * cX, cY * i, cX, cY);
                            }
                        }
                        this.Invoke((MethodInvoker)delegate () { PiMap.Refresh(); });
                    }
                }
                _REND_Zoom.Abort();
            }
            catch (Exception)
            {
                //
            }
        }

        private void REND()
        {
            try
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    for (int i = 0; i < col; i++)
                    {
                        for (int j = 0; j < row; j++)
                        {
                            SaveMap[j, i] = mode + 1;
                            g.DrawImage(pics.Images[mode], j * cX, cY * i, cX, cY);
                        }
                        this.Invoke((MethodInvoker)delegate () { PiMap.Refresh(); });
                    }
                }
                _REND.Abort();
            }
            catch (Exception)
            {
                //
            }

        }

        private void PiMap_MouseWheel(object sender, MouseEventArgs e)
        {
            int zoom = e.Delta > 0 ? 5 : -5;
            DeltaZoom += zoom;
            if (row > 8 || col > 8) zoom = zoom + zoom / 2;
            else if (row >= 5) zoom = -PiMap.Height / 30 / 6;
            else if (row == 4) zoom = -PiMap.Height / 30 / 4;
            else if (row == 3) zoom = -PiMap.Height / 30 / 3;
            else if (row == 2) zoom = -PiMap.Height / 30 / 2;
            else if (row ==  1) zoom = -PiMap.Height / 30;
            if (DeltaZoom < 0)
            {
                DeltaZoom = 0;
                return;
            }
            else if (DeltaZoom > 100)
            {
                DeltaZoom = 100;
                return;
            }
            else if (RenderFlag)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                bl = new Bitmap(PiMap.Width * 2, PiMap.Height * 2);
                laZoom.Text = $"Zoom: {DeltaZoom}%";
                cX += zoom;
                cY += zoom;
                b = new Bitmap(PiMap.Width*2, PiMap.Height*2);
                PiMap.Refresh();
                DrawCells();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                try
                {
                    _REND_Zoom.Start();
                }
                catch (Exception)
                {
                    _REND_Zoom.Abort();
                    _REND_Zoom = new Thread(REND_Zoom);
                    _REND_Zoom.Start();
                }
            }
        }

        private async void CheckDrawCellsFlag_Click(object sender, EventArgs e)
        {
            if (checkDrawCellsFlag.Checked) DrawCellsFlag = false;
            else DrawCellsFlag = true;
            bl = new Bitmap(PiMap.Width * 2, PiMap.Height * 2);
            await Task.Run(() => DrawCells()); //Асинхонный метод (Позволяет сократить время отрисовки + убирает длительное провисание)
            PiMap.Refresh();
        }

        private async void StartForm()
        {
            this.Height = 1080;
            this.Width = 1920;
            PiMap.Height = 2000;
            PiMap.Width = 2000;

            b = new Bitmap(PiMap.Width*2, PiMap.Height*2);
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
            laZoom.Parent = PiMap;
            laZoom.Location = new Point(10 + PiPreview.Width + 10, AllPanel.Height - 10 - PiSample.Height - XYPiSample.Height - laZoom.Height);
            PiPreview.Image = Resources.road.Clone(Mapparts[mode], PixelFormat.Format32bppArgb);

            DownloadPanel.Location = new Point(Width/2 - DownloadPanel.Width/2, Height/2 - DownloadPanel.Height / 2);
            SaveMap = new int[col, row];
            for (int i = 0; i < col; i++)
                for (int j = 0; j < row; j++)
                {
                    SaveMap[j, i] = -1;
                }

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
                        if (EndPointX < col && EndPointY < row)
                        {
                            Image image = Resources.road.Clone(Mapparts[mode], PixelFormat.Format32bppArgb);
                            g.DrawImage(image, EndPointX * cX, cY * EndPointY, cX, cY);
                            SaveMap[EndPointX, EndPointY] = mode + 1;
                            XYPiSample.Text = $"| {EndPointX} | {EndPointY} |";
                            PiMap.Refresh();
                        }
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
                        XYPiSample.Text = $"| {EndPointX} | {EndPointY} |";
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
                        LaPreview.Text = $"Preview: {x}|{y}";
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
            laZoom.Location = new Point(10 + PiPreview.Width + 10, AllPanel.Height - 10 - PiSample.Height - XYPiSample.Height - laZoom.Height);
        }
        private void ResizeCells()
        {
            cX = PiMap.Width / col;
            cY = PiMap.Height / row;
        }
        private void DrawCells()
        {   
            using (Graphics g = Graphics.FromImage(bl))
            {
                g.DrawLine(new Pen(Color.White, 1), 0, 0, col * cX, row * cY); // Диагональ ⤡
                g.DrawLine(new Pen(Color.White, 1), 0, cY * row, cX * col, 0); // Диагональ ⤢
                g.DrawLine(new Pen(Color.Beige, 5), 0, 0, cX * col, 0); // Линия ➜ 🗘
                g.DrawLine(new Pen(Color.Beige, 5), cX * col, 0, cX * col, cY * row); // Линия 🠗
                g.DrawLine(new Pen(Color.Beige, 5), cX * col, cY * row, 0, cX * col); // Линия 🠔
                g.DrawLine(new Pen(Color.Beige, 5), 0, cY * row, 0, 0); // Линия 🠕
                if (DrawCellsFlag)
                    for (int i = 0; i < col; i++) 
                    {
                        g.DrawLine(new Pen(Color.Silver, 1), i * cX, 0, i * cX, row * cY);
                        for (int j = 0; j < row; j++)
                        {
                            g.DrawLine(new Pen(Color.Silver, 1), 0, j * cY, col * cX, j * cY);
                        }
                    }

                this.Invoke((MethodInvoker)delegate () { PiMap.Refresh(); });
            } 
        }
        private async void Cleaning_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            b = new Bitmap(PiMap.Width * 2, PiMap.Height*2);
            bl = new Bitmap(PiMap.Width * 2, PiMap.Height * 2);
            Array.Clear(SaveMap, 0, SaveMap.Length);
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
                        if (SaveMap[j, i] == 0 || SaveMap[j, i] == -1)
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
        private void Download_Click() 
        {
            //b = new Bitmap(PiMap.Width * 2, PiMap.Height * 2);
            //bl = new Bitmap(PiMap.Width * 2, PiMap.Height * 2);
            //await Task.Run(() => DrawCells());
            //Array.Clear(SaveMap, 0, SaveMap.Length);
            PiMap.Enabled = false;
            Save.Enabled = false;
            Download.Enabled = false;
            Cleaning.Enabled = false;
            buFillin.Enabled = false;
            buOk.Enabled = false;
            Gridsize.Enabled = false;
            label1.Enabled = false;
            checkDrawCellsFlag.Enabled = false;


            buX.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buX.FlatAppearance.MouseDownBackColor = Color.Transparent;
            DownloadPanel.Visible = true;
        }
        private async void Download_File_Click()
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
                if ((int)Gridsize.Value <= 2)
                {
                    DialogResult rezult = MessageBox.Show("Размер слишком мал, Увеличьте сетку",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if ((int)Gridsize.Value < lines.Length)
                {
                    col = lines.Length; // Сетка 
                    row = lines.Length; // Сетка 
                    StartForm();
                    Gridsize.Value = lines.Length;
                }
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
                                await Task.Run(() =>
                                {
                                    g.DrawImage(pics.Images[num - 1], j * cX, cY * i, cX, cY);
                                    SaveMap[j, i] = num;
                                });
                            }
                            else SaveMap[j, i] = -1;
                        }
                    }
                }
                this.Invoke((MethodInvoker)delegate () { PiMap.Refresh(); });
            }
            catch
            {
                DialogResult rezult = MessageBox.Show("Непредвиденная ошибка",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Invoke((MethodInvoker)delegate () { PiMap.Refresh(); });
        }
    }
}