using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labButtonOnGrid
{
    public partial class labButtonOnGrid : Form
    {
        private const int COL_MAX = 4;
        private const int ROW_MAX = 4;
        private Button[,] bu = new Button[ROW_MAX, COL_MAX];
        public labButtonOnGrid()
        {
            InitializeComponent();
            CreateButtons();
            ResizeButtons();
            this.Resize += (s, e) => ResizeButtons();
        }

        private void ResizeButtons()
        {
            int xCellWidth = ClientSize.Width / COL_MAX;
            int xCellHeight = ClientSize.Height / ROW_MAX;

            for (int i = 0; i < ROW_MAX; i++)
                for (int j = 0; j < COL_MAX; j++)
                {
                    bu[i, j].Height = xCellHeight;
                    bu[i, j].Width = xCellWidth;
                    bu[i, j].Location = new Point(j + (j * xCellWidth), i + (i * xCellHeight));
                }
        }

        private void CreateButtons()
        {
            int n = 1;
            for (int i = 0; i < ROW_MAX; i++)
                for (int j = 0; j < COL_MAX; j++)
                {
                    bu[i, j] = new Button();
                    bu[i, j].Text = $"{n++}";
                    bu[i, j].Font = new Font("Microsoft YaHei", 15.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(204)));
                    bu[i, j].ForeColor = Color.LightCoral;
                    bu[i, j].Click += BuAll_Click;
                    this.Controls.Add(bu[i, j]);
                }
        }
        private void BuAll_Click(object sender, EventArgs e)
        {
            if (sender is Button x)
                MessageBox.Show(x.Text);
        }
    }
}
