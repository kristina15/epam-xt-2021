using System;

namespace Epam.Task1._2._1.AVERAGES
{
    internal class Program
    {
        private static void Main()
        {
            string str = Console.ReadLine();
            string[] array = str.Split(new char[] { ' ', ',', '.', '?', '/', '-', ':', ';', '!' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = GetSumLength(array);

            Console.WriteLine($"Average length={sum / array.Length}"); //возвращаю целое значение
        }

        private static int GetSumLength(string[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i].Length;
            }

            return sum;
        }
    }
}
