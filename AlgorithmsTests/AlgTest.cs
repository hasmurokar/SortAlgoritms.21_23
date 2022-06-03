using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms;

namespace Algorithm.Tests
{
    [TestClass()]
    public class AlgTest
    {
        Random rnd = new Random();
        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();
            for (int i = 0; i < 1000; i++)
            {
                Items.Add(rnd.Next(0, 100000));
            }

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void AlgorithmBaseTest()
        {
            // arrange
            var algorithm = new AlgorithmBase<int>();
            algorithm.Items.AddRange(Items);

            // act
            algorithm.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], algorithm.Items[i]);
            }
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            // arrange
            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(Items);

            // act
            bubble.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubble.Items[i]);
            }
        }

        [TestMethod()]
        public void CoktailSortTest()
        {
            // arrange
            var coktail = new CoktailSort<int>();
            coktail.Items.AddRange(Items);

            // act
            coktail.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], coktail.Items[i]);
            }
        }

        [TestMethod()]
        public void InsertionSortTest()
        {
            // arrange
            var insertion = new InsertionSort<int>();
            insertion.Items.AddRange(Items);

            // act
            insertion.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insertion.Items[i]);
            }
        }

        [TestMethod()]
        public void ShellSortTest()
        {
            // arrange
            var shell = new ShellSort<int>();
            shell.Items.AddRange(Items);

            // act
            shell.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shell.Items[i]);
            }
        }

        [TestMethod()]
        public void TreeSortTest()
        {
            // arrange
            var tree = new TreeSort<int>();
            tree.Items.AddRange(Items);

            // act
            tree.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], tree.Items[i]);
            }
        }

        [TestMethod()]
        public void HeapSortTest()
        {
            // arrange
            var heap = new HeapSort<int>();
            heap.Items.AddRange(Items);

            // act
            heap.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], heap.Items[i]);
            }
        }


        [TestMethod()]
        public void SelectionSortTest()
        {
            // arrange
            var selection = new SelectionSort<int>();
            selection.Items.AddRange(Items);

            // act
            selection.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], selection.Items[i]);
            }
        }

        [TestMethod()]
        public void RadixSortTest()
        {
            // arrange
            var radix = new RadixSort<int>();
            radix.Items.AddRange(Items);

            // act
            radix.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], radix.Items[i]);
            }
        }


        [TestMethod()]
        public void MergeSortTest()
        {
            // arrange
            var merge = new MergeSort<int>();
            merge.Items.AddRange(Items);

            // act
            merge.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], merge.Items[i]);
            }
        }


        [TestMethod()]
        public void QuickSortTest()
        {
            // arrange
            var quick = new QuickSort<int>();
            quick.Items.AddRange(Items);

            // act
            quick.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], quick.Items[i]);
            }
        }

    }
}