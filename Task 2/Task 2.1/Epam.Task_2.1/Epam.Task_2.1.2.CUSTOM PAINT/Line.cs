using System;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    class Line:Figure
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;

        public Line(int _x1, int _x2, int _y1, int _y2)
        {
            x1 = _x1;
            x2 = _x2;
            y1 = _y1;
            y2 = _y2;
        }

        public int Length => (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        public override void Print()
        {
            Console.WriteLine($"Line with origin at point ({x1}, {y1}) and with an end at the point ({x2}, {y2}) and Length = {0}", Length);
        }
    }
}
