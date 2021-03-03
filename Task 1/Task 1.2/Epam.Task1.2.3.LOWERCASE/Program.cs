using System;

namespace Epam.Task1._2._3.LOWERCASE
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("ВВОД: ");
            string str = Console.ReadLine();

            int count;
            string[] masStr = GetArray(str, out count);
            int counter = 0;
            foreach (var item in masStr)
            {
                if (!string.IsNullOrEmpty(item) && char.IsLower(item[0]) )
                {
                    counter++;
                }
            }

            Console.WriteLine($"ВЫВОД: {counter}");
            
        }

        private static string[] GetArray(string str, out int j)
        {
            string[] array = new string[(str.Length / 2) + 1];
            int k = 0;
            j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsPunctuation(str[i]) || char.IsWhiteSpace(str[i]) || i == str.Length - 1)
                {
                    if (i == str.Length - 1)
                    {
                        array[j] = str.Substring(k, i - k + 1);
                    }
                    else
                    {
                        array[j] = str.Substring(k, i - k);
                    }

                    while (char.IsPunctuation(str[i]) || char.IsWhiteSpace(str[i]))
                    {
                        i++;
                        k = i;
                    }

                    j++;
                }
            }

            return array;
        }

    }
}
