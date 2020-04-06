using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labCreateControlOnMouse
{
    public partial class labCreateControlOnMouse : Form
    {
        public labCreateControlOnMouse()
        {
            InitializeComponent();

            this.MouseDown += LabCreateControlOnMouse_MouseDown;
        }

        private void LabCreateControlOnMouse_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var x = new Label();
                x.Location = e.Location;
                //x.Text = String.Format("({0},{1})", e.X, e.Y);
                x.Text = $"({e.X},{e.Y})";
                x.AutoSize = true;
                x.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                x.ForeColor = Color.Red;
                this.Controls.Add(x);

            }
            if (e.Button == MouseButtons.Right)
            {
                var rnd = new Random();
                for (int i = 0; i < 100; i++)
                {
                    var x = new Label();
                    x.Location = new Point(rnd.Next(Size.Width - x.Size.Width), rnd.Next(Size.Height - x.Size.Height));
                    x.Text = $"({e.Location.X},{e.Location.Y})";
                    x.AutoSize = true;
                    x.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                    x.ForeColor = Color.Green;
                    this.Controls.Add(x);
                }
            }
        }
    }
}
