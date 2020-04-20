using System;
using System.IO;

namespace labStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black; // устанавливаем цвет
            WriteCharacterStrings(1, 15, true);

            Console.Clear();

            //Console.BackgroundColor = ConsoleColor.Cyan;

            string path = @"D:\Рабочий стол\999.txt";

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("1");
                streamWriter.WriteLine("22");
                streamWriter.WriteLine("333");
                Console.WriteLine("Файл создан");
            }
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine("4444");
                Console.WriteLine("Файл дописан");
            }

            using (StreamReader streamReader = new StreamReader(path)) 
            {
                Console.WriteLine("--- начало файла ---");
                Console.WriteLine(streamReader.ReadToEnd());
                Console.WriteLine("--- конец файла ---");
            }

            using (StreamReader streamReader = new StreamReader(path))
            {
                string line;
                int n = 1;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine($"Строка {n++} = [{line}]");
                }

                Console.WriteLine("*** Файл считан построчно ***");
            }

            var a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                foreach (var item in a)
                {
                    streamWriter.Write(item);

                }

                Console.WriteLine("*** Файл дописан ***");
            }


        }

        private static void WriteCharacterStrings(int start, int end, bool changeColor)
        {
            for (int ctr = start; ctr <= end; ctr++)
            {
                if (changeColor)
                    Console.BackgroundColor = (ConsoleColor)((ctr - 1) % 16);

                Console.WriteLine(new String(Convert.ToChar(ctr + 64), 30));
            }
        }
    }
}
