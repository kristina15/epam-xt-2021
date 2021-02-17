using System;

namespace Epam.Task9.NON_NEGATIVE_SUM
{
    internal class Program
    {
        private static void Main()
        {
            int[] mas = new int[20];
            Random random = new Random();
            int sum = 0;
            sum = GetSum(mas, random, sum);

            Console.WriteLine($"sum={sum}");
        }

        private static int GetSum(int[] mas, Random random, int sum)
        {
            for (int i = 0; i < 20; i++)
            {
                mas[i] = random.Next(-10000, 10000);
                if (mas[i] > 0)
                {
                    sum += mas[i];
                }
            }

            return sum;
        }
    }
}

