using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex
{
    public partial class Size_setting : Form
    {
        public Size_setting()
        {
            InitializeComponent();
            buOk.Click += (s,e) => this.DialogResult = DialogResult.OK;
            buX.Click += (s, e) => Application.Exit();
            buX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        }

        public int SizeMAP()
        {
            int Size = (int)Gridsize.Value;
            return Size;
        }
    }
}
