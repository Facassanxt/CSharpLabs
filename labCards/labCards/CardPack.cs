using System;
using System.Linq;

namespace labCards
{
    internal class CardPack
    {
        private int Count { get; }
        private int[] arr;
        private Random rnd = new Random();

        public CardPack(int count)
        {
            Count = count;
            CardRandom();
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }
        }

        public void CardSord() => arr = Enumerable.Range(0, Count).ToArray();
        public void CardRandom() => arr = Enumerable.Range(0,Count).OrderBy( _ => rnd.Next()).ToArray();
    }
}