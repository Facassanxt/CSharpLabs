using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabBufMoveOnTimer.Properties;

namespace LabBufMoveOnTimer
{
    public partial class Form1 : Form
    {
        private BufferedGraphics buf;
        private Bitmap ImageHero;
        private int deltaX = 1;
        private Point pointHero;

        public Form1()
        {
            InitializeComponent();

            buf = BufferedGraphicsManager.Current.Allocate(this.CreateGraphics(), this.ClientRectangle);
            ImageHero = new Bitmap(Resources._12, Resources._12.Width, Resources._12.Height);

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();

            this.DoubleBuffered = true;
            this.Paint += (s, e) => timer.Enabled = !timer.Enabled;
            this.MouseClick += (s, e) => timer.Enabled = !timer.Enabled;
            this.MouseWheel += (s, e) => deltaX += (e.Delta > 0) ? 1 : -1;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            pointHero = new Point(pointHero.X + deltaX, pointHero.Y);
            buf.Graphics.Clear(SystemColors.Control);
            buf.Graphics.DrawImage(ImageHero, pointHero);
            buf.Render();
        }
    }
}
