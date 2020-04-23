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

namespace labRoadEditor
{
    public partial class fm : MaterialForm
    {
        private int CountCFGSave = 0; // 
        private Bitmap b;
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
            PiMap.MouseUp += PiMap_MouseUp;
            PiMap.MouseMove += PiMap_MouseMove;
            PiMap.Paint += PiMap_Paint;
            Save.Click += Save_Click;
            Download.Click += Download_Click;
            Resize += Fm_Resize;
            PiSample.MouseDown += PiSample_MouseDown;


            StartForm();


            //b = new Bitmap(PiMap);
        }

        private void StartForm()
        {
            //b = new Bitmap(Resources.road);
            this.Height = 1080;
            this.Width = 1920;
            PiMap.Height = 4000;
            PiMap.Width = 4000;
            PiPreview.Width = 8 * 20;
            PiPreview.Height = 8 * 20;
            PiSample.Width = 32 * 10;
            PiSample.Height = 24 * 10;
            AllPanel.Width = Width - 4;
            AllPanel.Height = Height - 64 -2;
            AllPanel.Location = new Point(2, 64);
            PiMap.Location = new Point(0,0);
            PiSample.Location = new Point(10, Height - PiSample.Height - 10);
            PiPreview.Location = new Point(10, PiSample.Location.Y - PiPreview.Height - 10);

            LaPreview.Parent = PiMap;
            LaPreview.Location = new Point(4, AllPanel.Height - 10 - PiSample.Height - 10 - PiPreview.Height - LaPreview.Height);
            b = new Bitmap(PiMap.Width, PiMap.Height);

            XYPiSample.Parent = PiMap;
            XYPiSample.Location = new Point(10 + PiPreview.Width + 10, AllPanel.Height - 10 - PiSample.Height - XYPiSample.Height);
            ResizeCells();
            DrawCells();

            PiPreview.Image = Resources.road.Clone(Mapparts[mode], PixelFormat.Format32bppArgb);

        }
        private void PiMap_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(b, CurPoint);
        }
        private void PiMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (PiMap.Capture)
                {
                    CurPoint.X += e.X - StartPoint.X;
                    CurPoint.Y += e.Y - StartPoint.Y;

                    //curCol = (e.X - CurPoint.X) / sizeCellsMap;
                    //curRow = (e.Y - CurPoint.Y) / sizeCellsMap;

                    StartPoint = e.Location;
                    PiMap.Refresh();
                    XYPiSample.Refresh();
                    LaPreview.Refresh();
                }
            }
            //Random rnd = new Random();
            //Pen pen = new Pen(Color.Black, 1);
            //pen.Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //g.FillEllipse(pen.Brush, e.X, e.Y, 5, 5);
        }

        private void PiMap_MouseUp(object sender, MouseEventArgs e)
        {
//  
        }

        private void PiMap_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = e.Location;
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
                    }
                    else 
                    {
                        Count++;
                    }
            mode = Count;
            XYPiSample.Text = $"{{ {x} : {y} }}";
        }

        private void Fm_Resize(object sender, EventArgs e)
        {
            AllPanel.Width = Width - 4;
            AllPanel.Height = Height - 64 - 2;
            AllPanel.Location = new Point(2, 64);
            LaPreview.Location = new Point(4, AllPanel.Height - 10 - PiSample.Height - 10 - PiPreview.Height - LaPreview.Height);
            XYPiSample.Location = new Point(10 + PiPreview.Width + 10, AllPanel.Height - 10 - PiSample.Height - XYPiSample.Height);


            //AllPanel.Width = Width - 4;
            //AllPanel.Height = Height - 64 - 2;
            //AllPanel.Location = new Point(2, 64);
            //PiMap.Location = new Point(0, 0);
            //PiSample.Location = new Point(10, Height - PiSample.Height - 10);
            //PiPreview.Location = new Point(10, PiSample.Location.Y - PiPreview.Height - 10);
            //LaPreview.Location = new Point(4, AllPanel.Height - 10 - PiSample.Height - 10 - PiPreview.Height - 20);
            //this.CreateGraphics().DrawImage(b, new Point(0, 0));
        }
        private void ResizeCells()
        {
            cX = PiMap.Width / col;
            cY = PiMap.Height / row;
        }
        private void DrawCells()
        {
            using (Graphics g = Graphics.FromImage(b))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                for (int i = 0; i <= row; i++)
                    for (int j = 0; j <= col; j++)
                    {
                        g.DrawLine(new Pen(Color.Silver), 0, i * cY, col * cX, i * cY);
                        g.DrawLine(new Pen(Color.Silver, 1), j * cX, 0, j * cX, row * cY);
                    }
                g.DrawLine(new Pen(Color.White, 1), 0, 0, col * cX, row * cY); // Диагональ ⤡
                g.DrawLine(new Pen(Color.White, 1), 0, cY * row, cX * col, 0); // Диагональ ⤢
                g.DrawLine(new Pen(Color.Beige, 5), 0, 0, cX * col, 0); // Линия ➜ 🗘
                g.DrawLine(new Pen(Color.Beige, 5), cX * col, 0, cX * col, cY * row); // Линия 🠗
                g.DrawLine(new Pen(Color.Beige, 5), cX * col, cY * row, 0, cX * col); // Линия 🠔
                g.DrawLine(new Pen(Color.Beige, 5), 0, cY * row, 0, 0); // Линия 🠕
            } 
        }


        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog MyDialog = new SaveFileDialog();
            MyDialog.FileName = $"SavePaint_{CountCFGSave}";
            MyDialog.Filter = $"png (*.png)|*.png";
            if (MyDialog.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                //string path = MyDialog.FileName;
                //b.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                //CountFileSave++;
            }
            catch
            {
                DialogResult rezult = MessageBox.Show("Невозможно сохранить файл",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Download_Click(object sender, EventArgs e)
        {
            try
            {
                String fullPath = Application.StartupPath.ToString();
                string[] words = fullPath.Split(new char[] { '\\' });
                fullPath = "";
                for (int i = 0; i < words.Length-3; i++)
                {
                    fullPath += words[i] + '\\';
                }
                INIManager manager = new INIManager($"{fullPath}\\cfg\\MapRoad.ini");
                string name = manager.GetPrivateString("Facassanxt", "0");
                MessageBox.Show(name);
                manager.WritePrivateString("Facassanxt", "0", "164482754792524");
                name = manager.GetPrivateString("Facassanxt", "0");
                MessageBox.Show(name);
            }
            catch
            {
                DialogResult rezult = MessageBox.Show("Непредвиденная ошибка",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class INIManager
    {
        public INIManager(string aPath)
        {
            path = aPath;
        }
        public INIManager() : this("") { }
        public string GetPrivateString(string aSection, string aKey)
        {
            StringBuilder buffer = new StringBuilder(SIZE);
            GetPrivateString(aSection, aKey, null, buffer, SIZE, path);
            return buffer.ToString();
        }
        public void WritePrivateString(string aSection, string aKey, string aValue)
        {
            WritePrivateString(aSection, aKey, aValue, path);
        }
        public string Path { get { return path; } set { path = value; } }

        private const int SIZE = 1024;
        private string path = null;
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString")]
        private static extern int GetPrivateString(string section, string key, string def, StringBuilder buffer, int size, string path);
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString")]
        private static extern int WritePrivateString(string section, string key, string str, string path);
    }
}
