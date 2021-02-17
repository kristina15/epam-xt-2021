using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            foreach (var item in masStr)
            {
                if(char.IsLower(item[0]))
                {
                    builder[0]=char.ToUpper(item[0]);
                }
            }
            string.Join(str, masStr);
            Console.WriteLine($"ВЫВОД: {str}"); 
        }
    }
}
