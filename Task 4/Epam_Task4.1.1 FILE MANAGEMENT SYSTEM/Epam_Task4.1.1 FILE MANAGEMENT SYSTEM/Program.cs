using System;
using System.IO;

namespace Epam_Task4._1._1_FILE_MANAGEMENT_SYSTEM
{
    internal class Propgram
    {
        private static void Main()
        {
            Directory.CreateDirectory(ReserveObject._pathDict);
            Console.WriteLine("Select the program mode\r\n1.The observer mode\r\n2.Mode for undoing changes\r\nTo exit the program, click any button");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Observer mode enabled");
                    var reverser = new ReserveObject();
                    Console.WriteLine("Press 'q' to quit the sample.");
                    while (Console.Read() != 'q')
                    {
                    }
                    break;
                case "2":
                    ReserveObject.RollBackChanges();
                    break;
                default:
                    return;
            }
        }
    }
}
