using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace labFileExplorer
{
    public partial class Fm : MaterialForm
    {
        private ColumnHeader SortingColumn = null;
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
        List<Label> listlabel;
        List<string> listLabelString;
        public short current_position { get; private set; } = 0;
        public short CountSearch { get; set; } = 0;

        private History step = new History();
        private bool infoVisible = true;

        public Fm()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey100, Accent.Red400, TextShade.WHITE);

            listlabel = new List<Label> { };
            listLabelString = new List<string> 
            {
            "Имя диска: ",
           "Файловая система: ",
            "Тип диска: ",
            "Объем доступного свободного места: ",
            "Готов ли диск: ",
            "Корневой каталог диска: ",
            "Общий объем свободного места, доступного на диске (в байтах): ",
            "Размер диска: ",
            "Метка тома диска: ",
            };
            CurDir = "C:\\";
            step.add(CurDir);
            CountSearch = 0;
            DiscFullInfo(CurDir);


            buBack.Click += (s, e) => { LoadDir(step.getFromHistory(step.CurrentStep - 1)); CountSearch = 0; };
            buForward.Click += (s, e) => { LoadDir(step.getFromHistory(step.CurrentStep + 1)); CountSearch = 0; };
            laDetailsName.Click += (s,e) => La_Click(0);
            laDetailsDate.Click += (s, e) => La_Click(1);
            laDetailsType.Click += (s, e) => La_Click(2);
            labDetailsSize.Click += (s, e) => La_Click(3);
            edSearch.GotFocus += (s, e) => edSearchText(true);
            edSearch.LostFocus += (s, e) => edSearchText(false);
            edSearch.KeyDown += EdSearch_KeyDown;
            cbInfo.Click += (s, e) => 
            {
                if (cbInfo.Checked)
                {
                    infoVisible = false;
                    panelInfo.Width = 2;
                    panelInfo.Height = 0;
                    panelInfo.Visible = infoVisible;
                    cbInfo.Text = "Открыть панель Свойств";
                    Width++;
                }
                else
                {
                    infoVisible = true;
                    panelInfo.Width = paPreview.Width;
                    panelInfo.Height = Height - 64 - 2;
                    panelInfo.Visible = infoVisible;
                    cbInfo.Text = "Скрыть панель Свойств";
                    Width--;
                }
            };
            buUp.Click += (s, e) =>
            {
                try
                {
                    if (CountSearch > 0)
                    {
                        CountSearch = 0;
                        LoadDir(CurDir);
                    }
                    else
                    {
                        CountSearch = 0;
                        LoadDir(Directory.GetParent(CurDir).ToString());
                    }

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
            miViewTile.Click += (s, e) => { LV.View = View.Tile; StartForm(); };


            LV.ItemSelectionChanged += (s, e) => SelItem = Path.Combine(CurDir, e.Item.Text);
            LV.DoubleClick += (s, e) =>
            {
                string[] words = SelItem.Split('\\');
                DirectoryInfo directoryInfo = new DirectoryInfo(CurDir);
                foreach (var item in directoryInfo.GetDirectories())
                {
                    if (words[words.Length-1] == item.Name)
                    {
                        step.add(SelItem);
                        CountSearch = 0;
                    }
                }
                LoadDir(SelItem);
            };
            LV.Click += (s, e) => { if (infoVisible) FileFullInfo(SelItem); };

            Resize += Fm_Resize;

            LV.Columns.Add("Имя", 500);
            LV.Columns.Add("Дата изменения", 150);
            LV.Columns.Add("Тип", 100);
            LV.Columns.Add("Размер", 150);

            GetLogicalDrives();
            StartForm();
            LoadDir(CurDir);
        }
        public void edSearchText(bool flag)
        {
            if (flag)
            {
                if (edSearch.Text == "Поиск: *.*") edSearch.Text = "";
                return;
            }
            if (string.IsNullOrWhiteSpace(edSearch.Text)) edSearch.Text = "Поиск: *.*";
        }
        private void EdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string[] words = edSearch.Text.Split('.');
                try
                {
                    if (words[0].Length > 0 && words[1].Length > 0)
                    {
                        LV.Items.Clear();
                        DirectoryInfo directoryInfo = new DirectoryInfo(CurDir);
                        CountSearch = 0;
                        FindInDir(directoryInfo, edSearch.Text, true);
                        edDir.Text = $"{CurDir} = {CountSearch} совпадений! (500 Максимум)";
                    }
                }
                catch (Exception)
                {
                }
            }
        }
        public void FindInDir(DirectoryInfo dir, string pattern, bool recursive)
        {
            if (CountSearch >= 500) return;
            try
            {
                foreach (FileInfo file in dir.GetFiles(pattern))
                {
                    var f = new FileInfo(file.FullName);
                    LV.Items.Add(new ListViewItem(new string[] { file.FullName, f.LastWriteTime.ToString(), "Файл", checkSize(f) }, checkExtension(f)));
                    edDir.Text = $"{CurDir} = {CountSearch} совпадений!";
                    if (CountSearch >= 500) return;
                    else if (CountSearch % 100 == 0) Refresh();
                    CountSearch++;
                }
                if (recursive)
                {
                    foreach (DirectoryInfo subdir in dir.GetDirectories())
                    {
                        FindInDir(subdir, pattern, recursive);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void La_Click(byte number)
        {
            ColumnHeader new_sorting_column = LV.Columns[number];
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn == null) sort_order = SortOrder.Ascending;
            else
            {
                if (new_sorting_column == SortingColumn)
                {
                    if (SortingColumn.Text.StartsWith("> ")) sort_order = SortOrder.Descending;
                    else sort_order = SortOrder.Ascending;
                }
                else sort_order = SortOrder.Ascending;
                SortingColumn.Text = SortingColumn.Text.Substring(2);
            }
            SortingColumn = new_sorting_column;
            if (sort_order == SortOrder.Ascending) SortingColumn.Text = "> " + SortingColumn.Text;
            else SortingColumn.Text = "< " + SortingColumn.Text;
            LV.ListViewItemSorter =
                new ListViewComparer(number, sort_order);
            LV.Sort();
        }

        private void DiscFullInfo(string path)
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.Name == path)
                {

                    for (byte i = 0; i < listlabel.Count; i++)
                    {
                        panelInfo.Controls.Remove(listlabel[i]);
                    }
                    try
                    {
                        List<string> listDriveString;
                        listDriveString = new List<string>
                        {
                        drive.Name,
                        drive.DriveFormat,
                        drive.DriveType.ToString(),
                        (drive.AvailableFreeSpace / (double)Math.Pow(2, 30)).ToString() + " ГБ",
                        drive.IsReady.ToString(),
                        drive.RootDirectory.ToString(),
                        drive.RootDirectory.ToString(),
                        (drive.TotalSize / (double)Math.Pow(2, 30)).ToString() + " ГБ",
                        drive.VolumeLabel,
                        };
                        for (byte i = 0; i < 9; i++)
                        {
                            try
                            {
                                Label labelname = new Label();
                                labelname.BackColor = System.Drawing.Color.Transparent;
                                labelname.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                labelname.ForeColor = System.Drawing.Color.LightCoral;
                                labelname.TextAlign = ContentAlignment.MiddleLeft;
                                labelname.Parent = panelInfo;
                                labelname.Size = new Size(215, 27);
                                labelname.Text = listLabelString[i];
                                labelname.UseMnemonic = false;
                                labelname.Location = new System.Drawing.Point(0, laProperty.Height + 2 + labelname.Height * i);
                                listlabel.Add(labelname);

                                Label labelvalue = new Label();
                                labelvalue.BackColor = System.Drawing.Color.Transparent;
                                labelvalue.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                labelvalue.ForeColor = System.Drawing.Color.LightCoral;
                                labelvalue.TextAlign = ContentAlignment.MiddleLeft;
                                labelvalue.Parent = panelInfo;
                                labelvalue.Size = new Size(panelInfo.Width - labelname.Location.X + labelname.Width, 27);
                                labelvalue.Text = listDriveString[i];
                                labelvalue.UseMnemonic = false;
                                labelvalue.Location = new System.Drawing.Point(215, laProperty.Height + 2 + labelvalue.Height * i);
                                listlabel.Add(labelvalue);
                            }
                            catch { }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        [STAThread]
        private void FileFullInfo(string SelItem)
        {
            try
            {
                for (byte i = 0; i < listlabel.Count; i++)
                {
                    panelInfo.Controls.Remove(listlabel[i]);
                }

                var path = SelItem;
                var dir = Path.GetDirectoryName(path);
                var file = Path.GetFileName(path);

                var shell = new Shell32.Shell();
                var folder = shell.NameSpace(dir);
                var folderItem = folder.ParseName(file);

                var names =
                    (from idx in Enumerable.Range(0, short.MaxValue)
                     let key = folder.GetDetailsOf(null, idx)
                     where !string.IsNullOrEmpty(key)
                     select (idx, key)).ToDictionary(p => p.idx, p => p.key);

                var properties =
                    (from idx in names.Keys
                     orderby idx
                     let value = folder.GetDetailsOf(folderItem, idx)
                     where !string.IsNullOrEmpty(value)
                     select (name: names[idx], value)).ToList();
                byte counter = 0;
                foreach (var kvp in properties)
                {
                    Label labelname = new Label();
                    labelname.BackColor = System.Drawing.Color.Transparent;
                    labelname.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    labelname.ForeColor = System.Drawing.Color.LightCoral;
                    labelname.TextAlign = ContentAlignment.MiddleLeft;
                    labelname.Parent = panelInfo;
                    labelname.Size = new Size(215, 27);
                    labelname.Text = kvp.name;
                    labelname.UseMnemonic = false;
                    labelname.Location = new System.Drawing.Point(0, laProperty.Height + 2 + labelname.Height * counter);
                    listlabel.Add(labelname);

                    Label labelvalue = new Label();
                    labelvalue.BackColor = System.Drawing.Color.Transparent;
                    labelvalue.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    labelvalue.ForeColor = System.Drawing.Color.LightCoral;
                    labelvalue.TextAlign = ContentAlignment.MiddleLeft;
                    labelvalue.Parent = panelInfo;
                    labelvalue.Size = new Size(panelInfo.Width - labelname.Location.X + labelname.Width, 27);
                    labelvalue.Text = kvp.value;
                    labelvalue.UseMnemonic = false;
                    labelvalue.Location = new System.Drawing.Point(215, laProperty.Height + 2 + labelvalue.Height * counter);
                    listlabel.Add(labelvalue);
                    counter++;
                }
            }
            catch (Exception)
            {
            }
        }

        private byte checkExtension(FileInfo item)
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
                    btn.Size = new Size(65, 39);
                    btn.Text = str;
                    btn.Location = new Point(Count * btn.Width, 0);
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Click += (s, e) =>
                    {
                        step.add(str);
                        CountSearch = 0;
                        if (infoVisible) DiscFullInfo(str);
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
            LV.Width = Width - 2 - 2 - panelInfo.Width;
            paDetails.Width = LV.Width;
            if (infoVisible)
            {
                panelInfo.Location = new Point(LV.Width, 64);
                panelInfo.Height = Height - 64 - 2;
            }
            panelMenu.Width = Width - panelInfo.Width - 5;
            toolMenu.Width = Width - panelInfo.Width;
            edDir.Width = Width - 2 - buBack.Width - buForward.Width - buUp.Width - buDirSelect.Width - DButtons.Width - panelInfo.Width - 8 - edSearch.Width;
        }

        private void StartForm()
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height / 3 * 2;
            this.Width = Screen.PrimaryScreen.Bounds.Width / 3 * 2;
            paPreview.Height = 700;
            paPreview.Width = 520;
            panelInfo.Height = Height - 64 - 2;
            panelInfo.Width = paPreview.Width;

            panelMenu.Width = Width - panelInfo.Width;
            panelMenu.Height = toolMenu.Height - 2;
            panelMenu.Location = new Point(2, 64);

            LV.Height = Height - panelMenu.Height - 64 - 2;
            LV.Width = Width - 2 - 2 - panelInfo.Width;
            LV.Location = new Point(2, panelMenu.Height + 64);
            LV.BackColor = BackColor;

            paPreview.Location = new Point(LV.Width, 64);

            panelInfo.Location = new Point(LV.Width, 64);


            toolMenu.Width = Width;
            toolMenu.Location = new Point(0, 0);
            edDir.BackColor = BackColor;
            edSearch.BackColor = BackColor;
            edDir.Width = 100;
            edDir.Width = Width - 2 - buBack.Width - buForward.Width - buUp.Width - buDirSelect.Width - DButtons.Width - panelInfo.Width - 8 - edSearch.Width;

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
                step.add(dialog.SelectedPath);
                CountSearch = 0;
            }
        }

        private void EdDir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDir(edDir.Text);
                step.add(edDir.Text);
                CountSearch = 0;
            }
        }

        private void LoadDir(string newDir)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(newDir);
                LV.BeginUpdate();
                if (CountSearch <= 0) LV.Items.Clear();
                foreach (var item in directoryInfo.GetDirectories())
                {
                    var f = new FileInfo(item.FullName);
                    LV.Items.Add(new ListViewItem(new string[] { item.Name, f.LastWriteTime.ToString(), "Папка", "" }, 0));

                }
                foreach (var item in directoryInfo.GetFiles())
                {
                    var f = new FileInfo(item.FullName);
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
                }
                if (CountSearch <= 0) LoadDir(CurDir);
            }
            catch (System.Security.SecurityException)
            {
                System.Console.WriteLine("The caller does not have the " +
                    "required permission.");
            }
            catch (Exception)
            {
                LoadDir(CurDir);
            }
        }

        public class ListViewComparer : System.Collections.IComparer
        {
            private int ColumnNumber;
            private SortOrder SortOrder;
            public ListViewComparer(int column_number,
                SortOrder sort_order)
            {
                ColumnNumber = column_number;
                SortOrder = sort_order;
            }
            public int Compare(object object_x, object object_y)
            {
                ListViewItem item_x = object_x as ListViewItem;
                ListViewItem item_y = object_y as ListViewItem;
                string string_x;
                if (item_x.SubItems.Count <= ColumnNumber) string_x = "";
                else string_x = item_x.SubItems[ColumnNumber].Text;
                string string_y;
                if (item_y.SubItems.Count <= ColumnNumber) string_y = "";
                else string_y = item_y.SubItems[ColumnNumber].Text;
                int result;
                double double_x, double_y;
                if (double.TryParse(string_x, out double_x) &&
                    double.TryParse(string_y, out double_y))
                    result = double_x.CompareTo(double_y);
                else
                {
                    DateTime date_x, date_y;
                    if (DateTime.TryParse(string_x, out date_x) &&
                        DateTime.TryParse(string_y, out date_y)) 
                        result = date_x.CompareTo(date_y);
                    else result = string_x.CompareTo(string_y);
                }
                if (SortOrder == SortOrder.Ascending) return result;
                else return -result;
            }
        }
    }
}