using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labImageSelectlnGrid
{
    public partial class fm : Form
    {
        private Bitmap b;
        private int cX;
        private int cY;
        private int col = 3;
        private int row = 4;
        private int curRow;
        private int curCol;

        public fm()
        {
            InitializeComponent();

            ResizeCells();
            DrawCells();
            this.Paint += Fm_Paint;
            this.Resize += Fm_Resize;
            this.MouseMove += Fm_MouseMove;
        }

        private void Fm_MouseMove(object sender, MouseEventArgs e)
        {
            curRow = e.Y / cY;
            curCol = e.X / cX;
            if (curRow != row && curCol != col)
            {
                DrawCells();
                this.CreateGraphics().DrawImage(b, new Point(0, 0));
                Text = $"{curRow} {curCol} {row} {col}";
            }
        }

        private void Fm_Resize(object sender, EventArgs e)
        {
            ResizeCells();
            DrawCells();
            this.CreateGraphics().DrawImage(b, new Point(0, 0));

        }

        private void Fm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(b, new Point(0, 0));
        }

        private void DrawCells()
        {
            //var g = Graphics.FromImage(b);
            //g.Dispose();

            using (var g = Graphics.FromImage(b))
            {
                g.Clear(DefaultBackColor);
                for (int i = 0; i < row; i++)
                {
                    g.DrawLine(new Pen(Color.LightBlue, 1), 0, i * cY, col * cX, i * cY);
                }

                for (int j = 0; j < col; j++)
                {
                    g.DrawLine(new Pen(Color.LightBlue, 1), j * cX, 0, j * cX, row * cY);
                }


                g.DrawRectangle(new Pen(Color.Red, 4), curCol * cX, curRow * cY, cX, cY);
            }

        }

        private void ResizeCells()
        {
            b = new Bitmap(Width, Height);
            cX = ClientSize.Width / col;
            cY = ClientSize.Height / row;
        }
    }
}
