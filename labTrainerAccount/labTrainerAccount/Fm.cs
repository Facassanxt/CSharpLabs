using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTrainerAccount
{
    public partial class Fm : MaterialForm
    {
        private Games g;
        public Fm()
        {
            InitializeComponent();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700,Primary.BlueGrey900, Primary.BlueGrey100, Accent.Red400, TextShade.WHITE);



            g = new Games();
            g.Change += Event_change;
            g.DoReset();

            buYes.Click += (sender, e) => g.DoAnswer(true);
            buNo.Click += (sender, e) => g.DoAnswer(false);
            buReset.Click += (sender, e) => g.DoReset();
            buTest.Click += delegate
            {
                for (int i = 0; i < 1000; i++) 
                {
                    g.DoAnswer(true);
                }
            };
        }


        private void Event_change(object sender, EventArgs e)
        {
            laYes.Text = String.Format("Верно = {0}", g.CountCorrect.ToString());
            laNo.Text = String.Format("Неверно = {0}", g.CountWrong.ToString());
            laCode.Text = g.CodeText;

        }
    }
}
