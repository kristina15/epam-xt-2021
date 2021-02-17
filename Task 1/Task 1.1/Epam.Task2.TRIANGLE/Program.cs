using System;
using System.Runtime.InteropServices;

namespace Epam.Task2.TRIANGLE
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            GetDrawing(n);
        }

        private static void GetDrawing(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int j = i;
                while (j > 0)
                {
                    Console.Write("*");
                    j--;
                }

                Console.WriteLine();
            }
        }
    }
}

