using System;
using System.Collections.Generic;

namespace LabDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> x = new Dictionary<int, string>(5);
            x.Add(1, "BpaHcK");
            x.Add(3, "Tyna");
            x.Add(2, "Camapa");
            x.Add(4, "Kanyra");
            x.Add(5, "NckoB");

            foreach (KeyValuePair<int, string> keyValue in x)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            string country = x[4];
            x[4] = "Spain";
            x.Remove(2);

            Console.ReadLine();
        }
    }
}
