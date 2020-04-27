using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace GoogleForm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> Form = new List<List<string>>();
            List<string> IdForm = new List<string>()
            {
            "1153592590",
            "908004252",
            "1047382224",
            "555826182",
            "653285268",
            "1279264033",
            "126183507",
            "1261793588",
            "632899675",
            "884405806",
            "576498022",
            "150352188",
            "1217319619",
            "558159554",
            "1905809967",
            "685448848",
            "150795819",
            "702903059",
            "1418997226",
            "1589601094",
            "455571233",
            "1171082240",
            "208545808",
            "109634087",
            "425744934",
            "38558523",
            "1648393458",
            "2098843961",
            "391745551",
            "700180",
            "2064250300",
            "980031362",
            "1482352177",
            "128698315",
            "1170666803",
            "1235027735",
            "1036642785",
            "1558415245",
            "1585970302",
            "1328019865",
            "922016334",
            "1440332887",
            "1080881478",
            "1389298390",
            "586130763",
            "1160201065",
            "756242069",
            "2094452520",
            "129200737",
            "431149192",
            "1477067147",
            "1242177046",
            "1370412166",
            "28121206",
            "1246344192",
            "2086237294",
            "694730144",
            "280900412",
            "134662774",
            "1278715780",
            "870912751",
            "1322797665",
            "1902768919",
            "895424635",
            "817139225",
            "1312963450",
            "515614211",
            "293731970",
            "213290759",
            "58257980",
            "1375121083",
            "89894319",
            "1185163876",
            "713453374",
            "1918180924",
            "347317400",
            "1204231489",
            "660562664",
            "1103584834",
            "394644807",
            "1371345351",
            "1822349140",
            "265953637",
            "1218672215",
            "607827398",
            "56428255",
            "635144898",
            "1276001466",
            "1880717947",
            "838317044",
            "1139969027",
            "284161221",
            "2097965659",
            "128045524",
            "600631730",
            "1879308199",
            "668247015",
            "830129702",
            "575382043",
            "974625361",
            "2005508062",
            "1509874472",
            "1188212176",
            "57349432",
            "272271274",
            "1930671551",
            };
            String FinalURL = "https://docs.google.com/forms/d/e/1FAIpQLSdYNBbgPqrv3nGfDiU9BUdPszDzlzDPSGWenWXCGA0Hf8P5xQ/viewform?usp=pp_url";
            String FF;
            string s = "456-435-2318";
            // ReadF_ile();

            for (int j = 0; j < 100; j++)
            {
                Download_Forms(Form);
                FF = Random_All_Form(Form, IdForm, FinalURL);
                Save_RRL_Form(FF, j);
                Form = new List<List<string>>();
            }
        }

        static string Random_All_Form(List<List<string>> form, List<string> idForm, String FinalURL)
        {
            Random rnd = new Random();
            String temp = FinalURL;
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
                Console.WriteLine("Непредвиденная ошибка. #2");
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
                Console.WriteLine("Непредвиденная ошибка. #1");
            }
        }
        private static void ReadF_ile()
        {
            String fullPath = "D:\\Рабочий стол\\facassanxt-c\\GoogleForm";
            try
            {
                if (!Directory.Exists($"{ fullPath }\\cfg"))
                {
                    Console.WriteLine("Директория не найдена.");
                }
                else if (!File.Exists($"{ fullPath }\\cfg\\READ.txt"))
                {
                    Console.WriteLine("Файл для загрузки не найден или еще не был создан.");
                    return;
                }
                using (StreamReader streamReader = new StreamReader($"{ fullPath }\\cfg\\READ.txt"))
                {
                    Regex regex = new Regex("[[][0-9]{5,},[[]");
                    Regex re = new Regex("[0-9]{5,}");
                    string line;
                    int n = 1;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        MatchCollection matches = regex.Matches(line);
                        MatchCollection matc;
                        if (matches.Count > 0)
                        {
                            foreach (Match match in matches) 
                            {
                                matc = re.Matches(match.Value);
                                foreach (Match ma in matc)
                                {
                                    Console.WriteLine($"\"{ma.Value.ToString()}\",");
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Непредвиденная ошибка. #1");
            }
        }
    }
}
