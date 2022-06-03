using Algorithm;
using Algorithms.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class HeapSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void MakeSort()
        {
            var heap = new Heap<T>(Items);
            var sorted = heap.Order();
            Items = sorted;
        }
    }
}
