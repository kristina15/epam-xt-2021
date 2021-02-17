using System;

namespace Epam.Task1._2._3.LOWERCASE
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("ВВОД: ");
            string str = Console.ReadLine();

            string[] masStr = str.Split(new char[] { ' ', ',', '.', '?', '/', '-', ':', ';', '!' }, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;
            foreach (var item in masStr)
            {
                if (char.IsLower(item[0]))
                {
                    counter++;
                }
            }

            Console.WriteLine($"ВЫВОД: {counter}");
            
        }
    }
}
