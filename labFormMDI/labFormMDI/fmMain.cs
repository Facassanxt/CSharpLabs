using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labFormMDI
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();

            miCreateeNewForm.Click += delegate
            {
                var x = new fmNote();
                x.MdiParent = this;
                x.Show();

            };

            miWindowsCascade.Click += (s, e) => this.LayoutMdi(MdiLayout.Cascade);
            miWindowsCTileHorizontal.Click += (s, e) => this.LayoutMdi(MdiLayout.TileHorizontal);
            miWindowsTileVertical.Click += (s, e) => this.LayoutMdi(MdiLayout.TileVertical);
            miWindowsArrangeIcons.Click += (s, e) => this.LayoutMdi(MdiLayout.ArrangeIcons);

            micloseActiveForm.Click += (s, e) => this.ActiveMdiChild?.Close();
            micloseAllForms.Click += delegate
            {
                while (this.MdiChildren.Count() > 0)
                {
                    this.MdiChildren[0].Close();
                   // this.ActiveMdiChild?.Close();
                };
            };

            miabout.Click += (s, e) => new fmAbout().ShowDialog();

            //this.IsMdiContainer = true;
        }
    }
}
