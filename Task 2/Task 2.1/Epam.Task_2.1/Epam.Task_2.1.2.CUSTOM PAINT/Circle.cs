using System;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    internal class Circle : Figure
    {
        private int x;
        private int y;
        private int radius;

        public Circle(int _x, int _y, int _radius)
        {
            x = _x;
            y = _y;
            radius = _radius;
        }

        public int Length => (int)(2 * Math.PI * radius);

        public override void Print()
        {
            Console.WriteLine($"Circle centered at a point ({x}, {y}), Radius = {radius} and Length = {Length}");
        }
    }
}
