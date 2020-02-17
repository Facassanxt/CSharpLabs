using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTrainerAccount
{
    class Games
    {
        public int CountCorrect { get; protected set; }
        public int CountWrong { get; protected set; }
        public bool AnswerCorrect { get; protected set; }
        public string CodeText { get; protected set; }

        public event EventHandler Change;

        public void DoReset()
        {
            CountCorrect = 0;
            CountWrong = 0;
            DoContinue();
        }

        public void DoContinue()
        {
            Random rnd = new Random();
            int xValue1 = rnd.Next(20);
            int xValue2 = rnd.Next(20);
            int xResult = xValue1 + xValue2;
            int xResultNew;
            int xSign;
            if (rnd.Next(2) == 1)
            {
                xResultNew = xResult;
            }
            else
            {
                if (rnd.Next(2) == 1)
                    xSign = 1;
                else
                    xSign = -1;
                xResultNew = xResult + (rnd.Next(7) * xSign);
            }
            AnswerCorrect = (xResult == xResultNew);
            CodeText = String.Format("{0} + {1} = {2}", xValue1, xValue2, xResultNew);
            if (Change != null)
                Change(this, EventArgs.Empty);
        }

        public void DoAnswer(bool v)
        {
            if (v == AnswerCorrect)
                CountCorrect++;
            else
                CountWrong++;
            DoContinue();
        }
    }
}
