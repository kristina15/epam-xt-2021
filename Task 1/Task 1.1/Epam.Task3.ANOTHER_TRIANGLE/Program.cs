using System;

namespace Epam.Task3.ANOTHER_TRIANGLE
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k <= n - 1 - i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = i * 2 + 1; j > 0; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
