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
using System.Threading;
using labPaint.Properties;

namespace labPaint
{
    public partial class fm : MaterialForm
    {
        private bool isPressed = true;
        private Bitmap b;
        int x, y, CountFileSave = 0;
        private int mode, SazePen = 0;
        Size resolution;

        Graphics g;
        Pen pen;
        Thread[] Potok = new Thread[10];
        List<PictureBox> ColorList = new List<PictureBox>();
        private bool RandomColor = false;

        public fm()
        {
            InitializeComponent();


            pen = new Pen(Color.Black, 1);



            ColorList.Add(Black);
            ColorList.Add(White);
            ColorList.Add(Silver);
            ColorList.Add(Red);
            ColorList.Add(Orange);
            ColorList.Add(Yellow);
            ColorList.Add(Lime);
            ColorList.Add(Aqua);
            ColorList.Add(Blue);
            ColorList.Add(Fuchsia);
            

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.Blue50, Accent.Lime400, TextShade.WHITE);

            paImage.MouseDown += PaImage_MouseDown;
            paImage.MouseUp += PaImage_MouseUp;
            paImage.MouseMove += PaImage_MouseMove;
            paImage.Paint += PaImage_Paint;
            StartXY.Click += StartXY_Click;
            Save.Click += Save_Click;
            Resize += Fm_Resize;
            RndColor.Click += RndColor_Click;
            AllColor.Click += AllColor_Click;
            ResizeEnd += Fm_ResizeEnd;
            MinimumSizeChanged += (s,e) => WindowState = FormWindowState.Normal;
            MaximizedBoundsChanged += (s, e) => WindowState = FormWindowState.Normal;
            ClearPanel.Click += (s, e) =>
             {
                 g.Clear(Color.Silver);
                 StartFormPosition();
             };
            Download.Click += Download_Click;
            StartFormPosition();
            ColorPanel(ColorList);
            toolsBar.ImageList = imageList;
            toolsBar.ButtonClick += new ToolBarButtonClickEventHandler(this.ClickButtonsOnPanelMode);


            //List<ManagementObject> managementList = ManagementObjectCollection.OfType<ManagementObject>().ToList();
            //intitModePanel(toolsBar.Buttons);
        }

        private void StartXY_Click(object sender, EventArgs e)
        {
//
        }

        void getPointXY()
        {
                this.Invoke((MethodInvoker)delegate () { MouseLocation.Text = $"{{ {x.ToString()} : {y.ToString()}}}"; });
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


            resolution = Screen.PrimaryScreen.Bounds.Size;

            b = new Bitmap(resolution.Width, resolution.Height);
            g = paImage.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            mode = 1;
            Bitmap BitIcon = new Bitmap(imageList.Images[1]);
            Cursor = new Cursor(BitIcon.GetHicon());
            Sizepen.Enabled = false;



        }

        private void Fm_Resize(object sender, EventArgs e)
        {
            toolsBar.Height = this.Height - 64;
            instpanel.Width = this.Width - toolsBar.Width - 1;
            paImage.Height = this.Height - 64 - instpanel.Height - 1;
            paImage.Width = this.Width - toolsBar.Width - 1;
            g = paImage.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            //b2 = (Bitmap)b.Clone();
            ////g.DrawImage(b, new Point(0, 0));
            //b = new Bitmap(paImage.Width, paImage.Height);
            ////b = new Bitmap(b2);
            
        }
        private void Fm_ResizeEnd(object sender, EventArgs e)
        {
            g.DrawImage(b, new Point(0, 0));
        }

        private void PaImage_Paint(object sender, PaintEventArgs e)
        {
            g.DrawImage(b, new Point(0, 0));
        }

