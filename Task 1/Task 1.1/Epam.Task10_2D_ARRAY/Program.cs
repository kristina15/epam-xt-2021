using System;

namespace Epam.Task10_2D_ARRAY
{
    internal class Program
    {
        private static void Main()
        {
            int[,] array = new int[5, 6];
            Random random = new Random();
            int sum = 0;
            sum = GetSumOfEvenNumber(array, random, sum);

            Console.WriteLine($"sum={sum}");
        }

        private static int GetSumOfEvenNumber(int[,] array, Random random, int sum)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-10000, 10000);
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }

            return sum;

        }
    }
}
