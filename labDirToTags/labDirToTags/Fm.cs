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

namespace labDirToTags
{
    public partial class Fm : Form
    {
        public Fm()
        {
            InitializeComponent();

            //edTags
            edDir.Text = Directory.GetCurrentDirectory();

            string s = @"D:\Фото\МосПолитех\2020.01.19 Семинар «ООП» (Иванов, Сидоров)\2020010121300-002.jpg";
            var a = s.Split(new char[] { ' ', '\\', '«', '»', '(', ')' }).ToArray();
            a = a.Where(v => v.Length > 0).Select(v => v.TrimEnd(',')).OrderBy(v => v).ToArray();
            edTags.Text = string.Join(Environment.NewLine, a);
        }
    }
}
