using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTrainerAccount
{
    public partial class Fm : Form
    {
        private Games g;
        public Fm()
        {
            InitializeComponent();

            g = new Games();
            g.Change += Event_change;
            g.DoReset();

            buYes.Click += (sender, e) => g.DoAnswer(true);
            buNo.Click += (sender, e) => g.DoAnswer(false);
        }

        private void Event_change(object sender, EventArgs e)
        {
            laYes.Text = String.Format("Верно = {0}", g.CountCorrect.ToString());
            laNo.Text = String.Format("Неверно = {0}", g.CountWrong.ToString());
            laCode.Text = g.CodeText;

        }
    }
}
