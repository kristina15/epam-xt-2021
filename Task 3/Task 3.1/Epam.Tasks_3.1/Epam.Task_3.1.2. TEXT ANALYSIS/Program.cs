using System;
using System.Collections.Generic;

namespace Epam.Task_3._1._2.TEXT_ANALYSIS
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите текст");
            Console.Write("ВВОД: ");
            string str = Console.ReadLine();
            Dictionary<string, int> pairs = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);
            string[] s = "I’m Greg. I’m nine. I hAVE got a nice red cat. It can jump and run. But I haven’t got a Greg dog, and I’m sad. This is Rob. He is three. He has got a little yellow fish! The fish is nice. It can swim. Rob is happy. This is Jillian. She has got four little kittens. Jillian is happy, too.".Split();

            str.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in s)
            {
                if (pairs.ContainsKey(item))
                {
                    pairs[item]++;
                }
                else
                {
                    pairs.Add(item, 1);
                }
            }

            foreach (var item in pairs)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
