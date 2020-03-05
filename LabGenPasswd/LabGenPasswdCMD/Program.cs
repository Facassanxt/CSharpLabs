using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabGenPassword;

namespace LabGenPasswdCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            while (true)
            {
                try { 
                    Console.WriteLine("(1) x = 2");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("(1) x = {0}", x);

                    //Console.WriteLine("(2) x = 2");
                    //int.TryParse(Console.ReadLine(), out x);
                    //Console.WriteLine("(2) x = {0}", x);

                    //Console.WriteLine("(3) x = ?");
                    //x = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("(3) x = {0}", x);

                    //double d = 123.4;
                    //d = x;
                    //x = (int)d;
                    //Console.WriteLine("d = {0}", d);
                    //Console.WriteLine("x = {0}", x);

                    Console.WriteLine(Utils.RandomStrCMD(x,
                        true, true, true, true));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
