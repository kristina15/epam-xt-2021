using System;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    public class Ring : Figure
    {
        private int x;
        private int y;
        private int externalRadius;
        private int internalRadius;

        public Ring()
        {
            x = 0;
            y = 0;
            externalRadius = 0;
            internalRadius = 0;
        }

        public Ring(int _x, int _y, int _externalRadius, int _internalRadius)
        {
            if (internalRadius > externalRadius)
            {
                throw new ArgumentException();
            }
            else
            {
                externalRadius = _externalRadius;
                internalRadius = _internalRadius;
                x = _x;
                y = _y;
            }
        }

        public double Area => Math.PI * (Math.Pow(externalRadius, 2) - Math.Pow(internalRadius, 2));

        public double LengthOfBigCircle => Math.PI * 2 * externalRadius;

        public double LengthOfSmallCircle => Math.PI * 2 * internalRadius;

        public override void Print()
        {
            Console.WriteLine($"Ring centered at the point ({x}, {y}), with an external radius {externalRadius}, internal radius = {internalRadius}, Area ~ {(int)Area}, length of big circle ~ {(int)LengthOfBigCircle}, length of small sircle ~ {(int)LengthOfSmallCircle}");
        }
    }
}
