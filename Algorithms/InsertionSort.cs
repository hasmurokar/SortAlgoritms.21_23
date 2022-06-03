﻿using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class InsertionSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void MakeSort()
        {
            for (int i = 1; i < Items.Count; i++)
            {
                var temp = Items[i];
                var j = i;

                // Выполняется, пока левый временный эл-нт меньше, чем эл-нт в отсортированной коллекции
                while (j > 0 && temp.CompareTo(Items[j - 1]) == -1)
                {
                    Items[j] = Items[j - 1];
                    j--;
                }
                Items[j] = temp;
            }
        }
    }
}
