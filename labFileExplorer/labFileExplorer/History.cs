using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace labFileExplorer
{
    class History
    {
        private Dictionary<int, string> steps;
        public string this[int index] { get { return steps[index]; } }
        public int Count { get; set; }
        public int CurrentStep = 0;
        public History()
        {
            steps = new Dictionary<int, string>();
        }
        public void add(string dir, bool flag = true)
        {
            if (steps.ContainsKey(steps.Count())) return;
            Count = steps.Count();
            steps.Add(Count, dir);
            if (flag) CurrentStep++;
        }
        public string getFromHistory(int step)
        {
            if (!steps.ContainsKey(step)) return null;
            CurrentStep = step;
            Debug.WriteLine($"Get {steps[step]} CurrentStep: {CurrentStep}");
            return steps[step];
        }
        public void deleteFromHistory(int step)
        {
            if (!steps.ContainsKey(step)) return;
            steps.Remove(step);
        }
    }
}
