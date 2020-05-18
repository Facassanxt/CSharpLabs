using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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


            CurDir = "C:\\";
            //CurDir = Directory.GetCurrentDirectory();



            //buBack.Click += (s, e) => LV.GoBack();
            //buForward.Click += (s, e) => wb.GoForward();
            buUp.Click += (s, e) =>
            {
                try
                {
                    LoadDir(Directory.GetParent(CurDir).ToString());
                }
                catch (Exception)
                {
                }
            };
            buDirSelect.Click += BuDirSelect_Click;
            edDir.KeyDown += EdDir_KeyDown;

            miViewLargeIcon.Click += (s, e) => { LV.View = View.LargeIcon; StartForm(); };
            miViewSmallIcon.Click += (s, e) => { LV.View = View.SmallIcon; StartForm(); };
            miViewList.Click += (s, e) => { LV.View = View.List; StartForm(); };
            miViewDetails.Click += (s, e) =>
            {
                paDetails.Visible = true;
                LV.Height = Height - panelMenu.Height - paDetails.Height - 64 - 2;
                LV.Location = new Point(2, panelMenu.Height + laDetailsName.Height + 64);
                LV.View = View.Details;
            };
            miViewTile.Click += (s, e) => {LV.View = View.Tile; StartForm(); };


            LV.ItemSelectionChanged += (s, e) => SelItem = Path.Combine(CurDir, e.Item.Text);
            LV.DoubleClick += (s, e) => LoadDir(SelItem);

            Resize += Fm_Resize;

            LV.Columns.Add("Имя", 500);
            LV.Columns.Add("Дата изменения", 150);
            LV.Columns.Add("Тип", 100);
            LV.Columns.Add("Размер", 150);


            GetLogicalDrives();
            StartForm();
            LoadDir(CurDir);

            /* TODO HW
             * По расширению файла менять картинку  
                //f.Extension
             *  Добавить меню выбора размера файла (Кб,Мб)
             *   Больше инфы
             *   
             */
            //foreach (var drive in DriveInfo.GetDrives())
            //{
            //    try
            //    {
            //        Console.WriteLine("Имя диска: " + drive.Name);
            //        Console.WriteLine("Файловая система: " + drive.DriveFormat);
            //        Console.WriteLine("Тип диска: " + drive.DriveType);
            //        Console.WriteLine("Объем доступного свободного места (в байтах): " + drive.AvailableFreeSpace);
            //        Console.WriteLine("Готов ли диск: " + drive.IsReady);
            //        Console.WriteLine("Корневой каталог диска: " + drive.RootDirectory);
            //        Console.WriteLine("Общий объем свободного места, доступного на диске (в байтах): " + drive.TotalFreeSpace);
            //        Console.WriteLine("Размер диска (в байтах): " + drive.TotalSize);
            //        Console.WriteLine("Метка тома диска: " + drive.VolumeLabel);
            //    }
            //    catch { }

            //    Console.WriteLine();
            //}

        }

        private int checkExtension(FileInfo item)
        {
            var ex = item.Extension.ToLower();
            // Поддерживаемые форматы графических файлов
            if (ex == ".jpg" || ex == ".jpeg" || ex == ".jp2" || ex == ".png" || ex == ".gif" || ex == ".raw" || ex == ".tiff" || ex == ".bmp" || ex == ".psd" || ex == ".fid")
            {
                return 2;
            } // Поддерживаемые форматы видеофайлов
            else if (ex == ".asf" || ex == ".mkv" || ex == ".avi" || ex == ".mp4" || ex == ".m4v" || ex == ".mov" || ex == ".mpg" || ex == ".mpeg" || ex == ".swf" || ex == ".wmv" || ex == ".sfl")
            {
                return 3;
            } // Поддерживаемые форматы звуковых файлов
            else if (ex == ".aiff" || ex == ".au" || ex == ".mid" || ex == ".midi" || ex == ".mp3" || ex == ".m4a" || ex == ".mp4" || ex == ".wav" || ex == ".wma")
            {
                return 4;
            }// Поддерживаемые форматы архивирования 
            else if (ex == ".zip" || ex == ".arj" || ex == ".rar" || ex == ".cab" || ex == ".tar" || ex == ".lzh" || ex == ".jar" || ex == ".iso" || ex == ".7z" || ex == ".tgz" || ex == ".tar-gz" || ex == ".tar")
            {
                return 5;
            }// Поддерживаемые форматы текстовые 
            else if (ex == ".txt" || ex == ".rtf" || ex == ".doc" || ex == ".docx" || ex == ".odt" || ex == ".pdf" || ex == ".html" || ex == ".log" || ex == ".ini")
            {
                return 6;
            }// Поддерживаемые форматы Исполняемые 
            else if (ex == ".exe" || ex == ".bat" || ex == ".bin" || ex == ".msi" || ex == ".cmd")
            {
                return 7;
            }// Поддерживаемые форматы Скрипты и файлы с кодом 
            else if (ex == ".cs" || ex == ".asp" || ex == ".aspx" || ex == ".c" || ex == ".cgi" || ex == ".class" || ex == ".cpp" || ex == ".dtd" || ex == ".fla" || ex == ".h" || ex == ".java" || ex == ".js" || ex == ".json" || ex == ".lua" || ex == ".php" || ex == ".sln" || ex == ".py" || ex == ".dll" || ex == ".sys" || ex == ".dat" || ex == ".bak")
            {
                return 8;
            }// Нет расширения
            else if (ex == "")
            {
                return 9;
            }
            else
            {
                return 1;
            }
        }
        private string checkSize(FileInfo f)
        {
            string size;
            if (f.Length < 1024) size = f.Length.ToString() + " Байт";
            else if (f.Length < (long)Math.Pow(2, 20)) size = (f.Length/ (long)Math.Pow(2, 10)).ToString() + " КБ";
            else if (f.Length < (long)Math.Pow(2, 30)) size = (f.Length / (long)Math.Pow(2, 20)).ToString() + " МБ";
            else if (f.Length < (long)Math.Pow(2, 40)) size = (f.Length / (long)Math.Pow(2, 30)).ToString() + " ГБ";
            else size = (f.Length / (long)Math.Pow(2, 40)).ToString() + " ТБ";
            return size;
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
            catch (Exception)
            {
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
            edDir.BackColor = BackColor;
            edDir.Width = Width - 2 - buBack.Width - buForward.Width - buUp.Width - buDirSelect.Width - DButtons.Width - paPreview.Width - 8;

            laDetailsName.Location = new Point(0, 0);
            laDetailsDate.Location = new Point(500, 0);
            laDetailsType.Location = new Point(650, 0);
            labDetailsSize.Location = new Point(750, 0);

            paDetails.Visible = false;
            paDetails.Width = LV.Width;
            paDetails.Height = laDetailsName.Height;
            paDetails.Location = LV.Location;
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
            LV.Visible = true;
            LV.BringToFront();
            LV.Refresh();
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
                    LV.Items.Add(new ListViewItem(new string[] { item.Name, f.LastWriteTime.ToString(), "Файл", checkSize(f)}, checkExtension(f)));
                }
                LV.EndUpdate();
                CurDir = newDir;
            }
            catch (System.IO.IOException)
            {
                LV.EndUpdate();
                try
                {
                    Process.Start(newDir);
                }
                catch (Exception)
                {
                    LoadDir(edDir.Text);
                }
                //LV.Items.Clear();
                LoadDir(edDir.Text);
            }
            catch (System.Security.SecurityException)
            {
                System.Console.WriteLine("The caller does not have the " +
                    "required permission.");
            }
            catch (Exception)
            {
                LV.Items.Clear();
            }
        }
    }
}
