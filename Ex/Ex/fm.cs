using Ex.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex
{
    public partial class fm : MaterialForm
    {
        private Bitmap b, b_line;
        List<Button> listBtn = new List<Button> { };
        private bool DrawCellsFlag = true;
        private int[,] SaveMap;
        private int SizeMap = 100;
        private int cX, cY, XYmap = 32, DelataZoom = 5, BugError = 0;
        private int pSX, pSY;
        private int AmountX = 15; // Блоков по ширине
        private int AmountY = 6; // Блоков в высоту
        private int mode = 23; //Выбранный элемент
        private Point CurPoint, StartPoint,Person_Location;
        private List<Rectangle> Mapparts;
        private List<Rectangle> list_collision;
        private List<Rectangle> list_collision_items;
        ImageList pics;
        Thread _REND, _REND_Zoom;
        private bool flag = true, person = false;
        private static System.Threading.Timer timer_map;
        public fm()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.Blue50, Accent.Lime400, TextShade.WHITE);

            Size_setting f = new Size_setting();
            if (f.ShowDialog() == DialogResult.OK) SizeMap = f.SizeMAP();

            buCFG.Click += (s, e) => { System.Diagnostics.Process.Start("explorer", ".\\cfg"); };
            Download.Click += (s, e) => Download_Click();
            PiMap.Paint += (s, e) => { this.Invoke((MethodInvoker)delegate () { e.Graphics.DrawImage(b, CurPoint); e.Graphics.DrawImage(b_line, CurPoint); }); };
            PiPreviewMAP.Paint += (s, e) => {  e.Graphics.DrawImage(b, 0, 0, PiPreviewMAP.Width, PiPreviewMAP.Height); };
            buPlayGame.Click += (s, e) => 
            {
                int _cX = 60;
                int _cY = 60;
                Bitmap b_game = new Bitmap(b, SizeMap * _cX, SizeMap * _cY);
                list_collision = new List<Rectangle> { };
                list_collision_items = new List<Rectangle> { };
                using (Graphics g = Graphics.FromImage(b_game))
                {
                    g.Clear(Color.Transparent);
                    for (int i = 0; i < SizeMap; i++)
                        for (int j = 0; j < SizeMap; j++)
                        {
                            int num = SaveMap[j, i];
                            if (num != -1 && num != 0)
                                g.DrawImage(pics.Images[num - 1], j * _cX, _cY * i, _cX, _cY);
                            int[] collision = {0, 1, 36, 53, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 84, 85, 86, 87, 88, 89 };
                            foreach (int cheslo in collision)
                                if (num - 1 == cheslo)
                                    if (num - 1 == 0 || num - 1 == 1)
                                    {
                                        list_collision_items.Add(new Rectangle(j * _cX, _cY * i, _cX, _cY));
                                    }
                                    else
                                    {
                                        list_collision.Add(new Rectangle(j * _cX, _cY * i, _cX, _cY));
                                    }
                        }
                }
                Game game = new Game(b_game, Person_Location, list_collision, list_collision_items, pics);
                game.Show();
            };
            Resize += Fm_Resize;
            PiSample.MouseDown += PiSample_MouseDown;
            PiMap.MouseDown += PiMap_MouseDown;
            PiMap.MouseMove += PiMap_MouseMove;
            PiMap.MouseUp += PiMap_MouseUp;
            PiMap.MouseWheel += PiMap_MouseWheel;
            checkDrawCellsFlag.Click += CheckDrawCellsFlag_Click;
            Save.Click += async (s, e) => await Task.Run(() => 
            {
                Save_Load save_form = new Save_Load();
                save_form.Save(SaveMap, SizeMap);
            });
            Cleaning.Click += Cleaning_Click;
            piHere.Click += (s, e) => { person = true; };
            buX.Click += (s, e) =>
            {
                DownloadPanel.Visible = false;
                laDownload.Visible = false;
                buX.Visible = false;
                PiMap.Enabled = true;
                Save.Enabled = true;
                Download.Enabled = true;
                Cleaning.Enabled = true;
                buFillin.Enabled = true;
            };

            buFillin.Click += (s, e) =>
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                if (flag)
                {
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
                }
            };


            StartForm();
            timer_map = new System.Threading.Timer(new TimerCallback(TickTimer), null, 1000, 1000);
        }

        private void PiMap_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.XButton1 || e.Button == MouseButtons.XButton2)
                {
                    using (Graphics g = Graphics.FromImage(b))
                    {
                        if (pSY > (e.Y - CurPoint.Y) / cY && pSX > (e.X - CurPoint.X) / cX)
                        {
                            for (int i = (e.X - CurPoint.X) / cX; i <= pSX - 1; i++)
                                for (int j = (e.Y - CurPoint.Y) / cY; j <= pSY - 1; j++)
                                    if (i < SizeMap && j < SizeMap)
                                    {
                                        SaveMap[i, j] = mode + 1;
                                        g.DrawImage(pics.Images[mode], i * cX, cY * j, cX, cY);
                                    }
                        }
                        else if (pSY <= (e.Y - CurPoint.Y) / cY && pSX > (e.X - CurPoint.X) / cX)
                        {
                            for (int i = (e.X - CurPoint.X) / cX; i <= pSX - 1; i++)
                                for (int j = pSY; j <= (e.Y - CurPoint.Y) / cY; j++)
                                    if (i < SizeMap && j < SizeMap)
                                    {
                                        SaveMap[i, j] = mode + 1;
                                        g.DrawImage(pics.Images[mode], i * cX, cY * j, cX, cY);
                                    }
                        }
                        else if (pSY > (e.Y - CurPoint.Y) / cY)
                        {
                            for (int i = pSX; i <= (e.X - CurPoint.X) / cX; i++)
                                for (int j = (e.Y - CurPoint.Y) / cY; j <= pSY - 1; j++)
                                    if (i < SizeMap && j < SizeMap)
                                    {
                                        SaveMap[i, j] = mode + 1;
                                        g.DrawImage(pics.Images[mode], i * cX, cY * j, cX, cY);
                                    }
                        }
                        else if (pSY <= (e.Y - CurPoint.Y) / cY)
                        {
                            for (int i = pSX; i <= (e.X - CurPoint.X) / cX; i++)
                                for (int j = pSY; j <= (e.Y - CurPoint.Y) / cY; j++)
                                    if (i < SizeMap && j < SizeMap)
                                    {
                                        SaveMap[i, j] = mode + 1;
                                        g.DrawImage(pics.Images[mode], i * cX, cY * j, cX, cY);
                                    }
                        }
                    };
                    PiMap.Refresh();
                    using (Graphics g = Graphics.FromImage(b_line))
                        g.Clear(Color.Transparent);
                    DrawCells();
                }
            }
            catch (Exception)
            {
            }
        }

        private void REND()
        {
            flag = false;
            try
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.Clear(Color.Transparent);
                    for (int i = 0; i < SizeMap; i++)
                        for (int j = 0; j < SizeMap; j++)
                        {
                            SaveMap[j, i] = mode + 1;
                            g.DrawImage(PiPreview.Image, j * cX, cY * i, cX, cY);
                        }
                    flag = true;
                    this.Invoke((MethodInvoker)delegate () { PiMap.Refresh(); });
                    _REND.Abort();
                }
            }
            catch (Exception)
            {
                this.Invoke((MethodInvoker)delegate (){PiMap.Refresh();});
                flag = true;
                _REND.Abort();
            }
        }
        private void TickTimer(object state)
        {
            DateTime thisDay = DateTime.Now;
            this.Invoke((MethodInvoker)delegate ()
            {
                latime.Text = thisDay.ToString();
                latime.Location = new Point(Width - latime.Width, 25);
                buPlayGame.Location = new Point(Width - latime.Width - buPlayGame.Width, 25);
                piHere.Location = new Point(Width - latime.Width - buPlayGame.Width - piHere.Width, 25);
                latime.Invalidate();
            });
        }

        private async void StartForm()
        {
            pics = new ImageList
            {
                ImageSize = new Size(32, 32),
                ColorDepth = ColorDepth.Depth32Bit
            };
            Mapparts = new List<Rectangle> { };
            for (int i = 0; i < AmountX; i++)
                for (int j = 0; j < AmountY; j++)
                {
                    Mapparts.Add(new Rectangle(i * XYmap, j * XYmap, XYmap, XYmap));
                    pics.Images.Add(Resources.TILE.Clone(new Rectangle(i * XYmap, j * XYmap, XYmap, XYmap), PixelFormat.Format32bppArgb));
                }

            this.Height = Screen.PrimaryScreen.Bounds.Height / 3 * 2;
            this.Width = Screen.PrimaryScreen.Bounds.Width / 3 * 2;
            PiMap.Height = 2000;
            PiMap.Width = 2000;
            b = new Bitmap(PiMap.Width, PiMap.Height);
            b_line = new Bitmap(PiMap.Width * 2, PiMap.Height * 2);
            ResizeCells();
            DrawCells();
            //await Task.Run(() => DrawCells());
            PiPreviewMAP.Parent = PiMap;
            PiPreviewMAP.Location = new Point(0, 0);
            PiPreview.Width = 32 * 4;
            PiPreview.Height = 32 * 4;
            PiSample.Width = 480;
            PiSample.Height = 192;
            PiSample.Parent = PiMap;
            AllPanel.Width = Width - 4;
            AllPanel.Height = Height - 64 - 2;
            AllPanel.Location = new Point(2, 64);
            PiMap.Location = new Point(0, 0);
            PiSample.Location = new Point(10, Height - PiSample.Height - 64 - 10);
            PiPreview.Location = new Point(10, Height - PiSample.Height - 10 - PiPreview.Height - 10);
            LaPreview.Parent = PiMap;
            LaPreview.Location = new Point(4, AllPanel.Height - 10 - PiSample.Height - 10 - PiPreview.Height - LaPreview.Height);
            XYPiSample.Parent = PiMap;
            XYPiSample.Location = new Point(10 + PiPreview.Width + 10, AllPanel.Height - 10 - PiSample.Height - XYPiSample.Height);
            laZoom.Parent = PiMap;
            laZoom.Location = new Point(10 + PiPreview.Width + 10, AllPanel.Height - 10 - PiSample.Height - XYPiSample.Height - laZoom.Height);
            PiPreview.Image = Resources.TILE.Clone(Mapparts[mode], PixelFormat.Format32bppArgb);

            DownloadPanel.Location = new Point(Width / 2 - DownloadPanel.Width / 2, Height / 2 - DownloadPanel.Height / 2);
            laDownload.Location = new Point(DownloadPanel.Location.X - 5, DownloadPanel.Location.Y - laDownload.Height);
            buX.Location = new Point(DownloadPanel.Location.X + laDownload.Width - 5, DownloadPanel.Location.Y - buX.Height);
            SaveMap = new int[SizeMap, SizeMap];
            Array.Clear(SaveMap, 0, SaveMap.Length);
        }

        private async void PiMap_MouseWheel(object sender, MouseEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            int x = (e.X - CurPoint.X) / cX * 5;
            int y = (e.Y - CurPoint.Y) / cY * 5;

                if (e.Delta > 0)
            {
                if (cX < 100)
                {
                    cX += DelataZoom;
                    cY += DelataZoom;
                    CurPoint = new Point(CurPoint.X - y, CurPoint.Y - x);
                }
            }
            else
            {
                if (cX > 11)
                {
                    cX -= DelataZoom;
                    cY -= DelataZoom;
                    CurPoint = new Point(CurPoint.X + y, CurPoint.Y + x);
                }
            }
            b = new Bitmap(b, SizeMap * cX, SizeMap * cX);
            using (Graphics g = Graphics.FromImage(b_line))
                g.Clear(Color.Transparent);
            laZoom.Text = $"Zoom: {cX}%";
            _REND_Zoom = new Thread(REND_Zoom0);
            try
            {
                _REND_Zoom.Start();
            }
            catch (Exception)
            {
                _REND_Zoom.Abort();
                _REND_Zoom.Start();
            }
            await Task.Run(() =>
            {
                DrawCells();
                REND_Zoom();
            });
            PiMap.Refresh();
        }
        private void REND_Zoom()
        {
            using (Graphics g = Graphics.FromImage(b))
            {
                for (int i = SizeMap / 2; i < SizeMap; i++)
                    for (int j = 0; j < SizeMap; j++)
                    {
                        int num = SaveMap[j, i];
                        if (num != -1 && num != 0)
                            g.DrawImage(pics.Images[num - 1], j * cX, cY * i, cX, cY);
                    }
            }
        }

        private void REND_Zoom0()
        {
            using (Graphics g = Graphics.FromImage(b))
            {
                g.Clear(Color.Transparent);
                for (int i = 0; i < SizeMap / 2; i++)
                    for (int j = 0; j < SizeMap; j++)
                    {
                        int num = SaveMap[j, i];
                        if (num != -1 && num != 0)
                            g.DrawImage(pics.Images[num - 1], j * cX, cY * i, cX, cY);
                    }
            }
        }

        private async void CheckDrawCellsFlag_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (checkDrawCellsFlag.Checked) DrawCellsFlag = false;
            else DrawCellsFlag = true;
            using (Graphics g = Graphics.FromImage(b_line))
                g.Clear(Color.Transparent);
            await Task.Run(() => DrawCells());
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
                        g.SmoothingMode = SmoothingMode.HighSpeed;
                        g.PixelOffsetMode = PixelOffsetMode.HighSpeed;
                        int EndPointX = (e.X - CurPoint.X) / cX;
                        int EndPointY = (e.Y - CurPoint.Y) / cY;
                        if (EndPointX < SizeMap && EndPointY < SizeMap)
                        {
                            Image image = Resources.TILE.Clone(Mapparts[mode], PixelFormat.Format32bppArgb);
                            g.DrawImage(PiPreview.Image, EndPointX * cX, cY * EndPointY, cX, cY);
                            g.DrawImage(PiPreview.Image, EndPointX * cX, cY * EndPointY, cX, cY);
                            g.DrawImage(PiPreview.Image, EndPointX * cX, cY * EndPointY, cX, cY);
                            g.DrawImage(PiPreview.Image, EndPointX * cX, cY * EndPointY, cX, cY);
                            SaveMap[EndPointX, EndPointY] = mode + 1;
                            XYPiSample.Text = $"| {EndPointX} | {EndPointY} |";
                        }
                    }
                    PiMap.Refresh();
                }
                else if (e.Button == MouseButtons.XButton1 || e.Button == MouseButtons.XButton2)
                {
                    using (Graphics g = Graphics.FromImage(b_line))
                    {
                        g.Clear(Color.Transparent);
                        DrawCells();
                        int showX = (e.X - CurPoint.X) - pSX * cX;
                        int showY = cY * pSY - (e.Y - CurPoint.Y);
                        if (-showY < 0 && showX < 0)
                        {
                            g.DrawRectangle(new Pen(Color.LightSalmon, 2), pSX * cX + showX, pSY * cY - showY, -showX, showY);
                        }
                        else if (-showY > 0 && showX < 0)
                        {
                            g.DrawRectangle(new Pen(Color.LightSalmon, 2), pSX * cX + showX, pSY * cY, -showX, -showY);
                        }
                        else if(-showY < 0)
                        {
                            g.DrawRectangle(new Pen(Color.LightSalmon, 2), pSX * cX, pSY * cY - showY, showX, showY);
                        }
                        else if(-showY > 0)
                        {
                            g.DrawRectangle(new Pen(Color.LightSalmon, 2), pSX * cX, pSY * cY, showX, -showY);
                        }
                        laZoom.Text = $"{pSX * cX} = {pSX * cX + showX}";
                        laZoom.Refresh();
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
            try
            {
                StartPoint = e.Location;
                if (e.Button == MouseButtons.Left)
                {
                    if (person == true)
                    {
                        using (Graphics g = Graphics.FromImage(b_line))
                            g.Clear(Color.Transparent);
                        DrawCells();
                        using (Graphics g = Graphics.FromImage(b_line))
                        {
                            int EndPointX = (e.X - CurPoint.X) / cX;
                            int EndPointY = (e.Y - CurPoint.Y) / cY;
                            g.DrawImage(Resources.you_are_here, EndPointX * cX, cY * EndPointY, cX, cY);
                            Person_Location = new Point(EndPointX * 60, 60 * EndPointY);
                        }
                        person = false;
                    }
                    else
                    {
                        using (Graphics g = Graphics.FromImage(b))
                        {
                            g.SmoothingMode = SmoothingMode.HighSpeed;
                            g.PixelOffsetMode = PixelOffsetMode.HighSpeed;
                            int EndPointX = (e.X - CurPoint.X) / cX;
                            int EndPointY = (e.Y - CurPoint.Y) / cY;
                            if (EndPointX < SizeMap && EndPointY < SizeMap)
                            {
                                Image image = Resources.TILE.Clone(Mapparts[mode], PixelFormat.Format32bppArgb);
                                g.DrawImage(PiPreview.Image, EndPointX * cX, cY * EndPointY, cX, cY);
                                g.DrawImage(PiPreview.Image, EndPointX * cX, cY * EndPointY, cX, cY);
                                g.DrawImage(PiPreview.Image, EndPointX * cX, cY * EndPointY, cX, cY);
                                g.DrawImage(PiPreview.Image, EndPointX * cX, cY * EndPointY, cX, cY);
                                SaveMap[EndPointX, EndPointY] = mode + 1;
                                XYPiSample.Text = $"| {EndPointX} | {EndPointY} |";
                            }
                        }
                    }
                    PiMap.Refresh();
                }
                else if (e.Button == MouseButtons.XButton1 || e.Button == MouseButtons.XButton2)
                {
                    int EndPointX = (e.X - CurPoint.X) / cX;
                    int EndPointY = (e.Y - CurPoint.Y) / cY;
                    if (EndPointX >= 0 && EndPointY >= 0)
                    {
                        pSX = EndPointX;
                        pSY = EndPointY;
                    }
                }
            }
            catch
            {
                //
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
                        PiPreview.Image = new Bitmap(Resources.TILE.Clone(Mapparts[Count], PixelFormat.Format32bppArgb));
                        mode = Count;
                        LaPreview.Text = $"Preview: {x}|{y} || {mode}";
                        return;
                    }
                    else Count++;
        }

        private async void Cleaning_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            using (Graphics g = Graphics.FromImage(b))
                g.Clear(Color.Transparent);
            using (Graphics g = Graphics.FromImage(b_line))
                g.Clear(Color.Transparent);
            Array.Clear(SaveMap, 0, SaveMap.Length);
            await Task.Run(() => DrawCells());
        }

        private void Fm_Resize(object sender, EventArgs e)
        {
            AllPanel.Width = Width - 4;
            AllPanel.Height = Height - 64 - 2;
            AllPanel.Location = new Point(2, 64);
            PiSample.Location = new Point(10, Height - PiSample.Height - 64 - 10);
            LaPreview.Location = new Point(4, AllPanel.Height - 10 - PiSample.Height - 10 - PiPreview.Height - LaPreview.Height);
            XYPiSample.Location = new Point(10 + PiPreview.Width + 10, AllPanel.Height - 10 - PiSample.Height - XYPiSample.Height);
            laZoom.Location = new Point(10 + PiPreview.Width + 10, AllPanel.Height - 10 - PiSample.Height - XYPiSample.Height - laZoom.Height);
        }

        private void ResizeCells()
        {
            cX = PiMap.Width / SizeMap;
            cY = PiMap.Height / SizeMap;
        }

        private void DrawCells()
        {
            using (Graphics g = Graphics.FromImage(b_line))
            {
                g.DrawLine(new Pen(Color.White, 1), 0, 0, SizeMap * cX, SizeMap * cY); // Диагональ ⤡
                g.DrawLine(new Pen(Color.White, 1), 0, cY * SizeMap, cX * SizeMap, 0); // Диагональ ⤢
                g.DrawLine(new Pen(Color.Beige, 5), 0, 0, cX * SizeMap, 0); // Линия ➜ 🗘
                g.DrawLine(new Pen(Color.Beige, 5), cX * SizeMap, 0, cX * SizeMap, cY * SizeMap); // Линия 🠗
                g.DrawLine(new Pen(Color.Beige, 5), cX * SizeMap, cY * SizeMap, 0, cX * SizeMap); // Линия 🠔 
                g.DrawLine(new Pen(Color.Beige, 5), 0, cY * SizeMap, 0, 0); // Линия 🠕
                if (DrawCellsFlag)
                    for (int i = 0; i < SizeMap; i++)
                    {
                        g.DrawLine(new Pen(Color.Silver, 1), i * cX, 0, i * cX, SizeMap * cY);
                        for (int j = 0; j < SizeMap; j++)
                        {
                            g.DrawLine(new Pen(Color.Silver, 1), 0, j * cY, SizeMap * cX, j * cY);
                        }
                    }

                this.Invoke((MethodInvoker)delegate () { PiMap.Refresh(); });
            }
        }
        private void Download_Click()
        {
            PiMap.Enabled = false;
            Save.Enabled = false;
            Download.Enabled = false;
            Cleaning.Enabled = false;
            buFillin.Enabled = false;
            buX.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buX.FlatAppearance.MouseDownBackColor = Color.Transparent;
            DownloadPanel.Visible = true;
            laDownload.Visible = true;
            buX.Visible = true;

            DownloadPanel.HorizontalScroll.Maximum = 0;
            DownloadPanel.AutoScroll = false;
            DownloadPanel.VerticalScroll.Visible = false;
            DownloadPanel.AutoScroll = true;

            try
            {
                for (int i = 0; i < listBtn.Count; i++)
                {
                    DownloadPanel.Controls.Remove(listBtn[i]);
                }
                var dirs = new DirectoryInfo(@".\cfg"); // папка с файлами 

                int Count = 0;
                foreach (FileInfo file in dirs.GetFiles())
                {
                    string NameMapFile = Path.GetFileNameWithoutExtension(file.FullName);
                    Button btn = new Button
                    {
                        Parent = DownloadPanel,
                        Size = new Size(DownloadPanel.Width - 20, 50),
                        Text = NameMapFile,
                        ForeColor = Color.Coral,
                        Font = new Font("Comic Sans MS", 15f),
                        BackColor = Color.Transparent,
                        Visible = true,
                    };
                    btn.Location = new Point(0, Count * btn.Height);
                    btn.FlatAppearance.BorderColor = this.BackColor;
                    btn.Click += (s, e) =>
                    {
                        DownloadPanel.Visible = false;
                        laDownload.Visible = false;
                        buX.Visible = false;
                        PiMap.Enabled = true;
                        Save.Enabled = true;
                        Download.Enabled = true;
                        Cleaning.Enabled = true;
                        buFillin.Enabled = true;
                        PiMap.Refresh();
                        Download_File_Click(NameMapFile);
                    };
                    listBtn.Add(btn);
                    Count++;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        private async void Download_File_Click(String NameMapFile)
        {
            try
            {
                if (!Directory.Exists($".\\cfg"))
                {
                    DialogResult rezult = MessageBox.Show("Директория не найдена.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!File.Exists($".\\cfg\\{NameMapFile}.txt"))
                {
                    DialogResult rezult = MessageBox.Show("Файл для загрузки не найден или еще не был создан.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines($".\\cfg\\{NameMapFile}.txt");
                SizeMap = lines.Length; // Сетка
                SaveMap = new int[SizeMap, SizeMap];
                b = new Bitmap(b, SizeMap * cX, SizeMap * cX);
                using (Graphics g = Graphics.FromImage(b_line))
                    g.Clear(Color.Transparent);
                await Task.Run(() => DrawCells());
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.Clear(Color.Transparent);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] temp = lines[i].Split('|');
                        for (int j = 0; j < temp.Length - 1; j++)
                        {
                            if (temp[j] != "*")
                            {
                                int num = Int32.Parse(temp[j]);
                                await Task.Run(() => g.DrawImage(pics.Images[num - 1], j * cX, cY * i, cX, cY));
                                SaveMap[j, i] = num;
                            }
                        }
                    }
                }
                BugError = 0;
                this.Invoke((MethodInvoker)delegate () { PiMap.Refresh(); });
            }
            catch
            {
                BugError++;
                if (BugError < 3)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Download_File_Click(NameMapFile);
                }
            }
        }
    }
}
