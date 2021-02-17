using System;

namespace Epam.Task5.SUM_OF_NUMBERS
{
    internal class Program
    {
        private static void Main()
        {
            int sum = 8;
            for (int i = 6; i < 1000; i++)
            {
                if (i % 15 == 0 || i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"sum={sum}");
        }
    }
}
