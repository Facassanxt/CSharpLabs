using labSearchCity.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labSearchCity
{
    public partial class Fm : Form
    {
        private string[] arr;

        public Fm()
        {
            InitializeComponent();

            arr = Resources.cities.Split('\n');

            edSearch.TextChanged += EdSearch_TextChanged;
        }

        private void EdSearch_TextChanged(object sender, EventArgs e)
        {
            Text = edSearch.Text;
            var r = arr.Where(v => v.ToUpper().Contains(edSearch.Text.ToUpper())).OrderBy(v => v).Take(100).ToArray();
            edResult.Text = string.Join(Environment.NewLine,r);
            laCount.Text = r.Count().ToString();
        }
    }
}
