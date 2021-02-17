using System;

namespace Epam.Task7.ARRAY_PROCESSING
{
    internal class Program
    {
        private static void Main()
        {
            int[] mas = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                mas[i] = random.Next(-1000, 1000);
            }

            QuickSort(mas);
            Output(mas);
        }

        private static void Output(int[] mas)
        {
            Console.WriteLine($"max={mas[9]}");
            Console.WriteLine($"min={mas[0]}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"mas[{i}]={mas[i]}");
            }
        }

        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
    }
}
