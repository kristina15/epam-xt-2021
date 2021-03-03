using System;
using System.Text;

namespace Epam.Task1._2._1.AVERAGES
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("ВВОД: ");
            string str = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате";
            int count;
            string[] array = GetArray(str, out count);
            
            int sum = GetSumLength(array);

            Console.WriteLine($"Average length={sum / count}"); //возвращаю целое значение
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

        private static int GetSumLength(string[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (!string.IsNullOrEmpty(array[i]))
                {
                    sum += array[i].Length;
                }
            }

            return sum;
        }
    }
}
