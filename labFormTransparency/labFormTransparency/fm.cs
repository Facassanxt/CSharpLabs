using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labFormTransparency
{
    public partial class fm : Form
    {
        private Point startPoint;
        public fm()
        {
            InitializeComponent();
            buClose.Click += (s, e) => Close();
            this.MouseDown += (s, e) => startPoint = e.Location;
            this.MouseMove += Fm_MouseMove;

        }

        private void Fm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    Cursor.Position.X - startPoint.X,
                     Cursor.Position.Y - startPoint.Y);
            }
        }
    }
}
