using System;

namespace Epam.Task_3._2._1.DYNAMIC_ARRAY
{
    internal class Program
    {
        private static void Main()
        {
            DynamicArray<int> dynamicArray = new DynamicArray<int>();
            dynamicArray.Add(5);
            dynamicArray.Add(7);
            dynamicArray.Add(3);
            dynamicArray.Add(5);
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine($"\t{dynamicArray[i]}"); 
            }

            Console.WriteLine("\n");
            Console.WriteLine(dynamicArray.Length);
            dynamicArray.RemoveAt(-3);
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine($"\t{dynamicArray[i]}");
            }

            Console.WriteLine("\n");
            dynamicArray.Insert(4, -1);
            //dynamicArray.Insert(3, 6);
            dynamicArray.Insert(10, 4);
            //dynamicArray.Insert(7, 8);
            dynamicArray.Insert(2, 0);
            //dynamicArray.Insert(1, 10);
            dynamicArray.Capacity = 20;
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine($"\t{dynamicArray[i]}");
            }

            Console.WriteLine(dynamicArray.Capacity);
            var du = (DynamicArray<int>)dynamicArray.Clone();
            Console.WriteLine(du.Capacity);
            for (int i = 0; i < du.Length; i++)
            {
                Console.WriteLine($"\t{dynamicArray[i]}");
            }

            du.Capacity = 24;
            Console.WriteLine(du.Capacity);
            Console.WriteLine(dynamicArray.Capacity);
            Console.WriteLine("\n");
            foreach (var i in dynamicArray)
            {
                Console.WriteLine(i);
            }

            var circle = new CycledDynamicArray<int>(dynamicArray);
            foreach (var i in circle)
            {
                Console.WriteLine(i);
            }
        }
    }
}
