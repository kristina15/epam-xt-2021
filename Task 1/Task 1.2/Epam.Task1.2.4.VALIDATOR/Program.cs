using System;
using System.Text;

namespace Epam.Task1._2._4.VALIDATOR
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("ВВОД: ");
            string str = Console.ReadLine();

            string[] masStr = GetArray(str);
            StringBuilder builder = new StringBuilder();
            int index = 0;
            foreach (var item in masStr)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    builder.Append(item);
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (char.IsLetter(item[i]) && char.IsLower(item[i]))
                        {
                            builder[index + i] = char.ToUpper(item[i]);
                            break;
                        }
                    }

                    index += item.Length;
                    builder.Append(str[index]);
                    index++;
                }
            }

            Console.WriteLine($"ВЫВОД: {builder}");
        }

        private static string[] GetArray(string str)
        {
            string[] array = new string[(str.Length / 2) + 1];
            int k = 0;
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]=='?' || str[i] == '!' || str[i] == '.')
                {
                    array[j] = str.Substring(k, i - k);
                    k = i + 1;
                    j++;
                }
            }

            return array;
        }
    }
}
