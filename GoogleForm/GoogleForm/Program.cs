using System;
using System.Collections.Generic;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace GoogleForm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> Form = new List<List<string>>();
            List<string> IdForm = new List<string>()
            {
                "1327871374",
                "1529344881",
                "1724490446",
                "485560385",
                "1295049457",
                "554907992",
                "1037949504",
                "2105082844",
                "1151434781",
                "1599570321",
                "188224434",
                "1351020271",
                "1732106744",
                "57545652",
                "1552084195",
                "338409298",
                "611106426",
                "1548156459",
                "1601875540",
                "1208226160",
                "695603565",
                "365508798",
                "362028340",
                "1101584444",
            };
            String FinalURL = "https://docs.google.com/forms/d/e/1FAIpQLScnpynxaqQ91KGr6-zAbSFAKPVEL8btxo4AWN0r8BUMipSriA/viewform?usp=pp_url";
            String FF;
            for (int j = 0; j < 100; j++)
            {
                Download_Forms(Form);
                FF = Random_All_Form(Form, IdForm, FinalURL);
                Save_RRL_Form(FF,j);
                Form = new List<List<string>>();
            }
        }

        static string Random_All_Form(List<List<string>> form, List<string> idForm, String FinalURL)
        {
            Random rnd = new Random();
            String temp = FinalURL;
            Console.WriteLine($"{ form.Count}");
            for (int i = 0; i < form.Count; i++)
            {
                int CountRandom = form[i].Count;
                temp += $"&entry.{idForm[i]}={form[i][rnd.Next(CountRandom)]}";
            }
            return temp;
        }

        private static void Save_RRL_Form(String FinalURL, int j)
        {
            String fullPath = "D:\\Рабочий стол\\facassanxt-c\\GoogleForm";
            try
            {
                if (!Directory.Exists($"{ fullPath }\\cfg"))
                {
                    Directory.CreateDirectory($"{ fullPath }\\cfg");
                }
                StreamWriter strwrt = new StreamWriter($"{ fullPath }\\cfg\\Url.txt", true);
                strwrt.WriteLine($"= ГИПЕРССЫЛКА(\"{ FinalURL }\"; \"\"\"ВАША ЕБАННАЯЯ ССЫЛКА №{j}\"\"\")");
                strwrt.Close();
            }
            catch
            {
                Console.WriteLine("Непредвиденная ошибка.");
            }
        }

        private static void Download_Forms(List<List<string>> Form)
        {
            String fullPath = "D:\\Рабочий стол\\facassanxt-c\\GoogleForm";
            try
            {
                if (!Directory.Exists($"{ fullPath }\\cfg"))
                {
                    Console.WriteLine("Директория не найдена.");
                }
                else if (!File.Exists($"{ fullPath }\\cfg\\form.txt"))
                {
                    Console.WriteLine("Файл для загрузки не найден или еще не был создан.");
                    return;
                }
                string[] lines = File.ReadAllLines($"{ fullPath }\\cfg\\form.txt");
                List<string> list = new List<string>();
                for (int i = 1; i < lines.Length + 1; i++)
                {
                    string temp = lines[i];
                    if (temp == "====") 
                    {
                        Form.Add(list);
                        return;
                    }
                    if (temp == "")
                    {
                        Form.Add(list);
                        list = new List<string>();
                    }
                    else
                    {
                        list.Add(temp);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Непредвиденная ошибка.");
            }
        }
    }
}