        private void PaImage_MouseMove(object sender, MouseEventArgs e)
        {
            switch (mode)
            {
                case 0:
                    break;
                case 1:
                    if (e.Button == MouseButtons.Left)
                    {
                        using (Graphics g1 = Graphics.FromImage(b))
                        {
                            if (RandomColor)
                            {
                                Random rnd = new Random();
                                pen.Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                                g.FillEllipse(pen.Brush, e.X - SazePen, e.Y - SazePen, SazePen, SazePen);
                                g1.FillEllipse(pen.Brush, e.X - SazePen, e.Y - SazePen, SazePen, SazePen);
                            }
                            else
                            {
                                g.FillEllipse(pen.Brush, e.X - SazePen, e.Y - SazePen, SazePen, SazePen);
                                g1.FillEllipse(pen.Brush, e.X - SazePen, e.Y - SazePen, SazePen, SazePen);
                            }
                        }
                    }
                    break;
                case 2:
                    if (e.Button == MouseButtons.Left)
                    {
                        using (Graphics g1 = Graphics.FromImage(b))
                        {
                            if (RandomColor)
                            {
                                Random rnd = new Random();
                                pen.Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                                g.FillEllipse(pen.Brush, e.X - SazePen / 2, e.Y - SazePen / 2, SazePen, SazePen);
                                g1.FillEllipse(pen.Brush, e.X - SazePen / 2, e.Y - SazePen / 2, SazePen, SazePen);
                            }
                            else
                            {
                                g.FillEllipse(pen.Brush, e.X - SazePen / 2, e.Y - SazePen / 2, SazePen, SazePen);
                                g1.FillEllipse(pen.Brush, e.X - SazePen / 2, e.Y - SazePen / 2, SazePen, SazePen);
                            }
                        }
                    }
                    break;
                case 3:
                    break;
                case 4:
                    //if (isPressed == false)
                    //{
                    //    using (Graphics g1 = Graphics.FromImage(b))
                    //    {
                    //        if (RandomColor)
                    //        {
                    //            Random rnd = new Random();
                    //            pen.Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    //            g.DrawLine(new Pen(pen.Color, SazePen), x, y, e.X, e.Y);
                    //            g1.DrawLine(new Pen(pen.Color, SazePen), x, y, e.X, e.Y);
                    //        }
                    //        else
                    //        {
                    //            Bitmap b6 = new Bitmap(b);
                    //            using (Graphics g2 = Graphics.FromImage(b6)) 
                    //            {

                    //                g2.DrawLine(new Pen(pen.Color, SazePen), x, y, e.X, e.Y);
                    //                paImage.BackgroundImage = b6;
                    //                paImage.CreateGraphics().DrawImage(b6, new Point(0, 0));
                    //                g2.DrawImage(b, new Point(0, 0));
                    //            }
                    //        }  
                    //    }
                    //}
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    if (e.Button == MouseButtons.Left)
                    {
                        using (Graphics g1 = Graphics.FromImage(b))
                        {
                            pen.Color = Color.Silver;
                            g.FillEllipse(pen.Brush, e.X - SazePen / 2, e.Y - SazePen / 2, SazePen, SazePen);
                            g1.FillEllipse(pen.Brush, e.X - SazePen / 2, e.Y - SazePen / 2, SazePen, SazePen);
                        }
                    }
                    break;
            }
        }

