using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex
{
    class Save_Load
    {
        public void Save(int[,] SaveMap, int SizeMap)
        {
            try
            {
                if (!Directory.Exists($".\\cfg"))
                {
                    Directory.CreateDirectory($".\\cfg");
                }
                StreamWriter strwrt = new StreamWriter($".\\cfg\\MapRoad {SizeMap}x{SizeMap}.txt", false);
                for (int i = 0; i < SizeMap; i++)
                {
                    for (int j = 0; j < SizeMap; j++)
                    {
                        if (SaveMap[j, i] == 0 || SaveMap[j, i] == -1)
                        {
                            strwrt.Write("*|");
                        }
                        else
                        {
                            strwrt.Write($"{SaveMap[j, i]}|");
                        }
                    }
                    strwrt.WriteLine();
                }
                strwrt.Close();

            }
            catch
            {
            }
        }
    }
}
