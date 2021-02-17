using System;
using System.Linq;
using System.Text;

namespace Epam.Task1._2._2.DOUBLER
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Введите первую строку: ");
            string str1 = Console.ReadLine();

            Console.Write("Введите вторую строку: ");
            string str2 = Console.ReadLine();

            StringBuilder strBuilder = new StringBuilder();
            GetDoubleChar(str1, str2, strBuilder);

            Console.WriteLine($"Результирующая строка: {strBuilder}");
        }

        private static void GetDoubleChar(string str1, string str2, StringBuilder strBuilder)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str2.Contains(str1[i]))
                {
                    strBuilder.Append(str1[i]);
                }

                strBuilder.Append(str1[i]);
            }
        }
    }
}

