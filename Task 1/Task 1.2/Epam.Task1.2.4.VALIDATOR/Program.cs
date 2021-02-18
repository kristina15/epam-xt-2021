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

            string[] masStr = str.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder builder = new StringBuilder();
            int index = 0;
            foreach (var item in masStr)
            {
                builder.Append(item);
                for (int i = 0; i < item.Length; i++)
                {
                    if(char.IsLetter(item[i]) && char.IsLower(item[i]))
                    {
                        builder[index+i] = char.ToUpper(item[i]);
                        break;
                    }
                }

                index += item.Length;
                builder.Append(str[index]);
                index++;
            }

            Console.WriteLine($"ВЫВОД: {builder}");
        }
    }
}
