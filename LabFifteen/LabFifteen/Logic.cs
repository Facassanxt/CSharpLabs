using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabFifteen
{
    class Logic
    {
        // Проверка на возможность хода 
        public Boolean CheckStep(Button btn, Button btn0)
        {
            if (Math.Abs(btn0.Location.X - btn.Location.X) == 0 || Math.Abs(btn0.Location.Y - btn.Location.Y) == 0)
            {
                if ((btn.Location.X - (btn.Width + 5)) == btn0.Location.X || (btn.Location.Y - (btn.Height + 5)) == btn0.Location.Y
                    || (btn.Location.X + (btn.Width + 5)) == btn0.Location.X || (btn.Location.Y + (btn.Height + 5)) == btn0.Location.Y)
                {
                    return true;
                }
            }
            return false;
        }

        // Собрать в позицию win
        public void setWinPosition(List<Button> listBtn, List<Point> position)
        {
            int i = 0;
            foreach (Point location in position)
            {
                listBtn[i].Location = location;
                i++;
            }
        }

        // смена блоков 
        public void swapBlock(Button btn, Button block0)
        {
            Point p = btn.Location;
            btn.Location = block0.Location;
            block0.Location = p;
        }
    }
}
