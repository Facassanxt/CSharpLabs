using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labMethodExtension
{
    static class TextBoxExt
    {
        public static string TextUpper(this TextBox source) 
        {
            return source.Text.ToUpper();
        }
    }
}
