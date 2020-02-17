using System;

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
            float xValue1 = rnd.Next(20);
            float xValue2 = rnd.Next(20);
            float xResult;
            float xResultNew;
            int xOperator = rnd.Next(4);
            if (xOperator == 0)
            {
                xResult = xValue1 + xValue2;
                xResultNew = Ifi(xResult);
                AnswerCorrect = (xResult == xResultNew);
                CodeText = String.Format("{0} + {1} = {2}", xValue1, xValue2, xResultNew);
            }
            else if (xOperator == 1)
            {
                xResult = xValue1 - xValue2;
                xResultNew = Ifi(xResult);
                CodeText = String.Format("{0} - {1} = {2}", xValue1, xValue2, xResultNew);
            }
            else if (xOperator == 2)
            {
                xResult = xValue1 / xValue2;
                xResultNew = Ifi(xResult);
                Console.Write(xResultNew);
                CodeText = String.Format("{0} / {1} = {2}", xValue1, xValue2, xResultNew);
            }
            else if (xOperator == 3)
            {
                xResult = xValue1 * xValue2;
                xResultNew = Ifi(xResult);
                CodeText = String.Format("{0} * {1} = {2}", xValue1, xValue2, xResultNew);
            }
            if (Change != null)
                Change(this, EventArgs.Empty);
        }

        public float Ifi(float xResult)
        {
            Random rnd = new Random();
            float xResultNew;
            float xSign;
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
            return (xResultNew);
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
