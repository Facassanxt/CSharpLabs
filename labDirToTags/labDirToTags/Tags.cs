using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labDirToTags
{
    class Tags
    {
        private string str;

        public int CountSearch { get; private set; }
        public int CountSearchTags { get; private set; }

        public string[] CountTags(string dir)
        {
            str = "";
            CountSearchTags = 0;
            CountSearch = 0;
            DirectoryInfo directoryInfo = new DirectoryInfo(dir);
            FindInDir(directoryInfo, true);
            var a = str.Split(new char[] { ' ', '\\', '«', '»', '(', ')' }).ToArray();
            //a = a.Where(v => v.Length > 0).Select(v => v.TrimEnd(',')).Distinct().OrderBy(v => v).ToArray();
            CountSearchTags = a.Where(v => v.Length > 0).Select(v => v.TrimEnd(',')).Distinct().Count();
            var result = a
             .Select(str => new { Name = str, Count = a.Count(s => s == str) })
             .Where(obj => obj.Count > 1)
             .Distinct()
             .ToDictionary(obj => obj.Name, obj => obj.Count).Select(obj => $"{obj.Key} - {obj.Value}").ToArray();
            return result;
        }

        private void FindInDir(DirectoryInfo dir, bool recursive)
        {
            if (CountSearch >= 500) return;
            try
            {
                foreach (FileInfo file in dir.GetFiles())
                {
                    str += file.FullName + " ";
                    if (CountSearch >= 500) return;
                    CountSearch++;
                }
                if (recursive)
                {
                    foreach (DirectoryInfo subdir in dir.GetDirectories())
                    {
                        FindInDir(subdir, recursive);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
