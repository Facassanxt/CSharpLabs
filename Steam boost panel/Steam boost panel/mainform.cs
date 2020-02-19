using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class mainform : MaterialForm
    {

        public mainform()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700,Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red400, TextShade.WHITE);
            buClose.Click += (sender, e) => this.Close();
            timer.Tick += Timer_Tick;
            //buСollapse.Click += (sender, e) => this.BringToFront();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            metroProgressBarCPU.Value = (int)fcpu;
            metroProgressBarRAM.Value = (int)fram;
            lblCPU.Text = string.Format("{0:0.00}%",fcpu);
            lblRAM.Text = string.Format("{0:0.00}%", fram);
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

    }
}