        private void PaImage_MouseUp(object sender, MouseEventArgs e)
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
                    break;
                case 4:
                    //if (isPressed == true) 
                    //{
                    //    using (Graphics g1 = Graphics.FromImage(b))
                    //    {
                    //        if (RandomColor)
                    //        {
                    //            Random rnd = new Random();
                    //            pen.Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    //            g.DrawLine(new Pen(pen.Color, SazePen), x, y, e.X, e.Y);
                    //            g1.DrawLine(new Pen(pen.Color, SazePen), x, y, e.X, e.Y);
                    //        }
                    //        else
                    //        {
                    //            g.DrawLine(new Pen(pen.Color, SazePen), x, y, e.X, e.Y);
                    //            g1.DrawLine(new Pen(pen.Color, SazePen), x, y, e.X, e.Y);
                    //        }
                    //    }
                    //}
                    //isPressed = false;
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
            }
        }

        private void PaImage_MouseDown(object sender, MouseEventArgs e)
        {
            switch (mode)
            {
                case 0:
                    break;
                case 1:
                    SazePen = 2;
                    break;
                case 2:
                    SazePen = Sizepen.Value;
                    break;
                case 3:
                    break;
                case 4:
                    SazePen = Sizepen.Value;
                    if (isPressed == true) 
                    {
                        x = e.X;
                        y = e.Y;
                        SazePen = 6;
                        using (Graphics g1 = Graphics.FromImage(b))
                        {
                            if (RandomColor)
                            {
                                Random rnd = new Random();
                                pen.Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                                g.FillEllipse(pen.Brush, e.X - SazePen / 2, e.Y - SazePen / 2, SazePen/2, SazePen/2);
                                g1.FillEllipse(pen.Brush, e.X - SazePen / 2, e.Y - SazePen / 2, SazePen/2, SazePen/2);
                            }
                            else
                            {
                                g.FillEllipse(pen.Brush, e.X - SazePen / 4, e.Y - SazePen / 4, SazePen/2, SazePen/2);
                                g1.FillEllipse(pen.Brush, e.X - SazePen / 4, e.Y - SazePen / 4, SazePen/2, SazePen/2);
                            }
                            isPressed = false;
                        }
                    }
                    else 
                    {
                        isPressed = true;
                        using (Graphics g1 = Graphics.FromImage(b))
                        {
                            if (RandomColor)
                            {
                                Random rnd = new Random();
                                pen.Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                                g.DrawLine(new Pen(pen.Color, SazePen), x, y, e.X, e.Y);
                                g1.DrawLine(new Pen(pen.Color, SazePen), x, y, e.X, e.Y);
                            }
                            else
                            {
                                g.DrawLine(new Pen(pen.Color, SazePen), x, y, e.X, e.Y);
                                g1.DrawLine(new Pen(pen.Color, SazePen), x, y, e.X, e.Y);
                            }
                        }
                    }
                    break;
                case 5:
                    SazePen = Sizepen.Value;
                    break;
                case 6:
                    SazePen = Sizepen.Value;
                    break;
                case 7:
                    SazePen = Sizepen.Value;
                    break;
                case 8:
                    SazePen = Sizepen.Value;
                    break;
            }
        }
        private void ClickButtonsOnPanelMode(Object sender,ToolBarButtonClickEventArgs e)
        {
            for (int i = 0; i < toolsBar.Buttons.Count; i++)
            {
                toolsBar.Buttons[i].Pushed = false;
                Cursor = default;
            }
            e.Button.Pushed = true;

            if (sender is ToolBar)
            {
                switch (toolsBar.Buttons.IndexOf(e.Button))
                {
                    case 0:
                        mode = 0;
                        break;
                    case 1:
                        mode = 1;
                        Sizepen.Enabled = false;
                        break;
                    case 2:
                        mode = 2;
                        Sizepen.Enabled = true;
                        break;
                    case 3:
                        mode = 3;
                        Sizepen.Enabled = false;
                        break;
                    case 4:
                        mode = 4;
                        Sizepen.Enabled = true;
                        break;
                    case 5:
                        mode = 5;
                        Sizepen.Enabled = true;
                        break;
                    case 6:
                        mode = 6;
                        Sizepen.Enabled = true;
                        break;
                    case 7:
                        mode = 7;
                        Sizepen.Enabled = true;
                        break;
                    case 8:
                        mode = 8;
                        Sizepen.Enabled = true;
                        break;
                }
            }

            Image sad = toolsBar.ImageList.Images[mode];
            Bitmap BitIcon = new Bitmap(sad,sad.Width,sad.Height);
            Cursor = new Cursor(BitIcon.GetHicon());
        }

        private void ColorPanel (List<PictureBox> ColorList)
        {
            for (int i = 0; i < ColorList.Count; i++)
            {
                ColorList[i].Click += ClickButtonsOnColorPanel;
            }
        }

        private void ClickButtonsOnColorPanel(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox p = (PictureBox)sender;
                pen.Color = p.BackColor;
                RandomColor = false;
            }
        }
        private void AllColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = AllColor.ForeColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                AllColor.BackColor = MyDialog.Color;
                pen.Color = MyDialog.Color;
                RandomColor = false;
            }
        }

        private void RndColor_Click(object sender, EventArgs e)
        {
            RandomColor = true;
        }


        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog MyDialog = new SaveFileDialog();
            MyDialog.FileName = $"SavePaint_{CountFileSave}";
            MyDialog.Filter = $"png (*.png)|*.png";
            if (MyDialog.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                string path = MyDialog.FileName;
                b.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                CountFileSave++;
            }
            catch
            {
                DialogResult rezult = MessageBox.Show("Невозможно сохранить файл",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Download_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                g.Clear(Color.Silver);
                g.Dispose();
                paImage.BackColor = Color.Silver;
                g = paImage.CreateGraphics();
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                try
                {
                    Bitmap bImg = new Bitmap(open_dialog.FileName);
                    Size resolution = Screen.PrimaryScreen.Bounds.Size;
                    Bitmap bb = new Bitmap(bImg,resolution.Width, resolution.Height);
                    if (bImg.Width >= resolution.Width || bImg.Height >= resolution.Height)
                    {
                        if (bImg.Width >= resolution.Width && bImg.Height >= resolution.Height)
                        {
                            bb = new Bitmap(bImg, resolution.Width, resolution.Height);
                            StartPosition = FormStartPosition.Manual;
                            Height = resolution.Height;
                            Width = resolution.Width;
                        }
                        else if (bImg.Width >= resolution.Width)
                        {
                            bb = new Bitmap(bImg, resolution.Width, bImg.Height);
                            WindowState = FormWindowState.Normal;
                        }
                        else if (bImg.Height >= resolution.Height)
                        {
                            bb = new Bitmap(bImg, bImg.Width, resolution.Height);
                            WindowState = FormWindowState.Normal;
                        }
                    }
                    else
                    {
                        bb = new Bitmap(bImg, bImg.Width, bImg.Height);
                        WindowState = FormWindowState.Normal;
                    }
                    b = new Bitmap(resolution.Width, resolution.Height);

                    Height = bb.Height + 64 + instpanel.Height + 1; ;
                    Width = bb.Width;

                    using (Graphics g1 = Graphics.FromImage(b))
                    {
                        g1.CompositingMode = CompositingMode.SourceOver;
                        g1.SmoothingMode = SmoothingMode.HighQuality;
                        g1.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        g1.DrawImage(bb, new Point(0, 0));
                    }
                    //g.DrawImage(bb, new Point(0, 0));
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
