using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labGraphicsDrawLineRND
{
    public partial class fm : Form
    {
        private Random rnd = new Random();
        public fm()
        {
            InitializeComponent();

            this.MouseDown += Fm_MouseDown;
            this.Paint += Fm_Paint;
        }

        private void Fm_Paint(object sender, PaintEventArgs e)
        {
            var g = this.CreateGraphics();
            g.Clear(DefaultBackColor);
            for (int i = 0; i < 50; i++)
            {
                g.DrawLine(new Pen(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)), 5),
                    rnd.Next(ClientSize.Width), rnd.Next(ClientSize.Height),
                    rnd.Next(ClientSize.Width), rnd.Next(ClientSize.Height));
            }
        }

        private void Fm_MouseDown(object sender, MouseEventArgs e)
        {
            var g = this.CreateGraphics();
            g.DrawLine(new Pen(Color.Red, 5), e.X - 10, e.Y - 10, e.X + 10, e.Y + 10);
            g.DrawLine(new Pen(Color.Red, 5), e.X - 10, e.Y + 10, e.X + 10, e.Y - 10);
            g.Dispose();
        }
    }
}
