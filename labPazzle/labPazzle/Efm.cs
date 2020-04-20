using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labPazzle
{
    public partial class Efm : Form
    {
        public Efm(int Rows, int Cols)
        {
            InitializeComponent();
            buOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            numericUpDown1.Value = Rows;
            numericUpDown2.Value = Cols;
        }

        public int getRow() 
        {
            return (int)numericUpDown1.Value;
        }
        public int getCol()
        {
            return (int)numericUpDown2.Value;
        }
    }
}
