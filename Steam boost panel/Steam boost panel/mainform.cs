using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_boost_panel
{
    public partial class mainform : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);

        public mainform()
        {
            InitializeComponent();
            Panel_header.MouseDown += Panel_header_MouseDown;
            Panel_header.MouseMove += Panel_header_MouseMove;
            Panel_header.MouseUp += Panel_header_MouseUp;
        }

        private void Panel_header_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
            start_point = new Point(e.X, e.Y);
        }

        private void Panel_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void Panel_header_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }
    }
}