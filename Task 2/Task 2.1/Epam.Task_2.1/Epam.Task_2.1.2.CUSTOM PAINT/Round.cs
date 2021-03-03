using System;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    public class Round : Figure
    {
        private int x;
        private int y;
        private double radius;

        public Round(int _x, int _y, int _radius)
        {
            x = _x;
            y = _y;
            radius = _radius;
        }

        public int Area => (int)((int)Math.PI * Math.Pow(radius, 2));

        public override void Print()
        {
            Console.WriteLine($"Round centered at a point ({x}, {y}), Radius = {radius} and Area = {Area}");
        }
    }
}
