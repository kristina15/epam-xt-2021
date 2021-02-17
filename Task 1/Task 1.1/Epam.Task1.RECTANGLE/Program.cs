using System;

namespace Epam.Task1.RECTANGLE
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            if(a<=0)
            {
                throw new ArgumentException("Uncorrect agrgument");
            }

            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            if(b<=0)
            {
                throw new ArgumentException("Uncorrect agrgument");
            }

            Console.WriteLine($"{a * b}");
        }
    }
}
