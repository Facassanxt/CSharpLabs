using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labFileExplorer
{
    class History
    {
        private Dictionary<int, string> steps;

        public int Count { get; set; }
        public int CurrentStep = 0;

        public History()
        {
            steps = new Dictionary<int, string>();
        }

        public string this[int index] { get { return steps[index]; } }

        public void add(string dir, bool flag = true)
        {
            if (steps.ContainsKey(steps.Count())) return;
            Count = steps.Count();
            steps.Add(Count, dir);
            Debug.WriteLine($"LoadStep {dir} {CurrentStep} {Count}");
            if (flag)
                CurrentStep++;
        }

        public void DebugGetAllDictionary()
        {
            foreach (var item in steps)
            {
                Debug.WriteLine($"all {item.Key} {item.Value}");
            }
        }

        public string getFromHistory(int step)
        {
            if (!steps.ContainsKey(step))
            {
                Debug.WriteLine($"isn't have steps[{step}]");
                return null;
            }

            CurrentStep = step;
            Debug.WriteLine($"Get {steps[step]} CurrentStep: {CurrentStep}");
            return steps[step];
        }

        public void deleteFromHistory(int step)
        {
            if (!steps.ContainsKey(step))
            {
                Debug.WriteLine($"isn't have steps[{step}]");
                return;
            }

            steps.Remove(step);
        }
    }
}
