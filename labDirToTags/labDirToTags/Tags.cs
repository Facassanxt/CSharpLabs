using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            str = null;
            CountSearchTags = 0;
            CountSearch = 0;
            DirectoryInfo directoryInfo = new DirectoryInfo(dir);
            FindInDir(directoryInfo, true, dir);
            str = str.Remove(str.Length-1);
            var a = str.Split(new string[] { " ", "\\", "«", "»", "(", ")","  ",","}, StringSplitOptions.None).ToArray();
            var result = a
             .Select(str => new { Name = str, Count = a.Count(s => s == str) })
             .Where(obj => obj.Count > 1 && obj.Name.Length > 1)
             .Distinct()
             .ToDictionary(obj => obj.Name, obj => obj.Count)
             .OrderByDescending(obj => obj.Value)
             .Select(obj => $"{obj.Key} - {obj.Value}")
             .ToArray();
            CountSearchTags = result.Length;
            return result;
        }

        private void FindInDir(DirectoryInfo dir, bool recursive, string spl)
        {
            if (CountSearch >= 2500) return;
            try
            {
                foreach (FileInfo file in dir.GetFiles())
                {
                    str += file.FullName.Substring(spl.Length).TrimStart('\\').Replace("\\"," ").Replace(file.Extension,"") + " ";
                    if (CountSearch >= 2500) return;
                    CountSearch++;
                }
                if (recursive)
                {
                    foreach (DirectoryInfo subdir in dir.GetDirectories())
                    {
                        FindInDir(subdir, recursive, spl);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
