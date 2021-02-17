using System;

namespace Epam.Task4.X_MAS_TREE
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            for (int a = 1; a <= n; a++)
            {
                for (int i = 0; i < a; i++)
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
}

