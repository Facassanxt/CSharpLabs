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
    public partial class Form1 : MaterialForm
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

        public Form1()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey100, Accent.Red400, TextShade.WHITE);

            //CurDir = "D:\\";
            CurDir = Directory.GetCurrentDirectory();



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

            LV.Columns.Add("Имя", 200);
            LV.Columns.Add("Дата изменения", 150);
            LV.Columns.Add("Тип", 100);
            LV.Columns.Add("Размер", 150);


            Text += " : Drivers=" + string.Join(" ", Directory.GetLogicalDrives());

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

        private void StartForm()
        {
            this.Height = 1080;
            this.Width = 1920;
            panelMenu.Width = Width - 4;
            panelMenu.Height = toolMenu.Height - 4;
            toolMenu.Width = Width;
            toolMenu.Location = new Point(0, 0);
            panelMenu.Location = new Point(2, 64);
            //panelInfo.Location = new Point(2, 64);
            edDir.BackColor = BackColor;
            LV.BackColor = BackColor;
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
            DirectoryInfo directoryInfo = new DirectoryInfo(newDir);
            LV.BeginUpdate();
            LV.Items.Clear();
            foreach (var item in directoryInfo.GetDirectories())
            {
                var f = new FileInfo(item.FullName);
                //LV.Items.Add(item.Name, 0);
                LV.Items.Add(new ListViewItem(new string[] { item.Name, f.LastWriteTime.ToString(), "Папка", ""}, 0));

            }
            foreach (var item in directoryInfo.GetFiles())
            {
                var f = new FileInfo(item.FullName);
                //LV.Items.Add(item.Name, 1);
                LV.Items.Add(new ListViewItem(new string[] { item.Name, f.LastWriteTime.ToString(), "Файл", f.Length.ToString() + " байт" }, 1));
            }
            LV.EndUpdate();
            CurDir = newDir;
        }
    }
}
