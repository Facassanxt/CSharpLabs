using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labControlMoveOnTimer
{
    public partial class fm : Form
    {
        private int deltaX = 1;

        public fm()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();

            this.MouseWheel += (s, e) => deltaX += (e.Delta > 0) ? 1 : -1;
            this.MouseClick += (s, e) => timer.Enabled = !timer.Enabled;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var x = pictureBox1;
            x.Location = new Point(x.Location.X + deltaX, x.Location.Y);
            this.Text = $"{Application.ProductName} : {x.Location}, {deltaX}, {x.Width}, {ClientSize.Width}";
            if ((x.Location.X + x.Width + deltaX > ClientSize.Width) || (x.Location.X + deltaX <0))
            {
                deltaX *= -1;
            }
        }
    }
}
