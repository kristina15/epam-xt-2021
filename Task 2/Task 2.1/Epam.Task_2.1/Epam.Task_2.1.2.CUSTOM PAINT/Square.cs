using System;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    class Square:Figure
    {
        private int a;

        public Square(int _a)
        {
            a = _a;
        }

        public int Area => a * a;

        public int Perimetr => 4 * a;

        public override void Print()
        {
            Console.WriteLine($"Square with a side {a}, Area = {Area} and Perimetr = {Perimetr}");
        }
    }
}
