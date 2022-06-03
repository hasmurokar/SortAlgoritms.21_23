using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class RadixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void MakeSort()
        {
            var groups = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            int lenght = GetMaxLenght();

            for (int step = 0; step < lenght; step++)
            {
                //Распределение элементов по корзинам.
                foreach (var item in Items)
                {
                    var i = item.GetHashCode();
                    var value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                    groups[value].Add(item);
                }

                Items.Clear();

                // Сборка элементов
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Items.Add(item);
                    }
                }

                // Очистка корзин
                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
        }

        private int GetMaxLenght()
        {
            var lenght = 0;
            foreach (var item in Items)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Ошибка. Тут только числа равно или больше нуля");
                }

                var l = Convert.ToInt32(Math.Log10(item.GetHashCode() + 1));
                if (l > lenght)
                {
                    lenght = l;
                }
            }
            return lenght;
        }
    }
}

