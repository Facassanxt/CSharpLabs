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

namespace labRoadEditor
{
    public partial class fm : MaterialForm
    {
        private int CountCFGSave = 0;
        public fm()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.Blue50, Accent.Lime400, TextShade.WHITE);
            Save.Click += Save_Click;
            Download.Click += Download_Click;
            Resize += Fm_Resize;
            StartForm();
        }

        private void Fm_Resize(object sender, EventArgs e)
        {
            AllPanel.Width = Width - 4;
            AllPanel.Height = Height - 64 - 2;
            AllPanel.Location = new Point(2, 64);
            PiMap.Location = new Point(0, 0);
            PiSample.Location = new Point(10, Height - PiSample.Height - 10);
            PiPreview.Location = new Point(10, PiSample.Location.Y - PiPreview.Height - 10);
            LaPreview.Location = new Point(4, AllPanel.Height - 10 - PiSample.Height - 10 - PiPreview.Height - 20);
        }

        private void StartForm()
        {
            this.Height = 1080;
            this.Width = 1920;
            PiMap.Height = 3000;
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
            LaPreview.Location = new Point(4, AllPanel.Height - 10 - PiSample.Height - 10 - PiPreview.Height - 20);
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
