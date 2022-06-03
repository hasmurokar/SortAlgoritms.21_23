using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public int SwopCount { get; protected set; } = 0;
        public int CompareCount { get; protected set; } = 0;
        public List<T> Items { get; set; } = new List<T>();

        protected void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;

                SwopCount++;
            }
        }

        public virtual void MakeSort()
        {
            Items.Sort();
        }

        protected int Compare(T a, T b)
        {
            return a.CompareTo(b);
        }
    }
}
