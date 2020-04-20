using System;
using System.Collections.Generic;
using System.IO;

namespace labFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;

            string path = @"D:\Рабочий стол\999.txt";
            var list = new List<string>
            {
                "Один",
                "Два",
                "Три"
            };

            var xWriteText = string.Join(Environment.NewLine, list);
            File.WriteAllText(path, xWriteText);

            var xReadText = File.ReadAllText(path);
            Console.WriteLine(xReadText);

            Console.WriteLine(File.Exists(path));
            File.Delete(path);

            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine(fileInfo.Exists);

            Console.ResetColor();
        }
    }
}
