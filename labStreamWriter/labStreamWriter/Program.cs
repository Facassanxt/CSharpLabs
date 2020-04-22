using System;
using System.IO;

namespace labStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black; // устанавливаем цвет
            WriteCharacterStrings("C","0");

            Console.Clear();
            /*
                0 = Черный
                1 = Синий
                2 = Зеленый
                3 = Аквамарин
                4 = Красный
                5 = Фиолетовый
                6 = Желтый
                7 = Белый
                8 = Серый
                9 = Светло-голубой
                A = Светло-зеленый
                В = Светлый аквамарин
                С = Светло-красный
                D = Светло-фиолетовый
                E = Светло-желтый
                F = Ярко-белый
             */
            //Console.BackgroundColor = ConsoleColor.Cyan;

            string path = @"D:\Рабочий стол\999.txt";

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("1");
                streamWriter.WriteLine("22");
                streamWriter.WriteLine("333");
                WriteLineCentered("Файл создан");
            }
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine("4444");
                WriteLineCentered("Файл дописан");
            }

            using (StreamReader streamReader = new StreamReader(path)) 
            {
                WriteLineCentered("--- начало файла ---");
                WriteLineCentered(streamReader.ReadToEnd());
                WriteLineCentered("--- конец файла ---");
            }

            using (StreamReader streamReader = new StreamReader(path))
            {
                string line;
                int n = 1;
                while ((line = streamReader.ReadLine()) != null)
                {
                    WriteLineCentered($"Строка {n++} = [{line}]");
                }

                WriteLineCentered("*** Файл считан построчно ***");
            }

            var a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                foreach (var item in a)
                {
                    streamWriter.Write(item);

                }

                WriteLineCentered("*** Файл дописан ***");
            }


            WriteLineCentered("██████████████████████████████████████████");
            WriteLineCentered("█─███─██────██────██─██─██───██─██─██────█");
            WriteLineCentered("█─███─██─██─██─██─██──█─███─███──█─██─████");
            WriteLineCentered("█─█─█─██────██────██─█──███─███─█──██─█──█");
            WriteLineCentered("█─────██─██─██─█─███─██─███─███─██─██─██─█");
            WriteLineCentered("██─█─███─██─██─█─███─██─██───██─██─██────█");
            WriteLineCentered("██████████████████████████████████████████");



        }

        private static void WriteCharacterStrings(string Backcolor, string color)
        {
            string command = $"color {Backcolor+color}";
            System.Diagnostics.Process.Start("cmd.exe", "/C " + command);
            //Console.BackgroundColor = (ConsoleColor)((color - 1) % 16);
        }

        static void WriteLineCentered(string text)
        {
            int width = Console.WindowWidth;
            if (text.Length < width)
            {
                text = text.PadLeft((width - text.Length) / 2 + text.Length, ' ');
            }
            Console.WriteLine(text);
        }
    }
}
