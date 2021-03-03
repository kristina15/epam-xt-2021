using System;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    public class Rectangle : Figure
    {
        private int a;
        private int b;

        public Rectangle(int _a, int _b)
        {
            a = _a;
            b = _b;
        }

        public int Area => a * b;

        public int Perimetr => 2 * (a + b);

        public override void Print()
        {
            Console.WriteLine($"Rectangle with sides a = {a}, b = {b}, Area = {Area} and Perimetr = {Perimetr}");
        }
    }
}
