using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    internal class Program
    {
        private static void Main()
        {
            Figure[] figures = new Figure[5];
            figures[0] = new Line(1, 2, 5, 6);
            figures[1] = new Circle(0, 0, 4);
            figures[2] = new Rectangle(2, 4);
            figures[3] = new Round(0, 0, 4);
            figures[4] = new Ring(0, 0, 3, 2);
            for (int i = 0; i < 5; i++)
            {
                figures[i].Print();
            }
        }
    }
}
