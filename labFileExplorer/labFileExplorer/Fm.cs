using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labFileExplorer
{
    public partial class Fm : MaterialForm
    {
        private string _curDir;

        public string CurDir 
        { 
            get
            {
                return _curDir;
            }
            private set 
            {
                _curDir = value;
                edDir.Text = value;
            }  
        }
        public string SelItem { get; private set; }

        public Fm()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey100, Accent.Red400, TextShade.WHITE);

            CurDir = "D:\\";
            //CurDir = Directory.GetCurrentDirectory();



            //buBack.Click += (s, e) => LV.GoBack();
            //buForward.Click += (s, e) => wb.GoForward();
            buUp.Click += (s, e) => LoadDir(Directory.GetParent(CurDir).ToString());
            buDirSelect.Click += BuDirSelect_Click;
            edDir.KeyDown += EdDir_KeyDown;

            miViewLargeIcon.Click += (s, e) => LV.View = View.LargeIcon;
            miViewSmallIcon.Click += (s, e) => LV.View = View.SmallIcon;
            miViewList.Click += (s, e) => LV.View = View.List;
            miViewDetails.Click += (s, e) => LV.View = View.Details;
            miViewTile.Click += (s, e) => LV.View = View.Tile;


            LV.ItemSelectionChanged += (s, e) => SelItem = Path.Combine(CurDir,e.Item.Text);
            LV.DoubleClick += (s, e) => LoadDir(SelItem);

            Resize += Fm_Resize;

            LV.Columns.Add("Имя", 500);
            LV.Columns.Add("Дата изменения", 120);
            LV.Columns.Add("Тип", 100);
            LV.Columns.Add("Размер", 150);


            GetLogicalDrives();
            StartForm();
            LoadDir(CurDir);

            /* TODO HW
             * По расширению файла менять картинку  
                //f.Extension
             *  Добавить меню выбора размера файла (Кб,Мб)
             *   Выбор диска
             *   Больше инфы
             *   
             */

        }

        private void GetLogicalDrives()
        {
            try
            {
                string[] drives = System.IO.Directory.GetLogicalDrives();
                int Count = 0;
                foreach (string str in drives)
                {
                    Button btn = new Button();
                    btn.BackColor = System.Drawing.Color.Transparent;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    btn.ForeColor = System.Drawing.Color.Coral;
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.UseVisualStyleBackColor = false;
                    btn.Parent = paLogicalDrives;
                    btn.Size = new Size(60, 39);
                    btn.Text = str;
                    btn.Location = new Point(Count * btn.Width, 0);
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Click += (s, e) =>
                    {
                        LoadDir(str);
                    };
                    Count++;
                }
            }
            catch (System.IO.IOException)
            {
                System.Console.WriteLine("An I/O error occurs.");
            }
            catch (System.Security.SecurityException)
            {
                System.Console.WriteLine("The caller does not have the " +
                    "required permission.");
            }
        }

        private void Fm_Resize(object sender, EventArgs e)
        {
            panelInfo.Location = new Point(LV.Width, paPreview.Height + 64);
            panelMenu.Width = Width - paPreview.Width;
            toolMenu.Width = Width - paPreview.Width;
            edDir.Width = Width - 2 - buBack.Width - buForward.Width - buUp.Width - buDirSelect.Width - DButtons.Width - paPreview.Width - 8;
            //panelMenu.Location = new Point(2, 64);
        }

        private void StartForm()
        {
            this.Height = 1080;
            this.Width = 1920;
            paPreview.Height = 700;
            paPreview.Width = 520;

            panelMenu.Width = Width - paPreview.Width;
            panelMenu.Height = toolMenu.Height - 2;
            panelMenu.Location = new Point(2, 64);

            LV.Height = Height - panelMenu.Height - 64 - 2;
            LV.Width = Width - 2 - 2 - paPreview.Width;
            LV.Location = new Point(2, panelMenu.Height + 64);
            LV.BackColor = BackColor;

            paPreview.Location = new Point(LV.Width, 64);

            panelInfo.Height = Height - paPreview.Height - 64 - 2;
            panelInfo.Width = paPreview.Width;
            panelInfo.Location = new Point(LV.Width, paPreview.Height + 64);

            toolMenu.Width = Width;
            toolMenu.Location = new Point(0, 0);
            //panelInfo.Location = new Point(2, 64);
            edDir.BackColor = BackColor;
            edDir.Width = Width - 2 - buBack.Width - buForward.Width - buUp.Width - buDirSelect.Width - DButtons.Width - paPreview.Width - 8;
        }

        private void BuDirSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadDir(dialog.SelectedPath);
            }
        }

        private void EdDir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDir(edDir.Text);
            }
        }

        private void LoadDir(string newDir)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(newDir);
                LV.BeginUpdate();
                LV.Items.Clear();
                foreach (var item in directoryInfo.GetDirectories())
                {
                    var f = new FileInfo(item.FullName);
                    LV.Items.Add(new ListViewItem(new string[] { item.Name, f.LastWriteTime.ToString(), "Папка", "" }, 0));

                }
                foreach (var item in directoryInfo.GetFiles())
                {
                    var f = new FileInfo(item.FullName);
                    string extension = f.Extension;
                    if (extension == ".txt")
                    {
                        LV.Items.Add(new ListViewItem(new string[] { item.Name, f.LastWriteTime.ToString(), "Файл", f.Length.ToString() + " байт" }, -1));
                    }
                    else
                    {
                        LV.Items.Add(new ListViewItem(new string[] { item.Name, f.LastWriteTime.ToString(), "Файл", f.Length.ToString() + " байт" }, 1));
                    }
                }
                LV.EndUpdate();
                CurDir = newDir;
            }
            catch (System.IO.IOException)
            {
                foreach (var drive in DriveInfo.GetDrives())
                {
                    try
                    {
                        Console.WriteLine("Имя диска: " + drive.Name);
                        Console.WriteLine("Файловая система: " + drive.DriveFormat);
                        Console.WriteLine("Тип диска: " + drive.DriveType);
                        Console.WriteLine("Объем доступного свободного места (в байтах): " + drive.AvailableFreeSpace);
                        Console.WriteLine("Готов ли диск: " + drive.IsReady);
                        Console.WriteLine("Корневой каталог диска: " + drive.RootDirectory);
                        Console.WriteLine("Общий объем свободного места, доступного на диске (в байтах): " + drive.TotalFreeSpace);
                        Console.WriteLine("Размер диска (в байтах): " + drive.TotalSize);
                        Console.WriteLine("Метка тома диска: " + drive.VolumeLabel);
                    }
                    catch { }

                    Console.WriteLine();
                }
            }
            catch (System.Security.SecurityException)
            {
                System.Console.WriteLine("The caller does not have the " +
                    "required permission.");
            }
        }
    }
}
